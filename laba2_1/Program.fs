open System

let rec MinNum num min = 
    if num < 10 then
        if num < min then
            num
        else
            min
    else
        if num % 10 < min then
            MinNum (num/10) (num%10)
        else
            MinNum (num/10) min

let FindMinNum numbers = 
    [
        for i = 0 to List.length numbers - 1 do
            MinNum numbers.[i] 10
    ]

[<EntryPoint>]
let main args = 
    printf "Введите кол-во эл списка: "
    let count_el = int(Console.ReadLine())
    printfn "Введите эл списка: "
    let numbers = [for i in 0..count_el-1 -> int(Console.ReadLine())]
    let list_num = FindMinNum numbers
    printfn "Исходные числа: %A" numbers
    printfn "Минимальные цифры: %A" list_num
    0