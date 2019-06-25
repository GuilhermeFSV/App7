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
            {
                InitializeComponent();
            }
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {

                Picker.Items.Add(disciplina.Nome);

            }

        }
        void OnButtonClicked0(object sender, EventArgs args)
        {

            Navigation.PushModalAsync(new NovaDisciplinaPage());

        }
        void OnButtonClicked1(object sender, EventArgs args)
        {

            Navigation.PushModalAsync(new EditarDisciplinaPage());

        }
        void OnButtonClicked2(object sender, EventArgs args)
        {

            Navigation.PushModalAsync(new AssociarAoCursoPage());

        }
        void OnButtonClicked3(object sender, EventArgs args)
        {

            Navigation.PushModalAsync(new MainPage());

        }
    }
}