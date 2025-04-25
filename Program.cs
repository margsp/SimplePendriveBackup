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
                var destination = file.ElementAt(0);
                File.Copy(source, destination, true);
            }

            Console.WriteLine("Done. Press any key...");
            Console.ReadKey();
        }
    }
}
