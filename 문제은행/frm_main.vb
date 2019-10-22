Public Class frm_main
    Public frm As frm_main
    Private index As Integer
    Private Local_Folder As String
    '질문 데이터를 받아 화면에 표시
    Function setData(question As String, a As String, Optional b As String = "", Optional c As String = "", Optional d As String = "", Optional e As String = "", Optional f As String = "")
        Dim count As Integer = 0
        lb_Question.Text = question
        lb_Num.Text = index + 1 & ""

        'A
        cb_A.Checked = False
        If a = "" Or a = "0" Then
            cb_A.Enabled = False
            cb_A.Text = ""
        Else
            cb_A.Enabled = True
            cb_A.Text = a
            count += 1
        End If
        'B
        cb_B.Checked = False
        If b = "" Or b = "0" Then
            cb_B.Enabled = False
            cb_B.Text = ""
        Else
            cb_B.Enabled = True
            cb_B.Text = b
            count += 1
        End If
        'C
        cb_C.Checked = False
        If c = "" Or c = "0" Then
            cb_C.Enabled = False
            cb_C.Text = ""
        Else
            cb_C.Enabled = True
            cb_C.Text = c
            count += 1
        End If
        'D
        cb_D.Checked = False
        If d = "" Or d = "0" Then
            cb_D.Enabled = False
            cb_D.Text = ""
        Else
            cb_D.Enabled = True
            cb_D.Text = d
            count += 1
        End If
        'E
        cb_E.Checked = False
        If e = "" Or e = "0" Then
            cb_E.Enabled = False
            cb_E.Text = ""
        Else
            cb_E.Enabled = True
            cb_E.Text = e
            count += 1
        End If
        'F
        cb_F.Checked = False
        If f = "" Or f = "0" Then
            cb_F.Enabled = False
            cb_F.Text = ""
        Else
            cb_F.Enabled = True
            cb_F.Text = f
            count += 1
        End If
        Return count
    End Function

    '체크되어 있는거 스트링으로 반환
    Function getResult()
        Dim data As String = ""
        If (cb_A.Enabled = True And cb_A.Checked = True) Then
            data += "A"
        End If
        If (cb_B.Enabled = True And cb_B.Checked = True) Then
            data += "B"
        End If
        If (cb_C.Enabled = True And cb_C.Checked = True) Then
            data += "C"
        End If
        If (cb_D.Enabled = True And cb_D.Checked = True) Then
            data += "D"
        End If
        If (cb_E.Enabled = True And cb_E.Checked = True) Then
            data += "E"
        End If
        If (cb_F.Enabled = True And cb_F.Checked = True) Then
            data += "F"
        End If
        Return data
    End Function

    '다음 페이지 로드
    Function Load_Next()
        Dim tmp As que
        '마지막 문제일 경우 버튼이 바뀐다.
        If (ob_getRandomMax() <= index + 1) Then
            btn_Next.Text = "Result"
        Else
            btn_Next.Text = "NEXT >"
        End If
        'INDEX의 값으로 QUE 클래스를 가져온다.
        tmp = ob_getRandomQue(index)
        '비어 있을 경우 왕 끝이다!
        If Not tmp Is Nothing Then
            tmp.load()
            index += 1
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm = Me
        index = 0
        Local_Folder = "Exam"
        ob_LoadData(Local_Folder)
        ob_setRandomQue()
        Load_Next()
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        Dim temp_result As String = getResult()
        ob_getRandomQue(index - 1).setResult(temp_result)
        If (Load_Next() = 0) Then
            Dim i As Integer
            Dim count As Integer = 0
            MsgBox("문제를 모두 풀었습니다!")
            For i = 0 To ob_getRandomMax() - 1
                If ob_getRandomQue(i).getOK() = 1 Then
                    count += 1
                End If
            Next
            MsgBox("총 " & ob_getRandomMax() & "개의 문제에서" & count & "개 맞았습니다.", vbOKOnly, "결과")
            Me.Close()
        End If
    End Sub

    Private Sub lb_Question_Click(sender As Object, e As EventArgs) Handles lb_Question.Click
        Dim path As String = Application.StartupPath & "\" & Local_Folder & "\"
        Dim temp_path As String = ob_getRandomQue(index - 1).getPictureUrl
        If (Not temp_path = "") Then
            frm_Image.Show()
            frm_Image.pb_image.Image = Image.FromFile(path & temp_path)
            frm_Image.Refresh()
        End If
    End Sub
End Class