Imports System
Imports System.Linq

Namespace Grid_RowDetailsTemplateSelector
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = Person.GetData()
		End Sub
	End Class

	Public Class Person
		Public Property FirstName() As String
		Public Property LastName() As String
		Public Property PhoneNumber() As String
		Public Property Address() As String
		Public Shared Function GetData() As List(Of Person)
			Dim data As New List(Of Person)()
			data.Add(New Person() With {
				.FirstName = "Lara",
				.LastName = "Pembridge",
				.Address = "14 Aldgate, London",
				.PhoneNumber = "+44 3069 990173"
			})
			data.Add(New Person() With {
				.FirstName = "Chris",
				.LastName = "Christensen",
				.Address = "2 High Holborn, London",
				.PhoneNumber = "+44 3069 990032"
			})
			data.Add(New Person() With {
				.FirstName = "Sam",
				.LastName = "Darlington",
				.Address = "Hans-Grade-Allee 25, Damsdorf",
				.PhoneNumber = "04557 66 08 94"
			})
			data.Add(New Person() With {
				.FirstName = "Jessy",
				.LastName = "Oldridge",
				.Address = "An Der Urania 77, Aichstetten",
				.PhoneNumber = "04841 96 66 74"
			})
			Return data
		End Function
	End Class
End Namespace
