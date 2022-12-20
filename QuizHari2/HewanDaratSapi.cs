using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2
{
    internal class HewanDaratSapi : HewanDarat
    {
        protected string nama = "Kambing";
        public void TampilkanCiri()
        {
            Darat(nama);
        }
    }
}
