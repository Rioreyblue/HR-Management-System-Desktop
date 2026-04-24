Imports System.Drawing.Drawing2D
Imports System.IO

Public Module modFormMethods

    'Public emp As New frmMain

    Public Sub LoadForm(ByVal frm As Form, labelDesc As String)
        frmDash.lblName.Text = labelDesc
        frmDash.pnlLoad.Controls.Clear()
        frm.Dock = DockStyle.Fill
        frm.TopMost = True
        frm.TopLevel = False
        frmDash.pnlLoad.Controls.Add(frm)
        frm.Show()
    End Sub

    Public Sub CenterControlToContainer(ByVal container As Control, ByVal contl As Control)
        contl.Left = (container.Width - contl.Width) \ 2
    End Sub

    Public Function ImageToBase64(image As Image, format As System.Drawing.Imaging.ImageFormat) As String
        Dim base64String As String = ""
        Try
            Using ms As New MemoryStream()
                image.Save(ms, format)
                Dim imageBytes As Byte() = ms.ToArray
                base64String = Convert.ToBase64String(imageBytes)

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Return base64String
    End Function
    Public Function Base64ToImage(base64String As String) As Image
        Dim img As Image = Nothing
        Try
            Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
            Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)
            ms.Write(imageBytes, 0, imageBytes.Length)
            img = Image.FromStream(ms, True)
            ms.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        Return img
    End Function
    Public Sub RoundCorner(ByVal ctl As Control, radius As Integer)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        'top left corner
        DGP.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        DGP.AddLine(radius, 0, ctl.Width - radius, 0)

        'top right corner
        DGP.AddArc(New Rectangle(ctl.Width - radius, 0, radius, radius), -90, 90)
        DGP.AddLine(ctl.Width, radius, ctl.Width, ctl.Height - radius)

        'bottom right corner
        DGP.AddArc(New Rectangle(ctl.Width - radius, ctl.Height - radius, radius, radius), 0, 90)
        DGP.AddLine(ctl.Width - radius, ctl.Height, radius, ctl.Height)
        'bottom left corner
        DGP.AddArc(New Rectangle(0, ctl.Height - radius, radius, radius), 90, 90)
        DGP.CloseFigure()

        ctl.Region = New Region(DGP)

    End Sub
    Public Sub RoundPicture(ByVal pb As PictureBox)
        Dim croppedImage As New Bitmap(pb.Width, pb.Height)

        'Prepare to draw on the new image.
        Using g = Graphics.FromImage(croppedImage)
            Dim path As New Drawing2D.GraphicsPath

            'Create an ellipse that fills the image in both directions.
            path.AddEllipse(0, 0, croppedImage.Width, croppedImage.Height)

            Dim reg As New Region(path)

            'Draw only within the specified ellipse.
            g.Clip = reg
            g.DrawImage(pb.Image, Point.Empty)
            pb.Image = croppedImage
            pb.SizeMode = PictureBoxSizeMode.Zoom

        End Using


    End Sub
    Public Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth, percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function

    Public Function ResizeImg(img As Image, scale As Integer) As Bitmap
        Dim scale_factor As Integer = scale

        ' Get the source bitmap.
        Dim bm_source As New Bitmap(img)

        ' Make a bitmap for the result.
        Dim bm_dest As New Bitmap(
            CInt(bm_source.Width * scale_factor),
            CInt(bm_source.Height * scale_factor))

        ' Make a Graphics object for the result Bitmap.
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

        ' Copy the source image into the destination bitmap.
        gr_dest.DrawImage(bm_source, 0, 0,
            bm_dest.Width + 1,
            bm_dest.Height + 1)

        Return bm_dest
    End Function

    Public Class ListViewItemComparer
        Implements IComparer

        Private col As Integer
        Private order As SortOrder

        Public Sub New(column As Integer, sortOrder As SortOrder)
            col = column
            order = sortOrder
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim itemX As ListViewItem = CType(x, ListViewItem)
            Dim itemY As ListViewItem = CType(y, ListViewItem)

            Dim result As Integer = String.Compare(itemX.SubItems(col).Text, itemY.SubItems(col).Text)

            If order = SortOrder.Descending Then
                result *= -1
            End If

            Return result
        End Function
    End Class
End Module
