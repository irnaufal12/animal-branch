using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2
{
    class HewanLaut : Hewan
    {
        protected string nama;

        public void Laut(string nama)
        {
            Bernafas(nama);
            Console.WriteLine($"{nama} ini hewan laut, bergerak berenang");
        }
    }
}
