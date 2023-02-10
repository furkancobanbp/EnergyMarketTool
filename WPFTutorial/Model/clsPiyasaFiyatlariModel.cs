using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTutorial;

namespace jsonParser.Model
{
    [PrimaryKey(nameof(Tarih))]
    public class clsPiyasaFiyatlariModel:SistemYonu
    {
        [JsonProperty("date")]
        public DateTime Tarih { get; set; }
        [JsonProperty("mcp")]
        public decimal? PTF { get; set; }
        [JsonProperty("smp")]
        public decimal? SMF { get; set; }
        [JsonProperty("smpDirection")]
        public String? SistemYonu { get; set; }
    }
}
