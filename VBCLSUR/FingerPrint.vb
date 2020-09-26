Imports System
Imports System.Globalization
Imports System.Threading
Imports System.Resources
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Reflection
Imports System.Text

Public Class FingerPrint

    Public Shared Function Value() As String
        Dim prj As New Common.ProjectDetail
        'June 14 ,2011 -faheem khan
        'task --> Add year in registration key.
        'start
        'we have added year in front of diskid ..
        'this will always create the new key for each year
        'we have not added any other thing so old structure will remain same.

        Return pack(prj.Year + diskId())   'pack(cpuId() + biosId() + diskId() + baseId() + videoId() + macId())
        'end of June 14 ,2011 - faheem
    End Function

    Private Shared Function identifier(ByVal wmiClass As String, ByVal wmiProperty As String, ByVal wmiMustBeTrue As String) As String
        Dim result As String = ""
        Dim mc As System.Management.ManagementClass = New System.Management.ManagementClass(wmiClass)
        Dim moc As System.Management.ManagementObjectCollection = mc.GetInstances()
        Dim mo As System.Management.ManagementObject
        For Each mo In moc
            If mo(wmiMustBeTrue).ToString() = "True" Then
                If result = "" Then
                    Try
                        result = mo(wmiProperty).ToString()
                        Exit For
                    Catch
                    End Try
                End If
            End If
        Next
        Return result
    End Function

    Private Shared Function identifier(ByVal wmiClass As String, ByVal wmiProperty As String) As String
        Dim result As String = ""
        Dim mc As System.Management.ManagementClass = New System.Management.ManagementClass(wmiClass)
        Dim moc As System.Management.ManagementObjectCollection = mc.GetInstances()
        For Each mo As System.Management.ManagementObject In moc
            If (result = "") Then
                Try
                    result = mo(wmiProperty).ToString()
                Catch
                End Try
            End If
        Next
        Return result
    End Function

    Private Shared Function cpuId() As String
        'Uses first CPU identifier available in order of preference
        'Don't get all identifiers, as very time consuming
        Dim retVal As String = identifier("Win32_Processor", "UniqueId")
        If retVal = "" Then
            retVal = identifier("Win32_Processor", "ProcessorId")
            If retVal = "" Then
                retVal = identifier("Win32_Processor", "Name")
                If retVal = "" Then
                    retVal = identifier("Win32_Processor", "Manufacturer")
                End If
                'Add clock speed for extra security
                retVal += identifier("Win32_Processor", "MaxClockSpeed")
            End If
        End If
        Return retVal
    End Function

    Private Shared Function biosId() As String
        Return identifier("Win32_BIOS", "Manufacturer") + identifier("Win32_BIOS", "SMBIOSBIOSVersion") + identifier("Win32_BIOS", "IdentificationCode") + identifier("Win32_BIOS", "SerialNumber") + identifier("Win32_BIOS", "ReleaseDate") + identifier("Win32_BIOS", "Version")
    End Function

    Private Shared Function diskId() As String
        Return identifier("Win32_DiskDrive", "Model") + identifier("Win32_DiskDrive", "Manufacturer") + identifier("Win32_DiskDrive", "Signature") + identifier("Win32_DiskDrive", "TotalHeads")
    End Function

    Private Shared Function baseId() As String
        Return identifier("Win32_BaseBoard", "Model") + identifier("Win32_BaseBoard", "Manufacturer") + identifier("Win32_BaseBoard", "Name") + identifier("Win32_BaseBoard", "SerialNumber")
    End Function

    Private Shared Function videoId() As String
        Return identifier("Win32_VideoBLL", "DriverVersion") + identifier("Win32_VideoController", "Name")
    End Function


    Private Shared Function macId() As String
        Return identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled")
    End Function


    Private Shared Function pack(ByVal text As String) As String
        Dim retVal As String
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim n As Char
        For Each n In text
            y += 1
            x += (AscW(n) * y)
        Next
        retVal = x.ToString() + "00000000"
        Return retVal.Substring(0, 8)
    End Function
End Class
