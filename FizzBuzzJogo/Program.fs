/// Desenvolvido por Assuéro Araújo Morais
/// Em 19/02/2018
/// Executa um jogo FizzBuzz básico.
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
    // Se o usuário tiver informado ou tiver recebido por parâmetro, processa e imprime o resultado do FizzBuzz.
    if max > 0 then
        // Regras de contagem.
        let regras = 
            [(fun i -> if i % 15 = 0 then "FizzBuzz" else null); 
            (fun i -> if i % 3 = 0 && i % 5 <> 0 then "Fizz" else null); 
            (fun i -> if i % 5 = 0 && i % 3 <> 0 then "Buzz" else null); 
            (fun i -> if i % 3 <> 0 && i % 5 <> 0 then string i else null)]
        printfn "Contando até %i" max
        FizzBuzzJogo2.FizzBuzz max regras |> Seq.iter (printfn "%s")
    
    printfn "Digite qualquer tecla para fechar..."
    Console.ReadKey() |> ignore
    0  
