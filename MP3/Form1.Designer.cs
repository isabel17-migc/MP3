namespace MP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblarchivo = new Label();
            btnplay = new Button();
            btnstop = new Button();
            panel1 = new Panel();
            lblarchivoselec = new Label();
            openFileDialog1 = new OpenFileDialog();
            picmusic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picmusic).BeginInit();
            SuspendLayout();
            // 
            // lblarchivo
            // 
            lblarchivo.AutoSize = true;
            lblarchivo.BackColor = SystemColors.ButtonHighlight;
            lblarchivo.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblarchivo.Location = new Point(12, 37);
            lblarchivo.Name = "lblarchivo";
            lblarchivo.Size = new Size(180, 21);
            lblarchivo.TabIndex = 0;
            lblarchivo.Text = "Archivo seleccionado:";
            lblarchivo.Click += label1_Click;
            // 
            // btnplay
            // 
            btnplay.BackColor = Color.LightGreen;
            btnplay.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnplay.Location = new Point(34, 281);
            btnplay.Name = "btnplay";
            btnplay.Size = new Size(124, 33);
            btnplay.TabIndex = 2;
            btnplay.Text = "PLAY";
            btnplay.UseVisualStyleBackColor = false;
            btnplay.Click += btnplay_Click;
            // 
            // btnstop
            // 
            btnstop.BackColor = Color.IndianRed;
            btnstop.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnstop.Location = new Point(311, 281);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(124, 33);
            btnstop.TabIndex = 3;
            btnstop.Text = "STOP";
            btnstop.UseVisualStyleBackColor = false;
            btnstop.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblarchivoselec);
            panel1.Location = new Point(12, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 60);
            panel1.TabIndex = 4;
            // 
            // lblarchivoselec
            // 
            lblarchivoselec.AutoSize = true;
            lblarchivoselec.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblarchivoselec.Location = new Point(11, 20);
            lblarchivoselec.Name = "lblarchivoselec";
            lblarchivoselec.Size = new Size(199, 20);
            lblarchivoselec.TabIndex = 0;
            lblarchivoselec.Text = "No hay archivo seleccionado";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // picmusic
            // 
            picmusic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            picmusic.BackColor = Color.Transparent;
            picmusic.BackgroundImage = (Image)resources.GetObject("picmusic.BackgroundImage");
            picmusic.BackgroundImageLayout = ImageLayout.Stretch;
            picmusic.BorderStyle = BorderStyle.Fixed3D;
            picmusic.Enabled = false;
            picmusic.ErrorImage = (Image)resources.GetObject("picmusic.ErrorImage");
            picmusic.Image = (Image)resources.GetObject("picmusic.Image");
            picmusic.InitialImage = (Image)resources.GetObject("picmusic.InitialImage");
            picmusic.Location = new Point(331, 12);
            picmusic.Name = "picmusic";
            picmusic.Size = new Size(151, 66);
            picmusic.SizeMode = PictureBoxSizeMode.StretchImage;
            picmusic.TabIndex = 5;
            picmusic.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(494, 352);
            Controls.Add(panel1);
            Controls.Add(picmusic);
            Controls.Add(btnstop);
            Controls.Add(btnplay);
            Controls.Add(lblarchivo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "REPRODUCTOR DE MUSICA";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picmusic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblarchivo;
        private Button btnplay;
        private Button btnstop;
        private Panel panel1;
        private Label lblarchivoselec;
        private OpenFileDialog openFileDialog1;
        private PictureBox picmusic;
    }
}
