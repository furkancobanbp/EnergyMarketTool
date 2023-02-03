using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonParser.Model
{
    [PrimaryKey(nameof(Tarih),nameof(VeriTipi))]
    public class clsGrf
    {
        [JsonProperty("gasDay")]
        public DateTime Tarih { get; set; }
        [JsonProperty("price")]
        public decimal Fiyat { get; set; }
        public int period { get; set; }
        [JsonProperty("periodType")]
        public String VeriTipi { get; set; }
    }
}
