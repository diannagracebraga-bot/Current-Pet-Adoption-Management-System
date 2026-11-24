Public Class Form4
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Upload picture button
        Dim ofd As New OpenFileDialog() With {
        .CheckFileExists = True,
        .ShowReadOnly = False,
        .Filter = "All Files|*.*|JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp",
        .FilterIndex = 1
        }

        If ofd.ShowDialog() = DialogResult.OK Then
            ' Load the image into the PictureBox
            PictureBox2.Image = Image.FromFile(ofd.FileName)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'back to homepage
        FormStateManager.SwitchForm(Me, Form1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'go to my adoptions page
        FormStateManager.SwitchForm(Me, Form5)
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStateManager.LoadSavedState()
        Me.WindowState = FormStateManager.LastState
    End Sub


End Class