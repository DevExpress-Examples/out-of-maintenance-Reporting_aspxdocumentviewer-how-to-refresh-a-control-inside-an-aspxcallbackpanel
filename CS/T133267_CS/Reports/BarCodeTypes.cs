using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.XtraReports.UI;

namespace T133267_CS.Reports {
    public class BarCodeTypes : XtraReport {
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell10;
        private XRTableCell xrTableCell11;
        private XRBarCode xrBarCode3;
        private XRTableCell xrTableCell12;
        private XRTableCell xrTableCell13;
        private XRBarCode xrBarCode7;
        private XRBarCode xrBarCode11;
        private XRTableCell xrTableCell34;
        private XRBarCode xrBarCode4;
        private XRTableCell xrTableCell58;
        private XRTableCell xrTableCell78;
        private XRTableCell xrTableCell63;
        private XRTableRow xrTableRow9;
        private XRTableCell xrTableCell25;
        private XRTableCell xrTableCell26;
        private XRBarCode xrBarCode6;
        private XRTableCell xrTableCell27;
        private XRTableRow xrTableRow6;
        private XRTableCell xrTableCell16;
        private XRTableCell xrTableCell17;
        private XRTableCell xrTableCell18;
        private XRBarCode xrBarCode17;
        private XRBarCode xrBarCode5;
        private XRTableRow xrTableRow20;
        private XRTableCell xrTableCell59;
        private XRBarCode xrBarCode21;
        private XRTableCell xrTableCell60;
        private XRTableCell xrTableCell14;
        private XRTableCell xrTableCell56;
        private XRBarCode xrBarCode18;
        private XRBarCode xrBarCode20;
        private XRTableCell xrTableCell20;
        private XRBarCode xrBarCode12;
        private XRTableCell xrTableCell66;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell4;
        private XRTableCell xrTableCell5;
        private XRBarCode xrBarCode1;
        private XRTableCell xrTableCell6;
        private XRTableCell xrTableCell43;
        private XRControlStyle TextPaddingStyle;
        private XRTableCell xrTableCell42;
        private XRBarCode xrBarCode15;
        private XRTableCell xrTableCell71;
        private XRBarCode xrBarCode25;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private XRTableCell xrTableCell3;
        private XRTableRow xrTableRow22;
        private XRTableCell xrTableCell64;
        private XRTableCell xrTableCell65;
        private XRBarCode xrBarCode23;
        private TopMarginBand topMarginBand1;
        private XRTableCell xrTableCell55;
        private XRTableRow xrTableRow13;
        private XRTableCell xrTableCell37;
        private XRTableCell xrTableCell38;
        private XRBarCode xrBarCode10;
        private XRTableCell xrTableCell39;
        private XRTableCell xrTableCell29;
        private XRTableRow xrTableRow26;
        private XRTableCell xrTableCell76;
        private XRTableCell xrTableCell77;
        private XRBarCode xrBarCode28;
        private XRBarCode xrBarCode27;
        private DetailBand Detail;
        private XRTable xrTable2;
        private XRTableRow xrTableRow25;
        private XRTableCell xrTableCell73;
        private XRTableCell xrTableCell74;
        private XRBarCode xrBarCode26;
        private XRTableCell xrTableCell75;
        private XRTableRow xrTableRow24;
        private XRTableCell xrTableCell70;
        private XRTableCell xrTableCell72;
        private XRTableRow xrTableRow23;
        private XRTableCell xrTableCell67;
        private XRTableCell xrTableCell68;
        private XRBarCode xrBarCode24;
        private XRTableCell xrTableCell69;
        private XRTableRow xrTableRow21;
        private XRTableCell xrTableCell61;
        private XRTableCell xrTableCell62;
        private XRBarCode xrBarCode22;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell7;
        private XRTableCell xrTableCell8;
        private XRBarCode xrBarCode2;
        private XRTableCell xrTableCell9;
        private XRTableRow xrTableRow5;
        private XRTableCell xrTableCell15;
        private XRTableRow xrTableRow8;
        private XRTableCell xrTableCell22;
        private XRTableCell xrTableCell23;
        private XRTableCell xrTableCell24;
        private XRTableRow xrTableRow10;
        private XRTableCell xrTableCell28;
        private XRTableCell xrTableCell30;
        private XRTableRow xrTableRow11;
        private XRTableCell xrTableCell31;
        private XRTableCell xrTableCell32;
        private XRBarCode xrBarCode8;
        private XRTableCell xrTableCell33;
        private XRTableRow xrTableRow12;
        private XRTableCell xrTableCell35;
        private XRBarCode xrBarCode9;
        private XRTableCell xrTableCell36;
        private XRTableRow xrTableRow7;
        private XRTableCell xrTableCell19;
        private XRTableCell xrTableCell21;
        private XRTableRow xrTableRow14;
        private XRTableCell xrTableCell40;
        private XRTableCell xrTableCell41;
        private XRBarCode xrBarCode13;
        private XRTableRow xrTableRow15;
        private XRTableCell xrTableCell44;
        private XRBarCode xrBarCode14;
        private XRTableCell xrTableCell45;
        private XRTableRow xrTableRow16;
        private XRTableCell xrTableCell46;
        private XRTableCell xrTableCell47;
        private XRTableCell xrTableCell48;
        private XRTableRow xrTableRow17;
        private XRTableCell xrTableCell49;
        private XRTableCell xrTableCell50;
        private XRBarCode xrBarCode16;
        private XRTableCell xrTableCell51;
        private XRTableRow xrTableRow18;
        private XRTableCell xrTableCell52;
        private XRTableCell xrTableCell53;
        private XRBarCode xrBarCode19;
        private XRTableCell xrTableCell54;
        private XRTableRow xrTableRow19;
        private XRTableCell xrTableCell57;
        private XRLabel xrLabel3;
        private XRTable xrTable1;
        private PageHeaderBand PageHeader;
        private DevExpress.XtraReports.Parameters.Parameter AutoModuleParameter;
        private XRPictureBox xrPictureBox4;
        private ReportHeaderBand ReportHeader;
        private XRLabel xrLabel1;
        private BottomMarginBand BottomMargin;
    
