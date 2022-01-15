using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yazlab1_3.v._1
{
    public partial class arama : System.Web.UI.Page
    {
        public string query, constr;
        public MySqlCommand com;
        public SqlConnection con;
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=web;Uid=root;Pwd='123456';");
        MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
        MySqlConnection MyCon;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void connection()
        {

            conn_string.Server = "localhost";
            conn_string.Port = 3306;
            conn_string.UserID = "root";
            conn_string.Password = "123456";
            conn_string.Database = "web";
            MyCon = new MySqlConnection(conn_string.ToString());

            MyCon.Open();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            connection();

            MySqlCommand kosul = new MySqlCommand("SELECT * from kullanici ", MyCon);

            MySqlDataAdapter da = new MySqlDataAdapter(kosul);

            DataTable dt = new DataTable();

            dt.Clear();

            da.Fill(dt);
            GridView1.DataSource = dt;
            dt.Clear();

            Response.Redirect("arama.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection();
            SqlCommand com = new SqlCommand("select Name,type,data from web.pdf where id=@id", con);
            com.Parameters.AddWithValue("id", GridView1.SelectedRow.Cells[1].Text);
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = dr["type"].ToString();
                Response.AddHeader("content-disposition", "attachment;filename=" + dr["Name"].ToString());
                Response.Charset = "";
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite((byte[])dr["Data"]);
                Response.End();
            }
        }
    

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}