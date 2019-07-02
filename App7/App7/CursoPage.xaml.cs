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
	public partial class CursoPage : ContentPage
	{
        public CursoPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            PickerCursos.Items.Clear();

            foreach (Curso curso in Listas.Cursos)
            {
                PickerCursos.Items.Add(curso.Nome);
            }
            PickerListaDisciplinas.Items.Clear();
        }
        void PickerSelecionado(object sender, EventArgs args)
        {
            PickerListaDisciplinas.Items.Clear();
            Curso curso1 = Listas.Cursos.ElementAt(PickerCursos.SelectedIndex);
            foreach (Disciplina disciplina in curso1.Disciplinas)
            {
                PickerListaDisciplinas.Items.Add(disciplina.Nome);
            }
        }

        void ButtonNovo_Clicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new NovoCursoPage());
        }
        void ButtonEditar_Clicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new EditarCursoPage());
        }

    }
}