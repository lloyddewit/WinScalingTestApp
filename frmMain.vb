Public Class frmMain
    Private Sub btnAutoScaleNone_Click(sender As Object, e As EventArgs) Handles btnAutoScaleNone.Click
        frmAutoScaleNone.ShowDialog()
    End Sub

    Private Sub btnAutoScaleFont_Click(sender As Object, e As EventArgs) Handles btnAutoScaleFont.Click
        frmAutoScaleFont.ShowDialog()
    End Sub

    Private Sub btnAutoScaleDpi_Click(sender As Object, e As EventArgs) Handles btnAutoScaleDpi.Click
        frmAutoScaleDpi.ShowDialog()
    End Sub
End Class
