Imports System.IO

Module OpenData
    Private Big_Data As ArrayList = New ArrayList()
    Private Random_Data As ArrayList
    Private MAX_RANDOM_DATA As Integer
    Function ob_LoadData(file_name As String, Optional check As String = "^", Optional MAX_RANDOM As Integer = 10)
        Dim path As String = Application.StartupPath & "\" & file_name & "\DATA.dat"
        If Not File.Exists(path) Then
            MsgBox("잘못된 설정입니다.", vbOK, "불러오기 실패")
            Return 0
            Exit Function
        Else
            Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(path)
            Dim temp As String
            Dim data() As String
            Do
                temp = reader.ReadLine
                If Not temp Is Nothing Then
                    data = temp.Split(check)
                    Big_Data.Add(New que(data(0), data(1), data(2), data(3), data(4), data(5), data(6), data(7), data(8), data(9)))
                End If
            Loop Until temp Is Nothing
            MAX_RANDOM_DATA = MAX_RANDOM
        End If
        Return 1
    End Function
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
            n = ((Int(Rnd() * 10) + 1) Mod max_size)
            For i = 0 To Random_Data.Count - 1
                If Random_Data(i).getNum() = Big_Data(n).getNum() Then
                    n = ((Int(Rnd() * 1000) + 1) Mod max_size)
                    i = -1
                End If
            Next
            Random_Data.Add(Big_Data(n))
        Loop
        Return 0
    End Function
    Function ob_getRandomQue(i As Integer) As que
        If i < Random_Data.Count Then
            Return Random_Data(i)
        Else
            Return Nothing
        End If
    End Function
    Function ob_getRandomMax()
        Return Random_Data.Count
    End Function
End Module
