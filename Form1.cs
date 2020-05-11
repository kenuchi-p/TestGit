using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KLib2;

namespace TestGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuShowMessageBox_Click(object sender, EventArgs e)
        {
//            Message.Beep();
//            MessageBox.Show("Helloこんにちは");
//            MessageBox.Show("Hello World");
//            MessageBox.Show("Hello Git"); // コメント付け
            MessageBox.Show("Gitのテスト");
//            Log.t("Gitのテスト");
//            Log.t("Gitのテスト02");
            Log.t("Gitのテスト03");
//            Log.t("Gitのテスト04");
        }
    }
}
