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
using System.Windows.Forms;

namespace CW_05292022_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Boolean flag = false;
        public MainWindow()
        {
            InitializeComponent();
            //string[] lang = { "C++", "C#", "SQL", "PHP" };
            //List_lang.ItemSource = lang;
        }

        private void btnEject_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.DefaultExt = "*.*";
            ofd.Filter = "Media Files (*.*)|*.*";
            ofd.ShowDialog();
            try
            {
                
                mediaElement_1.Source = new Uri(ofd.FileName);
            }
            catch (Exception)
            {
                new NullReferenceException("Error");
            }
            System.Windows.Threading.DispatcherTimer dt = new System.Windows.Threading.DispatcherTimer();
            dt.Tick += new EventHandler(timer_Tick);
            dt.Interval = new TimeSpan(0, 0, 1);
            dt.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            sldrVideo.Value = mediaElement_1.Position.TotalSeconds;
            //throw new NotImplementedException();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mediaElement_1.Pause();
        }

        private void sldrVideo_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            mediaElement_1.Position = ts;
        }

        private void sldrVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement_1.Volume = sldrVolume.Value;
        }

        private void mediaElement_1_MediaOpened(object sender, RoutedEventArgs e)
        {
            if(mediaElement_1.NaturalDuration.HasTimeSpan)
            {
                TimeSpan ts = TimeSpan.FromMilliseconds(mediaElement_1.NaturalDuration.TimeSpan.TotalMilliseconds);
                sldrVideo.Maximum = ts.TotalSeconds;
            }
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mediaElement_1.Play();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mediaElement_1.Stop();
        }

        //private void g1_Loaded(object sender, RoutedEventArgs e)
        //{
        //    Title = "Click the picture";
        //    Pic1.Source = new BitmapImage (new Uri("10.jpg",UriKind.Relative));
        //    Pic2.Source = new BitmapImage (new Uri("20.jpg",UriKind.Relative));

        //    Pic1.HorizontalAlignment = HorizontalAlignment.Left;
        //    Pic1.VerticalAlignment = VerticalAlignment.Top;
        //    Pic2.HorizontalAlignment = HorizontalAlignment.Left;
        //    Pic2.VerticalAlignment = VerticalAlignment.Top;

        //    Pic1.Width = 600; Pic1.Height = 300;
        //    Pic2.Width = 600; Pic2.Height = 300;

        //    Pic1.Margin = new Thickness(5,5,0,0);

        //    Pic1.MouseDown += new MouseButtonEventHandler(p_MouseDown);
        //    Pic2.MouseDown += new MouseButtonEventHandler(p_MouseDown);

        //    Pic1.Opacity = 1;
        //}

        //private void p_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    flag = !flag;
        //    var Anime = new System.Windows.Media.Animation.DoubleAnimation();

        //    if(flag == true)
        //    {
        //        Anime.From = 1;
        //        Anime.To = 0;
        //    }
        //    else 
        //    { 
        //        Anime.From = 0;
        //        Anime.To = 1;            
        //    }
        //    Anime.Duration = TimeSpan.FromSeconds(5);
        //    Pic2.BeginAnimation(OpacityProperty, Anime);
        //}

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    ComboBox comboBox = (ComboBox)sender;
        //    ComboBox selectedItem = (ComboBoxItem)comboBox.SelectedItem;
        //    MessageBox.Show(selectedItem.HorizontalContentAlignment.ToString());
        //}

        //private void List_lang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Student st = (Student)List_lang.SelectedItem;
        //    MessageBox.Show(st.lastName);
        //}
    }
}
