using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Lib
{
    [PluginType(".base64")]
    public class CodingAlgorithms
    {
        public static void Encode(string filePath)
        {
            string mystr = "";
            using (StreamReader br = new StreamReader(filePath,Encoding.UTF8))
            {
                mystr = br.ReadToEnd();
            }

            byte[] toEncodeAsBytes= Encoding.UTF8.GetBytes(mystr);

            mystr = Convert.ToBase64String(toEncodeAsBytes);
            File.Delete(filePath);
            filePath += ".base64";

            using (StreamWriter sr = new StreamWriter(filePath,false,Encoding.UTF8))
            {
                sr.Write(mystr);
            }
        }

        public static void Decode(string filePath)
        {
            string mystr = "";
            using (StreamReader br = new StreamReader(filePath, Encoding.UTF8))
            {
                mystr = br.ReadToEnd();
            }
            byte[] encodedDataAsBytes = Convert.FromBase64String(mystr);
            mystr = Encoding.UTF8.GetString(encodedDataAsBytes);
            
            File.Delete(filePath);
            filePath = filePath.Substring(0, filePath.Length - 7);

            using (StreamWriter sr = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                sr.Write(mystr);
            }
        }

    }

}
