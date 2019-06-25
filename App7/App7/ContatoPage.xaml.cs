using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App7.Modelos;

namespace App7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContatoPage : ContentPage
    {
        public ContatoPage()
        {
            InitializeComponent();
        }
        void OnButtonClicked0(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AssociarFamiliaPage());
        }
        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AssociarEndereçoPage());
        }
        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AssociarInternetPage());
        }
        void OnButtonClicked3(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AssociarTelefonePage());
        }
        void OnButtonClicked4(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        void OnButtonClicked5(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        void OnButtonClicked6(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }

    }
}
