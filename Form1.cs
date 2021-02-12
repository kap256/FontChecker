using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontChecker
{
    public partial class Form1 : Form
    {
        List<UserControl1> mFonts=new List<UserControl1>();
        public Form1()
        {
            InitializeComponent();

            AddFonts("メイリオ");
            AddFonts("游ゴシック");
            AddFonts("Arial");
            AddFonts("MS UI Gothic");

        }
        private void AddFonts(string name)
        {
            var ctrl = new UserControl1(name);
            FontsPanel.Controls.Add(ctrl);
            mFonts.Add(ctrl);

        }
    }
}
