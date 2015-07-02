open System
open System.IO

Environment.CurrentDirectory <- __SOURCE_DIRECTORY__

if not (File.Exists "paket.exe") then
    let url = "https://github.com/fsprojects/Paket/releases/download/0.26.3/paket.exe"
    use wc = new Net.WebClient()
    let tmp = Path.GetTempFileName()
    wc.DownloadFile(url, tmp);
    File.Move(tmp,Path.GetFileName url)

// Step 1. Resolve and install the packages

#r "paket.exe"

Paket.Dependencies.Install """
    source https://nuget.org/api/v2
    nuget Suave 0.16.0
    nuget FSharp.Data
    nuget FSharp.Charting
""";;
