using Albums;

AlbumManager albumManager = new AlbumManager();
List<Album> albums = albumManager.GetAllAlbums();
foreach (Album album in albums)
    Console.WriteLine(album);