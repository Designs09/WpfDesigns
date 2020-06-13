namespace Fasetto.Word.Core
{
    /// <summary>
    /// The response for all Web API calls made
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResponse
    {
        #region Public Properties

        /// <summary>
        /// Indicates if the API call was successful
        /// </summary>
        public bool Successful => ErrorMessage == null;

        /// <summary>
        /// The error message for a failed API call
        /// </summary>
        public string ErrorMessage { get; set; }

        #endregion
    }

    /// <summary>
    /// The response for all Web API calls made
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResponse<T> : ApiResponse
    {
        #region Public Properties

        /// <summary>
        /// The API response object
        /// </summary>
        public T Response { get; set; }

        #endregion
    }
}
