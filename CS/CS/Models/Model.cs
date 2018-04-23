using System;
using System.Data;
using System.Data.OleDb;

namespace CS.Models {
    public class InMemoryModel {
        private static string fileName = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Customers.xls");

        public static object OpenExcelFile() {
            DataTable dataTable = new DataTable();
            string connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fileName);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString);
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}