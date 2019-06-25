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
	public partial class AlunoPage : ContentPage
	{
		public AlunoPage ()
		{
			InitializeComponent ();

            foreach (Aluno aluno in Listas.Alunos)
            {
                Picker0.Items.Add(aluno.Nome);
            }
           
        }
        void OnButtonClicked0(object sender, EventArgs args)
        {        
             Aluno aluno = Listas.Alunos.ElementAt(Picker1.SelectedIndex);

             Navigation.PushModalAsync(new NovoAlunoPage());
        }
        void OnButtonClicked1(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage()); //(new EditarAlunoPage())
        }
        void OnButtonClicked2(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MatricularNoCursoPage());
        }
        void OnButtonClicked3(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}