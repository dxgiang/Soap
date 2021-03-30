using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for ConvertNumToString
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class ConvertNumToString : System.Web.Services.WebService
{

    public ConvertNumToString()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }
    [WebMethod]
    public string NumToString(int Number)
    {
        //Viết hàm xử lý sự kiện khi nhập vào số sẽ xuất ra chữ
        //Mảng 1
        string[] Ones = { "Một", "Hai", "Ba", "Bốn",
                        "Năm", "Sáu", "Bảy", "Tám", 
                        "Chín", "Mười", "Mười Một", "Mười Hai",
                        "Mười Ba", "Mười Bốn", "Mười Lăm", "Mười Sáu",
                        "Mười Bảy", "Mười Tám", "Mười Chín"};
        //Mảng 2
        string[] Tens = {"Mười", "Hai Mươi", "Ba Mươi",
                        "Bốn Mươi", "Năm Mươi", "Sáu Mươi",
                        "Bảy Mươi", "Tám Mươi", "Chín Mươi"};
        //
        string strWords = "";

        if(Number > 999 && Number < 10000)
        {
            int i = Number / 1000;
            strWords = strWords + Ones[i - 1] + " Ngàn ";
            Number = Number % 1000;
        }

        if (Number > 99 && Number < 1000)
        {
            int i = Number / 100;
            strWords = strWords + Ones[i - 1] + " Trăm ";
            Number = Number % 100;
        }

        if (Number > 19 && Number < 100)
        {
            int i = Number / 10;
            strWords = strWords + Tens[i - 1] + " ";
            Number = Number % 10;
        }

        if (Number > 0 && Number < 20)
        {
            strWords = strWords + Ones[Number - 1];
        }
        strWords = Convert.ToString(strWords);
        return strWords;
    }
}
