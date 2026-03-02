open System

let rec RecNum num required_number = 
    if num < 10 then
        if num = required_number then
            1
        else
            0
    else
        if num % 10 = required_number then
            1
        else
            RecNum (num/10) required_number

let FindNum numbers required_number = 
    [
        for i = 0 to List.length numbers - 1 do
            RecNum numbers.[i] required_number
    ]

[<EntryPoint>]
let main args = 
    printf "Введите кол-во эл списка: "
    let count_el = int(Console.ReadLine())
    printfn "Введите эл списка: "
    let numbers = [for i in 0..count_el-1 -> int(Console.ReadLine())]
    printf "Какое число необходимо найти: "
    let required_number = int(Console.ReadLine())
    let list_num = FindNum numbers required_number
    let sum = List.fold (fun acc x -> acc + x) 0 list_num
    printfn "Кол-во чисел с %i: %i" required_number sum
    0