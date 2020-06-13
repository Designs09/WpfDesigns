using Dna;
using Fasetto.Word.Core;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    /// <summary>
    /// Extension methods for the <see cref="ApiResponse{T}"/> class
    /// </summary>
    public static class WebRequestResultExtensions
    {
        /// <summary>
        /// Checks the web request result for any errors, display them if there are any
        /// </summary>
        /// <typeparam name="T">The type of API Response</typeparam>
        /// <param name="response">The response to check</param>
        /// <param name="title">The title of the error dialog if there is an error</param>
        /// <returns>Returns true if there was an error, or false if all was Ok</returns>
        public static async Task<bool> DisplayErrorIfFailedAsync(this WebRequestResult response, string title)
        {
            // If there was no respones, bad data, or a response with a error message...
            if (response == null || response.ServerResponse == null || (response.ServerResponse as ApiResponse)?.Successful == false)
            {
                // Default error message
                // TODO: Localize strings
                var message = "Unknow error from server call";

                // If we got response from the server...
                if (response?.ServerResponse is ApiResponse apiResponse)
                    // Set message to servers response
                    message = apiResponse.ErrorMessage;
                // If we have a result but deserialize failed...
                else if (!string.IsNullOrWhiteSpace(response?.RawServerResponse))
                    // Set error message
                    message = $"Unexcepted response from server. {response.RawServerResponse}";
                // If we have no result at all
                else if (response != null)
                    // Set message to standard HTTP server response details
                    message = response.ErrorMessage ?? $"{response.StatusDescription} ({response.StatusCode})";

                // Display error
                await DI.UI.ShowMessage(new MessageBoxDialogViewModel
                {
                    // TODO: Localize strings
                    Title = title,
                    Message = message,
                });

                // Returns that we had an error
                return true;
            }

            // All was Ok, so return false for no error
            return false;
        }
    }
}
