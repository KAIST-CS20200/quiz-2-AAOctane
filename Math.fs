module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let rec collatz n =
  if n = 1 then 0 else
    if n % 2 = 1 then collatz(3 * n + 1) + 1 else collatz(n / 2) + 1
