using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            QRCoder.QRCodeGenerator Qg = new QRCoder.QRCodeGenerator();
            var data = Qg.CreateQrCode(TB.Text,QRCoder.QRCodeGenerator.ECCLevel.H);
            var Pic = new QRCoder.QRCode(data);
            PB.Image = Pic.GetGraphic(50);                  
         }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "files (*.PNG)|*.PNG | png (*.png)|*.png";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PB.Image.Save(saveFileDialog1.FileName);
            } 
                
                    
                    }
    }
}
