#tool "nuget:?package=Wyam&version=2.2.7"
#addin "nuget:?package=Cake.Wyam&version=2.2.7"

var target = Argument("target", "Build");

Task("Build")
    .Does(() =>
    {
        Wyam();
    });

Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Preview = true,
            Watch = true
        });
    });

Task("Deploy")
    .IsDependentOn("Build")
    .Does(() => 
    {
        StartProcess("git", "remote add ghpages https://github.com/kingstonrichard/kingstonrichard.github.io");
        StartProcess("git", "subtree split --prefix output -b public");
        StartProcess("git", "checkout public");
        StartProcess("git", "push -f public ghpages:master");
        StartProcess("git", "checkout master");
        StartProcess("git", "branch -D public");
        StartProcess("git", "remote remove ghpages");
    });

RunTarget(target);