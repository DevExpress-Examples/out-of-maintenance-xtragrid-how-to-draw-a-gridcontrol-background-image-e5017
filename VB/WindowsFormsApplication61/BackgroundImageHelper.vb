Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Blending
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace WindowsFormsApplication61
	Public Class BackgroundImageHelper
		Private _blendingComponent As XtraGridBlending
		Private _originalImage As Bitmap
		Private _grid As GridView
		Private _pictureAlignment As ContentAlignment

		Public Property Image() As Bitmap
			Get
				Return _originalImage
			End Get
			Set(ByVal value As Bitmap)
				_originalImage = value
				GenegateBackgroundImage()
			End Set
		End Property
		Public Property PictureAlignment() As ContentAlignment
			Get
				Return _pictureAlignment
			End Get
			Set(ByVal value As ContentAlignment)
				_pictureAlignment = value
				GenegateBackgroundImage()
			End Set
		End Property
		Public Sub New(ByVal grid As GridView, ByVal image As Bitmap, Optional ByVal alignment As ContentAlignment = ContentAlignment.BottomRight)
			_grid = grid
			InitializingBlendingComponent()
			_originalImage = image
			_grid.GridControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			PictureAlignment = alignment
			AddHandler _grid.GridControl.Resize, AddressOf GridControl_Resize
			GenegateBackgroundImage()
		End Sub

		Private Sub GridControl_Resize(ByVal sender As Object, ByVal e As EventArgs)
			GenegateBackgroundImage()
		End Sub

		Private Sub GenegateBackgroundImage()
			Dim gvInfo As GridViewInfo = TryCast(_grid.GetViewInfo(), GridViewInfo)
			Dim _processedImage As New Bitmap(gvInfo.ViewRects.Client.Width + 1, gvInfo.ViewRects.Client.Height + 1)
			Using g As Graphics = Graphics.FromImage(_processedImage)
				Dim p As Point = CalculateImageLocation(_originalImage.Width, _originalImage.Height, gvInfo, _pictureAlignment)
				g.DrawImage(_originalImage, p)
				g.Save()
			End Using
			_grid.GridControl.BackgroundImage = _processedImage
		End Sub

		Private Function CalculateImageLocation(ByVal imageWidht As Integer, ByVal imageHeight As Integer, ByVal gvInfo As GridViewInfo, ByVal alignment As ContentAlignment) As Point
			Dim location As Point = Point.Empty
			Dim rect As Rectangle = gvInfo.ViewRects.Rows
			Dim indicatorWidth As Integer = gvInfo.ViewRects.IndicatorWidth
			Dim vScrollSize As Integer = If(gvInfo.VScrollBarPresence = ScrollBarPresence.Visible, 20, 0)
			Dim hSctollSize As Integer = If(gvInfo.HScrollBarPresence = ScrollBarPresence.Visible, 20, 0)

			Select Case alignment
				Case ContentAlignment.BottomCenter
					location.Offset((rect.Width / 2) - (imageWidht \ 2), rect.Bottom - imageHeight - hSctollSize)
				Case ContentAlignment.BottomLeft
					location.Offset(indicatorWidth, rect.Bottom - imageHeight - hSctollSize)
				Case ContentAlignment.BottomRight
					location.Offset(rect.Right - imageWidht - vScrollSize, rect.Bottom - imageHeight - hSctollSize)
				Case ContentAlignment.MiddleCenter
					location.Offset((rect.Width / 2) - (imageWidht \ 2), (rect.Height / 2) - (imageHeight \ 2))
				Case ContentAlignment.MiddleLeft
					location.Offset(indicatorWidth, (rect.Height / 2) - (imageHeight \ 2))
				Case ContentAlignment.MiddleRight
					location.Offset(rect.Width - imageWidht - vScrollSize, (rect.Height / 2) - (imageHeight \ 2))
				Case ContentAlignment.TopCenter
					location.Offset((rect.Width / 2) - (imageWidht \ 2), rect.Top)
				Case ContentAlignment.TopLeft
					location.Offset(indicatorWidth, rect.Top)
				Case ContentAlignment.TopRight
					location.Offset(rect.Right - imageWidht - vScrollSize, rect.Top)
				Case Else
			End Select
			Return location
		End Function

		Private Sub InitializingBlendingComponent()
			_blendingComponent = New XtraGridBlending()
			_blendingComponent.GridControl = _grid.GridControl
		End Sub
	End Class
End Namespace
