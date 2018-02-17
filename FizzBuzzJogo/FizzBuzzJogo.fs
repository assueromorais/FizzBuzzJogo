module FizzBuzzJogo

//  Retorna um dos valores do contador
let Define valor : string = 
    let mutable retorno = ""
    // O valor é divisível por 3 ou por 5
    if (valor % 3 = 0) || (valor % 5 = 0) then
        let retorno = 
            if valor % 3 = 0 then "Fizz"
            else ""
        let retorno = 
            if valor % 5 = 0 then retorno + "Buzz"
            else retorno
        retorno
    else 
        valor.ToString()

// Executa o jogo FizzBuzz, contando até o valor de max
let FizzBuzz max : string list =
      // Percorre a lista gerando um novo array com os valores correspondentes
      List.init max (fun index -> Define (index + 1) )
