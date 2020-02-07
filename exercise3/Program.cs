using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            QuerySyntax();
            LambdaSyntax();
        }



        private static void QuerySyntax()
        {
            //specifying the file path
            var files = new DirectoryInfo("c:\\windows").GetFiles();

            //storing specific contents of that directory in a variable
            var results = from f in files
                          where f.Length > 10000
                          orderby f.Length, f.Name
                          //creates a class based on these results
                          select new myFileInfo
                          {
                              Name = f.Name,
                              Length = f.Length,
                              CreationTime = f.CreationTime
                          };
        }
        private static void LambdaSyntax()
        {

        }
    }
}
