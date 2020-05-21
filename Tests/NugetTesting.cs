using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnetTestsGeneral
{
    [TestClass]
    public class NugetTesting
    {
        [TestMethod]
        public void GetAllNugetRepositories()
        {
            var userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var settings = new NuGet.Configuration.Settings(root: userProfilePath);
            var sourceProvider = new NuGet.Configuration.PackageSourceProvider(settings);

            var repositories = sourceProvider.LoadPackageSources();
        }
    }
}
