'Copyright (C) 2012 christopherx

'Permission is hereby granted, free of charge, to any person obtaining a copy 
'of this software and associated documentation files (the "Software"), to deal 
'in the Software without restriction, including without limitation the rights 
'to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
'of the Software, and to permit persons to whom the Software is furnished to do 
'so, subject to the following conditions:

'The above copyright notice and this permission notice shall be included in all
'copies or substantial portions of the Software.

'THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
'INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
'PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
'HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION 
'OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
'SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading

Public Class Form1
    'todo
    'squelch for NFM
    'scanner

    Const WM_SETTEXT As Int32 = 12
    Const WM_KEYDOWN As Int32 = 256
    Const WM_KEYUP As Int32 = 257

    Public childcount As Int32
    Public cfhwnd As Int32
    Public fhwnd As Int32
    Public nfmhwnd As Int32
    Public amhwnd As Int32
    Public wfmhwnd As Int32
    Public lsbhwnd As Int32
    Public usbhwnd As Int32
    Public dsbhwnd As Int32
    Public cwlhwnd As Int32
    Public cwuhwnd As Int32

    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Int32, _
                                                                            ByVal wMsg As Int32, _
                                                                            ByVal wParam As Int32, _
                                                                            ByVal lParam As String) As Int32

    Private Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hWnd As Int32, _
                                                                            ByVal wMsg As Int32, _
                                                                            ByVal wParam As Int32, _
                                                                            ByVal lParam As String) As Int32

    Private Delegate Function EnumChildProc(ByVal hwnd As IntPtr, ByVal lParam As IntPtr) As Boolean

    <DllImport("user32")> _
    Private Shared Function EnumChildWindows(ByVal hWndParent As IntPtr, _
                                         ByVal lpEnumProc As EnumChildProc, _
                                         ByVal lParam As IntPtr) As Boolean
    End Function


    Private Sub EnumChildWindows(ByVal parentWindow As IntPtr)

        EnumChildWindows(parentWindow, AddressOf ProcessChildWindow, IntPtr.Zero)

    End Sub


    Private Function ProcessChildWindow(ByVal hwnd As IntPtr, ByVal lParam As IntPtr) As Boolean

        childcount = childcount + 1

        'DEBUG find childcount for particular hwnd
        'If hwnd = 1511440 Then
        '    MsgBox(childcount)
        'End If

        Select Case childcount
            Case 12
                nfmhwnd = hwnd
            Case 20
                amhwnd = hwnd
            Case 17
                wfmhwnd = hwnd
            Case 22
                lsbhwnd = hwnd
            Case 24
                usbhwnd = hwnd
            Case 13
                dsbhwnd = hwnd
            Case 11
                cwlhwnd = hwnd
            Case 10
                cwuhwnd = hwnd
            Case 16
                fhwnd = hwnd
            Case 45
                cfhwnd = hwnd
        End Select

        Return True

    End Function


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'load settings
        Dim strTmp As String
        strTmp = My.Settings.strUsr

        If strTmp <> Nothing Then
            Dim strArray() As String
            strArray = Split(strTmp, ";")
            Dim i As Integer
            For i = 0 To UBound(strArray) - 1
                lstUser.Items.Add(strArray(i))
            Next
        End If

        'get sdrsharp hwnd
        Dim hwnd As Int32
        Dim pIndex As Int32 = 0
        For Each p As System.Diagnostics.Process In System.Diagnostics.Process.GetProcessesByName("SDRSharp")
            pIndex += 1
            If pIndex = 1 Then hwnd = p.MainWindowHandle.ToInt32
        Next

        If hwnd = Nothing Then
            MsgBox("Please launch and 'Play' SDRSharp prior to launching SDRSharp Frequency Manager")
            Exit Sub
        End If

        'get child hwnds
        childcount = 0
        EnumChildWindows(hwnd)

        'add bands center freq
        'should probably refactor, this is lazy
        lstBand.Items.Add("126,000,000")
        '2m
        lstBand.Items.Add("145,000,000")
        lstBand.Items.Add("147,000,000")
        '1.25m
        lstBand.Items.Add("221,000,000")
        lstBand.Items.Add("223,000,000")
        lstBand.Items.Add("225,000,000")
        '70cm
        lstBand.Items.Add("421,000,000")
        lstBand.Items.Add("423,000,000")
        lstBand.Items.Add("425,000,000")
        lstBand.Items.Add("427,000,000")
        lstBand.Items.Add("429,000,000")
        lstBand.Items.Add("431,000,000")
        lstBand.Items.Add("433,000,000")
        lstBand.Items.Add("435,000,000")
        lstBand.Items.Add("437,000,000")
        lstBand.Items.Add("439,000,000")
        lstBand.Items.Add("441,000,000")
        lstBand.Items.Add("443,000,000")
        lstBand.Items.Add("445,000,000")
        lstBand.Items.Add("447,000,000")
        lstBand.Items.Add("449,000,000")
        '33cm
        lstBand.Items.Add("903,000,000")
        lstBand.Items.Add("905,000,000")
        lstBand.Items.Add("907,000,000")
        lstBand.Items.Add("909,000,000")
        lstBand.Items.Add("911,000,000")
        lstBand.Items.Add("913,000,000")
        lstBand.Items.Add("915,000,000")
        lstBand.Items.Add("917,000,000")
        lstBand.Items.Add("919,000,000")
        lstBand.Items.Add("921,000,000")
        lstBand.Items.Add("923,000,000")
        lstBand.Items.Add("925,000,000")
        lstBand.Items.Add("927,000,000")

    End Sub


    Private Sub lstBand_DoubleClick(sender As Object, e As System.EventArgs) Handles lstBand.DoubleClick

        Dim cf As String = lstBand.Items(lstBand.SelectedIndex)

        SendMessage(cfhwnd, WM_SETTEXT, 0, cf)
        PostMessage(cfhwnd, WM_KEYDOWN, Keys.Enter, Nothing)
        PostMessage(cfhwnd, WM_KEYUP, Keys.Enter, Nothing)

        Thread.Sleep(100)

        'lazy
        PostMessage(nfmhwnd, WM_KEYDOWN, Keys.Space, Nothing)
        PostMessage(nfmhwnd, WM_KEYUP, Keys.Space, Nothing)

    End Sub


    Private Sub lstUser_DoubleClick(sender As Object, e As System.EventArgs) Handles lstUser.DoubleClick

        Dim f As String = Split(lstUser.Items(lstUser.SelectedIndex), " -- ")(1)
        Dim cf As String = f - 20000

        Dim md As String = Split(lstUser.Items(lstUser.SelectedIndex), " -- ")(2)

        Dim mdhwnd As Int32

        Select Case md
            Case "NFM"
                mdhwnd = nfmhwnd
            Case "AM"
                mdhwnd = amhwnd
            Case "WFM"
                mdhwnd = wfmhwnd
            Case "LSB"
                mdhwnd = lsbhwnd
            Case "USB"
                mdhwnd = usbhwnd
            Case "DSB"
                mdhwnd = dsbhwnd
            Case "CWL"
                mdhwnd = cwlhwnd
            Case "CWU"
                mdhwnd = cwuhwnd
        End Select

        'center freq
        SendMessage(cfhwnd, WM_SETTEXT, 0, cf)
        PostMessage(cfhwnd, WM_KEYDOWN, Keys.Enter, Nothing)
        PostMessage(cfhwnd, WM_KEYUP, Keys.Enter, Nothing)

        Thread.Sleep(100)

        'freq
        SendMessage(fhwnd, WM_SETTEXT, 0, f)
        PostMessage(fhwnd, WM_KEYDOWN, Keys.Enter, Nothing)
        PostMessage(fhwnd, WM_KEYUP, Keys.Enter, Nothing)

        Thread.Sleep(100)

        'mode
        PostMessage(mdhwnd, WM_KEYDOWN, Keys.Space, Nothing)
        PostMessage(mdhwnd, WM_KEYUP, Keys.Space, Nothing)

    End Sub


    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        If MessageBox.Show("Are you sure you want to save?", "Save", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim i As Integer
            Dim strTmp As String
            strTmp = ""

            For i = 0 To (lstUser.Items.Count - 1)
                strTmp = strTmp & lstUser.Items(i).ToString & ";"
            Next

            My.Settings.strUsr = strTmp
            My.Settings.Save()
            MsgBox("Settings saved.")
        Else
            MsgBox("Save aborted.")
        End If

    End Sub


    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        If txtName.Text = "" Or txtFreq.Text = "" Then
            MsgBox("Please enter both a Label and Frequency before adding to User List.")
            Exit Sub
        End If

        Dim md As String
        md = "NFM"
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is RadioButton Then
                If CType(ctl, RadioButton).Checked = True Then
                    md = Split(ctl.Name, "rdo")(1)
                    Exit For
                End If
            End If
        Next

        lstUser.Items.Add(txtName.Text & " -- " & txtFreq.Text & " -- " & md)

    End Sub


    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

        lstUser.Items.RemoveAt(lstUser.SelectedIndex)

    End Sub


    Private Sub txtFreq_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFreq.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnAdd_Click(sender, e)
        End If

    End Sub


    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

        lstUser.Height = Me.Height - 75
        lstBand.Height = Me.Height - 75

    End Sub


End Class
