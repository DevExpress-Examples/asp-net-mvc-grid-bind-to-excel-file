Imports System.Web.Mvc
Imports CS.Models

Namespace CS.Controllers

    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            If Session("DataTableModel") Is Nothing Then Session("DataTableModel") = InMemoryModel.OpenExcelFile()
            Return View(Session("DataTableModel"))
        End Function

        Public Function DataTableDataBindingPartial() As ActionResult
            Return PartialView(Session("DataTableModel"))
        End Function
    End Class
End Namespace
