using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portfolio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Erfaring : ContentPage
    {
        public Erfaring()
        {
            InitializeComponent();
        }
        private void Button_Clicked_Home(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MainPage());
        }
    }
}