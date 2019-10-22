Public Class que
    Private num As Integer
    Private question As String
    Private a As String
    Private b As String
    Private c As String
    Private d As String
    Private e As String
    Private f As String
    Private url As String
    Private current As String
    Private result As String = ""
    Public Sub New(g_num As String, g_que As String, g_current As String, Optional pic_url As String = "", Optional g_a As String = "", Optional g_b As String = "", Optional g_c As String = "", Optional g_d As String = "", Optional g_e As String = "", Optional g_f As String = "")
        num = g_num
        question = g_que
        current = g_current
        a = g_a
        b = g_b
        c = g_c
        d = g_d
        e = g_e
        f = g_f
        url = pic_url
    End Sub

    Public Sub load()
        Dim add As String = ""
        If (Not url = "") Then
            add = vbCrLf & "[이미지 보기(클릭)]"
        End If
        frm_main.frm.setData(question & add, a, b, c, d, e, f)
    End Sub
    Function getNum()
        Return num
    End Function
    Function getPictureUrl()
        Return url
    End Function
    Function getResult()
        Return result
    End Function
    Function setResult(data As String)
        result = data
        Return 0
    End Function
    Function getCurrent()
        Return current
    End Function
    Function getOK()
        If (result = current) Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class
