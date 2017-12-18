Public Class Form1

    Public pi As Double

    Private Sub btncalcular_Click(sender As System.Object, e As System.EventArgs) Handles btncalcular.Click

        Try


            Dim radesfera As Double
            Dim volesfera As Double

            pi = 3.14
            radesfera = CType(txtradioesf.Text, Double)

            volesfera = (4 / 3) * (pi) * (Math.Pow(radesfera, 3))

            txtrvolesf.Text = volesfera

        Catch ex As Exception

            MsgBox("Ingrese los datos correctos", MsgBoxStyle.Critical)

        End Try


    End Sub

 
   
    Private Sub btncalcular1_Click(sender As System.Object, e As System.EventArgs) Handles btncalcular1.Click

        Try

            Dim radcilindro As Double
            Dim alturacilindro As Double

            Dim volcilindro As Double

            pi = 3.14
            radcilindro = CType(txtradiocil.Text, Double)

            alturacilindro = CType(txtalturacil.Text, Double)

            volcilindro = (pi) * (Math.Pow(radcilindro, 2)) * alturacilindro

            txtvolcil.Text = volcilindro


        Catch ex As Exception

            MsgBox("Ingrese los datos correctos", MsgBoxStyle.Critical)

        End Try

    End Sub


End Class
