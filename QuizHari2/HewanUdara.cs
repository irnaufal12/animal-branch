using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2
{
    class HewanUdara : Hewan
    {
        protected string nama;

        public void Udara(string nama)
        {
            Bernafas(nama);
            Console.WriteLine($"{nama} ini hewan udara, bergerak terbang");
        }
    }
}
