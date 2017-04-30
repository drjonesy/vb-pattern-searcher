Public Class Form1

    Private Property _location As String
    Private Property _fileExtension As String
    Private Property _isCaseSensitive As Boolean
    Private Property _pattern As String
    Private Property _arrayListResults As ArrayList

    Private Sub checkCaseSensitive_CheckedChanged(sender As Object, e As EventArgs) Handles checkCaseSensitive.CheckedChanged
        _isCaseSensitive = checkCaseSensitive.Checked
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            _location = FolderBrowserDialog1.SelectedPath
        End If
        txtLoad.Text = _location
    End Sub

    Private Sub cbFileType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFileType.SelectedIndexChanged
        _fileExtension = cbFileType.SelectedItem.ToString()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        _pattern = txtSearch.Text.ToString()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Time
        ListView1.Clear()
        Dim patternSearcher As New PatternSearcher(_location, _fileExtension, _isCaseSensitive, _pattern)
        patternSearcher.StartSearch()
        _arrayListResults = patternSearcher._arrayListResults
        lblTotalResults.Text = _arrayListResults.Count
        For Each item As String In Me._arrayListResults
            ListView1.Items.Add(item)
        Next
    End Sub
End Class
