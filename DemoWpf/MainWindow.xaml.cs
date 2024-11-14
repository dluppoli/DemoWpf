using DemoWpf.ViewModels;
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

namespace DemoWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel vm = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void AtletaRandom_Click(object sender, RoutedEventArgs e)
        {
            vm.getAtletaRandom();
        }

        private void PrimoAtleta_Click(object sender, RoutedEventArgs e)
        {
            vm.getPrimoAtleta();
        }

        private void NumeriPrimi_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
