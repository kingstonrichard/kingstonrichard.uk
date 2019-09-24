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
        // Check in the regenerated output - we'll need this next
        StartProcess("git", "add .");
        StartProcess("git", "commit -m \"Regenerated output at " + DateTime.Now + "\"");
        StartProcess("git", "push origin master");
        
        // Extract the output local folder and check it into a "public" branch
        StartProcess("git", "subtree split --prefix output -b public");
        StartProcess("git", "checkout public");
        
        // Push the public branch to the "public" repository
        // Note: Make sure a remote respository is added named "public"
        StartProcess("git", "push -f public public:master");
        
        // Tidy up by removing the public branch and public repository 
        StartProcess("git", "checkout master");
        StartProcess("git", "branch -D public");
    });

RunTarget(target);