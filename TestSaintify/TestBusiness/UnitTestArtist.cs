using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace saintify.Business
{
    [TestClass]
    public class UnitTestArtist
    {

        #region private attributes
        private Artist artist = null;
        private int expectedArtisId = -1;
        private String expectedArtistName = "Artist's Name";
        private String expectedArtistPictureName = "Artist's picture name";
        private String expectedArtistBiography = "This a biography of the artist.";
        private List<Song> expectedArtistListOfSongs = null;
        private int expectedSongsTotalDuration = 0;
        private int expectedLongestSongDuration;
        private int expectedShortestSongDuration;
        private int expectedAverageSongDuration;
        private int expectedMedianSongDuration;
        #endregion private attributes

        /// <summary>
        /// This test method initializes variables and objects needed for the next test session.
        /// Runs before each test method.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            this.expectedArtistListOfSongs = new List<Song>();
            for (int i = 0; i < 10; i++ )
            {
                Song song = new Song("Song" + i.ToString(), i+60);
                this.expectedArtistListOfSongs.Add(song);
            }
            artist = new Artist(this.expectedArtisId,  this.expectedArtistPictureName, this.expectedArtistName, this.expectedArtistBiography, this.expectedArtistListOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the artist's id
        /// </summary>
        [TestMethod]
        public void TestMethodGetterActistIdSucess()
        {
            //given
            //please refer to Init() method
            int actualArtistId = -1;

            //then
            actualArtistId = this.artist.Id();

            //when
            Assert.AreEqual(this.expectedArtisId, actualArtistId);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the artist's picutre's name
        /// </summary>
        [TestMethod]
        public void TestMethodGetterActistPictureNameSucess()
        {
            //given
            //please refer to Init() method
            String actualArtistPictureName = "";

            //then
            actualArtistPictureName = this.artist.PictureName();

            //when
            Assert.AreEqual(this.expectedArtistPictureName, actualArtistPictureName);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the artist's name
        /// </summary>
        [TestMethod]
        public void TestMethodGetterArtistNameSucess()
        {
            //given
            //please refer to Init() method
            String actualArtistName = "";

            //then
            actualArtistName = this.artist.Name();

            //when
            Assert.AreEqual(this.expectedArtistName, actualArtistName);
        }

        /// <summary>
        /// This test method is designed to test the Getter in charge to deliver the artist's biography
        /// </summary>
        [TestMethod]
        public void TestMethodGetterArtistBiographySucess()
        {
            //given
            //please refer to Init() method
            String actualArtistBio = "";

            //then
            actualArtistBio = this.artist.Bio();

            //when
            Assert.AreEqual(this.expectedArtistBiography, actualArtistBio);
        }

        /// <summary>
        /// This test method is designed to test the method allowing to add a single song
        /// </summary>
        [TestMethod]
        public void TestMethodAddSongSucess()
        {
            //given
            //please refer to Init() method
            Song songToAdd = new Song("TitleToAdd", 120);
            int expectedAmountOfSongs = 11;
            int actualAmountOfSongs = -1;

            //then
            this.artist.AddSong(songToAdd);
            actualAmountOfSongs = this.artist.ListOfSongs().Count;

            //when
            Assert.AreEqual(expectedAmountOfSongs, actualAmountOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the method allowing to add a single song
        /// In this case, one of songs to add is "null" and must be rejected.
        /// </summary>
        [TestMethod]
        public void TestMethodAddSongFail()
        {
            //given
            //please refer to Init() method
            Song songNullToAdd = null;
            Song songNotNullToAdd = new Song("SongNotNull", 12);
            int expectedAmountOfSongs = 11;
            int actualAmountOfSongs = -1;

            //then
            this.artist.AddSong(songNullToAdd);
            this.artist.AddSong(songNotNullToAdd);
            actualAmountOfSongs = this.artist.ListOfSongs().Count;

            //when
            Assert.AreEqual(expectedAmountOfSongs, actualAmountOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the method allowing to add a list of songs
        /// </summary>
        [TestMethod]
        public void TestMethodAddListOfSongsSucess()
        {
            //given
            //please refer to Init() method
            List<Song> listOfSongsToAdd = new List<Song>();
            for (int i = 0; i < 10; i++)
            {
                Song song = new Song("SongToAdd" + i.ToString(), i + 60);
                listOfSongsToAdd.Add(song);
            }
            int expectedAmountOfSongs = 20;
            int actualAmountOfSongs = -1;

            //then
            this.artist.AddSong(listOfSongsToAdd);
            actualAmountOfSongs = this.artist.ListOfSongs().Count;

            //when
            Assert.AreEqual(expectedAmountOfSongs, actualAmountOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the method allowing to add a list of songs
        /// In this case, the list of song is "null" and must be rejected.
        /// </summary>
        [TestMethod]
        public void TestMethodAddListOfSongsFail()
        {
            //given
            //please refer to Init() method
            List<Song> listOfSongsToAddNull = null;
            Song songToAdd = new Song("Song to add", 12);
            List<Song> listOfSongToAddNotNull = new List<Song>();
            listOfSongToAddNotNull.Add(songToAdd);

            int expectedAmountOfSongs = 11;
            int actualAmountOfSongs = -1;

            //then
            this.artist.AddSong(listOfSongsToAddNull);
            this.artist.AddSong(listOfSongToAddNotNull);
            actualAmountOfSongs = this.artist.ListOfSongs().Count;

            //when
            Assert.AreEqual(expectedAmountOfSongs, actualAmountOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the method allowing to add a list of songs
        /// In this case, the list of song contains a "null" song.
        /// Only the "null" song must be rejected. The others must be added.
        /// </summary>
        [TestMethod]
        public void TestMethodAddListOfSongsRejectNullSongSuccess()
        {
            //given
            //please refer to Init() method
            List<Song> listOfSongsToAdd = new List<Song>();
            for (int i = 0; i < 10; i++)
            {
                Song song = new Song("SongToAdd" + i.ToString(), i + 60);
                listOfSongsToAdd.Add(song);
            }
            Song emptySong = null;
            listOfSongsToAdd.Add(emptySong);//11th songs, must be rejected

            int expectedAmountOfSongs = 20;
            int actualAmountOfSongs = -1;

            //then
            this.artist.AddSong(listOfSongsToAdd);
            actualAmountOfSongs = this.artist.ListOfSongs().Count;

            //when
            Assert.AreEqual(expectedAmountOfSongs, actualAmountOfSongs);
        }

        /// <summary>
        /// This test method is designed to test the method returning the total duration
        /// of a list of songs for a specific artist.
        /// In this case, the list of song contains songs. This is the basic case to test.
        /// </summary>
        [TestMethod]
        public void TestMethodSongsTotalDurationSuccess()
        {
            //given
            //please refer to Init() method
            this.expectedSongsTotalDuration = 645;
            int actualSongsTotalDuration = 0;

            //then
            actualSongsTotalDuration = this.artist.SongsTotalDuration();

            //when
            Assert.AreEqual(expectedSongsTotalDuration, actualSongsTotalDuration);
        }

        /// <summary>
        /// This test method is designed to test the method returning the longest song's duration 
        /// of an artist'list of songs
        /// In this case, the list of song contains songs. This is the basic case to test.
        /// </summary>
        [TestMethod]
        public void TestMethodUpdateLongestSongDurationSuccess()
        {
            //given
            //please refer to Init() method
            this.expectedLongestSongDuration = 69;
            int actualLongestSongDuration = -1;

            //then
            actualLongestSongDuration = this.artist.LongestSongDuration();

            //when
            Assert.AreEqual(expectedLongestSongDuration, actualLongestSongDuration);
        }

        /// <summary>
        /// This test method is designed to test the method returning the shortest song's duration 
        /// of an artist'list of songs
        /// In this case, the list of song contains songs. This is the basic case to test.
        /// </summary>
        [TestMethod]
        public void TestMethodUpdateShortestSongDurationSuccess()
        {
            //given
            //please refer to Init() method
            this.expectedShortestSongDuration = 60;
            int actualShortestSongDuration = -1;

            //then
            actualShortestSongDuration = this.artist.ShortestSongDuration();

            //when
            Assert.AreEqual(expectedShortestSongDuration, actualShortestSongDuration);
        }

        /// <summary>
        /// This test method is designed to test the method returning the average song's duration 
        /// of an artist'list of songs
        /// In this case, the list of song contains songs. This is the basic case to test.
        /// </summary>
        [TestMethod]
        public void TestMethodUpdateAverageSongDurationSuccess()
        {
            //given
            //please refer to Init() method
            this.expectedAverageSongDuration = 64;
            int actualAverageSongDuration = -1;

            //then
            actualAverageSongDuration = this.artist.AverageSongDuration();

            //when
            Assert.AreEqual(expectedAverageSongDuration, actualAverageSongDuration);
        }

        /// <summary>
        /// This test method is designed to test the method returning the total duration
        /// of a list of songs for a specific artist.
        /// In this case, the list of song contains songs. This is the basic case to test.
        /// </summary>
        [TestMethod]
        public void TestMethodMedianDurationSuccess()
        {
            //given
            //please refer to Init() method
            this.expectedMedianSongDuration = 65;
            int actualMedianSongDuration = 0;

            //then
            actualMedianSongDuration = this.artist.MedianSonggDuration();

            //when
            Assert.AreEqual(expectedMedianSongDuration, actualMedianSongDuration);
        }

        /// <summary>
        /// This test method cleanup variables and objects used for the last test session.
        /// Run after each test method.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            this.artist = null;
        }
    }
}
