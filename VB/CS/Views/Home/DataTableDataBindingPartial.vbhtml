@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gvDataTableDataBinding"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "DataTableDataBindingPartial"}
    End Sub).Bind(Model).GetHtml()