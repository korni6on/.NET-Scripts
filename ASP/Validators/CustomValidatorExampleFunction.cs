protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args) 
{ 
  if (TextBox6.Text == "1" && TextBox7.Text=="2") 
    args.IsValid = true; 
  else 
    args.IsValid = false; 
}
