using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    public SqlConnection con;
    public string constr;

    public void connection()
    { 
     constr=ConfigurationManager.ConnectionStrings["emp"].ToString();
      con = new SqlConnection(constr);
        con.Open();
    
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        Label1.Visible = false;
    
    
    }

                    private void rep_bind()
                    {
                        connection();
                        string query = "select * from emp where Name like'" + TextBox1.Text + "%'";

                        SqlDataAdapter da = new SqlDataAdapter(query, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        GridView1.DataSource = ds;
                        GridView1.DataBind();
                    }

  
    protected void Button1_Click(object sender, EventArgs e)
    {
        connection();
        string query = "select Name  from emp where Name like'" + TextBox1.Text + "%'";
        SqlCommand com = new SqlCommand(query, con);

        SqlDataReader dr;
        dr = com.ExecuteReader();


        if (dr.HasRows)
        {
            dr.Read();

            rep_bind();
            GridView1.Visible = true;

            TextBox1.Text = "";
            Label1.Text = "";
        }
        else
        {
            GridView1.Visible = false;        
            Label1.Visible = true;
            Label1.Text = "The search Term " + TextBox1.Text + " &nbsp;Is Not Available in the Records"; ;
        
        }



    }
}
