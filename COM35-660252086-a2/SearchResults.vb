Imports System.Text.RegularExpressions

Public Class SearchResults
    Dim listFromFilePath As New ArrayList
    Dim resultsArray As New ArrayList


    'Pull in all file from directory
    Sub listOfFiles(location As String, extension As String)
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(location, FileIO.SearchOption.SearchAllSubDirectories, extension)
            listFromFilePath.Add(foundFile)
        Next

    End Sub

    Sub patternSearcher(checkBox As Boolean, pattern As String)
        If pattern <> Nothing Then
            resultsArray.Clear()
            If Not checkBox Then 'Test if not checked'
                resultsArray.Clear()
                For i = 0 To listFromFilePath.Count - 1
                    For Each m As Match In Regex.Matches(listFromFilePath(i), pattern, RegexOptions.IgnoreCase)
                        resultsArray.Add(listFromFilePath(i))
                        Exit For
                    Next

                Next
            Else 'if is checked'
                resultsArray.Clear()
                For i = 0 To listFromFilePath.Count - 1
                    For Each m As Match In Regex.Matches(listFromFilePath(i), pattern)
                        resultsArray.Add(listFromFilePath(i))
                        Exit For
                    Next
                Next
            End If

        Else 'empty pattern'
            resultsArray.Clear()
            For i = 0 To listFromFilePath.Count - 1
                resultsArray.Add(listFromFilePath(i))
            Next
        End If
    End Sub

    'To be called from Found Results'
    Public Function getResults() As ArrayList
        Return resultsArray
    End Function

End Class
