namespace QuizHari2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HewanDaratKambing hewanDaratKambing = new HewanDaratKambing();
            hewanDaratKambing.TampilkanCiri();
            Console.WriteLine();

            HewanLautHiu hewanLautHiu = new HewanLautHiu();
            hewanLautHiu.TampilkanCiri();
            Console.WriteLine();

            HewanUdaraBeo hewanUdaraBeo = new HewanUdaraBeo();
            hewanUdaraBeo.TampilkanCiri();
            Console.WriteLine();
        }
    }
}
