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
	public partial class AssociarTelefonePage : ContentPage
	{
		public AssociarTelefonePage ()
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
            Pessoa pessoa = Listas.Pessoas.ElementAt(Picker.SelectedIndex);
            Telefone telefone = new Telefone(int.Parse(Entry.Text));
            pessoa.Contatos.Add(telefone);
            Navigation.PushModalAsync(new ContatoPage());
        }
    }
}