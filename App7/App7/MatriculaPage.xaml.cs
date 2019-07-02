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
	public partial class MatriculaPage : ContentPage
	{
        public MatriculaPage ()
        {
            InitializeComponent ();
     
            foreach (Curso curso in Listas.Cursos)
            {
                Picker1.Items.Add(curso.Nome);
            }

            foreach (Aluno aluno in Listas.Alunos)
            {
                Picker2.Items.Add(aluno.Nome);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            if (Picker1.Items.Count > 0 && Picker2.Items.Count > 0)
            {
                Aluno aluno = Listas.Alunos.ElementAt(Picker2.SelectedIndex);
                Curso curso = Listas.Cursos.ElementAt(Picker1.SelectedIndex);

                Matricula matricula = new Matricula(aluno, curso);
                matricula.Ano = 2019;
                Random cod = new Random();
                matricula.Codigo = "2019" + Convert.ToString(cod.Next());
                Listas.Matriculas.Add(matricula);

                DisplayAlert("Aluno", "Aluno associado ao curso!", "Ok");
            }
        }

        void OnButtonClicked2(object sender, EventArgs args)
        {
            if (Picker1.Items.Count > 0 && Picker2.Items.Count > 0)
            {
                Listas.Matriculas.RemoveAt(Picker1.SelectedIndex);

                DisplayAlert("Aluno", "Aluno removido do curso!", "Ok");
            }
        }
    }
}