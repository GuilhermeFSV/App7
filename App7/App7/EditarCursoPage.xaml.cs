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
            foreach (Curso curso in Listas.Cursos)
            {
                Picker0.Items.Add(curso.Nome);
            }           
        }
        
        public void SelecionarCurso(object sender, EventArgs args)
        {
            Entry0.Text = Listas.Cursos.ElementAt(Picker0.SelectedIndex).Nome;
        }
        void OnButtonClicked0(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }

        void OnButtonClicked1(object sender, EventArgs args)
        {
            if (Picker0.SelectedIndex >= 0)
            {
                Curso curso = Listas.Cursos.ElementAt(Picker0.SelectedIndex);
                curso.Disciplinas.RemoveAt(Picker0.SelectedIndex);
                Navigation.PushModalAsync(new CursoPage());
            }              
        }
    }
 }