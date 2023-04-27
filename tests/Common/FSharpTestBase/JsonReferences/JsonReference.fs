module JsonChartReference

open Newtonsoft.Json
open System.IO

type JsonChartReference = {
    Data: string
    Layout:string
} with
    static member create(data, layout) =
        {
            Data = data
            Layout = layout
        }

    static member fromJsonFile (path:string) =
        let json = File.ReadAllText(path)
        JsonConvert.DeserializeObject<JsonChartReference>(json)