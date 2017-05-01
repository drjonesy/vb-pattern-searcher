Public Class Form1

    Private Property f_location As String
    Private Property f_fileExtension As String
    Private Property f_isCaseSensitive As Boolean
    Private Property f_pattern As String
    Private Property f_dictListResults As Dictionary(Of Integer, String)

    Dim start_time As DateTime
    Dim stop_time As DateTime
    Dim elapsed_time As TimeSpan



    Private Sub checkCaseSensitive_CheckedChanged(sender As Object, e As EventArgs) Handles checkCaseSensitive.CheckedChanged
        f_isCaseSensitive = checkCaseSensitive.Checked
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            f_location = FolderBrowserDialog1.SelectedPath
        End If
        txtLoad.Text = f_location
    End Sub

    Private Sub cbFileType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFileType.SelectedIndexChanged
        f_fileExtension = cbFileType.SelectedItem.ToString()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        f_pattern = txtSearch.Text.ToString()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lblTotalSeconds.Text = 0.0000000
        start_time = Now

        ListView1.Clear()
        Dim patternSearcher As New PatternSearcher(f_location, f_fileExtension, f_isCaseSensitive, f_pattern)
        patternSearcher.StartSearch() 'initialize'
        f_dictListResults = patternSearcher._dictListResults 'call to class property'
        'Display results in list view'
        For Each item As KeyValuePair(Of Integer, String) In f_dictListResults
            ListView1.Items.Add(item.Key & " - " & item.Value)
        Next
        'Display total millisecond between load time'
        stop_time = Now
        elapsed_time = stop_time.Subtract(start_time)
        lblTotalSeconds.Text = elapsed_time.TotalSeconds.ToString("0.0000000")

        lblTotalResults.Text = f_dictListResults.Count


    End Sub


End Class
