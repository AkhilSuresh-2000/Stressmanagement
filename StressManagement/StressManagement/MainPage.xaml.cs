using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using Xamarin.Forms;
using Newtonsoft.Json;
using StressManagement.Model;

namespace StressManagement
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }



        private async void navigatetoNews_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new NewsPage());

        }

        private async void checkStress_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckStressPage());
        }

    }  
}
