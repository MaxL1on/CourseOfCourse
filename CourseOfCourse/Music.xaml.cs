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

namespace CourseOfCourse
{
    /// <summary>
    /// Логика взаимодействия для Music.xaml
    /// </summary>
    public partial class Music : Page
    {
        MediaPlayer player;
        List<Uri> playList;

        public Music()
        {
            InitializeComponent();
            player = new MediaPlayer();
            playList = new List<Uri>();

            var mp3Files = Directory.GetFiles("C:\\Users\\Tom\\Desktop\\WinOld\\Desktop\\muz", "*.mp3");
            

            playList.AddRange(mp3Files.Select(p => new Uri(p)));

            Playlist.ItemsSource = playList;
            Playlist.SelectionChanged += Song_Selected;
        }

        private void Song_Selected(object sender, RoutedEventArgs e)
        {
            player.Open(new Uri(Playlist.SelectedItem.ToString()));
            player.Play();
        }
    }
}