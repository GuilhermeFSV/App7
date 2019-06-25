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
            // para todos os alunos da lista
            foreach (Matricula matricula in Listas.Matriculas)  
            {
                // adicionar um elemento na caixa de seleção
                Picker1.Items.Add(matricula.Aluno.Nome);
            }
            // para todos as disciplinas do vetor
            foreach (Turma turma in Listas.Turmas)
            {
                //int cpf = int.Parse(Entry1.Text);
                // adicionar um elemento na caixa de seleção
               // int turma = int.Parse(Picker2.SelectedIndex);
                Picker2.Items.Add(turma.Semestre.ToString() + "-" + turma.Disciplina.Nome);

            }
        }

        void OnButtonClicked0(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        void OnButtonClicked2(object sender, EventArgs args)
        {
            if (Picker1.SelectedIndex >= 0 && Picker2.SelectedIndex >=0)
            {
                Matricula matricula = Listas.Matriculas.ElementAt(Picker1.SelectedIndex);
                matricula.Historicos.RemoveAt(Picker1.SelectedIndex);
                Navigation.PushModalAsync(new CursoPage());
            }
            Navigation.PushModalAsync(new MainPage());
        }

    }
}