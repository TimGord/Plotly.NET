(*** hide ***)

(*** condition: prepare ***)
#r "../bin/Plotly.NET/net5.0/Plotly.NET.dll"
(*** condition: fsx ***)
#if FSX
#r "../packages/Newtonsoft.Json/lib/netstandard2.0/Newtonsoft.Json.dll"
#r "../bin/Plotly.NET/net5.0/Plotly.NET.dll"
#endif // FSX
(*** condition: ipynb ***)
#if IPYNB
#r "nuget: Plotly.NET, 2.0.0-beta1"
#r "nuget: Plotly.NET.Interactive, 2.0.0-alpha5"
#endif // IPYNB


(** 
# 3D line charts

[![Binder](https://mybinder.org/badge_logo.svg)](https://mybinder.org/v2/gh/plotly/Plotly.NET/gh-pages?filepath=3d-line-plots.ipynb)

*Summary:* This example shows how to create three-dimensional scatter charts in F#.

let's first create some data for the purpose of creating example charts:
*)

open Plotly.NET 
open System
 
let c = [0. .. 0.5 .. 15.]

let x,y,z =  
    c
    |> List.map (fun i ->
        let i' = float i 
        let r = 10. * Math.Cos (i' / 10.)
        (r*Math.Cos i',r*Math.Sin i',i')
    )
    |> List.unzip3

(**
A Scatter3 chart shows a three-dimensional spinnable view of your data.
When using `Lines_Markers` as the mode of the chart, you additionally render a line between the points:
*)

let scatter3dLine = 
    Chart.Scatter3d(x,y,z,StyleParam.Mode.Lines_Markers)
    |> Chart.withX_AxisStyle("x-axis")
    |> Chart.withY_AxisStyle("y-axis")
    |> Chart.withZ_AxisStyle("z-axis")
    |> Chart.withSize(800.,800.)

(*** condition: ipynb ***)
#if IPYNB
scatter3dLine
#endif // IPYNB

(***hide***)
scatter3dLine |> GenericChart.toChartHTML
(*** include-it-raw ***)