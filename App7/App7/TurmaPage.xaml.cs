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
	public partial class TurmaPage : ContentPage
	{
		public TurmaPage ()
		{
			InitializeComponent ();
		}

        void OnButtonClicked0(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AssociarProfessorPage());
        }
        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new NovaTurmaPage());
        }
        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage()); //EditarTurmaPage()
        }
        void OnButtonClicked3(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}