using System;
using System.Collections.Generic;

namespace NC.NugetHelpers
{
    public static class Utility
    {
        public static IEnumerable<NuGet.Configuration.PackageSource> GetPackageSources(){
            var userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var settings = new NuGet.Configuration.Settings(root: userProfilePath);
            var sourceProvider = new NuGet.Configuration.PackageSourceProvider(settings);

            var repositories = sourceProvider.LoadPackageSources();

            return repositories;
        }


    }
}