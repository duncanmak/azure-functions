module Hello

open Microsoft.Azure.WebJobs.Host
open System.Net
open System.Net.Http

let Run(req: HttpRequestMessage, log: TraceWriter) =
  log.Info(sprintf "F# HTTP trigger function processed a request.")
  req.CreateResponse(HttpStatusCode.OK, "Hello World!")