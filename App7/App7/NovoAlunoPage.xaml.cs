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
        void OnButtonClicked(object sender, EventArgs args)
        {
            if (Entry1.Text != null && Entry2.Text != null)
            {
                Aluno aluno = new Aluno(Entry1.Text, Convert.ToInt32(Entry2.Text));


                Listas.Alunos.Add(aluno);
                Listas.Pessoas.Add(aluno);
                DisplayAlert("App7", "Aluno salvo com sucesso.", "OK");
            }
            else
            {
                DisplayAlert("Erro", "Há campos sem preencher.", "OK");
            }
        }
    }
}