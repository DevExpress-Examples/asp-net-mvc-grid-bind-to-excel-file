Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Data.OleDb

Namespace CS.Models
	Public Class InMemoryModel
		Private Shared fileName As String = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Customers.xls")

		Public Shared Function OpenExcelFile() As Object
			Dim dataTable As New DataTable()
			Dim connectionString As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fileName)
			Dim adapter As New OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString)
			adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class
End Namespace