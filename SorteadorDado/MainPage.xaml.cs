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

            if (picker.SelectedIndex >= 0)
            {
                
                int lados = int.Parse(picker.SelectedItem.ToString());

                // Sorteia de 1 até o número de lados
                int numero = rnd.Next(1, lados + 1);

                MostrarResultado.Text = numero.ToString();
            }
            else
            {
                DisplayAlert("Aviso", "Selecione um dado antes de sortear.", "OK");
            }

        }
    }

}
