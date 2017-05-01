Imports System.Text.RegularExpressions

Public Class SearchResults
    Dim dictListFromFilePath As New Dictionary(Of Integer, String)
    Dim dictList As New Dictionary(Of Integer, String)



    'Pull in all file from directory
    Sub listOfFiles(location As String, extension As String)
        Dim result As String
        Dim i = 0
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(location, FileIO.SearchOption.SearchAllSubDirectories, extension)
            result = IO.Path.GetFileName(foundFile) 'Display only file.ext'
            'listFromFilePath.Add(result)
            dictListFromFilePath.Add(i + 1, result)
            i += 1
        Next
    End Sub

    Sub patternSearcher(checkBox As Boolean, pattern As String)
        If pattern <> Nothing Then
            dictList.Clear()
            If Not checkBox Then 'Test if not checked'
                dictList.Clear()
                For i = 0 To dictListFromFilePath.Count - 1
                    For Each m As Match In Regex.Matches(dictListFromFilePath.Values(i), pattern, RegexOptions.IgnoreCase)
                        dictList.Add(i + 1, dictListFromFilePath.Values(i))
                        Exit For
                    Next

                Next
            Else 'if is checked'
                dictList.Clear()
                For i = 0 To dictListFromFilePath.Count - 1
                    For Each m As Match In Regex.Matches(dictListFromFilePath.Values(i), pattern)
                        dictList.Add(i + 1, dictListFromFilePath.Values(i))
                        Exit For
                    Next
                Next
            End If

        Else 'empty pattern'
            dictList.Clear()
            For i = 0 To dictListFromFilePath.Count - 1
                dictList.Add(i + 1, dictListFromFilePath.Values(i))
            Next
        End If
    End Sub

    'To be called from Found Results'
    Public Function getResults() As Dictionary(Of Integer, String)
        Return dictList
    End Function

End Class
