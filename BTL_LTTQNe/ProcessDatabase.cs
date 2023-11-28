using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_LTTQ_Ne
{
	internal class ProcessDatabase
	{
/*		string stringcon = @"Data Source=MSI\GB;Initial Catalog=Food_Ind_Management;Integrated Security=True";
*/       
		string stringcon = @"Data Source=DESKTOP-3GCI6TQ\SQLEXPRESS;Initial Catalog=Food_Ind_Management;Integrated Security=True";

        SqlConnection con;
		public void KetNoi()
		{
			con = new SqlConnection(stringcon);
			if (con.State != ConnectionState.Open)
				con.Open();
		}
		public void DongKetNoi()
		{
			if (con.State != ConnectionState.Closed)
				con.Close();
			con.Dispose();
		}
		public DataTable DocBang(string sql)
		{
			DataTable tb = new DataTable();
			KetNoi();
			SqlDataAdapter adap = new SqlDataAdapter(sql, con);
			adap.Fill(tb);
			DongKetNoi();
			return tb;
		}

        public DataTable DocBang2(string sql, SqlParameter[] parameter = null)
        {
            DataTable tb = new DataTable();
            KetNoi();

            using (SqlCommand command = new SqlCommand(sql, con))
            {
                // Thêm tham số nếu có
                if (parameter != null)
                {
                    command.Parameters.AddRange(parameter);
                }

                SqlDataAdapter adap = new SqlDataAdapter(command);
                adap.Fill(tb);
            }

            DongKetNoi();
            return tb;
        }

        public void CapNhat(string sql)
		{
			SqlCommand cmm = new SqlCommand();
			KetNoi();
			cmm.CommandText = sql;
			cmm.Connection = con;
			cmm.ExecuteNonQuery();
			cmm.Dispose();
			DongKetNoi();
		}

        public void RunSQL(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            KetNoi();
            cmd.CommandText = sql;
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            KetNoi();
            cmd.Dispose();
        }

    }
}