﻿using System;
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
	public partial class NovaTurmaPage : ContentPage
	{
		public NovaTurmaPage ()
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
                Entry1.Text.Length > 0 && 
                Picker1.SelectedIndex >= 0 &&
                Picker2.SelectedIndex >= 0)
            {

                int cpf = int.Parse(Entry1.Text);
                // criar um aluno e adicionar na lista
               // Listas.Turmas.Add(new Turma(Entry0.Text, cpf));

                Entry0.Text = "";
                Entry1.Text = "";
            }

            Navigation.PushModalAsync(new AlunoPage());
        }
    }
}