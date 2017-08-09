Public Class Form1

    Private Sub ClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientToolStripMenuItem.Click
        frmClientSearch.MdiParent = Me
        frmClientSearch.Show()
    End Sub
End Class
