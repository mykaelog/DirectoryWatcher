
Class ComputerNode
    Inherits FileSystemNode

    Private Const ComputerImageKey = "computer.png"

    Public Sub New()

        Me.New("My Computer")

    End Sub

    Protected Sub New(ByVal text As String)

        MyBase.New(FileSystemNodeType.Computer, text)
        Me.ImageKey = ComputerNode.ComputerImageKey
        Me.SelectedImageKey = ComputerNode.ComputerImageKey

    End Sub

End Class
