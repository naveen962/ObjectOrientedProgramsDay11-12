using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StockManagement
{
    class FetchJson
    {
        public Stock Read(string path)
        {
            using (StreamReader file=new StreamReader(path))
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Stock>(json);
                
            
                }
                catch(Exception e)
                {
                    Console.WriteLine("problem occured");
                    return null;
                }
        }
    }
}
