#r "packages/Newtonsoft.Json/lib/net45/Newtonsoft.Json.dll"
open Newtonsoft.Json

[<CLIMutable>]
type Build = 
    {
      commit_id: int
      duration: int
      finished_at: System.DateTime
      id: int
      job_ids: int[]
      number: string
      pull_request: bool
      pull_request_number: string
      pull_request_title: string
      repository_id: int
      started_at: System.DateTime
      state: string
    }

[<CLIMutable>]
type Builds =
    {
        builds: Build[]
    }

let wr = System.Net.HttpWebRequest.Create("http://api.travis-ci.org/repos/halcwb/Bootstrap/builds") :?> System.Net.HttpWebRequest
wr.Host <- "api.travis-ci.org"
wr.UserAgent <- "Bootstrap"
wr.Accept <- "application/vnd.travis-ci.2+json"
let resp = wr.GetResponse()
let reader = new System.IO.StreamReader(resp.GetResponseStream())

let builds = JsonConvert.DeserializeObject<Builds>(reader.ReadToEnd())
printfn "%A" (builds.builds.[0])




