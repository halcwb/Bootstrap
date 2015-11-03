#if BOOTSTRAP
System.Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

[<Literal>]
let paketExe = "paket.exe"
[<Literal>]
let paketDir = ".paket"

let paketFile = 
   sprintf "%s/%s/%s" System.Environment.CurrentDirectory paketDir paketExe

/// Get the latest paket.exe if it doesn't exist yet
if not (System.IO.File.Exists paketFile) then 
    System.IO.Directory.CreateDirectory paketDir |> ignore
    printfn "Created directory: %s" paketDir

    use wc = new System.Net.WebClient() 
    // Get the latest release
    let latest = "https://github.com/fsprojects/Paket/releases/latest"
    let html = wc.DownloadString(latest)
    let title = html.Substring(html.IndexOf("<title>") + 7, (html.IndexOf("</title>") - html.IndexOf("<title>") - 7))
    let release = title.Split(' ').[1]

    let url =
        sprintf "https://github.com/fsprojects/Paket/releases/download/%s/%s" release paketExe 
    let tmp = System.IO.Path.GetTempFileName() 

    // Get the paket.exe
    wc.DownloadFile(url, tmp) 
    System.IO.File.Move(tmp, paketFile)
    printfn "Installed: %s" paketFile

#r "./.paket/paket.exe"

/// Install dependencies
Paket.Dependencies.Install (System.IO.File.ReadAllText "paket.dependencies")

#endif
