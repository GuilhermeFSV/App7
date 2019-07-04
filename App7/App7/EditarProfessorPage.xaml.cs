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
	public partial class EditarProfessorPage : ContentPage
	{
		public EditarProfessorPage ()
        {
            InitializeComponent();

            foreach (Professor professor in Listas.Professores)
            {
                Picker.Items.Add(professor.Nome + " - " + professor.Cpf + " - " + professor.Codigo);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            if (Picker.Items.Count > 0 && Entry.Text != null && Entry2.Text != null && Entry3.Text != null)
            {
                Listas.Professores.RemoveAt(Picker.SelectedIndex);
                Professor professor = new Professor(Entry.Text, Convert.ToInt32(Entry2.Text), Convert.ToInt32(Entry3.Text));
                Listas.Professores.Add(professor);

                DisplayAlert("App7", "Modificação realizada com sucesso.", "OK");
            }
            else
            {
                DisplayAlert("Erro", "Há campos sem preencher.", "OK");
            }

        }
    }
}