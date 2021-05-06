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

using AxAXVLC;

namespace VlcTest
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        AxVLCPlugin2 vLCPlugin2;

        public MainWindow()
        {
            InitializeComponent();

            vLCPlugin2 = new AxVLCPlugin2();
            WFH1.Child = vLCPlugin2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vLCPlugin2.playlist.add("rtsp ://YOUR.RTSP.IP.000:PORT/h264Preview_01_sub", "LOGGIN", "PASSWORD");
            vLCPlugin2.playlist.play();




            //System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            //ofd.ShowDialog();

            //if(ofd.FileName != string.Empty)
            //{
            //    var myUri = new Uri(ofd.FileName);
            //    var convertedUri = myUri.AbsoluteUri;

            //    vLCPlugin2.playlist.add(convertedUri);
            //    vLCPlugin2.playlist.play();
            //}
        }
    }
}
