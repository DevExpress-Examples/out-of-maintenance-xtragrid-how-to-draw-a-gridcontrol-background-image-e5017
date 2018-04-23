Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication61
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(778, 578)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' pictureEdit1
			' 
			Me.pictureEdit1.EditValue = My.Resources.DevExpress_Logo_Large_Color
			Me.pictureEdit1.Location = New System.Drawing.Point(783, 25)
			Me.pictureEdit1.Name = "pictureEdit1"
'			Me.pictureEdit1.Properties.ImageChanged += New System.EventHandler(Me.pictureEdit1_Properties_ImageChanged);
			Me.pictureEdit1.Size = New System.Drawing.Size(206, 167)
			Me.pictureEdit1.TabIndex = 1
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.HelpVisible = False
			Me.propertyGrid1.Location = New System.Drawing.Point(783, 218)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(211, 360)
			Me.propertyGrid1.TabIndex = 4
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(784, 6)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(88, 13)
			Me.label1.TabIndex = 5
			Me.label1.Text = "Load new image:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(784, 202)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(95, 13)
			Me.label2.TabIndex = 5
			Me.label2.Text = "Change alignment:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(992, 578)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.propertyGrid1)
			Me.Controls.Add(Me.pictureEdit1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Shown += New System.EventHandler(Me.Form1_Shown);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private WithEvents pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
	End Class
End Namespace

