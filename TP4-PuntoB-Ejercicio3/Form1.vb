Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim Resto, B As Integer
        lstSalida.Items.Add("Numeros pares del 2 al 100:")
        For B = 0 To 100 Step 1
            Resto = B Mod 2
            If Resto = 0 Then
                lstSalida.Items.Add("" & B)
            Else

            End If

        Next B

    End Sub
End Class
