Public Class Form1

    Dim FruitUserSettings As FruitCollection
    Dim GridBindingSrc As BindingSource

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FruitUserSettings = New FruitCollection()

        GridBindingSrc = New BindingSource(FruitUserSettings, "Fruits")

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = GridBindingSrc

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FruitUserSettings.Save()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        GridBindingSrc.Dispose()
    End Sub
End Class
