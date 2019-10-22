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
        ob_getRandomQue(index).load()
        index += 1
        If index >= ob_getRandomMax() Then
            btn_Next.Text = "Finish"
            Return 1
        Else
            btn_Next.Text = "Check!"
            Return 0
        End If
    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim getCommandLine() As String
        Dim checksum As String = ""
        Dim MAX_RANDOM As Integer = 0
        Dim check_random As String = ""
        Dim getReal As Integer
        '파라미터 값으로 데이터를 가져옴 (확장성 추가)
        getCommandLine = Environment.GetCommandLineArgs()
        If (getCommandLine.Length > 2) Then
            checksum = getCommandLine(1)
            Local_Folder = getCommandLine(2)
            '데이터 파일 구분 방식이 입력이 되어 있으면 입력
            If (getCommandLine.Length > 3) Then
                check_random = getCommandLine(3)
            End If

            '최대 랜덤 문제 항수가 있는 경우 입력
            If (getCommandLine.Length > 4) Then
                MAX_RANDOM = CInt(getCommandLine(4))
            End If
        End If
        '외부에서 값을 받지 못한 경우 오류 발생 후 프로그램 종료
        If Local_Folder = "" Or (Not checksum = "gnyontu39") Then
            'Local_Folder = "CCNA_2017_10_102"
            MsgBox("잘못된 접근입니다! 프로그램을 재설치를 하거나, 정상적인 방법으로 접근하시길 바랍니다.", vbOKOnly, "잘못된 접근")
            Me.Close()
            Exit Sub
        End If
        '나 자신을 등록한다.
        frm = Me
        index = 0
        '접근한 폴더에 정보가 없을 경우 프로그램을 종료한다.
        If (Not MAX_RANDOM = 0) Then
            getReal = ob_LoadData(Local_Folder, check_random, MAX_RANDOM)
        ElseIf (Not check_random = "") Then
            getReal = ob_LoadData(Local_Folder, check_random)
        Else
            getReal = ob_LoadData(Local_Folder)
        End If
        If getReal = 0 Then
            Me.Close()
            Exit Sub
        End If
        '랜덤한 문제를 추출한다.
        ob_setRandomQue()
        '랜덤 문제을 불러온다.
        Load_Next()
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        '버튼을 누르면 check!일때, finish일때, next 일때, restart 등 버튼의 이름을 가지고 기능을 분류하여 실행한다.
        If (btn_Next.Text = "Check!" Or btn_Next.Text = "Finish") Then
            '정답 확인이나 시험이 완료가 되었을 경우
            Dim tmp_q As que = ob_getRandomQue(index - 1)
            Dim qu As String = getResult()
            '정답 확인시, 입력한 답이 없을 때 메시지를 출력하고 함수를 종료한다.
            If qu = "" Then
                MsgBox("선택한 답이 없습니다.", vbOKOnly, "뭐하는 겨!")
                Exit Sub
            End If
            '정답이 입력이 되어 있으면 값을 저장한다.
            tmp_q.setResult(qu)
            '정답 여부를 확인하여 문제의 마지막에 입력한다.
            If (tmp_q.getOK = 1) Then
                lb_Question.Text += " [맞았습니다]"
            Else
                lb_Question.Text += " [틀렸습니다! 답 : " & tmp_q.getCurrent & "]"
            End If
            '만약 문항이 종료 되었다면 문제를 푼 총 수와 맞은 개수를 메시지로 표시한다.
            If (btn_Next.Text = "Finish") Then
                MsgBox("모든 시험이 종료 되었습니다. ! 고생했습니다.", vbOKOnly, "Finish!")
                MsgBox("총 " & ob_getRandomMax() & "개 문제 중에 " & ob_getCurrentResult() & "개 맞았습니다.")
                btn_Next.Text = "Restart"
            Else
                btn_Next.Text = "NEXT >"
            End If
        ElseIf (btn_Next.Text = "NEXT >") Then
            '넥스트로 되어 있을 경우 다음 문항으로 넘어간다.
            Load_Next()
        ElseIf (btn_Next.Text = "Restart") Then
            '다시시작일 경우 시스템을 다시 시작한다.
            Application.Restart()
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

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        System.Diagnostics.Process.Start("http://sotaneum.tistory.com")
    End Sub
End Class