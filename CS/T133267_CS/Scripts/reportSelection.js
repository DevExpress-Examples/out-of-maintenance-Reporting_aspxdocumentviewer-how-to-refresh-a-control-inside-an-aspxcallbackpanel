function documentViewerInitialization(documentViewer) {
    var toolbar = documentViewer.GetToolbar();
    var reportsCombobox = toolbar.GetItemTemplateControl('Reports');
    if(documentViewer.cpReportName) {
        var item = reportsCombobox.FindItemByValue(documentViewer.cpReportName);
        reportsCombobox.SetSelectedItem(item);
    }
}

function processToolbarItemValueChanged(callbackPanel, documentViewer, e) {
    if(e.item && e.item.name === 'Reports') {
        var reportName = e.editor.GetValue();
        callbackPanel.PerformCallback(reportName);
    }
}