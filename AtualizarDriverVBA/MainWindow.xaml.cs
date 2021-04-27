using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
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
using versaodriver;

namespace AtualizarDriverVBA
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var usuario = System.Environment.UserName;

                vdriver v = new vdriver();

                var caminhoorigem = v.versaoChromeDriver() + "chromedriver.exe";

                var caminho = $@"C:\Users\{usuario}\AppData\Local\SeleniumBasic\";
                File.Copy(caminhoorigem, caminho + "chromedriver.exe", true);
                MessageBox.Show("Chromedriver atualizado!", "Sucesso");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Não é possível atuaizar o chromedriver devido a {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);

            }




        }
    }
}
