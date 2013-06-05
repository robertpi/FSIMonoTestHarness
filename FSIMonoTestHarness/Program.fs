
// NOTE: If warnings appear, you may need to retarget this project to .NET 4.0. Show the Solution
// Pad, right-click on the project node, choose 'Options --> Build --> General' and change the target
// framework to .NET 4.0 or .NET 4.5.

module FSIMonoTestHarness.Main

open System
open System.IO
open Microsoft.FSharp.Compiler.Interactive

[<EntryPoint>]
let main args = 

    let input = new Shell.CompilerInputStream()
    let output = new Shell.CompilerOutputStream()
    let error = new Shell.CompilerOutputStream()
    
    let input' = new StreamWriter(input)
    let output' = new StreamWriter(output)
    let error' = new StreamReader(error)
     
    let args = [|"fsi.exe"|]
    
    let interact = new Shell.FsiEvaluationSession(args, input', output', error')
    Console.ReadLine() |> ignore
    0

