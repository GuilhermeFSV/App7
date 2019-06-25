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

        void OnButtonClicked0(object sender, EventArgs args)
        {          
            foreach (Curso curso in Listas.Cursos)
            {
                Picker1.Items.Add(curso.Nome);
            }
            Navigation.PushModalAsync(new MainPage());
        }

        void IndexChanged(object sender, EventArgs args)
        {
            Curso curso1 = Listas.Cursos.ElementAt(Picker1.SelectedIndex);
            foreach (Disciplina disciplina in curso1.Disciplinas)
            {
                Picker2.Items.Add(disciplina.Nome);
            }
        }

        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new NovoCursoPage());
        }

        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new EditarCursoPage());
        }
        void OnButtonClicked3(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        void OnButtonClicked4(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        void OnButtonClicked5(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
        void OnButtonClicked6(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }

    }
}