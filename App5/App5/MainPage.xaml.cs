using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public Database Database { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Database = new Database();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstPage(Database));
        }

        

    }
   
}