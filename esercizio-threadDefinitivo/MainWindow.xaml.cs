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
using System.Threading;

namespace esercizio_threadDefinitivo
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Uri uriMacchina1 = new Uri("macchina1.jpg", UriKind.Relative);
        readonly Uri uriMacchina2 = new Uri("macchina2.jpg", UriKind.Relative);
        readonly Uri uriMacchina3 = new Uri("macchina3.jpg", UriKind.Relative);

        int posMacchina1 = 0;
        int posMacchina2 = 100;
        int posMacchina3 = 200;

        public MainWindow()
        {
            InitializeComponent();

            Thread t1 = new Thread(new ThreadStart(muoviMacchina1));
            ImageSource imm = new BitmapImage(uriMacchina1);
            imgMacchina1.Source = imm;
            t1.Start();


            Thread t2 = new Thread(new ThreadStart(muoviMacchina2));
            ImageSource imm2 = new BitmapImage(uriMacchina2);
            imgMacchina1.Source = imm2;
            t2.Start();


            Thread t3 = new Thread(new ThreadStart(muoviMacchina3));
            ImageSource imm3 = new BitmapImage(uriMacchina3);
            imgMacchina1.Source = imm3;
            t3.Start();
            
        }

        public void muoviMacchina1()
        {
            while (posMacchina1 < 100)
            {
                posMacchina1 += 100;

                Thread.Sleep(TimeSpan.FromMilliseconds(500));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgMacchina1.Margin = new Thickness(posMacchina1, 100, 0, 0);
                }));


            }


        }

        public void muoviMacchina2()
        {
            while (posMacchina2 < 100)
            {
                posMacchina2 += 100;

                Thread.Sleep(TimeSpan.FromMilliseconds(500));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgMacchina2.Margin = new Thickness(posMacchina2, 100, 0, 0);
                }));


            }


        }

        public void muoviMacchina3()
        {
            while (posMacchina3 < 100)
            {
                posMacchina3 += 100;

                Thread.Sleep(TimeSpan.FromMilliseconds(500));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgMacchina3.Margin = new Thickness(posMacchina3, 100, 0, 0);
                }));


            }


        }

    }
}
