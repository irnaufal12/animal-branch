using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2.Nomor1
{
    class StaffClass : ManajerClass
    {
        protected string divisi;

        public string Divisi
        {
            get { return divisi; }
            set { divisi = value; }
        }

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
            Console.Write("Nama Divisi              : ");
            Console.WriteLine(Divisi);
            Console.Write("Alamat                   : ");
            Console.WriteLine(Address);
            Console.Write("No Telp                  : ");
            Console.WriteLine(Phone);
        }
    }
}
