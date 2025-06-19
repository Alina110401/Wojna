using System;
using System.Windows.Forms;
namespace Wojna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string nickname = txtNickname.Text.Trim();
            if (string.IsNullOrEmpty(nickname))
            {
                MessageBox.Show("Podaj sw�j nick, aby zagra�.");
                return;
            }

            Form1 gameForm = new Form1(nickname);
            gameForm.Show();
        }
    }
}
// GameStartForm.cs - formularz pocz�tkowy

