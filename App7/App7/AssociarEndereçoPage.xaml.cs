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
	public partial class AssociarEndereçoPage : ContentPage
	{
		public AssociarEndereçoPage ()
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
            Endereco endereco = new Endereco(Entry.Text, Entry1.Text);
            pessoa.Contatos.Add(endereco);
            Navigation.PushModalAsync(new ContatoPage());
        }
    }
}