using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M07_UF1_A05_EventsGrids
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Començament(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs al Començament. Reps M200");
        }

        private void Button_Click_RondaValencia(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Ronda de Valencia. El Preu és de M60");
        }

        private void Button_Click_CajaComunidad(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Caja de Comunidad. Agafa una carta");
        }

        private void Button_Click_PlazaLavapies(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Plaza Lavapies. El Preu és de M60");
        }

        private void Button_Click_ImpuestoCapital(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Impuesto sobre el Capital. Paga M200");
        }

        private void Button_Click_EstacionGoya(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Estacion de Goya. El Preu és de M200");
        }

        private void Button_Click_GlorietaCaminos(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Glorieta Cuatro Caminos. El Preu és de M100");
        }

        private void Button_Click_Suerte(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Suerte. Agafa una carta");

        }

        private void Button_Click_AvenidaVictoria(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Avenida Reina Victoria. El Preu és de M100");
        }

        private void Button_Click_CalleMurillo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Calle Bravo Murillo. El Preu és de M100");
        }

        private void Button_Click_Preso(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a la Preso. Nomes de visita");
        }

        private void Button_Click_GlorietaBilbao(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a la Glorieta de Bilbao. El Preu és de M140");
        }

        private void Button_Click_CompañiaElectricidad(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Compañia de Electricidad. El Preu és de M150");
        }

        private void Button_Click_CalleAlberto(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Calle Alberto Aguilera. El Preu és de M140");
        }

        private void Button_Click_CalleFuencarral(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Calle Fuencarral. El Preu és de M140");
        }

        private void Button_Click_EsatcioDelicias(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a la Estación de las Delicicas. El Preu és de M200");
        }

        private void Button_AvenidaFelipe(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Avenida Felipe. El Preu és de M180");
        }

        private void Button_Click_CalleVelazquez(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Calle Velazquez. El Preu és de M180");

        }

        private void Button_Click_CalleSerrano(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Calle Serrano. El Preu és de M200");
        }

        private void Button_Click_Parking(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs al Parking. Es GRATUIT!");

        }

        private void Button_Click_AvenidaAmerica(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Avenida de America. El Preu és de M220");
        }
        private void Button_Click_CalleMaria(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Calle Maria de Molina. El Preu és de M220");
        }

        private void Button_Click_CalleCea(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Calle Cea Bermudez. El Preu és de M240");
        }

        private void Button_Click_EstacionMediodia(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Estacion del Mediodia. El Preu és de M200");
        }

        private void Button_Click_AvenidaReyes(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Avenida de los Reyes Catolicos. El Preu és de M260");
        }

        private void Button_Click_CalleBailen(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Calle Bailen. El Preu és de M260");
        }

        private void Button_Click_CompañiaAgua(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Compañia de Aguas. El Preu és de M150");
        }

        private void Button_Click_PlazaEspaña(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Plaza de España. El Preu és de M280");
        }

        private void Button_Click_Carcel(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("VE A LA CÁRCEL");
        }

        private void Button_Click_PuertaSol(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Plaza de España. El Preu és de M300");
        }

        private void Button_Click_CalleAlcala(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Calle Alcala. El Preu és de M300");
        }

        private void Button_Click_GranVia(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Gran Via. El Preu és de M300");
        }

        private void Button_Click_EstacionNorte(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Estacion Norte. El Preu és de M200");
        }

        private void Button_Click_PaseoCastellana(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Paseo de la Castellana. El Preu és de M350");
        }

        private void Button_Click_ImpuestoLujo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Impuesto de Lujo. Paga M100");
        }

        private void Button_Click_PaseoPrado(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estàs a Paseo del Prado. El Preu és de M400");
        }
    }
}
