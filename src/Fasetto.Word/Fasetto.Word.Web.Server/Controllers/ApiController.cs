using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Dna;
using Fasetto.Word.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Fasetto.Word.Web.Server
{
    /// <summary>
    /// Manages the web API calls
    /// </summary>
    public class ApiController : Controller
    {
        #region Proceted Members

        /// <summary>
        /// The scoped Application context
        /// </summary>
        protected ApplicationDbContext mContext;

        /// <summary>
        /// The manager for handling user creation, deletion, searching, roles etc...
        /// </summary>
        protected UserManager<ApplicationUser> mUserManager;

        /// <summary>
        /// The manager for handling signing in and out for our users
        /// </summary>
        protected SignInManager<ApplicationUser> mSignInManager;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="context">The injected context</param>
        /// <param name="userManager">The Identity sign in manager</param>
        /// <param name="signInManager">The Identity user manager</param>
        public ApiController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            mContext = context;
            mUserManager = userManager;
            mSignInManager = signInManager;
        }

        #endregion

        /// <summary>
        /// Tries to register for a new account on the server
        /// </summary>
        /// <param name="registerCredentials">The registration details</param>
        /// <returns>Returns the result of the register request</returns>
        [Route("api/register")]
        public async Task<ApiResponse<RegisterResultApiModel>> RegisterAsync([FromBody] RegisterCredentialsApiModel registerCredentials)
        {
            // TODO: Localize all strings
            // The message when we failed to login
            var invalidErrorMessage = "Please provide all required details to register for an account";

            // The error response for a failed login
            var errorResponse = new ApiResponse<RegisterResultApiModel>
            {
                // Set error message
                ErrorMessage = invalidErrorMessage,
            };

            // Make sure we have a register credentials
            if (registerCredentials == null)
                // Return error message to user
                return errorResponse;

            // Make sure we have a user name
            if (string.IsNullOrWhiteSpace(registerCredentials.Username))
                // Return error message to user
                return errorResponse;

            // Create the desired user from the given details
            var user = new ApplicationUser
            {
                UserName = registerCredentials?.Username,
                FirstName = registerCredentials?.FirstName,
                LastName = registerCredentials?.LastName,
                Email = registerCredentials?.Email,
            };

            // Try and create a user
            var result = await mUserManager.CreateAsync(user, registerCredentials.Password);

            // If the registration was successful...
            if (result.Succeeded)
            {
                // Get the user details
                var userIdentity = await mUserManager.FindByNameAsync(registerCredentials.Username);

                // Generate an email verification code
                var emailVerificationCode = await mUserManager.GenerateEmailConfirmationTokenAsync(user);

                // TODO: Email the user the verfication code

                // Returns valid response containing all users details
                return new ApiResponse<RegisterResultApiModel>
                {
                    Response = new RegisterResultApiModel
                    {
                        FirstName = userIdentity.FirstName,
                        LastName = userIdentity.LastName,
                        Email = userIdentity.Email,
                        Username = userIdentity.UserName,
                        Token = userIdentity.GenerateJwtToken(),
                    },
                };
            }
            // Otherwise if it failed...
            else
                // Return the failed response
                return new ApiResponse<RegisterResultApiModel>
                {
                    // Aggregate all errors into a single error string
                    ErrorMessage = result.Errors?.ToList()
                        .Select(f => f.Description)
                        .Aggregate((a, b) => $"{a}{Environment.NewLine}{b}"),
                };
        }

        [Route("api/login")]
        public async Task<ApiResponse<LoginResultApiModel>> LogInAsync([FromBody] LoginCredentialsApiModel loginCreadentials)
        {
            // TODO: Localize all strings
            // The message when we failed to login
            var invalidErrorMessage = "Invalid username or password";

            // The error response for a failed login
            var errorResponse = new ApiResponse<LoginResultApiModel>
            {
                // Set error message
                ErrorMessage = invalidErrorMessage,
            };

            // Make sure we have a user name
            if (loginCreadentials?.UsernameOrEmail == null || string.IsNullOrWhiteSpace(loginCreadentials.UsernameOrEmail))
                // Return error message to user
                return errorResponse;

            // Validate if the user credentials are correct

                // If it an email?
            var isEmail = loginCreadentials.UsernameOrEmail.Contains("@");

            // Get the user details
            var user = isEmail ?
                // Find by Email
                await mUserManager.FindByEmailAsync(loginCreadentials.UsernameOrEmail) :
                // Find by username
                await mUserManager.FindByNameAsync(loginCreadentials.UsernameOrEmail); 

            // If we failed to find the user
            if (user == null)
                // Return error message to user
                return errorResponse;

            // If we got here we have a user...
            // Let's validate the password
            var isValidPassword = await mUserManager.CheckPasswordAsync(user, loginCreadentials.Password);
            
            // If the password was wrong
            if (!isValidPassword)
                // Return error message to user
                return errorResponse;

            // If we get here, we are valid and the user passed the correct login details

            // Return token to user
            return new ApiResponse<LoginResultApiModel>
            {
                // Pass back the user details and the token
                Response = new LoginResultApiModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Username = user.UserName,
                    Token = user.GenerateJwtToken(),
                }
            };
        }

        [Route("create")]
        public async Task<IActionResult> CreateUserAsync()
        {
            var result = await mUserManager.CreateAsync(new ApplicationUser
            {
                UserName = "angelsix",
                Email = "contact@angelsix.com",
                FirstName = "Luke",
                LastName = "Malpass",
            }, "password");

            if (result.Succeeded)
                return Content("User was created", "text/html");

            return Content("User creation failed", "text/html");
        }
    }
}
