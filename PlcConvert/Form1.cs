using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlcConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertPlc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMesWord.Text))
                return;

            txtPlcWord.Text = string.Empty;
            var str = txtMesWord.Text;
            var bytes = Encoding.ASCII.GetBytes(str);
            var words = new UInt16[Convert.ToInt32(txtWordArray.Text)];

            int j = 0;
            for (var i = 0; i < words.Length; i++)
            {
                //int shift = bytes[j] << 8 | bytes[j - 1];
                //words[i] += shift;

                if (bytes.Length <= j * 2)
                {
                    words[i] = 0;
                }
                else
                {
                    words[i] = (UInt16)bytes[j * 2];
                    if (bytes.Length > (j * 2) + 1)
                    {
                        var tempWord = (UInt16)bytes[(j * 2) + 1];
                        words[i] += (UInt16)(tempWord << 8);
                    }
                }

                j++;
            }

            for (var i = 0; i < words.Length; i++)
            {
                txtPlcWord.Text += words[i].ToString();
                txtPlcWord.Text += (words.Length - 1 != i) ? "," : "";
            }

            //int shift = bytes[1] << 8 | bytes[0];
            //txtConvert.Text += shift.ToString();
        }

        private void btnConvertMes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlcWord.Text))
                return;

            txtMesWord.Text = string.Empty;
            string[] values = txtPlcWord.Text.Split(',');

            foreach(var value in values)
            {
                if (string.IsNullOrEmpty(value))
                    continue;

                var bytes = BitConverter.GetBytes(Convert.ToInt16(value));

                for(var i=0; i<bytes.Length; i++)
                {
                    if (bytes[i] == 0)
                        bytes[i] = 32;                    
                }

                txtMesWord.Text += ASCIIEncoding.ASCII.GetString(bytes);
            }
        }
    }
}
