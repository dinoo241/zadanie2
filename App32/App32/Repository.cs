using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace App32
{
    public class Repository
    {
        [JsonProperty("stacja")]
        public string Stacja { get; set; }

        [JsonProperty("id_stacji")]
        public string Id_stacji { get; set; }

        [JsonProperty("data_pomiaru")]
        public string Data_pomiaru { get; set; }

        [JsonProperty("temperatura")]
        public string Temperatura { get; set; }

        [JsonProperty("predkosc_wiatru")]
        public string Predkosc_wiatru { get; set; }

        [JsonProperty("kierunek_wiatru")]
        public string Kierunek_wiatru { get; set; }

        [JsonProperty("suma_opadu")]
        public string Suma_opadu { get; set; }

        [JsonProperty("cisnienie")]
        public string Cisnienie { get; set; }

        [JsonProperty("wilgotnosc_wzgledna")]
        public string Wilgotnosc_wzgledna { get; set; }
    }
}