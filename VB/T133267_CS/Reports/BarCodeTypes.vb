Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.XtraReports.UI

Namespace T133267_CS.Reports
    Public Class BarCodeTypes
        Inherits XtraReport

        Private xrTableRow4 As XRTableRow
        Private xrTableCell10 As XRTableCell
        Private xrTableCell11 As XRTableCell
        Private xrBarCode3 As XRBarCode
        Private xrTableCell12 As XRTableCell
        Private xrTableCell13 As XRTableCell
        Private xrBarCode7 As XRBarCode
        Private xrBarCode11 As XRBarCode
        Private xrTableCell34 As XRTableCell
        Private xrBarCode4 As XRBarCode
        Private xrTableCell58 As XRTableCell
        Private xrTableCell78 As XRTableCell
        Private xrTableCell63 As XRTableCell
        Private xrTableRow9 As XRTableRow
        Private xrTableCell25 As XRTableCell
        Private xrTableCell26 As XRTableCell
        Private xrBarCode6 As XRBarCode
        Private xrTableCell27 As XRTableCell
        Private xrTableRow6 As XRTableRow
        Private xrTableCell16 As XRTableCell
        Private xrTableCell17 As XRTableCell
        Private xrTableCell18 As XRTableCell
        Private xrBarCode17 As XRBarCode
        Private xrBarCode5 As XRBarCode
        Private xrTableRow20 As XRTableRow
        Private xrTableCell59 As XRTableCell
        Private xrBarCode21 As XRBarCode
        Private xrTableCell60 As XRTableCell
        Private xrTableCell14 As XRTableCell
        Private xrTableCell56 As XRTableCell
        Private xrBarCode18 As XRBarCode
        Private xrBarCode20 As XRBarCode
        Private xrTableCell20 As XRTableCell
        Private xrBarCode12 As XRBarCode
        Private xrTableCell66 As XRTableCell
        Private xrTableRow2 As XRTableRow
        Private xrTableCell4 As XRTableCell
        Private xrTableCell5 As XRTableCell
        Private xrBarCode1 As XRBarCode
        Private xrTableCell6 As XRTableCell
        Private xrTableCell43 As XRTableCell
        Private TextPaddingStyle As XRControlStyle
        Private xrTableCell42 As XRTableCell
        Private xrBarCode15 As XRBarCode
        Private xrTableCell71 As XRTableCell
        Private xrBarCode25 As XRBarCode
        Private xrTableRow1 As XRTableRow
        Private xrTableCell1 As XRTableCell
        Private xrTableCell2 As XRTableCell
        Private xrTableCell3 As XRTableCell
        Private xrTableRow22 As XRTableRow
        Private xrTableCell64 As XRTableCell
        Private xrTableCell65 As XRTableCell
        Private xrBarCode23 As XRBarCode
        Private topMarginBand1 As TopMarginBand
        Private xrTableCell55 As XRTableCell
        Private xrTableRow13 As XRTableRow
        Private xrTableCell37 As XRTableCell
        Private xrTableCell38 As XRTableCell
        Private xrBarCode10 As XRBarCode
        Private xrTableCell39 As XRTableCell
        Private xrTableCell29 As XRTableCell
        Private xrTableRow26 As XRTableRow
        Private xrTableCell76 As XRTableCell
        Private xrTableCell77 As XRTableCell
        Private xrBarCode28 As XRBarCode
        Private xrBarCode27 As XRBarCode
        Private Detail As DetailBand
        Private xrTable2 As XRTable
        Private xrTableRow25 As XRTableRow
        Private xrTableCell73 As XRTableCell
        Private xrTableCell74 As XRTableCell
        Private xrBarCode26 As XRBarCode
        Private xrTableCell75 As XRTableCell
        Private xrTableRow24 As XRTableRow
        Private xrTableCell70 As XRTableCell
        Private xrTableCell72 As XRTableCell
        Private xrTableRow23 As XRTableRow
        Private xrTableCell67 As XRTableCell
        Private xrTableCell68 As XRTableCell
        Private xrBarCode24 As XRBarCode
        Private xrTableCell69 As XRTableCell
        Private xrTableRow21 As XRTableRow
        Private xrTableCell61 As XRTableCell
        Private xrTableCell62 As XRTableCell
        Private xrBarCode22 As XRBarCode
        Private xrTableRow3 As XRTableRow
        Private xrTableCell7 As XRTableCell
        Private xrTableCell8 As XRTableCell
        Private xrBarCode2 As XRBarCode
        Private xrTableCell9 As XRTableCell
        Private xrTableRow5 As XRTableRow
        Private xrTableCell15 As XRTableCell
        Private xrTableRow8 As XRTableRow
        Private xrTableCell22 As XRTableCell
        Private xrTableCell23 As XRTableCell
        Private xrTableCell24 As XRTableCell
        Private xrTableRow10 As XRTableRow
        Private xrTableCell28 As XRTableCell
        Private xrTableCell30 As XRTableCell
        Private xrTableRow11 As XRTableRow
        Private xrTableCell31 As XRTableCell
        Private xrTableCell32 As XRTableCell
        Private xrBarCode8 As XRBarCode
        Private xrTableCell33 As XRTableCell
        Private xrTableRow12 As XRTableRow
        Private xrTableCell35 As XRTableCell
        Private xrBarCode9 As XRBarCode
        Private xrTableCell36 As XRTableCell
        Private xrTableRow7 As XRTableRow
        Private xrTableCell19 As XRTableCell
        Private xrTableCell21 As XRTableCell
        Private xrTableRow14 As XRTableRow
        Private xrTableCell40 As XRTableCell
        Private xrTableCell41 As XRTableCell
        Private xrBarCode13 As XRBarCode
        Private xrTableRow15 As XRTableRow
        Private xrTableCell44 As XRTableCell
        Private xrBarCode14 As XRBarCode
        Private xrTableCell45 As XRTableCell
        Private xrTableRow16 As XRTableRow
        Private xrTableCell46 As XRTableCell
        Private xrTableCell47 As XRTableCell
        Private xrTableCell48 As XRTableCell
        Private xrTableRow17 As XRTableRow
        Private xrTableCell49 As XRTableCell
        Private xrTableCell50 As XRTableCell
        Private xrBarCode16 As XRBarCode
        Private xrTableCell51 As XRTableCell
        Private xrTableRow18 As XRTableRow
        Private xrTableCell52 As XRTableCell
        Private xrTableCell53 As XRTableCell
        Private xrBarCode19 As XRBarCode
        Private xrTableCell54 As XRTableCell
        Private xrTableRow19 As XRTableRow
        Private xrTableCell57 As XRTableCell
        Private xrLabel3 As XRLabel
        Private xrTable1 As XRTable
        Private PageHeader As PageHeaderBand
        Private AutoModuleParameter As DevExpress.XtraReports.Parameters.Parameter
        Private xrPictureBox4 As XRPictureBox
        Private ReportHeader As ReportHeaderBand
        Private xrLabel1 As XRLabel
        Private BottomMargin As BottomMarginBand

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Dim code128Generator1 As New DevExpress.XtraPrinting.BarCode.Code128Generator()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(BarCodeTypes))
            Dim code93Generator1 As New DevExpress.XtraPrinting.BarCode.Code93Generator()
            Dim interleaved2of5Generator1 As New DevExpress.XtraPrinting.BarCode.Interleaved2of5Generator()
            Dim eaN128Generator1 As New DevExpress.XtraPrinting.BarCode.EAN128Generator()
            Dim code39ExtendedGenerator1 As New DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator()
            Dim eaN13Generator1 As New DevExpress.XtraPrinting.BarCode.EAN13Generator()
            Dim code39Generator1 As New DevExpress.XtraPrinting.BarCode.Code39Generator()
            Dim pdF417Generator1 As New DevExpress.XtraPrinting.BarCode.PDF417Generator()
            Dim eaN13Generator2 As New DevExpress.XtraPrinting.BarCode.EAN13Generator()
            Dim upcSupplemental5Generator1 As New DevExpress.XtraPrinting.BarCode.UPCSupplemental5Generator()
            Dim eaN13Generator3 As New DevExpress.XtraPrinting.BarCode.EAN13Generator()
            Dim codabarGenerator1 As New DevExpress.XtraPrinting.BarCode.CodabarGenerator()
            Dim upcaGenerator1 As New DevExpress.XtraPrinting.BarCode.UPCAGenerator()
            Dim dataMatrixGS1Generator1 As New DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator()
            Dim qrCodeGenerator1 As New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
            Dim matrix2of5Generator1 As New DevExpress.XtraPrinting.BarCode.Matrix2of5Generator()
            Dim dataBarGenerator1 As New DevExpress.XtraPrinting.BarCode.DataBarGenerator()
            Dim dataBarGenerator2 As New DevExpress.XtraPrinting.BarCode.DataBarGenerator()
            Dim itF14Generator1 As New DevExpress.XtraPrinting.BarCode.ITF14Generator()
            Dim intelligentMailGenerator1 As New DevExpress.XtraPrinting.BarCode.IntelligentMailGenerator()
            Dim dataMatrixGenerator1 As New DevExpress.XtraPrinting.BarCode.DataMatrixGenerator()
            Dim code11Generator1 As New DevExpress.XtraPrinting.BarCode.Code11Generator()
            Dim code93ExtendedGenerator1 As New DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator()
            Dim industrial2of5Generator1 As New DevExpress.XtraPrinting.BarCode.Industrial2of5Generator()
            Dim eaN8Generator1 As New DevExpress.XtraPrinting.BarCode.EAN8Generator()
            Dim codeMSIGenerator1 As New DevExpress.XtraPrinting.BarCode.CodeMSIGenerator()
            Dim upcE0Generator1 As New DevExpress.XtraPrinting.BarCode.UPCE0Generator()
            Dim upcSupplemental2Generator1 As New DevExpress.XtraPrinting.BarCode.UPCSupplemental2Generator()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode3 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode7 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrBarCode11 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode4 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode6 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode17 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrBarCode5 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableRow20 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode21 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode18 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrBarCode20 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode12 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TextPaddingStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode15 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode25 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode23 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode10 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow26 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode28 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrBarCode27 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow25 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode26 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow24 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow23 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode24 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode22 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode2 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode8 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode9 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode13 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode14 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode16 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrBarCode19 = New DevExpress.XtraReports.UI.XRBarCode()
            Me.xrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.AutoModuleParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell10, Me.xrTableCell11, Me.xrTableCell12})
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow4.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell10
            ' 
            Me.xrTableCell10.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell10.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell10.Multiline = True
            Me.xrTableCell10.Name = "xrTableCell10"
            Me.xrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell10.StyleName = "TextPaddingStyle"
            Me.xrTableCell10.StylePriority.UseBackColor = False
            Me.xrTableCell10.Text = "Code 128"
            Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell10.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell11
            ' 
            Me.xrTableCell11.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell11.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode3})
            Me.xrTableCell11.Name = "xrTableCell11"
            Me.xrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell11.StylePriority.UseBackColor = False
            Me.xrTableCell11.Text = "xrTableCell11"
            Me.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell11.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode3
            ' 
            Me.xrBarCode3.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrBarCode3.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode3.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode3.Module = 1F
            Me.xrBarCode3.Name = "xrBarCode3"
            Me.xrBarCode3.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode3.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode3.StylePriority.UseBackColor = False
            code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
            Me.xrBarCode3.Symbology = code128Generator1
            Me.xrBarCode3.Text = "XRBarCode 0123456"
            Me.xrBarCode3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell12
            ' 
            Me.xrTableCell12.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell12.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell12.Name = "xrTableCell12"
            Me.xrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell12.StyleName = "TextPaddingStyle"
            Me.xrTableCell12.StylePriority.UseBackColor = False
            Me.xrTableCell12.Text = resources.GetString("xrTableCell12.Text")
            Me.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell12.Weight = 0.47324913892078074R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.BackColor = System.Drawing.Color.White
            Me.xrTableCell13.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell13.Multiline = True
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell13.StyleName = "TextPaddingStyle"
            Me.xrTableCell13.StylePriority.UseBackColor = False
            Me.xrTableCell13.Text = "EAN128"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell13.Weight = 0.14936854190585536R
            ' 
            ' xrBarCode7
            ' 
            Me.xrBarCode7.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode7.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrBarCode7.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode7.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode7.Module = 1F
            Me.xrBarCode7.Name = "xrBarCode7"
            Me.xrBarCode7.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode7.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode7.StylePriority.UseBackColor = False
            Me.xrBarCode7.Symbology = code93Generator1
            Me.xrBarCode7.Text = "XRBARCODE"
            Me.xrBarCode7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrBarCode11
            ' 
            Me.xrBarCode11.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode11.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrBarCode11.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode11.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode11.Module = 1F
            Me.xrBarCode11.Name = "xrBarCode11"
            Me.xrBarCode11.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode11.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode11.StylePriority.UseBackColor = False
            interleaved2of5Generator1.WideNarrowRatio = 3F
            Me.xrBarCode11.Symbology = interleaved2of5Generator1
            Me.xrBarCode11.Text = "0123456789"
            Me.xrBarCode11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell34
            ' 
            Me.xrTableCell34.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell34.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell34.Multiline = True
            Me.xrTableCell34.Name = "xrTableCell34"
            Me.xrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell34.StyleName = "TextPaddingStyle"
            Me.xrTableCell34.StylePriority.UseBackColor = False
            Me.xrTableCell34.Text = "Industrial" & ControlChars.CrLf & "2 of 5"
            Me.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell34.Weight = 0.14936854190585536R
            ' 
            ' xrBarCode4
            ' 
            Me.xrBarCode4.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode4.BackColor = System.Drawing.Color.White
            Me.xrBarCode4.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode4.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode4.Module = 1F
            Me.xrBarCode4.Name = "xrBarCode4"
            Me.xrBarCode4.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode4.SizeF = New System.Drawing.SizeF(251F, 59F)
            Me.xrBarCode4.StylePriority.UseBackColor = False
            eaN128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto
            Me.xrBarCode4.Symbology = eaN128Generator1
            Me.xrBarCode4.Text = "XRBarCode 0123456"
            Me.xrBarCode4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell58
            ' 
            Me.xrTableCell58.BackColor = System.Drawing.Color.White
            Me.xrTableCell58.Name = "xrTableCell58"
            Me.xrTableCell58.StyleName = "TextPaddingStyle"
            Me.xrTableCell58.StylePriority.UseBackColor = False
            Me.xrTableCell58.StylePriority.UseTextAlignment = False
            Me.xrTableCell58.Text = "PDF417"
            Me.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell58.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell78
            ' 
            Me.xrTableCell78.BackColor = System.Drawing.Color.White
            Me.xrTableCell78.BorderColor = System.Drawing.Color.White
            Me.xrTableCell78.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell78.Multiline = True
            Me.xrTableCell78.Name = "xrTableCell78"
            Me.xrTableCell78.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell78.StylePriority.UseBackColor = False
            Me.xrTableCell78.StylePriority.UseBorderColor = False
            Me.xrTableCell78.StylePriority.UseFont = False
            Me.xrTableCell78.StylePriority.UsePadding = False
            Me.xrTableCell78.StylePriority.UseTextAlignment = False
            Me.xrTableCell78.Text = resources.GetString("xrTableCell78.Text")
            Me.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell78.Weight = 0.47324913892078074R
            ' 
            ' xrTableCell63
            ' 
            Me.xrTableCell63.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell63.Multiline = True
            Me.xrTableCell63.Name = "xrTableCell63"
            Me.xrTableCell63.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell63.StylePriority.UseFont = False
            Me.xrTableCell63.StylePriority.UsePadding = False
            Me.xrTableCell63.StylePriority.UseTextAlignment = False
            Me.xrTableCell63.Text = resources.GetString("xrTableCell63.Text")
            Me.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell63.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow9
            ' 
            Me.xrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell25, Me.xrTableCell26, Me.xrTableCell27})
            Me.xrTableRow9.Name = "xrTableRow9"
            Me.xrTableRow9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow9.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell25
            ' 
            Me.xrTableCell25.BackColor = System.Drawing.Color.White
            Me.xrTableCell25.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell25.Multiline = True
            Me.xrTableCell25.Name = "xrTableCell25"
            Me.xrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell25.StyleName = "TextPaddingStyle"
            Me.xrTableCell25.StylePriority.UseBackColor = False
            Me.xrTableCell25.Text = "Code 39 Extended"
            Me.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell25.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell26
            ' 
            Me.xrTableCell26.BackColor = System.Drawing.Color.White
            Me.xrTableCell26.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode6})
            Me.xrTableCell26.Name = "xrTableCell26"
            Me.xrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell26.StylePriority.UseBackColor = False
            Me.xrTableCell26.Text = "xrTableCell26"
            Me.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell26.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode6
            ' 
            Me.xrBarCode6.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode6.BackColor = System.Drawing.Color.White
            Me.xrBarCode6.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode6.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode6.Module = 1F
            Me.xrBarCode6.Name = "xrBarCode6"
            Me.xrBarCode6.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode6.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode6.StylePriority.UseBackColor = False
            code39ExtendedGenerator1.WideNarrowRatio = 3F
            Me.xrBarCode6.Symbology = code39ExtendedGenerator1
            Me.xrBarCode6.Text = "BarCODE"
            Me.xrBarCode6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell27
            ' 
            Me.xrTableCell27.BackColor = System.Drawing.Color.White
            Me.xrTableCell27.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell27.Name = "xrTableCell27"
            Me.xrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell27.StyleName = "TextPaddingStyle"
            Me.xrTableCell27.StylePriority.UseBackColor = False
            Me.xrTableCell27.Text = resources.GetString("xrTableCell27.Text")
            Me.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell27.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell16, Me.xrTableCell17, Me.xrTableCell18})
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow6.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell16
            ' 
            Me.xrTableCell16.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell16.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell16.Multiline = True
            Me.xrTableCell16.Name = "xrTableCell16"
            Me.xrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell16.StyleName = "TextPaddingStyle"
            Me.xrTableCell16.StylePriority.UseBackColor = False
            Me.xrTableCell16.Text = "Interleaved" & ControlChars.CrLf & "2 of 5"
            Me.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell16.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell17
            ' 
            Me.xrTableCell17.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell17.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode11})
            Me.xrTableCell17.Name = "xrTableCell17"
            Me.xrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell17.StylePriority.UseBackColor = False
            Me.xrTableCell17.Text = "xrTableCell17"
            Me.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell17.Weight = 0.3773823191733639R
            ' 
            ' xrTableCell18
            ' 
            Me.xrTableCell18.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell18.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell18.Name = "xrTableCell18"
            Me.xrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell18.StyleName = "TextPaddingStyle"
            Me.xrTableCell18.StylePriority.UseBackColor = False
            Me.xrTableCell18.Text = "Interleaved 2 of 5 is a higher-density numeric symbology based upon the Standard " & "2 of 5 symbology. It is used primarily in the distribution and warehouse industr" & "y."
            Me.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell18.Weight = 0.47324913892078074R
            ' 
            ' xrBarCode17
            ' 
            Me.xrBarCode17.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrBarCode17.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode17.LocationFloat = New DevExpress.Utils.PointFloat(33F, 0F)
            Me.xrBarCode17.Module = 1F
            Me.xrBarCode17.Name = "xrBarCode17"
            Me.xrBarCode17.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F)
            Me.xrBarCode17.SizeF = New System.Drawing.SizeF(133F, 60F)
            Me.xrBarCode17.StylePriority.UseBackColor = False
            Me.xrBarCode17.Symbology = eaN13Generator1
            Me.xrBarCode17.Text = "978531800111"
            Me.xrBarCode17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrBarCode5
            ' 
            Me.xrBarCode5.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrBarCode5.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode5.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode5.Module = 1F
            Me.xrBarCode5.Name = "xrBarCode5"
            Me.xrBarCode5.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode5.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode5.StylePriority.UseBackColor = False
            code39Generator1.WideNarrowRatio = 3F
            Me.xrBarCode5.Symbology = code39Generator1
            Me.xrBarCode5.Text = "XRBARCODE"
            Me.xrBarCode5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow20
            ' 
            Me.xrTableRow20.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell58, Me.xrTableCell59, Me.xrTableCell60})
            Me.xrTableRow20.Name = "xrTableRow20"
            Me.xrTableRow20.Weight = 0.11R
            ' 
            ' xrTableCell59
            ' 
            Me.xrTableCell59.BackColor = System.Drawing.Color.White
            Me.xrTableCell59.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode21})
            Me.xrTableCell59.Name = "xrTableCell59"
            Me.xrTableCell59.StylePriority.UseBackColor = False
            Me.xrTableCell59.Text = "xrTableCell59"
            Me.xrTableCell59.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode21
            ' 
            Me.xrBarCode21.Alignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.xrBarCode21.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
            Me.xrBarCode21.LocationFloat = New DevExpress.Utils.PointFloat(1.100014F, 0F)
            Me.xrBarCode21.Module = 1F
            Me.xrBarCode21.Name = "xrBarCode21"
            Me.xrBarCode21.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F)
            Me.xrBarCode21.ShowText = False
            Me.xrBarCode21.SizeF = New System.Drawing.SizeF(251.7461F, 120.0001F)
            Me.xrBarCode21.StylePriority.UsePadding = False
            pdF417Generator1.Columns = 9
            pdF417Generator1.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.ErrorCorrectionLevel.Level0
            pdF417Generator1.Rows = 36
            Me.xrBarCode21.Symbology = pdF417Generator1
            Me.xrBarCode21.Text = resources.GetString("xrBarCode21.Text")
            ' 
            ' xrTableCell60
            ' 
            Me.xrTableCell60.BackColor = System.Drawing.Color.White
            Me.xrTableCell60.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell60.Multiline = True
            Me.xrTableCell60.Name = "xrTableCell60"
            Me.xrTableCell60.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell60.StylePriority.UseBackColor = False
            Me.xrTableCell60.StylePriority.UsePadding = False
            Me.xrTableCell60.StylePriority.UseTextAlignment = False
            Me.xrTableCell60.Text = resources.GetString("xrTableCell60.Text")
            Me.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell60.Weight = 0.47324913892078074R
            ' 
            ' xrTableCell14
            ' 
            Me.xrTableCell14.BackColor = System.Drawing.Color.White
            Me.xrTableCell14.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode4})
            Me.xrTableCell14.Name = "xrTableCell14"
            Me.xrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell14.StylePriority.UseBackColor = False
            Me.xrTableCell14.Text = "xrTableCell14"
            Me.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell14.Weight = 0.3773823191733639R
            ' 
            ' xrTableCell56
            ' 
            Me.xrTableCell56.BackColor = System.Drawing.Color.White
            Me.xrTableCell56.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode18, Me.xrBarCode20})
            Me.xrTableCell56.Name = "xrTableCell56"
            Me.xrTableCell56.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell56.StylePriority.UseBackColor = False
            Me.xrTableCell56.Text = "xrTableCell56"
            Me.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell56.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode18
            ' 
            Me.xrBarCode18.BackColor = System.Drawing.Color.White
            Me.xrBarCode18.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode18.LocationFloat = New DevExpress.Utils.PointFloat(25F, 0F)
            Me.xrBarCode18.Module = 1F
            Me.xrBarCode18.Name = "xrBarCode18"
            Me.xrBarCode18.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F)
            Me.xrBarCode18.SizeF = New System.Drawing.SizeF(133F, 60F)
            Me.xrBarCode18.StylePriority.UseBackColor = False
            Me.xrBarCode18.Symbology = eaN13Generator2
            Me.xrBarCode18.Text = "978531800111"
            Me.xrBarCode18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrBarCode20
            ' 
            Me.xrBarCode20.BackColor = System.Drawing.Color.White
            Me.xrBarCode20.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode20.LocationFloat = New DevExpress.Utils.PointFloat(158F, 0F)
            Me.xrBarCode20.Module = 1F
            Me.xrBarCode20.Name = "xrBarCode20"
            Me.xrBarCode20.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 4, 0, 100F)
            Me.xrBarCode20.SizeF = New System.Drawing.SizeF(75F, 60F)
            Me.xrBarCode20.StylePriority.UseBackColor = False
            Me.xrBarCode20.Symbology = upcSupplemental5Generator1
            Me.xrBarCode20.Text = "01234"
            Me.xrBarCode20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' xrTableCell20
            ' 
            Me.xrTableCell20.BackColor = System.Drawing.Color.White
            Me.xrTableCell20.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode12})
            Me.xrTableCell20.Name = "xrTableCell20"
            Me.xrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell20.StylePriority.UseBackColor = False
            Me.xrTableCell20.Text = "xrTableCell20"
            Me.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell20.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode12
            ' 
            Me.xrBarCode12.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode12.BackColor = System.Drawing.Color.White
            Me.xrBarCode12.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode12.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode12.Module = 1F
            Me.xrBarCode12.Name = "xrBarCode12"
            Me.xrBarCode12.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode12.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode12.StylePriority.UseBackColor = False
            Me.xrBarCode12.Symbology = eaN13Generator3
            Me.xrBarCode12.Text = "978531800111"
            Me.xrBarCode12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell66
            ' 
            Me.xrTableCell66.BackColor = System.Drawing.Color.White
            Me.xrTableCell66.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell66.Multiline = True
            Me.xrTableCell66.Name = "xrTableCell66"
            Me.xrTableCell66.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell66.StylePriority.UseBackColor = False
            Me.xrTableCell66.StylePriority.UseFont = False
            Me.xrTableCell66.StylePriority.UsePadding = False
            Me.xrTableCell66.StylePriority.UseTextAlignment = False
            Me.xrTableCell66.Text = resources.GetString("xrTableCell66.Text")
            Me.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell66.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell4.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell4.Multiline = True
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell4.StyleName = "TextPaddingStyle"
            Me.xrTableCell4.StylePriority.UseBackColor = False
            Me.xrTableCell4.Text = "Codabar"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell4.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode1})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell5.StylePriority.UseBackColor = False
            Me.xrTableCell5.Text = "xrTableCell5"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell5.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode1
            ' 
            Me.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode1.Module = 1F
            Me.xrBarCode1.Name = "xrBarCode1"
            Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode1.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode1.StylePriority.UseBackColor = False
            codabarGenerator1.WideNarrowRatio = 2F
            Me.xrBarCode1.Symbology = codabarGenerator1
            Me.xrBarCode1.Text = "0123456789+-/:.$"
            Me.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell6.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell6.StyleName = "TextPaddingStyle"
            Me.xrTableCell6.StylePriority.UseBackColor = False
            Me.xrTableCell6.Text = resources.GetString("xrTableCell6.Text")
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell6.Weight = 0.47324913892078074R
            ' 
            ' xrTableCell43
            ' 
            Me.xrTableCell43.BackColor = System.Drawing.Color.White
            Me.xrTableCell43.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell43.Multiline = True
            Me.xrTableCell43.Name = "xrTableCell43"
            Me.xrTableCell43.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell43.StyleName = "TextPaddingStyle"
            Me.xrTableCell43.StylePriority.UseBackColor = False
            Me.xrTableCell43.Text = "MSI/Plessey"
            Me.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell43.Weight = 0.14936854190585536R
            ' 
            ' TextPaddingStyle
            ' 
            Me.TextPaddingStyle.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.TextPaddingStyle.Name = "TextPaddingStyle"
            ' 
            ' xrTableCell42
            ' 
            Me.xrTableCell42.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell42.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell42.Name = "xrTableCell42"
            Me.xrTableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell42.StyleName = "TextPaddingStyle"
            Me.xrTableCell42.StylePriority.UseBackColor = False
            Me.xrTableCell42.Text = "EAN-8 is the EAN equivalent of UPC-E in the sense that it provides a ""short"" barc" & "ode for small packages."
            Me.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell42.Weight = 0.47324913892078074R
            ' 
            ' xrBarCode15
            ' 
            Me.xrBarCode15.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode15.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrBarCode15.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode15.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode15.Module = 1F
            Me.xrBarCode15.Name = "xrBarCode15"
            Me.xrBarCode15.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode15.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode15.StylePriority.UseBackColor = False
            Me.xrBarCode15.Symbology = upcaGenerator1
            Me.xrBarCode15.Text = "78534235463"
            Me.xrBarCode15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell71
            ' 
            Me.xrTableCell71.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode25})
            Me.xrTableCell71.Name = "xrTableCell71"
            Me.xrTableCell71.Text = "xrTableCell71"
            Me.xrTableCell71.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode25
            ' 
            Me.xrBarCode25.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode25.BackColor = System.Drawing.Color.White
            Me.xrBarCode25.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode25.Name = "xrBarCode25"
            Me.xrBarCode25.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F)
            Me.xrBarCode25.ShowText = False
            Me.xrBarCode25.SizeF = New System.Drawing.SizeF(249.1538F, 105.0473F)
            Me.xrBarCode25.StylePriority.UseBackColor = False
            Me.xrBarCode25.StylePriority.UsePadding = False
            Me.xrBarCode25.Symbology = dataMatrixGS1Generator1
            Me.xrBarCode25.Text = "010031234567890621123456789012#300144"
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.Text = "Symbology"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.Text = "Example"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.3773823191733639R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell3.Text = "Description"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell3.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow22
            ' 
            Me.xrTableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell64, Me.xrTableCell65, Me.xrTableCell66})
            Me.xrTableRow22.Name = "xrTableRow22"
            Me.xrTableRow22.StylePriority.UseBackColor = False
            Me.xrTableRow22.StylePriority.UseTextAlignment = False
            Me.xrTableRow22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableRow22.Weight = 0.084843876334442653R
            ' 
            ' xrTableCell64
            ' 
            Me.xrTableCell64.BackColor = System.Drawing.Color.White
            Me.xrTableCell64.Name = "xrTableCell64"
            Me.xrTableCell64.StyleName = "TextPaddingStyle"
            Me.xrTableCell64.StylePriority.UseBackColor = False
            Me.xrTableCell64.Text = "QR Code"
            Me.xrTableCell64.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell65
            ' 
            Me.xrTableCell65.BackColor = System.Drawing.Color.White
            Me.xrTableCell65.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode23})
            Me.xrTableCell65.Name = "xrTableCell65"
            Me.xrTableCell65.StylePriority.UseBackColor = False
            Me.xrTableCell65.Text = "xrTableCell65"
            Me.xrTableCell65.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode23
            ' 
            Me.xrBarCode23.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode23.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
            Me.xrBarCode23.LocationFloat = New DevExpress.Utils.PointFloat(1.100014F, 0F)
            Me.xrBarCode23.Module = 3F
            Me.xrBarCode23.Name = "xrBarCode23"
            Me.xrBarCode23.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F)
            Me.xrBarCode23.ShowText = False
            Me.xrBarCode23.SizeF = New System.Drawing.SizeF(251.7462F, 94.85706F)
            Me.xrBarCode23.StylePriority.UsePadding = False
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version2
            Me.xrBarCode23.Symbology = qrCodeGenerator1
            Me.xrBarCode23.Text = "URL:http://www.devexpress.com"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 86F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' xrTableCell55
            ' 
            Me.xrTableCell55.BackColor = System.Drawing.Color.White
            Me.xrTableCell55.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell55.Multiline = True
            Me.xrTableCell55.Name = "xrTableCell55"
            Me.xrTableCell55.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell55.StyleName = "TextPaddingStyle"
            Me.xrTableCell55.StylePriority.UseBackColor = False
            Me.xrTableCell55.Text = "EAN13" & ControlChars.CrLf & "with" & ControlChars.CrLf & "UPC Suppl. 5"
            Me.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell55.Weight = 0.14936854190585536R
            ' 
            ' xrTableRow13
            ' 
            Me.xrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell37, Me.xrTableCell38, Me.xrTableCell39})
            Me.xrTableRow13.Name = "xrTableRow13"
            Me.xrTableRow13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow13.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell37
            ' 
            Me.xrTableCell37.BackColor = System.Drawing.Color.White
            Me.xrTableCell37.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell37.Multiline = True
            Me.xrTableCell37.Name = "xrTableCell37"
            Me.xrTableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell37.StyleName = "TextPaddingStyle"
            Me.xrTableCell37.StylePriority.UseBackColor = False
            Me.xrTableCell37.Text = "Matrix" & ControlChars.CrLf & "2 of 5"
            Me.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell37.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell38
            ' 
            Me.xrTableCell38.BackColor = System.Drawing.Color.White
            Me.xrTableCell38.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode10})
            Me.xrTableCell38.Name = "xrTableCell38"
            Me.xrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell38.StylePriority.UseBackColor = False
            Me.xrTableCell38.Text = "xrTableCell38"
            Me.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell38.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode10
            ' 
            Me.xrBarCode10.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode10.BackColor = System.Drawing.Color.White
            Me.xrBarCode10.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode10.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode10.Module = 1F
            Me.xrBarCode10.Name = "xrBarCode10"
            Me.xrBarCode10.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode10.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode10.StylePriority.UseBackColor = False
            Me.xrBarCode10.Symbology = matrix2of5Generator1
            Me.xrBarCode10.Text = "00123456789"
            Me.xrBarCode10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell39
            ' 
            Me.xrTableCell39.BackColor = System.Drawing.Color.White
            Me.xrTableCell39.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell39.Name = "xrTableCell39"
            Me.xrTableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell39.StyleName = "TextPaddingStyle"
            Me.xrTableCell39.StylePriority.UseBackColor = False
            Me.xrTableCell39.Text = resources.GetString("xrTableCell39.Text")
            Me.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell39.Weight = 0.47324913892078074R
            ' 
            ' xrTableCell29
            ' 
            Me.xrTableCell29.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell29.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode7})
            Me.xrTableCell29.Name = "xrTableCell29"
            Me.xrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell29.StylePriority.UseBackColor = False
            Me.xrTableCell29.Text = "xrTableCell29"
            Me.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell29.Weight = 0.3773823191733639R
            ' 
            ' xrTableRow26
            ' 
            Me.xrTableRow26.BackColor = System.Drawing.Color.White
            Me.xrTableRow26.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell76, Me.xrTableCell77, Me.xrTableCell78})
            Me.xrTableRow26.Name = "xrTableRow26"
            Me.xrTableRow26.StylePriority.UseBackColor = False
            Me.xrTableRow26.Weight = 0.19355560919964779R
            ' 
            ' xrTableCell76
            ' 
            Me.xrTableCell76.BackColor = System.Drawing.Color.White
            Me.xrTableCell76.BorderColor = System.Drawing.Color.White
            Me.xrTableCell76.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell76.Name = "xrTableCell76"
            Me.xrTableCell76.StylePriority.UseBackColor = False
            Me.xrTableCell76.StylePriority.UseBorderColor = False
            Me.xrTableCell76.StylePriority.UseFont = False
            Me.xrTableCell76.StylePriority.UseTextAlignment = False
            Me.xrTableCell76.Text = "DataBar"
            Me.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell76.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell77
            ' 
            Me.xrTableCell77.BackColor = System.Drawing.Color.White
            Me.xrTableCell77.BorderColor = System.Drawing.Color.White
            Me.xrTableCell77.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode28, Me.xrBarCode27})
            Me.xrTableCell77.Name = "xrTableCell77"
            Me.xrTableCell77.StylePriority.UseBackColor = False
            Me.xrTableCell77.StylePriority.UseBorderColor = False
            Me.xrTableCell77.StylePriority.UseTextAlignment = False
            Me.xrTableCell77.Text = "xrTableCell77"
            Me.xrTableCell77.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode28
            ' 
            Me.xrBarCode28.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode28.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
            Me.xrBarCode28.BackColor = System.Drawing.Color.White
            Me.xrBarCode28.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 154.65F)
            Me.xrBarCode28.Module = 1.75F
            Me.xrBarCode28.Name = "xrBarCode28"
            Me.xrBarCode28.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 4, 0, 100F)
            Me.xrBarCode28.SizeF = New System.Drawing.SizeF(251F, 51.74995F)
            Me.xrBarCode28.StylePriority.UseBackColor = False
            Me.xrBarCode28.StylePriority.UsePadding = False
            Me.xrBarCode28.StylePriority.UseTextAlignment = False
            dataBarGenerator1.SegmentsInRow = 4
            dataBarGenerator1.Type = DevExpress.XtraPrinting.BarCode.DataBarType.Truncated
            Me.xrBarCode28.Symbology = dataBarGenerator1
            Me.xrBarCode28.Text = "123456789"
            Me.xrBarCode28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrBarCode27
            ' 
            Me.xrBarCode27.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode27.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
            Me.xrBarCode27.BackColor = System.Drawing.Color.White
            Me.xrBarCode27.Font = New System.Drawing.Font("Times New Roman", 8.75F)
            Me.xrBarCode27.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode27.Module = 1.75F
            Me.xrBarCode27.Name = "xrBarCode27"
            Me.xrBarCode27.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 4, 0, 100F)
            Me.xrBarCode27.SizeF = New System.Drawing.SizeF(251F, 147.982F)
            Me.xrBarCode27.StylePriority.UseBackColor = False
            Me.xrBarCode27.StylePriority.UseFont = False
            Me.xrBarCode27.StylePriority.UsePadding = False
            Me.xrBarCode27.StylePriority.UseTextAlignment = False
            dataBarGenerator2.SegmentsInRow = 4
            dataBarGenerator2.Type = DevExpress.XtraPrinting.BarCode.DataBarType.ExpandedStacked
            Me.xrBarCode27.Symbology = dataBarGenerator2
            Me.xrBarCode27.Text = "01906141410000153202000150"
            Me.xrBarCode27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' Detail
            ' 
            Me.Detail.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail.HeightF = 2023.267F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BorderColor = System.Drawing.Color.White
            Me.xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow26, Me.xrTableRow25, Me.xrTableRow24, Me.xrTableRow23, Me.xrTableRow22, Me.xrTableRow21, Me.xrTableRow20, Me.xrTableRow2, Me.xrTableRow3, Me.xrTableRow4, Me.xrTableRow5, Me.xrTableRow8, Me.xrTableRow9, Me.xrTableRow10, Me.xrTableRow11, Me.xrTableRow12, Me.xrTableRow13, Me.xrTableRow6, Me.xrTableRow7, Me.xrTableRow14, Me.xrTableRow15, Me.xrTableRow16, Me.xrTableRow17, Me.xrTableRow18, Me.xrTableRow19})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(670F, 2003.267F)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow25
            ' 
            Me.xrTableRow25.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell73, Me.xrTableCell74, Me.xrTableCell75})
            Me.xrTableRow25.Name = "xrTableRow25"
            Me.xrTableRow25.Weight = 0.089443999426061266R
            ' 
            ' xrTableCell73
            ' 
            Me.xrTableCell73.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell73.Name = "xrTableCell73"
            Me.xrTableCell73.StylePriority.UseFont = False
            Me.xrTableCell73.StylePriority.UseTextAlignment = False
            Me.xrTableCell73.Text = "UPC Shipping Container Symbol (ITF-14)"
            Me.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell73.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell74
            ' 
            Me.xrTableCell74.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode26})
            Me.xrTableCell74.Name = "xrTableCell74"
            Me.xrTableCell74.Text = "xrTableCell74"
            Me.xrTableCell74.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode26
            ' 
            Me.xrBarCode26.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode26.LocationFloat = New DevExpress.Utils.PointFloat(1.846186F, 0F)
            Me.xrBarCode26.Module = 1.2F
            Me.xrBarCode26.Name = "xrBarCode26"
            Me.xrBarCode26.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 2, 100F)
            Me.xrBarCode26.SizeF = New System.Drawing.SizeF(251F, 100F)
            Me.xrBarCode26.StylePriority.UsePadding = False
            Me.xrBarCode26.StylePriority.UseTextAlignment = False
            itF14Generator1.WideNarrowRatio = 3F
            Me.xrBarCode26.Symbology = itF14Generator1
            Me.xrBarCode26.Text = "1234567890123"
            Me.xrBarCode26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' xrTableCell75
            ' 
            Me.xrTableCell75.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell75.Multiline = True
            Me.xrTableCell75.Name = "xrTableCell75"
            Me.xrTableCell75.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell75.StylePriority.UseFont = False
            Me.xrTableCell75.StylePriority.UsePadding = False
            Me.xrTableCell75.StylePriority.UseTextAlignment = False
            Me.xrTableCell75.Text = resources.GetString("xrTableCell75.Text")
            Me.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell75.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow24
            ' 
            Me.xrTableRow24.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell70, Me.xrTableCell71, Me.xrTableCell72})
            Me.xrTableRow24.Name = "xrTableRow24"
            Me.xrTableRow24.StyleName = "TextPaddingStyle"
            Me.xrTableRow24.StylePriority.UseBackColor = False
            Me.xrTableRow24.Weight = 0.093958501291118587R
            ' 
            ' xrTableCell70
            ' 
            Me.xrTableCell70.BackColor = System.Drawing.Color.White
            Me.xrTableCell70.Name = "xrTableCell70"
            Me.xrTableCell70.StylePriority.UseBackColor = False
            Me.xrTableCell70.StylePriority.UseTextAlignment = False
            Me.xrTableCell70.Text = "Data Matrix GS1"
            Me.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell70.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell72
            ' 
            Me.xrTableCell72.BackColor = System.Drawing.Color.White
            Me.xrTableCell72.Name = "xrTableCell72"
            Me.xrTableCell72.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell72.StylePriority.UseBackColor = False
            Me.xrTableCell72.StylePriority.UsePadding = False
            Me.xrTableCell72.StylePriority.UseTextAlignment = False
            Me.xrTableCell72.Text = resources.GetString("xrTableCell72.Text")
            Me.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell72.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow23
            ' 
            Me.xrTableRow23.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell67, Me.xrTableCell68, Me.xrTableCell69})
            Me.xrTableRow23.Name = "xrTableRow23"
            Me.xrTableRow23.Weight = 0.084843876334442653R
            ' 
            ' xrTableCell67
            ' 
            Me.xrTableCell67.Name = "xrTableCell67"
            Me.xrTableCell67.StyleName = "TextPaddingStyle"
            Me.xrTableCell67.StylePriority.UseTextAlignment = False
            Me.xrTableCell67.Text = "Intelligent Mail"
            Me.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell67.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell68
            ' 
            Me.xrTableCell68.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode24})
            Me.xrTableCell68.Name = "xrTableCell68"
            Me.xrTableCell68.Text = "xrTableCell68"
            Me.xrTableCell68.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode24
            ' 
            Me.xrBarCode24.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode24.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
            Me.xrBarCode24.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode24.Module = 1.75F
            Me.xrBarCode24.Name = "xrBarCode24"
            Me.xrBarCode24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrBarCode24.ShowText = False
            Me.xrBarCode24.SizeF = New System.Drawing.SizeF(251F, 94.85698F)
            Me.xrBarCode24.StylePriority.UsePadding = False
            Me.xrBarCode24.Symbology = intelligentMailGenerator1
            Me.xrBarCode24.Text = "4408200000012345678991203"
            ' 
            ' xrTableCell69
            ' 
            Me.xrTableCell69.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell69.Name = "xrTableCell69"
            Me.xrTableCell69.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell69.StylePriority.UseFont = False
            Me.xrTableCell69.StylePriority.UsePadding = False
            Me.xrTableCell69.StylePriority.UseTextAlignment = False
            Me.xrTableCell69.Text = resources.GetString("xrTableCell69.Text")
            Me.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell69.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow21
            ' 
            Me.xrTableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell61, Me.xrTableCell62, Me.xrTableCell63})
            Me.xrTableRow21.Name = "xrTableRow21"
            Me.xrTableRow21.Weight = 0.13515612366555735R
            ' 
            ' xrTableCell61
            ' 
            Me.xrTableCell61.Name = "xrTableCell61"
            Me.xrTableCell61.StyleName = "TextPaddingStyle"
            Me.xrTableCell61.StylePriority.UseTextAlignment = False
            Me.xrTableCell61.Text = "Data Matrix"
            Me.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell61.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell62
            ' 
            Me.xrTableCell62.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode22})
            Me.xrTableCell62.Name = "xrTableCell62"
            Me.xrTableCell62.StylePriority.UseTextAlignment = False
            Me.xrTableCell62.Text = "xrTableCell62"
            Me.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell62.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode22
            ' 
            Me.xrBarCode22.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode22.AnchorVertical = (CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles))
            Me.xrBarCode22.LocationFloat = New DevExpress.Utils.PointFloat(1.100014F, 0F)
            Me.xrBarCode22.Module = 1F
            Me.xrBarCode22.Name = "xrBarCode22"
            Me.xrBarCode22.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F)
            Me.xrBarCode22.ShowText = False
            Me.xrBarCode22.SizeF = New System.Drawing.SizeF(251.7462F, 151.107F)
            Me.xrBarCode22.StylePriority.UsePadding = False
            Me.xrBarCode22.StylePriority.UseTextAlignment = False
            Me.xrBarCode22.Symbology = dataMatrixGenerator1
            Me.xrBarCode22.Text = resources.GetString("xrBarCode22.Text")
            Me.xrBarCode22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.BackColor = System.Drawing.Color.White
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow3.StylePriority.UseBackColor = False
            Me.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow3.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.BackColor = System.Drawing.Color.White
            Me.xrTableCell7.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell7.Multiline = True
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell7.StyleName = "TextPaddingStyle"
            Me.xrTableCell7.StylePriority.UseBackColor = False
            Me.xrTableCell7.Text = "Code 11"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell7.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.BackColor = System.Drawing.Color.White
            Me.xrTableCell8.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode2})
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.StylePriority.UseBackColor = False
            Me.xrTableCell8.Text = "xrTableCell8"
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell8.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode2
            ' 
            Me.xrBarCode2.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode2.BackColor = System.Drawing.Color.White
            Me.xrBarCode2.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode2.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode2.Name = "xrBarCode2"
            Me.xrBarCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode2.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode2.StylePriority.UseBackColor = False
            Me.xrBarCode2.Symbology = code11Generator1
            Me.xrBarCode2.Text = "0123456"
            Me.xrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell9
            ' 
            Me.xrTableCell9.BackColor = System.Drawing.Color.White
            Me.xrTableCell9.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell9.Name = "xrTableCell9"
            Me.xrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell9.StyleName = "TextPaddingStyle"
            Me.xrTableCell9.StylePriority.UseBackColor = False
            Me.xrTableCell9.Text = resources.GetString("xrTableCell9.Text")
            Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell9.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell13, Me.xrTableCell14, Me.xrTableCell15})
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow5.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell15
            ' 
            Me.xrTableCell15.BackColor = System.Drawing.Color.White
            Me.xrTableCell15.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell15.Name = "xrTableCell15"
            Me.xrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell15.StyleName = "TextPaddingStyle"
            Me.xrTableCell15.StylePriority.UseBackColor = False
            Me.xrTableCell15.Text = resources.GetString("xrTableCell15.Text")
            Me.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell15.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow8
            ' 
            Me.xrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell22, Me.xrTableCell23, Me.xrTableCell24})
            Me.xrTableRow8.Name = "xrTableRow8"
            Me.xrTableRow8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow8.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell22
            ' 
            Me.xrTableCell22.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell22.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell22.Multiline = True
            Me.xrTableCell22.Name = "xrTableCell22"
            Me.xrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell22.StyleName = "TextPaddingStyle"
            Me.xrTableCell22.StylePriority.UseBackColor = False
            Me.xrTableCell22.Text = "Code 39"
            Me.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell22.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell23
            ' 
            Me.xrTableCell23.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell23.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode5})
            Me.xrTableCell23.Name = "xrTableCell23"
            Me.xrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell23.StylePriority.UseBackColor = False
            Me.xrTableCell23.Text = "xrTableCell23"
            Me.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell23.Weight = 0.3773823191733639R
            ' 
            ' xrTableCell24
            ' 
            Me.xrTableCell24.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell24.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell24.Name = "xrTableCell24"
            Me.xrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell24.StyleName = "TextPaddingStyle"
            Me.xrTableCell24.StylePriority.UseBackColor = False
            Me.xrTableCell24.Text = resources.GetString("xrTableCell24.Text")
            Me.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell24.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow10
            ' 
            Me.xrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell28, Me.xrTableCell29, Me.xrTableCell30})
            Me.xrTableRow10.Name = "xrTableRow10"
            Me.xrTableRow10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow10.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell28
            ' 
            Me.xrTableCell28.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell28.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell28.Multiline = True
            Me.xrTableCell28.Name = "xrTableCell28"
            Me.xrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell28.StyleName = "TextPaddingStyle"
            Me.xrTableCell28.StylePriority.UseBackColor = False
            Me.xrTableCell28.Text = "Code 93"
            Me.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell28.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell30
            ' 
            Me.xrTableCell30.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell30.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell30.Name = "xrTableCell30"
            Me.xrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell30.StyleName = "TextPaddingStyle"
            Me.xrTableCell30.StylePriority.UseBackColor = False
            Me.xrTableCell30.Text = resources.GetString("xrTableCell30.Text")
            Me.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell30.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow11
            ' 
            Me.xrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell31, Me.xrTableCell32, Me.xrTableCell33})
            Me.xrTableRow11.Name = "xrTableRow11"
            Me.xrTableRow11.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow11.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell31
            ' 
            Me.xrTableCell31.BackColor = System.Drawing.Color.White
            Me.xrTableCell31.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell31.Multiline = True
            Me.xrTableCell31.Name = "xrTableCell31"
            Me.xrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell31.StyleName = "TextPaddingStyle"
            Me.xrTableCell31.StylePriority.UseBackColor = False
            Me.xrTableCell31.Text = "Code 93 Extended"
            Me.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell31.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell32
            ' 
            Me.xrTableCell32.BackColor = System.Drawing.Color.White
            Me.xrTableCell32.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode8})
            Me.xrTableCell32.Name = "xrTableCell32"
            Me.xrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell32.StylePriority.UseBackColor = False
            Me.xrTableCell32.Text = "xrTableCell32"
            Me.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell32.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode8
            ' 
            Me.xrBarCode8.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode8.BackColor = System.Drawing.Color.White
            Me.xrBarCode8.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode8.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode8.Module = 1F
            Me.xrBarCode8.Name = "xrBarCode8"
            Me.xrBarCode8.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode8.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode8.StylePriority.UseBackColor = False
            Me.xrBarCode8.Symbology = code93ExtendedGenerator1
            Me.xrBarCode8.Text = "XRBarCode"
            Me.xrBarCode8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell33
            ' 
            Me.xrTableCell33.BackColor = System.Drawing.Color.White
            Me.xrTableCell33.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell33.Name = "xrTableCell33"
            Me.xrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell33.StyleName = "TextPaddingStyle"
            Me.xrTableCell33.StylePriority.UseBackColor = False
            Me.xrTableCell33.Text = resources.GetString("xrTableCell33.Text")
            Me.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell33.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow12
            ' 
            Me.xrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell34, Me.xrTableCell35, Me.xrTableCell36})
            Me.xrTableRow12.Name = "xrTableRow12"
            Me.xrTableRow12.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow12.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell35
            ' 
            Me.xrTableCell35.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell35.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode9})
            Me.xrTableCell35.Name = "xrTableCell35"
            Me.xrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell35.StylePriority.UseBackColor = False
            Me.xrTableCell35.Text = "xrTableCell35"
            Me.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell35.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode9
            ' 
            Me.xrBarCode9.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrBarCode9.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode9.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode9.Module = 1F
            Me.xrBarCode9.Name = "xrBarCode9"
            Me.xrBarCode9.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode9.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode9.StylePriority.UseBackColor = False
            Me.xrBarCode9.Symbology = industrial2of5Generator1
            Me.xrBarCode9.Text = "0123456789"
            Me.xrBarCode9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell36
            ' 
            Me.xrTableCell36.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell36.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell36.Name = "xrTableCell36"
            Me.xrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell36.StyleName = "TextPaddingStyle"
            Me.xrTableCell36.StylePriority.UseBackColor = False
            Me.xrTableCell36.Text = resources.GetString("xrTableCell36.Text")
            Me.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell36.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow7
            ' 
            Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell19, Me.xrTableCell20, Me.xrTableCell21})
            Me.xrTableRow7.Name = "xrTableRow7"
            Me.xrTableRow7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow7.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell19
            ' 
            Me.xrTableCell19.BackColor = System.Drawing.Color.White
            Me.xrTableCell19.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell19.Multiline = True
            Me.xrTableCell19.Name = "xrTableCell19"
            Me.xrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell19.StyleName = "TextPaddingStyle"
            Me.xrTableCell19.StylePriority.UseBackColor = False
            Me.xrTableCell19.Text = "EAN13"
            Me.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell19.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell21
            ' 
            Me.xrTableCell21.BackColor = System.Drawing.Color.White
            Me.xrTableCell21.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell21.Name = "xrTableCell21"
            Me.xrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell21.StyleName = "TextPaddingStyle"
            Me.xrTableCell21.StylePriority.UseBackColor = False
            Me.xrTableCell21.Text = "EAN-13, based upon the UPC-A standard, was implemented by the International Artic" & "le Numbering Association (EAN) in Europe."
            Me.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell21.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow14
            ' 
            Me.xrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell40, Me.xrTableCell41, Me.xrTableCell42})
            Me.xrTableRow14.Name = "xrTableRow14"
            Me.xrTableRow14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow14.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell40
            ' 
            Me.xrTableCell40.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell40.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell40.Multiline = True
            Me.xrTableCell40.Name = "xrTableCell40"
            Me.xrTableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell40.StyleName = "TextPaddingStyle"
            Me.xrTableCell40.StylePriority.UseBackColor = False
            Me.xrTableCell40.Text = "EAN8"
            Me.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell40.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell41
            ' 
            Me.xrTableCell41.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell41.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode13})
            Me.xrTableCell41.Name = "xrTableCell41"
            Me.xrTableCell41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell41.StylePriority.UseBackColor = False
            Me.xrTableCell41.Text = "xrTableCell41"
            Me.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell41.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode13
            ' 
            Me.xrBarCode13.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode13.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrBarCode13.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode13.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode13.Module = 1F
            Me.xrBarCode13.Name = "xrBarCode13"
            Me.xrBarCode13.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode13.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode13.StylePriority.UseBackColor = False
            Me.xrBarCode13.Symbology = eaN8Generator1
            Me.xrBarCode13.Text = "0123456"
            Me.xrBarCode13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow15
            ' 
            Me.xrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell43, Me.xrTableCell44, Me.xrTableCell45})
            Me.xrTableRow15.Name = "xrTableRow15"
            Me.xrTableRow15.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow15.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell44
            ' 
            Me.xrTableCell44.BackColor = System.Drawing.Color.White
            Me.xrTableCell44.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode14})
            Me.xrTableCell44.Name = "xrTableCell44"
            Me.xrTableCell44.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell44.StylePriority.UseBackColor = False
            Me.xrTableCell44.Text = "xrTableCell44"
            Me.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell44.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode14
            ' 
            Me.xrBarCode14.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode14.BackColor = System.Drawing.Color.White
            Me.xrBarCode14.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode14.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode14.Module = 1F
            Me.xrBarCode14.Name = "xrBarCode14"
            Me.xrBarCode14.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode14.SizeF = New System.Drawing.SizeF(250F, 62.11206F)
            Me.xrBarCode14.StylePriority.UseBackColor = False
            Me.xrBarCode14.Symbology = codeMSIGenerator1
            Me.xrBarCode14.Text = "0123456789"
            Me.xrBarCode14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell45
            ' 
            Me.xrTableCell45.BackColor = System.Drawing.Color.White
            Me.xrTableCell45.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell45.Name = "xrTableCell45"
            Me.xrTableCell45.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell45.StyleName = "TextPaddingStyle"
            Me.xrTableCell45.StylePriority.UseBackColor = False
            Me.xrTableCell45.Text = resources.GetString("xrTableCell45.Text")
            Me.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell45.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow16
            ' 
            Me.xrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell46, Me.xrTableCell47, Me.xrTableCell48})
            Me.xrTableRow16.Name = "xrTableRow16"
            Me.xrTableRow16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow16.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell46
            ' 
            Me.xrTableCell46.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell46.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell46.Multiline = True
            Me.xrTableCell46.Name = "xrTableCell46"
            Me.xrTableCell46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell46.StyleName = "TextPaddingStyle"
            Me.xrTableCell46.StylePriority.UseBackColor = False
            Me.xrTableCell46.Text = "UPC-A"
            Me.xrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell46.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell47
            ' 
            Me.xrTableCell47.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell47.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode15})
            Me.xrTableCell47.Name = "xrTableCell47"
            Me.xrTableCell47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell47.StylePriority.UseBackColor = False
            Me.xrTableCell47.Text = "xrTableCell47"
            Me.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell47.Weight = 0.3773823191733639R
            ' 
            ' xrTableCell48
            ' 
            Me.xrTableCell48.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell48.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell48.Name = "xrTableCell48"
            Me.xrTableCell48.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell48.StyleName = "TextPaddingStyle"
            Me.xrTableCell48.StylePriority.UseBackColor = False
            Me.xrTableCell48.Text = resources.GetString("xrTableCell48.Text")
            Me.xrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell48.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow17
            ' 
            Me.xrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell49, Me.xrTableCell50, Me.xrTableCell51})
            Me.xrTableRow17.Name = "xrTableRow17"
            Me.xrTableRow17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow17.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell49
            ' 
            Me.xrTableCell49.BackColor = System.Drawing.Color.White
            Me.xrTableCell49.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell49.Multiline = True
            Me.xrTableCell49.Name = "xrTableCell49"
            Me.xrTableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell49.StyleName = "TextPaddingStyle"
            Me.xrTableCell49.StylePriority.UseBackColor = False
            Me.xrTableCell49.Text = "UPC-E"
            Me.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell49.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell50
            ' 
            Me.xrTableCell50.BackColor = System.Drawing.Color.White
            Me.xrTableCell50.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode16})
            Me.xrTableCell50.Name = "xrTableCell50"
            Me.xrTableCell50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell50.StylePriority.UseBackColor = False
            Me.xrTableCell50.Text = "xrTableCell50"
            Me.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell50.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode16
            ' 
            Me.xrBarCode16.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrBarCode16.BackColor = System.Drawing.Color.White
            Me.xrBarCode16.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode16.LocationFloat = New DevExpress.Utils.PointFloat(1.1F, 0F)
            Me.xrBarCode16.Module = 1F
            Me.xrBarCode16.Name = "xrBarCode16"
            Me.xrBarCode16.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F)
            Me.xrBarCode16.SizeF = New System.Drawing.SizeF(250F, 60F)
            Me.xrBarCode16.StylePriority.UseBackColor = False
            Me.xrBarCode16.Symbology = upcE0Generator1
            Me.xrBarCode16.Text = "4210000526"
            Me.xrBarCode16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell51
            ' 
            Me.xrTableCell51.BackColor = System.Drawing.Color.White
            Me.xrTableCell51.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell51.Name = "xrTableCell51"
            Me.xrTableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell51.StyleName = "TextPaddingStyle"
            Me.xrTableCell51.StylePriority.UseBackColor = False
            Me.xrTableCell51.Text = resources.GetString("xrTableCell51.Text")
            Me.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell51.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow18
            ' 
            Me.xrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell52, Me.xrTableCell53, Me.xrTableCell54})
            Me.xrTableRow18.Name = "xrTableRow18"
            Me.xrTableRow18.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow18.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell52
            ' 
            Me.xrTableCell52.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell52.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell52.Multiline = True
            Me.xrTableCell52.Name = "xrTableCell52"
            Me.xrTableCell52.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell52.StyleName = "TextPaddingStyle"
            Me.xrTableCell52.StylePriority.UseBackColor = False
            Me.xrTableCell52.Text = "EAN13" & ControlChars.CrLf & "with" & ControlChars.CrLf & "UPC Suppl. 2"
            Me.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell52.Weight = 0.14936854190585536R
            ' 
            ' xrTableCell53
            ' 
            Me.xrTableCell53.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell53.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrBarCode19, Me.xrBarCode17})
            Me.xrTableCell53.Name = "xrTableCell53"
            Me.xrTableCell53.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell53.StylePriority.UseBackColor = False
            Me.xrTableCell53.Text = "xrTableCell53"
            Me.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell53.Weight = 0.3773823191733639R
            ' 
            ' xrBarCode19
            ' 
            Me.xrBarCode19.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrBarCode19.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrBarCode19.LocationFloat = New DevExpress.Utils.PointFloat(167F, 0F)
            Me.xrBarCode19.Module = 1F
            Me.xrBarCode19.Name = "xrBarCode19"
            Me.xrBarCode19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 4, 0, 100F)
            Me.xrBarCode19.SizeF = New System.Drawing.SizeF(42F, 60F)
            Me.xrBarCode19.StylePriority.UseBackColor = False
            Me.xrBarCode19.Symbology = upcSupplemental2Generator1
            Me.xrBarCode19.Text = "01"
            Me.xrBarCode19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' xrTableCell54
            ' 
            Me.xrTableCell54.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(235)))), (CInt((CByte(235)))))
            Me.xrTableCell54.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell54.Name = "xrTableCell54"
            Me.xrTableCell54.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell54.StyleName = "TextPaddingStyle"
            Me.xrTableCell54.StylePriority.UseBackColor = False
            Me.xrTableCell54.Text = resources.GetString("xrTableCell54.Text")
            Me.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell54.Weight = 0.47324913892078074R
            ' 
            ' xrTableRow19
            ' 
            Me.xrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell55, Me.xrTableCell56, Me.xrTableCell57})
            Me.xrTableRow19.Name = "xrTableRow19"
            Me.xrTableRow19.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow19.Weight = 0.055555555555555552R
            ' 
            ' xrTableCell57
            ' 
            Me.xrTableCell57.BackColor = System.Drawing.Color.White
            Me.xrTableCell57.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableCell57.Name = "xrTableCell57"
            Me.xrTableCell57.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F)
            Me.xrTableCell57.StyleName = "TextPaddingStyle"
            Me.xrTableCell57.StylePriority.UseBackColor = False
            Me.xrTableCell57.Text = "5-digit supplemental barcodes are used on books to indicate a suggested retail pr" & "ice."
            Me.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify
            Me.xrTableCell57.Weight = 0.47324913892078074R
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrLabel3.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(43F, 0F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(627F, 25F)
            Me.xrLabel3.Text = "You may print the following barcodes and then read them by any suitable barcode s" & "canner"
            Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomJustify
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(670F, 34F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.BackColor = System.Drawing.Color.Black
            Me.PageHeader.BorderColor = System.Drawing.Color.White
            Me.PageHeader.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.PageHeader.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.PageHeader.ForeColor = System.Drawing.Color.White
            Me.PageHeader.HeightF = 34F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' AutoModuleParameter
            ' 
            Me.AutoModuleParameter.Description = "AutoModule"
            Me.AutoModuleParameter.Name = "AutoModuleParameter"
            Me.AutoModuleParameter.Type = GetType(Boolean)
            Me.AutoModuleParameter.ValueInfo = "False"
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.Image = (DirectCast(resources.GetObject("xrPictureBox4.Image"), System.Drawing.Image))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(249F, 22F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrLabel3})
            Me.ReportHeader.HeightF = 32F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(42F, 25F)
            Me.xrLabel1.Text = "Note: "
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox4})
            Me.BottomMargin.HeightF = 93F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BarCodeTypes
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader, Me.PageHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.Margins = New System.Drawing.Printing.Margins(100, 80, 86, 93)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.AutoModuleParameter})
            Me.RequestParameters = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.TextPaddingStyle})
            Me.Version = "14.1"
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Private Sub BarCodeTypes_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            SetAutoModule(CBool(AutoModuleParameter.Value))
        End Sub

        Private Sub SetAutoModule(ByVal autoModule As Boolean)
            For Each barCode As XRBarCode In AllControls(Of XRBarCode)()
                barCode.AutoModule = autoModule
            Next barCode
        End Sub
    End Class
End Namespace