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
    public partial class LançarNotaPage : ContentPage
    {
        public LançarNotaPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Picker.Items.Clear();

            foreach (Matricula matricula in Listas.Matriculas)
            {
                Picker.Items.Add(matricula.Aluno.Nome + " - " + matricula.Codigo);
            }
        }

        void PickerSelecionado(object sender, EventArgs args)
        {
            Picker1.Items.Clear();
            Matricula matricula = Listas.Matriculas.ElementAt(Picker.SelectedIndex);
            foreach (Historico historico in matricula.Historicos)
            {
                Picker1.Items.Add(historico.Turma.Disciplina.Nome);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            if (Picker.SelectedIndex >= 0 && Picker1.SelectedIndex >= 0 && Entry.Text != null && Entry1.Text != null)
            {
                Historico historico = Listas.Matriculas.ElementAt(Picker.SelectedIndex).Historicos.ElementAt(Picker1.SelectedIndex);
                historico.Notas.Add(new Nota()
                {
                    Valor = float.Parse(Entry.Text),
                    Data = DateTime.Parse(Entry1.Text)
                });


                Navigation.PushModalAsync(new HistoricoPage());
            }
            else { }
        }

    }
}