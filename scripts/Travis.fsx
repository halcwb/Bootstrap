#r "../packages/Newtonsoft.Json/lib/net45/Newtonsoft.Json.dll"
open Newtonsoft.Json

[<CLIMutable>]
type Build = 
    {
      commit_id: int
      number: string
      duration: int
      finished_at: System.DateTime
      started_at: System.DateTime
      state: string
    }

[<CLIMutable>]
type Builds =
    {
        builds: Build[]
    }

let getLatestBuild project =
  try
    let url = sprintf "http://api.travis-ci.org/repos/halcwb/%s/builds" project
    let wr = System.Net.HttpWebRequest.Create(url) :?> System.Net.HttpWebRequest
    wr.Host <- "api.travis-ci.org"
    wr.UserAgent <- project
    wr.Accept <- "application/vnd.travis-ci.2+json"
    let resp = wr.GetResponse()
    use reader = new System.IO.StreamReader(resp.GetResponseStream())
    let json = reader.ReadToEnd()
    let builds = JsonConvert.DeserializeObject<Builds>(json)
    builds.builds.[0] |> Some
  with 
  | e -> printfn "Failed with %A" e; None

printfn "%A" (getLatestBuild "Bootstrap")

