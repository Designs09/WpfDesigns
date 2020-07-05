func @_Fasetto.Word.Web.Server.JwtTokenExtensions.GenerateJwtToken$Fasetto.Word.Web.Server.ApplicationUser$(none) -> none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :19 :8) {
^entry (%_user : none):
%0 = cbde.alloca none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :19 :46)
cbde.store %_user, %0 : memref<none> loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :19 :46)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :22 :25) // new[]              {                  // Unique ID for the token                  new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),                    // The username using the Identity name so it fills out the HttpContext.User.Identity.Name value                  new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName),                    // Add user Id so that UserManager.GetUserAsync can find the user based on Id                  new Claim(ClaimTypes.NameIdentifier, user.Id),              } (ImplicitArrayCreationExpression)
// Entity from another assembly: JwtRegisteredClaimNames
%2 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :25 :26) // JwtRegisteredClaimNames.Jti (SimpleMemberAccessExpression)
// Entity from another assembly: Guid
%3 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :25 :55) // Guid.NewGuid() (InvocationExpression)
%4 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :25 :79) // "N" (StringLiteralExpression)
%5 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :25 :55) // Guid.NewGuid().ToString("N") (InvocationExpression)
%6 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :25 :16) // new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")) (ObjectCreationExpression)
// Entity from another assembly: ClaimsIdentity
%7 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :28 :26) // ClaimsIdentity.DefaultNameClaimType (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :28 :63) // Not a variable of known type: user
%9 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :28 :63) // user.UserName (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :28 :16) // new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName) (ObjectCreationExpression)
// Entity from another assembly: ClaimTypes
%11 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :31 :26) // ClaimTypes.NameIdentifier (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :31 :53) // Not a variable of known type: user
%13 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :31 :53) // user.Id (SimpleMemberAccessExpression)
%14 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :31 :16) // new Claim(ClaimTypes.NameIdentifier, user.Id) (ObjectCreationExpression)
// Entity from another assembly: Encoding
%16 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :37 :41) // Encoding.UTF8 (SimpleMemberAccessExpression)
// Entity from another assembly: Framework
%17 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :37 :64) // Framework.Construction (SimpleMemberAccessExpression)
%18 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :37 :64) // Framework.Construction.Configuration (SimpleMemberAccessExpression)
%19 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :37 :101) // "Jwt:SecretKey" (StringLiteralExpression)
%20 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :37 :64) // Framework.Construction.Configuration["Jwt:SecretKey"] (ElementAccessExpression)
%21 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :37 :41) // Encoding.UTF8.GetBytes(Framework.Construction.Configuration["Jwt:SecretKey"]) (InvocationExpression)
%22 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :37 :16) // new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Framework.Construction.Configuration["Jwt:SecretKey"])) (ObjectCreationExpression)
// Entity from another assembly: SecurityAlgorithms
%23 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :39 :16) // SecurityAlgorithms.HmacSha256 (SimpleMemberAccessExpression)
%24 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :35 :30) // new SigningCredentials(                  // Get the secret key from configuration                  new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Framework.Construction.Configuration["Jwt:SecretKey"])),                  // Use HS256 algorithm                  SecurityAlgorithms.HmacSha256) (ObjectCreationExpression)
// Entity from another assembly: Framework
%26 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :43 :24) // Framework.Construction (SimpleMemberAccessExpression)
%27 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :43 :24) // Framework.Construction.Configuration (SimpleMemberAccessExpression)
%28 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :43 :61) // "Jwt:Issuer" (StringLiteralExpression)
%29 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :43 :24) // Framework.Construction.Configuration["Jwt:Issuer"] (ElementAccessExpression)
// Entity from another assembly: Framework
%30 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :44 :26) // Framework.Construction (SimpleMemberAccessExpression)
%31 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :44 :26) // Framework.Construction.Configuration (SimpleMemberAccessExpression)
%32 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :44 :63) // "Jwt:Audience" (StringLiteralExpression)
%33 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :44 :26) // Framework.Construction.Configuration["Jwt:Audience"] (ElementAccessExpression)
%34 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :45 :24) // Not a variable of known type: claims
%35 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :46 :36) // Not a variable of known type: credentials
// Entity from another assembly: DateTime
%36 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :48 :25) // DateTime.Now (SimpleMemberAccessExpression)
%37 = constant 3 : i32 loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :48 :48)
%38 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :48 :25) // DateTime.Now.AddMonths(3) (InvocationExpression)
%39 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :42 :24) // new JwtSecurityToken(                  issuer: Framework.Construction.Configuration["Jwt:Issuer"],                  audience: Framework.Construction.Configuration["Jwt:Audience"],                  claims: claims,                  signingCredentials: credentials,                  // Expire if not used for 3 months                  expires: DateTime.Now.AddMonths(3)                  ) (ObjectCreationExpression)
%41 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :52 :19) // new JwtSecurityTokenHandler() (ObjectCreationExpression)
%42 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :52 :60) // Not a variable of known type: token
%43 = cbde.unknown : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :52 :19) // new JwtSecurityTokenHandler().WriteToken(token) (InvocationExpression)
return %43 : none loc("J:\\Designs09\\WpfDesigns\\src\\Fasetto.Word\\Fasetto.Word.Web.Server\\Authentication\\JwtTokenExtensions.cs" :52 :12)

^1: // ExitBlock
cbde.unreachable

}
