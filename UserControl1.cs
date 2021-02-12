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
    public partial class UserControl1 : UserControl
    {
        private string mFontName="MS UI Gothic";
        public string FontName
        {
            get { return mFontName; }
            set { mFontName = value; UpdateChilds(); }
        }

        private FontStyle mFontStyle=FontStyle.Regular;
        public FontStyle FontStyle
        {
            get { return mFontStyle; }
            set { mFontStyle = value; UpdateChilds(); }
        }
        private int mFontSize=16;
        public int FontSize
        {
            get { return mFontSize; }
            set { mFontSize = value; UpdateChilds(); }
        }

        private string mSampleText="sample";
        public string SampleText
        {
            get { return mSampleText; }
            set { mSampleText = value; UpdateChilds(); }
        }


        public UserControl1(string name, FontStyle style= FontStyle.Regular)
        {
            InitializeComponent();
            mFontName = name;
            mFontStyle = style;
            UpdateChilds();
        }

        private void UpdateChilds()
        {
            LabelSample.Font = new Font(mFontName, mFontSize, mFontStyle);
            LabelSample.Text = mSampleText;
            BoxFontName.Text = $"{mFontName} {LabelSample.Font.Style} - {mFontSize}px";
            if(mFontName != LabelSample.Font.Name) {
                LabelSample.ForeColor = Color.Red;
            }

            this.Width = Math.Max(LabelSample.Width + 20,300);
            this.Height = LabelSample.Height + 20;
        }
    }
}
