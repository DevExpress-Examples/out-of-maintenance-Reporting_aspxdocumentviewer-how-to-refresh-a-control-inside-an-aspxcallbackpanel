<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="T133267_CS.Default" %>

<%@ Register Assembly="DevExpress.Web.v14.1" Namespace="DevExpress.Web.ASPxCallbackPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraReports.v14.1.Web" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>T133267: ASPxDocumentViewer - How to refresh control inside ASPxCallbackPanel</title>
    <script type="text/javascript" src="Scripts/reportSelection.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <dx:aspxcallbackpanel runat="server" ClientInstanceName="callbackPanel" OnCallback="callbackPanel_Callback">
            <PanelCollection>
                <dx:PanelContent runat="server">
                    <dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" ClientInstanceName="documentViewer" runat="server">
                        <SettingsReportViewer UseIFrame="false" />
                        <SettingsSplitter DocumentMapCollapsed="true" />
                        <toolbaritems>
                            <dx:ReportToolbarButton ItemKind="Search" />
                            <dx:ReportToolbarSeparator />
                            <dx:ReportToolbarButton ItemKind="PrintReport" />
                            <dx:ReportToolbarButton ItemKind="PrintPage" />
                            <dx:ReportToolbarSeparator />
                            <dx:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
                            <dx:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
                            <dx:ReportToolbarLabel ItemKind="PageLabel" />
                            <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                            </dx:ReportToolbarComboBox>
                            <dx:ReportToolbarLabel ItemKind="OfLabel" />
                            <dx:ReportToolbarTextBox ItemKind="PageCount" />
                            <dx:ReportToolbarButton ItemKind="NextPage" />
                            <dx:ReportToolbarButton ItemKind="LastPage" />
                            <dx:ReportToolbarSeparator />
                            <dx:ReportToolbarButton ItemKind="SaveToDisk" />
                            <dx:ReportToolbarButton ItemKind="SaveToWindow" />
                            <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                                <elements>
                                    <dx:ListElement Value="pdf" />
                                    <dx:ListElement Value="xls" />
                                    <dx:ListElement Value="xlsx" />
                                    <dx:ListElement Value="rtf" />
                                    <dx:ListElement Value="mht" />
                                    <dx:ListElement Value="html" />
                                    <dx:ListElement Value="txt" />
                                    <dx:ListElement Value="csv" />
                                    <dx:ListElement Value="png" />
                                </elements>
                            </dx:ReportToolbarComboBox>
                            <dx:ReportToolbarComboBox Name="Reports">
                                <elements>
                                    <dx:ListElement Text="BarCodes" Value="BarCodeTypes" />
                                    <dx:ListElement Text="Shapes" Value="Shapes" />
                                </elements>
                            </dx:ReportToolbarComboBox>
                        </toolbaritems>
                        <clientsideevents toolbaritemvaluechanged="function(_, e) { processToolbarItemValueChanged(callbackPanel, documentViewer, e); }"
                                Init="function(s, e) { documentViewerInitialization(s); }" />
                    </dx:ASPxDocumentViewer>
                </dx:PanelContent>
            </PanelCollection>
        </dx:aspxcallbackpanel>
    </form>
</body>
</html>
