Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO

Public Class FileSystemTree

#Region "Members"

    Private m_ShowSystem As Boolean = False
    Private m_ShowHidden As Boolean = False
    Private m_ShowNetworkDrives As Boolean = False
    Private m_ShowRemovableDrives As Boolean = False
    Private m_showRamDrives As Boolean = True
    Private m_showInactiveDrives As Boolean = True
    Private m_initialTreeCreate As Boolean = False
    Private m_rootDrive As String = String.Empty

#End Region

#Region "Properties"

    <DefaultValue(False)>
    <Category("Behaviour")>
    <Browsable(True)>
    <Description("Gets or Set if a File/Directory with system attribute should be shown.")>
    Public Property ShowSystem As Boolean
        Get
            Return Me.m_ShowSystem
        End Get
        Set(value As Boolean)
            Me.m_ShowSystem = value
        End Set
    End Property

    <DefaultValue(False)>
    <Category("Behaviour")>
    <Browsable(True)>
    <Description("Gets or Set if a File/Directory with hidden attribute should be shown.")>
    Public Property ShowHidden As Boolean
        Get
            Return Me.m_ShowHidden
        End Get
        Set(value As Boolean)
            Me.m_ShowHidden = value
        End Set
    End Property

    <DefaultValue(False)>
    <Category("Behaviour")>
    <Browsable(True)>
    <Description("Gets or Set if a network drive should be shown.")>
    Public Property ShowNetworkDrives As Boolean
        Get
            Return Me.m_ShowNetworkDrives
        End Get
        Set(value As Boolean)
            Me.m_ShowNetworkDrives = value
        End Set
    End Property

    <DefaultValue(False)>
    <Category("Behaviour")>
    <Browsable(True)>
    <Description("Gets or Set if a removable drive should be shown.")>
    Public Property ShowRemovableDrives As Boolean
        Get
            Return Me.m_ShowRemovableDrives
        End Get
        Set(value As Boolean)
            Me.m_ShowRemovableDrives = value
        End Set
    End Property

    <DefaultValue(False)>
    <Category("Behaviour")>
    <Browsable(True)>
    <Description("Gets or Set if a ram drive should be shown.")>
    Public Property ShowRamDrives As Boolean
        Get
            Return Me.m_showRamDrives
        End Get
        Set(value As Boolean)
            Me.m_showRamDrives = value
        End Set
    End Property

    <DefaultValue(False)>
    <Category("Behaviour")>
    <Browsable(True)>
    <Description("Gets or Set if a inactive drive should be shown.")>
    Public Property ShowInactiveDrives As Boolean
        Get
            Return Me.m_showInactiveDrives
        End Get
        Set(value As Boolean)
            Me.m_showInactiveDrives = value
        End Set
    End Property

    <DefaultValue("")>
    <Category("Behavior")>
    <Browsable(True)>
    <Description("Gets or sets the name of the root drive. If empty or Nothing, then My Computer is root.")>
    Public Property RootDrive As String
        Get
            Return Me.m_rootDrive
        End Get
        Set(value As String)
            If (value <> Me.m_rootDrive) Then
                Me.m_rootDrive = Path.GetPathRoot(value)
                If (m_rootDrive.EndsWith(":")) Then
                    m_rootDrive += "\"
                End If
                CreateInitialTree()
            End If
        End Set
    End Property

#End Region

#Region "Control Events"

    Private Sub FileSystemTree_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub FileSystemTree_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        If (Me.m_initialTreeCreate = False) Then
            Me.CreateInitialTree()
            Me.m_initialTreeCreate = True
        End If

    End Sub

#End Region

#Region "Methods"

    <Description("Creates Initial Tree")>
    Private Sub CreateInitialTree()

        Me.tvSystem.Nodes.Clear()

        Dim rootNode = Me.ResolveRootNode()



    End Sub

    <Description("Resolve RootNode, which can be my computer or drive node.")
    Private Function ResolveRootNode() As FileSystemNode

        If (String.IsNullOrWhiteSpace(Me.RootDrive)) Then
            Return New ComputerNode()
        End If

        Dim drives = DriveInfo.GetDrives()
        For Each drive In drives
            If (drive.Name = Me.RootDrive) Then
                Return New DriveNode(drive)
            End If
        Next

        Return New ComputerNode()

    End Function

#End Region

    
    
End Class
