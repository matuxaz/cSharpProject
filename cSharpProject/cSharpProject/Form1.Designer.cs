namespace cSharpProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cpuBox = new System.Windows.Forms.ComboBox();
            this.mbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.scrapeButton = new System.Windows.Forms.Button();
            this.cpuSocketLabel = new System.Windows.Forms.Label();
            this.cpuPriceLabel = new System.Windows.Forms.Label();
            this.cpuLinkLabel = new System.Windows.Forms.LinkLabel();
            this.mbLinkLabel = new System.Windows.Forms.LinkLabel();
            this.mbPriceLabel = new System.Windows.Forms.Label();
            this.mbSocketLabel = new System.Windows.Forms.Label();
            this.mbChipsetLabel = new System.Windows.Forms.Label();
            this.mbFactorLabel = new System.Windows.Forms.Label();
            this.compTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpuBox
            // 
            this.cpuBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuBox.FormattingEnabled = true;
            this.cpuBox.Location = new System.Drawing.Point(12, 55);
            this.cpuBox.Name = "cpuBox";
            this.cpuBox.Size = new System.Drawing.Size(560, 23);
            this.cpuBox.TabIndex = 0;
            this.cpuBox.SelectedIndexChanged += new System.EventHandler(this.cpuBox_SelectedIndexChanged);
            // 
            // mbBox
            // 
            this.mbBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mbBox.FormattingEnabled = true;
            this.mbBox.Location = new System.Drawing.Point(12, 253);
            this.mbBox.Name = "mbBox";
            this.mbBox.Size = new System.Drawing.Size(560, 23);
            this.mbBox.TabIndex = 1;
            this.mbBox.SelectedIndexChanged += new System.EventHandler(this.mbBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose your parts to check whether they are compatible:";
            // 
            // scrapeButton
            // 
            this.scrapeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scrapeButton.Location = new System.Drawing.Point(396, 9);
            this.scrapeButton.Name = "scrapeButton";
            this.scrapeButton.Size = new System.Drawing.Size(176, 40);
            this.scrapeButton.TabIndex = 3;
            this.scrapeButton.Text = "Get Available parts";
            this.scrapeButton.UseVisualStyleBackColor = true;
            this.scrapeButton.Click += new System.EventHandler(this.scrapeButton_Click);
            // 
            // cpuSocketLabel
            // 
            this.cpuSocketLabel.AutoSize = true;
            this.cpuSocketLabel.Location = new System.Drawing.Point(17, 106);
            this.cpuSocketLabel.Name = "cpuSocketLabel";
            this.cpuSocketLabel.Size = new System.Drawing.Size(45, 15);
            this.cpuSocketLabel.TabIndex = 5;
            this.cpuSocketLabel.Text = "Socket:";
            // 
            // cpuPriceLabel
            // 
            this.cpuPriceLabel.AutoSize = true;
            this.cpuPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpuPriceLabel.Location = new System.Drawing.Point(12, 81);
            this.cpuPriceLabel.Name = "cpuPriceLabel";
            this.cpuPriceLabel.Size = new System.Drawing.Size(61, 25);
            this.cpuPriceLabel.TabIndex = 6;
            this.cpuPriceLabel.Text = "Price:";
            // 
            // cpuLinkLabel
            // 
            this.cpuLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuLinkLabel.AutoSize = true;
            this.cpuLinkLabel.Location = new System.Drawing.Point(396, 81);
            this.cpuLinkLabel.Name = "cpuLinkLabel";
            this.cpuLinkLabel.Size = new System.Drawing.Size(29, 15);
            this.cpuLinkLabel.TabIndex = 7;
            this.cpuLinkLabel.TabStop = true;
            this.cpuLinkLabel.Text = "Link";
            this.cpuLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cpuLinkLabel_LinkClicked);
            // 
            // mbLinkLabel
            // 
            this.mbLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbLinkLabel.AutoSize = true;
            this.mbLinkLabel.Location = new System.Drawing.Point(396, 279);
            this.mbLinkLabel.Name = "mbLinkLabel";
            this.mbLinkLabel.Size = new System.Drawing.Size(29, 15);
            this.mbLinkLabel.TabIndex = 11;
            this.mbLinkLabel.TabStop = true;
            this.mbLinkLabel.Text = "Link";
            this.mbLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mbLinkLabel_LinkClicked);
            // 
            // mbPriceLabel
            // 
            this.mbPriceLabel.AutoSize = true;
            this.mbPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mbPriceLabel.Location = new System.Drawing.Point(12, 279);
            this.mbPriceLabel.Name = "mbPriceLabel";
            this.mbPriceLabel.Size = new System.Drawing.Size(61, 25);
            this.mbPriceLabel.TabIndex = 10;
            this.mbPriceLabel.Text = "Price:";
            // 
            // mbSocketLabel
            // 
            this.mbSocketLabel.AutoSize = true;
            this.mbSocketLabel.Location = new System.Drawing.Point(12, 319);
            this.mbSocketLabel.Name = "mbSocketLabel";
            this.mbSocketLabel.Size = new System.Drawing.Size(45, 15);
            this.mbSocketLabel.TabIndex = 9;
            this.mbSocketLabel.Text = "Socket:";
            // 
            // mbChipsetLabel
            // 
            this.mbChipsetLabel.AutoSize = true;
            this.mbChipsetLabel.Location = new System.Drawing.Point(12, 304);
            this.mbChipsetLabel.Name = "mbChipsetLabel";
            this.mbChipsetLabel.Size = new System.Drawing.Size(50, 15);
            this.mbChipsetLabel.TabIndex = 12;
            this.mbChipsetLabel.Text = "Chipset:";
            // 
            // mbFactorLabel
            // 
            this.mbFactorLabel.AutoSize = true;
            this.mbFactorLabel.Location = new System.Drawing.Point(12, 334);
            this.mbFactorLabel.Name = "mbFactorLabel";
            this.mbFactorLabel.Size = new System.Drawing.Size(74, 15);
            this.mbFactorLabel.TabIndex = 13;
            this.mbFactorLabel.Text = "Form Factor:";
            // 
            // compTitle
            // 
            this.compTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.compTitle.AutoSize = true;
            this.compTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.compTitle.Location = new System.Drawing.Point(12, 515);
            this.compTitle.Name = "compTitle";
            this.compTitle.Size = new System.Drawing.Size(289, 37);
            this.compTitle.TabIndex = 14;
            this.compTitle.Text = "The chosen parts are:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.compTitle);
            this.Controls.Add(this.mbFactorLabel);
            this.Controls.Add(this.mbChipsetLabel);
            this.Controls.Add(this.mbLinkLabel);
            this.Controls.Add(this.mbPriceLabel);
            this.Controls.Add(this.mbSocketLabel);
            this.Controls.Add(this.cpuLinkLabel);
            this.Controls.Add(this.cpuPriceLabel);
            this.Controls.Add(this.cpuSocketLabel);
            this.Controls.Add(this.scrapeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mbBox);
            this.Controls.Add(this.cpuBox);
            this.Name = "Form1";
            this.Text = "CPU + Motherboard checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cpuBox;
        private ComboBox mbBox;
        private Label label1;
        private Button scrapeButton;
        private Label cpuSocketLabel;
        private Label cpuPriceLabel;
        private LinkLabel cpuLinkLabel;
        private LinkLabel mbLinkLabel;
        private Label mbPriceLabel;
        private Label mbSocketLabel;
        private Label mbChipsetLabel;
        private Label mbFactorLabel;
        private Label compTitle;
    }
}