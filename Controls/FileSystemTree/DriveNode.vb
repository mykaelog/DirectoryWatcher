Imports System.IO

Class DriveNode
    Inherits DirectoryTreeNode


    Private m_drive As DriveInfo

    Private Const DriveNetworkImage = "drive_network.png"
    Private Const DriveFixedImage = "drive_fixed.png"
    Private Const DriveExternalImage = "drive_external.png"
    Private Const DriveDefaultImage = "drive_default.png"

    Public Sub New(drive As DriveInfo)

        MyBase.New(FileSystemNodeType.Drive, drive.Name)
        Me.m_drive = drive
        Me.SetImage()

    End Sub

    Private Sub SetImage()

        Select Case Me.m_drive.DriveType

            Case DriveType.Network
                Me.ImageKey = DriveNode.DriveNetworkImage
                Me.SelectedImageKey = DriveNode.DriveNetworkImage
            Case DriveType.CDRom Or DriveType.Removable
                Me.ImageKey = DriveNode.DriveExternalImage
                Me.SelectedImageKey = DriveNode.DriveExternalImage
            Case DriveType.Fixed
                Me.ImageKey = DriveNode.DriveFixedImage
                Me.SelectedImageKey = DriveNode.DriveFixedImage
            Case Else
                Me.ImageKey = DriveNode.DriveDefaultImage
                Me.SelectedImageKey = DriveNode.DriveDefaultImage

        End Select

    End Sub

End Class
