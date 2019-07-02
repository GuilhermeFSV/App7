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
    public partial class NovoCursoPage : ContentPage
    {
        public NovoCursoPage()
        {
            InitializeComponent();
        }

        void OnButtonSalvar(object Sender, EventArgs args)
        {
            Curso curso = new Curso(NomeDoCurso.Text);
            Listas.Cursos.Add(curso);
            DisplayAlert("Cadastro", "Curso cadastrado", "Ok");
            NomeDoCurso.Text = " ";
            //Navigation.PushModalAsync(new CursosPage());
        }
    }
}