# README
+ Alot of information was gained from reading [this](https://daveaglick.com/posts/exploring-the-nuget-v3-libraries-part-2) article.  It covers how to search nuget packages with the API.
+ I first used [roslynpad](https://github.com/aelij/RoslynPad) to determine how to do this since it does a really good job.
    + I specifically focused on the code at these places
        + [DocumentView.xaml](https://github.com/aelij/RoslynPad/blob/master/src/RoslynPad/DocumentView.xaml)
            + Search for `<MenuItem Name="RootNuGetMenu"`
            + Search for `<TextBox Name="NuGetSearch"`
        + [NuGetViewModel.cs](https://github.com/aelij/RoslynPad/blob/master/src/RoslynPad.Common.UI/ViewModels/NuGetViewModel.cs)
            + Search for `var sourceProvider = new PackageSourceProvider(settings);`
            + Search for `var searchResults = await searchResource.SearchAsync(`
