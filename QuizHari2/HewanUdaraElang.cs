using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2
{
    internal class HewanUdaraElang : HewanUdara
    {
        protected string nama = "Elang";
        public void TampilkanCiri()
        {
            Udara(nama);
        }
    }
}
