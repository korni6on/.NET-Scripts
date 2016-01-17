TableRow r1 = new TableRow(); 
TableRow r2 = new TableRow(); 

Table1.Rows.Add(r1); 
able1.Rows.Add(r2);

TableCell c1, c2, c3, c4; 
c1 = new TableCell(); 
c1.Text = "First"; 
c2 = new TableCell(); 
c2.Text = "Second"; 
c3 = new TableCell(); 
c3.Text = "Third"; 
c4 = new TableCell(); 
c4.Text = "Fourth";

Table1.Rows[0].Cells.Add(c1); 
Table1.Rows[0].Cells.Add(c2); 
Table1.Rows[1].Cells.Add(c3); 
Table1.Rows[1].Cells.Add(c4);
