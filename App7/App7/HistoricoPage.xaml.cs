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
	public partial class HistoricoPage : ContentPage
	{
		public HistoricoPage ()
		{
			InitializeComponent ();
		}
        void OnButtonClicked0(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new LançarNotaPage());
        }
        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        void OnButtonClicked3(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}