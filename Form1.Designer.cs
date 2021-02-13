
namespace FontChecker
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.FontsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.FontSet = new System.Windows.Forms.ComboBox();
            this.FontSize = new System.Windows.Forms.TextBox();
            this.SampleText = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FontsPanel
            // 
            this.FontsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FontsPanel.AutoScroll = true;
            this.FontsPanel.Location = new System.Drawing.Point(12, 32);
            this.FontsPanel.Name = "FontsPanel";
            this.FontsPanel.Size = new System.Drawing.Size(1560, 800);
            this.FontsPanel.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1236, 840);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(336, 12);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://helpx.adobe.com/jp/x-productkb/global/cq08041028.html";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1195, 840);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 12);
            label1.TabIndex = 2;
            label1.Text = "参考：";
            // 
            // FontSet
            // 
            this.FontSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSet.FormattingEnabled = true;
            this.FontSet.Items.AddRange(new object[] {
            "Window7標準",
            "Window10標準",
            "インストール済み全て"});
            this.FontSet.Location = new System.Drawing.Point(83, 6);
            this.FontSet.Name = "FontSet";
            this.FontSet.Size = new System.Drawing.Size(155, 20);
            this.FontSet.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 12);
            label2.TabIndex = 4;
            label2.Text = "フォントセット";
            // 
            // FontSize
            // 
            this.FontSize.Location = new System.Drawing.Point(328, 7);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(57, 19);
            this.FontSize.TabIndex = 5;
            this.FontSize.Text = "16";
            // 
            // SampleText
            // 
            this.SampleText.Location = new System.Drawing.Point(495, 6);
            this.SampleText.Name = "SampleText";
            this.SampleText.Size = new System.Drawing.Size(405, 19);
            this.SampleText.TabIndex = 6;
            this.SampleText.Text = "Sample";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(288, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(34, 12);
            label3.TabIndex = 7;
            label3.Text = "サイズ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(391, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(17, 12);
            label4.TabIndex = 8;
            label4.Text = "px";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(454, 10);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(29, 12);
            label5.TabIndex = 9;
            label5.Text = "例文";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(917, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "更新";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.SampleText);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(label2);
            this.Controls.Add(this.FontSet);
            this.Controls.Add(label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.FontsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "フォント一式を比較したい";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FontsPanel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox FontSet;
        private System.Windows.Forms.TextBox FontSize;
        private System.Windows.Forms.TextBox SampleText;
        private System.Windows.Forms.Button UpdateButton;
    }
}

