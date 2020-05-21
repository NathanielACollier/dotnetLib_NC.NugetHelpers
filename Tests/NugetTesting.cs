using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace dotnetTestsGeneral
{
    [TestClass]
    public class NugetTesting
    {
        [TestMethod]
        public void GetAllNugetRepositories()
        {
            var sources = NC.NugetHelpers.Utility.GetPackageSources();

            Assert.IsTrue(sources.Count() > 0);
        }
    }
}
