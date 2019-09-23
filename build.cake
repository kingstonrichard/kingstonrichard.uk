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
        if(FileExists("./CNAME"))
            CopyFile("./CNAME", "./output/CNAME");

        StartProcess("git", "add .");
        StartProcess("git", "commit -m \"Checking in master prior to publish\"");
        StartProcess("git", "push origin master");
                
        /*StartProcess("git", "subtree split --prefix output -b public");
        StartProcess("git", "checkout public");
        StartProcess("git", "remote add public https://github.com/kingstonrichard/kingstonrichard.github.io");
        StartProcess("git", "push -f public master");
        StartProcess("git", "remote remove public");
        StartProcess("git", "checkout master");
        StartProcess("git", "branch -D public");
*/
    });

RunTarget(target);