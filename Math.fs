module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.

let rec collatz64 n: int64 = 
  if n = 1L then 0L else
    if n % 2L = 1L then collatz64(3L * n + 1L) + 1L else collatz64(n / 2L) + 1L
let collatz n = int (collatz64 (int64 n))
