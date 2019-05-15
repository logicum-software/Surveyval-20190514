using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Surveyval_20190514
{
    /// <summary>
    /// Interaktionslogik für Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        private AppData appData;
        public Manager()
        {
            InitializeComponent();

            appData = new AppData();

            //Daten einlesen aus Datei "udata.dat"
            IFormatter formatter = new BinaryFormatter();
            try
            {
                Stream stream = new FileStream("udata.dat", FileMode.Open, FileAccess.Read, FileShare.Read);
                appData = (AppData)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Dateifehler", MessageBoxButton.OK);
                //throw;
            }

            if (appData.appFrageboegen.Count > 0)
                listBoxFrageboegen.ItemsSource = appData.appFrageboegen;

            if (appData.appFragen.Count > 0)
                listBoxFragen.ItemsSource = appData.appFragen;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
