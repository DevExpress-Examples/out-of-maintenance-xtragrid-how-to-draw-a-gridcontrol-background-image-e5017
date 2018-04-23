Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication61
	Partial Public Class Form1
		Inherits Form
		Private _biHelper As BackgroundImageHelper
		Public Sub New()
			InitializeComponent()
'			#Region "DataSourceInitialization"
			Dim lst As New List(Of Employee)()
			For i As Integer = 0 To 41
				lst.Add(New Employee() With {.ID = i, .FirstName = "Name " & i, .BirthDate = DateTime.Now, .AtVacation = i Mod 2 = 0})
			Next i
			gridControl1.DataSource = lst
'			#End Region
			_biHelper = New BackgroundImageHelper(gridView1, CType(pictureEdit1.Image, Bitmap))
			propertyGrid1.SelectedObject = _biHelper
		End Sub

		Private Sub pictureEdit1_Properties_ImageChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pictureEdit1.Properties.ImageChanged
			If pictureEdit1.Image IsNot Nothing Then
				_biHelper.Image = CType(pictureEdit1.Image, Bitmap)
			End If
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
			_biHelper.PictureAlignment = ContentAlignment.BottomRight
		End Sub
	End Class
	#Region "TestClass"
	Public Class Employee
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateFirstName As String
		Public Property FirstName() As String
			Get
				Return privateFirstName
			End Get
			Set(ByVal value As String)
				privateFirstName = value
			End Set
		End Property
		Private privateAtVacation As Boolean
		Public Property AtVacation() As Boolean
			Get
				Return privateAtVacation
			End Get
			Set(ByVal value As Boolean)
				privateAtVacation = value
			End Set
		End Property
		Private privateBirthDate As DateTime
		Public Property BirthDate() As DateTime
			Get
				Return privateBirthDate
			End Get
			Set(ByVal value As DateTime)
				privateBirthDate = value
			End Set
		End Property
	End Class
	#End Region
End Namespace
