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
	public partial class AlunoPage : ContentPage
	{
		public AlunoPage ()
		{
			InitializeComponent ();                
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker.Items.Clear();
            Picker2.Items.Clear();
            Picker3.Items.Clear();

            foreach (Aluno aluno in Listas.Alunos)
            {
                Picker.Items.Add(aluno.Nome + " - " + aluno.Cpf);
            }
            foreach (Matricula matricula in Listas.Matriculas)
            {
                Picker2.Items.Add(matricula.Aluno.Nome + " - " + matricula.Curso.Nome);
            }
        }

        void PickerAluno(object sender, EventArgs args)
        {
            Picker3.Items.Clear();
            Aluno aluno = Listas.Alunos.ElementAt(Picker.SelectedIndex);

            foreach (Contato contato in aluno.Contatos)
            {
                foreach (string exibir in contato.Comunicar())
                {
                    Picker3.Items.Add(exibir);
                }

            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new NovoAlunoPage());
        }

        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new EditarAlunoPage());
        }

        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MatricularNoCursoPage());
        }
    }
}