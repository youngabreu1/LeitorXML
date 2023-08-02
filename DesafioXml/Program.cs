using DesafioXml.util;
class Program
{
    static void Main(string[] args)
    {
        Insercao ledor = new Insercao(@"C:\qualquercoisaqcquiser\26-07-2023.xml");
        ledor.print_ins();

    }
}