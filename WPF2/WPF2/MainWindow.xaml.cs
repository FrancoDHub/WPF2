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

namespace WPF2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TbxButton_Click(object sender, RoutedEventArgs e)
        {
            string _bj = "Bonjour";
            string Nom = TbxNom.Text;
            int Age = Convert.ToInt32(TbxAge.Text);
            string  majeurmineur = null;

           

            if (Age >= 18)
            {
                majeurmineur = "Vous etes majeur !";
            }
            else
            {
                majeurmineur = "vous etes mineur";

              
            }
            MessageBox.Show(_bj + "  . " + Nom + "  " + majeurmineur, "super titre", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }

}
