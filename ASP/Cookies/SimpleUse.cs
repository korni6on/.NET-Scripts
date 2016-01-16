HttpCookie MyCookie = New HttpCookie("MyCookieName");
MyCookie.Value = "MyValue";
Response.Cookies.Add(MyCookie);
string myVariable = Response.Cookies["MyCookieName"].Value;
MyCookie.Expires = DateTime.Now.AddDays(2);
Response.Cookies.Remove("MyCookieName");
