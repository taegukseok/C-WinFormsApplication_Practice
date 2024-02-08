using Albums;

namespace AlbumRegistry
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblMessages.Text = "";
            UpdateControls(AppState.AwaitingAlbum);

            try
            {
                _albumManager = new AlbumManager();
                LoadAlbumsInListBox();
            }
            catch (Exception)
            {
                SetErrorMessage("Hmmm, there was a problem loading albums from the file.");
            }
        }

        private void btnCreateNewAlbum_Click(object sender, EventArgs e)
        {
            UpdateControls(AppState.AddingAlbum);
            _currentAlbum = new Album();
            _currentAlbum.AlbumId = _albumManager.GetNextAlbumId();
            txtAlbumId.Text = $"{_currentAlbum.AlbumId}";
        }
        private void btnSaveAlbum_Click(object sender, EventArgs e)
        {
            HandleAddOrEdit();
        }

        private void btnUpdateAlbum_Click(object sender, EventArgs e)
        {
            HandleAddOrEdit();
        }

        private void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            if (_currentAlbum == null)
            {
                SetErrorMessage("No active album - please select or create a new album first.");
                return;
            }

            _albumManager.DeleteAlbumById(_currentAlbum.AlbumId);
            LoadAlbumsInListBox();
            UpdateControls(AppState.AwaitingAlbum);
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxAlbums.SelectedIndex;
            if (selectedIndex == -1)
                return;

            UpdateControls(AppState.EditingAlbum);
            LoadAlbumBySelectedIndex(selectedIndex);
        }

        private void LoadAlbumBySelectedIndex(int selectedIndex)
        {
            Album? selectedAlbum = listBoxAlbums.Items[selectedIndex] as Album;
            if (selectedAlbum != null)
            {
                _currentAlbum = _albumManager.GetAlbumById(selectedAlbum.AlbumId);
                txtAlbumId.Text = _currentAlbum.AlbumId.ToString();
                txtBandOrArtist.Text = _currentAlbum.BandOrArtistName;
                txtTitle.Text = _currentAlbum.Title;
                if (_currentAlbum.YearProduced != null)
                    txtYearProduced.Text = _currentAlbum.YearProduced.ToString();
                else
                    txtYearProduced.Text = "";
            }
        }

        private void LoadAlbumsInListBox()
        {
            listBoxAlbums.Items.Clear();

            List<Album> albums = _albumManager.GetAllAlbums();
            foreach (Album album in albums)
            {
                listBoxAlbums.Items.Add(album);
            }
        }

        private void HandleAddOrEdit()
        {
            if (_currentAlbum == null)
            {
                SetErrorMessage("No active album - please select or create a new album first.");
                return;
            }

            string errMsg = "";

            string bandOrArtist = txtBandOrArtist.Text.Trim();
            if (string.IsNullOrEmpty(bandOrArtist))
                errMsg += "A Band/Artist is required - please enter one.\n";

            string albumTitle = txtTitle.Text.Trim();
            if (string.IsNullOrEmpty(albumTitle))
                errMsg += "An album title is required - please enter one.\n";

            int? yearProduced;
            string yearProducedStr = txtYearProduced.Text.Trim();
            if (string.IsNullOrEmpty(yearProducedStr))
            {
                yearProduced = null;
            }
            else
            {
                int yearProducedTemp;
                if (int.TryParse(yearProducedStr, out yearProducedTemp))
                {
                    yearProduced = yearProducedTemp;
                }
                else
                {
                    yearProduced = null;
                    errMsg += "Year produced must be entered as a positive integer for the year";
                }
            }

            if (errMsg == "")
            {
                _currentAlbum.BandOrArtistName = bandOrArtist;
                _currentAlbum.Title = albumTitle;
                _currentAlbum.YearProduced = yearProduced;

                if (_currentAppState == AppState.AddingAlbum)
                {
                    _albumManager.AddAlbum(_currentAlbum);

                    listBoxAlbums.Items.Add(_currentAlbum);
                    int currCount = listBoxAlbums.Items.Count;
                    listBoxAlbums.SelectedIndex = currCount - 1;

                    UpdateControls(AppState.EditingAlbum);
                    SetInfoMessage("New album was added.");
                }
                else if (_currentAppState == AppState.EditingAlbum)
                {
                    _albumManager.UpdateAlbum(_currentAlbum);
                    LoadAlbumsInListBox();
                    SetInfoMessage("Album was updated.");
                }
            }
            else
            {
                SetErrorMessage(errMsg);
            }
        }

        // A helper method that updates the current state with the
        // arg passed and then updates to UI controls accordingly
        // based on that new state.
        private void UpdateControls(AppState newState)
        {
            _currentAppState = newState;

            if (_currentAppState == AppState.AwaitingAlbum)
            {
                listBoxAlbums.SelectedIndex = -1;

                // reset all content:
                txtAlbumId.Text = "";
                txtBandOrArtist.Text = "";
                txtTitle.Text = "";
                txtYearProduced.Text = "";

                // disable most controls:
                txtBandOrArtist.Enabled = false;
                txtTitle.Enabled = false;
                txtYearProduced.Enabled = false;

                btnSaveAlbum.Enabled = false;
                btnDeleteAlbum.Enabled = false;
                btnUpdateAlbum.Enabled = false;
            }
            else if (_currentAppState == AppState.AddingAlbum)
            {
                txtBandOrArtist.Text = "";
                txtTitle.Text = "";
                txtYearProduced.Text = "";

                txtBandOrArtist.Enabled = true;
                txtTitle.Enabled = true;
                txtYearProduced.Enabled = true;

                btnSaveAlbum.Enabled = true;
                btnDeleteAlbum.Enabled = false;
                btnUpdateAlbum.Enabled = false;
            }
            else if (_currentAppState == AppState.EditingAlbum)
            {
                txtBandOrArtist.Enabled = true;
                txtTitle.Enabled = true;
                txtYearProduced.Enabled = true;

                btnSaveAlbum.Enabled = false;
                btnDeleteAlbum.Enabled = true;
                btnUpdateAlbum.Enabled = true;
            }
        }

        private void SetErrorMessage(string msg)
        {
            lblMessages.ForeColor = Color.Red;
            lblMessages.Text = msg;
        }

        private void SetInfoMessage(string msg)
        {
            lblMessages.ForeColor = Color.Black;
            lblMessages.Text = msg;
        }

        private enum AppState { AwaitingAlbum, AddingAlbum, EditingAlbum };

        private AppState _currentAppState = AppState.AwaitingAlbum;

        // a reference to the album currently being added or edited:
        private Album? _currentAlbum = null;

        // This is our object we use to manage all our albums:
        private AlbumManager _albumManager;
    }
}