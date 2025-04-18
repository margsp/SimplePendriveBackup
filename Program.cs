namespace SimplePendriveBackup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"C:\plik1.txt";
            string file2 = @"C:\plik2.txt";
            string targetLocation1 = @"D:\plik1.txt";
            string targetLocation2 = @"D:\plik2.txt";

            File.Copy(file1, targetLocation1, true);
            File.Copy(file2, targetLocation2, true);

            Console.WriteLine("Done. Press any key...");
            Console.ReadKey();
        }
    }
}
