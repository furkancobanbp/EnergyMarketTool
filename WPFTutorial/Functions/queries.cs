using jsonParser;
using jsonParser.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTutorial.Functions
{
    public class queries
    {
        public List<clsPiyasaFiyatlariModel> piyasaFiyatCek(DateTime basTar, DateTime bitTar)
        {
            String baslangicTarihi = basTar.ToString("dd-MM-yyyy 00:00:00");
            String bitisTarihi = bitTar.ToString("dd-MM-yyyy 23:59:00");

            using (var contex = new context())
            {               
                var Sql = "Select * from \"tblPiyasaFiyatlari\" where \"Tarih\" between '"+ baslangicTarihi + "' and '" + bitisTarihi + "'";
                return contex.tblPiyasaFiyatlari.FromSqlRaw(Sql).ToList();
            }
        }
        
    }
}
