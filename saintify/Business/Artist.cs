using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saintify.Business
{
    /// <summary>
    /// This class is designed to define an artist
    /// </summary>
    public class Artist
    {
        #region private attributes
        private int id = -1;
        private String pictureName = "";//artist's picture's file name (see application ressources.resx)
        private String name = "";//artist's name
        private String bio = "";
        private List<Song> listOfSongs = null;//list of the artist's songs 
        private int songsTotalDuration = -1;//total duration of the list of songs
        private int shortestSongDuration = -1;
        private int longestSongDuration = -1;
        private int averageSongDuration = -1;
        private int medianSongDuration = -1;

        #endregion private attributes

        #region constructors
        /// <summary>
        /// This constructor initializes a new instance of the artist class.
        /// </summary>
        /// <param name="id">The artist's id</param>
        /// <param name="pictureName">The artist's picture (see application ressources.resx</param>
        /// <param name="name">The artist's name</param>
        /// <param name="bio">The artist's biography</param>
        /// <param name="listOfSongs">The list of artist's songs</param>
        public Artist (int id, String pictureName, String name, String bio, List<Song> listOfSongs)
        {
            this.id = id;
            this.pictureName = pictureName;
            this.name = name;
            this.bio = bio;
            AddSong(listOfSongs);
        }
        #endregion constructors

        #region public methods
        #region getters and setters
        /// <summary>
        /// This getter delivers the value of the private attribute "id" 
        /// </summary>
        /// <returns>The artist's id</returns>
        public int Id()
        {
            return this.id;
        }

        /// <summary>
        /// This getter delivers the value of the private attribut "title" 
        /// </summary>
        /// <returns>The artist's picture's file name (see application ressources.resx)</returns>
        public String PictureName()
        {
            return this.pictureName;
        }

        /// <summary>
        /// This getter delivers the value of the private attribute "name" 
        /// </summary>
        /// <returns>The artist's name</returns>
        public String Name()
        {
            return this.name;
        }

        /// <summary>
        /// This getter delivers the value of the private attribute "bio"
        /// </summary>
        /// <returns></returns>
        public String Bio()
        {
            return this.bio;
        }

        /// <summary>
        /// This getter delivers the list of Songs
        /// </summary>
        /// <returns>All songs performed by the artists</returns>
        public List<Song> ListOfSongs()
        {
            return this.listOfSongs;
        }

        /// <summary>
        /// This method allows to add a song
        /// </summary>
        /// <param name="songToAdd">an object song to add to the list of existing song</param>
        public void AddSong (Song songToAdd)
        {
            if (this.listOfSongs == null)
            {
                this.listOfSongs = new List<Song>();
            }
            if (songToAdd != null)
            {
                if (SongNotNull(songToAdd))
                {
                    this.listOfSongs.Add(songToAdd);
                    updateSongsStatistics(this.listOfSongs);
                }
            }
        }

        /// <summary>
        /// This method allows to add a song
        /// </summary>
        /// <param name="songToAdd">The song to be added</param>
        public void AddSong(List<Song> listOfSongsToAdd)
        {
            if (listOfSongsToAdd != null)
            {
                foreach (Song song in listOfSongsToAdd)
                {
                    this.AddSong(song);
                }
            }
        }

        /// <summary>
        /// This getter delivers the value of the private attribut 
        /// songsTotalDuration
        /// </summary>
        public int SongsTotalDuration()
        {
            return this.songsTotalDuration;
        }

        /// <summary>
        /// This getter delivers the value of the private attribut 
        /// longestSongDuration
        /// </summary>
        public int LongestSongDuration()
        {
            return this.longestSongDuration;
        }

        /// <summary>
        /// This getter delivers the value of the private attribut 
        /// shortestSongDuration
        /// </summary>
        public int ShortestSongDuration()
        {
            return this.shortestSongDuration;
        }

        /// <summary>
        /// This getter delivers the value of the private attribut 
        /// averageSongDuration
        /// </summary>
        public int AverageSongDuration()
        {
            return this.averageSongDuration;
        }

        /// <summary>
        /// This getter delivers the value of the private attribut 
        /// averageSongDuration
        /// </summary>
        public int MedianSonggDuration()
        {
            return this.medianSongDuration;
        }
        #endregion getters and setters
        #endregion public methods

        #region private
        /// <summary>
        /// This method prevents duplicate (when adding a song for the second time)
        /// </summary>
        /// <param name="songToCheck">The song to be added</param>
        /// <returns></returns>
        private bool SongExists(Song songToCheck)
        {
            bool exists = false;

            foreach (Song song in this.listOfSongs)
            {
                if (song.Title() == songToCheck.Title() && song.Duration() == songToCheck.Duration())
                {
                    exists = true;
                }
            }
            return exists;
        }

        /// <summary>
        /// This method prevents adding "null" song
        /// </summary>
        /// <param name="songToCheck">The song to be added</param>
        /// <returns></returns>
        private bool SongNotNull(Song songToCheck)
        {
            bool songNotEmpty = false;

            if (songToCheck != null)
            {
                songNotEmpty = true;
            }

            return songNotEmpty;
        }

        private void updateSongsStatistics(List<Song> listOfSongs)
        {
            UpdateSongsTotalDuration(listOfSongs);
            UpdateShortestSongDuration(listOfSongs);
            UpdateLongestSongDuration(listOfSongs);
            UpdateAverageSongDuration(listOfSongs);
            UpdateMedianSongDuration(listOfSongs);
        }

        /// <summary>
        /// This method update the private attribut "songsTotalDuration"
        /// </summary>
        /// <param name="listOfSongs">List of Song just updated</param>
        private void UpdateSongsTotalDuration(List<Song> listOfSongs)
        {
            int temp = 0;
            foreach (Song song in listOfSongs)
            {
                temp += song.Duration();
            }
            this.songsTotalDuration = temp;
        }

        /// <summary>
        /// This method update the private attribut "shortestSongDuration"
        /// </summary>
        /// <param name="listOfSongs">List of Song just updated</param>
        private void UpdateShortestSongDuration(List<Song> listOfSongs)
        {
            int temp = 0;
            foreach (Song song in listOfSongs)
            {
                int currentSongDuration = song.Duration();
                if (temp == 0 || currentSongDuration < temp)
                {
                    temp = song.Duration();
                }
            }
            this.shortestSongDuration = temp;
        }

        /// <summary>
        /// This method update the private attribut "longestSongDuration"
        /// </summary>
        /// <param name="listOfSongs">List of Song just updated</param>
        private void UpdateLongestSongDuration(List<Song> listOfSongs)
        {
            int temp = 0;
            foreach (Song song in listOfSongs)
            {
                int currentSongDuration = song.Duration();
                if (temp == 0 || currentSongDuration > temp)
                {
                    temp = song.Duration();
                }
            }
            this.longestSongDuration = temp;
        }

        /// <summary>
        /// This method update the private attribut "averageSongs"
        /// Be carreful, this method need a object Artist with updpated attribut SongsDuration
        /// </summary>
        /// <param name="listOfSongs">List of Song just updated</param>
        private void UpdateAverageSongDuration(List<Song> listOfSongs)
        {
            int temp = 0;
            if (this.listOfSongs != null)
            {
                if (this.listOfSongs.Count != 0)
                {
                    temp = this.songsTotalDuration / this.listOfSongs.Count();
                }
            }
            this.averageSongDuration = temp;
        }

        /// <summary>
        /// This method update the private attribut "averageSongs"
        /// Be carreful, this method need a object Artist with updpated attribut SongsDuration
        /// </summary>
        /// <param name="listOfSongs">List of Song just updated</param>
        private void UpdateMedianSongDuration(List<Song> listOfSongs)
        {
            //first we sort the song by duration
            List<Song> listOfSongsOrdered = listOfSongs.OrderBy(song => song.Duration()).ToList();

            //we find the position of the song in the list
            int medianSongPosition = listOfSongsOrdered.Count / 2;

            //we get the duration of this the media song
            int temp = listOfSongsOrdered[medianSongPosition].Duration();

            this.medianSongDuration = temp;
        }
        #endregion private


    }
}
