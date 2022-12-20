using QuizHari2.Nomor1;

namespace QuizHari2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HewanDaratKambing hewanDaratKambing = new HewanDaratKambing();
            //hewanDaratKambing.TampilkanCiri();
            //Console.WriteLine();

            //HewanLautHiu hewanLautHiu = new HewanLautHiu();
            //hewanLautHiu.TampilkanCiri();
            //Console.WriteLine();

            //HewanUdaraBeo hewanUdaraBeo = new HewanUdaraBeo();
            //hewanUdaraBeo.TampilkanCiri();
            //Console.WriteLine();

            PresidenClass presidenClass = new PresidenClass();
            presidenClass.Name = "Nama Presiden";
            presidenClass.Address = "Alamat Presiden";
            presidenClass.BirthDate = "dd-MM-yy";

            Console.WriteLine(presidenClass.Name);
            Console.WriteLine(presidenClass.getPosition());
            Console.WriteLine(presidenClass.Address);
            Console.WriteLine(presidenClass.BirthDate);

            ManajerITClass manajerITClass = new ManajerITClass();
            manajerITClass.Name= "Nama Manajer";
            manajerITClass.Address = "Alamat";
            manajerITClass.BirthDate = "dd-MM-yy";

            Console.WriteLine();
            Console.WriteLine(manajerITClass.Name);
            Console.WriteLine(manajerITClass.getPosition());
            Console.WriteLine(manajerITClass.Address);
            Console.WriteLine(manajerITClass.BirthDate);

            ProgrammerClass programmerClass = new ProgrammerClass();
            programmerClass.Name = "Nama Programmer";
            programmerClass.Address = "Alamat";
            programmerClass.BirthDate = "dd-MM-yy";

            Console.WriteLine();
            Console.WriteLine(programmerClass.Name);
            Console.WriteLine(programmerClass.getPosition());
            Console.WriteLine(programmerClass.Address);
            Console.WriteLine(programmerClass.BirthDate);

        }
    }
}
