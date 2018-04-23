Imports DevExpress.Xpf.Grid
Imports System
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls

Namespace Grid_RowDetailsTemplateSelector
	Friend Class RowDetailsTemplateSelector
		Inherits DataTemplateSelector

		Public Property PrimaryRowDetailsTemplate() As DataTemplate
		Public Property SecondaryRowDetailsTemplate() As DataTemplate
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim row As RowData = TryCast(item, RowData)
			If row IsNot Nothing Then
                Dim _person As Person = TryCast(row.Row, Person)
                If _person IsNot Nothing Then
                    Return If(_person.Address.Contains("London"), PrimaryRowDetailsTemplate, SecondaryRowDetailsTemplate)
                End If
			End If
			Return MyBase.SelectTemplate(item, container)
		End Function
	End Class
End Namespace
