﻿// Project Euler - Problem 1
// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
// Find the sum of all the multiples of 3 or 5 below 1000.

open System

let multiples = [1..999]
             |> List.filter (fun n -> n % 3 = 0 || n % 5 = 0)
             |> List.sum
             |> printfn "The sum of all multiples are: %d"
Console.ReadKey () |> ignore