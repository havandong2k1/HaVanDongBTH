using System.Text.RegularExpressions;
namespace baithuchanh1004.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey ( string strInput )
        {
            string strResult="", numPart="", strPart="";
            numPart=Regex.Match(strInput,@"\d+").Value;
            strPart=Regex.Match(strInput,@"\D+").Value;
            int intPart=(Convert.ToInt32(numPart)+1);
            for (int i=0; i<numPart.Length - intPart.ToString().Length;i++)
            {
                strPart +=0;
            }
            strResult=strPart+intPart;
            return strResult;
        }
        //phuong thuc chuyen chu sang in hoa
        public string LowerToUpper(string strInput)
        {
            //strInput = strInput.ToUpper();
            return (strInput.ToUpper());
        }
        //phuong thuc chuyen chu sang in thuong
        public string UpperToLower(string abc)
        {
            return abc.ToLower();
        }
        public string HelloWord(string fullName)
        {
            return ("Hello " + fullName);
        }
        public int BinhPhuong(int a)
        {
            return a*a;
        }
    }
}