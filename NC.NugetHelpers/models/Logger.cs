using System;
using System.Threading.Tasks;
using NuGet.Common;

namespace NC.NugetHelpers.models
{
    public class Logger : NuGet.Common.ILogger
    {
        public void LogDebug(string data) => System.Diagnostics.Debug.WriteLine( $"DEBUG: {data}");
        public void LogVerbose(string data) => System.Diagnostics.Debug.WriteLine( $"VERBOSE: {data}");
        public void LogInformation(string data) => System.Diagnostics.Debug.WriteLine( $"INFORMATION: {data}");
        public void LogMinimal(string data) => System.Diagnostics.Debug.WriteLine( $"MINIMAL: {data}");
        public void LogWarning(string data) => System.Diagnostics.Debug.WriteLine( $"WARNING: {data}");
        public void LogError(string data) => System.Diagnostics.Debug.WriteLine( $"ERROR: {data}");
        public void LogSummary(string data) => System.Diagnostics.Debug.WriteLine( $"SUMMARY: {data}");
    }
}
