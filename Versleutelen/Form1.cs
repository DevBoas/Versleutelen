using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Versleutelen
{
    public partial class Form1 : Form
    {
        string password = "pEb#ozZ$@$w3*yqRGX$26Um64L71i!&qRY2T6aEt$GgHASpDIyrKo$77R4gmQ45VDF4aeKXXip097sehJ784kuRv9P";

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Encrypt_Click(object sender, EventArgs e)
        {
            string userInput = TxtBox_User_Input.Text;
            DESEncrypt encryptClass = new DESEncrypt();
            string encText = encryptClass.EncryptString(userInput, password);
            TxtBox_User_Input.Text = encText;
        }

        private void Btn_Decrypt_Click(object sender, EventArgs e)
        {
            string userInput = TxtBox_User_Input.Text;
            DESEncrypt encryptClass = new DESEncrypt();
            string plain = encryptClass.DecryptString(userInput, password);
            TxtBox_User_Input.Text = plain;
        }

    }
}
