Class mdlGenerator

    Public Const VALID_CHARACTERS = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ"
    Public Const DEFAULT_FORMAT = "&&&&-&&&&-&&&&-&&&&"

    Public Function GetSerialNo() As String
        GetSerialNo = RandomText(16)
    End Function

    Public Function GetActivationCode(ByVal serialNo As String, ByVal enhCode As String) As String
        Dim activationKey As String

        Try
            serialNo = serialNo.Insert(1, Mid(enhCode, 1, 1))
            serialNo = serialNo.Insert(3, Mid(enhCode, 2, 1))
            serialNo = serialNo.Insert(5, Mid(enhCode, 3, 1))
        Catch ex As Exception
        End Try
        activationKey = CreateKey(serialNo, enhCode)
        Return addHyphen(activationKey)
    End Function

    Public Function GetReActivationCode(ByVal serialNo As String) As String
        Dim activationKey As String
        activationKey = CreateKey("Kashif Jilani", serialNo)
        Return addHyphen(activationKey)
    End Function

    Private Function RandomText(ByVal Length As Integer) As String
        Dim Text As String
        Dim r As Integer
        Dim i As Integer

        'Get a random seed - the timer is about as random as it gets 
        Randomize()
        For i = 1 To Length
            r = Int((9 * (Rnd()) + 1))
            Text = Text & CStr(r)
        Next
        RandomText = Text
    End Function

    Private Function CountAmpersands(ByVal Format As String) As Integer
        'Counts the number of characters that need to be returned

        Dim i As Integer
        Dim intCount As Integer

        intCount = 0
        For i = 1 To Len(Format)
            If Mid(Format, i, 1) = "&" Then
                intCount = intCount + 1
            End If
        Next i

        CountAmpersands = intCount
    End Function

    Private Function CreateKey(ByVal ApplicationKey As String, ByVal UserName As String, Optional ByVal sFormat As String = DEFAULT_FORMAT, Optional ByVal ValidCharacters As String = VALID_CHARACTERS) As String
        ' for use in sFormat; use '&' to represent alpha-numeric characters
        Dim intTemp As Integer
        Dim strTextChar As String
        Dim strKeyChar As String
        Dim intEncryptedChar As String
        Dim strKey As String
        Dim i As Integer
        Dim strUserName As String

        strUserName = LCase(Trim(UserName))

        If Len(strUserName) = 0 Then
            '          Err.Raise(vbError + 1001, , "Invalid Username")
            MsgBox("Invalid UserName")
            Exit Function
        End If

        'This is an altered simple encryption algorithm
        'Key Length is minimised to 8 instead of 16
        '8 is replaced with CountAmpersands(sFormat)ie 16
        For i = 1 To CountAmpersands(sFormat)
            strTextChar = Mid(strUserName, (i Mod Len(strUserName)) + 1, 1)
            strKeyChar = Mid(ApplicationKey, (i Mod Len(ApplicationKey)) + 1, 1)
            intTemp = (((Asc(strKeyChar) * i) * Len(ApplicationKey) + 1) Mod Len(ValidCharacters) + 1)
            strTextChar = Chr(Asc(strTextChar) Xor intTemp)
            intTemp = (((Asc(strKeyChar) * i) * Len(UserName) + 1) Mod Len(ValidCharacters) + 1)
            strTextChar = Chr(Asc(strTextChar) Xor intTemp)
            intEncryptedChar = ((Asc(strTextChar) Xor Asc(strKeyChar)) Mod Len(ValidCharacters)) + 1
            strKey = strKey & Mid(ValidCharacters, intEncryptedChar, 1)
        Next i

        CreateKey = Format(sFormat, strKey)
    End Function

    Private Function addHyphen(ByVal activationKey As String) As String

        Dim i As Integer
        Dim t As Integer
        For i = 0 To activationKey.Length - 1
            If (i Mod 4 = 0 And i <> 0) Then
                activationKey = activationKey.Insert(i + t, "-")
                t += 1
            End If
        Next
        Return activationKey
    End Function

    Public Function SimpleCrypt(ByVal Text As String) As String
        ' Encrypts/decrypts the passed string using 
        ' a simple ASCII value-swapping algorithm
        Dim strTempChar As String, i As Integer
        For i = 1 To Len(Text)
            If Asc(Mid$(Text, i, 1)) < 128 Then
                strTempChar = _
          CType(Asc(Mid$(Text, i, 1)) + 128, String)
            ElseIf Asc(Mid$(Text, i, 1)) > 128 Then
                strTempChar = _
          CType(Asc(Mid$(Text, i, 1)) - 128, String)
            End If
            Mid$(Text, i, 1) = _
                Chr(CType(strTempChar, Integer))
        Next i
        Return Text
    End Function

End Class
