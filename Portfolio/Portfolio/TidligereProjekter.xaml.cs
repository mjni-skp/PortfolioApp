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
    public partial class TidligereProjekter : ContentPage
    {
        public TidligereProjekter()
        {
            InitializeComponent();
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Projekt());
        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MainPage());
        }
    }
}