using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App7.Modelos;

namespace App7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new CursoPage());
        }

        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new DisciplinaPage());
        }

        void OnButtonClicked3(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AlunoPage());
        }

        void OnButtonClicked4(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new ProfessorPage());
        }

        void OnButtonClicked5(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new TurmaPage());
        }

        void OnButtonClicked6(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MatriculaPage());
        }

        void OnButtonClicked7(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new HistoricoPage());
        }

        void OnButtonClicked8(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new ContatoPage());
        }

    }
}

