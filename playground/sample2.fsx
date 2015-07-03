open System


let quantityOfCookies = [|1; 2; 3; 4; 5; 0; |]
let zero = quantityOfCookies.[5]
quantityOfCookies. [5] <- 6
for i in quantityOfCookies do
  if i = zero then
    printfn "Good job. Eat healthy food."
  else if i = 1 then
    printfn "One cookie won't hurt you."
  else if i = 2 then
    printfn "Two cookies makes a nice snack."
  else
    printfn "%d cookies is too much!" i
