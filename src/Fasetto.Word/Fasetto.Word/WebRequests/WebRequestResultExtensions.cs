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
        /// <param name="result">The response to check</param>
        /// <param name="title">The title of the error dialog if there is an error</param>
        /// <returns>Returns true if there was an error, or false if all was Ok</returns>
        public static async Task<bool> DisplayErrorIfFailedAsync<T>(this WebRequestResult<ApiResponse<T>> result, string title)
        {
            // If there was no respones, bad data, or a response with a error message...
            if (result == null || result.ServerResponse == null || !result.ServerResponse.Successful)
            {
                // Default error message
                var message = "Unknow error from server call";

                // If we got response from the server...
                if (result?.ServerResponse != null)
                    // Set message to servers response
                    message = result.ServerResponse.ErrorMessage;
                // If we have a result but deserialize failed...
                else if (!string.IsNullOrWhiteSpace(result?.RawServerResponse))
                    // Set error message
                    message = $"Unexcepted response from server. {result.RawServerResponse}";
                // If we have no result at all
                else if (result != null)
                    // Set message to standard HTTP server response details
                    message = $"Failed to communicate with server. Status code {result.StatusCode}. {result.StatusDescription}";

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
