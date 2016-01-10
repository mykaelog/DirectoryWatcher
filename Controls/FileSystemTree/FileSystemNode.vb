Imports System.Windows.Forms

Class FileSystemNode
    Inherits TreeNode

    Private m_nodeType As FileSystemNodeType

    Public Sub New(ByVal nodeType As FileSystemNodeType)
        Me.New(nodeType, String.Empty)
    End Sub

    Public Sub New(ByVal nodeType As FileSystemNodeType, ByVal text As String)
        MyBase.New(text)
        Me.m_nodeType = nodeType
    End Sub

    Public ReadOnly Property NodeType
        Get
            Return Me.m_nodeType
        End Get
    End Property
        
End Class
