namespace FizzBuzzJogo.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member __.``Testar FizzBuzz 21 - Passa``() =
        let esperado = [ "1";"2";"Fizz";"4";"Buzz";"Fizz";"7";"8";"Fizz";"Buzz";"11";"Fizz";"13"; "14"; "FizzBuzz"; "16";"17";"Fizz";"19";"Buzz";"Fizz"]
        let atual = FizzBuzzJogo.FizzBuzz(21)
        Assert.AreEqual<list<string>>(esperado, atual);
    
    [<TestMethod>]
    member __.``Testar FizzBuzz 9 - Falha`` () =
        let esperado = ["1";"2";"Fizz";"4";"Buzz";"Fizz";"7";"8";"9"]
        let atual = FizzBuzzJogo.FizzBuzz(9)
        Assert.AreNotEqual<list<string>>(esperado, atual);
    
    [<TestMethod>]
    member __.``Testar FizzBuzz 21 - V2 - Passa``() =
        let regras = [(fun i -> if i % 15 = 0 then "FizzBuzz" else null); 
                        (fun i -> if i % 3 = 0 && i % 5 <> 0 then "Fizz" else null); 
                        (fun i -> if i % 5 = 0 && i % 3 <> 0 then "Buzz" else null); 
                        (fun i -> if i % 3 <> 0 && i % 5 <> 0 then string i else null)]
        let esperado = [ "1";"2";"Fizz";"4";"Buzz";"Fizz";"7";"8";"Fizz";"Buzz";"11";"Fizz";"13"; "14"; "FizzBuzz"; "16";"17";"Fizz";"19";"Buzz";"Fizz"]
        let atual = FizzBuzzJogo2.FizzBuzz 21 regras
        Assert.AreEqual<list<string>>(esperado, atual);
    
    [<TestMethod>]
    member __.``Testar FizzBuzz 9 - V2 - Falha``() =
        let regras = [(fun i -> if i % 15 = 0 then "FizzBuzz" else null); 
                        (fun i -> if i % 3 = 0 && i % 5 <> 0 then "Fizz" else null); 
                        (fun i -> if i % 5 = 0 && i % 3 <> 0 then "Buzz" else null); 
                        (fun i -> if i % 3 <> 0 && i % 5 <> 0 then string i else null)]
        let esperado = ["1";"2";"Fizz";"4";"Buzz";"Fizz";"7";"8";"9"]
        let atual = FizzBuzzJogo2.FizzBuzz 9 regras
        Assert.AreNotEqual<list<string>>(esperado, atual);
