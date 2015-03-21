Public Class Stats


    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Label7.BackColor = Color.Transparent
        Label8.BackColor = Color.Transparent
        Label9.BackColor = Color.Transparent
        Label10.BackColor = Color.Transparent
        Label11.BackColor = Color.Transparent
        Label12.BackColor = Color.Transparent
        Label13.BackColor = Color.Transparent
        Label14.BackColor = Color.Transparent
        Label15.BackColor = Color.Transparent
        Label16.BackColor = Color.Transparent
        Label17.BackColor = Color.Transparent
        Label18.BackColor = Color.Transparent
        Label19.BackColor = Color.Transparent
        Label20.BackColor = Color.Transparent
        Label21.BackColor = Color.Transparent
    End Sub

    Private Sub GoalsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoalsToolStripMenuItem.Click
        Me.Hide()
        Goals.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Measurement.Show()
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub
End Class
