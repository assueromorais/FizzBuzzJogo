module FizzBuzzJogo

let ehDivisivel dividendo divisor  = dividendo % divisor = 0

let ehFizz valor = ehDivisivel valor 3
let ehBuzz valor = ehDivisivel valor 5
let ehFizzBuzz valor = ehDivisivel valor 15

let Contar valor : string = 
    if ehFizzBuzz valor then
        "FizzBuzz"
    else if ehBuzz valor then 
        "Buzz"
    else if ehFizz valor then 
        "Fizz" 
    else
        string valor

/// Executa o jogo FizzBuzz, até o valor de max
let FizzBuzz max : string list =
      List.init max (fun index -> Contar (index + 1) )
