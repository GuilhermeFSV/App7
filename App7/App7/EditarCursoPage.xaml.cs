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
    public partial class EditarCursoPage : ContentPage
    {
        public EditarCursoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            PickerListaCursosExistentes.Items.Clear();
            foreach (Curso curso in Listas.Cursos)
            {
                PickerListaCursosExistentes.Items.Add(curso.Nome);
            }
        }

        private void ButtonSalvar_Clicked(object sender, EventArgs e)
        {
            Listas.Cursos.RemoveAt(PickerListaCursosExistentes.SelectedIndex);
            PickerListaCursosExistentes.Items.Clear();
            Curso curso = new Curso(NomeCurso.Text);
            Listas.Cursos.Add(curso);
            foreach (Curso Curso in Listas.Cursos)
            {
                PickerListaCursosExistentes.Items.Add(Curso.Nome);
            }
            DisplayAlert("Operação", "Curso editado!", "Ok");
            NomeCurso.Text = " ";
        }

        private void ButtonExcluir_Clicked(object sender, EventArgs e)
        {
            Listas.Cursos.RemoveAt(PickerListaCursosExistentes.SelectedIndex);
            PickerListaCursosExistentes.Items.Clear();
            foreach (Curso curso in Listas.Cursos)
            {
                PickerListaCursosExistentes.Items.Add(curso.Nome);
            }
            DisplayAlert("Operação", "Curso removido!", "Ok");
        }
    }
}