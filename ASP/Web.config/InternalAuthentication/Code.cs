//Add
using System.Web.Security;
//On Click
if(FormsAuthentication.Authenticate(TextBox1.Text,TextBox2.Text))
  FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
else
  Label4.Text = "Incorrect username or password!";
