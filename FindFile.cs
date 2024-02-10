using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CSharp_3._8
{
    internal class FindFile
    {
        public static List<string> find(string path, string extension, string text)
        {
            var res = new List<string>();
            var res2 = new List<string>();
            var dirs = Directory.GetDirectories(path: path);
            foreach(var dir in dirs)
            {
                res = res.Concat(findInFile(dir, extension, text)).ToList();
                res = res.Concat(find(dir, extension, text)).ToList();

            }
            return res;
        }

        private static List<string> findInFile(string path, string extension, string text) {
            var res = new List<string>();
            var files = Directory.GetFiles(path, "*." + extension);
            foreach (var file in files)
            {
                using(var sr = new StreamReader(file))
                {
                    while (!sr.EndOfStream)
                    {
                        if (sr.ReadLine().Contains(text))
                        {
                            res.Add(file);
                            break;
                        }
                    }

                }
            }
            return res;
        }
    }
}
