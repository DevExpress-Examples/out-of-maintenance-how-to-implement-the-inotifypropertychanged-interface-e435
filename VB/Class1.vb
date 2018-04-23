Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace WindowsApplication18
	''' <summary>
	''' Summary description for Class1.
	''' </summary>
	''' 
	Public Class Record
		Implements INotifyPropertyChanged
		Private id_Renamed, age_Renamed As Integer
		Private name_Renamed As String
		Private detail_Renamed As BindingList(Of Record)
		Public Sub New()
			detail_Renamed = New BindingList(Of Record)()
			detail_Renamed.AllowEdit = True
			detail_Renamed.AllowNew = True
		End Sub
		Public Sub New(ByVal id As Integer, ByVal name As String, ByVal age As Integer)
			Me.id_Renamed = id
			Me.name_Renamed = name
			Me.age_Renamed = age
			'this.detail = detail;
		End Sub
		Public ReadOnly Property ID() As Integer
			Get
				Return id_Renamed
			End Get
		End Property
		Public Overridable Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
				NotifyPropertyChanged("Name")
			End Set
		End Property
		Public Property Age() As Integer
			Get
				Return age_Renamed
			End Get
			Set(ByVal value As Integer)
				age_Renamed = value
				NotifyPropertyChanged("Age")
			End Set
		End Property

		Public Property Detail() As BindingList(Of Record)
			Get
				Return detail_Renamed
			End Get
			Set(ByVal value As BindingList(Of Record))
				detail_Renamed = value
			End Set
		End Property

		#Region "INotifyPropertyChanged Members"

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Private Sub NotifyPropertyChanged(ByVal info As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
		End Sub

		#End Region
	End Class

End Namespace
