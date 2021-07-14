using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mp3_tag_editor
{
    public partial class FormMain : Form
    {
        const TagLib.TagTypes TagType = TagLib.TagTypes.Id3v1;
        TagLib.File currentFile = null;

        Image current_artwork;

        public FormMain()
        {
            InitializeComponent();
            numeric_Year.Value = numeric_Year.Maximum = DateTime.Now.Year;
        }

        private void UpdateArtwork() => pictureBox_Artwork.Image = current_artwork;

        private void getAlbumArtwork()
        {
            try
            {
                current_artwork = Image.FromStream(new MemoryStream(currentFile.Tag.Pictures[0].Data.Data));
                UpdateArtwork();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void Tags_Load()
        {
            try
            {
                textBox_Title.Text = currentFile.Tag.Title;
                textBox_Performers.Text = ArrayToStringFormat(currentFile.Tag.Performers);
                textBox_Artists.Text = ArrayToStringFormat(currentFile.Tag.AlbumArtists);
                textBox_Album.Text = currentFile.Tag.Album;
                numeric_Year.Value = currentFile.Tag.Year;

                textBox_Comment.Text = currentFile.Tag.Comment;
                numeric_TrackNo.Value = currentFile.Tag.Track;
                textBox_Genres.Text = ArrayToStringFormat(currentFile.Tag.Genres);

                getAlbumArtwork();
            }
            catch(Exception exc) { MessageBox.Show(exc.Message); }
        }

        private string ArrayToStringFormat(string[] artists)
        {
            string s = artists[0];
            for (int i = 1; i < artists.Length; i++) s += "; " + artists[i]; 
            return s;
        }

        private string[] StringToArrayFormat(string s)
        {
            string[] items = s.Split(';');
            for (int i = 0; i < items.Length; i++) items[i] = items[i].Trim();
            return items;
        }

        private void button_UploadFile_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Environment.CurrentDirectory;
            fileDialog.Filter = "MP3 Files|*.mp3";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = TagLib.File.Create(fileDialog.FileName);

                textBox_Title.Enabled = textBox_Performers.Enabled = textBox_Album.Enabled =
                    numeric_Year.Enabled = textBox_Comment.Enabled = numeric_TrackNo.Enabled =
                    textBox_Artists.Enabled = textBox_Genres.Enabled = true;

                Tags_Load();
            }
        }

        private void button_ChangeArtwork_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Environment.CurrentDirectory;
            fileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                current_artwork = Image.FromFile(fileDialog.FileName);
                UpdateArtwork();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_SaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                currentFile.Tag.Title = textBox_Title.Text;
                currentFile.Tag.Performers = StringToArrayFormat(textBox_Performers.Text);
                currentFile.Tag.AlbumArtists = StringToArrayFormat(textBox_Artists.Text);
                currentFile.Tag.Album = textBox_Album.Text;
                currentFile.Tag.Year = (uint)numeric_Year.Value;
                currentFile.Tag.Comment = textBox_Comment.Text;
                currentFile.Tag.Track = (uint)numeric_TrackNo.Value;
                currentFile.Tag.Genres = StringToArrayFormat(textBox_Genres.Text);

                currentFile.Tag.Pictures = new TagLib.IPicture[]
                {
                    new TagLib.Picture(
                        new TagLib.ByteVector((byte[])new System.Drawing.ImageConverter()
                        .ConvertTo(current_artwork, typeof(byte[]))))
                };

                currentFile.Save();

                MessageBox.Show("File Successfuly Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }
    }
}
