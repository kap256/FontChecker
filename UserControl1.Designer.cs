
namespace FontChecker
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.BoxFontName = new System.Windows.Forms.GroupBox();
            this.LabelSample = new System.Windows.Forms.Label();
            this.BoxFontName.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxFontName
            // 
            this.BoxFontName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxFontName.Controls.Add(this.LabelSample);
            this.BoxFontName.Location = new System.Drawing.Point(5, 3);
            this.BoxFontName.Name = "BoxFontName";
            this.BoxFontName.Size = new System.Drawing.Size(507, 54);
            this.BoxFontName.TabIndex = 1;
            this.BoxFontName.TabStop = false;
            this.BoxFontName.Text = "FontName";
            // 
            // LabelSample
            // 
            this.LabelSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSample.AutoSize = true;
            this.LabelSample.Location = new System.Drawing.Point(6, 15);
            this.LabelSample.Name = "LabelSample";
            this.LabelSample.Size = new System.Drawing.Size(42, 12);
            this.LabelSample.TabIndex = 0;
            this.LabelSample.Text = "Sample";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BoxFontName);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(515, 57);
            this.BoxFontName.ResumeLayout(false);
            this.BoxFontName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxFontName;
        private System.Windows.Forms.Label LabelSample;
    }
}
