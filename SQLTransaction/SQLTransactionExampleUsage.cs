SqlConnection mySqlCon = new SqlConnection("server=localhost; database=stud; integrated security=true");
mySqlCon.Open();
SqlTransaction myTrans;
myTrans = mySqlCon.BeginTransaction();
//code
myTrans.Commit(); //or use myTrans.Rollback();
mySqlCon.Close();
