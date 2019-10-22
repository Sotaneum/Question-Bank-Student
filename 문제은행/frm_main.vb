Public Class frm_main
    'btn_Next Option
    Private func_NEXT As String = "NEXT >"
    Private func_Restart As String = "Restart"
    Private func_Check As String = "Check"
    Private func_Final As String = "Final"

    'System Setting
    Private sys_BookPath As String = "" '문제집의 폴더명
    Private sys_BookChecker As String = "" '문제집의 구분
    Private sys_BookCountMax As Integer = 20 '문제 문항 개수
    Private sys_Test As Boolean = False '시스템 구동이 테스트 모드인가?
    Private sys_Test_Folder As String = "CCNA_01_140"  '테스트 모드로 구동시 실행되는 폴더
    Private sys_Test_list As String = "57,198,368,427,15,89,156,168,189,200,273,353,356,372,388,6,20,77,133,204,221,231,264,333,363,369,371,402,414,418" '테스트 모드로 구동시 실행되는 리스트
    Private sys_shutdown = False '시스템을 그냥 끄는 경우 True
    Private sys_time As Integer = 0 '시간을 저장한다.
    Private sys_title As String = "문제은행 Beta ! Play Time : "
    Private sys_list As String = ""

    'Book System
    Private bk_index As Integer = 0
    Private bk_item As ArrayList

    Function getBookPath() As String
        Return sys_BookPath
    End Function

    Function getBookChecker() As String
        Return sys_BookChecker
    End Function

    '화면에 문제를 표시하는 함수
    Function print_question(num As String, title As String, item As ArrayList, Optional image As Image = Nothing)
        Dim size As Integer = item.Count + 2 '항목 개수 + 제목 + 번호
        Dim i As Integer
        Dim tbl_question As TableLayoutPanel = New TableLayoutPanel
        Dim lb_title As Label = New Label
        Dim lb_num As Label = New Label
        Dim img_post As PictureBox = New PictureBox
        Dim cb_item As CheckBox = New CheckBox
        '이미지가 있을 경우 사이즈 증가
        If Not image Is Nothing Then
            size += 1
        End If
        '이미 컨트롤이 있을 경우 지워버린다.
        If tbl_main.Controls.Count > 1 Then
            tbl_main.Controls.RemoveAt(1)
        End If
        '그리곤 나를 등록한다/
        tbl_main.Controls.Add(tbl_question)
        'question 테이블 레이아웃 기본 설정
        With tbl_question
            .Name = "tbl_question"
            .RowCount = size + 1
            .Dock = DockStyle.Fill
            For i = 1 To .RowCount
                .RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Next
        End With

        '문항 번호 설정
        With lb_num
            .Name = "lb_num"
            .Dock = DockStyle.Fill
            .Text = bk_index + 1
            If Not num = "" Then
                .Text += " ( No. " & num & " )"
            End If
            .Font = New Font("맑은 고딕", 12, Font.Style.Bold)
            If num = "" Then
                .Text += " (No. " & num & ")"
            End If
        End With

        tbl_question.Controls.Add(lb_num)

        '제목을 단어를 나눈다.
        Dim test_title() As String = title.Split(" ")
        title = test_title(0) + " "
        For i = 1 To test_title.Length - 1
            title += test_title(i) & " "
            If i Mod 13 = 0 Then
                title += vbCrLf
            End If
        Next

        '문제 설정
        With lb_title
            .Name = "lb_title"
            .AutoSize = True
            .Text = title
            .Font = New Font("맑은 고딕", 12)
        End With
        tbl_question.Controls.Add(lb_title)

        '이미지 설정
        If Not image Is Nothing Then
            With img_post
                .Name = "img_post"
                .Dock = DockStyle.Fill
                .Image = image
                .SizeMode = PictureBoxSizeMode.AutoSize
            End With
            tbl_question.Controls.Add(img_post)
        End If
        bk_item = New ArrayList
        '항목 부분 설계
        For i = 0 To item.Count - 1
            cb_item = New CheckBox
            With cb_item
                .Name = "cb_item" & i
                .Text = item(i)
                .Font = New Font("맑은 고딕", 9)
                .AutoSize = True
            End With
            bk_item.Add(cb_item)
            tbl_question.Controls.Add(cb_item)
        Next

        Me.Refresh()
        Return 0
    End Function

    Function getBk_item(idx As Integer) As CheckBox
        Return bk_item(idx)
    End Function

    Function getResultByUser() As String
        Dim i As Integer
        Dim result As String = ""
        For i = 0 To bk_item.Count - 1
            If getBk_item(i).Checked = True Then
                result += dc_CStr(i)
            End If
        Next
        Return result
    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command() As String
        command = Environment.GetCommandLineArgs
        If command.Count > 1 And sys_Test = False Then
            If Not command(1) = "gnyontu39" Then
                sys_shutdown = True
                Me.Close()
                Exit Sub
            End If
            If command.Count >= 2 Then
                sys_BookPath = command(2)
                If command.Count >= 3 Then
                    sys_BookChecker = command(3)
                    If command.Count >= 4 Then
                        sys_BookCountMax = CInt(command(4))
                        If command.Count >= 5 Then
                            sys_list = command(5)
                        End If
                    Else
                        sys_BookCountMax = 10
                    End If
                Else
                    sys_BookCountMax = 10
                    sys_BookChecker = "^"
                End If
            End If
        ElseIf sys_Test = True Then
            sys_BookPath = sys_Test_Folder
            sys_BookChecker = "^"
            sys_list = sys_Test_list
            sys_BookCountMax = 20
        Else
            sys_shutdown = True
            Me.Close()
            Exit Sub
        End If

        If ob_LoadData(sys_BookPath, sys_BookChecker, sys_BookCountMax, sys_list) = 0 Then
            sys_shutdown = True
            Me.Close()
            Exit Sub
        End If
        dc_init()
        ob_setRandomQue()
        ob_getRandomQue(bk_index).load(Me)
        btn_Next.Text = func_Check
        btn_info.Text = "총 " & ob_getRandomMax() & "개의 문제 중에 " & (bk_index + 1) & "번째 도전 중입니다."
    End Sub

    Private Sub frm_main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If sys_shutdown = False Then
            MsgBox("중도에 포기했지만 괜찮아요!", vbOKOnly, "괜찮아요!")
            If btn_Next.Text = func_NEXT Then
                MsgBox("총 " & bk_index + 1 & "개의 문제중에 " & ob_getCurrentResult(bk_index) & "개 맞았습니다!", vbOKOnly, "와우! 고생했어요!")
            Else
                MsgBox("총 " & bk_index & "개의 문제중에 " & ob_getCurrentResult(bk_index) & "개 맞았습니다!", vbOKOnly, "와우! 고생했어요!")
            End If
        End If
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        If btn_Next.Text = func_NEXT Then
            bk_index += 1
            ob_getRandomQue(bk_index).load(Me)
            btn_Next.Text = func_Check
            btn_info.Text = "총 " & ob_getRandomMax() & "개의 문제 중에 " & (bk_index + 1) & "번째 도전 중입니다."
        ElseIf btn_Next.Text = func_Check Then
            Dim data_que As que = ob_getRandomQue(bk_index)
            Dim lb_result As Label = New Label
            data_que.setResult(getResultByUser())
            With lb_result
                .Name = "lb_result"
                .Dock = DockStyle.Fill
                If data_que.getAnswer = 1 Then
                    .Text = "[  정답입니다.!  ]"
                Else
                    .Text = "[  오답입니다. 정답은 : " & data_que.getCurrent & " 입니다.  ]"
                End If
                .TextAlign = ContentAlignment.MiddleCenter
            End With
            tbl_main.Controls(1).Controls.Add(lb_result)
            Dim tempas As Integer = ob_getRandomMax()
            If tempas <= bk_index + 1 Then
                btn_Next.Text = func_Final
            Else
                btn_Next.Text = func_NEXT
            End If
        ElseIf btn_Next.Text = func_Final Then
            MsgBox("문제를 모두 풀었습니다! 고생하셨습니다!", vbOKOnly, "와우! 대단해요!")
            MsgBox("총 " & ob_getRandomMax() & "개의 문제중에 " & ob_getCurrentResult() & "개 맞았습니다!", vbOKOnly, "와우! 대단해요!")
            btn_Next.Text = func_Restart
        ElseIf btn_Next.Text = func_Restart Then
            sys_shutdown = True
            Application.Restart()
        End If
    End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
        System.Diagnostics.Process.Start("http://sotaneum.tistory.com")
    End Sub

    Private Sub btn_copyright_Click(sender As Object, e As EventArgs) Handles btn_copyright.Click
        System.Diagnostics.Process.Start("http://duration.digimoon.net")
    End Sub

    Private Sub tm_now_Tick(sender As Object, e As EventArgs) Handles tm_now.Tick
        Dim hour As Integer
        Dim min As Integer
        Dim sec As Integer
        sys_time += 1
        hour = (sys_time / (60 * 60)) Mod 60
        min = (sys_time / 60) Mod 60
        sec = sys_time Mod 60
        Me.Text = sys_title & hour & "시간 " & min & "분 " & sec & "초"
    End Sub
End Class