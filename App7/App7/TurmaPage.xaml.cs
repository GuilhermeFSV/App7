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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker.Items.Clear();
            Picker2.Items.Clear();
            Picker3.Items.Clear();

            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                Picker.Items.Add(disciplina.Nome + " - " + disciplina.Horas);
            }

            foreach (Turma turmas in Listas.Turmas)
            {
                Picker2.Items.Add(turmas.Ano + " - " + turmas.Disciplina.Nome + " - " + turmas.Semestre);
            }

            foreach (Professor professor in Listas.Professores)
            {
                Picker3.Items.Add(professor.Nome + " - " + professor.Codigo);
            }
        }


        void ButtonAssociarProfessor(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AssociarProfessorPage());
        }
        void ButtonNovaTurma(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new NovaTurmaPage());
        }
        void ButtonEditarTurma(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new EditarTurmaPage());
        }
    }
}