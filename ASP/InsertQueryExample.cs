OleDbDataAdapter prodAdapter = new OleDbDataAdapter("Insert Into Products(Product, Price) Values('" + TextBox3.Text + "','" + TextBox4.Text + "')", SqlDataSource1.ConnectionString);
prodAdapter.Fill(new DataSet());
DropDownList1.DataBind();
GridView1.DataBind();
