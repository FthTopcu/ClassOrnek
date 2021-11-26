using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrnek.Class
{
    class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public UrunKategorileri UrunKategorisi { get; set; }
    }
}
