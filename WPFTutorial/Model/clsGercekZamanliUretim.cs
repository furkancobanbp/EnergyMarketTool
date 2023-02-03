using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonParser.Model
{
    [PrimaryKey(nameof(Tarih))]
    public class clsGercekZamanliUretim
    {
        [JsonProperty("date")]
        public DateTime Tarih { get; set; }
        [JsonProperty("fuelOil")]
        public decimal FuelOil { get; set; }
        [JsonProperty("gasOil")]
        public decimal GasOil { get; set; }
        [JsonProperty("blackCoal")]
        public decimal TasKomuru { get; set; }
        [JsonProperty("lignite")]
        public decimal Linyit { get; set; }
        [JsonProperty("geothermal")]
        public decimal Jeotermal { get; set; }
        [JsonProperty("naturalGas")]
        public decimal DogalGaz { get; set; }
        [JsonProperty("river")]
        public decimal NehirTipi { get; set; }
        [JsonProperty("dammedHydro")]
        public decimal BarajliHidro { get; set; }        
        public decimal Lng { get; set; }
        [JsonProperty("biomass")]
        public decimal BiyoKutle { get; set; }
        [JsonProperty("naphta")]
        public decimal Nafta { get; set; }
        [JsonProperty("importCoal")]
        public decimal IthalKomur { get; set; }
        [JsonProperty("asphaltiteCoal")]
        public decimal AsfaltitKomur { get; set; }
        [JsonProperty("wind")]
        public decimal Ruzgar { get; set; }
        [JsonProperty("nucklear")]
        public decimal Nukleer { get; set; }
        [JsonProperty("sun")]
        public decimal Gunes { get; set; }
        [JsonProperty("importExport")]
        public decimal TicaretiYapilan { get; set; }
        [JsonProperty("wasteheat")]
        public decimal AtikIsi { get; set; }
        [JsonProperty("total")]
        public decimal Toplam { get; set; }






    }
}
