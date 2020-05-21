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


        [TestMethod]
        public async Task SearchForAPackage(){
            var topNuget = NC.NugetHelpers.Utility.GetPackageSources().First();

            var source = new NuGet.Protocol.Core.Types.SourceRepository(source: topNuget, 
                                providers: NuGet.Protocol.Core.Types.Repository.Provider.GetCoreV3()
                        );
            var packageSearchResource = await source.GetResourceAsync<NuGet.Protocol.Core.Types.PackageSearchResource>();
            var resullts = await packageSearchResource.SearchAsync(searchTerm: "newtonsoft",
                                        filters: new NuGet.Protocol.Core.Types.SearchFilter(),
                                        skip: 0,
                                        take: 5,
                                        log: )
        }
    }
}
