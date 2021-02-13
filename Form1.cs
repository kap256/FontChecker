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

namespace FontChecker
{
    public partial class Form1 : Form
    {

        List<UserControl1> mFonts=new List<UserControl1>();
        public Form1()
        {
            InitializeComponent();
            FontSet.Text = FontSet.Items[0].ToString();

        }
        private void AddFontFamily(string font)
        {
            Debug.WriteLine(font);
            var sep = new Label();
            sep.Text = $"■{font}===============================================================================";
            sep.BackColor = Color.AntiqueWhite;
            sep.Height = 16;
            sep.Width = FontsPanel.Width - 32;
            FontsPanel.Controls.Add(sep);
            AddFont(font);
            AddFont(font, FontStyle.Bold);
            AddFont(font, FontStyle.Italic);
            AddFont(font, FontStyle.Bold | FontStyle.Italic);
        }
        private void AddFont(string font, FontStyle style = FontStyle.Regular)
        {
            var ctrl = new UserControl1(font,style);
            FontsPanel.Controls.Add(ctrl);
            mFonts.Add(ctrl);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        private void FontSet_TextChanged(object sender, EventArgs e)
        {
            for(int i=0;i< FontSet.Items.Count; i++) {
                if(FontSet.Text == FontSet.Items[i].ToString()) {
                    FontsPanel.Controls.Clear();
                    mFonts.Clear();
                    switch(i) {
                        case 0:
                            foreach(var font in Fonts.ToList(Fonts.Win7)) {
                                AddFontFamily(font);
                            }
                            break;
                        case 1:
                            foreach(var font in Fonts.ToList(Fonts.Win10)) {
                                AddFontFamily(font);
                            }
                            break;
                        case 2:
                            foreach(var font in Fonts.GetInstalledFonts()) {
                                AddFontFamily(font);
                            }
                            break;

                    }
                    break;
                }
            }
        }
    }
}
