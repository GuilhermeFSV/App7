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
	public partial class AssociarProfessorPage : ContentPage
	{
		public AssociarProfessorPage ()
		{
			InitializeComponent ();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker.Items.Clear();
            Picker2.Items.Clear();

            foreach (Turma turma in Listas.Turmas)
            {
                Picker.Items.Add(turma.Ano + " - " + turma.Semestre);
            }

            foreach (Professor professor in Listas.Professores)
            {
                Picker2.Items.Add(professor.Nome + " - " + professor.Codigo);
            }

        }
        void ButtonAssociar(object sender, EventArgs args)
        {

        }
        void ButtonRemover(object sender, EventArgs args)
        {

        }
    }
}