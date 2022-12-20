using Microsoft.VisualBasic;
using QuizHari2.Nomor1;
using System.Net;
using System.Runtime.Serialization;

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

            //PresidenClass presidenClass = new PresidenClass();
            //presidenClass.Name = "Nama Presiden";
            //presidenClass.Address = "Alamat Presiden";
            //presidenClass.BirthDate = "dd/MM/yyyy";

            //Console.WriteLine(presidenClass.Name);
            //Console.WriteLine(presidenClass.getPosition());
            //Console.WriteLine(presidenClass.Address);
            //Console.WriteLine(presidenClass.BirthDate);

            //ManajerClass manajerITClass = new ManajerClass();
            //manajerITClass.Name= "Nama Manajer IT";
            //manajerITClass.Address = "Alamat";
            //manajerITClass.BirthDate = "dd/MM/yyyy";

            //Console.WriteLine();
            //Console.WriteLine(manajerITClass.Name);
            //Console.WriteLine(manajerITClass.getPosition());
            //Console.WriteLine(manajerITClass.Address);
            //Console.WriteLine(manajerITClass.BirthDate);

            //List<StaffClass> programmerClassLists = new List<StaffClass>();
            //programmerClassLists.Add(new StaffClass()
            //{
            //    Name = "Nama Programmer",
            //    Address = "Alamat",
            //    BirthDate = "dd/MM/yyyy"
            //});

            //foreach (StaffClass programmerClassList in programmerClassLists)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(programmerClassList.Name);
            //    Console.WriteLine(programmerClassList.getPosition());
            //    Console.WriteLine(programmerClassList.Address);
            //    Console.WriteLine(programmerClassList.BirthDate);
            //}


            //ManajerSalesClass manajerSalesClass = new ManajerSalesClass();
            //manajerSalesClass.Name = "Nama Manajer Sales";
            //manajerSalesClass.Address = "Alamat";
            //manajerSalesClass.BirthDate = "dd/MM/yyyy";

            //Console.WriteLine();
            //Console.WriteLine(manajerSalesClass.Name);
            //Console.WriteLine(manajerSalesClass.getPosition());
            //Console.WriteLine(manajerSalesClass.Address);
            //Console.WriteLine(manajerSalesClass.BirthDate);

            //List<SalesClass> salesClassLists = new List<SalesClass>();
            //salesClassLists.Add(new SalesClass()
            //{
            //    Name = "Nama Sales",
            //    Address = "Alamat Sales",
            //    BirthDate = "dd/MM/yyyy"
            //});

            //foreach (SalesClass salesClassList in salesClassLists)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(salesClassList.Name);
            //    Console.WriteLine(salesClassList.getPosition());
            //    Console.WriteLine(salesClassList.Address);
            //    Console.WriteLine(salesClassList.BirthDate);
            //}

            List<StaffClass> staffClassList = new List<StaffClass>();
            staffClassList.Add(new StaffClass()
            {
                Name = "Staff 1",
                Position = "Programmer",
                Divisi = "IT",
                Phone = "24723942191",
                Salary = 50989,
                Address = "Jalan Staff 1",
                BirthDate = Convert.ToDateTime("11-09-1999"),
                BirthDateString = "11-09-1999",
                Id = 323
            });

            List<string> NamaBawahanManajerList = new List<string>();
            foreach(StaffClass staffClass in staffClassList)
            {
                NamaBawahanManajerList.Add(staffClass.Name);
            }

            List<string> IdBawahanManajerList = new List<string>();
            foreach (StaffClass staffClass in staffClassList)
            {
                IdBawahanManajerList.Add(Convert.ToString(staffClass.Id));
            }

            List<StaffClass> staffClassList2 = new List<StaffClass>();
            staffClassList2.Add(new StaffClass()
            {
                Name = "Staff 2",
                Position = "Sales",
                Divisi = "Marketing",
                Phone = "24723942191",
                Salary = 50989,
                Address = "Jalan Staff 2",
                BirthDate = Convert.ToDateTime("11-09-1999"),
                BirthDateString = "11-09-1999",
                Id = 333
            });

            List<string> NamaBawahanManajerList2 = new List<string>();
            foreach (StaffClass staffClass in staffClassList2)
            {
                NamaBawahanManajerList2.Add(staffClass.Name);
            }

            List<string> IdBawahanManajerList2 = new List<string>();
            foreach (StaffClass staffClass in staffClassList2)
            {
                IdBawahanManajerList2.Add(Convert.ToString(staffClass.Id));
            }

            List<StaffClass> staffClassList3 = new List<StaffClass>();
            staffClassList2.Add(new StaffClass()
            {
                Name = "Staff 3",
                Position = "Accountant",
                Divisi = "Finance",
                Phone = "24723942191",
                Salary = 50989,
                Address = "Jalan Staff 3",
                BirthDate = Convert.ToDateTime("11-09-1999"),
                BirthDateString = "11-09-1999",
                Id = 233
            });

            List<string> NamaBawahanManajerList3 = new List<string>();
            foreach (StaffClass staffClass in staffClassList3)
            {
                NamaBawahanManajerList3.Add(staffClass.Name);
            }

            List<string> IdBawahanManajerList3 = new List<string>();
            foreach (StaffClass staffClass in staffClassList3)
            {
                IdBawahanManajerList3.Add(Convert.ToString(staffClass.Id));
            }



            //StaffClass staffClass = new StaffClass();
            //staffClass.Name = "Staff 1";
            //staffClass.Position = "Programmer";
            //staffClass.Salary = 50989;
            //staffClass.Address = "Jalan Staff 1";
            //staffClass.BirthDate = Convert.ToDateTime("11-09-1999");
            //staffClass.BirthDateString = "11-09-1999";
            //staffClass.Id = 323;

            List<ManajerClass> manajerClassList = new List<ManajerClass>();
            manajerClassList.Add(new ManajerClass()
            {
                Name = "Manajer 1",
                Position = "Manajer",
                Salary = 100989,
                ManagerType = "IT",
                Phone = "09773728818",
                NamaBawahan = NamaBawahanManajerList,
                IdBawahan = IdBawahanManajerList,
                Address = "Jalan Manajer 1",
                BirthDate = Convert.ToDateTime("10-09-1999"),
                BirthDateString = "10-09-1999",
                Id = 223
            });

            List<string> NamaBawahanPresidenList = new List<string>();
            foreach(ManajerClass manajerClass in manajerClassList)
            {
                NamaBawahanPresidenList.Add(manajerClass.Name);
            };

            List<string> IdBawahanPresidenList = new List<string>();
            foreach (ManajerClass manajerClass in manajerClassList)
            {
                IdBawahanPresidenList.Add(Convert.ToString(manajerClass.Id));
            };

            List<ManajerClass> manajerClassList2 = new List<ManajerClass>();
            manajerClassList2.Add(new ManajerClass()
            {
                Name = "Manajer 2",
                Position = "Manajer",
                Salary = 100989,
                ManagerType = "Marketing",
                Phone = "09773728818",
                NamaBawahan = NamaBawahanManajerList2,
                IdBawahan = IdBawahanManajerList2,
                Address = "Jalan Manajer 2",
                BirthDate = Convert.ToDateTime("10-09-1999"),
                BirthDateString = "10-09-1999",
                Id = 209
            });

            List<string> NamaBawahanPresidenList2 = new List<string>();
            foreach (ManajerClass manajerClass in manajerClassList2)
            {
                NamaBawahanPresidenList2.Add(manajerClass.Name);
            };

            List<string> IdBawahanPresidenList2 = new List<string>();
            foreach (ManajerClass manajerClass in manajerClassList2)
            {
                IdBawahanPresidenList2.Add(Convert.ToString(manajerClass.Id));
            };


            List<ManajerClass> manajerClassList3 = new List<ManajerClass>();
            manajerClassList3.Add(new ManajerClass()
            {
                Name = "Manajer 3",
                Position = "Manajer",
                Salary = 100989,
                ManagerType = "Finance",
                Phone = "09773728818",
                NamaBawahan = NamaBawahanManajerList3,
                IdBawahan = IdBawahanManajerList3,
                Address = "Jalan Manajer 3",
                BirthDate = Convert.ToDateTime("10-09-1999"),
                BirthDateString = "10-09-1999",
                Id = 200
            });

            List<string> NamaBawahanPresidenList3 = new List<string>();
            foreach (ManajerClass manajerClass in manajerClassList3)
            {
                NamaBawahanPresidenList3.Add(manajerClass.Name);
            };

            List<string> IdBawahanPresidenList3 = new List<string>();
            foreach (ManajerClass manajerClass in manajerClassList3)
            {
                IdBawahanPresidenList3.Add(Convert.ToString(manajerClass.Id));
            };

            PresidenClass presidenClass = new PresidenClass();
            presidenClass.Name = "Presiden 1";
            presidenClass.Position = "Presiden";
            presidenClass.Salary = 19800989;
            presidenClass.NamaPerusahaan = "I<3COFFEE";
            presidenClass.NamaBawahan = NamaBawahanPresidenList;
            presidenClass.IdBawahan = IdBawahanPresidenList;
            presidenClass.Address = "Jalan Presiden 1";
            presidenClass.Phone = "09773728818";
            presidenClass.BirthDate = Convert.ToDateTime("12-09-1999");
            presidenClass.BirthDateString = "12-09-1999";
            presidenClass.Id = 123;

            PresidenClass presidenClass2 = new PresidenClass();
            presidenClass2.Name = "Presiden 2";
            presidenClass2.Position = "Presiden";
            presidenClass2.Salary = 19800989;
            presidenClass2.NamaPerusahaan = "I<3TEA";
            presidenClass2.NamaBawahan = NamaBawahanPresidenList2;
            presidenClass2.IdBawahan = IdBawahanPresidenList2;
            presidenClass2.Address = "Jalan Presiden 2";
            presidenClass2.Phone = "09773728818";
            presidenClass2.BirthDate = Convert.ToDateTime("12-09-1999");
            presidenClass2.BirthDateString = "12-09-1999";
            presidenClass2.Id = 222;

            PresidenClass presidenClass3 = new PresidenClass();
            presidenClass3.Name = "Presiden 3";
            presidenClass3.Position = "Presiden";
            presidenClass3.Salary = 19800989;
            presidenClass3.NamaPerusahaan = "I<3TEA";
            presidenClass3.NamaBawahan = NamaBawahanPresidenList3;
            presidenClass3.IdBawahan = IdBawahanPresidenList3;
            presidenClass3.Address = "Jalan Presiden 3";
            presidenClass3.Phone = "09773728818";
            presidenClass3.BirthDate = Convert.ToDateTime("12-09-1999");
            presidenClass3.BirthDateString = "12-09-1999";
            presidenClass3.Id = 111;


            presidenClass.Introduction();
            presidenClass2.Introduction();
            presidenClass3.Introduction();

            foreach(ManajerClass manajerClass1 in manajerClassList)
            {
                manajerClass1.Introduction();
            }

            foreach (StaffClass staffClass1 in staffClassList)
            {
                staffClass1.Introduction();
            }






        }
    }
}
