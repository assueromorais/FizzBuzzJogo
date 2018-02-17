module FizzBuzzJogo

//  Imprime um dos valores do contador
let Imprime valor = 
    if (valor % 3 <> 0) && (valor % 5 <> 0) then
        printf "%i" valor
    else
        if valor % 3 = 0 then
            printf "Fizz"
        if valor % 5 = 0 then
            printf "Buzz"
    printfn ""

// Executa o jogo FizzBuzz, contando até o valor de max
// Se triggers é preenchido, utiliza-o para controlar a verificação
let FizzBuzz max =
      [1..max] |> List.map Imprime  |> ignore
