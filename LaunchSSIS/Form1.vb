Imports Microsoft.SqlServer.Dts.Runtime

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
        Dim result = dlgSSISFile.ShowDialog()
        If result = DialogResult.OK Then
            TextBox1.Text = dlgSSISFile.FileName
        End If
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim pkgLocation As String
        Dim pkg As New Package
        Dim app As New Application
        Dim eventListerner As New EventListener()
        pkg = app.LoadPackage(TextBox1.Text, Nothing)
        If pkg.Execute(Nothing, Nothing, eventListerner, Nothing, Nothing) = DTSExecResult.Success Then
            MessageBox.Show("Successs")
        End If

    End Sub
End Class

Class EventListener
    Inherits DefaultEvents

    Public Overrides Function OnError(ByVal source As Microsoft.SqlServer.Dts.Runtime.DtsObject,
    ByVal errorCode As Integer, ByVal subComponent As String, ByVal description As String,
    ByVal helpFile As String, ByVal helpContext As Integer,
    ByVal idofInterfaceWithError As String) As Boolean

        ' Add application-specific diagnostics here.  
        MessageBox.Show(String.Format("Error in {0}/{1} : {2}", source, subComponent, description))
        Return False

    End Function

End Class