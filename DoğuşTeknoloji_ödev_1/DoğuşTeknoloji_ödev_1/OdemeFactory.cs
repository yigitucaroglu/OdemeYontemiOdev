using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace DoğuşTeknoloji_ödev_1;

    public class OdemeFactory
{
    public static Iodeme CreateOdeme(string odemeTipi)
    {
        string className = odemeTipi + "Odeme"; 
        var type = Assembly.GetExecutingAssembly().GetTypes()
            .FirstOrDefault(t => t.Name.Equals(className, StringComparison.OrdinalIgnoreCase));

        if (type != null)
        {
            return (Iodeme)Activator.CreateInstance(type);
        }

        throw new Exception("Geçersiz ödeme tipi!");
    }
}
