// For more information see https://aka.ms/fsharp-console-apps
//printfn "Hello from F#"

open MyLibrary  // o importo el modulo con open MyLibrary.Say
open MyLibrary

[<EntryPoint>]
// Entry point
let main args =  
//    printfn $"Hola Mundo"
    Say.hello "Rober" 

    Math.imprimeAdd 3 2

    0