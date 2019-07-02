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
	public partial class MatricularNoCursoPage : ContentPage
	{
		public MatricularNoCursoPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker.Items.Clear();
            Picker2.Items.Clear();

            foreach (Matricula matricula in Listas.Matriculas)
            {
                Picker.Items.Add(matricula.Aluno.Nome + " - " + matricula.Curso.Nome);
            }
            foreach (Turma turma in Listas.Turmas)
            {
                Picker2.Items.Add(turma.Disciplina.Nome + " - " + turma.Semestre + " - " + turma.Ano);
            }
        }

        void ButtonAssociar(object sender, EventArgs args)
        {
            if (Picker.Items.Count > 0 && Picker2.Items.Count > 0)
            {
                Historico historico = new Historico();

                Turma turma = Listas.Turmas.ElementAt(Picker2.SelectedIndex);
                Matricula matricula = Listas.Matriculas.ElementAt(Picker.SelectedIndex);

                historico.Turma = turma;
                historico.Matricula = matricula;

                //Acrescentar histórico na lista

                DisplayAlert("Histórico", "Histórico associado com sucesso!", "Ok");
            }
        }

        void ButtonRemover(object sender, EventArgs args)
        {
            if (Picker.Items.Count > 0 && Picker2.Items.Count > 0)
            {

            }
        }
    }
}