using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2.Nomor1
{
    class PresidenClass
    {
        protected int id;
        protected string name;
        protected string birthDateString;
        protected DateTime birthDate;
        protected string address;
        protected string phone;
        protected string position;
        protected string namaPerusahaan;
        protected double salary;

        public int Id
        {
            get { return id; } set { id = value; }
        }

        public string Name
        {
            get { return name; } set { name = value; }
        }

        public string BirthDateString
        {
            get { return birthDateString; } set { birthDateString = value; }
        }

        public string Address
        {
            get { return address; } set { address = value; }
        }

        public string Phone
        {
            get { return phone; } set { phone = value; }
        }

        public string NamaPerusahaan { get; set; }

        public DateTime BirthDate { get; set; }

        public double Salary { get; set; }

        public List<string> NamaBawahan { get; set; }
        public List<string> IdBawahan { get; set; }

        public string Position { get; set; }

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
            Console.Write("Nama Perusahaan          : ");
            Console.WriteLine(NamaPerusahaan);
            Console.Write("Alamat                   : ");
            Console.WriteLine(Address);
            Console.Write("No Telp                  : ");
            Console.WriteLine(Phone);
            Console.WriteLine("Manager                  : ");
            Console.Write("             ID          : ");
            foreach (string bawahan in IdBawahan)
            {
                Console.WriteLine(bawahan);
            }
            Console.Write("             Nama        : ");
            foreach(string bawahan in NamaBawahan)
            {
                Console.WriteLine(bawahan);
            }
        } 

        //Masing-masing class memliki properti sebagai berikut :
        //Id - int
        //Name - string
        //BirthDate - string format dd-M-yyyy
        //Address - string
        //Phone - string
        //Position - string
        //Lists(1 atau lebih seusaikan dengan kebutuhan)
    }
}
