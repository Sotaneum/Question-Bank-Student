Public Class que
    'Question 구성
    Private index As String    '식별
    Private title As String     '문제 제목
    Private item As ArrayList   '문제 항목
    Private url As String       '이미지 경로
    Private current As String   '정답
    Private result As String = ""    '사용자 선택 답

    'Qusetion 옵션
    Private showIndex As Boolean = True '문항번호 외에 인덱스도 추가로 표시합니다.

    '클래스를 생성하기 위해서는 여러가지 기입정보가 필요합니다.
    Public Sub New(g_index As String, g_title As String, g_item As ArrayList, g_current As String, Optional g_url As String = "")
        index = g_index
        title = g_title
        item = g_item
        url = g_url
        current = g_current
    End Sub

    '정답인지 아닌지 반환 1:정답, 0:오답
    Function getAnswer() As Integer
        If current = result Then
            Return 1
        End If
        Return 0
    End Function

    '이미지를 반환
    Function getimage(path As String) As Image
        If url = "" Then
            Return Nothing
        End If
        Return Image.FromFile(path & "\" & url, True)
    End Function

    '정답을 반환
    Function getCurrent() As String
        Return current
    End Function

    '사용자 선택 답을 입력합니다.
    Function setResult(data As String)
        result = data
        Return 0
    End Function

    Function getNum()
        Return index
    End Function

    '화면에 표시할 수 있도록 데이터를 불러옵니다. 
    Function load(fm As frm_main)
        Dim index_data As String = ""
        If showIndex = True Then
            index_data = index
        End If
        fm.print_question(index_data, title, item, getimage(Application.StartupPath & "\" & fm.getBookPath))
        Return 0
    End Function

End Class
