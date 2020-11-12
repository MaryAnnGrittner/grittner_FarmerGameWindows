namespace grittner_FarmerGameWindows
{
    partial class FarmerGameUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmerGameUI));
            this.gamePanel = new System.Windows.Forms.Panel();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnFox = new System.Windows.Forms.Button();
            this.btnGrain = new System.Windows.Forms.Button();
            this.btnChicken = new System.Windows.Forms.Button();
            this.labelMoveItem = new System.Windows.Forms.Label();
            this.picFox = new System.Windows.Forms.PictureBox();
            this.picChicken = new System.Windows.Forms.PictureBox();
            this.picGrain = new System.Windows.Forms.PictureBox();
            this.picFarmer = new System.Windows.Forms.PictureBox();
            this.txtPromptBox = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFarmer)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamePanel.BackgroundImage")));
            this.gamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gamePanel.Controls.Add(this.txtQuestion);
            this.gamePanel.Controls.Add(this.btnNone);
            this.gamePanel.Controls.Add(this.btnFox);
            this.gamePanel.Controls.Add(this.btnGrain);
            this.gamePanel.Controls.Add(this.btnChicken);
            this.gamePanel.Controls.Add(this.labelMoveItem);
            this.gamePanel.Controls.Add(this.picFox);
            this.gamePanel.Controls.Add(this.picChicken);
            this.gamePanel.Controls.Add(this.picGrain);
            this.gamePanel.Controls.Add(this.picFarmer);
            this.gamePanel.Location = new System.Drawing.Point(63, 51);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(2030, 1432);
            this.gamePanel.TabIndex = 2;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.Goldenrod;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(269, 174);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(1505, 67);
            this.txtQuestion.TabIndex = 10;
            this.txtQuestion.Text = " Which item you will move? Please click the button below.";
            // 
            // btnNone
            // 
            this.btnNone.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNone.Location = new System.Drawing.Point(1545, 265);
            this.btnNone.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(238, 83);
            this.btnNone.TabIndex = 8;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = false;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnFox
            // 
            this.btnFox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFox.Location = new System.Drawing.Point(1124, 265);
            this.btnFox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnFox.Name = "btnFox";
            this.btnFox.Size = new System.Drawing.Size(241, 83);
            this.btnFox.TabIndex = 7;
            this.btnFox.Text = "Fox";
            this.btnFox.UseVisualStyleBackColor = false;
            this.btnFox.Click += new System.EventHandler(this.btnFox_Click);
            // 
            // btnGrain
            // 
            this.btnGrain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGrain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGrain.Location = new System.Drawing.Point(694, 265);
            this.btnGrain.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGrain.Name = "btnGrain";
            this.btnGrain.Size = new System.Drawing.Size(225, 83);
            this.btnGrain.TabIndex = 6;
            this.btnGrain.Text = "Grain";
            this.btnGrain.UseVisualStyleBackColor = false;
            this.btnGrain.Click += new System.EventHandler(this.btnGrain_Click);
            // 
            // btnChicken
            // 
            this.btnChicken.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChicken.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChicken.Location = new System.Drawing.Point(272, 265);
            this.btnChicken.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnChicken.Name = "btnChicken";
            this.btnChicken.Size = new System.Drawing.Size(215, 83);
            this.btnChicken.TabIndex = 5;
            this.btnChicken.Text = "Chicken";
            this.btnChicken.UseVisualStyleBackColor = false;
            this.btnChicken.Click += new System.EventHandler(this.btnChicken_Click);
            // 
            // labelMoveItem
            // 
            this.labelMoveItem.Location = new System.Drawing.Point(0, 0);
            this.labelMoveItem.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelMoveItem.Name = "labelMoveItem";
            this.labelMoveItem.Size = new System.Drawing.Size(317, 65);
            this.labelMoveItem.TabIndex = 9;
            // 
            // picFox
            // 
            this.picFox.BackColor = System.Drawing.Color.Transparent;
            this.picFox.Image = ((System.Drawing.Image)(resources.GetObject("picFox.Image")));
            this.picFox.Location = new System.Drawing.Point(396, 689);
            this.picFox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.picFox.Name = "picFox";
            this.picFox.Size = new System.Drawing.Size(146, 319);
            this.picFox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFox.TabIndex = 3;
            this.picFox.TabStop = false;
            // 
            // picChicken
            // 
            this.picChicken.BackColor = System.Drawing.Color.Transparent;
            this.picChicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picChicken.Image = ((System.Drawing.Image)(resources.GetObject("picChicken.Image")));
            this.picChicken.Location = new System.Drawing.Point(41, 689);
            this.picChicken.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.picChicken.Name = "picChicken";
            this.picChicken.Size = new System.Drawing.Size(212, 333);
            this.picChicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChicken.TabIndex = 0;
            this.picChicken.TabStop = false;
            // 
            // picGrain
            // 
            this.picGrain.BackColor = System.Drawing.Color.Transparent;
            this.picGrain.Image = ((System.Drawing.Image)(resources.GetObject("picGrain.Image")));
            this.picGrain.Location = new System.Drawing.Point(222, 783);
            this.picGrain.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.picGrain.Name = "picGrain";
            this.picGrain.Size = new System.Drawing.Size(190, 194);
            this.picGrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGrain.TabIndex = 2;
            this.picGrain.TabStop = false;
            // 
            // picFarmer
            // 
            this.picFarmer.BackColor = System.Drawing.Color.Transparent;
            this.picFarmer.Image = ((System.Drawing.Image)(resources.GetObject("picFarmer.Image")));
            this.picFarmer.Location = new System.Drawing.Point(272, 749);
            this.picFarmer.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.picFarmer.Name = "picFarmer";
            this.picFarmer.Size = new System.Drawing.Size(874, 470);
            this.picFarmer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFarmer.TabIndex = 1;
            this.picFarmer.TabStop = false;
            // 
            // txtPromptBox
            // 
            this.txtPromptBox.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtPromptBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtPromptBox.Location = new System.Drawing.Point(2112, 985);
            this.txtPromptBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtPromptBox.Multiline = true;
            this.txtPromptBox.Name = "txtPromptBox";
            this.txtPromptBox.ReadOnly = true;
            this.txtPromptBox.Size = new System.Drawing.Size(546, 257);
            this.txtPromptBox.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPlay.Location = new System.Drawing.Point(2429, 1267);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(238, 80);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "RESET";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnStop.Location = new System.Drawing.Point(2112, 1267);
            this.btnStop.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(238, 80);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "EXIT";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInstructions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtInstructions.Location = new System.Drawing.Point(2112, 176);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(546, 784);
            this.txtInstructions.TabIndex = 6;
            // 
            // FarmerGameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2742, 1543);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtPromptBox);
            this.Controls.Add(this.gamePanel);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "FarmerGameUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FarmerGameUI_Load);
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChicken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFarmer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox picChicken;
        private System.Windows.Forms.PictureBox picFarmer;
        private System.Windows.Forms.PictureBox picFox;
        private System.Windows.Forms.PictureBox picGrain;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnFox;
        private System.Windows.Forms.Button btnGrain;
        private System.Windows.Forms.Button btnChicken;
        private System.Windows.Forms.Label labelMoveItem;
        private System.Windows.Forms.TextBox txtPromptBox;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.TextBox txtQuestion;
    }
}

