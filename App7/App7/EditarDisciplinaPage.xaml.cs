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
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            PickerListaDisciplinasExistentes.Items.Clear();
            PickerPreRequisito.Items.Clear();
            foreach (Disciplina disciplina in Listas.Disciplinas)
            {
                if (disciplina.Requisito != null)
                {
                    PickerListaDisciplinasExistentes.Items.Add(disciplina.Nome + " - " + disciplina.Horas + "h " + " - " + "Pré requisito: " + disciplina.Requisito.Nome);
                }
                else
                {
                    PickerListaDisciplinasExistentes.Items.Add(disciplina.Nome + " - " + disciplina.Horas + "h");
                }
            }
            foreach (Disciplina disciplina2 in Listas.Disciplinas)
            {
                PickerPreRequisito.Items.Add(disciplina2.Nome);
            }
        }

        private void ButtonSalvar_Clicked(object sender, EventArgs e)
        {
            Listas.Disciplinas.RemoveAt(PickerListaDisciplinasExistentes.SelectedIndex);
            Disciplina disciplina = new Disciplina(NomeDisciplinas.Text);
            disciplina.Horas = Convert.ToInt32(disciplina.Horas);
            if (PickerPreRequisito.SelectedIndex >= 0)
            {
                disciplina.Requisito = Listas.Disciplinas.ElementAt(PickerPreRequisito.SelectedIndex);
            }

            PickerListaDisciplinasExistentes.Items.Clear();
            PickerPreRequisito.Items.Clear();
            Listas.Disciplinas.Add(disciplina);
            foreach (Disciplina Disciplina in Listas.Disciplinas)
            {
                if (disciplina.Requisito != null)
                {
                    PickerListaDisciplinasExistentes.Items.Add(disciplina.Nome + " - " + disciplina.Horas + "horas. " + "Pré-requisito:" + disciplina.Requisito.Nome);
                }
                else
                {
                    PickerListaDisciplinasExistentes.Items.Add(disciplina.Nome + " - " + disciplina.Horas + "horas.");
                }
                PickerPreRequisito.Items.Add(Disciplina.Nome);
            }
            DisplayAlert("Operação", "Disciplina editada!", "Ok");
            NomeDisciplinas.Text = " ";
            EntryHoras.Text = " ";
        }

        private void ButtonExcluir_Clicked(object sender, EventArgs e)
        {
            Listas.Disciplinas.RemoveAt(PickerListaDisciplinasExistentes.SelectedIndex);
            PickerListaDisciplinasExistentes.Items.Clear();
            foreach (Disciplina Disciplina in Listas.Disciplinas)
            {
                PickerListaDisciplinasExistentes.Items.Add(Disciplina.Nome + "-" + Disciplina.Horas + "h");
            }
            DisplayAlert("Operação", "Disciplina excluida!", "Ok");
        }
    }
}