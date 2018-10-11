using System;
using System.IO;
using System.Reflection;

namespace Utilities
{
    public static class ApplicationExtensions
    {
        /// <summary>
        /// Determines the local file system folder from which an application is running.
        /// </summary>
        /// <returns></returns>
        public static string ExecutableDirectoryPath()
        {
            var codeBase = new Uri(Assembly.GetExecutingAssembly().GetName().CodeBase);
            var localCodeBase = codeBase.LocalPath;
            var basePath = Path.GetDirectoryName(localCodeBase);
            return basePath;
        }
    }
}
