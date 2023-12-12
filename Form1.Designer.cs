namespace GameCaro
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
            this.panelBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLan = new System.Windows.Forms.Button();
            this.textBoxIp = new System.Windows.Forms.TextBox();
            this.progressBarCoolDown = new System.Windows.Forms.ProgressBar();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMark = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMark)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.BackColor = System.Drawing.SystemColors.Control;
            this.panelBoard.Location = new System.Drawing.Point(16, 18);
            this.panelBoard.Margin = new System.Windows.Forms.Padding(4);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(825, 699);
            this.panelBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.buttonLan);
            this.panel2.Controls.Add(this.textBoxIp);
            this.panel2.Controls.Add(this.pictureBoxMark);
            this.panel2.Controls.Add(this.progressBarCoolDown);
            this.panel2.Controls.Add(this.textBoxPlayerName);
            this.panel2.Location = new System.Drawing.Point(849, 351);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 367);
            this.panel2.TabIndex = 1;
            // 
            // buttonLan
            // 
            this.buttonLan.Location = new System.Drawing.Point(4, 148);
            this.buttonLan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLan.Name = "buttonLan";
            this.buttonLan.Size = new System.Drawing.Size(171, 28);
            this.buttonLan.TabIndex = 3;
            this.buttonLan.Text = "LAN";
            this.buttonLan.UseVisualStyleBackColor = true;
            // 
            // textBoxIp
            // 
            this.textBoxIp.Location = new System.Drawing.Point(4, 101);
            this.textBoxIp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIp.Name = "textBoxIp";
            this.textBoxIp.Size = new System.Drawing.Size(169, 22);
            this.textBoxIp.TabIndex = 2;
            this.textBoxIp.Text = "192.168.1.64";
            // 
            // progressBarCoolDown
            // 
            this.progressBarCoolDown.Location = new System.Drawing.Point(4, 50);
            this.progressBarCoolDown.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarCoolDown.Name = "progressBarCoolDown";
            this.progressBarCoolDown.Size = new System.Drawing.Size(171, 28);
            this.progressBarCoolDown.TabIndex = 1;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(4, 4);
            this.textBoxPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.ReadOnly = true;
            this.textBoxPlayerName.Size = new System.Drawing.Size(169, 22);
            this.textBoxPlayerName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.pictureBoxAvatar);
            this.panel3.Location = new System.Drawing.Point(849, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 325);
            this.panel3.TabIndex = 0;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxAvatar.Image = global::GameCaro.Properties.Resources.ava_caro;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(343, 321);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // pictureBoxMark
            // 
            this.pictureBoxMark.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxMark.Location = new System.Drawing.Point(197, 30);
            this.pictureBoxMark.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMark.Name = "pictureBoxMark";
            this.pictureBoxMark.Size = new System.Drawing.Size(145, 122);
            this.pictureBoxMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMark.TabIndex = 1;
            this.pictureBoxMark.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 732);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBoard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Cờ Caro";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Button buttonLan;
        private System.Windows.Forms.TextBox textBoxIp;
        private System.Windows.Forms.PictureBox pictureBoxMark;
        private System.Windows.Forms.ProgressBar progressBarCoolDown;
        private System.Windows.Forms.TextBox textBoxPlayerName;
    }
}

