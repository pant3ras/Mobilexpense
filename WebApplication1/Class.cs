﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.webservices;
/// <summary>  
/// used for Airthmatic calculation  
/// </summary>  
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.  
// [System.Web.Script.Services.ScriptService]  
public class Airthmatic : System.Web.Services.WebService
{
    public Airthmatic()
    {
        //Uncomment the following line if using designed components  
        //InitializeComponent();  
    }
    [WebMethod]
    public int Add(int x, int y)
    {
        return x + y;
    }
    [WebMethod]
    public int Sub(int x, int y)
    {
        return x - y;
    }
    [WebMethod]
    public int Mul(int x, int y)
    {
        return x * y;
    }
    [WebMethod]
    public int Div(int x, int y)
    {
        return x / y;
    }
}
