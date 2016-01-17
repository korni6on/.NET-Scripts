using System.Drawing; 
using System.Drawing.Imaging;
protected void GenerateImage() { 
  string dir = MapPathSecure(TemplateSourceDirectory); 
  Bitmap newBitmap = new Bitmap(200, 150, PixelFormat.Format24bppRgb); 
  Graphics g = Graphics.FromImage(newBitmap); 
  g.FillRectangle(new SolidBrush(Color.Red), 40, 40, 140, 100); 
  g.DrawEllipse(new Pen(Color.Green, 5), 10, 10, 70, 60); 
  newBitmap.Save(dir + "\\TestImage.jpg", ImageFormat.Jpeg); 
  Image1.ImageUrl = "TestImage.jpg"; 
}
