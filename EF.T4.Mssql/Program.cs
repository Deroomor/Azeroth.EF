using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.T4.Mssql
{
    class Program
    {
        static void Main(string[] args)
        {
            //string cnnstr = System.Configuration.ConfigurationManager.ConnectionStrings["mssqlmaster"].ConnectionString;
            //using (var cnn = new System.Data.SqlClient.SqlConnection(cnnstr))
            //{
            //    List<string> lstTableName = new List<string>();
            //    using (var cmd = cnn.CreateCommand())
            //    {
            //        cmd.CommandText = "select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME";
            //        using (var reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                lstTableName.Add(reader.GetString(0));
            //            }
            //        }
            //    }
            //    foreach (string nameClass in lstTableName)
            //    {
            //        //manager.StartNewFile(nameClass + ".cs");
            //        //this.WriteLine(string.Format("{1}public partial class {0}", nameClass, new String(' ', 4)));
            //        //this.WriteLine(new String(' ', 4) + "{");
            //        System.Data.DataTable schemaTable;
            //        using (var cmd = cnn.CreateCommand())
            //        {
            //            cmd.CommandText = "select * from " + nameClass;
            //            using (var reader = cmd.ExecuteReader(System.Data.CommandBehavior.KeyInfo | System.Data.CommandBehavior.SchemaOnly))
            //            {
            //                schemaTable = reader.GetSchemaTable();
            //            }
            //        }
            //        System.Data.DataTable commentTable=new System.Data.DataTable("rt");
            //        using (var cmd = cnn.CreateCommand())
            //        {
            //            cmd.CommandText = string.Format("with htt as({0}),gmm as ({1}) select htt.name,gmm.value from htt left join gmm on htt.column_id=gmm.minor_id",
            //                 "select * from sys.columns where object_id=OBJECT_ID('" + nameClass + "')",
            //                 "select * from sys.extended_properties where sys.extended_properties.major_id=OBJECT_ID('" + nameClass + "')");
            //            using (var adapter=new System.Data.SqlClient.SqlDataAdapter(cmd))
            //            {
            //                adapter.Fill(commentTable);
            //            }
            //        }
            //        foreach (System.Data.DataRow row in schemaTable.Select())
            //        {
            //            string colName = row["ColumnName"].ToString();
            //            int ss = Convert.ToInt32(row["ColumnSize"]);
            //            string colType = row["DataType"].ToString().Substring("System.".Length);
            //            bool allowDBNull = Convert.ToBoolean(row["AllowDBNull"]);
            //            if (allowDBNull && !colType.Equals("String") && !colType.Equals("Byte[]"))
            //                colType = "Nullable<" + colType + ">";
            //            if (colName.EndsWith("Enum"))
            //                colType = colName.Substring(0, colName.Length - "Enum".Length) + "Index";
            //            string comment = commentTable.Select("name='" + colName + "'")[0]["value"].ToString().Replace("\r\n", " ").Replace("\n", " ").Replace("\n", " ");
            //            this.WriteLine(string.Format("{0}/// <summary>",new String(' ', 8)));
            //            this.WriteLine(string.Format("{0}///{1}", new String(' ', 8), comment));
            //            this.WriteLine(string.Format("{0}/// </summary>", new String(' ', 8)));
            //            this.WriteLine(string.Format("{0}public {0} {1} {2}", new String(' ', 8), colType, colName, "{set;get;}"));
            //        }
            //        //manager.EndBlock();
            //    }
            //}
        }
    }
}
