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
        protected string birthDate;
        protected string address;
        protected string phone;
        protected string position;

        public PresidenClass()
        {
            this.position = "Presiden";
        }

        public string getPosition()
        {
            return this.position;
        }

        public int Id
        {
            get { return id; } set { id = value; }
        }

        public string Name
        {
            get { return name; } set { name = value; }
        }

        public string BirthDate
        {
            get { return birthDate; } set { birthDate = value; }
        }

        public string Address
        {
            get { return address; } set { address = value; }
        }

        public string Phone
        {
            get { return phone; } set { phone = value; }
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
