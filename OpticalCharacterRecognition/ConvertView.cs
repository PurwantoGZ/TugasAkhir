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
namespace OpticalCharacterRecognition
{
    public partial class ConvertView : MetroForm
    {
        public ConvertView()
        {
            InitializeComponent();
        }
        public ConvertView(RichTextBox richText)
        {
            InitializeComponent();
            TextConvert = richText;
        }
    }
}
