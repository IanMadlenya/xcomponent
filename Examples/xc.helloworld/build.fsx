// include Fake lib
#r @"../packages/FAKE/tools/FakeLib.dll"
#r "System.Xml.Linq"

open Fake
open Fake.XMLHelper
open System
open System.Text.RegularExpressions
open System.IO
open System.Xml.Linq
open System.Text

// parameters and constants definition
let buildDir = "./build/"
let buildClientAppDir = Path.Combine(buildDir, "consoleApp")
let generatedDir = "./helloworld/generated/"
let exportDir = Path.Combine(buildDir, "exportMicroservice")
let studioScriptPath = "./xcstudio.cmd"
let startMicroserviceScriptPath = Path.Combine(buildDir, "startMicroservice.cmd")
let startConsoleAppScriptPath = Path.Combine(buildDir, "startConsoleApp.cmd")
let xctools = "../packages/xcomponent.community/tools/XCStudio\XCTools/XComponent.XCTools.exe"
let timeoutExec = 5.0


Target "Clean" (fun _ ->
    trace "Cleaning..."
    CleanDir buildDir
    CleanDir generatedDir
    CleanDir exportDir
    DeleteFile studioScriptPath

    !! "./**/*.csproj"
    |> MSBuildRelease "" "Clean"
    |> Log "MSBuild clean Output: "
)

Target "Compile" (fun _ ->    
    trace ("Compiling XComponent project")

    let result = ExecProcess (fun info ->
                    info.FileName <- xctools
                    info.WorkingDirectory <- __SOURCE_DIRECTORY__ 
                    info.Arguments <- "--build --project=\"helloworld\helloworld_Model.xcml\""
                    ) 
                    (TimeSpan.FromMinutes timeoutExec)
  
    if result <> 0 then failwithf "xctools returned with a non-zero exit code"

    ensureDirectory buildClientAppDir

    !! "helloworld\HelloWorldClientApplication/HelloWorldClientApplication.sln"
    |> MSBuildRelease buildClientAppDir "Build"
    |> Log "Hello world client application build output: "

    result = ExecProcess (fun info ->
                    info.FileName <- xctools
                    info.WorkingDirectory <- __SOURCE_DIRECTORY__ 
                    info.Arguments <- "-t --testconfig=\"helloworld.test\helloworldtests.json\" --testoutput=\"helloworld.test\helloworldtestproject\""
                    ) 
                    (TimeSpan.FromMinutes timeoutExec)
    if result <> 0 then failwithf "xctools test project generation returned with a non-zero exit code"
  
    
)

Target "Generate" (fun _ ->
    let parentDirectory = Directory.GetParent(__SOURCE_DIRECTORY__).FullName
    //Generate xcstudio.cmd
    trace("Generating xcstudio.cmd")
    let studioScriptContents = [| "pushd %~dp0"
    ;"cd /d \"" + Path.Combine(parentDirectory, "packages\\xcomponent.community\\tools\XCStudio") + "\""
    ;"start \"\" XCStudio.exe \"" + Path.Combine(__SOURCE_DIRECTORY__, "helloworld\\helloworld_Model.xcml") + "\""
    ;"popd" |]
    File.WriteAllLines(studioScriptPath, studioScriptContents)    

    //Generate startMicroservice.cmd
    trace("Generating startMicroservice.cmd")
    let startMicroserviceScriptContents = [| "pushd %~dp0"
    ;"cd /d \"" + Path.Combine(parentDirectory, "packages\\xcomponent.community\\tools\XCStudio\XCRuntime") + "\""
    ;"start \"\" XCRuntime.exe \"" + Path.Combine(__SOURCE_DIRECTORY__, "build\\exportMicroservice\\xcassemblies\\helloworld-HelloMicroservice.xcr") + "\""
    ;"popd"|]
    File.WriteAllLines(startMicroserviceScriptPath, startMicroserviceScriptContents)    
    
    //Generate startConsoleApp.cmd
    trace("Generating startConsoleApp.cmd")
    let startConsoleAppScriptContents = [| "pushd %~dp0"
    ;"cd /d \"" + Path.Combine(__SOURCE_DIRECTORY__, "build\\consoleApp") + "\""
    ;"start \"\" HelloWorldClientApplication.exe"
    ;"popd"|]
    File.WriteAllLines(startConsoleAppScriptPath, startConsoleAppScriptContents)    
)
  
// Default target
Target "Help" (fun _ ->
    List.iter printfn [
      "xcomponent.helloworld build usage: "      
      ""
      "build All"      
      ""                  
      ""]
)

Target "All" DoNothing

// Dependencies
"Clean"  
  ==> "Generate"
  ==> "Compile"    
  ==> "All"

// start build
RunTargetOrDefault "Help"