﻿
namespace horserace
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
            this.panelBet = new System.Windows.Forms.Panel();
            this.textBoxPunter3 = new System.Windows.Forms.TextBox();
            this.textBoxPunter2 = new System.Windows.Forms.TextBox();
            this.textBoxPunter1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericCycleNo = new System.Windows.Forms.NumericUpDown();
            this.numericBetAmount = new System.Windows.Forms.NumericUpDown();
            this.labelCycleNo = new System.Windows.Forms.Label();
            this.labelBet = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.punter3Radio = new System.Windows.Forms.RadioButton();
            this.punter2Radio = new System.Windows.Forms.RadioButton();
            this.punter1Radio = new System.Windows.Forms.RadioButton();
            this.btnAction = new System.Windows.Forms.Button();
            this.horse4 = new System.Windows.Forms.PictureBox();
            this.horse3 = new System.Windows.Forms.PictureBox();
            this.horse2 = new System.Windows.Forms.PictureBox();
            this.horse1 = new System.Windows.Forms.PictureBox();
            this.pictureTracks = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelBet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCycleNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBet
            // 
            this.panelBet.BackColor = System.Drawing.Color.Teal;
            this.panelBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBet.Controls.Add(this.textBoxPunter3);
            this.panelBet.Controls.Add(this.textBoxPunter2);
            this.panelBet.Controls.Add(this.textBoxPunter1);
            this.panelBet.Controls.Add(this.groupBox1);
            this.panelBet.Controls.Add(this.punter3Radio);
            this.panelBet.Controls.Add(this.punter2Radio);
            this.panelBet.Controls.Add(this.punter1Radio);
            this.panelBet.Location = new System.Drawing.Point(12, 441);
            this.panelBet.Name = "panelBet";
            this.panelBet.Size = new System.Drawing.Size(1481, 256);
            this.panelBet.TabIndex = 7;
            // 
            // textBoxPunter3
            // 
            this.textBoxPunter3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPunter3.Location = new System.Drawing.Point(189, 185);
            this.textBoxPunter3.Name = "textBoxPunter3";
            this.textBoxPunter3.Size = new System.Drawing.Size(682, 42);
            this.textBoxPunter3.TabIndex = 6;
            // 
            // textBoxPunter2
            // 
            this.textBoxPunter2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPunter2.Location = new System.Drawing.Point(189, 104);
            this.textBoxPunter2.Name = "textBoxPunter2";
            this.textBoxPunter2.Size = new System.Drawing.Size(682, 42);
            this.textBoxPunter2.TabIndex = 5;
            // 
            // textBoxPunter1
            // 
            this.textBoxPunter1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPunter1.Location = new System.Drawing.Point(189, 23);
            this.textBoxPunter1.Name = "textBoxPunter1";
            this.textBoxPunter1.Size = new System.Drawing.Size(682, 42);
            this.textBoxPunter1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.numericCycleNo);
            this.groupBox1.Controls.Add(this.numericBetAmount);
            this.groupBox1.Controls.Add(this.labelCycleNo);
            this.groupBox1.Controls.Add(this.labelBet);
            this.groupBox1.Controls.Add(this.labelMax);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(878, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 248);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls:";
            // 
            // numericCycleNo
            // 
            this.numericCycleNo.Location = new System.Drawing.Point(416, 178);
            this.numericCycleNo.Name = "numericCycleNo";
            this.numericCycleNo.Size = new System.Drawing.Size(120, 45);
            this.numericCycleNo.TabIndex = 4;
            // 
            // numericBetAmount
            // 
            this.numericBetAmount.Location = new System.Drawing.Point(416, 100);
            this.numericBetAmount.Name = "numericBetAmount";
            this.numericBetAmount.Size = new System.Drawing.Size(120, 45);
            this.numericBetAmount.TabIndex = 3;
            // 
            // labelCycleNo
            // 
            this.labelCycleNo.AutoSize = true;
            this.labelCycleNo.Location = new System.Drawing.Point(37, 180);
            this.labelCycleNo.Name = "labelCycleNo";
            this.labelCycleNo.Size = new System.Drawing.Size(257, 37);
            this.labelCycleNo.TabIndex = 2;
            this.labelCycleNo.Text = "Bets on Cycle No";
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Location = new System.Drawing.Point(37, 102);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(276, 37);
            this.labelBet.TabIndex = 1;
            this.labelBet.Text = "Bets Of Amount $ ";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(131, 41);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(346, 37);
            this.labelMax.TabIndex = 0;
            this.labelMax.Text = "Max Bet Amount is $50";
            // 
            // punter3Radio
            // 
            this.punter3Radio.AutoSize = true;
            this.punter3Radio.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punter3Radio.Location = new System.Drawing.Point(10, 183);
            this.punter3Radio.Name = "punter3Radio";
            this.punter3Radio.Size = new System.Drawing.Size(145, 41);
            this.punter3Radio.TabIndex = 2;
            this.punter3Radio.TabStop = true;
            this.punter3Radio.Text = "Gaurav";
            this.punter3Radio.UseVisualStyleBackColor = true;
            this.punter3Radio.CheckedChanged += new System.EventHandler(this.puntersRadio_CheckedChanged);
            // 
            // punter2Radio
            // 
            this.punter2Radio.AutoSize = true;
            this.punter2Radio.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punter2Radio.Location = new System.Drawing.Point(10, 102);
            this.punter2Radio.Name = "punter2Radio";
            this.punter2Radio.Size = new System.Drawing.Size(85, 41);
            this.punter2Radio.TabIndex = 1;
            this.punter2Radio.TabStop = true;
            this.punter2Radio.Text = "Avi";
            this.punter2Radio.UseVisualStyleBackColor = true;
            this.punter2Radio.CheckedChanged += new System.EventHandler(this.puntersRadio_CheckedChanged);
            // 
            // punter1Radio
            // 
            this.punter1Radio.AutoSize = true;
            this.punter1Radio.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punter1Radio.Location = new System.Drawing.Point(10, 21);
            this.punter1Radio.Name = "punter1Radio";
            this.punter1Radio.Size = new System.Drawing.Size(138, 41);
            this.punter1Radio.TabIndex = 0;
            this.punter1Radio.TabStop = true;
            this.punter1Radio.Text = "Yogesh";
            this.punter1Radio.UseVisualStyleBackColor = true;
            this.punter1Radio.CheckedChanged += new System.EventHandler(this.puntersRadio_CheckedChanged);
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.Gray;
            this.btnAction.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(202, 703);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(1080, 66);
            this.btnAction.TabIndex = 13;
            this.btnAction.Text = "Place Bet";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // horse4
            // 
            this.horse4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horse4.Image = global::horserace.Properties.Resources.horse4;
            this.horse4.Location = new System.Drawing.Point(20, 346);
            this.horse4.Name = "horse4";
            this.horse4.Size = new System.Drawing.Size(129, 66);
            this.horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse4.TabIndex = 12;
            this.horse4.TabStop = false;
            // 
            // horse3
            // 
            this.horse3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horse3.Image = global::horserace.Properties.Resources.horse3;
            this.horse3.Location = new System.Drawing.Point(20, 245);
            this.horse3.Name = "horse3";
            this.horse3.Size = new System.Drawing.Size(129, 66);
            this.horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse3.TabIndex = 11;
            this.horse3.TabStop = false;
            // 
            // horse2
            // 
            this.horse2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horse2.Image = global::horserace.Properties.Resources.horse2;
            this.horse2.Location = new System.Drawing.Point(20, 144);
            this.horse2.Name = "horse2";
            this.horse2.Size = new System.Drawing.Size(129, 66);
            this.horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse2.TabIndex = 10;
            this.horse2.TabStop = false;
            // 
            // horse1
            // 
            this.horse1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horse1.Image = global::horserace.Properties.Resources.horse;
            this.horse1.Location = new System.Drawing.Point(20, 43);
            this.horse1.Name = "horse1";
            this.horse1.Size = new System.Drawing.Size(129, 66);
            this.horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse1.TabIndex = 9;
            this.horse1.TabStop = false;
            this.horse1.Click += new System.EventHandler(this.pictureDog1_Click);
            // 
            // pictureTracks
            // 
            this.pictureTracks.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureTracks.Location = new System.Drawing.Point(-130, 29);
            this.pictureTracks.Name = "pictureTracks";
            this.pictureTracks.Size = new System.Drawing.Size(1557, 406);
            this.pictureTracks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTracks.TabIndex = 8;
            this.pictureTracks.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1368, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 406);
            this.button1.TabIndex = 14;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.horse4);
            this.Controls.Add(this.horse3);
            this.Controls.Add(this.horse2);
            this.Controls.Add(this.horse1);
            this.Controls.Add(this.pictureTracks);
            this.Controls.Add(this.panelBet);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelBet.ResumeLayout(false);
            this.panelBet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCycleNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBet;
        private System.Windows.Forms.TextBox textBoxPunter3;
        private System.Windows.Forms.TextBox textBoxPunter2;
        private System.Windows.Forms.TextBox textBoxPunter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericCycleNo;
        private System.Windows.Forms.NumericUpDown numericBetAmount;
        private System.Windows.Forms.Label labelCycleNo;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.RadioButton punter3Radio;
        private System.Windows.Forms.RadioButton punter2Radio;
        private System.Windows.Forms.RadioButton punter1Radio;
        private System.Windows.Forms.PictureBox pictureTracks;
        private System.Windows.Forms.PictureBox horse4;
        private System.Windows.Forms.PictureBox horse3;
        private System.Windows.Forms.PictureBox horse2;
        private System.Windows.Forms.PictureBox horse1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button button1;
    }
}

