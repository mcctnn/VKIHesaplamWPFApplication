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

namespace Deneme
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double boy = Convert.ToInt32(tbxBoy.Text);
            int kilo = Convert.ToInt32(tbxKilo.Text);
            double sonuc =( kilo / (boy * boy/10000));
            if (sonuc>40.0)
            {
                MessageBox.Show("3.dereceden obez");
            }
            if (sonuc<40.0&&sonuc>35.0)
            {
                MessageBox.Show("2.dereceden obez");
            }
            if (sonuc < 35.0 && sonuc > 30.0)
            {
                MessageBox.Show("1.dereceden obez");
            }
            if (sonuc < 30.0 && sonuc > 25.0)
            {
                MessageBox.Show("Fazla kilolu");
            }
            if (sonuc < 25.0 && sonuc > 19.0)
            {
                MessageBox.Show("Olması gereken kilodasınız tebrikler!!!");
            }
            if (sonuc < 19.0 && sonuc > 16.0)
            {
                MessageBox.Show("Düşük kilo");
            }
            if (sonuc > 15.0&& sonuc < 16.0)
            {
                MessageBox.Show("Ciddi derece düşük kilo");
            }
            if (sonuc<15.0&&sonuc>0.0)
            {
                MessageBox.Show("Çok ciddi derecede düşük kilo");
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
          
        }
    }
}
