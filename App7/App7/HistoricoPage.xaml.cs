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
	public partial class HistoricoPage : ContentPage
	{
		public HistoricoPage ()
		{
			InitializeComponent ();
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

        void PickerSelecionado1(object sender, EventArgs args)
        {
            Historico historico = Listas.Matriculas.ElementAt(Picker.SelectedIndex).Historicos.ElementAt(Picker1.SelectedIndex);
            Historico.Resultado resultado = historico.Calcular();

            Picker2.Items.Clear();
            foreach (Nota nota in historico.Notas)
            {
                Picker2.Items.Add(nota.Valor.ToString());
            }

            if (resultado.Aprovado)
            {
                Label1.Text = " Resultado: Aprovado";
            }
            else
            {
                Label1.Text = "Resultado: Reprovado";       
            }
            Label2.Text = "Faltas:" + historico.Faltas;

            Labe3.Text = "Media:" + resultado.Media;
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Lançar_notas());
        }
        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Remover_notas());
        }

        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Lançar_faltas());
        }
    }
}