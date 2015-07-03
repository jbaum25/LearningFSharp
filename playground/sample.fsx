open System
let msg = "Hello F#!"
Console.WriteLine(msg)

let quantityOfCookies = [|1; 2; 3; 4; 5; 0; |]
let zero = quantityOfCookies. [5]
quantityOfCookies. [5] <- 6
for i in quantityOfCookies do
  if i = zero then
    printfn "Good job. Eat healthy food."
  else if i = 1 then
    printfn "One cookie won't hurt you."
  else if i = 2 then
    printfn "Two cookies makes a nice snack"
  else
    printfn "%d cookies is too many!" i

let foo = 3 + 4 * 8
let lucky = foo + 7 * 9 / 3

sprintf "the answer is %d" lucky
