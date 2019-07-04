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
    public partial class DisciplinaPage : ContentPage
    {
        public DisciplinaPage()
        {
            
                InitializeComponent();
        }
            
        protected override void OnAppearing()
        {
            base.OnAppearing();
            PickerDisciplina.Items.Clear();
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                if (disciplina.Requisito == null)
                {
                    PickerDisciplina.Items.Add(disciplina.Nome + " - " + disciplina.Horas + "h");

                }
                else
                {
                    PickerDisciplina.Items.Add(disciplina.Nome + "-" + disciplina.Horas + "h" + "pré requisito :" + disciplina.Requisito.Nome);
                }

            }
        }

        private void ButtonNova_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NovaDisciplinaPage());
        }

        private void ButtonEditar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EditarDisciplinaPage());
        }

        private void ButtonAssociar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AssociarDisciplinasPage());

        }
    }
}