//Add FileUpload control in form and use this code 

String dirPath = Server.MapPath(".") + "\\images";
if(!System.IO.Directory.Exists(dirPath))
{
    System.IO.Directory.CreateDirectory(dirPath);
}
if (FileUpload1.HasFile)
{
    FileUpload1.SaveAs(dirPath + "\\temp."+System.IO.Path.GetExtension(FileUpload1.FileName));
}
