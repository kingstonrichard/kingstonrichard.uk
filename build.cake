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
        StartProcess("git", "subtree split --prefix output -b public");
        StartProcess("git", "checkout public");
        
        StartProcess("git", "add .");
        StartProcess("git", "commit -m \"Publishing output folder to public repository\"");
        
        StartProcess("git", "remote add public https://github.com/kingstonrichard/kingstonrichard.github.io");
        StartProcess("git", "push -f public public:master");
        
        StartProcess("git", "remote remove public");
        
        StartProcess("git", "checkout master");
        StartProcess("git", "branch -D public");
    });

RunTarget(target);