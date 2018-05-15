using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CourseOfCourse
{
    [Serializable]
    class Song
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Mptime { get; set; }
        public double Duration { get; set; }

        public Song()
        {
            Album = String.Empty;
            Name = String.Empty;
            Path = String.Empty;
            Title = String.Empty;
            Year = String.Empty;
            Artist = String.Empty;
            Mptime = String.Empty;
            Duration = 0;
        }
        public static void SerializeObject(ObservableCollection<Song> playlst, string savedName)
        {
            FileStream fstream = new FileStream("listmp3.dat", FileMode.OpenOrCreate, FileAccess.Write);

            new BinaryFormatter().Serialize(fstream, playlst);
        }
        public static ObservableCollection<Song> DeserializeObject(string playlistName)
        {
            FileStream fstream = new FileStream(playlistName, FileMode.Open, FileAccess.Read);

            return (ObservableCollection<Song>)new BinaryFormatter().Deserialize(fstream);
        }
    }
}
