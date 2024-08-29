<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label15 = New Label()
        txtClientId = New TextBox()
        rtbResponse = New RichTextBox()
        btnLogin = New Button()
        txtClientSecret = New TextBox()
        txtToken = New TextBox()
        txtXml = New TextBox()
        txtUuid = New TextBox()
        txtReason = New TextBox()
        btnGetRecentDoc = New Button()
        btnSubmit = New Button()
        btnCancelReject = New Button()
        cmbCancelReject = New ComboBox()
        rtbRejectCancel = New RichTextBox()
        rtbRecent = New RichTextBox()
        btnDocType = New Button()
        btnNoti = New Button()
        rtbResponseDoctype = New RichTextBox()
        rtbResponseNoti = New RichTextBox()
        txtDocTypeVersion = New TextBox()
        txtDocTypeId = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        btnValidate = New Button()
        txtValidateValue = New TextBox()
        txtTin = New TextBox()
        Label18 = New Label()
        Label19 = New Label()
        cmbValidateType = New ComboBox()
        Label20 = New Label()
        rtbValidate = New RichTextBox()
        btnGetSubmit = New Button()
        btnGetDocument = New Button()
        btnDocDetail = New Button()
        btnSearchDoc = New Button()
        txtSubmitId = New TextBox()
        txtDocId = New TextBox()
        txtDocDetailId = New TextBox()
        rtbShare = New RichTextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 25)
        Label1.TabIndex = 0
        Label1.Text = "Client Id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 25)
        Label2.TabIndex = 1
        Label2.Text = "Client Secret"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 25)
        Label3.TabIndex = 2
        Label3.Text = "token"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(62, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 25)
        Label4.TabIndex = 3
        Label4.Text = "XML Attiribute"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(62, 379)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 25)
        Label5.TabIndex = 4
        Label5.Text = "uuid"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(62, 416)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 25)
        Label6.TabIndex = 5
        Label6.Text = "reason"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(394, 419)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 25)
        Label7.TabIndex = 6
        Label7.Text = "Status"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(1187, 26)
        Label15.Name = "Label15"
        Label15.Size = New Size(60, 25)
        Label15.TabIndex = 14
        Label15.Text = "Status"
        ' 
        ' txtClientId
        ' 
        txtClientId.Location = New Point(170, 26)
        txtClientId.Name = "txtClientId"
        txtClientId.Size = New Size(201, 31)
        txtClientId.TabIndex = 15
        txtClientId.Text = "3a2881f4-e0d8-4577-8847-c2cd3eb09a00"
        ' 
        ' rtbResponse
        ' 
        rtbResponse.Location = New Point(194, 233)
        rtbResponse.Name = "rtbResponse"
        rtbResponse.Size = New Size(1202, 131)
        rtbResponse.TabIndex = 16
        rtbResponse.Text = ""
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(394, 57)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(104, 33)
        btnLogin.TabIndex = 17
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtClientSecret
        ' 
        txtClientSecret.Location = New Point(170, 61)
        txtClientSecret.Name = "txtClientSecret"
        txtClientSecret.Size = New Size(201, 31)
        txtClientSecret.TabIndex = 18
        txtClientSecret.Text = "c16ba9bc-e3f8-4d24-8256-c0a9f20faa82"
        ' 
        ' txtToken
        ' 
        txtToken.Location = New Point(170, 98)
        txtToken.Name = "txtToken"
        txtToken.Size = New Size(1233, 31)
        txtToken.TabIndex = 19
        ' 
        ' txtXml
        ' 
        txtXml.Location = New Point(194, 134)
        txtXml.Multiline = True
        txtXml.Name = "txtXml"
        txtXml.ScrollBars = ScrollBars.Vertical
        txtXml.Size = New Size(1053, 93)
        txtXml.TabIndex = 20
        ' 
        ' txtUuid
        ' 
        txtUuid.Location = New Point(170, 379)
        txtUuid.Name = "txtUuid"
        txtUuid.Size = New Size(201, 31)
        txtUuid.TabIndex = 21
        ' 
        ' txtReason
        ' 
        txtReason.Location = New Point(170, 416)
        txtReason.Name = "txtReason"
        txtReason.Size = New Size(201, 31)
        txtReason.TabIndex = 22
        ' 
        ' btnGetRecentDoc
        ' 
        btnGetRecentDoc.Location = New Point(67, 517)
        btnGetRecentDoc.Name = "btnGetRecentDoc"
        btnGetRecentDoc.Size = New Size(104, 33)
        btnGetRecentDoc.TabIndex = 26
        btnGetRecentDoc.Text = "Get Doc"
        btnGetRecentDoc.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(1276, 137)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(127, 33)
        btnSubmit.TabIndex = 27
        btnSubmit.Text = "Submit Doc"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnCancelReject
        ' 
        btnCancelReject.Location = New Point(394, 370)
        btnCancelReject.Name = "btnCancelReject"
        btnCancelReject.Size = New Size(149, 40)
        btnCancelReject.TabIndex = 28
        btnCancelReject.Text = "Cancel/Reject"
        btnCancelReject.UseVisualStyleBackColor = True
        ' 
        ' cmbCancelReject
        ' 
        cmbCancelReject.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCancelReject.FormattingEnabled = True
        cmbCancelReject.Items.AddRange(New Object() {"cancelled", "rejected"})
        cmbCancelReject.Location = New Point(463, 416)
        cmbCancelReject.Name = "cmbCancelReject"
        cmbCancelReject.Size = New Size(203, 33)
        cmbCancelReject.TabIndex = 29
        ' 
        ' rtbRejectCancel
        ' 
        rtbRejectCancel.Location = New Point(698, 367)
        rtbRejectCancel.Name = "rtbRejectCancel"
        rtbRejectCancel.Size = New Size(698, 131)
        rtbRejectCancel.TabIndex = 30
        rtbRejectCancel.Text = ""
        ' 
        ' rtbRecent
        ' 
        rtbRecent.Location = New Point(194, 517)
        rtbRecent.Name = "rtbRecent"
        rtbRecent.Size = New Size(698, 131)
        rtbRecent.TabIndex = 31
        rtbRecent.Text = ""
        ' 
        ' btnDocType
        ' 
        btnDocType.Location = New Point(37, 665)
        btnDocType.Name = "btnDocType"
        btnDocType.Size = New Size(134, 33)
        btnDocType.TabIndex = 32
        btnDocType.Text = "Get DocType"
        btnDocType.UseVisualStyleBackColor = True
        ' 
        ' btnNoti
        ' 
        btnNoti.Location = New Point(37, 803)
        btnNoti.Name = "btnNoti"
        btnNoti.Size = New Size(134, 33)
        btnNoti.TabIndex = 33
        btnNoti.Text = "Get Noti"
        btnNoti.UseVisualStyleBackColor = True
        ' 
        ' rtbResponseDoctype
        ' 
        rtbResponseDoctype.Location = New Point(660, 665)
        rtbResponseDoctype.Name = "rtbResponseDoctype"
        rtbResponseDoctype.Size = New Size(698, 131)
        rtbResponseDoctype.TabIndex = 34
        rtbResponseDoctype.Text = ""
        ' 
        ' rtbResponseNoti
        ' 
        rtbResponseNoti.Location = New Point(215, 803)
        rtbResponseNoti.Name = "rtbResponseNoti"
        rtbResponseNoti.Size = New Size(574, 131)
        rtbResponseNoti.TabIndex = 35
        rtbResponseNoti.Text = ""
        ' 
        ' txtDocTypeVersion
        ' 
        txtDocTypeVersion.Location = New Point(325, 710)
        txtDocTypeVersion.Name = "txtDocTypeVersion"
        txtDocTypeVersion.Size = New Size(201, 31)
        txtDocTypeVersion.TabIndex = 39
        ' 
        ' txtDocTypeId
        ' 
        txtDocTypeId.Location = New Point(325, 673)
        txtDocTypeId.Name = "txtDocTypeId"
        txtDocTypeId.Size = New Size(201, 31)
        txtDocTypeId.TabIndex = 38
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(217, 710)
        Label16.Name = "Label16"
        Label16.Size = New Size(70, 25)
        Label16.TabIndex = 37
        Label16.Text = "Version"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(217, 673)
        Label17.Name = "Label17"
        Label17.Size = New Size(106, 25)
        Label17.TabIndex = 36
        Label17.Text = "Doc Type id"
        ' 
        ' btnValidate
        ' 
        btnValidate.Location = New Point(1145, 803)
        btnValidate.Name = "btnValidate"
        btnValidate.Size = New Size(134, 33)
        btnValidate.TabIndex = 40
        btnValidate.Text = "Validate"
        btnValidate.UseVisualStyleBackColor = True
        ' 
        ' txtValidateValue
        ' 
        txtValidateValue.Location = New Point(916, 898)
        txtValidateValue.Name = "txtValidateValue"
        txtValidateValue.Size = New Size(201, 31)
        txtValidateValue.TabIndex = 44
        ' 
        ' txtTin
        ' 
        txtTin.Location = New Point(916, 816)
        txtTin.Name = "txtTin"
        txtTin.Size = New Size(201, 31)
        txtTin.TabIndex = 43
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(808, 898)
        Label18.Name = "Label18"
        Label18.Size = New Size(54, 25)
        Label18.TabIndex = 42
        Label18.Text = "Value"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(808, 816)
        Label19.Name = "Label19"
        Label19.Size = New Size(39, 25)
        Label19.TabIndex = 41
        Label19.Text = "TIN"
        ' 
        ' cmbValidateType
        ' 
        cmbValidateType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbValidateType.FormattingEnabled = True
        cmbValidateType.Items.AddRange(New Object() {"NRIC", "PASSPORT", "BRN", "ARMY"})
        cmbValidateType.Location = New Point(916, 853)
        cmbValidateType.Name = "cmbValidateType"
        cmbValidateType.Size = New Size(203, 33)
        cmbValidateType.TabIndex = 46
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(808, 861)
        Label20.Name = "Label20"
        Label20.Size = New Size(49, 25)
        Label20.TabIndex = 45
        Label20.Text = "Type"
        ' 
        ' rtbValidate
        ' 
        rtbValidate.Location = New Point(1125, 853)
        rtbValidate.Name = "rtbValidate"
        rtbValidate.Size = New Size(253, 81)
        rtbValidate.TabIndex = 47
        rtbValidate.Text = ""
        ' 
        ' btnGetSubmit
        ' 
        btnGetSubmit.Location = New Point(37, 950)
        btnGetSubmit.Name = "btnGetSubmit"
        btnGetSubmit.Size = New Size(182, 33)
        btnGetSubmit.TabIndex = 48
        btnGetSubmit.Text = "Get Submission"
        btnGetSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnGetDocument
        ' 
        btnGetDocument.Location = New Point(37, 989)
        btnGetDocument.Name = "btnGetDocument"
        btnGetDocument.Size = New Size(182, 33)
        btnGetDocument.TabIndex = 49
        btnGetDocument.Text = "Get Document"
        btnGetDocument.UseVisualStyleBackColor = True
        ' 
        ' btnDocDetail
        ' 
        btnDocDetail.Location = New Point(37, 1028)
        btnDocDetail.Name = "btnDocDetail"
        btnDocDetail.Size = New Size(182, 33)
        btnDocDetail.TabIndex = 50
        btnDocDetail.Text = "Get Doc Detail"
        btnDocDetail.UseVisualStyleBackColor = True
        ' 
        ' btnSearchDoc
        ' 
        btnSearchDoc.Location = New Point(37, 1063)
        btnSearchDoc.Name = "btnSearchDoc"
        btnSearchDoc.Size = New Size(182, 33)
        btnSearchDoc.TabIndex = 51
        btnSearchDoc.Text = "Search Doc"
        btnSearchDoc.UseVisualStyleBackColor = True
        ' 
        ' txtSubmitId
        ' 
        txtSubmitId.Location = New Point(253, 950)
        txtSubmitId.Name = "txtSubmitId"
        txtSubmitId.Size = New Size(201, 31)
        txtSubmitId.TabIndex = 52
        ' 
        ' txtDocId
        ' 
        txtDocId.Location = New Point(253, 987)
        txtDocId.Name = "txtDocId"
        txtDocId.Size = New Size(201, 31)
        txtDocId.TabIndex = 53
        ' 
        ' txtDocDetailId
        ' 
        txtDocDetailId.Location = New Point(253, 1029)
        txtDocDetailId.Name = "txtDocDetailId"
        txtDocDetailId.Size = New Size(201, 31)
        txtDocDetailId.TabIndex = 54
        ' 
        ' rtbShare
        ' 
        rtbShare.Location = New Point(479, 951)
        rtbShare.Name = "rtbShare"
        rtbShare.Size = New Size(574, 131)
        rtbShare.TabIndex = 55
        rtbShare.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1411, 1108)
        Controls.Add(rtbShare)
        Controls.Add(txtDocDetailId)
        Controls.Add(txtDocId)
        Controls.Add(txtSubmitId)
        Controls.Add(btnSearchDoc)
        Controls.Add(btnDocDetail)
        Controls.Add(btnGetDocument)
        Controls.Add(btnGetSubmit)
        Controls.Add(rtbValidate)
        Controls.Add(cmbValidateType)
        Controls.Add(Label20)
        Controls.Add(txtValidateValue)
        Controls.Add(txtTin)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(btnValidate)
        Controls.Add(txtDocTypeVersion)
        Controls.Add(txtDocTypeId)
        Controls.Add(Label16)
        Controls.Add(Label17)
        Controls.Add(rtbResponseNoti)
        Controls.Add(rtbResponseDoctype)
        Controls.Add(btnNoti)
        Controls.Add(btnDocType)
        Controls.Add(rtbRecent)
        Controls.Add(rtbRejectCancel)
        Controls.Add(cmbCancelReject)
        Controls.Add(btnCancelReject)
        Controls.Add(btnSubmit)
        Controls.Add(btnGetRecentDoc)
        Controls.Add(txtReason)
        Controls.Add(txtUuid)
        Controls.Add(txtXml)
        Controls.Add(txtToken)
        Controls.Add(txtClientSecret)
        Controls.Add(btnLogin)
        Controls.Add(rtbResponse)
        Controls.Add(txtClientId)
        Controls.Add(Label15)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtClientId As TextBox
    Friend WithEvents rtbResponse As RichTextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtClientSecret As TextBox
    Friend WithEvents txtToken As TextBox
    Friend WithEvents txtXml As TextBox
    Friend WithEvents txtUuid As TextBox
    Friend WithEvents txtReason As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents btnGetRecentDoc As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancelReject As Button
    Friend WithEvents cmbCancelReject As ComboBox
    Friend WithEvents rtbRejectCancel As RichTextBox
    Friend WithEvents rtbRecent As RichTextBox
    Friend WithEvents btnDocType As Button
    Friend WithEvents btnNoti As Button
    Friend WithEvents rtbResponseDoctype As RichTextBox
    Friend WithEvents rtbResponseNoti As RichTextBox
    Friend WithEvents txtDocTypeVersion As TextBox
    Friend WithEvents txtDocTypeId As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnValidate As Button
    Friend WithEvents txtValidateValue As TextBox
    Friend WithEvents txtTin As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbValidateType As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents rtbValidate As RichTextBox
    Friend WithEvents btnGetSubmit As Button
    Friend WithEvents btnGetDocument As Button
    Friend WithEvents btnDocDetail As Button
    Friend WithEvents btnSearchDoc As Button
    Friend WithEvents txtSubmitId As TextBox
    Friend WithEvents txtDocId As TextBox
    Friend WithEvents txtDocDetailId As TextBox
    Friend WithEvents rtbShare As RichTextBox

End Class
