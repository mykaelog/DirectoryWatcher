
Class DirectoryTreeNode
    Inherits FileSystemNode

    Public Sub New(ByVal nodeType As FileSystemNodeType)
        Me.New(nodeType, String.Empty)
    End Sub

    Public Sub New(ByVal nodeType As FileSystemNodeType, ByVal text As String)
        MyBase.New(nodeType, text)
    End Sub

End Class
