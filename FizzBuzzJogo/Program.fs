// Desenvolvido por Assuéro Araújo Morais
// Em 19/02/2018
// Executa um jogo FizzBuzz básico.
open System

[<EntryPoint>]
let main argv =
    let mutable max = 0
    // Verifica se recebeu um argumento com o valor máximo via execução.
    if (argv.Length > 0) then
        Int32.TryParse(argv.[0], &max) |> ignore
    // Se não recebeu o argumento irá solicitar ao usuário.
    if max = 0 then
        printfn "FIZZBUZZ GAMES"
        printfn "Informe o número final do contador:"
        let x = Console.ReadLine()
        if x <> null then
            Int32.TryParse(x, &max) |> ignore
    // Sé o usuário tiver informado ou tiver recebido por parâmetro, processa e imprime o resultado do FizzBuzz.
    if max > 0 then
        printfn "Contando até %i" max
        FizzBuzzJogo.FizzBuzz max |> Seq.iter (printfn "%s")
    
    printfn "Digite qualquer tecla para fechar..."
    Console.ReadKey() |> ignore
    0  
