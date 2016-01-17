OleDbConnection scon = new OleDbConnection(SqlDataSource1.ConnectionString); 
scon.Open();
OleDbCommand cmd = new OleDbCommand("DELETE FROM products WHERE productid=" + DropDownList1.SelectedValue, scon); 
cmd.ExecuteNonQuery(); 
scon.Close(); 
DropDownList1.DataBind();
GridView1.DataBind();
