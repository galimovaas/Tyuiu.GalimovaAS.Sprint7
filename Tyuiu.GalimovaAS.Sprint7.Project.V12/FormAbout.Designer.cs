namespace Tyuiu.GalimovaAS.Sprint7.Project.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxAboutMe_GAS = new TextBox();
            pictureBoxPhoto = new PictureBox();
            buttonClose = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // textBoxAboutMe_GAS
            // 
            textBoxAboutMe_GAS.BackColor = Color.FromArgb(255, 192, 255);
            textBoxAboutMe_GAS.Location = new Point(262, 12);
            textBoxAboutMe_GAS.Multiline = true;
            textBoxAboutMe_GAS.Name = "textBoxAboutMe_GAS";
            textBoxAboutMe_GAS.Size = new Size(340, 275);
            textBoxAboutMe_GAS.TabIndex = 0;
            textBoxAboutMe_GAS.Text = resources.GetString("textBoxAboutMe_GAS.Text");
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.ErrorImage = null;
            pictureBoxPhoto.Image = (Image)resources.GetObject("pictureBoxPhoto.Image");
            pictureBoxPhoto.Location = new Point(12, 12);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(232, 275);
            pictureBoxPhoto.TabIndex = 1;
            pictureBoxPhoto.TabStop = false;
            pictureBoxPhoto.Click += pictureBoxPhoto_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(255, 128, 255);
            buttonClose.ForeColor = Color.Black;
            buttonClose.Location = new Point(539, 293);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(63, 30);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "OK";
            buttonClose.TextAlign = ContentAlignment.TopCenter;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 315);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(610, 326);
            Controls.Add(label1);
            Controls.Add(buttonClose);
            Controls.Add(pictureBoxPhoto);
            Controls.Add(textBoxAboutMe_GAS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAboutMe_GAS;
        private PictureBox pictureBoxPhoto;
        private Button buttonClose;
        private Label label1;
    }
}