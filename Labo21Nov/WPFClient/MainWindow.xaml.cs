using Labo21Nov;
using System.Data.Entity.Migrations.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CompanyContext _context = new CompanyContext();
        private Customer _customer;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<CompanyContext>());
            _context = new CompanyContext();
            _customer = _context.Customers.First();
            Formulaire.DataContext = _customer;

            //throw new NotImplementedException("Voir énoncé");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _customer.AccountBalance += (double) MontantAAjouterAuCompte.Value;
            _context.SaveChanges();
            //throw new NotImplementedException("Voir énoncé");
        }
    }
}
