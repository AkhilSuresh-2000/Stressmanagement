using Newtonsoft.Json;
using StressManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StressManagement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
            loadArticle();
        }

       

        public async void loadArticle()
        {
            string url = "https://newsapi.org/v2/top-headlines?country=ca&category=health&apiKey=2df3f394b9eb49c7824d131c90d57bd4";
            using (HttpClient client = new HttpClient())
            {
                var respond = client.GetAsync(url).Result;
                if (respond.IsSuccessStatusCode)
                {
                    var content = await respond.Content.ReadAsStringAsync();
                    var articles = JsonConvert.DeserializeObject<HealthNews>(content);

                     HealthNews news = new HealthNews();
                    articleCarouselView.ItemsSource = articles.articles;
                }
                else
                {
                    Console.WriteLine("Error");
                }


            }
        }

        private void articleCarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {

        }
    }
}