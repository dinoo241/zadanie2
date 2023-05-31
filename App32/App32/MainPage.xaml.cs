using App32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Collections;
using Xamarin.Essentials;
using System.Net.Http;

namespace App32
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            data();
        }
        private List<Repository> sList;
        private async void data()
        {
            using (var client = new HttpClient())
            {
                var connect = await client.GetAsync("http://10.0.2.2:3000/data");
                string con = await connect.Content.ReadAsStringAsync();
                sList = JsonConvert.DeserializeObject<List<Repository>>(con);
            }
            for (int i = 0; i < sList.Count; i++)
            {
                chooseStation.Items.Add(sList[i].Stacja);
            }
        }
        private void stacjaINFO(object sender, EventArgs e)
        {
            Repository repo = sList[chooseStation.SelectedIndex];

            nStacja.Text = $"Nazwa stacji: {repo.Stacja}";
            nId.Text = $"id stacji: {repo.Id_stacji}";
            nData.Text = $"Data pomiaru: {repo.Data_pomiaru}";
            nTemperatura.Text = $"Temperatura: {repo.Temperatura} ℃";
            nPredkosc.Text = $"Predkosc wiatru wynosi: {repo.Predkosc_wiatru} km/h";
            nKierunek.Text = $"Kierunek wiatru to: {repo.Kierunek_wiatru}";
            nSuma.Text = $"Suma opadow to: {repo.Temperatura}";
            nCisnienie.Text = $"Cisnienie wynosi: {repo.Cisnienie} hPa";
            nWilgotnosc.Text = $"Wilgotnosc wzgledna wynosi: {repo.Wilgotnosc_wzgledna} %";


        }
    }
}