open System

//type Result<'TSuccess,'TFailure> =
//    |Success of 'TSuccess
//    |Failure of 'TFailure

//let bind switchFn twoTrackInput =
//    match twoTrackInput with
//    |Success s -> switchFn s
//    |Failure f -> Failure f
//
//let validate1 email = 
//    if email = "" then
//        Failure "email cannot be empty"
//    else
//        Success email
//
//let validate2 email = 
//    if not (email.ToString().Contains("@")) then
//        Failure "email must contains @."
//    else
//        Success email
//
//let validate3 email = 
//    if email.ToString().Length > 50 then
//        Failure "email is longer than 50 chars"
//    else
//        Success email
//
//let getResult result = 
//    match result with
//    |Success s -> "Yes"
//    |Failure f -> f



let validate1 email = 
    if email = "" then
        false
    else
        true

let validate2 email = 
    if not (email.ToString().Contains("@")) then
        false
    else
        true

let validate3 email = 
    if email.ToString().Length > 50 then
        false
    else
        true

//pyramid of doom:
let validateEmail email =
    if (validate1 email) then
        if (validate2 email) then
            if (validate3 email)  then
                true
            else
                false
        else
            false
    else
        false

[<EntryPoint>]
let main argv = 
    let good = "abc@gmail.com"
    let bad = "abc"

    let r1 = validateEmail good
    printfn "Email: [%s] is valid: %b" good r1

    let r2 = validateEmail bad
    printfn "Email: [%s] is valid: %b" bad r2

    Console.Read() |> ignore
    0 // return an integer exit code
