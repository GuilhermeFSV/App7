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
    public partial class ContatoPage : ContentPage
    {
        public ContatoPage()
        {
            InitializeComponent();
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
        void PickerSelecionado(object sender, EventArgs args)
        {
            Picker1.Items.Clear();
            Pessoa pessoa = Listas.Pessoas.ElementAt(Picker.SelectedIndex);    
            foreach (Contato contato in pessoa.Contatos)
            {
                foreach (string exibir in contato.Comunicar())
                {
                    Picker1.Items.Add(exibir);
                }

            }
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AssociarFamiliaPage());
        }
        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AssociarEndereçoPage());
        }
        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AssociarInternetPage());
        }
        void OnButtonClicked3(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new AssociarTelefonePage());
        }
        void OnButtonClicked4(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());

        }
        void OnButtonClicked5(object sender, EventArgs args)
        {        
            Navigation.PushModalAsync(new MainPage());
        }
        void OnButtonClicked6(object sender, EventArgs args)
        {
            if (Picker.SelectedIndex > -1)
            {
                Listas.Pessoas.RemoveAt(Picker.SelectedIndex);
                Navigation.PushModalAsync(new ContatoPage());
            }
        }
    }
}