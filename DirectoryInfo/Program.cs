class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo di = new DirectoryInfo(@"E:\PRN212\ReadFile\DirectoryInfo");
        Console.WriteLine("Search pattern returns:");
        foreach (var fi in di.GetDirectories())
        {
            Console.WriteLine(fi.Name);
        }
        Console.WriteLine();
        Console.WriteLine("Search pattern TopDirectoryOnly returns:");
        foreach (var fi in di.GetFiles("*.cs", SearchOption.TopDirectoryOnly))
        {
            Console.WriteLine(fi.Name);
        }
        Console.ReadLine();
    }
}