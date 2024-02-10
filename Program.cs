
namespace HW_CSharp_3._8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                var res = FindFile.find(Directory.GetCurrentDirectory(), args[0], args[1]);
                foreach (var file in res)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}