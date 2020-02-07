/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 7 / 2 / 2020
 * Description : LAB SHEET TWO CODE SOLUTION, QUESTION 2 - using System.Linq;/Query syntax and Lambda Synta;
 * 
 * ############################# */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuerySyntax();
            var files = new DirectoryInfo("c:\\windows").GetFiles();

            LambdaSyntax(files);

        }

        //private static void QuerySyntax()
        //{
        //    //specifying the file path
        //    var files = new DirectoryInfo("c:\\windows").GetFiles();

        //    //storing specific contents of that directory in a variable
        //    var results = from f in files
        //                  where f.Length > 10000
        //                  orderby f.Length, f.Name
        //                  //creates a class based on these results
        //                  select new myFileInfo
        //                  {
        //                      Name = f.Name,
        //                      Length = f.Length,
        //                      CreationTime = f.CreationTime
        //                  };

        //    //writes the result to the console
        //    foreach (var item in results)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        private static void LambdaSyntax(IEnumerable<FileInfo> files)
        {
            var results = files
                .Where(f => f.Length > 10000)
                .OrderBy(f => f.Length).ThenBy(f => f.Name)
                .Select(f => new myFileInfo()
                {
                    Name = f.Name,
                    Length = f.Length,
                    DOB = f.CreationTime
                });
                

        }
    }//end of class

    public class myFileInfo
    {
        public string Name { get; set; }
        public long Length { get; set; }
        public DateTime DOB { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Length} - {DOB.ToShortDateString()}";
        }
    }
}
