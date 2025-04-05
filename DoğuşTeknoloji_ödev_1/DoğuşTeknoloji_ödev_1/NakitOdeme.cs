using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoğuşTeknoloji_ödev_1
{
    public class NakitOdeme : Iodeme

    {
        public string OdemeYap(decimal tutar)
        {
            return $" Nakit ile {tutar} TL ödeme yapıldı.";
        }
    }
}
