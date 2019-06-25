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
	public partial class NovoAlunoPage : ContentPage
	{
		public NovoAlunoPage ()
		{
			InitializeComponent ();
		}
        void OnButtonClicked0(object sender, EventArgs args)
        {
            // verificar as entradas
            // verificar se os campos foram preenchidos
            if (Entry0.Text != null &&
                Entry0.Text.Length > 0 &&
                Entry1.Text != null &&
                Entry1.Text.Length > 0)
            {

                int cpf = int.Parse(Entry1.Text);
                // criar um aluno e adicionar na lista
                Listas.Alunos.Add(new Aluno(Entry0.Text, cpf));

                Entry0.Text = "";
                Entry1.Text = "";
            }

            Navigation.PushModalAsync(new AlunoPage());
        }
    }
}