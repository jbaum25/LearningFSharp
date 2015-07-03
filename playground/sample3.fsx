open System
let printMsg i =
    match i with
    | 0 -> "Good job. Eat healthy food."
    | 1 -> "One cookie won't hurt you."
    | 2 -> "Two cookies makes a nice snack."
    | n when n > 2 -> n.ToString() + " cookies are too much!"
    |  _ -> failwith( "number of expected cookies")

for i in [1 .. 6] do
    printMsg i |> printfn ("%s")