        public BarCodeTypes() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarCodeTypes));
            DevExpress.XtraPrinting.BarCode.Code93Generator code93Generator1 = new DevExpress.XtraPrinting.BarCode.Code93Generator();
            DevExpress.XtraPrinting.BarCode.Interleaved2of5Generator interleaved2of5Generator1 = new DevExpress.XtraPrinting.BarCode.Interleaved2of5Generator();
            DevExpress.XtraPrinting.BarCode.EAN128Generator eaN128Generator1 = new DevExpress.XtraPrinting.BarCode.EAN128Generator();
            DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator code39ExtendedGenerator1 = new DevExpress.XtraPrinting.BarCode.Code39ExtendedGenerator();
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator1 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            DevExpress.XtraPrinting.BarCode.Code39Generator code39Generator1 = new DevExpress.XtraPrinting.BarCode.Code39Generator();
            DevExpress.XtraPrinting.BarCode.PDF417Generator pdF417Generator1 = new DevExpress.XtraPrinting.BarCode.PDF417Generator();
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator2 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            DevExpress.XtraPrinting.BarCode.UPCSupplemental5Generator upcSupplemental5Generator1 = new DevExpress.XtraPrinting.BarCode.UPCSupplemental5Generator();
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator3 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            DevExpress.XtraPrinting.BarCode.CodabarGenerator codabarGenerator1 = new DevExpress.XtraPrinting.BarCode.CodabarGenerator();
            DevExpress.XtraPrinting.BarCode.UPCAGenerator upcaGenerator1 = new DevExpress.XtraPrinting.BarCode.UPCAGenerator();
            DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator dataMatrixGS1Generator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGS1Generator();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraPrinting.BarCode.Matrix2of5Generator matrix2of5Generator1 = new DevExpress.XtraPrinting.BarCode.Matrix2of5Generator();
            DevExpress.XtraPrinting.BarCode.DataBarGenerator dataBarGenerator1 = new DevExpress.XtraPrinting.BarCode.DataBarGenerator();
            DevExpress.XtraPrinting.BarCode.DataBarGenerator dataBarGenerator2 = new DevExpress.XtraPrinting.BarCode.DataBarGenerator();
            DevExpress.XtraPrinting.BarCode.ITF14Generator itF14Generator1 = new DevExpress.XtraPrinting.BarCode.ITF14Generator();
            DevExpress.XtraPrinting.BarCode.IntelligentMailGenerator intelligentMailGenerator1 = new DevExpress.XtraPrinting.BarCode.IntelligentMailGenerator();
            DevExpress.XtraPrinting.BarCode.DataMatrixGenerator dataMatrixGenerator1 = new DevExpress.XtraPrinting.BarCode.DataMatrixGenerator();
            DevExpress.XtraPrinting.BarCode.Code11Generator code11Generator1 = new DevExpress.XtraPrinting.BarCode.Code11Generator();
            DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator code93ExtendedGenerator1 = new DevExpress.XtraPrinting.BarCode.Code93ExtendedGenerator();
            DevExpress.XtraPrinting.BarCode.Industrial2of5Generator industrial2of5Generator1 = new DevExpress.XtraPrinting.BarCode.Industrial2of5Generator();
            DevExpress.XtraPrinting.BarCode.EAN8Generator eaN8Generator1 = new DevExpress.XtraPrinting.BarCode.EAN8Generator();
            DevExpress.XtraPrinting.BarCode.CodeMSIGenerator codeMSIGenerator1 = new DevExpress.XtraPrinting.BarCode.CodeMSIGenerator();
            DevExpress.XtraPrinting.BarCode.UPCE0Generator upcE0Generator1 = new DevExpress.XtraPrinting.BarCode.UPCE0Generator();
            DevExpress.XtraPrinting.BarCode.UPCSupplemental2Generator upcSupplemental2Generator1 = new DevExpress.XtraPrinting.BarCode.UPCSupplemental2Generator();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode3 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode7 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode11 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode4 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode6 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode17 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode5 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode21 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode18 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode20 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode12 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TextPaddingStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode15 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode25 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode23 = new DevExpress.XtraReports.UI.XRBarCode();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode10 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode28 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrBarCode27 = new DevExpress.XtraReports.UI.XRBarCode();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode26 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode24 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode22 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode2 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode8 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode9 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode13 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode14 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode16 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBarCode19 = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.AutoModuleParameter = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow4.Weight = 0.055555555555555552D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell10.StyleName = "TextPaddingStyle";
            this.xrTableCell10.StylePriority.UseBackColor = false;
            this.xrTableCell10.Text = "Code 128";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell10.Weight = 0.14936854190585536D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode3});
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell11.StylePriority.UseBackColor = false;
            this.xrTableCell11.Text = "xrTableCell11";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell11.Weight = 0.3773823191733639D;
            // 
            // xrBarCode3
            // 
            this.xrBarCode3.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode3.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode3.Module = 1F;
            this.xrBarCode3.Name = "xrBarCode3";
            this.xrBarCode3.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode3.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode3.StylePriority.UseBackColor = false;
            code128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto;
            this.xrBarCode3.Symbology = code128Generator1;
            this.xrBarCode3.Text = "XRBarCode 0123456";
            this.xrBarCode3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell12.StyleName = "TextPaddingStyle";
            this.xrTableCell12.StylePriority.UseBackColor = false;
            this.xrTableCell12.Text = resources.GetString("xrTableCell12.Text");
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell12.Weight = 0.47324913892078074D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.BackColor = System.Drawing.Color.White;
            this.xrTableCell13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell13.StyleName = "TextPaddingStyle";
            this.xrTableCell13.StylePriority.UseBackColor = false;
            this.xrTableCell13.Text = "EAN128";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell13.Weight = 0.14936854190585536D;
            // 
            // xrBarCode7
            // 
            this.xrBarCode7.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode7.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode7.Module = 1F;
            this.xrBarCode7.Name = "xrBarCode7";
            this.xrBarCode7.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode7.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode7.StylePriority.UseBackColor = false;
            this.xrBarCode7.Symbology = code93Generator1;
            this.xrBarCode7.Text = "XRBARCODE";
            this.xrBarCode7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrBarCode11
            // 
            this.xrBarCode11.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode11.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode11.Module = 1F;
            this.xrBarCode11.Name = "xrBarCode11";
            this.xrBarCode11.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode11.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode11.StylePriority.UseBackColor = false;
            interleaved2of5Generator1.WideNarrowRatio = 3F;
            this.xrBarCode11.Symbology = interleaved2of5Generator1;
            this.xrBarCode11.Text = "0123456789";
            this.xrBarCode11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell34.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell34.Multiline = true;
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell34.StyleName = "TextPaddingStyle";
            this.xrTableCell34.StylePriority.UseBackColor = false;
            this.xrTableCell34.Text = "Industrial\r\n2 of 5";
            this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell34.Weight = 0.14936854190585536D;
            // 
            // xrBarCode4
            // 
            this.xrBarCode4.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode4.BackColor = System.Drawing.Color.White;
            this.xrBarCode4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode4.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode4.Module = 1F;
            this.xrBarCode4.Name = "xrBarCode4";
            this.xrBarCode4.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode4.SizeF = new System.Drawing.SizeF(251F, 59F);
            this.xrBarCode4.StylePriority.UseBackColor = false;
            eaN128Generator1.CharacterSet = DevExpress.XtraPrinting.BarCode.Code128Charset.CharsetAuto;
            this.xrBarCode4.Symbology = eaN128Generator1;
            this.xrBarCode4.Text = "XRBarCode 0123456";
            this.xrBarCode4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.BackColor = System.Drawing.Color.White;
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.StyleName = "TextPaddingStyle";
            this.xrTableCell58.StylePriority.UseBackColor = false;
            this.xrTableCell58.StylePriority.UseTextAlignment = false;
            this.xrTableCell58.Text = "PDF417";
            this.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell58.Weight = 0.14936854190585536D;
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.BackColor = System.Drawing.Color.White;
            this.xrTableCell78.BorderColor = System.Drawing.Color.White;
            this.xrTableCell78.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell78.Multiline = true;
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell78.StylePriority.UseBackColor = false;
            this.xrTableCell78.StylePriority.UseBorderColor = false;
            this.xrTableCell78.StylePriority.UseFont = false;
            this.xrTableCell78.StylePriority.UsePadding = false;
            this.xrTableCell78.StylePriority.UseTextAlignment = false;
            this.xrTableCell78.Text = resources.GetString("xrTableCell78.Text");
            this.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell78.Weight = 0.47324913892078074D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell63.Multiline = true;
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell63.StylePriority.UseFont = false;
            this.xrTableCell63.StylePriority.UsePadding = false;
            this.xrTableCell63.StylePriority.UseTextAlignment = false;
            this.xrTableCell63.Text = resources.GetString("xrTableCell63.Text");
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell63.Weight = 0.47324913892078074D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow9.Weight = 0.055555555555555552D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.BackColor = System.Drawing.Color.White;
            this.xrTableCell25.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell25.Multiline = true;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell25.StyleName = "TextPaddingStyle";
            this.xrTableCell25.StylePriority.UseBackColor = false;
            this.xrTableCell25.Text = "Code 39 Extended";
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell25.Weight = 0.14936854190585536D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.BackColor = System.Drawing.Color.White;
            this.xrTableCell26.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode6});
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell26.StylePriority.UseBackColor = false;
            this.xrTableCell26.Text = "xrTableCell26";
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell26.Weight = 0.3773823191733639D;
            // 
            // xrBarCode6
            // 
            this.xrBarCode6.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode6.BackColor = System.Drawing.Color.White;
            this.xrBarCode6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode6.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode6.Module = 1F;
            this.xrBarCode6.Name = "xrBarCode6";
            this.xrBarCode6.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode6.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode6.StylePriority.UseBackColor = false;
            code39ExtendedGenerator1.WideNarrowRatio = 3F;
            this.xrBarCode6.Symbology = code39ExtendedGenerator1;
            this.xrBarCode6.Text = "BarCODE";
            this.xrBarCode6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.BackColor = System.Drawing.Color.White;
            this.xrTableCell27.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell27.StyleName = "TextPaddingStyle";
            this.xrTableCell27.StylePriority.UseBackColor = false;
            this.xrTableCell27.Text = resources.GetString("xrTableCell27.Text");
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell27.Weight = 0.47324913892078074D;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow6.Weight = 0.055555555555555552D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell16.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell16.StyleName = "TextPaddingStyle";
            this.xrTableCell16.StylePriority.UseBackColor = false;
            this.xrTableCell16.Text = "Interleaved\r\n2 of 5";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell16.Weight = 0.14936854190585536D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell17.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode11});
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell17.StylePriority.UseBackColor = false;
            this.xrTableCell17.Text = "xrTableCell17";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell17.Weight = 0.3773823191733639D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell18.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell18.StyleName = "TextPaddingStyle";
            this.xrTableCell18.StylePriority.UseBackColor = false;
            this.xrTableCell18.Text = "Interleaved 2 of 5 is a higher-density numeric symbology based upon the Standard " +
    "2 of 5 symbology. It is used primarily in the distribution and warehouse industr" +
    "y.";
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell18.Weight = 0.47324913892078074D;
            // 
            // xrBarCode17
            // 
            this.xrBarCode17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode17.LocationFloat = new DevExpress.Utils.PointFloat(33F, 0F);
            this.xrBarCode17.Module = 1F;
            this.xrBarCode17.Name = "xrBarCode17";
            this.xrBarCode17.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F);
            this.xrBarCode17.SizeF = new System.Drawing.SizeF(133F, 60F);
            this.xrBarCode17.StylePriority.UseBackColor = false;
            this.xrBarCode17.Symbology = eaN13Generator1;
            this.xrBarCode17.Text = "978531800111";
            this.xrBarCode17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrBarCode5
            // 
            this.xrBarCode5.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode5.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode5.Module = 1F;
            this.xrBarCode5.Name = "xrBarCode5";
            this.xrBarCode5.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode5.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode5.StylePriority.UseBackColor = false;
            code39Generator1.WideNarrowRatio = 3F;
            this.xrBarCode5.Symbology = code39Generator1;
            this.xrBarCode5.Text = "XRBARCODE";
            this.xrBarCode5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow20
            // 
            this.xrTableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell60});
            this.xrTableRow20.Name = "xrTableRow20";
            this.xrTableRow20.Weight = 0.11D;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.BackColor = System.Drawing.Color.White;
            this.xrTableCell59.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode21});
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.StylePriority.UseBackColor = false;
            this.xrTableCell59.Text = "xrTableCell59";
            this.xrTableCell59.Weight = 0.3773823191733639D;
            // 
            // xrBarCode21
            // 
            this.xrBarCode21.Alignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrBarCode21.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode21.LocationFloat = new DevExpress.Utils.PointFloat(1.100014F, 0F);
            this.xrBarCode21.Module = 1F;
            this.xrBarCode21.Name = "xrBarCode21";
            this.xrBarCode21.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F);
            this.xrBarCode21.ShowText = false;
            this.xrBarCode21.SizeF = new System.Drawing.SizeF(251.7461F, 120.0001F);
            this.xrBarCode21.StylePriority.UsePadding = false;
            pdF417Generator1.Columns = 9;
            pdF417Generator1.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.ErrorCorrectionLevel.Level0;
            pdF417Generator1.Rows = 36;
            this.xrBarCode21.Symbology = pdF417Generator1;
            this.xrBarCode21.Text = resources.GetString("xrBarCode21.Text");
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.BackColor = System.Drawing.Color.White;
            this.xrTableCell60.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell60.Multiline = true;
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell60.StylePriority.UseBackColor = false;
            this.xrTableCell60.StylePriority.UsePadding = false;
            this.xrTableCell60.StylePriority.UseTextAlignment = false;
            this.xrTableCell60.Text = resources.GetString("xrTableCell60.Text");
            this.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell60.Weight = 0.47324913892078074D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.BackColor = System.Drawing.Color.White;
            this.xrTableCell14.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode4});
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell14.StylePriority.UseBackColor = false;
            this.xrTableCell14.Text = "xrTableCell14";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell14.Weight = 0.3773823191733639D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.BackColor = System.Drawing.Color.White;
            this.xrTableCell56.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode18,
            this.xrBarCode20});
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell56.StylePriority.UseBackColor = false;
            this.xrTableCell56.Text = "xrTableCell56";
            this.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell56.Weight = 0.3773823191733639D;
            // 
            // xrBarCode18
            // 
            this.xrBarCode18.BackColor = System.Drawing.Color.White;
            this.xrBarCode18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode18.LocationFloat = new DevExpress.Utils.PointFloat(25F, 0F);
            this.xrBarCode18.Module = 1F;
            this.xrBarCode18.Name = "xrBarCode18";
            this.xrBarCode18.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F);
            this.xrBarCode18.SizeF = new System.Drawing.SizeF(133F, 60F);
            this.xrBarCode18.StylePriority.UseBackColor = false;
            this.xrBarCode18.Symbology = eaN13Generator2;
            this.xrBarCode18.Text = "978531800111";
            this.xrBarCode18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrBarCode20
            // 
            this.xrBarCode20.BackColor = System.Drawing.Color.White;
            this.xrBarCode20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode20.LocationFloat = new DevExpress.Utils.PointFloat(158F, 0F);
            this.xrBarCode20.Module = 1F;
            this.xrBarCode20.Name = "xrBarCode20";
            this.xrBarCode20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 4, 0, 100F);
            this.xrBarCode20.SizeF = new System.Drawing.SizeF(75F, 60F);
            this.xrBarCode20.StylePriority.UseBackColor = false;
            this.xrBarCode20.Symbology = upcSupplemental5Generator1;
            this.xrBarCode20.Text = "01234";
            this.xrBarCode20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.BackColor = System.Drawing.Color.White;
            this.xrTableCell20.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode12});
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell20.StylePriority.UseBackColor = false;
            this.xrTableCell20.Text = "xrTableCell20";
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell20.Weight = 0.3773823191733639D;
            // 
            // xrBarCode12
            // 
            this.xrBarCode12.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode12.BackColor = System.Drawing.Color.White;
            this.xrBarCode12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode12.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode12.Module = 1F;
            this.xrBarCode12.Name = "xrBarCode12";
            this.xrBarCode12.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode12.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode12.StylePriority.UseBackColor = false;
            this.xrBarCode12.Symbology = eaN13Generator3;
            this.xrBarCode12.Text = "978531800111";
            this.xrBarCode12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.BackColor = System.Drawing.Color.White;
            this.xrTableCell66.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell66.Multiline = true;
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell66.StylePriority.UseBackColor = false;
            this.xrTableCell66.StylePriority.UseFont = false;
            this.xrTableCell66.StylePriority.UsePadding = false;
            this.xrTableCell66.StylePriority.UseTextAlignment = false;
            this.xrTableCell66.Text = resources.GetString("xrTableCell66.Text");
            this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell66.Weight = 0.47324913892078074D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow2.Weight = 0.055555555555555552D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell4.StyleName = "TextPaddingStyle";
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.Text = "Codabar";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.14936854190585536D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.Text = "xrTableCell5";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.3773823191733639D;
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode1.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode1.Module = 1F;
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode1.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode1.StylePriority.UseBackColor = false;
            codabarGenerator1.WideNarrowRatio = 2F;
            this.xrBarCode1.Symbology = codabarGenerator1;
            this.xrBarCode1.Text = "0123456789+-/:.$";
            this.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell6.StyleName = "TextPaddingStyle";
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.Text = resources.GetString("xrTableCell6.Text");
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell6.Weight = 0.47324913892078074D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.BackColor = System.Drawing.Color.White;
            this.xrTableCell43.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell43.Multiline = true;
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell43.StyleName = "TextPaddingStyle";
            this.xrTableCell43.StylePriority.UseBackColor = false;
            this.xrTableCell43.Text = "MSI/Plessey";
            this.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell43.Weight = 0.14936854190585536D;
            // 
            // TextPaddingStyle
            // 
            this.TextPaddingStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TextPaddingStyle.Name = "TextPaddingStyle";
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell42.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell42.StyleName = "TextPaddingStyle";
            this.xrTableCell42.StylePriority.UseBackColor = false;
            this.xrTableCell42.Text = "EAN-8 is the EAN equivalent of UPC-E in the sense that it provides a \"short\" barc" +
    "ode for small packages.";
            this.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell42.Weight = 0.47324913892078074D;
            // 
            // xrBarCode15
            // 
            this.xrBarCode15.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode15.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode15.Module = 1F;
            this.xrBarCode15.Name = "xrBarCode15";
            this.xrBarCode15.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode15.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode15.StylePriority.UseBackColor = false;
            this.xrBarCode15.Symbology = upcaGenerator1;
            this.xrBarCode15.Text = "78534235463";
            this.xrBarCode15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode25});
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.Text = "xrTableCell71";
            this.xrTableCell71.Weight = 0.3773823191733639D;
            // 
            // xrBarCode25
            // 
            this.xrBarCode25.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode25.BackColor = System.Drawing.Color.White;
            this.xrBarCode25.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode25.Name = "xrBarCode25";
            this.xrBarCode25.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F);
            this.xrBarCode25.ShowText = false;
            this.xrBarCode25.SizeF = new System.Drawing.SizeF(249.1538F, 105.0473F);
            this.xrBarCode25.StylePriority.UseBackColor = false;
            this.xrBarCode25.StylePriority.UsePadding = false;
            this.xrBarCode25.Symbology = dataMatrixGS1Generator1;
            this.xrBarCode25.Text = "010031234567890621123456789012#300144";
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.Text = "Symbology";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.14936854190585536D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.Text = "Example";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.3773823191733639D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell3.Text = "Description";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 0.47324913892078074D;
            // 
            // xrTableRow22
            // 
            this.xrTableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell64,
            this.xrTableCell65,
            this.xrTableCell66});
            this.xrTableRow22.Name = "xrTableRow22";
            this.xrTableRow22.StylePriority.UseBackColor = false;
            this.xrTableRow22.StylePriority.UseTextAlignment = false;
            this.xrTableRow22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow22.Weight = 0.084843876334442653D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.BackColor = System.Drawing.Color.White;
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.StyleName = "TextPaddingStyle";
            this.xrTableCell64.StylePriority.UseBackColor = false;
            this.xrTableCell64.Text = "QR Code";
            this.xrTableCell64.Weight = 0.14936854190585536D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.BackColor = System.Drawing.Color.White;
            this.xrTableCell65.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode23});
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.StylePriority.UseBackColor = false;
            this.xrTableCell65.Text = "xrTableCell65";
            this.xrTableCell65.Weight = 0.3773823191733639D;
            // 
            // xrBarCode23
            // 
            this.xrBarCode23.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode23.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode23.LocationFloat = new DevExpress.Utils.PointFloat(1.100014F, 0F);
            this.xrBarCode23.Module = 3F;
            this.xrBarCode23.Name = "xrBarCode23";
            this.xrBarCode23.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 0, 100F);
            this.xrBarCode23.ShowText = false;
            this.xrBarCode23.SizeF = new System.Drawing.SizeF(251.7462F, 94.85706F);
            this.xrBarCode23.StylePriority.UsePadding = false;
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version2;
            this.xrBarCode23.Symbology = qrCodeGenerator1;
            this.xrBarCode23.Text = "URL:http://www.devexpress.com";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 86F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.BackColor = System.Drawing.Color.White;
            this.xrTableCell55.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell55.Multiline = true;
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell55.StyleName = "TextPaddingStyle";
            this.xrTableCell55.StylePriority.UseBackColor = false;
            this.xrTableCell55.Text = "EAN13\r\nwith\r\nUPC Suppl. 5";
            this.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell55.Weight = 0.14936854190585536D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow13.Weight = 0.055555555555555552D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.BackColor = System.Drawing.Color.White;
            this.xrTableCell37.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell37.Multiline = true;
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell37.StyleName = "TextPaddingStyle";
            this.xrTableCell37.StylePriority.UseBackColor = false;
            this.xrTableCell37.Text = "Matrix\r\n2 of 5";
            this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell37.Weight = 0.14936854190585536D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.BackColor = System.Drawing.Color.White;
            this.xrTableCell38.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode10});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell38.StylePriority.UseBackColor = false;
            this.xrTableCell38.Text = "xrTableCell38";
            this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell38.Weight = 0.3773823191733639D;
            // 
            // xrBarCode10
            // 
            this.xrBarCode10.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode10.BackColor = System.Drawing.Color.White;
            this.xrBarCode10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode10.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode10.Module = 1F;
            this.xrBarCode10.Name = "xrBarCode10";
            this.xrBarCode10.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode10.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode10.StylePriority.UseBackColor = false;
            this.xrBarCode10.Symbology = matrix2of5Generator1;
            this.xrBarCode10.Text = "00123456789";
            this.xrBarCode10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.BackColor = System.Drawing.Color.White;
            this.xrTableCell39.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell39.StyleName = "TextPaddingStyle";
            this.xrTableCell39.StylePriority.UseBackColor = false;
            this.xrTableCell39.Text = resources.GetString("xrTableCell39.Text");
            this.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell39.Weight = 0.47324913892078074D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell29.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode7});
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell29.StylePriority.UseBackColor = false;
            this.xrTableCell29.Text = "xrTableCell29";
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell29.Weight = 0.3773823191733639D;
            // 
            // xrTableRow26
            // 
            this.xrTableRow26.BackColor = System.Drawing.Color.White;
            this.xrTableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell76,
            this.xrTableCell77,
            this.xrTableCell78});
            this.xrTableRow26.Name = "xrTableRow26";
            this.xrTableRow26.StylePriority.UseBackColor = false;
            this.xrTableRow26.Weight = 0.19355560919964779D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.BackColor = System.Drawing.Color.White;
            this.xrTableCell76.BorderColor = System.Drawing.Color.White;
            this.xrTableCell76.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.StylePriority.UseBackColor = false;
            this.xrTableCell76.StylePriority.UseBorderColor = false;
            this.xrTableCell76.StylePriority.UseFont = false;
            this.xrTableCell76.StylePriority.UseTextAlignment = false;
            this.xrTableCell76.Text = "DataBar";
            this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell76.Weight = 0.14936854190585536D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.BackColor = System.Drawing.Color.White;
            this.xrTableCell77.BorderColor = System.Drawing.Color.White;
            this.xrTableCell77.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode28,
            this.xrBarCode27});
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.StylePriority.UseBackColor = false;
            this.xrTableCell77.StylePriority.UseBorderColor = false;
            this.xrTableCell77.StylePriority.UseTextAlignment = false;
            this.xrTableCell77.Text = "xrTableCell77";
            this.xrTableCell77.Weight = 0.3773823191733639D;
            // 
            // xrBarCode28
            // 
            this.xrBarCode28.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode28.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode28.BackColor = System.Drawing.Color.White;
            this.xrBarCode28.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 154.65F);
            this.xrBarCode28.Module = 1.75F;
            this.xrBarCode28.Name = "xrBarCode28";
            this.xrBarCode28.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 4, 0, 100F);
            this.xrBarCode28.SizeF = new System.Drawing.SizeF(251F, 51.74995F);
            this.xrBarCode28.StylePriority.UseBackColor = false;
            this.xrBarCode28.StylePriority.UsePadding = false;
            this.xrBarCode28.StylePriority.UseTextAlignment = false;
            dataBarGenerator1.SegmentsInRow = 4;
            dataBarGenerator1.Type = DevExpress.XtraPrinting.BarCode.DataBarType.Truncated;
            this.xrBarCode28.Symbology = dataBarGenerator1;
            this.xrBarCode28.Text = "123456789";
            this.xrBarCode28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrBarCode27
            // 
            this.xrBarCode27.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode27.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode27.BackColor = System.Drawing.Color.White;
            this.xrBarCode27.Font = new System.Drawing.Font("Times New Roman", 8.75F);
            this.xrBarCode27.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode27.Module = 1.75F;
            this.xrBarCode27.Name = "xrBarCode27";
            this.xrBarCode27.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 4, 0, 100F);
            this.xrBarCode27.SizeF = new System.Drawing.SizeF(251F, 147.982F);
            this.xrBarCode27.StylePriority.UseBackColor = false;
            this.xrBarCode27.StylePriority.UseFont = false;
            this.xrBarCode27.StylePriority.UsePadding = false;
            this.xrBarCode27.StylePriority.UseTextAlignment = false;
            dataBarGenerator2.SegmentsInRow = 4;
            dataBarGenerator2.Type = DevExpress.XtraPrinting.BarCode.DataBarType.ExpandedStacked;
            this.xrBarCode27.Symbology = dataBarGenerator2;
            this.xrBarCode27.Text = "01906141410000153202000150";
            this.xrBarCode27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Detail
            // 
            this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 2023.267F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.BorderColor = System.Drawing.Color.White;
            this.xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow26,
            this.xrTableRow25,
            this.xrTableRow24,
            this.xrTableRow23,
            this.xrTableRow22,
            this.xrTableRow21,
            this.xrTableRow20,
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow5,
            this.xrTableRow8,
            this.xrTableRow9,
            this.xrTableRow10,
            this.xrTableRow11,
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow14,
            this.xrTableRow15,
            this.xrTableRow16,
            this.xrTableRow17,
            this.xrTableRow18,
            this.xrTableRow19});
            this.xrTable2.SizeF = new System.Drawing.SizeF(670F, 2003.267F);
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow25
            // 
            this.xrTableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell73,
            this.xrTableCell74,
            this.xrTableCell75});
            this.xrTableRow25.Name = "xrTableRow25";
            this.xrTableRow25.Weight = 0.089443999426061266D;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.StylePriority.UseFont = false;
            this.xrTableCell73.StylePriority.UseTextAlignment = false;
            this.xrTableCell73.Text = "UPC Shipping Container Symbol (ITF-14)";
            this.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell73.Weight = 0.14936854190585536D;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode26});
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.Text = "xrTableCell74";
            this.xrTableCell74.Weight = 0.3773823191733639D;
            // 
            // xrBarCode26
            // 
            this.xrBarCode26.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode26.LocationFloat = new DevExpress.Utils.PointFloat(1.846186F, 0F);
            this.xrBarCode26.Module = 1.2F;
            this.xrBarCode26.Name = "xrBarCode26";
            this.xrBarCode26.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 4, 2, 100F);
            this.xrBarCode26.SizeF = new System.Drawing.SizeF(251F, 100F);
            this.xrBarCode26.StylePriority.UsePadding = false;
            this.xrBarCode26.StylePriority.UseTextAlignment = false;
            itF14Generator1.WideNarrowRatio = 3F;
            this.xrBarCode26.Symbology = itF14Generator1;
            this.xrBarCode26.Text = "1234567890123";
            this.xrBarCode26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell75.Multiline = true;
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell75.StylePriority.UseFont = false;
            this.xrTableCell75.StylePriority.UsePadding = false;
            this.xrTableCell75.StylePriority.UseTextAlignment = false;
            this.xrTableCell75.Text = resources.GetString("xrTableCell75.Text");
            this.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell75.Weight = 0.47324913892078074D;
            // 
            // xrTableRow24
            // 
            this.xrTableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell70,
            this.xrTableCell71,
            this.xrTableCell72});
            this.xrTableRow24.Name = "xrTableRow24";
            this.xrTableRow24.StyleName = "TextPaddingStyle";
            this.xrTableRow24.StylePriority.UseBackColor = false;
            this.xrTableRow24.Weight = 0.093958501291118587D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.BackColor = System.Drawing.Color.White;
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.StylePriority.UseBackColor = false;
            this.xrTableCell70.StylePriority.UseTextAlignment = false;
            this.xrTableCell70.Text = "Data Matrix GS1";
            this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell70.Weight = 0.14936854190585536D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.BackColor = System.Drawing.Color.White;
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell72.StylePriority.UseBackColor = false;
            this.xrTableCell72.StylePriority.UsePadding = false;
            this.xrTableCell72.StylePriority.UseTextAlignment = false;
            this.xrTableCell72.Text = resources.GetString("xrTableCell72.Text");
            this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell72.Weight = 0.47324913892078074D;
            // 
            // xrTableRow23
            // 
            this.xrTableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69});
            this.xrTableRow23.Name = "xrTableRow23";
            this.xrTableRow23.Weight = 0.084843876334442653D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.StyleName = "TextPaddingStyle";
            this.xrTableCell67.StylePriority.UseTextAlignment = false;
            this.xrTableCell67.Text = "Intelligent Mail";
            this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell67.Weight = 0.14936854190585536D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode24});
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.Text = "xrTableCell68";
            this.xrTableCell68.Weight = 0.3773823191733639D;
            // 
            // xrBarCode24
            // 
            this.xrBarCode24.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode24.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode24.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode24.Module = 1.75F;
            this.xrBarCode24.Name = "xrBarCode24";
            this.xrBarCode24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrBarCode24.ShowText = false;
            this.xrBarCode24.SizeF = new System.Drawing.SizeF(251F, 94.85698F);
            this.xrBarCode24.StylePriority.UsePadding = false;
            this.xrBarCode24.Symbology = intelligentMailGenerator1;
            this.xrBarCode24.Text = "4408200000012345678991203";
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell69.StylePriority.UseFont = false;
            this.xrTableCell69.StylePriority.UsePadding = false;
            this.xrTableCell69.StylePriority.UseTextAlignment = false;
            this.xrTableCell69.Text = resources.GetString("xrTableCell69.Text");
            this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell69.Weight = 0.47324913892078074D;
            // 
            // xrTableRow21
            // 
            this.xrTableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63});
            this.xrTableRow21.Name = "xrTableRow21";
            this.xrTableRow21.Weight = 0.13515612366555735D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.StyleName = "TextPaddingStyle";
            this.xrTableCell61.StylePriority.UseTextAlignment = false;
            this.xrTableCell61.Text = "Data Matrix";
            this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell61.Weight = 0.14936854190585536D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode22});
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.StylePriority.UseTextAlignment = false;
            this.xrTableCell62.Text = "xrTableCell62";
            this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell62.Weight = 0.3773823191733639D;
            // 
            // xrBarCode22
            // 
            this.xrBarCode22.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode22.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrBarCode22.LocationFloat = new DevExpress.Utils.PointFloat(1.100014F, 0F);
            this.xrBarCode22.Module = 1F;
            this.xrBarCode22.Name = "xrBarCode22";
            this.xrBarCode22.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 100F);
            this.xrBarCode22.ShowText = false;
            this.xrBarCode22.SizeF = new System.Drawing.SizeF(251.7462F, 151.107F);
            this.xrBarCode22.StylePriority.UsePadding = false;
            this.xrBarCode22.StylePriority.UseTextAlignment = false;
            this.xrBarCode22.Symbology = dataMatrixGenerator1;
            this.xrBarCode22.Text = resources.GetString("xrBarCode22.Text");
            this.xrBarCode22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.BackColor = System.Drawing.Color.White;
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow3.StylePriority.UseBackColor = false;
            this.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow3.Weight = 0.055555555555555552D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BackColor = System.Drawing.Color.White;
            this.xrTableCell7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell7.StyleName = "TextPaddingStyle";
            this.xrTableCell7.StylePriority.UseBackColor = false;
            this.xrTableCell7.Text = "Code 11";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 0.14936854190585536D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.BackColor = System.Drawing.Color.White;
            this.xrTableCell8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode2});
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell8.StylePriority.UseBackColor = false;
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell8.Weight = 0.3773823191733639D;
            // 
            // xrBarCode2
            // 
            this.xrBarCode2.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode2.BackColor = System.Drawing.Color.White;
            this.xrBarCode2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode2.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode2.Name = "xrBarCode2";
            this.xrBarCode2.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode2.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode2.StylePriority.UseBackColor = false;
            this.xrBarCode2.Symbology = code11Generator1;
            this.xrBarCode2.Text = "0123456";
            this.xrBarCode2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BackColor = System.Drawing.Color.White;
            this.xrTableCell9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell9.StyleName = "TextPaddingStyle";
            this.xrTableCell9.StylePriority.UseBackColor = false;
            this.xrTableCell9.Text = resources.GetString("xrTableCell9.Text");
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell9.Weight = 0.47324913892078074D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow5.Weight = 0.055555555555555552D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.BackColor = System.Drawing.Color.White;
            this.xrTableCell15.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell15.StyleName = "TextPaddingStyle";
            this.xrTableCell15.StylePriority.UseBackColor = false;
            this.xrTableCell15.Text = resources.GetString("xrTableCell15.Text");
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell15.Weight = 0.47324913892078074D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow8.Weight = 0.055555555555555552D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell22.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell22.Multiline = true;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell22.StyleName = "TextPaddingStyle";
            this.xrTableCell22.StylePriority.UseBackColor = false;
            this.xrTableCell22.Text = "Code 39";
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell22.Weight = 0.14936854190585536D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell23.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode5});
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell23.StylePriority.UseBackColor = false;
            this.xrTableCell23.Text = "xrTableCell23";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell23.Weight = 0.3773823191733639D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell24.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell24.StyleName = "TextPaddingStyle";
            this.xrTableCell24.StylePriority.UseBackColor = false;
            this.xrTableCell24.Text = resources.GetString("xrTableCell24.Text");
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell24.Weight = 0.47324913892078074D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow10.Weight = 0.055555555555555552D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell28.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell28.Multiline = true;
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell28.StyleName = "TextPaddingStyle";
            this.xrTableCell28.StylePriority.UseBackColor = false;
            this.xrTableCell28.Text = "Code 93";
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell28.Weight = 0.14936854190585536D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell30.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell30.StyleName = "TextPaddingStyle";
            this.xrTableCell30.StylePriority.UseBackColor = false;
            this.xrTableCell30.Text = resources.GetString("xrTableCell30.Text");
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell30.Weight = 0.47324913892078074D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow11.Weight = 0.055555555555555552D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.BackColor = System.Drawing.Color.White;
            this.xrTableCell31.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell31.Multiline = true;
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell31.StyleName = "TextPaddingStyle";
            this.xrTableCell31.StylePriority.UseBackColor = false;
            this.xrTableCell31.Text = "Code 93 Extended";
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell31.Weight = 0.14936854190585536D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.BackColor = System.Drawing.Color.White;
            this.xrTableCell32.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode8});
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell32.StylePriority.UseBackColor = false;
            this.xrTableCell32.Text = "xrTableCell32";
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell32.Weight = 0.3773823191733639D;
            // 
            // xrBarCode8
            // 
            this.xrBarCode8.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode8.BackColor = System.Drawing.Color.White;
            this.xrBarCode8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode8.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode8.Module = 1F;
            this.xrBarCode8.Name = "xrBarCode8";
            this.xrBarCode8.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode8.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode8.StylePriority.UseBackColor = false;
            this.xrBarCode8.Symbology = code93ExtendedGenerator1;
            this.xrBarCode8.Text = "XRBarCode";
            this.xrBarCode8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.BackColor = System.Drawing.Color.White;
            this.xrTableCell33.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell33.StyleName = "TextPaddingStyle";
            this.xrTableCell33.StylePriority.UseBackColor = false;
            this.xrTableCell33.Text = resources.GetString("xrTableCell33.Text");
            this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell33.Weight = 0.47324913892078074D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell36});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow12.Weight = 0.055555555555555552D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell35.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode9});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell35.StylePriority.UseBackColor = false;
            this.xrTableCell35.Text = "xrTableCell35";
            this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell35.Weight = 0.3773823191733639D;
            // 
            // xrBarCode9
            // 
            this.xrBarCode9.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode9.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode9.Module = 1F;
            this.xrBarCode9.Name = "xrBarCode9";
            this.xrBarCode9.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode9.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode9.StylePriority.UseBackColor = false;
            this.xrBarCode9.Symbology = industrial2of5Generator1;
            this.xrBarCode9.Text = "0123456789";
            this.xrBarCode9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell36.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell36.StyleName = "TextPaddingStyle";
            this.xrTableCell36.StylePriority.UseBackColor = false;
            this.xrTableCell36.Text = resources.GetString("xrTableCell36.Text");
            this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell36.Weight = 0.47324913892078074D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow7.Weight = 0.055555555555555552D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.BackColor = System.Drawing.Color.White;
            this.xrTableCell19.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell19.Multiline = true;
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell19.StyleName = "TextPaddingStyle";
            this.xrTableCell19.StylePriority.UseBackColor = false;
            this.xrTableCell19.Text = "EAN13";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell19.Weight = 0.14936854190585536D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.BackColor = System.Drawing.Color.White;
            this.xrTableCell21.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell21.StyleName = "TextPaddingStyle";
            this.xrTableCell21.StylePriority.UseBackColor = false;
            this.xrTableCell21.Text = "EAN-13, based upon the UPC-A standard, was implemented by the International Artic" +
    "le Numbering Association (EAN) in Europe.";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell21.Weight = 0.47324913892078074D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow14.Weight = 0.055555555555555552D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell40.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell40.Multiline = true;
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell40.StyleName = "TextPaddingStyle";
            this.xrTableCell40.StylePriority.UseBackColor = false;
            this.xrTableCell40.Text = "EAN8";
            this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell40.Weight = 0.14936854190585536D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell41.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode13});
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell41.StylePriority.UseBackColor = false;
            this.xrTableCell41.Text = "xrTableCell41";
            this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell41.Weight = 0.3773823191733639D;
            // 
            // xrBarCode13
            // 
            this.xrBarCode13.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode13.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode13.Module = 1F;
            this.xrBarCode13.Name = "xrBarCode13";
            this.xrBarCode13.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode13.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode13.StylePriority.UseBackColor = false;
            this.xrBarCode13.Symbology = eaN8Generator1;
            this.xrBarCode13.Text = "0123456";
            this.xrBarCode13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell45});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow15.Weight = 0.055555555555555552D;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.BackColor = System.Drawing.Color.White;
            this.xrTableCell44.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode14});
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell44.StylePriority.UseBackColor = false;
            this.xrTableCell44.Text = "xrTableCell44";
            this.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell44.Weight = 0.3773823191733639D;
            // 
            // xrBarCode14
            // 
            this.xrBarCode14.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode14.BackColor = System.Drawing.Color.White;
            this.xrBarCode14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode14.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode14.Module = 1F;
            this.xrBarCode14.Name = "xrBarCode14";
            this.xrBarCode14.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode14.SizeF = new System.Drawing.SizeF(250F, 62.11206F);
            this.xrBarCode14.StylePriority.UseBackColor = false;
            this.xrBarCode14.Symbology = codeMSIGenerator1;
            this.xrBarCode14.Text = "0123456789";
            this.xrBarCode14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.BackColor = System.Drawing.Color.White;
            this.xrTableCell45.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell45.StyleName = "TextPaddingStyle";
            this.xrTableCell45.StylePriority.UseBackColor = false;
            this.xrTableCell45.Text = resources.GetString("xrTableCell45.Text");
            this.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell45.Weight = 0.47324913892078074D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow16.Weight = 0.055555555555555552D;
            // 
            // xrTableCell46
            // 
            this.xrTableCell46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell46.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell46.Multiline = true;
            this.xrTableCell46.Name = "xrTableCell46";
            this.xrTableCell46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell46.StyleName = "TextPaddingStyle";
            this.xrTableCell46.StylePriority.UseBackColor = false;
            this.xrTableCell46.Text = "UPC-A";
            this.xrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell46.Weight = 0.14936854190585536D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell47.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode15});
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell47.StylePriority.UseBackColor = false;
            this.xrTableCell47.Text = "xrTableCell47";
            this.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell47.Weight = 0.3773823191733639D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell48.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell48.StyleName = "TextPaddingStyle";
            this.xrTableCell48.StylePriority.UseBackColor = false;
            this.xrTableCell48.Text = resources.GetString("xrTableCell48.Text");
            this.xrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell48.Weight = 0.47324913892078074D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell49,
            this.xrTableCell50,
            this.xrTableCell51});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow17.Weight = 0.055555555555555552D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.BackColor = System.Drawing.Color.White;
            this.xrTableCell49.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell49.Multiline = true;
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell49.StyleName = "TextPaddingStyle";
            this.xrTableCell49.StylePriority.UseBackColor = false;
            this.xrTableCell49.Text = "UPC-E";
            this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell49.Weight = 0.14936854190585536D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.BackColor = System.Drawing.Color.White;
            this.xrTableCell50.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode16});
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell50.StylePriority.UseBackColor = false;
            this.xrTableCell50.Text = "xrTableCell50";
            this.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell50.Weight = 0.3773823191733639D;
            // 
            // xrBarCode16
            // 
            this.xrBarCode16.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrBarCode16.BackColor = System.Drawing.Color.White;
            this.xrBarCode16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode16.LocationFloat = new DevExpress.Utils.PointFloat(1.1F, 0F);
            this.xrBarCode16.Module = 1F;
            this.xrBarCode16.Name = "xrBarCode16";
            this.xrBarCode16.Padding = new DevExpress.XtraPrinting.PaddingInfo(20, 20, 4, 0, 100F);
            this.xrBarCode16.SizeF = new System.Drawing.SizeF(250F, 60F);
            this.xrBarCode16.StylePriority.UseBackColor = false;
            this.xrBarCode16.Symbology = upcE0Generator1;
            this.xrBarCode16.Text = "4210000526";
            this.xrBarCode16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.BackColor = System.Drawing.Color.White;
            this.xrTableCell51.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell51.StyleName = "TextPaddingStyle";
            this.xrTableCell51.StylePriority.UseBackColor = false;
            this.xrTableCell51.Text = resources.GetString("xrTableCell51.Text");
            this.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell51.Weight = 0.47324913892078074D;
            // 
            // xrTableRow18
            // 
            this.xrTableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54});
            this.xrTableRow18.Name = "xrTableRow18";
            this.xrTableRow18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow18.Weight = 0.055555555555555552D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell52.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell52.Multiline = true;
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell52.StyleName = "TextPaddingStyle";
            this.xrTableCell52.StylePriority.UseBackColor = false;
            this.xrTableCell52.Text = "EAN13\r\nwith\r\nUPC Suppl. 2";
            this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell52.Weight = 0.14936854190585536D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell53.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode19,
            this.xrBarCode17});
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell53.StylePriority.UseBackColor = false;
            this.xrTableCell53.Text = "xrTableCell53";
            this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell53.Weight = 0.3773823191733639D;
            // 
            // xrBarCode19
            // 
            this.xrBarCode19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrBarCode19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrBarCode19.LocationFloat = new DevExpress.Utils.PointFloat(167F, 0F);
            this.xrBarCode19.Module = 1F;
            this.xrBarCode19.Name = "xrBarCode19";
            this.xrBarCode19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 4, 0, 100F);
            this.xrBarCode19.SizeF = new System.Drawing.SizeF(42F, 60F);
            this.xrBarCode19.StylePriority.UseBackColor = false;
            this.xrBarCode19.Symbology = upcSupplemental2Generator1;
            this.xrBarCode19.Text = "01";
            this.xrBarCode19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell54.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell54.StyleName = "TextPaddingStyle";
            this.xrTableCell54.StylePriority.UseBackColor = false;
            this.xrTableCell54.Text = resources.GetString("xrTableCell54.Text");
            this.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell54.Weight = 0.47324913892078074D;
            // 
            // xrTableRow19
            // 
            this.xrTableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell57});
            this.xrTableRow19.Name = "xrTableRow19";
            this.xrTableRow19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableRow19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableRow19.Weight = 0.055555555555555552D;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.BackColor = System.Drawing.Color.White;
            this.xrTableCell57.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 4, 2, 2, 100F);
            this.xrTableCell57.StyleName = "TextPaddingStyle";
            this.xrTableCell57.StylePriority.UseBackColor = false;
            this.xrTableCell57.Text = "5-digit supplemental barcodes are used on books to indicate a suggested retail pr" +
    "ice.";
            this.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell57.Weight = 0.47324913892078074D;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(43F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(627F, 25F);
            this.xrLabel3.Text = "You may print the following barcodes and then read them by any suitable barcode s" +
    "canner";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomJustify;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(670F, 34F);
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.BackColor = System.Drawing.Color.Black;
            this.PageHeader.BorderColor = System.Drawing.Color.White;
            this.PageHeader.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.PageHeader.ForeColor = System.Drawing.Color.White;
            this.PageHeader.HeightF = 34F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AutoModuleParameter
            // 
            this.AutoModuleParameter.Description = "AutoModule";
            this.AutoModuleParameter.Name = "AutoModuleParameter";
            this.AutoModuleParameter.Type = typeof(bool);
            this.AutoModuleParameter.ValueInfo = "False";
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox4.Image")));
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(249F, 22F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/";
            this.xrPictureBox4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(165.625F, 30.20833F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel3});
            this.ReportHeader.HeightF = 32F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(42F, 25F);
            this.xrLabel1.Text = "Note: ";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox4});
            this.BottomMargin.HeightF = 93F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BarCodeTypes
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.PageHeader,
            this.BottomMargin,
            this.topMarginBand1});
            this.Margins = new System.Drawing.Printing.Margins(100, 80, 86, 93);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AutoModuleParameter});
            this.RequestParameters = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.TextPaddingStyle});
            this.Version = "14.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.BarCodeTypes_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void BarCodeTypes_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            SetAutoModule((bool)AutoModuleParameter.Value);
        }

        void SetAutoModule(bool autoModule) {
            foreach(XRBarCode barCode in AllControls<XRBarCode>())
                barCode.AutoModule = autoModule;
        }
    }
}