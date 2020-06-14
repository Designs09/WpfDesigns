using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dna.FrameworkDI;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// Helper methods for getting and working with web routes
    /// </summary>
    public static class RouteHelpers
    {
        /// <summary>
        /// Host URL of fasetto word server
        /// </summary>
        public static string Host = Configuration["FasettoWordServer:HostUrl"];

        /// <summary>
        /// Converts a relative URL into an absolute URL
        /// </summary>
        /// <param name="relativeUrl">The relative URL</param>
        /// <returns>Returns the absolute URL including the Host URL</returns>
        public static string GetAbsoluteRoute(string relativeUrl)
        {
            // Get the host
            var host = Host;

            // If no relative url passed...
            if (string.IsNullOrEmpty(relativeUrl))
                return host;

            // If the relative Url does not start with /...
            if (!relativeUrl.StartsWith("/"))
                // Add the slash
                relativeUrl = $"/{relativeUrl}";

            // Return combined URL
            return host + relativeUrl;
        }
    }
}
