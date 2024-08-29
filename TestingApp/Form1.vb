Imports E_Invoice_Extension
Public Class Form1
    Dim invoiceController As New InvoiceController
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        txtToken.Clear()
        Dim strResponse As String = Await invoiceController.login(txtClientId.Text, txtClientSecret.Text)
        txtToken.Text = strResponse
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        rtbResponse.Clear()
        Dim strResponse As String = Await invoiceController.submitDoc(txtToken.Text, txtXml.Text)
        rtbResponse.Text = strResponse
    End Sub

    Private Async Sub btnCancelReject_Click(sender As Object, e As EventArgs) Handles btnCancelReject.Click
        rtbRejectCancel.Clear()
        Dim strResponse As String = Await invoiceController.cancelOrRejectDoc(txtToken.Text, txtUuid.Text, cmbCancelReject.Text, txtReason.Text)
        rtbRejectCancel.Text = strResponse
    End Sub

    Private Async Sub btnGetRecentDoc_Click(sender As Object, e As EventArgs) Handles btnGetRecentDoc.Click
        rtbRecent.Clear()
        Dim strResponse As String = Await invoiceController.getRecentDoc(txtToken.Text)
        rtbRecent.Text = strResponse
    End Sub

    Private Async Sub btnDocType_Click(sender As Object, e As EventArgs) Handles btnDocType.Click
        rtbResponseDoctype.Clear()
        Dim strResponse As String = Await invoiceController.getDocType(txtToken.Text, txtDocTypeId.Text, txtDocTypeVersion.Text)
        rtbResponseDoctype.Text = strResponse
    End Sub

    Private Async Sub btnNoti_Click(sender As Object, e As EventArgs) Handles btnNoti.Click
        rtbResponseNoti.Clear()
        Dim strResponse As String = Await invoiceController.getNotification(txtToken.Text)
        rtbResponseNoti.Text = strResponse
    End Sub

    Private Async Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        rtbValidate.Clear()
        Dim strResponse As String = Await invoiceController.validateTin(txtToken.Text, txtTin.Text, cmbValidateType.Text, txtValidateValue.Text)
        rtbValidate.Text = strResponse
    End Sub

    Private Async Sub btnGetSubmit_Click(sender As Object, e As EventArgs) Handles btnGetSubmit.Click
        rtbShare.Clear()
        Dim strResponse As String = Await invoiceController.getSubmission(txtToken.Text, txtSubmitId.Text)
        rtbShare.Text = strResponse
    End Sub

    Private Async Sub btnGetDocument_Click(sender As Object, e As EventArgs) Handles btnGetDocument.Click
        rtbShare.Clear()
        Dim strResponse As String = Await invoiceController.getDocument(txtToken.Text, txtDocId.Text)
        rtbShare.Text = strResponse
    End Sub

    Private Async Sub btnDocDetail_Click(sender As Object, e As EventArgs) Handles btnDocDetail.Click
        rtbShare.Clear()
        Dim strResponse As String = Await invoiceController.getDocumentDetail(txtToken.Text, txtDocDetailId.Text)
        rtbShare.Text = strResponse
    End Sub

    Private Async Sub btnSearchDoc_Click(sender As Object, e As EventArgs) Handles btnSearchDoc.Click
        rtbShare.Clear()
        Dim strResponse As String = Await invoiceController.searchDoc(txtToken.Text)
        rtbShare.Text = strResponse
    End Sub

End Class
