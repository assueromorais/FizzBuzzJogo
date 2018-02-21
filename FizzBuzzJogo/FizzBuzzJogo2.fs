// Fornece os métodos necessários para o jogo FizzBuzz com opção de encaminhar as funções com as regras da contagem.
module FizzBuzzJogo2

//  Processa as regras de contagem recebidas, retornando o text conforme o valor atual.
let Contar valor regras : string = 
    let mutable resultado = null
    regras |> List.iter (fun r -> 
                if (r valor <> null && resultado = null) then 
                    resultado <- r valor  // Altera para o valor retornado pela função.
                else 
                    resultado <- resultado) // Mantém o valor.
    if(resultado <> null) then // Uma das funções retornou um valor.
        resultado
    else
        string valor
    
// Executa o jogo FizzBuzz, até o valor de max.
// O parâmetro regras contém as funções que tratam os padrões de contagem.
let FizzBuzz max regras: string list =
      // Percorre a lista gerando um novo array com os valores correspondentes
      List.init max (fun index -> Contar (index + 1) regras)
      