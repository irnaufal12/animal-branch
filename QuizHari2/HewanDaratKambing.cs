using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2
{
    internal class HewanDaratKambing : HewanDarat
    {
        protected string nama = "Kambing";
        public void TampilkanCiri()
        {
            Darat(nama);
        }
    }
}
