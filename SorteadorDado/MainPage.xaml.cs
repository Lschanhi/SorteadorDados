using SorteadorDado.Models;
using System.Security.Cryptography.X509Certificates;

namespace SorteadorDado
{
    public partial class MainPage : ContentPage
    {
       Random rnd = new Random();

        public MainPage()
        {
            InitializeComponent();
            
        }

  
        private void SortearBtn_Clicked(object sender, EventArgs e)
        {
            /* if(picker.SelectedIndex >= 0)
             {
                 int lados =  int.Parse(picker.SelectedItem.ToString());

                 int numeros = rnd.Next(1, lados+1);

                 MostrarResultado.Text = numeros.ToString();
             }
             */
            Dado dado = new Dado(6);
            dado.Rolar();
            MostrarResultado.Text = dado.LadoSorteado.ToString();
        }
    }

}
