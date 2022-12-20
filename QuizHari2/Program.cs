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
            presidenClass.BirthDate = "dd/MM/yyyy";

            Console.WriteLine(presidenClass.Name);
            Console.WriteLine(presidenClass.getPosition());
            Console.WriteLine(presidenClass.Address);
            Console.WriteLine(presidenClass.BirthDate);

            ManajerITClass manajerITClass = new ManajerITClass();
            manajerITClass.Name= "Nama Manajer IT";
            manajerITClass.Address = "Alamat";
            manajerITClass.BirthDate = "dd/MM/yyyy";

            Console.WriteLine();
            Console.WriteLine(manajerITClass.Name);
            Console.WriteLine(manajerITClass.getPosition());
            Console.WriteLine(manajerITClass.Address);
            Console.WriteLine(manajerITClass.BirthDate);

            List<ProgrammerClass> programmerClassLists = new List<ProgrammerClass>();
            programmerClassLists.Add(new ProgrammerClass()
            {
                Name = "Nama Programmer",
                Address = "Alamat",
                BirthDate = "dd/MM/yyyy"
            });

            foreach (ProgrammerClass programmerClassList in programmerClassLists)
            {
                Console.WriteLine();
                Console.WriteLine(programmerClassList.Name);
                Console.WriteLine(programmerClassList.getPosition());
                Console.WriteLine(programmerClassList.Address);
                Console.WriteLine(programmerClassList.BirthDate);
            }


            ManajerSalesClass manajerSalesClass = new ManajerSalesClass();
            manajerSalesClass.Name = "Nama Manajer Sales";
            manajerSalesClass.Address = "Alamat";
            manajerSalesClass.BirthDate = "dd/MM/yyyy";

            Console.WriteLine();
            Console.WriteLine(manajerSalesClass.Name);
            Console.WriteLine(manajerSalesClass.getPosition());
            Console.WriteLine(manajerSalesClass.Address);
            Console.WriteLine(manajerSalesClass.BirthDate);

            List<SalesClass> salesClassLists = new List<SalesClass>();
            salesClassLists.Add(new SalesClass()
            {
                Name = "Nama Sales",
                Address = "Alamat Sales",
                BirthDate = "dd/MM/yyyy"
            });

            foreach (SalesClass salesClassList in salesClassLists)
            {
                Console.WriteLine();
                Console.WriteLine(salesClassList.Name);
                Console.WriteLine(salesClassList.getPosition());
                Console.WriteLine(salesClassList.Address);
                Console.WriteLine(salesClassList.BirthDate);
            }


        }
    }
}
