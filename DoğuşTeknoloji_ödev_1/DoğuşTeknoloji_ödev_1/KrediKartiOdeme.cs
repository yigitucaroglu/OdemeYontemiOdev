using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoğuşTeknoloji_ödev_1
{
    
    
      public class KrediKartiOdeme : Iodeme
        {
            public string OdemeYap(decimal tutar)
            {
                return $"Kredi Kartı il {tutar} TL ödeme yapıldı";
            }
        }
    }

