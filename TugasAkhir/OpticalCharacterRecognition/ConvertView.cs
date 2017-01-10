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
    public partial class ConvertView : MetroForm
    {
        public string hasil="";
        public ConvertView()
        {
            InitializeComponent();
        }

        public ConvertView(string result)
        {
            InitializeComponent();
            TextConvert.Text = result;
            hasil = result;
        }

        public void SaveAs(string filetype)
        {
            saveFileDialog1.FileName = "Simpan";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = filetype;
            saveFileDialog1.Title = "Save As";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.FileName.Length > 0)
                {
                    //GetCurrentDocument.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    //TextConvert.SaveFile(saveFileDialog1.FileName);
                    // Set Store Image Content text file Path
                    String StoreTextFilePath = AppDomain.CurrentDomain.BaseDirectory + "SampleText.doc";
                    // Store Image Content in Text File
                    FileStream CreateFileObj = new FileStream(StoreTextFilePath, FileMode.Create);
                    //save the image text in the text file 
                    StreamWriter WriteFileObj = new StreamWriter(CreateFileObj);
                    WriteFileObj.Write(hasil);
                    WriteFileObj.Close();
                }
            }
        }
    }
}
