### 0.10.0 - March 21 2023

- Add WithLegend and WithLegendStyle extension methods to GenericChart

### 0.9.0 - March 21 2023

- Update package to work with Plotly.NET 4.0
- use strict dependency range to prevent major version increases from Plotly.NET from breaking dependent packages.

### 0.8.0 - August 23 2022

completed C# bindings for the missing domain and smith charts:

- [x] ChartTernary  
    - [x] ScatterTernary
    - [x] PointTernary
    - [x] LineTernary
    - [x] BubbleTernary
 - [x] ChartCarpet 
    - [x] Carpet
    - [x] ScatterCarpet
    - [x] PointCarpet
    - [x] LineCarpet
    - [x] SplineCarpet
    - [x] BubbleCarpet
    - [x] ContourCarpet

The Chart construction API is now complete.

### 0.7.0 - August 22 2022

completed C# bindings for the missing ternary and carpet charts:

- [x] ChartTernary  
    - [x] ScatterTernary
    - [x] PointTernary
    - [x] LineTernary
    - [x] BubbleTernary
 - [x] ChartCarpet 
    - [x] Carpet
    - [x] ScatterCarpet
    - [x] PointCarpet
    - [x] LineCarpet
    - [x] SplineCarpet
    - [x] BubbleCarpet
    - [x] ContourCarpet

### 0.6.0 - August 19 2022

completed C# bindings for the missing map charts:

- [x] ChoroplethMap
- [x] PointGeo
- [x] LineGeo
- [x] BubbleGeo
- [x] ScatterMapbox
- [x] LineMapbox
- [x] BubbleMapbox
- [x] ChoroplethMapbox


### 0.5.0 - August 11 2022

completed C# bindings for the missing polar charts:

- [x] PointPolar
- [x] LinePolar
- [x] SplinePolar
- [x] BubblePolar
- [x] BarPolar

### 0.4.0 - August 9 2022

completed C# bindings for the missing 3D charts:

- [x] Point3D
- [x] Line3D
- [x] Bubble3D
- [x] Surface
- [x] Mesh3D
- [x] Cone
- [x] StreamTube
- [x] Volume
- [x] IsoSurface

### 0.3.0 - August 2 2022

completed C# bindings for 2D traces/charts:

- [x] Spline
- [x] Bubble
- [x] Range
- [x] Area
- [x] SplineArea
- [x] StackedArea
- [x] StackedFunnel
- [x] StackedBar
- [x] StackedColumn
- [x] Heatmap
- [x] AnnotatedHeatmap
- [x] Image
- [x] Contour
- [x] Splom

### 0.2.0 - July 28 2022

added C# bindings for finance charts

- [x] OHLC
- [x] Candlestick
- [x] Waterfall
- [x] Funnel
- [x] Funnel Area
- [x] Indicator

Additionally, some GenericChart extensions have been added:

- [x] WithXAxisrangeSlider

### 0.1.0 - July 26 2022

added C# bindings for statistical charts

- [x] Histogram
- [x] Histogram2D
- [x] BoxPlot
- [x] Violin
- [x] Histogram2DContour
- [x] PointDensity
- [x] DensityMapbox
- [x] ContourCarpet

Optional arguments are now wrapped in a custom `Optional<T>` type to allow usage of both reference and value types for optional arguments across the whole API.

Some GenericChart extension methods were also added:
- WithMabox
- WithMaboxStyle

### 0.0.1 - June 15 2022

C# bindings for basic charts and styling for usage in ML.NET notebooks:

**Chart styling / Layouting**

- [x] Extension Methods
	- [x] SaveHtml
	- [x] Show
	- [x] WithTraceInfo
	- [x] WithSize
	- [x] WithXAxisStyle
	- [x] WithYAxisStyle
- [x] Chart.Grid
- [x] Chart.Combine

**Chart generation**
- [x] Chart.Invisible
- [x] Chart2D
	- [x] Scatter
	- [x] Point
	- [x] Line
	- [x] Bar
	- [x] Column
- [x] Chart3D 	  
	- [x] Scatter3D
- [x] ChartPolar	  
	- [x] ScatterPolar
- [x] ChartMap  
	- [x] ScatterGeo
- [x] ChartTernary  
	- [x] ScatterTernary
- [x] ChartCarpet 
	- [x] Carpet
- [x] ChartDomain
	- [x] Pie
 - [x] ChartSmith
	- [x] ScatterSmith