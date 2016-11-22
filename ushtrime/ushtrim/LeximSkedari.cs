using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
namespace ushtrim
{
   public class LeximSkedari
    {
        XmlDocument doc = new XmlDocument();
        public string toEmail;
        public string fromEmail;
        public string subject;
        public string body;
        public LeximSkedari()
        {
             
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\Users\\idinja\\Desktop\\New folder\\ushtrim\\ushtrim\\skedar.xml");
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/email");
            
            foreach (XmlNode node in nodeList)
            {
                toEmail = node.SelectSingleNode("to").InnerText;
                fromEmail = node.SelectSingleNode("from").InnerText;
                subject = node.SelectSingleNode("subject").InnerText;
                body = node.SelectSingleNode("body").InnerText;
               
            }
        }
        
        


    }
}
