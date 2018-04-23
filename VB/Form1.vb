Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication18
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As GridView
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
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
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(559, 318)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.UseEmbeddedNavigator = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.AllowExpandEmptyDetails = True
			Me.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails
			Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(568, 349)
			Me.xtraTabControl1.TabIndex = 1
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2})
			Me.xtraTabControl1.Text = "xtraTabControl1"
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.gridControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(559, 318)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.gridControl2)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(559, 318)
			Me.xtraTabPage2.Text = "xtraTabPage2"
			' 
			' gridControl2
			' 
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl2.EmbeddedNavigator.Name = ""
			Me.gridControl2.Location = New System.Drawing.Point(0, 0)
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(559, 318)
			Me.gridControl2.TabIndex = 1
			Me.gridControl2.UseEmbeddedNavigator = True
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.Name = "gridView2"
			Me.gridView2.OptionsDetail.AllowExpandEmptyDetails = True
			Me.gridView2.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails
			Me.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(399, 355)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(157, 23)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "Add detail record"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(568, 389)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		Private list As BindingList(Of Record) = New BindingList(Of Record)()

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			list.Add(New Record(1, "Jane", 19))
			list.Add(New Record(2, "Joe", 30))
			list.Add(New Record(3, "Bill", 15))
			list.Add(New Record(4, "Michael", 42))
			list(0).Detail = New BindingList(Of Record)()
			list(0).Detail.Add(New Record(1, "Name 1", 10))
			list.AllowEdit = True
			list.AllowEdit = True

			gridControl1.DataSource = list
			gridControl1.MainView.PopulateColumns()

			gridControl2.DataSource = list
			gridControl2.MainView.PopulateColumns()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Me.list(0).Detail.Add(New Record(2, "Name2", 20))
		End Sub
	End Class
End Namespace
