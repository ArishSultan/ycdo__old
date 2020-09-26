Imports Common
Imports BLL
Public Class VBCLS

    'Public Function Get_Reg_Code() As Object
    '    Dim Srno
    '    Srno = FingerPrint.Value
    '    Dim keyObj As New mdlGenerator
    '    Return keyObj.GetActivationCode(Srno + Srno, Srno).Replace("-", "")
    'End Function


    Public Function LETGO() As Boolean
        Dim vuscontrol As New VUSDBREGBLL
        Dim DoContinue As Boolean = False
        Try
            Dim prjdet As New ProjectDetail
            '"Select EnhCode,EnhMenuText from Enhancements Where EnhActivationCode<>'none'"
            Dim frmclientAuthentication As New frmClientProductRegistrationNumber
            Dim Res As Integer = -1
            'first verify Database 
            'Dim helper As New OledbHelper
            'helper.SetStartupPath(InfoCls.MainConfigFile)

            DoContinue = False   ' helper.ExecuteScalar("Select EnhActivationCode  from Enhancements Where EnhCode='" & prjdet.ProjectName  & "'")

            'June 14, 2011 - faheem khan

            'task add year information in registration key 
            '---->Start
            ' we will not look at the main database
            ' as it does not contain year information.
            'DoContinue = vuscontrol.GetACode()
            '---->end of June 14,2011 -faheem khan

            'helper.CloseConnection()
            'helper = Nothing
            'if already activated inside the database
            'this is for old projects which has not this style 
            If (DoContinue = True) Then
                Res = 3
            End If
            If Res <> 3 Then
                Res = VerifyCode()

            End If

            If Res = 0 Or Res = 2 Then


                frmclientAuthentication.ShowDialog()
                'frmclientAuthentication.Close()
                If frmclientAuthentication.prjdet.StatusCheck = True Or frmclientAuthentication.prjdet.Active_code = "with_out_reg" Then
                    DoContinue = True
                Else
                    DoContinue = False

                End If
            ElseIf Res = 1 Then
                Try

                    frmclientAuthentication.ShowDialog()

                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.ApplicationModal, "Res 1")

                End Try

                If frmclientAuthentication.prjdet.Active_code <> "" Then
                    DoContinue = True
                Else
                    DoContinue = False
                    'Application.Exit()
                End If
            ElseIf Res = 3 Then
                DoContinue = True

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "LET GO")
        End Try
        Return DoContinue
    End Function
    Private Function VerifyCode() As Integer
        Dim prjdet As New ProjectDetail

        Dim b = GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", "")
        If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "Bool", "") = "" Then
            If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", "") = "" Then
                Return 0
            End If

            Dim a = GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", Val(GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", "") + 1))
            If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", Val(GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", "") + 1)) > prjdet.Noofhits Then

                Try
                    If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year & prjdet.MyAdd_CS, prjdet.MyAdd_CS) <> "" Then
                        Return 3
                    Else
                        Return 1
                    End If
                Catch ex As Exception
                    Return 1
                End Try
            Else
                Try
                    If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year & prjdet.MyAdd_CS, prjdet.MyAdd_CS) <> "" Then
                        Return 3
                    Else
                        Return 2
                    End If
                Catch ex As Exception
                    Return 2
                End Try
            End If

        Else
            Dim a = GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", Val(GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", "") + 1))

            If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", Val(GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year, "ExpD", "") + 1)) > prjdet.Noofhits Then

                Try
                    If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year & prjdet.MyAdd_CS, prjdet.MyAdd_CS) <> "" Then
                        Return 3
                    Else
                        Return 1
                    End If
                Catch ex As Exception
                    Return 1
                End Try
            Else
                Try

                    If GetSetting(prjdet.CompanyName, prjdet.ProjectName + prjdet.Year & prjdet.MyAdd_CS, prjdet.MyAdd_CS) <> "" Then
                        Return 3
                    Else
                        Return 2
                    End If
                Catch ex As Exception
                    Return 2
                End Try
            End If
        End If
    End Function
End Class
