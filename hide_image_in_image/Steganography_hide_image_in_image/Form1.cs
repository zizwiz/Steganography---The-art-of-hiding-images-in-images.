using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace hide_image_in_image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hide and then recover the image.
        private void btnGo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            int num_bits = (int) nudHiddenBits.Value;

            // Hide the image.
            picCombined.Image = Stego.HideImage(
                (Bitmap) picVisible.Image,
                (Bitmap) picHidden.Image, num_bits);

            // Recover the hidden image.
            picRecovered.Image = Stego.RecoverImage(
                (Bitmap) picCombined.Image, (Bitmap) picHidden.Image, (Bitmap)picVisible.Image, num_bits);
            Cursor = Cursors.Default;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Open Image",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "BMP",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                         "All files (*.*)|*.*",
                FilterIndex = 0,
                RestoreDirectory = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
            }

            if (rdobtn_open_hidden.Checked)
            {
                picHidden.Image = new Bitmap(filename);
            }
            else
            {
                picVisible.Image = new Bitmap(filename);
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (((picVisible.Image == null) && (rdobtn_save_visible.Checked)) ||
                ((picHidden.Image == null) && (rdobtn_save_hidden.Checked)) ||
                ((picCombined.Image == null) && (rdobtn_save_combined.Checked)) ||
                ((picRecovered.Image == null) && (rdobtn_save_recovered.Checked)))
            {
                MessageBox.Show("You do not have an image to save.");
            }
            else
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter =
                        "Lossless Image Files | *.bmp; *.png; *.tiff | Lossy Image Files| *.jpg; *.gif | All Files | *.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;


                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            FileInfo file_info = new FileInfo(saveFileDialog.FileName);

                            switch (file_info.Extension)
                            {
                                case ".png":
                                    if (rdobtn_save_visible.Checked) picVisible.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                                    else if (rdobtn_save_hidden.Checked) picHidden.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                                    else if (rdobtn_save_combined.Checked) picCombined.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                                    else if (rdobtn_save_recovered.Checked) picRecovered.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                                    else MessageBox.Show("Error saving image");
                                    break;
                                case ".bmp":
                                    if (rdobtn_save_visible.Checked) picVisible.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                                    else if (rdobtn_save_hidden.Checked) picHidden.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                                    else if (rdobtn_save_combined.Checked) picCombined.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                                    else if (rdobtn_save_recovered.Checked) picRecovered.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                                    else MessageBox.Show("Error saving image");
                                    break;
                                case ".gif":
                                    if (rdobtn_save_visible.Checked) picVisible.Image.Save(saveFileDialog.FileName, ImageFormat.Gif);
                                    else if (rdobtn_save_hidden.Checked) picHidden.Image.Save(saveFileDialog.FileName, ImageFormat.Gif);
                                    else if (rdobtn_save_combined.Checked) picCombined.Image.Save(saveFileDialog.FileName, ImageFormat.Gif);
                                    else if (rdobtn_save_recovered.Checked) picRecovered.Image.Save(saveFileDialog.FileName, ImageFormat.Gif);
                                    else MessageBox.Show("Error saving image");
                                    break;
                                case ".tiff":
                                case ".tif":
                                    if (rdobtn_save_visible.Checked) picVisible.Image.Save(saveFileDialog.FileName, ImageFormat.Tiff);
                                    else if (rdobtn_save_hidden.Checked) picHidden.Image.Save(saveFileDialog.FileName, ImageFormat.Tiff);
                                    else if (rdobtn_save_combined.Checked) picCombined.Image.Save(saveFileDialog.FileName, ImageFormat.Tiff);
                                    else if (rdobtn_save_recovered.Checked) picRecovered.Image.Save(saveFileDialog.FileName, ImageFormat.Tiff);
                                    else MessageBox.Show("Error saving image");
                                    break;
                                case ".jpg":
                                case ".jpeg":
                                    if (rdobtn_save_visible.Checked) picVisible.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                                    else if (rdobtn_save_hidden.Checked) picHidden.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                                    else if (rdobtn_save_combined.Checked) picCombined.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                                    else if (rdobtn_save_recovered.Checked) picRecovered.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                                    else MessageBox.Show("Error saving image");
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_ver.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                rdobtn_open_visible.Checked = true;
                rdobtn_open_hidden.Checked = false;
                rdobtn_save_visible.Checked = true;
                rdobtn_save_hidden.Checked = false;
                rdobtn_save_combined.Checked = false;
                rdobtn_save_recovered.Checked = false;
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                rdobtn_open_visible.Checked = false;
                rdobtn_open_hidden.Checked = true;
                rdobtn_save_visible.Checked = false;
                rdobtn_save_hidden.Checked = true;
                rdobtn_save_combined.Checked = false;
                rdobtn_save_recovered.Checked = false;
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                rdobtn_open_visible.Checked = true;
                rdobtn_open_hidden.Checked = false;
                rdobtn_save_visible.Checked = false;
                rdobtn_save_hidden.Checked = false;
                rdobtn_save_combined.Checked = true;
                rdobtn_save_recovered.Checked = false;
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                rdobtn_open_visible.Checked = true;
                rdobtn_open_hidden.Checked = false;
                rdobtn_save_visible.Checked = false;
                rdobtn_save_hidden.Checked = false;
                rdobtn_save_combined.Checked = false;
                rdobtn_save_recovered.Checked = true;
            }
        }
    }
}
