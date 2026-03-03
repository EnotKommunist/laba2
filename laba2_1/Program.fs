open System

let rec minNum (num: int) (min: int) =
    if num < 10 then
        if num < min then num else min
    else
        if num % 10 < min then
            minNum (num / 10) (num % 10)
        else
            minNum (num / 10) min

let findMinNum numbers =
    numbers |> List.map (fun x -> minNum x 10)

[<EntryPoint>]
let main argv =
    printf "Введите кол-во эл списка: "
    let countEl = int (Console.ReadLine())
    
    printfn "Введите эл списка: "
    let numbers = [ for i in 0 .. countEl - 1 -> int (Console.ReadLine()) ]
    
    let listMinDigits = findMinNum numbers
    
    printfn "Исходные числа: %A" numbers
    printfn "Минимальные цифры: %A" listMinDigits
    0
