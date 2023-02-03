using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonParser.Model
{
    [PrimaryKey(nameof(period), nameof(BaslangicTarihi), nameof(BitisTarihi))]
    public class clsAuf
    {
        public DateTime period { get; set; }
        [JsonProperty("startDate")]
        public DateTime BaslangicTarihi { get; set; }
        [JsonProperty("endDate")]
        public DateTime BitisTarihi { get; set; }
        public decimal gopAzamiFiyat { get; set; }
        public decimal dogalGaz { get; set; }
        public decimal ithalKomur { get; set; }
        public decimal yerliKomur { get; set; }
        public decimal diger { get; set; }

    }
}
