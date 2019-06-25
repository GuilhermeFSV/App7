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
    public partial class LançarNotaPage : ContentPage
    {
        public LançarNotaPage()
        {
            InitializeComponent();
        }
        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MatriculaPage());

        }
        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MatriculaPage());
        }
    }
}