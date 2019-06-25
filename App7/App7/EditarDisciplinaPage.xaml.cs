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
	public partial class EditarDisciplinaPage : ContentPage
	{
        public EditarDisciplinaPage()
        {
            InitializeComponent();
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                Picker0.Items.Add(disciplina.Nome);
            }
        }

        public void SelecionarDisciplina(object sender, EventArgs args)
        {
            Entry0.Text = Listas.Disciplinas.ElementAt(Picker0.SelectedIndex).Nome;
            Navigation.PushModalAsync(new DisciplinaPage());
        }

        void OnButtonClicked1(object sender, EventArgs args)
        {
            if (Picker0.SelectedIndex >= 0)
            {
                Disciplina disciplina = Listas.Disciplinas.ElementAt(Picker0.SelectedIndex);
                disciplina.Cursos.RemoveAt(Picker0.SelectedIndex);
                Navigation.PushModalAsync(new DisciplinaPage());
            }
        }
        void OnButtonClicked0(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new DisciplinaPage());
        }
    }
}