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
	public partial class AssociarDisciplinasPage : ContentPage
	{
		public AssociarDisciplinasPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            PickerListCursos.Items.Clear();
            PickerListDisciplina.Items.Clear();
            foreach (Curso curso in Listas.Cursos)
            {
                PickerListCursos.Items.Add(curso.Nome);
            }
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                PickerListDisciplina.Items.Add(disciplina.Nome);
            }
        }
        void ButtonSalvar_Clicked(object sender, EventArgs e)
        {

            Disciplina d = Listas.Disciplinas.ElementAt(PickerListDisciplina.SelectedIndex);
            Curso c = Listas.Cursos.ElementAt(PickerListCursos.SelectedIndex);
            d.Cursos.Add(c);
            c.Disciplinas.Add(d);

            DisplayAlert("Status", "Associação feita!", "Ok");

        }
    }
}