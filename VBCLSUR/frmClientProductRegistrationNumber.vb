Imports System.IO
Imports System.Management
Imports System.Text
Imports System.Collections.Specialized
Imports System.Security.Cryptography
Imports System.Security.Cryptography.CryptoStream
Imports System.Security.Cryptography.MD5
Imports System.Security.Cryptography.MD5CryptoServiceProvider
Imports System.Security.Cryptography.TripleDES
Imports System.Security.Cryptography.TripleDESCryptoServiceProvider
Imports Common
Imports BLL
Imports System.Windows.Forms

Public Class frmClientProductRegistrationNumber
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
    Friend WithEvents lblInformation As System.Windows.Forms.Label
    Friend WithEvents txtActivationCode As System.Windows.Forms.TextBox
    Friend WithEvents lblActivationCode As System.Windows.Forms.Label
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents txtEnhCode As System.Windows.Forms.TextBox
    Friend WithEvents lblEnhcode As System.Windows.Forms.Label
    Friend WithEvents lblRegistrationNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnConinueWithoutRegistration As System.Windows.Forms.Button
    Friend WithEvents BtnRequest As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblInformation = New System.Windows.Forms.Label
        Me.txtActivationCode = New System.Windows.Forms.TextBox
        Me.lblActivationCode = New System.Windows.Forms.Label
        Me.btnActivate = New System.Windows.Forms.Button
        Me.txtEnhCode = New System.Windows.Forms.TextBox
        Me.lblEnhcode = New System.Windows.Forms.Label
        Me.lblRegistrationNumber = New System.Windows.Forms.TextBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnConinueWithoutRegistration = New System.Windows.Forms.Button
        Me.BtnRequest = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblInformation
        '
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.ForeColor = System.Drawing.Color.Green
        Me.lblInformation.Location = New System.Drawing.Point(24, 64)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(384, 48)
        Me.lblInformation.TabIndex = 0
        Me.lblInformation.Text = "Your Enhancements have been installed Successfully.Above is your Registration Num" & _
        "ber please provide that Registration Number to the SKS Consulting to get your En" & _
        "hancement Activation Code."
        '
        'txtActivationCode
        '
        Me.txtActivationCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtActivationCode.Location = New System.Drawing.Point(104, 144)
        Me.txtActivationCode.Name = "txtActivationCode"
        Me.txtActivationCode.Size = New System.Drawing.Size(272, 20)
        Me.txtActivationCode.TabIndex = 3
        Me.txtActivationCode.Text = ""
        '
        'lblActivationCode
        '
        Me.lblActivationCode.Location = New System.Drawing.Point(104, 128)
        Me.lblActivationCode.Name = "lblActivationCode"
        Me.lblActivationCode.Size = New System.Drawing.Size(248, 16)
        Me.lblActivationCode.TabIndex = 2
        Me.lblActivationCode.Text = "Enter Activation Code and Press Validate Button"
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(312, 184)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.TabIndex = 4
        Me.btnActivate.Text = "&Register"
        '
        'txtEnhCode
        '
        Me.txtEnhCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEnhCode.Location = New System.Drawing.Point(24, 144)
        Me.txtEnhCode.MaxLength = 3
        Me.txtEnhCode.Name = "txtEnhCode"
        Me.txtEnhCode.Size = New System.Drawing.Size(64, 20)
        Me.txtEnhCode.TabIndex = 1
        Me.txtEnhCode.Text = ""
        '
        'lblEnhcode
        '
        Me.lblEnhcode.Location = New System.Drawing.Point(24, 128)
        Me.lblEnhcode.Name = "lblEnhcode"
        Me.lblEnhcode.Size = New System.Drawing.Size(64, 16)
        Me.lblEnhcode.TabIndex = 0
        Me.lblEnhcode.Text = "Enh Code"
        '
        'lblRegistrationNumber
        '
        Me.lblRegistrationNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRegistrationNumber.Location = New System.Drawing.Point(24, 32)
        Me.lblRegistrationNumber.Name = "lblRegistrationNumber"
        Me.lblRegistrationNumber.ReadOnly = True
        Me.lblRegistrationNumber.Size = New System.Drawing.Size(352, 20)
        Me.lblRegistrationNumber.TabIndex = 5
        Me.lblRegistrationNumber.Text = ""
        Me.lblRegistrationNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(392, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Close"
        '
        'btnConinueWithoutRegistration
        '
        Me.btnConinueWithoutRegistration.Location = New System.Drawing.Point(8, 184)
        Me.btnConinueWithoutRegistration.Name = "btnConinueWithoutRegistration"
        Me.btnConinueWithoutRegistration.Size = New System.Drawing.Size(192, 23)
        Me.btnConinueWithoutRegistration.TabIndex = 6
        Me.btnConinueWithoutRegistration.Text = "&Continue without Registration..."
        '
        'BtnRequest
        '
        Me.BtnRequest.Location = New System.Drawing.Point(208, 184)
        Me.BtnRequest.Name = "BtnRequest"
        Me.BtnRequest.Size = New System.Drawing.Size(96, 23)
        Me.BtnRequest.TabIndex = 7
        Me.BtnRequest.Text = "Request for Key"
        '
        'frmClientProductRegistrationNumber
        '
        Me.AcceptButton = Me.btnConinueWithoutRegistration
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 214)
        Me.Controls.Add(Me.BtnRequest)
        Me.Controls.Add(Me.btnConinueWithoutRegistration)
        Me.Controls.Add(Me.lblRegistrationNumber)
        Me.Controls.Add(Me.txtEnhCode)
        Me.Controls.Add(Me.txtActivationCode)
        Me.Controls.Add(Me.lblEnhcode)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.lblActivationCode)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.btnExit)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmClientProductRegistrationNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enchancement Registration..."
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private searcher As New ManagementObjectSearcher("Select * from Win32_PhysicalMedia")
    Private SerialNo As String
    Private abc As String
    Private HDSerial As String

    Private ReadOnly kashif
    Private lbtVector() As Byte = {240, 3, 45, 29, 0, 76, 173, 59}
    Private lscryptoKey As String = "kashif"
    Private vusdbregcontroller As New VUSDBREGBLL
    Public prjdet As New ProjectDetail


    Private Sub frmClientProductRegistrationNumber_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim b = GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", "")
            If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "Bool", "") = "" Then
                If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", "") = "" Then
                    SaveSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", 1)
                End If
                Dim a = GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", Val(GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", "") + 1))
                If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", Val(GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", "") + 1)) > prjdet.Noofhits Then
                    SaveSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "Bool", True)
                    MsgBox("Please Register the Enhancement First", MsgBoxStyle.Information, Me.Text)
                    btnConinueWithoutRegistration.Enabled = False

                Else
                    SaveSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", Val(b) + 1)
                    btnConinueWithoutRegistration.Enabled = True
                End If

            Else
                MsgBox("Please Register the Enhancement First", MsgBoxStyle.Information, Me.Text)
                btnConinueWithoutRegistration.Enabled = False
            End If



            Try
                Dim serial
                serial = FingerPrint.Value ' mdlGlobal.GetHDSerial()
                Dim keyObj As New mdlGenerator
                HDSerial = keyObj.GetActivationCode(serial + serial, serial).Replace("-", "")
                Me.lblRegistrationNumber.Text = HDSerial
                prjdet.StatusCheck = False
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Load Error")

            End Try

        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.AbortRetryIgnore, "frmClientProductRegistration_LOad")
        End Try

    End Sub

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        Try

            Dim rever As String
            Dim bank As String
            Dim abc As String = ""
            Dim activationCodes As String = ""

            If Me.txtEnhCode.Text.Trim = String.Empty Then
                MsgBox("Please enter enhamcement code.", MsgBoxStyle.Exclamation)
                Me.txtEnhCode.Focus()
                Exit Sub
            ElseIf Me.txtActivationCode.Text.Trim = String.Empty Then
                MsgBox("Please enter activation code.", MsgBoxStyle.Exclamation)
                Me.txtActivationCode.Focus()
                Exit Sub
            End If
            If prjdet.ProjectName <> Me.txtEnhCode.Text.Trim Then
                MsgBox("Please enter valid EnhancemnetCode Like ABC", MsgBoxStyle.Exclamation, "Information")
                Exit Sub
            End If
            rever = StrReverse(Me.txtEnhCode.Text.Trim)
            bank = Mid(HDSerial, 1, 3)
            rever = rever.Insert(1, Mid(bank, 1, 1))
            rever = rever.Insert(3, Mid(bank, 2, 1))
            rever = rever.Insert(5, Mid(bank, 3, 1))
            abc = abc + rever + vbCrLf
            Dim S As String
            Dim keyObj As New mdlGenerator
            S = keyObj.GetActivationCode(HDSerial, rever)
            If S = Me.txtActivationCode.Text.Trim Then


                activationCodes += Me.txtEnhCode.Text.Trim + vbTab + keyObj.GetActivationCode(HDSerial, rever) & vbCrLf
                Try

                    vusdbregcontroller.SaveReg(New ProjectDetail(lblRegistrationNumber.Text, S))
                     
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
                'if it is ok then let it ok 
                prjdet.StatusCheck = True

                prjdet.Active_code = Me.txtEnhCode.Text.Trim + "\" + keyObj.GetActivationCode(HDSerial, rever)
                SaveSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, Me.lblRegistrationNumber.Text.Trim, True)
                SaveSetting(prjdet.CompanyName, prjdet.ProjectName.Trim + prjdet.Year & prjdet.MyAdd_CS.Trim, prjdet.MyAdd_CS.Trim, prjdet.Active_code)
                MsgBox("Thank You for registering you Product", MsgBoxStyle.Information, Me.Text)

                Me.Dispose()


                System.Windows.Forms.Application.DoEvents()

                Exit Sub 'mainFormMenu.MenuItems
            Else
                MsgBox("Invalid Activation Code", MsgBoxStyle.Critical, "Failed Activation")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Activation Error")
            MsgBox("Activation Code seems to be in invalid format.", MsgBoxStyle.Exclamation, "Activation Error")
            'sw.WriteLine("btnActivate_Click" + ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click


        prjdet.StatusCheck = False

        Me.Close()
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub btnConinueWithoutRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConinueWithoutRegistration.Click


        'Me.Dispose()
        prjdet.StatusCheck = True
        prjdet.Active_code = "with_out_reg"

        Me.Close()
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub BtnRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRequest.Click
        Dim frmCustInfo As New FrmCutomerInfo
        frmCustInfo.ShowDialog()
    End Sub
    Public Function psEncrypt(ByVal sInputVal As String) As String

        Dim loCryptoClass As New TripleDESCryptoServiceProvider
        Dim loCryptoProvider As New MD5CryptoServiceProvider
        Dim lbtBuffer() As Byte

        ' Dim lbtVector As String()


        Try
            'st = Converter.StringToBinary(sInputVal)
            lbtBuffer = System.Text.Encoding.ASCII.GetBytes(Convert.ToString(sInputVal))
            'lbtBuffer = System.Text.Encoding.ASCII.GetBytes(sInputVal)
            loCryptoClass.Key = loCryptoProvider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(lscryptoKey))
            loCryptoClass.IV = lbtVector
            sInputVal = Convert.ToBase64String(loCryptoClass.CreateEncryptor().TransformFinalBlock(lbtBuffer, 0, lbtBuffer.Length()))
            psEncrypt = sInputVal
        Catch ex As CryptographicException
            Throw ex
        Catch ex As FormatException
            Throw ex
        Catch ex As Exception
            Throw ex
        Finally
            loCryptoClass.Clear()
            loCryptoProvider.Clear()
            loCryptoClass = Nothing
            loCryptoProvider = Nothing
        End Try
    End Function

    Public Function psDecrypt(ByVal sQueryString As String) As String

        Dim buffer() As Byte
        Dim loCryptoClass As New TripleDESCryptoServiceProvider
        Dim loCryptoProvider As New MD5CryptoServiceProvider
        'Dim lscryptoKey As String


        Try
            'st = Converter.BinaryToString(sQueryString)
            buffer = Convert.FromBase64String(sQueryString)
            'buffer = Convert.FromBase64String(sQueryString)
            'loCryptoClass.Key = loCryptoProvider.ComputeHash(lscryptoKey)
            loCryptoProvider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(lscryptoKey))
            loCryptoClass.IV = lbtVector
            Return Encoding.ASCII.GetString(loCryptoClass.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
        Catch ex As Exception
            Throw ex
        Finally
            loCryptoClass.Clear()
            loCryptoProvider.Clear()
            loCryptoClass = Nothing
            loCryptoProvider = Nothing
        End Try
    End Function

    Private Sub frmClientProductRegistrationNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmClientProductRegistrationNumber_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

    End Sub
End Class
