namespace hide_image_in_image
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGo = new System.Windows.Forms.Button();
            this.nudHiddenBits = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picVisible = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picHidden = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.picCombined = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.picRecovered = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.rdobtn_save_visible = new System.Windows.Forms.RadioButton();
            this.rdobtn_save_combined = new System.Windows.Forms.RadioButton();
            this.rdobtn_save_hidden = new System.Windows.Forms.RadioButton();
            this.rdobtn_save_recovered = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdobtn_open_hidden = new System.Windows.Forms.RadioButton();
            this.rdobtn_open_visible = new System.Windows.Forms.RadioButton();
            this.btn_open = new System.Windows.Forms.Button();
            this.lbl_ver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHiddenBits)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisible)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHidden)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCombined)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRecovered)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(191, 8);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(81, 28);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "Combine";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // nudHiddenBits
            // 
            this.nudHiddenBits.Location = new System.Drawing.Point(119, 9);
            this.nudHiddenBits.Margin = new System.Windows.Forms.Padding(4);
            this.nudHiddenBits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudHiddenBits.Name = "nudHiddenBits";
            this.nudHiddenBits.Size = new System.Drawing.Size(64, 22);
            this.nudHiddenBits.TabIndex = 9;
            this.nudHiddenBits.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "No Bits to use:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 44);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 449);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.picVisible);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(937, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visible";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // picVisible
            // 
            this.picVisible.Location = new System.Drawing.Point(4, 4);
            this.picVisible.Margin = new System.Windows.Forms.Padding(4);
            this.picVisible.Name = "picVisible";
            this.picVisible.Size = new System.Drawing.Size(600, 632);
            this.picVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picVisible.TabIndex = 0;
            this.picVisible.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.picHidden);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(937, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hidden";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // picHidden
            // 
            this.picHidden.Location = new System.Drawing.Point(4, 4);
            this.picHidden.Margin = new System.Windows.Forms.Padding(4);
            this.picHidden.Name = "picHidden";
            this.picHidden.Size = new System.Drawing.Size(600, 337);
            this.picHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHidden.TabIndex = 1;
            this.picHidden.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.picCombined);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(937, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Combined";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // picCombined
            // 
            this.picCombined.Location = new System.Drawing.Point(4, 4);
            this.picCombined.Margin = new System.Windows.Forms.Padding(4);
            this.picCombined.Name = "picCombined";
            this.picCombined.Size = new System.Drawing.Size(100, 50);
            this.picCombined.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCombined.TabIndex = 2;
            this.picCombined.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.picRecovered);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(937, 420);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Recovered";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // picRecovered
            // 
            this.picRecovered.Location = new System.Drawing.Point(4, 4);
            this.picRecovered.Margin = new System.Windows.Forms.Padding(4);
            this.picRecovered.Name = "picRecovered";
            this.picRecovered.Size = new System.Drawing.Size(100, 50);
            this.picRecovered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRecovered.TabIndex = 3;
            this.picRecovered.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(7, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 37);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // rdobtn_save_visible
            // 
            this.rdobtn_save_visible.AutoSize = true;
            this.rdobtn_save_visible.Checked = true;
            this.rdobtn_save_visible.Location = new System.Drawing.Point(106, 10);
            this.rdobtn_save_visible.Name = "rdobtn_save_visible";
            this.rdobtn_save_visible.Size = new System.Drawing.Size(70, 21);
            this.rdobtn_save_visible.TabIndex = 12;
            this.rdobtn_save_visible.TabStop = true;
            this.rdobtn_save_visible.Text = "Visible";
            this.rdobtn_save_visible.UseVisualStyleBackColor = true;
            // 
            // rdobtn_save_combined
            // 
            this.rdobtn_save_combined.AutoSize = true;
            this.rdobtn_save_combined.Location = new System.Drawing.Point(106, 37);
            this.rdobtn_save_combined.Name = "rdobtn_save_combined";
            this.rdobtn_save_combined.Size = new System.Drawing.Size(92, 21);
            this.rdobtn_save_combined.TabIndex = 13;
            this.rdobtn_save_combined.Text = "Combined";
            this.rdobtn_save_combined.UseVisualStyleBackColor = true;
            // 
            // rdobtn_save_hidden
            // 
            this.rdobtn_save_hidden.AutoSize = true;
            this.rdobtn_save_hidden.Location = new System.Drawing.Point(203, 11);
            this.rdobtn_save_hidden.Name = "rdobtn_save_hidden";
            this.rdobtn_save_hidden.Size = new System.Drawing.Size(74, 21);
            this.rdobtn_save_hidden.TabIndex = 14;
            this.rdobtn_save_hidden.Text = "Hidden";
            this.rdobtn_save_hidden.UseVisualStyleBackColor = true;
            // 
            // rdobtn_save_recovered
            // 
            this.rdobtn_save_recovered.AutoSize = true;
            this.rdobtn_save_recovered.Location = new System.Drawing.Point(203, 37);
            this.rdobtn_save_recovered.Name = "rdobtn_save_recovered";
            this.rdobtn_save_recovered.Size = new System.Drawing.Size(98, 21);
            this.rdobtn_save_recovered.TabIndex = 15;
            this.rdobtn_save_recovered.Text = "Recovered";
            this.rdobtn_save_recovered.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobtn_save_recovered);
            this.groupBox1.Controls.Add(this.rdobtn_save_hidden);
            this.groupBox1.Controls.Add(this.rdobtn_save_combined);
            this.groupBox1.Controls.Add(this.rdobtn_save_visible);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Location = new System.Drawing.Point(490, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 63);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdobtn_open_hidden);
            this.groupBox2.Controls.Add(this.rdobtn_open_visible);
            this.groupBox2.Controls.Add(this.btn_open);
            this.groupBox2.Location = new System.Drawing.Point(293, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 62);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // rdobtn_open_hidden
            // 
            this.rdobtn_open_hidden.AutoSize = true;
            this.rdobtn_open_hidden.Location = new System.Drawing.Point(87, 35);
            this.rdobtn_open_hidden.Name = "rdobtn_open_hidden";
            this.rdobtn_open_hidden.Size = new System.Drawing.Size(74, 21);
            this.rdobtn_open_hidden.TabIndex = 16;
            this.rdobtn_open_hidden.Text = "Hidden";
            this.rdobtn_open_hidden.UseVisualStyleBackColor = true;
            // 
            // rdobtn_open_visible
            // 
            this.rdobtn_open_visible.AutoSize = true;
            this.rdobtn_open_visible.Checked = true;
            this.rdobtn_open_visible.Location = new System.Drawing.Point(87, 14);
            this.rdobtn_open_visible.Name = "rdobtn_open_visible";
            this.rdobtn_open_visible.Size = new System.Drawing.Size(70, 21);
            this.rdobtn_open_visible.TabIndex = 15;
            this.rdobtn_open_visible.TabStop = true;
            this.rdobtn_open_visible.Text = "Visible";
            this.rdobtn_open_visible.UseVisualStyleBackColor = true;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(6, 13);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 40);
            this.btn_open.TabIndex = 12;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Location = new System.Drawing.Point(814, 8);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(24, 17);
            this.lbl_ver.TabIndex = 18;
            this.lbl_ver.Text = "....";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 508);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.nudHiddenBits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Steganography hide image in image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHiddenBits)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisible)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHidden)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCombined)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRecovered)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown nudHiddenBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox picVisible;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox picHidden;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox picCombined;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox picRecovered;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RadioButton rdobtn_save_visible;
        private System.Windows.Forms.RadioButton rdobtn_save_combined;
        private System.Windows.Forms.RadioButton rdobtn_save_hidden;
        private System.Windows.Forms.RadioButton rdobtn_save_recovered;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdobtn_open_hidden;
        private System.Windows.Forms.RadioButton rdobtn_open_visible;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label lbl_ver;
    }
}

