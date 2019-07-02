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
	public partial class ProfessorPage : ContentPage
	{
        public ProfessorPage()
        {
            InitializeComponent();        
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker.Items.Clear();
            foreach (Professor professor in Listas.Professores)
            {
                Picker.Items.Add(professor.Nome + " - " + professor.Cpf + " - " + professor.Codigo);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new NovoProfessorPage());
        }

        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new EditarProfessorPage());
        }
    }
}