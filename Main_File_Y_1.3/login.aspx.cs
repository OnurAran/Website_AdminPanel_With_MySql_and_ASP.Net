using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yazlab1_3.v._1
{
    public SqlConnection con;
    public string constr;
    public string query;
    public MySqlCommand com;
    public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=web;Uid=root;Pwd='123456';");
    MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
    MySqlConnection MyCon;

    public void connection()
    {
        //constr = ConfigurationManager.ConnectionStrings["emp"].ToString();
        //con = new SqlConnection(constr);

        conn_string.Server = "localhost";
        conn_string.Port = 3306;
        conn_string.UserID = "root";
        conn_string.Password = "123456";
        conn_string.Database = "web";
        MyCon = new MySqlConnection(conn_string.ToString());


        MyCon.Open();

    }
    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

}