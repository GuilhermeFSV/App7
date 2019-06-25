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

        void OnButtonClicked0(object sender, EventArgs args)
        {
            // verificar as entradas
            // verificar se os campos foram preenchidos
            if (Entry0.Text != null &&
                Entry0.Text.Length > 0)
            {
                // criar um aluno e adicionar na lista
                Listas.Cursos.Add(new Curso(Entry0.Text));

                Entry0.Text = "";
            }

            Navigation.PushModalAsync(new CursoPage());
        }

    }
}