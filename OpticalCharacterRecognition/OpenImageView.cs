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
    public partial class OpenImageView : MetroForm
    {
        public OpenImageView()
        {
            InitializeComponent();
        }
        public OpenImageView(OpenFileDialog ofd)
        {
            InitializeComponent();
            SourceImage.Image = Image.FromFile(ofd.FileName);
        }
    }
}
