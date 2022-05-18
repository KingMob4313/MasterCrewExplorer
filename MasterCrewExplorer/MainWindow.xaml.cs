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
using System.Configuration;
using Microsoft.Win32;

namespace MasterCrewExplorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string fileLocation = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Ugh move this
            MasterClassController mcc = new MasterClassController();
            var crewObject = mcc.GetMasterCrewData(fileLocation);
            //string xyz = crewObject
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void LoadFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "JSON|*.Json|All|*.*";
            bool? result = OFD.ShowDialog();

            if (result == true)
            {
                var currentFileName = OFD.FileName;
                fileLocation = currentFileName.ToString();
                FileLocationTextBox.Text = currentFileName;;
            }
        }
    }
}
