namespace Tyuiu.MakarovAY.Sprint7.V14
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
            buttonOK_MAY = new Button();
            labelAbout_MAY = new Label();
            pictureBox_MAY = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_MAY).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_MAY
            // 
            buttonOK_MAY.Cursor = Cursors.Hand;
            buttonOK_MAY.Location = new Point(447, 226);
            buttonOK_MAY.Name = "buttonOK_MAY";
            buttonOK_MAY.Size = new Size(75, 23);
            buttonOK_MAY.TabIndex = 6;
            buttonOK_MAY.Text = "Ok";
            buttonOK_MAY.UseVisualStyleBackColor = true;
            buttonOK_MAY.Click += buttonOK_MAY_Click;
            // 
            // labelAbout_MAY
            // 
            labelAbout_MAY.AutoSize = true;
            labelAbout_MAY.Location = new Point(219, 12);
            labelAbout_MAY.Name = "labelAbout_MAY";
            labelAbout_MAY.Size = new Size(303, 165);
            labelAbout_MAY.TabIndex = 5;
            labelAbout_MAY.Text = resources.GetString("labelAbout_MAY.Text");
            labelAbout_MAY.Click += labelAbout_MAY_Click;
            // 
            // pictureBox_MAY
            // 
            pictureBox_MAY.Image = (Image)resources.GetObject("pictureBox_MAY.Image");
            pictureBox_MAY.Location = new Point(12, 12);
            pictureBox_MAY.Name = "pictureBox_MAY";
            pictureBox_MAY.Size = new Size(187, 189);
            pictureBox_MAY.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_MAY.TabIndex = 4;
            pictureBox_MAY.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 261);
            Controls.Add(buttonOK_MAY);
            Controls.Add(labelAbout_MAY);
            Controls.Add(pictureBox_MAY);
            MaximumSize = new Size(550, 300);
            MinimumSize = new Size(550, 300);
            Name = "FormAbout";
            Text = "FormAbout";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_MAY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_MAY;
        private Label labelAbout_MAY;
        private PictureBox pictureBox_MAY;
    }
}