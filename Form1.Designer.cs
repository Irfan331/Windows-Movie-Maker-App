namespace Movie_Maker_App
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
            this.axTimelineControl1 = new AxTimelineAxLib.AxTimelineControl();
            this.btn_addImages = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_paly = new System.Windows.Forms.Button();
            this.btn_addAudio = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axTimelineControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axTimelineControl1
            // 
            this.axTimelineControl1.Enabled = true;
            this.axTimelineControl1.Location = new System.Drawing.Point(5, 163);
            this.axTimelineControl1.Name = "axTimelineControl1";
            this.axTimelineControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTimelineControl1.OcxState")));
            this.axTimelineControl1.Size = new System.Drawing.Size(1043, 415);
            this.axTimelineControl1.TabIndex = 0;
            this.axTimelineControl1.Enter += new System.EventHandler(this.axTimelineControl1_Enter);
            // 
            // btn_addImages
            // 
            this.btn_addImages.Location = new System.Drawing.Point(12, 12);
            this.btn_addImages.Name = "btn_addImages";
            this.btn_addImages.Size = new System.Drawing.Size(92, 52);
            this.btn_addImages.TabIndex = 1;
            this.btn_addImages.Text = "Add Images";
            this.btn_addImages.UseVisualStyleBackColor = true;
            this.btn_addImages.Click += new System.EventHandler(this.btn_addImages_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(715, 96);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 36);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(796, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 145);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_paly
            // 
            this.Btn_paly.Location = new System.Drawing.Point(715, 12);
            this.Btn_paly.Name = "Btn_paly";
            this.Btn_paly.Size = new System.Drawing.Size(75, 36);
            this.Btn_paly.TabIndex = 4;
            this.Btn_paly.Text = "Play";
            this.Btn_paly.UseVisualStyleBackColor = true;
            this.Btn_paly.Click += new System.EventHandler(this.Btn_paly_Click);
            // 
            // btn_addAudio
            // 
            this.btn_addAudio.Location = new System.Drawing.Point(110, 12);
            this.btn_addAudio.Name = "btn_addAudio";
            this.btn_addAudio.Size = new System.Drawing.Size(92, 52);
            this.btn_addAudio.TabIndex = 5;
            this.btn_addAudio.Text = "Add Audio";
            this.btn_addAudio.UseVisualStyleBackColor = true;
            this.btn_addAudio.Click += new System.EventHandler(this.btn_addAudio_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(208, 12);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(92, 52);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.Text = "Remove All";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(715, 54);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 36);
            this.btn_pause.TabIndex = 7;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 590);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_addAudio);
            this.Controls.Add(this.Btn_paly);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_addImages);
            this.Controls.Add(this.axTimelineControl1);
            this.MaximumSize = new System.Drawing.Size(1076, 629);
            this.MinimumSize = new System.Drawing.Size(1076, 629);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axTimelineControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxTimelineAxLib.AxTimelineControl axTimelineControl1;
        private System.Windows.Forms.Button btn_addImages;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_paly;
        private System.Windows.Forms.Button btn_addAudio;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_pause;
    }
}

