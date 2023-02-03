using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonParser.Model
{
    [PrimaryKey(nameof(Tarih), nameof(SonrakiSaat))]
    public class clsDgpTalimatOzet
    {
        [JsonProperty("date")]
        public DateTime Tarih { get; set; }
        [JsonProperty("net")]
        public decimal NetHacim { get; set; }
        [JsonProperty("upRegulationZeroCoded")]
        public decimal YAL0 { get; set; }
        [JsonProperty("upRegulationOneCoded")]
        public decimal YAL1 { get; set; }
        [JsonProperty("upRegulationTwoCoded")]
        public decimal YAL2 { get; set; }
        [JsonProperty("downRegulationZeroCoded")]
        public decimal YAT0 { get; set; }
        [JsonProperty("downRegulationOneCoded")]
        public decimal YAT1 { get; set; }
        [JsonProperty("downRegulationTwoCoded")]
        public decimal YAT2 { get; set; }
        [JsonProperty("upRegulationDelivered")]
        public decimal TeslimEdilenYAL { get; set; }
        [JsonProperty("downRegulationDelivered")]
        public decimal TeslimEdilenYAT { get; set; }
        [JsonProperty("direction")]
        public String SistemYonu { get; set; }
        [JsonProperty("nextHour")]
        public DateTime SonrakiSaat { get; set; }


    }
}
