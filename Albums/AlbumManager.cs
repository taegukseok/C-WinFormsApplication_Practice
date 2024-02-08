using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albums
{
    public class AlbumManager
    {
        /// <summary>
        /// Constructs a new AlbumManager object.
        /// </summary>
        public AlbumManager()
        {
            if (!File.Exists(_filename))
                File.Create(_filename).Dispose();

            ReadAlbumsFromFile();
        }

        /// <summary>
        /// Generates the next available ID for use for Album objects.
        /// </summary>
        /// <returns></returns>
        public int GetNextAlbumId()
        {
            // find the max ID of all the albums we currently have
            // and add 1 to get the new one. First though, if list is empty..
            if (_albums.Count == 0)
            {
                // start with 1:
                return 1;
            }
            else
            {
                // otherwise, we have Album objects in the list so we need to
                // somehow find which one has the maximum AlbumId value:
                var albumWithMaxId = _albums.MaxBy(a => a.AlbumId);
                return albumWithMaxId.AlbumId + 1;
            }
        }

        public List<Album> GetAllAlbums()
        {
            return _albums;
        }

        /// <summary>
        /// Returns the album with the Id passed as a param.
        /// or null if no such Album exists
        /// </summary>
        public Album? GetAlbumById(int albumId)
        {
            return _albums.Where(a => a.AlbumId == albumId).FirstOrDefault();
        }

        /// <summary>
        /// Deletes the album with the Id passed as a param.
        /// </summary>
        public void DeleteAlbumById(int albumId)
        {
            _albums.RemoveAll(a => a.AlbumId == albumId);
            WriteAlbumsToFile();
        }

        /// <summary>
        /// Updates the album with the Id passed as a param.
        /// </summary>
        public void UpdateAlbum(Album album)
        {
            if (album != null)
            {
                int albumIndex = _albums.FindIndex(a => a.AlbumId == album.AlbumId);
                if (albumIndex != -1)
                {
                    _albums[albumIndex] = album;
                    WriteAlbumsToFile();
                }
            }
        }

        /// <summary>
        /// Adds a new album to be maintained by this manager object.
        /// </summary>
        public void AddAlbum(Album album)
        {
            // To properly add this album we need to both add it to
            // our in memory list & then sync that list to the file again:
            _albums.Add(album);
            WriteAlbumsToFile();
        }

        // a helper method that reads from the file, line by line,
        // and uses the "ParseFromFileRecord" method parse that
        // line/record into an album and add it to the in-memory list
        private void ReadAlbumsFromFile()
        {
            using (StreamReader reader = new StreamReader(_filename))
            {
                _albums.Clear();

                while (!reader.EndOfStream)
                {
                    string? albumRecord = reader.ReadLine();
                    if (albumRecord != null)
                    {
                        Album album = ParseFromFileRecord(albumRecord);
                        _albums.Add(album);
                    }
                }
            }
        }

        // A helper method that writes each album object in the in-memory
        // list to file - i.e. 1 object is written to 1 line/file record
        // by separating the props using | as a delimiter using the
        // "WriteToFileRecord" method.
        private void WriteAlbumsToFile()
        {
            using (StreamWriter writer = new StreamWriter(_filename))
            {
                foreach (var album in _albums)
                {
                    writer.WriteLine(WriteToFileRecord(album));
                }
            }
        }

        // Writes an Album object to a string representing a 
        // file record with props delimited by |
        private static string WriteToFileRecord(Album album)
        {
            return album.AlbumId.ToString() + "|" + album.BandOrArtistName + "|" + album.Title + "|" +
                    ((album.YearProduced == null) ? "" : album.YearProduced.ToString());
        }

        // Writes a string representing a file record with props delimited
        // by | into an Album object.
        private static Album ParseFromFileRecord(string fileRecord)
        {
            string[] albumFields = fileRecord.Split('|');

            int yearProduced;
            bool isValidAlbumYear = int.TryParse(albumFields[3], out yearProduced);

            int albumId;
            if (!int.TryParse(albumFields[0], out albumId))
            {
                throw new FormatException($"\"{albumId}\" is not a valid integer for use as an Album ID");
            }

            if (isValidAlbumYear)
            {
                return new Album() { 
                    AlbumId = albumId, 
                    BandOrArtistName = albumFields[1], 
                    Title = albumFields[2], 
                    YearProduced = yearProduced
                };
            }
            else
            {
                return new Album() { 
                    AlbumId = albumId, 
                    BandOrArtistName = albumFields[1], 
                    Title = albumFields[2] 
                };
            }
        }

        // the name for the file we are storing albums in:
        private readonly string _filename = @"albums.txt";

        // Our list of in-memory albums this object maintains, and endeavours
        // to keep in sync with what's stored in the file.
        private List<Album> _albums = new List<Album>();
    }
}
