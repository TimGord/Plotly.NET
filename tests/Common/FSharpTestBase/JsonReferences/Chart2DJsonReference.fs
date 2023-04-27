module Chart2DJsonReference

open System
open System.IO
open JsonChartReference

module Point =
    
    let ``Point chart with full plotly.js reference`` = ()

    let ``Point chart with plotly.js cdn reference`` = ()

    let ``Point chart referencing plotly.js using require.js`` = ()

    let ``Point chart with axis labels and title`` = JsonChartReference.fromJsonFile("JsonReferences/Chart2D/Point_chart_with_axis_labels_and_title.json")

    let ``Point chart with text labels`` = ()

module Line = 

    let ``Simple line chart`` = ()

    let ``Line chart with line styling`` = ()

module Spline =

    let ``Simple spline chart`` = ()

module Bubble = 

    let ``Simple bubble chart`` = ()

module Range = 

    let ``Styled range chart`` = ()

module Area = 
    
    let ``Simple area chart`` = ()

module SplineArea = 
    
    let ``Simple spline area chart`` = ()

module StackedArea = 
    
    let ``Two stacked areas chart`` = ()

module Funnel = ()

module StackedFunnel = ()

module Waterfall = ()

module Bar = 

    let ``Simple bar chart`` = ()

    let ``Two stacked bars chart`` = ()

module StackedBar = ()

module Column = 

    let ``Simple column chart`` = ()

    let ``Two stacked columns chart`` = ()

module StackedColumn = ()

module Histogram = 

    let ``Simple histogram`` = ()


module Histogram2D = 

    let ``Histogram2D of 2D normal distribution`` = ()

module BoxPlot = 

    let ``Simple boxplot with boxpoints`` = ()

    let ``Simple horizontal boxplot with boxpoints`` = ()

    let ``Combined chart with 2 horizontal boxplots`` = ()

module Violin = 

    let ``Simple violin plot with jitterpoints`` = ()

    let ``Simple horizontal violin plot with jitterpoints`` = ()

    let ``Combined chart with 2 horizontal violin plots`` = ()

module Histogram2DContour = 

    let ``Histogram2DContour of 2D normal distribution`` = ()

module Heatmap = 
    
    let ``simple heatmap with custom colorscale`` = ()

        
    let ``Simple heatmap with custom colorscale and styled colorbar`` = ()


module AnnotatedHeatmap = 


    let ``Simple annotated heatmap`` = ()

module Image = 

    let ``Raw color component image chart`` = ()

    let ``HSL image chart`` = ()

    let ``ARGB image chart`` = ()

    let ``Image chart from base64 string`` = ()

module Contour = 

    let ``Contour plot with peak and sink`` = ()

module OHLC = ()

module Candlestick = ()

module Splom = ()

module PointDensity = 

    let ``Simple PointDensity chart`` =  ()

    let ``Styled PointDensity chart`` = ()