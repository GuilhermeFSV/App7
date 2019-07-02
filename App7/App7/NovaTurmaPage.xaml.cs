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
	public partial class NovaTurmaPage : ContentPage
	{
		public NovaTurmaPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker.Items.Clear();
            Picker2.Items.Clear();

            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                Picker.Items.Add(disciplina.Nome + " - " + disciplina.Horas);
            }
            foreach (Professor professor in Listas.Professores)
            {
                Picker2.Items.Add(professor.Nome + " - " + professor.Codigo);
            }
        }


        void ButtonSalvar(object sender, EventArgs args)
        {
            if (Picker.Items.Count > 0 && Entry.Text != null && Picker2.Items.Count > 0 && Entry2.Text != null)
            {
                Turma turma = new Turma(Listas.Disciplinas.ElementAt(Picker.SelectedIndex), Listas.Professores.ElementAt(Picker2.SelectedIndex));
                turma.Ano = Convert.ToInt32(Entry.Text);
                turma.Semestre = Convert.ToInt32(Entry2.Text);

                Listas.Turmas.Add(turma);

                DisplayAlert("Sucess!", "Turma Cadastrada com Sucesso", "Ok");
            }
            else
            {
                DisplayAlert("Fail", "Não foi possivel cadastrar a turma", "Ok");
            }

        }
    }
}