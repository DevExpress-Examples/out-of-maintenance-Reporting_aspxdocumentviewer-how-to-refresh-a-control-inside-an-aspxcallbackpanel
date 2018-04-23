Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.XtraReports.UI

Namespace T133267_CS.Reports
    Public Class Shapes
        Inherits XtraReport

        Private xrShape28 As XRShape
        Private xrShape14 As XRShape
        Private xrShape19 As XRShape
        Private xrShape26 As XRShape
        Private xrShape9 As XRShape
        Private xrShape5 As XRShape
        Private xrLabel1 As XRLabel
        Private ReportHeader As ReportHeaderBand
        Private xrShape22 As XRShape
        Private xrShape24 As XRShape
        Private xrShape15 As XRShape
        Private xrShape12 As XRShape
        Private xrShape20 As XRShape
        Private xrShape23 As XRShape
        Private xrShape1 As XRShape
        Private xrShape3 As XRShape
        Private xrShape13 As XRShape
        Private Detail As DetailBand
        Private xrShape27 As XRShape
        Private xrShape25 As XRShape
        Private xrShape21 As XRShape
        Private xrShape18 As XRShape
        Private xrShape17 As XRShape
        Private xrShape16 As XRShape
        Private xrShape11 As XRShape
        Private xrShape10 As XRShape
        Private xrShape8 As XRShape
        Private xrShape7 As XRShape
        Private xrShape6 As XRShape
        Private xrShape4 As XRShape
        Private xrShape2 As XRShape
        Private topMarginBand1 As TopMarginBand
        Private bottomMarginBand1 As BottomMarginBand

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Dim shapeBracket1 As New DevExpress.XtraPrinting.Shape.ShapeBracket()
            Dim shapeStar1 As New DevExpress.XtraPrinting.Shape.ShapeStar()
            Dim shapeLine1 As New DevExpress.XtraPrinting.Shape.ShapeLine()
            Dim shapeCross1 As New DevExpress.XtraPrinting.Shape.ShapeCross()
            Dim shapePolygon1 As New DevExpress.XtraPrinting.Shape.ShapePolygon()
            Dim shapeArrow1 As New DevExpress.XtraPrinting.Shape.ShapeArrow()
            Dim shapeBracket2 As New DevExpress.XtraPrinting.Shape.ShapeBracket()
            Dim shapeBrace1 As New DevExpress.XtraPrinting.Shape.ShapeBrace()
            Dim shapeStar2 As New DevExpress.XtraPrinting.Shape.ShapeStar()
            Dim shapeStar3 As New DevExpress.XtraPrinting.Shape.ShapeStar()
            Dim shapeLine2 As New DevExpress.XtraPrinting.Shape.ShapeLine()
            Dim shapeBrace2 As New DevExpress.XtraPrinting.Shape.ShapeBrace()
            Dim shapeRectangle1 As New DevExpress.XtraPrinting.Shape.ShapeRectangle()
            Dim shapeArrow2 As New DevExpress.XtraPrinting.Shape.ShapeArrow()
            Dim shapeStar4 As New DevExpress.XtraPrinting.Shape.ShapeStar()
            Dim shapePolygon2 As New DevExpress.XtraPrinting.Shape.ShapePolygon()
            Dim shapeLine3 As New DevExpress.XtraPrinting.Shape.ShapeLine()
            Dim shapePolygon6 As New DevExpress.XtraPrinting.Shape.ShapePolygon()
            Dim shapeLine4 As New DevExpress.XtraPrinting.Shape.ShapeLine()
            Dim shapePolygon5 As New DevExpress.XtraPrinting.Shape.ShapePolygon()
            Dim shapeCross2 As New DevExpress.XtraPrinting.Shape.ShapeCross()
            Dim shapePolygon4 As New DevExpress.XtraPrinting.Shape.ShapePolygon()
            Dim shapeRectangle2 As New DevExpress.XtraPrinting.Shape.ShapeRectangle()
            Dim shapeArrow4 As New DevExpress.XtraPrinting.Shape.ShapeArrow()
            Dim shapePolygon3 As New DevExpress.XtraPrinting.Shape.ShapePolygon()
            Dim shapeArrow3 As New DevExpress.XtraPrinting.Shape.ShapeArrow()
            Dim shapeStar5 As New DevExpress.XtraPrinting.Shape.ShapeStar()
            Me.xrShape28 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape14 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape19 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape26 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape9 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape5 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrShape22 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape24 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape15 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape12 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape20 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape23 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape1 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape3 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape13 = New DevExpress.XtraReports.UI.XRShape()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrShape27 = New DevExpress.XtraReports.UI.XRShape()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrShape18 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape6 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape17 = New DevExpress.XtraReports.UI.XRShape()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrShape8 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape21 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape2 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape10 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape25 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape4 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape11 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape7 = New DevExpress.XtraReports.UI.XRShape()
            Me.xrShape16 = New DevExpress.XtraReports.UI.XRShape()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' xrShape28
            ' 
            Me.xrShape28.Angle = 180
            Me.xrShape28.BorderWidth = 1F
            Me.xrShape28.FillColor = System.Drawing.Color.Red
            Me.xrShape28.LineWidth = 2
            Me.xrShape28.LocationFloat = New DevExpress.Utils.PointFloat(175F, 600F)
            Me.xrShape28.Name = "xrShape28"
            Me.xrShape28.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape28.Shape = shapeBracket1
            Me.xrShape28.SizeF = New System.Drawing.SizeF(133F, 83F)
            Me.xrShape28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape14
            ' 
            Me.xrShape14.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(0)))))
            Me.xrShape14.LineWidth = 0
            Me.xrShape14.LocationFloat = New DevExpress.Utils.PointFloat(333F, 308F)
            Me.xrShape14.Name = "xrShape14"
            Me.xrShape14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeStar1.Concavity = 35F
            shapeStar1.StarPointCount = 6
            Me.xrShape14.Shape = shapeStar1
            Me.xrShape14.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape19
            ' 
            Me.xrShape19.Angle = 45
            Me.xrShape19.BorderWidth = 1F
            Me.xrShape19.LineWidth = 2
            Me.xrShape19.LocationFloat = New DevExpress.Utils.PointFloat(333F, 508F)
            Me.xrShape19.Name = "xrShape19"
            Me.xrShape19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape19.Shape = shapeLine1
            Me.xrShape19.SizeF = New System.Drawing.SizeF(133F, 83F)
            Me.xrShape19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape26
            ' 
            Me.xrShape26.Angle = 45
            Me.xrShape26.FillColor = System.Drawing.Color.Silver
            Me.xrShape26.LineWidth = 0
            Me.xrShape26.LocationFloat = New DevExpress.Utils.PointFloat(200F, 417F)
            Me.xrShape26.Name = "xrShape26"
            Me.xrShape26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeCross1.Fillet = 100
            shapeCross1.HorizontalLineWidth = 30
            shapeCross1.VerticalLineWidth = 30
            Me.xrShape26.Shape = shapeCross1
            Me.xrShape26.SizeF = New System.Drawing.SizeF(83F, 84F)
            Me.xrShape26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape9
            ' 
            Me.xrShape9.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(88)))), (CInt((CByte(190)))), (CInt((CByte(141)))))
            Me.xrShape9.LineWidth = 0
            Me.xrShape9.LocationFloat = New DevExpress.Utils.PointFloat(17F, 208F)
            Me.xrShape9.Name = "xrShape9"
            Me.xrShape9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapePolygon1.Fillet = 20
            shapePolygon1.NumberOfSides = 5
            Me.xrShape9.Shape = shapePolygon1
            Me.xrShape9.SizeF = New System.Drawing.SizeF(133F, 91F)
            Me.xrShape9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape5
            ' 
            Me.xrShape5.Angle = 180
            Me.xrShape5.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(123)))), (CInt((CByte(199)))), (CInt((CByte(213)))))
            Me.xrShape5.LineWidth = 0
            Me.xrShape5.LocationFloat = New DevExpress.Utils.PointFloat(333F, 108F)
            Me.xrShape5.Name = "xrShape5"
            Me.xrShape5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeArrow1.ArrowHeight = 30
            shapeArrow1.Fillet = 30
            Me.xrShape5.Shape = shapeArrow1
            Me.xrShape5.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.Maroon
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(50F, 25F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(567F, 50F)
            Me.xrLabel1.Text = "Shapes supported by XtraReports:"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.ReportHeader.HeightF = 91F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape22
            ' 
            Me.xrShape22.BorderWidth = 1F
            Me.xrShape22.FillColor = System.Drawing.Color.Red
            Me.xrShape22.LineWidth = 2
            Me.xrShape22.LocationFloat = New DevExpress.Utils.PointFloat(17F, 600F)
            Me.xrShape22.Name = "xrShape22"
            Me.xrShape22.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape22.Shape = shapeBracket2
            Me.xrShape22.SizeF = New System.Drawing.SizeF(133F, 83F)
            Me.xrShape22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape24
            ' 
            Me.xrShape24.Angle = 180
            Me.xrShape24.BorderWidth = 1F
            Me.xrShape24.LineWidth = 2
            Me.xrShape24.LocationFloat = New DevExpress.Utils.PointFloat(492F, 600F)
            Me.xrShape24.Name = "xrShape24"
            Me.xrShape24.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape24.Shape = shapeBrace1
            Me.xrShape24.SizeF = New System.Drawing.SizeF(133F, 83F)
            Me.xrShape24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape15
            ' 
            Me.xrShape15.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(207)))), (CInt((CByte(29)))), (CInt((CByte(33)))))
            Me.xrShape15.LineWidth = 0
            Me.xrShape15.LocationFloat = New DevExpress.Utils.PointFloat(175F, 308F)
            Me.xrShape15.Name = "xrShape15"
            Me.xrShape15.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeStar2.StarPointCount = 5
            Me.xrShape15.Shape = shapeStar2
            Me.xrShape15.SizeF = New System.Drawing.SizeF(134F, 92F)
            Me.xrShape15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape12
            ' 
            Me.xrShape12.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(141)))), (CInt((CByte(189)))), (CInt((CByte(113)))))
            Me.xrShape12.LineWidth = 0
            Me.xrShape12.LocationFloat = New DevExpress.Utils.PointFloat(492F, 208F)
            Me.xrShape12.Name = "xrShape12"
            Me.xrShape12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape12.Shape = shapeStar3
            Me.xrShape12.SizeF = New System.Drawing.SizeF(133F, 91F)
            Me.xrShape12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape20
            ' 
            Me.xrShape20.Angle = 315
            Me.xrShape20.BorderWidth = 1F
            Me.xrShape20.LineWidth = 2
            Me.xrShape20.LocationFloat = New DevExpress.Utils.PointFloat(492F, 508F)
            Me.xrShape20.Name = "xrShape20"
            Me.xrShape20.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape20.Shape = shapeLine2
            Me.xrShape20.SizeF = New System.Drawing.SizeF(133F, 83F)
            Me.xrShape20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape23
            ' 
            Me.xrShape23.BorderWidth = 1F
            Me.xrShape23.LineWidth = 2
            Me.xrShape23.LocationFloat = New DevExpress.Utils.PointFloat(333F, 600F)
            Me.xrShape23.Name = "xrShape23"
            Me.xrShape23.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape23.Shape = shapeBrace2
            Me.xrShape23.SizeF = New System.Drawing.SizeF(133F, 83F)
            Me.xrShape23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape1
            ' 
            Me.xrShape1.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(57)))), (CInt((CByte(143)))), (CInt((CByte(215)))))
            Me.xrShape1.LineWidth = 0
            Me.xrShape1.LocationFloat = New DevExpress.Utils.PointFloat(17F, 8F)
            Me.xrShape1.Name = "xrShape1"
            Me.xrShape1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape1.Shape = shapeRectangle1
            Me.xrShape1.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape3
            ' 
            Me.xrShape3.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(154)))), (CInt((CByte(107)))), (CInt((CByte(10)))))
            Me.xrShape3.LineWidth = 0
            Me.xrShape3.LocationFloat = New DevExpress.Utils.PointFloat(17F, 108F)
            Me.xrShape3.Name = "xrShape3"
            Me.xrShape3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeArrow2.Fillet = 30
            Me.xrShape3.Shape = shapeArrow2
            Me.xrShape3.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape13
            ' 
            Me.xrShape13.Angle = 45
            Me.xrShape13.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(202)))), (CInt((CByte(149)))))
            Me.xrShape13.LineWidth = 0
            Me.xrShape13.LocationFloat = New DevExpress.Utils.PointFloat(17F, 308F)
            Me.xrShape13.Name = "xrShape13"
            Me.xrShape13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeStar4.Concavity = 60F
            shapeStar4.Fillet = 20
            shapeStar4.StarPointCount = 4
            Me.xrShape13.Shape = shapeStar4
            Me.xrShape13.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrShape28, Me.xrShape27, Me.xrShape26, Me.xrShape25, Me.xrShape24, Me.xrShape23, Me.xrShape22, Me.xrShape21, Me.xrShape20, Me.xrShape19, Me.xrShape18, Me.xrShape17, Me.xrShape16, Me.xrShape15, Me.xrShape14, Me.xrShape13, Me.xrShape12, Me.xrShape11, Me.xrShape10, Me.xrShape9, Me.xrShape8, Me.xrShape7, Me.xrShape6, Me.xrShape5, Me.xrShape4, Me.xrShape3, Me.xrShape2, Me.xrShape1})
            Me.Detail.HeightF = 708F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape27
            ' 
            Me.xrShape27.Angle = 45
            Me.xrShape27.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(119)))), (CInt((CByte(197)))), (CInt((CByte(238)))))
            Me.xrShape27.LineWidth = 0
            Me.xrShape27.LocationFloat = New DevExpress.Utils.PointFloat(492F, 408F)
            Me.xrShape27.Name = "xrShape27"
            Me.xrShape27.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapePolygon2.Fillet = 75
            shapePolygon2.NumberOfSides = 4
            Me.xrShape27.Shape = shapePolygon2
            Me.xrShape27.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' xrShape18
            ' 
            Me.xrShape18.Angle = 90
            Me.xrShape18.BorderWidth = 1F
            Me.xrShape18.FillColor = System.Drawing.Color.Red
            Me.xrShape18.LineWidth = 2
            Me.xrShape18.LocationFloat = New DevExpress.Utils.PointFloat(175F, 508F)
            Me.xrShape18.Name = "xrShape18"
            Me.xrShape18.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape18.Shape = shapeLine3
            Me.xrShape18.SizeF = New System.Drawing.SizeF(134F, 83F)
            Me.xrShape18.Stretch = True
            Me.xrShape18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape6
            ' 
            Me.xrShape6.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(245)))), (CInt((CByte(106)))), (CInt((CByte(14)))))
            Me.xrShape6.LineWidth = 0
            Me.xrShape6.LocationFloat = New DevExpress.Utils.PointFloat(492F, 8F)
            Me.xrShape6.Name = "xrShape6"
            Me.xrShape6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapePolygon6.Fillet = 30
            Me.xrShape6.Shape = shapePolygon6
            Me.xrShape6.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape17
            ' 
            Me.xrShape17.BorderWidth = 1F
            Me.xrShape17.LineWidth = 2
            Me.xrShape17.LocationFloat = New DevExpress.Utils.PointFloat(17F, 508F)
            Me.xrShape17.Name = "xrShape17"
            Me.xrShape17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape17.Shape = shapeLine4
            Me.xrShape17.SizeF = New System.Drawing.SizeF(133F, 83F)
            Me.xrShape17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 100F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' xrShape8
            ' 
            Me.xrShape8.FillColor = System.Drawing.Color.Gray
            Me.xrShape8.LineWidth = 0
            Me.xrShape8.LocationFloat = New DevExpress.Utils.PointFloat(333F, 408F)
            Me.xrShape8.Name = "xrShape8"
            Me.xrShape8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapePolygon5.NumberOfSides = 4
            Me.xrShape8.Shape = shapePolygon5
            Me.xrShape8.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape21
            ' 
            Me.xrShape21.FillColor = System.Drawing.Color.DodgerBlue
            Me.xrShape21.LineWidth = 0
            Me.xrShape21.LocationFloat = New DevExpress.Utils.PointFloat(17F, 408F)
            Me.xrShape21.Name = "xrShape21"
            Me.xrShape21.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeCross2.HorizontalLineWidth = 40
            shapeCross2.VerticalLineWidth = 40
            Me.xrShape21.Shape = shapeCross2
            Me.xrShape21.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape2
            ' 
            Me.xrShape2.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(236)))), (CInt((CByte(205)))), (CInt((CByte(28)))))
            Me.xrShape2.LineWidth = 0
            Me.xrShape2.LocationFloat = New DevExpress.Utils.PointFloat(333F, 8F)
            Me.xrShape2.Name = "xrShape2"
            Me.xrShape2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrShape2.SizeF = New System.Drawing.SizeF(134F, 92F)
            Me.xrShape2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape10
            ' 
            Me.xrShape10.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(119)))), (CInt((CByte(111)))), (CInt((CByte(191)))))
            Me.xrShape10.LineWidth = 0
            Me.xrShape10.LocationFloat = New DevExpress.Utils.PointFloat(333F, 208F)
            Me.xrShape10.Name = "xrShape10"
            Me.xrShape10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapePolygon4.NumberOfSides = 8
            Me.xrShape10.Shape = shapePolygon4
            Me.xrShape10.SizeF = New System.Drawing.SizeF(133F, 91F)
            Me.xrShape10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape25
            ' 
            Me.xrShape25.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(131)))), (CInt((CByte(197)))), (CInt((CByte(33)))))
            Me.xrShape25.LineWidth = 0
            Me.xrShape25.LocationFloat = New DevExpress.Utils.PointFloat(175F, 8F)
            Me.xrShape25.Name = "xrShape25"
            Me.xrShape25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeRectangle2.Fillet = 20
            Me.xrShape25.Shape = shapeRectangle2
            Me.xrShape25.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape4
            ' 
            Me.xrShape4.Angle = 90
            Me.xrShape4.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(173)))), (CInt((CByte(91)))), (CInt((CByte(217)))))
            Me.xrShape4.LineWidth = 0
            Me.xrShape4.LocationFloat = New DevExpress.Utils.PointFloat(175F, 108F)
            Me.xrShape4.Name = "xrShape4"
            Me.xrShape4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeArrow4.ArrowWidth = 30
            shapeArrow4.Fillet = 30
            Me.xrShape4.Shape = shapeArrow4
            Me.xrShape4.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape11
            ' 
            Me.xrShape11.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(186)))), (CInt((CByte(200)))), (CInt((CByte(89)))))
            Me.xrShape11.LineWidth = 0
            Me.xrShape11.LocationFloat = New DevExpress.Utils.PointFloat(175F, 208F)
            Me.xrShape11.Name = "xrShape11"
            Me.xrShape11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapePolygon3.NumberOfSides = 6
            Me.xrShape11.Shape = shapePolygon3
            Me.xrShape11.SizeF = New System.Drawing.SizeF(134F, 91F)
            Me.xrShape11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape7
            ' 
            Me.xrShape7.Angle = 270
            Me.xrShape7.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(204)))), (CInt((CByte(102)))), (CInt((CByte(173)))))
            Me.xrShape7.LineWidth = 0
            Me.xrShape7.LocationFloat = New DevExpress.Utils.PointFloat(492F, 108F)
            Me.xrShape7.Name = "xrShape7"
            Me.xrShape7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeArrow3.ArrowHeight = 40
            shapeArrow3.ArrowWidth = 40
            shapeArrow3.Fillet = 30
            Me.xrShape7.Shape = shapeArrow3
            Me.xrShape7.SizeF = New System.Drawing.SizeF(134F, 92F)
            Me.xrShape7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrShape16
            ' 
            Me.xrShape16.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(62)))), (CInt((CByte(84)))), (CInt((CByte(172)))))
            Me.xrShape16.LineWidth = 0
            Me.xrShape16.LocationFloat = New DevExpress.Utils.PointFloat(492F, 308F)
            Me.xrShape16.Name = "xrShape16"
            Me.xrShape16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            shapeStar5.StarPointCount = 8
            Me.xrShape16.Shape = shapeStar5
            Me.xrShape16.SizeF = New System.Drawing.SizeF(133F, 92F)
            Me.xrShape16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' Shapes
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.Version = "14.1"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace