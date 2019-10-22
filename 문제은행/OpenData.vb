Imports System.IO

Module OpenData
    Private Big_Data As ArrayList = New ArrayList()
    Private Random_Data As ArrayList
    Private MAX_RANDOM_DATA As Integer
    '데이터를 파일로부터 읽어서 저장한다.
    Function ob_LoadData(file_name As String, Optional check As String = "^", Optional MAX_RANDOM As Integer = 10)
        Dim path As String = Application.StartupPath & "\" & file_name & "\DATA.dat"
        '파일 존재 여부를 확인한다.
        If Not File.Exists(path) Then
            '존재하지 않으면 시스템이 정상적으로 가동이 어렵다.
            MsgBox("잘못된 설정입니다.", vbOK, "불러오기 실패")
            Return 0
            Exit Function
        Else
            '파일이 존재한다면 열기한다.
            Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(path)
            Dim temp As String
            Dim data() As String
            '파일을 줄단위로 불러온다.
            Do
                temp = reader.ReadLine
                '불러온게 아무런 정보가 없다면 종료한다.
                If Not temp Is Nothing Then
                    Dim i As Integer
                    '데이터를 check변수에 입력된대로 나누어 저장한다.
                    data = temp.Split(check)
                    '다중 문항에 대한 설정
                    For i = 0 To data.Count - 1
                        data(i) = data(i).Replace("\n", vbCrLf)
                    Next
                    '그 데이터를 가지고 전체 문항에 저장한다.
                    Big_Data.Add(New que(data(0), data(1), data(2), data(3), data(4), data(5), data(6), data(7), data(8), data(9)))
                End If
            Loop Until temp Is Nothing
            '최대 랜덤 문제를 정한다.
            MAX_RANDOM_DATA = MAX_RANDOM
        End If
        Return 1
    End Function
    '랜덤하게 데이터를 뽑아낸다.
    Function ob_setRandomQue()
        Dim n As Integer
        Dim i As Integer
        Dim max_size As Integer
        '문제가 최대로 출력할 수 있는 크기를 반환한다.
        If (MAX_RANDOM_DATA > Big_Data.Count) Then
            max_size = Big_Data.Count
        Else
            max_size = MAX_RANDOM_DATA
        End If
        '랜덤하게 담을 리스트를 선언한다.
        Random_Data = New ArrayList()
        '비교적 랜덤하게 하기위해 실제 시간에서 x을 나눈 나머지 값을 구한다.

        Do While (Random_Data.Count < max_size)
            Randomize()

            '특정 공식을 통해 띄어넘기를 한다.
            n = ((Int(Rnd() * 10) + 1) Mod (Big_Data.Count))
            For i = 0 To Random_Data.Count - 1
                If Random_Data(i).getNum() = Big_Data(n).getNum() Then
                    n = ((Int(Rnd() * 1000) + 1) Mod (Big_Data.Count))
                    i = -1
                End If
            Next
            Random_Data.Add(Big_Data(n))
        Loop
        Return 0
    End Function
    '랜덤리스트에서 해당 데이터를 반환한다.
    Function ob_getRandomQue(i As Integer) As que
        If i < Random_Data.Count Then
            Return Random_Data(i)
        Else
            Return Nothing
        End If
    End Function
    '현재 랜덤 데이터 총 개수를 반환한다.
    Function ob_getRandomMax()
        Return Random_Data.Count
    End Function
    '총 맞은 개수를 반환한다.
    Function ob_getCurrentResult(Optional size As Integer = 0)
        Dim i As Integer
        Dim count As Integer = 0
        If size = 0 Or size > Random_Data.Count Then
            size = Random_Data.Count
        End If
        For i = 0 To size - 1
            count += ob_getRandomQue(i).getOK()
        Next
        Return count
    End Function
End Module
