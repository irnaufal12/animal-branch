using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2
{
    class Hewan
    {
        protected string nama;
        public void Bernafas(string nama)
        {
            Console.WriteLine($"{nama} ini hewan, {nama} bernafas");
        }
    }
}
