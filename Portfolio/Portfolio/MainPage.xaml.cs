using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Portfolio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UdannelsePage());
        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TidligereProjekter());
        }
        private void Button_Clicked_Erfaring(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Erfaring());
        }
        private void Submit(object sender, EventArgs e)
        {
            Email.ComposeAsync();
        }
        private void Dial(object sender, EventArgs e)
        {
            PhoneDialer.Open("29427965");
        }
    }
}
