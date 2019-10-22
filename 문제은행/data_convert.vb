Module data_convert
    Private list As ArrayList
    Function dc_init()
        list = New ArrayList
        list.Clear()
        list.Add("A")
        list.Add("B")
        list.Add("C")
        list.Add("D")
        list.Add("E")
        list.Add("F")
        list.Add("G")
        list.Add("H")
        list.Add("I")
        list.Add("J")
        list.Add("K")
        list.Add("L")
        list.Add("N")
        list.Add("M")
        list.Add("O")
        list.Add("P")
        list.Add("Q")
        list.Add("R")
        list.Add("S")
        list.Add("T")
        list.Add("U")
        list.Add("V")
        list.Add("W")
        list.Add("X")
        list.Add("Y")
        list.Add("Z")
        Return 0
    End Function
    '스트링을 숫자로 변경
    Function dc_CINT(num As String) As Integer
        Dim i As Integer
        For i = 0 To list.Count - 1
            If list(i) = num Then
                Return i
            End If
        Next
        Return -1
    End Function
    '숫자를 스트링으로 변경
    Function dc_CStr(num As Integer) As String
        If (num - 1 >= list.Count) Then
            Return ""
        End If
        Return list(num)
    End Function

    '숫자인지, 텍스트인지 판별 1:String 2:int
    Function dc_Check(data As String)
        Dim i As Integer
        For i = 0 To list.Count - 1
            If list(i) = Left(data, 1) Then
                Return 1
            End If
        Next
        Return 0
    End Function

    '숫자든 텍스트든 다음 큰숫자로 반환
    Function dc_NumPlus(data As String) As String
        Dim num As Integer
        Dim check As Boolean = False
        If dc_Check(data) = 1 Then
            num = dc_CINT(data)
            check = False
        Else
            num = CInt(data)
            check = True
        End If
        num += 1
        If (check = True) Then
            Return CStr(num)
        Else
            Return dc_CStr(num)
        End If
    End Function

End Module
