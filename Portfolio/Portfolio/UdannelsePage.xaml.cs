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
    public partial class UdannelsePage : ContentPage
    {
        public UdannelsePage()
        {
            InitializeComponent();
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MainPage());
        }
    }
}