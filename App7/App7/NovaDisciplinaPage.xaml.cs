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
	public partial class NovaDisciplinaPage : ContentPage
	{
		public NovaDisciplinaPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            PickerPreRequisito.Items.Clear();
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                PickerPreRequisito.Items.Add(disciplina.Nome + " - " + disciplina.Horas);
            }
        }


        private void ButtonSalvar_Clicked(object sender, EventArgs e)
        {

            if (EntryNome.Text != null && EntryHoras.Text != null)
            {
                Disciplina disciplina = new Disciplina(EntryNome.Text);
                disciplina.Horas = Convert.ToInt32(EntryHoras.Text);
                if (PickerPreRequisito.SelectedIndex >= 0)
                {
                    disciplina.Requisito = Listas.Disciplinas.ElementAt(PickerPreRequisito.SelectedIndex);
                }
                Listas.Disciplinas.Add(disciplina);

                PickerPreRequisito.Items.Clear();
                foreach (Disciplina Disciplina in Listas.Disciplinas)
                {
                    PickerPreRequisito.Items.Add(Disciplina.Nome);
                }

                DisplayAlert("Cadastro", "Disciplina cadastrada", "Ok");
                EntryNome.Text = " ";
                EntryHoras.Text = " ";
            }
            else
            {
                DisplayAlert("Cadastro", "Campo sem preencher", "Ok");
            }
        }
    }
}