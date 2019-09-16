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
        StartProcess("git", "push origin master");
        StartProcess("git", "remote add public https://github.com/kingstonrichard/kingstonrichard.github.io");
        StartProcess("git", "subtree split --prefix output -b public");
        StartProcess("git", "checkout public");
        StartProcess("git", "push -f public public:master");
        StartProcess("git", "checkout master");
        StartProcess("git", "branch -D public");
        StartProcess("git", "remote remove public");
    });

RunTarget(target);