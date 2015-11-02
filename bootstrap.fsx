#if BOOTSTRAP
System.Environment.CurrentDirectory <- __SOURCE_DIRECTORY__
[<Literal>]
let paketExe = "paket.exe"
[<Literal>]
let release = "2.20.0"
[<Literal>]
let paketDir = ".paket"

let paketFile = 
   sprintf "%s/%s/%s" System.Environment.CurrentDirectory paketDir paketExe

if not (System.IO.File.Exists paketFile) then 
    System.IO.Directory.CreateDirectory paketDir |> ignore
    printfn "Created directory: %s" paketDir

    let url =
        sprintf "https://github.com/fsprojects/Paket/releases/download/%s/%s" release paketExe 
    let tmp = System.IO.Path.GetTempFileName() 

    use wc = new System.Net.WebClient() 
    wc.DownloadFile(url, tmp) 
    System.IO.File.Move(tmp, paketFile)
    printfn "Installed: %s" paketFile

#r "./.paket/paket.exe"
Paket.Dependencies.Install (System.IO.File.ReadAllText "paket.dependencies")
#endif
