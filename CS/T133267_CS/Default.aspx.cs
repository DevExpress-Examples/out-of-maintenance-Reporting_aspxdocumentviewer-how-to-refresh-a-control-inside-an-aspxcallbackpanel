using System;
using DevExpress.Web;
using DevExpress.XtraReports.UI;
using T133267_CS.Reports;

namespace T133267_CS {
    public partial class Default : System.Web.UI.Page {
        const string DefaultReportName = "BarCodeTypes";

        string CurrentReportName {
            get { return Session["CurrentReportName"] as string ?? DefaultReportName; }
            set { Session["CurrentReportName"] = value; }
        }

        protected void Page_Init(object sender, EventArgs e) {
            ASPxDocumentViewer1.Report = LoadReportByName(CurrentReportName);
        }

        protected void callbackPanel_Callback(object sender, CallbackEventArgsBase e) {
            var selectedReport = e.Parameter ?? DefaultReportName;
            CurrentReportName = selectedReport;
            ASPxDocumentViewer1.Report = LoadReportByName(selectedReport);
            ASPxDocumentViewer1.JSProperties["cpReportName"] = selectedReport;
        }

        static XtraReport LoadReportByName(string name) {
            switch(name) {
                case "Shapes":
                    return new Shapes();
                case "BarCodeTypes":
                    return new BarCodeTypes();
                default:
                    return null;
            }
        }
    }
}