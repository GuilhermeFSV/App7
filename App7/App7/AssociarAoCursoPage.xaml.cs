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
	public partial class AssociarAoCursoPage : ContentPage
	{
		public AssociarAoCursoPage ()
		{
			InitializeComponent ();
		}
        public void SelecionarCurso(object sender, EventArgs args)
        {
            Disciplina disciplina = Listas.Disciplinas.ElementAt(Picker0.SelectedIndex);
            Curso curso = Listas.Cursos.ElementAt(Picker1.SelectedIndex);

            Navigation.PushModalAsync(new DisciplinaPage());
        }
        void OnButtonClicked0(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new DisciplinaPage());
        }
        void OnButtonClicked1(object sender, EventArgs args)
        {
            Disciplina disciplina = Listas.Disciplinas.ElementAt(Picker0.SelectedIndex);
            Curso curso = Listas.Cursos.ElementAt(Picker1.SelectedIndex);
            disciplina.Cursos.RemoveAt(Picker0.SelectedIndex);
            curso.Disciplinas.RemoveAt(Picker1.SelectedIndex);
            Navigation.PushModalAsync(new DisciplinaPage());
        }
    }
}