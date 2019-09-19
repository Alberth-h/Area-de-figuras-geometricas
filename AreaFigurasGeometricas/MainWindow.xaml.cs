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

namespace AreaFigurasGeometricas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalcularRec_Click(object sender, RoutedEventArgs e)
        {
            double baseRec = double.Parse(txtBaseRec.Text);
            double alturaRec = double.Parse(txtAlturaRec.Text);
            double areaRec = baseRec * alturaRec;
            txtAreaRec.Text = areaRec.ToString() + " u2";
        }

        private void BtnCalcularTri_Click(object sender, RoutedEventArgs e)
        {
            double baseTri = double.Parse(txtBaseTri.Text);
            double alturaTri = double.Parse(txtAlturaTri.Text);
            double areaTri1 = baseTri * alturaTri;
            double areaTri2 = areaTri1 / 2;
            txtAreaTri.Text = areaTri2.ToString() + " u2";
        }

        private void BtnCalcularCir_Click(object sender, RoutedEventArgs e)
        {
            double radio = double.Parse(txtRadio.Text);
            double areaCir1 = radio * radio;
            double areaCir2 = 3.1416 * areaCir1;
            txtAreaCir.Text = areaCir2.ToString() + " u2";

        }

        private void BtnCalcularTrap_Click(object sender, RoutedEventArgs e)
        {
            double baseMa = double.Parse(txtBaseMa.Text);
            double baseMe = double.Parse(txtBaseMe.Text);
            double alturaTrap = double.Parse(txtAlturaTrap.Text);
            double areaTrap1 = baseMa + baseMe;
            double areaTrap2 = areaTrap1 / 2;
            double areaTrap3 = areaTrap2 * alturaTrap;
            txtAreaTrap.Text = areaTrap3.ToString() + " u2";
        }
    }
}
