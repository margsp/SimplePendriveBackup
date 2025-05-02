namespace SimplePendriveBackup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var files = new string[][]
            {
                [@"C:\plik1.txt", @"D:\plik1.txt"],
                [@"C:\plik2.txt", @"D:\plik2.txt"],
            };

            foreach(var file in files)
            {
                var source = file.ElementAt(0);
                var destination = file.ElementAt(1);
                Console.WriteLine(string.Format("Backuping {0}\nto {1}", source, destination));
                try
                {
                    File.Copy(source, destination, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Error backuping {0} !\n{1}", source, ex.Message));
                }
            }

            Console.WriteLine("Done. Press any key...");
            Console.ReadKey();
        }
    }
}
