module FizzBuzzJogo2

let Contar valor regras : string = 
    regras 
    |> List.map (fun r -> r valor)
    |> List.filter (fun x -> not (isNull x))
    |> List.head
    
/// Executa o jogo FizzBuzz, até o valor de max.
/// Parâmetro regras contém as funções que tratam os padrões de contagem.
let FizzBuzz max regras: string list =
    List.init max (fun index -> Contar (index + 1) regras)