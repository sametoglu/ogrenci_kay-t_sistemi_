using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenci_kayıt_sistemi
{

    // uye address ,kisisel ve aile sınıflarına işaret ediyor.
    public class uye
    {
        public kisisel kisisel = new kisisel();
        public adres adres = new adres();
        public aile aile = new aile();
    }
}
