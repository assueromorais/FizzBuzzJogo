// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let mutable x = ""
    let mutable max = 0
    if (argv.Length > 0) then
        Int32.TryParse(argv.[0], &max) |> ignore

    if max = 0 then
        printfn "Jogo FizzBuzz digital"
        printfn "Informe o número final do contador:"
        x <- Console.ReadLine()
        if x <> null then
            Int32.TryParse(x, &max) |> ignore

    if max > 0 then
        printfn "Contando até %i" max
        FizzBuzzJogo.FizzBuzz max
    
    printfn "Digite qualquer tecla para fechar..."
    Console.ReadKey() |> ignore
    0  
