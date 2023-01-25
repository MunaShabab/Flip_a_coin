namespace FlipACoin_MunaShabab
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
            this.flipButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.headPic = new System.Windows.Forms.PictureBox();
            this.tailPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailPic)).BeginInit();
            this.SuspendLayout();
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(27, 192);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(67, 32);
            this.flipButton.TabIndex = 0;
            this.flipButton.Text = "Flip a Coin";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(121, 192);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(67, 32);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(213, 192);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(67, 32);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // headPic
            // 
            this.headPic.Image = ((System.Drawing.Image)(resources.GetObject("headPic.Image")));
            this.headPic.Location = new System.Drawing.Point(97, 37);
            this.headPic.Name = "headPic";
            this.headPic.Size = new System.Drawing.Size(114, 110);
            this.headPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headPic.TabIndex = 3;
            this.headPic.TabStop = false;
            this.headPic.Visible = false;
            // 
            // tailPic
            // 
            this.tailPic.Image = ((System.Drawing.Image)(resources.GetObject("tailPic.Image")));
            this.tailPic.Location = new System.Drawing.Point(97, 37);
            this.tailPic.Name = "tailPic";
            this.tailPic.Size = new System.Drawing.Size(114, 110);
            this.tailPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailPic.TabIndex = 4;
            this.tailPic.TabStop = false;
            this.tailPic.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 248);
            this.Controls.Add(this.tailPic);
            this.Controls.Add(this.headPic);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.flipButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.headPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox headPic;
        private System.Windows.Forms.PictureBox tailPic;
    }
}

