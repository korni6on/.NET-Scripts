string connetionString = null;
OleDbConnection connection;
OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();
DataSet ds = new DataSet();
int i = 0;
connetionString = SqlDataSource1.ConnectionString;
connection = new OleDbConnection(connetionString);
try
{
    connection.Open();
    oledbAdapter.SelectCommand = new OleDbCommand("SELECT * FROM products", connection);
    oledbAdapter.Fill(ds);
    oledbAdapter.Dispose();
    connection.Close();
    foreach (DataRow r in ds.Tables[0].Rows)
    {
        if (r[0].ToString() == DropDownList1.SelectedValue)
        {
            TextBox2.Text = r[2].ToString();
            break;
        }
    }
}
catch (Exception ex)
{
}
//variant 2
TextBox1.Text = DropDownList1.SelectedValue;
OleDbDataAdapter prodAdapter = new OleDbDataAdapter("SELECT * FROM Products WHERE productid=" + DropDownList1.SelectedValue, SqlDataSource1.ConnectionString); 

DataSet ds = new DataSet(); 
prodAdapter.Fill(ds, "products"); 
TextBox2.Text = ds.Tables[0].Rows[0][2].ToString();
