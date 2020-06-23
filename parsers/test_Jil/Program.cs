using System;
using System.IO;
using Jil;

namespace test_Jil
{
    public class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine($"Usage: {Path.GetFileName(Environment.GetCommandLineArgs()[0])} file.json");
                return 1;
            }

            try
            {
                try
                {
                    JSON.Deserialize<object>(File.ReadAllText(args[0]));
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                    return 1;
                }

                return 0;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return 2;
            }
        }
    }
}