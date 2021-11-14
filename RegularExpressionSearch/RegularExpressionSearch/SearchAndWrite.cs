using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace RegularExpressionSearch
{
    public class  SearchAndWrite
    {
       
        
        public SearchAndWrite(string path, string pathT)
        {
            StreamWriter sw = new(pathT);
            Regex reg = new Regex(@"(\d{4}-\d{2}-\d{2})\s(\d{2}:\d{2}:\d{2}.\d{4}).*?Request for.*?(\d{5}_\d{1,5}_\d{1,2}_\w*)");
            MatchCollection match = reg.Matches(path);

            foreach (Match item in match)
            {
                Console.WriteLine(item.Groups[1].Value + item.Groups[2] + item.Groups[3]);
                sw.WriteLine(item.Groups[1].Value + "\t" + item.Groups[2] + "\t" + item.Groups[3]);
            }
            sw.Close();

        }
    }
}

