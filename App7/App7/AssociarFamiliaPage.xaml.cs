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
	public partial class AssociarFamiliaPage : ContentPage
	{
		public AssociarFamiliaPage ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker.Items.Clear();
            foreach (Pessoa pessoa in Listas.Pessoas)
            {
                Picker.Items.Add(pessoa.Nome);
            }
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            if (Picker.SelectedIndex > -1)
            {
                Pessoa pessoa = Listas.Pessoas.ElementAt(Picker.SelectedIndex);

                Familiar contato = new Familiar(Entry.Text, int.Parse(Entry1.Text), Entry2.Text);

                pessoa.Contatos.Add(contato);

                Listas.Pessoas.Add(contato);

                Navigation.PushModalAsync(new ContatoPage());
            }
        }
    }
}