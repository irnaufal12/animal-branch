using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2.Nomor1
{
    class ManajerClass : PresidenClass
    {
        protected string managerType;

        public string ManagerType { get; set; }

        public virtual void Introduction()
        {
            Console.WriteLine();
            Console.Write("Nama                     : ");
            Console.WriteLine(Name);
            Console.Write("ID                       : ");
            Console.WriteLine(Id);
            Console.Write("Position                 : ");
            Console.WriteLine(Position);
            Console.Write("Tgl Lahir                : ");
            Console.WriteLine(BirthDateString);
            Console.Write("Gaji                     : ");
            Console.WriteLine(Salary);
            Console.Write("Manager Type             : ");
            Console.WriteLine(ManagerType);
            Console.Write("Alamat                   : ");
            Console.WriteLine(Address);
            Console.Write("No Telp                  : ");
            Console.WriteLine(Phone);
            Console.WriteLine("Staff                  : ");
            Console.Write("             ID          : ");
            foreach (string bawahan in IdBawahan)
            {
                Console.WriteLine(bawahan);
            }
            Console.Write("             Nama        : ");
            foreach (string bawahan in NamaBawahan)
            {
                Console.WriteLine(bawahan);
            }
        }
    }
}
