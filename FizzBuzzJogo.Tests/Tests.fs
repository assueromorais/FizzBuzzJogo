namespace FizzBuzzJogo.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.TestMethodFail () = 
        Assert.IsTrue(false);

    [<TestMethod>]
    member this.TestMethodPassing () =
        Assert.IsTrue(true);
    
    [<TestMethod>]
    member this.TestFizzBuzz21Pass () =
        let esperado = [ "1";"2";"Fizz";"4";"Buzz";"Fizz";"7";"8";"Fizz";"Buzz";"11";"Fizz";"13";"14";"FizzBuzz";"16";"17";"Fizz";"19";"Buzz";"Fizz"]
        let atual = FizzBuzzJogo.FizzBuzz(21)
        Assert.AreEqual<list<string>>(esperado, atual);
    
    [<TestMethod>]
    member this.TestFizzBuzz9Fail () =
        let esperado = ["1";"2";"Fizz";"4";"Buzz";"Fizz";"7";"8";"9"]
        let atual = FizzBuzzJogo.FizzBuzz(9)
        Assert.AreEqual<list<string>>(esperado, atual);
    
    [<TestMethod>]
    member this.TestFizzBuzzV221Pass () =
        let triggers = [(fun i -> if i % 15 = 0 then "FizzBuzz" else null); (fun i -> if i % 3 = 0 && i % 5 <> 0 then "Fizz" else null); (fun i -> if i % 5 = 0 && i % 3 <> 0 then "Buzz" else null); (fun i -> if i % 3 <> 0 && i % 5 <> 0 then string i else null)]
        let esperado = [ "1";"2";"Fizz";"4";"Buzz";"Fizz";"7";"8";"Fizz";"Buzz";"11";"Fizz";"13";"14";"FizzBuzz";"16";"17";"Fizz";"19";"Buzz";"Fizz"]
        let atual = FizzBuzzJogo2.FizzBuzz 21 triggers
        Assert.AreEqual<list<string>>(esperado, atual);
    
    [<TestMethod>]
    member this.TestFizzBuzzV29Fail () =
        let triggers = [(fun i -> if i % 15 = 0 then "FizzBuzz" else null); 
                        (fun i -> if i % 3 = 0 && i % 5 <> 0 then "Fizz" else null); 
                        (fun i -> if i % 5 = 0 && i % 3 <> 0 then "Buzz" else null); 
                        (fun i -> if i % 3 <> 0 && i % 5 <> 0 then string i else null)]
        let esperado = ["1";"2";"Fizz";"4";"Buzz";"Fizz";"7";"8";"9"]
        let atual = FizzBuzzJogo2.FizzBuzz 9 triggers
        Assert.AreEqual<list<string>>(esperado, atual);
    