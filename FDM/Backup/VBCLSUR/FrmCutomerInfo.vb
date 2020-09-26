Imports System.Xml

Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports BLL
Imports Common

Public Class FrmCutomerInfo
    Inherits System.Windows.Forms.Form

    

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSysRegNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCompName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtZIP As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Lable9 As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmbEnh As System.Windows.Forms.ComboBox
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents Fg1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtFolderBrowse As System.Windows.Forms.TextBox
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCutomerInfo))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSysRegNo = New System.Windows.Forms.TextBox
        Me.txtCompName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcity = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtZIP = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnExport = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.txtState = New System.Windows.Forms.TextBox
        Me.Lable9 = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtSerialNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCustID = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.CmbEnh = New System.Windows.Forms.ComboBox
        Me.Fg1 = New System.Windows.Forms.FolderBrowserDialog
        Me.txtFolderBrowse = New System.Windows.Forms.TextBox
        Me.BtnBrowse = New System.Windows.Forms.Button
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System Registration No"
        '
        'txtSysRegNo
        '
        Me.txtSysRegNo.Enabled = False
        Me.txtSysRegNo.Location = New System.Drawing.Point(144, 12)
        Me.txtSysRegNo.Name = "txtSysRegNo"
        Me.txtSysRegNo.Size = New System.Drawing.Size(176, 20)
        Me.txtSysRegNo.TabIndex = 1
        Me.txtSysRegNo.Text = ""
        '
        'txtCompName
        '
        Me.txtCompName.Location = New System.Drawing.Point(144, 40)
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.Size = New System.Drawing.Size(176, 20)
        Me.txtCompName.TabIndex = 3
        Me.txtCompName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Company Name"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(144, 72)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(176, 20)
        Me.txtAddress.TabIndex = 5
        Me.txtAddress.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address"
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(144, 136)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(176, 20)
        Me.txtcity.TabIndex = 7
        Me.txtcity.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "City"
        '
        'txtZIP
        '
        Me.txtZIP.Location = New System.Drawing.Point(144, 192)
        Me.txtZIP.Name = "txtZIP"
        Me.txtZIP.Size = New System.Drawing.Size(176, 20)
        Me.txtZIP.TabIndex = 9
        Me.txtZIP.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ZIP"
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(144, 224)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(176, 20)
        Me.txtCountry.TabIndex = 11
        Me.txtCountry.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Country"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(144, 256)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(176, 20)
        Me.txtPhone.TabIndex = 13
        Me.txtPhone.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Phone"
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(144, 288)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(176, 20)
        Me.txtFax.TabIndex = 15
        Me.txtFax.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Fax"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(144, 320)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(176, 20)
        Me.txtEmail.TabIndex = 19
        Me.txtEmail.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "E-Mail"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(16, 480)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(88, 24)
        Me.BtnSave.TabIndex = 20
        Me.BtnSave.Text = "Save"
        '
        'BtnExport
        '
        Me.BtnExport.Location = New System.Drawing.Point(128, 480)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(88, 24)
        Me.BtnExport.TabIndex = 21
        Me.BtnExport.Text = "Export "
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(328, 480)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(88, 24)
        Me.BtnExit.TabIndex = 22
        Me.BtnExit.Text = "E&xit"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(144, 168)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(176, 20)
        Me.txtState.TabIndex = 24
        Me.txtState.Text = ""
        '
        'Lable9
        '
        Me.Lable9.Location = New System.Drawing.Point(8, 160)
        Me.Lable9.Name = "Lable9"
        Me.Lable9.Size = New System.Drawing.Size(104, 16)
        Me.Lable9.TabIndex = 23
        Me.Lable9.Text = "State"
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(144, 104)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(176, 20)
        Me.txtAddress2.TabIndex = 25
        Me.txtAddress2.Text = ""
        '
        'txtSerialNo
        '
        Me.txtSerialNo.Enabled = False
        Me.txtSerialNo.Location = New System.Drawing.Point(144, 344)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.Size = New System.Drawing.Size(176, 20)
        Me.txtSerialNo.TabIndex = 26
        Me.txtSerialNo.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Peachtree Serial No"
        '
        'txtCustID
        '
        Me.txtCustID.Enabled = False
        Me.txtCustID.Location = New System.Drawing.Point(144, 376)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(176, 20)
        Me.txtCustID.TabIndex = 28
        Me.txtCustID.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 376)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Peachtree Customer ID"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(0, 416)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 16)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Enhancement"
        '
        'CmbEnh
        '
        Me.CmbEnh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEnh.Location = New System.Drawing.Point(144, 408)
        Me.CmbEnh.Name = "CmbEnh"
        Me.CmbEnh.Size = New System.Drawing.Size(144, 21)
        Me.CmbEnh.TabIndex = 31
        '
        'txtFolderBrowse
        '
        Me.txtFolderBrowse.Enabled = False
        Me.txtFolderBrowse.Location = New System.Drawing.Point(24, 448)
        Me.txtFolderBrowse.Name = "txtFolderBrowse"
        Me.txtFolderBrowse.Size = New System.Drawing.Size(288, 20)
        Me.txtFolderBrowse.TabIndex = 32
        Me.txtFolderBrowse.Text = ""
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Location = New System.Drawing.Point(320, 448)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(72, 24)
        Me.BtnBrowse.TabIndex = 33
        Me.BtnBrowse.Text = "B&rowse"
        '
        'BtnEmail
        '
        Me.BtnEmail.Location = New System.Drawing.Point(232, 480)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(88, 24)
        Me.BtnEmail.TabIndex = 34
        Me.BtnEmail.Text = "E-mail"
        '
        'FrmCutomerInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 518)
        Me.Controls.Add(Me.BtnEmail)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.txtFolderBrowse)
        Me.Controls.Add(Me.CmbEnh)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSerialNo)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.Lable9)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtZIP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCompName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSysRegNo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCutomerInfo"
        Me.Text = "Customer Info"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private vusdbregcontroller As New VUSDBREGBLL
    Private Sub FrmCutomerInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

        



        Dim ds As New DataSet
            Dim dsdata As New DataSet
            Dim dt As New DataTable
            Dim i As Integer
            dt = vusdbregcontroller.GetCusInfo()
       
            dsdata.Tables.Add(dt)
        If dsdata.Tables(0).Rows.Count = 0 Then
               
                dt = vusdbregcontroller.GetCompanyInfo()
                Dim serial, HDSerial



                serial = FingerPrint.Value '.GetHDSerial()
                Dim keyObj As New mdlGenerator
                HDSerial = keyObj.GetActivationCode(serial + serial, serial).Replace("-", "")
                txtSysRegNo.Text = HDSerial
                If dt.Columns.Contains("Name").ToString() Then
                    txtCompName.Text = dt.Rows(0).Item("Name").ToString()
                End If
                If dt.Columns.Contains("Address1").ToString() Then
                    txtAddress.Text = dt.Rows(0).Item("Address1").ToString()
                End If
                If dt.Columns.Contains("Address2").ToString() Then
                    txtAddress2.Text = "" & dt.Rows(0).Item("Address2").ToString()
                End If
                If dt.Columns.Contains("City").ToString() Then
                    txtcity.Text = dt.Rows(0).Item("City").ToString()
                End If
                If dt.Columns.Contains("CompanyEmail").ToString() Then
                    txtEmail.Text = "" & dt.Rows(0).Item("CompanyEmail").ToString()
                End If
                If dt.Columns.Contains("State").ToString() Then
                    txtState.Text = "" & dt.Rows(0).Item("State").ToString()
                End If
                If dt.Columns.Contains("Telephone").ToString() Then
                    txtPhone.Text = "" & dt.Rows(0).Item("Telephone").ToString()
                End If
                If dt.Columns.Contains("Fax").ToString() Then
                    txtFax.Text = "" & dt.Rows(0).Item("Fax").ToString()
                End If
                If dt.Columns.Contains("Country").ToString() Then
                    txtCountry.Text = "" & dt.Rows(0).Item("Country").ToString()
                End If
                If dt.Columns.Contains("Zip").ToString() Then
                    txtZIP.Text = "" & dt.Rows(0).Item("Zip").ToString()
                End If
                If dt.Columns.Contains("SysRegNumber").ToString() Then
                    txtSysRegNo.Text = "" & HDSerial
                End If



                txtSerialNo.Text = vusdbregcontroller.GetPeachSerialNo()
                txtCustID.Text = vusdbregcontroller.GetPeachCustomerNumber()

            Else
                txtCompName.Text = "" & dsdata.Tables(0).Rows(0).Item("Name").ToString()
                txtAddress.Text = "" & dsdata.Tables(0).Rows(0).Item("Address1").ToString()
                txtAddress2.Text = "" & dsdata.Tables(0).Rows(0).Item("Address2").ToString()
                txtcity.Text = "" & dsdata.Tables(0).Rows(0).Item("City").ToString()
                txtState.Text = "" & dsdata.Tables(0).Rows(0).Item("State").ToString()
                txtZIP.Text = "" & dsdata.Tables(0).Rows(0).Item("Zip").ToString()
                txtCountry.Text = "" & dsdata.Tables(0).Rows(0).Item("Country").ToString()
                txtPhone.Text = "" & dsdata.Tables(0).Rows(0).Item("Telephone").ToString()
                txtFax.Text = "" & dsdata.Tables(0).Rows(0).Item("Fax").ToString()
                txtEmail.Text = "" & dsdata.Tables(0).Rows(0).Item("CompanyEmail").ToString()
                txtSerialNo.Text = "" & dsdata.Tables(0).Rows(0).Item("SerialNumber").ToString()
                txtCustID.Text = "" & dsdata.Tables(0).Rows(0).Item("CustomerNumber").ToString()
                txtSysRegNo.Text = "" & dsdata.Tables(0).Rows(0).Item("SysRegNumber").ToString()
            End If
            
            dt = vusdbregcontroller.GetALLUnRegEnh()
            ds.Tables.Add(dt)
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    CmbEnh.Items.Add(ds.Tables(0).Rows(i).Item(0).ToString())
                Next
            End If
            txtFolderBrowse.Text = "c:\"
             


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
  

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
       
        Try
            If (vusdbregcontroller.SaveCustInfo(New CompanyInformation(txtCompName.Text, txtAddress.Text, txtAddress2.Text, txtcity.Text, txtState.Text, txtZIP.Text, txtCountry.Text, txtPhone.Text, txtFax.Text, txtEmail.Text), txtSysRegNo.Text, txtSerialNo.Text, txtCustID.Text) = True) Then
                MsgBox("Operation Completed succesfully ", MsgBoxStyle.Information, Me.Text)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "BtnSave_Click")
        End Try

    End Sub

    Private Sub Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExport.Click

        Dim Export As String
        Dim fileinfo As String
        Dim prjdet As New ProjectDetail
        Export = prjdet.ProjectName & " Request"
        If CmbEnh.Text = "" Then
            MsgBox("Please Select the Enhancement which you want to request ", MsgBoxStyle.Information, Me.Text)
            CmbEnh.Focus()
            Exit Sub
        ElseIf txtFolderBrowse.Text = "" Then
            MsgBox("Please Select the path ", MsgBoxStyle.Information, Me.Text)
            txtFolderBrowse.Focus()
            Exit Sub
        End If
        If Not File.Exists(txtFolderBrowse.Text + "\" + Export + ".txt") Then

            Dim sw As New StreamWriter(txtFolderBrowse.Text + "\" + Export + ".txt")
            fileinfo = "System Registeration No " & vbTab & txtSysRegNo.Text & vbNewLine & _
            "PeachTree Serial No" & vbTab & txtSerialNo.Text & vbNewLine & _
            "Peachtree Customer ID" & vbTab & txtCustID.Text & vbNewLine & _
            "Enhancement Required " & vbTab & CmbEnh.SelectedItem & vbNewLine & _
            "Company Name " & vbTab & txtCompName.Text & vbNewLine & _
            "Company Address" & vbTab & txtAddress.Text & txtAddress2.Text & vbNewLine & _
            "Company Phone " & vbTab & txtPhone.Text & vbNewLine & _
            "Company Fax" & vbTab & txtFax.Text & vbNewLine & _
            "Company Email" & vbTab & txtEmail.Text & vbNewLine & _
            "Company City" & vbTab & txtcity.Text & vbNewLine & _
            "Company Country" & vbTab & txtCountry.Text & vbNewLine & _
            "Company State" & vbTab & txtState.Text & vbNewLine & _
            "Company Zip" & vbTab & txtZIP.Text & vbNewLine

            sw.Write(fileinfo)
            '    MsgBox("Your request has been successfully write", MsgBoxStyle.Information, Me.Text)
            sw.Close()

        End If

    End Sub

    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        Fg1.ShowDialog()
        txtFolderBrowse.Text = Fg1.SelectedPath
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Dispose()
    End Sub

    Private Sub BtnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmail.Click
        Dim FileInfo As String
        Dim Export As String

        Dim prjdet As New ProjectDetail
        Export = prjdet.ProjectName & " Request" & CmbEnh.Text
        If CmbEnh.Text <> "" Then
            Export_Click(Nothing, Nothing)
            '  FF = txtFolderBrowse.Text + "\" + Export + ".txt"


            FileInfo = "mailto:" & prjdet.CompanyEmail & "?subject=Enhancement Actvation Request&body=" & _
               "System Registration No:" & vbTab & txtSysRegNo.Text & _
               "     PeachTree Serial No:   " & vbTab & txtSerialNo.Text & _
               "     Peachtree Customer ID:  " & vbTab & txtCustID.Text & _
               "     Enhancement Required:  " & vbTab & CmbEnh.Text & _
               "   Company Name:   " & vbTab & txtCompName.Text & _
               "   Company Address:  " & vbTab & txtAddress.Text & txtAddress2.Text & _
               "    Company Phone:  " & vbTab & txtPhone.Text & _
               "     Company Fax:    " & vbTab & txtFax.Text & _
               "     Company Email:   " & vbTab & txtEmail.Text & _
               "     Company City:  " & vbTab & txtcity.Text & _
               "    Company Country: " & vbTab & txtCountry.Text & _
               "    Company State:  " & vbTab & txtState.Text & vbNewLine & _
               "    Company Zip:   " & vbTab & txtZIP.Text & vbNewLine



            System.Diagnostics.Process.Start(FileInfo)
        Else
            MsgBox("Please Select the Enhancement First", MsgBoxStyle.Information, Me.Text)
            CmbEnh.Focus()
            Exit Sub

        End If


    End Sub


    Private Sub FrmCutomerInfo_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

       
    End Sub
End Class
