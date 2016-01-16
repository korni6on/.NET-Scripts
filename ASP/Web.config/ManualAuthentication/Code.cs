//Add
using System.Web.Security;
//On click
if(TextBox1.Text==user && TextBox2.Text==pass)
  FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
else
  Label4.Text = "Incorrect username or password!";
