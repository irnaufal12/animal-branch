using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2
{
    class HewanDarat : Hewan
    {
        protected string nama;

        public void Darat(string nama)
        {
            Bernafas(nama);
            Console.WriteLine($"{nama} ini hewan darat, bergerak berjalan");
        }
    }
}
