using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;


namespace AppDevAssignment
{
    class Test
    {
        public static void method()
        {
            string q = "SELECT * FROM COWS WHERE ID = 1002";
            OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\stevi\\Desktop\\wintec\\farm\\FarmInfomation.accdb; Persist Security Info = False");
            conn.Open();
            try
            {
                string str = "\t";
                OleDbCommand cmd = new OleDbCommand(q, conn);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        str += reader["id"].ToString() + "\t";
                        str += reader["Amount of water"].ToString() + "\t";
                        str += reader["weight"].ToString() + "\t";
                        str += reader["Age"].ToString() + "\t";
                        str += reader["Color"].ToString() + "\t";
                        str += reader["Amount of milk"].ToString() + "\t";
                        str += reader["Is jersy"].ToString() + "\t";
                        str += "\n\t";
                    }
                    MessageBox.Show(str);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
