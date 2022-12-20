using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHari2
{
    internal class HewanUdaraBeo : HewanUdara
    {
        protected string nama = "Beo";
        public void TampilkanCiri()
        {
            Udara(nama);
        }
    }
}
