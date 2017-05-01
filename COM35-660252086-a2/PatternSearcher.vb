Public Class PatternSearcher

    Private Property _location As String
    Private Property _fileExtension As String
    Private Property _isCaseSensitive As Boolean
    Private Property _pattern As String
    Public Property _dictListResults As Dictionary(Of Integer, String)

    Public Sub New(location As String, fileExtension As String, isCaseSensitive As Boolean, pattern As String)
        Me._location = location
        Me._fileExtension = fileExtension
        Me._isCaseSensitive = isCaseSensitive
        Me._pattern = pattern
    End Sub

    'Rename to NewSearch'
    Public Sub StartSearch()
        Dim CustomSearchResults As New SearchResults()
        CustomSearchResults.listOfFiles(_location, _fileExtension)
        CustomSearchResults.patternSearcher(_isCaseSensitive, _pattern)
        _dictListResults = CustomSearchResults.getResults()
    End Sub

End Class
