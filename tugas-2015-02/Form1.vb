﻿Public Class Form1
    Dim Angka1 As Integer
    Dim Angka2 As Integer
    Dim operasi As String
    Dim status As Boolean

    Private Sub input(ByVal angka As Char)
        If Me.status = True Then
            If (Me.resultText.Text = "0") Then
                Me.resultText.Text = Convert.ToString(angka)
            Else
                Dim resultText As TextBox = Me.resultText
                resultText.Text = (resultText.Text & Convert.ToString(angka))
            End If
        Else
            Me.resultText.Text = Convert.ToString(angka)
            Me.status = True
        End If
    End Sub
    Private Sub inputOperator(ByVal oprator As String)
        If (Me.resultText.Text <> "0") Then
            If (Me.operasi = String.Empty) Then
                Me.Angka1 = Convert.ToInt32(Me.resultText.Text)
                Me.resultText.Text = Me.Angka1.ToString
                Me.status = False
            Else
                Me.hitung()
            End If
            Me.operasi = oprator
        End If
    End Sub

    Private Sub hitung()
        Me.Angka2 = Convert.ToInt32(Me.resultText.Text)
        Select Case Me.operasi
            Case "+"
                Me.Angka1 = (Me.Angka1 + Me.Angka2)
                Exit Select
            Case "-"
                Me.Angka1 = (Me.Angka1 - Me.Angka2)
                Exit Select
        End Select
        Me.resultText.Text = Me.Angka1.ToString
        Me.status = False
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        Me.resultText.Text = "0"
        Me.Angka1 = 0
        Me.operasi = String.Empty
    End Sub


    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If (Me.status AndAlso (Me.resultText.Text <> "0")) Then
            Dim resultText As TextBox = Me.resultText
            resultText.Text = (resultText.Text & "0")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.input("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.input("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.input("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.input("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.input("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.input("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.input("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.input("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.input("9")
    End Sub

    Private Sub kurangButton_Click(sender As Object, e As EventArgs) Handles kurangButton.Click
        Me.inputOperator("-")
    End Sub

    Private Sub tambahButton_Click(sender As Object, e As EventArgs) Handles tambahButton.Click
        Me.inputOperator("+")
    End Sub

    Private Sub samaDenganButton_Click(sender As Object, e As EventArgs) Handles samaDenganButton.Click
        If ((Me.resultText.Text <> "0") And (Me.Angka1 <> 0)) Then
            Me.hitung()
            Me.operasi = String.Empty
        End If
    End Sub
End Class
