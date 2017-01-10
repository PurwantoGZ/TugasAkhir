using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace OpticalCharacterRecognition
{
    public partial class MainView : MetroForm
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public MainView()
        {
            InitializeComponent();
        }
        public string FileNameImage = null;
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void newImageTool_Click(object sender, EventArgs e)
        {
            using (ofd)
            {
                ofd.Title = "Open Image Training";
                ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    OpenImageView openimage =new OpenImageView(ofd);
                    FileNameImage = ofd.FileName;
                    newImageTool.Enabled = false;
                    enabletool(true);
                    OpentoolStripMenuItem.Enabled = false;
                    openimage.MdiParent = this;
                    openimage.FormClosed += new FormClosedEventHandler(openimageclosed);
                    openimage.Show();
                }
            }
        }

        private void openimageclosed(object sender, FormClosedEventArgs e)
        {
            newImageTool.Enabled = true;
            OpentoolStripMenuItem.Enabled = true;
            enabletool(false);
        }

        private void OpentoolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ofd)
            {
                ofd.Title = "Open Image Training";
                ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    OpenImageView openimage = new OpenImageView(ofd);
                    newImageTool.Enabled = false;
                    FileNameImage = ofd.FileName;
                    enabletool(true);
                    OpentoolStripMenuItem.Enabled = false;
                    openimage.MdiParent = this;
                    openimage.FormClosed += new FormClosedEventHandler(openimageclosed);
                    openimage.Show();
                }
            }
        }

        private void toolSave2Pdf_Click(object sender, EventArgs e)
        {

        }

        private void toolSave2Text_Click(object sender, EventArgs e)
        {

        }

        private void toolZoomIn_Click(object sender, EventArgs e)
        {

        }

        private void toolZoomOut_Click(object sender, EventArgs e)
        {

        }

        private void toolRotate_Click(object sender, EventArgs e)
        {
            
        }

        private void toolConvert_Click(object sender, EventArgs e)
        {
            var convert = new OCR();
            RichTextBox richText = new RichTextBox();
            convert.ReadTextFromImage(FileNameImage,ref richText);

            ConvertView convertview = new ConvertView(richText);
            convertview.MdiParent = this;
            toolConvert.Enabled = false;
            
            convertview.FormClosed += new FormClosedEventHandler(convertviewclosed);
            convertview.Show();
        }

        private void convertviewclosed(object sender, FormClosedEventArgs e)
        {
            toolConvert.Enabled = true;
        }

        private void enabletool(bool state)
        {
            toolSave2Pdf.Enabled = state;
            toolSave2Text.Enabled = state;
            toolZoomIn.Enabled = state;
            toolZoomOut.Enabled = state;
            toolZoomOut.Enabled = state;
            toolRotate.Enabled = state;
            toolConvert.Enabled = state;
        }
    }
    public class OCR
    {
        public OCR()
        {

        }


        public int jumlahKarakter(string sentence)
        {
            int result = 0;
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                var character = sentence.ToCharArray();
                foreach (char item in character)
                {
                    result++;
                }
            }
            else
            {
                throw new Exception("bummer no data and stuff");
            }
            return result;
        }

        #region ConvertImage2Text
        public void ReadTextFromImage(String ImagePath, ref string result)
        {
            try
            {
                // Grab Text From Image
                MODI.Document ModiObj = new MODI.Document();
                ModiObj.Create(ImagePath);
                ModiObj.OCR(MODI.MiLANGUAGES.miLANG_ENGLISH, true, true);

                //Retrieve the text gathered from the image
                MODI.Image ModiImageObj = (MODI.Image)ModiObj.Images[0];

                // Set Store Image Content text file Path
                String StoreTextFilePath = AppDomain.CurrentDomain.BaseDirectory + "SampleText.doc";
                // Store Image Content in Text File
                FileStream CreateFileObj = new FileStream(StoreTextFilePath, FileMode.Create);
                //save the image text in the text file 
                StreamWriter WriteFileObj = new StreamWriter(CreateFileObj);
                WriteFileObj.Write(ModiImageObj.Layout.Text);
                WriteFileObj.Close();

                result = ModiImageObj.Layout.Text;
                System.Console.WriteLine(ModiImageObj.Layout.Text);
                //ConvertText.Text = ModiImageObj.Layout.Text;

                ModiObj.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }

}
