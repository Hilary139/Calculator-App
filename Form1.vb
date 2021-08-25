Public Class Form1      ' this starts the application, it holds other block of code used in the application 

    ' this is the Addition Code 

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim AddOne As Integer = CInt(TextAdd1.Text)
        Dim AddTwo As Integer = CInt(TextAdd2.Text)
        Dim AnswerAdd As Integer = CInt(AddOne + AddTwo)

        AddAns.Text = CStr(AnswerAdd)

    End Sub



    ' this is the Subtraction Code 

    Private Sub SubBtn_Click(sender As Object, e As EventArgs) Handles SubBtn.Click
        Dim SubOne As Integer = CInt(TextSub1.Text)
        Dim SubTwo As Integer = CInt(TextSub2.Text)
        Dim AnswerSub As Integer = CInt(SubOne - SubTwo)

        SubAns.Text = CStr(AnswerSub)

    End Sub


    ' this is the Multiplication Code 

    Private Sub MultiBtn_Click(sender As Object, e As EventArgs) Handles MultiBtn.Click
        Dim MultiOne As Integer = CInt(TextMul1.Text)
        Dim MultiTwo As Integer = CInt(TextMul2.Text)
        Dim AnswerMulti As Integer = CInt(MultiOne * MultiTwo)

        MulAns.Text = CStr(AnswerMulti)

    End Sub


    ' this is the Division Code

    Private Sub DivBtn_Click(sender As Object, e As EventArgs) Handles DivBtn.Click
        Dim DivOne As Integer = CInt(TextDiv1.Text)
        Dim DivTwo As Integer = CInt(TextDiv2.Text)
        Dim AnswerDiv As Integer = CInt(DivOne / DivTwo)

        DivAns.Text = CStr(AnswerDiv)
    End Sub



    ' this is the Exit Button Code 
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()  ' used to exit the application 

    End Sub



    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        MessageBox.Show("Thank You!! You Can Now Use The Application :) ")
    End Sub


End Class

' the End statement is used to end every block of code 