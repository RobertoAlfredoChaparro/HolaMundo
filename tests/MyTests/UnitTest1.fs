module MyTests

open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    Assert.Pass()

[<Test>]
let ``Suma de 2 y 2 es cuatro´´ () = 
    let expected = 4
    let actual = add 2 2

    Assert.AreEqual(expected, actual)
