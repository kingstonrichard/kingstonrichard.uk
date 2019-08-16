#addin "Cake.Powershell"

var buildtarget = Argument("target", "Default");

Task("Default")
    .Does(() => 
    {
        StartProcess("git", "push origin master");
        StartProcess("git", "remote add public https://github.com/kingstonrichard/kingstonrichard.github.io");
        StartProcess("git", "subtree split --prefix output -b public");
        StartProcess("git", "checkout public");
        StartProcess("git", "pull public master");
        StartProcess("git", "push -f public public:master");
        StartProcess("git", "checkout master");
        StartProcess("git", "branch -D public");
        StartProcess("git", "remote remove public");
    });

RunTarget(buildtarget);