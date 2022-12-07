Imports System
Imports DevExpress.Web
Imports DevExpress.XtraReports.UI
Imports T133267_CS.Reports

Namespace T133267_CS
    Partial Public Class [Default]
        Inherits System.Web.UI.Page

        Private Const DefaultReportName As String = "BarCodeTypes"

        Private Property CurrentReportName() As String
            Get
                Return If(TryCast(Session("CurrentReportName"), String), DefaultReportName)
            End Get
            Set(ByVal value As String)
                Session("CurrentReportName") = value
            End Set
        End Property

        Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
            ASPxDocumentViewer1.Report = LoadReportByName(CurrentReportName)
        End Sub

        Protected Sub callbackPanel_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
            Dim selectedReport = If(e.Parameter, DefaultReportName)
            CurrentReportName = selectedReport
            ASPxDocumentViewer1.Report = LoadReportByName(selectedReport)
            ASPxDocumentViewer1.JSProperties("cpReportName") = selectedReport
        End Sub

        Private Shared Function LoadReportByName(ByVal name As String) As XtraReport
            Select Case name
                Case "Shapes"
                    Return New Shapes()
                Case "BarCodeTypes"
                    Return New BarCodeTypes()
                Case Else
                    Return Nothing
            End Select
        End Function
    End Class
End Namespace