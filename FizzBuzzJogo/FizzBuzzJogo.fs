// Fornece os métodos necessários para o jogo FizzBuzz básico.
module FizzBuzzJogo

//  Retorna um dos valores do contador
let Contar valor : string = 
    if (valor % 3 = 0) || (valor % 5 = 0) then // O valor é divisível por 3 ou por 5
        if valor % 3 <> 0 then 
            "Buzz"
        else if valor % 5 <> 0 then 
            "Fizz" 
        else
            "FizzBuzz"
    else // Valor não divisível por 3 nem por 5
        string valor

// Executa o jogo FizzBuzz, até o valor de max
let FizzBuzz max : string list =
      // Percorre a lista gerando um novo array com os valores correspondentes
      List.init max (fun index -> Contar (index + 1) )
      