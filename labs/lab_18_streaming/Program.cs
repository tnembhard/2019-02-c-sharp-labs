using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_18_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<String>();
            // not using streaming : writing directly
            string File01 = File.ReadAllText("data.txt");


            // StreamReader
            // Create StreamReader Object
            // Enclose in 'using' block (complete 'cleanup' afterwards)
            // ReadLine() stream and read line by line


            // Path as a variable
            // path01 is relative path
            string path01 = "data.txt";
            // path02 is absolute path
            string path02 = "C:/data/data.txt";
            // using 'escape' characters /t=tabe /n new line
            // \' will print one single apostrophe
            string path03 = "C:\\data\\data.txt";
            // @ means treat the following string literally
            string path04 = @"C:\data\data.txt";
            // Enviroment variable : my documents path
            string path05 = Environment.ExpandEnvironmentVariables("%userprofile%" + "\\Documents\\data.txt");
            Console.WriteLine(path05);
            string path06 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\data.txt";
            using (var reader = new StreamReader(path06)) 
            {
                string output;
                // read every line
                // output to string
                // test each time that the string is not null
                // continue looping until out of data
                while ((output=reader.ReadLine())!=null)
                {
                    list.Add(output);
                }
            }
            list.ForEach(output => Console.WriteLine(output));
            // StreamWriter
        }
    }
}
