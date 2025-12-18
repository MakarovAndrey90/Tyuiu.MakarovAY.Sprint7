namespace Tyuiu.MakarovAY.Sprint7.V14
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelShowInformation_MAY = new Panel();
            label2 = new Label();
            label1 = new Label();
            textBoxStop_MAY = new TextBox();
            textBoxStart_MAY = new TextBox();
            textBoxRoutesNumber_MAY = new TextBox();
            pictureBoxTTC_MAY = new PictureBox();
            panelShowTools_MAY = new Panel();
            buttonDone_MAY = new Button();
            buttonOpenFile = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label3 = new Label();
            comboBoxShowNum_MAY = new ComboBox();
            panelShowInformationAboutBus_MAY = new Panel();
            textBoxPaymentForSBPSystem_MAY = new TextBox();
            textBoxWheelchairRamp_MAY = new TextBox();
            textBoxCharger_MAY = new TextBox();
            textBoxWorksOnWeekends_MAY = new TextBox();
            textBoxLargeClassBus_MAY = new TextBox();
            textBoxModeOfTheTransport_MAY = new TextBox();
            labelPaymentForSBPSystem_MAY = new Label();
            labelWheelchairRamp_MAY = new Label();
            labelCharger_MAY = new Label();
            labelWorksOnWeekends_MAY = new Label();
            label5LargeClassBus_MAY = new Label();
            labelModeOfTheTransport_MAY = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            toolTip5 = new ToolTip(components);
            openFileDialog_MAY = new OpenFileDialog();
            panelShowInformation_MAY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTTC_MAY).BeginInit();
            panelShowTools_MAY.SuspendLayout();
            panelShowInformationAboutBus_MAY.SuspendLayout();
            SuspendLayout();
            // 
            // panelShowInformation_MAY
            // 
            panelShowInformation_MAY.BackColor = Color.ForestGreen;
            panelShowInformation_MAY.Controls.Add(label2);
            panelShowInformation_MAY.Controls.Add(label1);
            panelShowInformation_MAY.Controls.Add(textBoxStop_MAY);
            panelShowInformation_MAY.Controls.Add(textBoxStart_MAY);
            panelShowInformation_MAY.Controls.Add(textBoxRoutesNumber_MAY);
            panelShowInformation_MAY.Controls.Add(pictureBoxTTC_MAY);
            panelShowInformation_MAY.Dock = DockStyle.Top;
            panelShowInformation_MAY.Location = new Point(0, 0);
            panelShowInformation_MAY.Name = "panelShowInformation_MAY";
            panelShowInformation_MAY.Size = new Size(984, 112);
            panelShowInformation_MAY.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(506, 63);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 4;
            label2.Text = "конец пути:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(506, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 3;
            label1.Text = "начало пути:";
            // 
            // textBoxStop_MAY
            // 
            textBoxStop_MAY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxStop_MAY.BackColor = Color.ForestGreen;
            textBoxStop_MAY.BorderStyle = BorderStyle.None;
            textBoxStop_MAY.Font = new Font("Segoe UI", 15F);
            textBoxStop_MAY.Location = new Point(627, 63);
            textBoxStop_MAY.Multiline = true;
            textBoxStop_MAY.Name = "textBoxStop_MAY";
            textBoxStop_MAY.Size = new Size(319, 33);
            textBoxStop_MAY.TabIndex = 2;
            textBoxStop_MAY.TextChanged += textBoxStop_MAY_TextChanged;
            // 
            // textBoxStart_MAY
            // 
            textBoxStart_MAY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxStart_MAY.BackColor = Color.ForestGreen;
            textBoxStart_MAY.BorderStyle = BorderStyle.None;
            textBoxStart_MAY.Font = new Font("Segoe UI", 15F);
            textBoxStart_MAY.Location = new Point(637, 12);
            textBoxStart_MAY.Multiline = true;
            textBoxStart_MAY.Name = "textBoxStart_MAY";
            textBoxStart_MAY.Size = new Size(319, 33);
            textBoxStart_MAY.TabIndex = 2;
            // 
            // textBoxRoutesNumber_MAY
            // 
            textBoxRoutesNumber_MAY.BorderStyle = BorderStyle.FixedSingle;
            textBoxRoutesNumber_MAY.Font = new Font("Segoe UI", 20F);
            textBoxRoutesNumber_MAY.Location = new Point(328, 50);
            textBoxRoutesNumber_MAY.Multiline = true;
            textBoxRoutesNumber_MAY.Name = "textBoxRoutesNumber_MAY";
            textBoxRoutesNumber_MAY.ReadOnly = true;
            textBoxRoutesNumber_MAY.Size = new Size(91, 46);
            textBoxRoutesNumber_MAY.TabIndex = 1;
            textBoxRoutesNumber_MAY.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBoxTTC_MAY
            // 
            pictureBoxTTC_MAY.BackColor = Color.Transparent;
            pictureBoxTTC_MAY.BackgroundImage = (Image)resources.GetObject("pictureBoxTTC_MAY.BackgroundImage");
            pictureBoxTTC_MAY.BackgroundImageLayout = ImageLayout.None;
            pictureBoxTTC_MAY.Location = new Point(0, 0);
            pictureBoxTTC_MAY.Name = "pictureBoxTTC_MAY";
            pictureBoxTTC_MAY.Size = new Size(203, 112);
            pictureBoxTTC_MAY.TabIndex = 0;
            pictureBoxTTC_MAY.TabStop = false;
            // 
            // panelShowTools_MAY
            // 
            panelShowTools_MAY.BackColor = SystemColors.AppWorkspace;
            panelShowTools_MAY.Controls.Add(buttonDone_MAY);
            panelShowTools_MAY.Controls.Add(buttonOpenFile);
            panelShowTools_MAY.Controls.Add(button4);
            panelShowTools_MAY.Controls.Add(button3);
            panelShowTools_MAY.Controls.Add(button1);
            panelShowTools_MAY.Controls.Add(label3);
            panelShowTools_MAY.Controls.Add(comboBoxShowNum_MAY);
            panelShowTools_MAY.Dock = DockStyle.Left;
            panelShowTools_MAY.Location = new Point(0, 112);
            panelShowTools_MAY.Name = "panelShowTools_MAY";
            panelShowTools_MAY.Size = new Size(328, 449);
            panelShowTools_MAY.TabIndex = 1;
            // 
            // buttonDone_MAY
            // 
            buttonDone_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDone_MAY.Cursor = Cursors.Hand;
            buttonDone_MAY.Enabled = false;
            buttonDone_MAY.Image = (Image)resources.GetObject("buttonDone_MAY.Image");
            buttonDone_MAY.Location = new Point(222, 394);
            buttonDone_MAY.Name = "buttonDone_MAY";
            buttonDone_MAY.Size = new Size(75, 52);
            buttonDone_MAY.TabIndex = 2;
            toolTip1.SetToolTip(buttonDone_MAY, "произвести вычисление");
            buttonDone_MAY.UseVisualStyleBackColor = true;
            buttonDone_MAY.Click += buttonDone_MAY_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOpenFile.Cursor = Cursors.Hand;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 336);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 52);
            buttonOpenFile.TabIndex = 2;
            toolTip4.SetToolTip(buttonOpenFile, "загрузить файл в формате csv");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Cursor = Cursors.Hand;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(106, 336);
            button4.Name = "button4";
            button4.Size = new Size(75, 52);
            button4.TabIndex = 2;
            toolTip3.SetToolTip(button4, "построить график по данным из файла");
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Cursor = Cursors.Hand;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(12, 394);
            button3.Name = "button3";
            button3.Size = new Size(75, 52);
            button3.TabIndex = 2;
            toolTip5.SetToolTip(button3, "информация о разработчике");
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Cursor = Cursors.Hand;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(106, 394);
            button1.Name = "button1";
            button1.Size = new Size(75, 52);
            button1.TabIndex = 2;
            toolTip2.SetToolTip(button1, "добавить или удалить информацию из файла, сохранить");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(3, 33);
            label3.Name = "label3";
            label3.Size = new Size(202, 20);
            label3.TabIndex = 1;
            label3.Text = "Выберите номер маршрута";
            // 
            // comboBoxShowNum_MAY
            // 
            comboBoxShowNum_MAY.Font = new Font("Segoe UI", 12F);
            comboBoxShowNum_MAY.FormattingEnabled = true;
            comboBoxShowNum_MAY.Location = new Point(211, 34);
            comboBoxShowNum_MAY.Name = "comboBoxShowNum_MAY";
            comboBoxShowNum_MAY.Size = new Size(86, 29);
            comboBoxShowNum_MAY.TabIndex = 0;
            comboBoxShowNum_MAY.SelectedIndexChanged += comboBoxShowNum_MAY_SelectedIndexChanged;
            // 
            // panelShowInformationAboutBus_MAY
            // 
            panelShowInformationAboutBus_MAY.BackColor = Color.DarkSeaGreen;
            panelShowInformationAboutBus_MAY.Controls.Add(textBoxPaymentForSBPSystem_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(textBoxWheelchairRamp_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(textBoxCharger_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(textBoxWorksOnWeekends_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(textBoxLargeClassBus_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(textBoxModeOfTheTransport_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(labelPaymentForSBPSystem_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(labelWheelchairRamp_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(labelCharger_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(labelWorksOnWeekends_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(label5LargeClassBus_MAY);
            panelShowInformationAboutBus_MAY.Controls.Add(labelModeOfTheTransport_MAY);
            panelShowInformationAboutBus_MAY.Dock = DockStyle.Fill;
            panelShowInformationAboutBus_MAY.Location = new Point(328, 112);
            panelShowInformationAboutBus_MAY.Name = "panelShowInformationAboutBus_MAY";
            panelShowInformationAboutBus_MAY.Size = new Size(656, 449);
            panelShowInformationAboutBus_MAY.TabIndex = 2;
            // 
            // textBoxPaymentForSBPSystem_MAY
            // 
            textBoxPaymentForSBPSystem_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxPaymentForSBPSystem_MAY.BackColor = Color.DarkSeaGreen;
            textBoxPaymentForSBPSystem_MAY.BorderStyle = BorderStyle.None;
            textBoxPaymentForSBPSystem_MAY.Font = new Font("Segoe UI", 15F);
            textBoxPaymentForSBPSystem_MAY.Location = new Point(295, 360);
            textBoxPaymentForSBPSystem_MAY.Name = "textBoxPaymentForSBPSystem_MAY";
            textBoxPaymentForSBPSystem_MAY.ReadOnly = true;
            textBoxPaymentForSBPSystem_MAY.Size = new Size(155, 27);
            textBoxPaymentForSBPSystem_MAY.TabIndex = 1;
            textBoxPaymentForSBPSystem_MAY.TextChanged += textBoxPaymentForSBPSystem_MAY_TextChanged;
            // 
            // textBoxWheelchairRamp_MAY
            // 
            textBoxWheelchairRamp_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxWheelchairRamp_MAY.BackColor = Color.DarkSeaGreen;
            textBoxWheelchairRamp_MAY.BorderStyle = BorderStyle.None;
            textBoxWheelchairRamp_MAY.Font = new Font("Segoe UI", 15F);
            textBoxWheelchairRamp_MAY.Location = new Point(231, 299);
            textBoxWheelchairRamp_MAY.Name = "textBoxWheelchairRamp_MAY";
            textBoxWheelchairRamp_MAY.ReadOnly = true;
            textBoxWheelchairRamp_MAY.Size = new Size(164, 27);
            textBoxWheelchairRamp_MAY.TabIndex = 1;
            // 
            // textBoxCharger_MAY
            // 
            textBoxCharger_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxCharger_MAY.BackColor = Color.DarkSeaGreen;
            textBoxCharger_MAY.BorderStyle = BorderStyle.None;
            textBoxCharger_MAY.Font = new Font("Segoe UI", 15F);
            textBoxCharger_MAY.Location = new Point(365, 234);
            textBoxCharger_MAY.Name = "textBoxCharger_MAY";
            textBoxCharger_MAY.ReadOnly = true;
            textBoxCharger_MAY.Size = new Size(135, 27);
            textBoxCharger_MAY.TabIndex = 1;
            // 
            // textBoxWorksOnWeekends_MAY
            // 
            textBoxWorksOnWeekends_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxWorksOnWeekends_MAY.BackColor = Color.DarkSeaGreen;
            textBoxWorksOnWeekends_MAY.BorderStyle = BorderStyle.None;
            textBoxWorksOnWeekends_MAY.Font = new Font("Segoe UI", 15F);
            textBoxWorksOnWeekends_MAY.Location = new Point(267, 170);
            textBoxWorksOnWeekends_MAY.Name = "textBoxWorksOnWeekends_MAY";
            textBoxWorksOnWeekends_MAY.ReadOnly = true;
            textBoxWorksOnWeekends_MAY.Size = new Size(147, 27);
            textBoxWorksOnWeekends_MAY.TabIndex = 1;
            // 
            // textBoxLargeClassBus_MAY
            // 
            textBoxLargeClassBus_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxLargeClassBus_MAY.BackColor = Color.DarkSeaGreen;
            textBoxLargeClassBus_MAY.BorderStyle = BorderStyle.None;
            textBoxLargeClassBus_MAY.Font = new Font("Segoe UI", 15F);
            textBoxLargeClassBus_MAY.Location = new Point(420, 110);
            textBoxLargeClassBus_MAY.Name = "textBoxLargeClassBus_MAY";
            textBoxLargeClassBus_MAY.ReadOnly = true;
            textBoxLargeClassBus_MAY.Size = new Size(124, 27);
            textBoxLargeClassBus_MAY.TabIndex = 1;
            textBoxLargeClassBus_MAY.TextChanged += textBoxLargeClassBus_MAY_TextChanged;
            // 
            // textBoxModeOfTheTransport_MAY
            // 
            textBoxModeOfTheTransport_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxModeOfTheTransport_MAY.BackColor = Color.DarkSeaGreen;
            textBoxModeOfTheTransport_MAY.BorderStyle = BorderStyle.None;
            textBoxModeOfTheTransport_MAY.Font = new Font("Segoe UI", 15F);
            textBoxModeOfTheTransport_MAY.Location = new Point(216, 46);
            textBoxModeOfTheTransport_MAY.Name = "textBoxModeOfTheTransport_MAY";
            textBoxModeOfTheTransport_MAY.ReadOnly = true;
            textBoxModeOfTheTransport_MAY.Size = new Size(151, 27);
            textBoxModeOfTheTransport_MAY.TabIndex = 1;
            textBoxModeOfTheTransport_MAY.TextChanged += textBoxModeOfTheTransport_MAY_TextChanged;
            // 
            // labelPaymentForSBPSystem_MAY
            // 
            labelPaymentForSBPSystem_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelPaymentForSBPSystem_MAY.AutoSize = true;
            labelPaymentForSBPSystem_MAY.Font = new Font("Segoe UI", 15F);
            labelPaymentForSBPSystem_MAY.Location = new Point(50, 360);
            labelPaymentForSBPSystem_MAY.Name = "labelPaymentForSBPSystem_MAY";
            labelPaymentForSBPSystem_MAY.Size = new Size(239, 28);
            labelPaymentForSBPSystem_MAY.TabIndex = 0;
            labelPaymentForSBPSystem_MAY.Text = "Наличие оплаты по СБП:";
            // 
            // labelWheelchairRamp_MAY
            // 
            labelWheelchairRamp_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelWheelchairRamp_MAY.AutoSize = true;
            labelWheelchairRamp_MAY.Font = new Font("Segoe UI", 15F);
            labelWheelchairRamp_MAY.Location = new Point(50, 299);
            labelWheelchairRamp_MAY.Name = "labelWheelchairRamp_MAY";
            labelWheelchairRamp_MAY.Size = new Size(175, 28);
            labelWheelchairRamp_MAY.TabIndex = 0;
            labelWheelchairRamp_MAY.Text = "Наличие пандуса:";
            // 
            // labelCharger_MAY
            // 
            labelCharger_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelCharger_MAY.AutoSize = true;
            labelCharger_MAY.Font = new Font("Segoe UI", 15F);
            labelCharger_MAY.Location = new Point(50, 234);
            labelCharger_MAY.Name = "labelCharger_MAY";
            labelCharger_MAY.Size = new Size(309, 28);
            labelCharger_MAY.TabIndex = 0;
            labelCharger_MAY.Text = "Возможность зарядить телефон:";
            // 
            // labelWorksOnWeekends_MAY
            // 
            labelWorksOnWeekends_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelWorksOnWeekends_MAY.AutoSize = true;
            labelWorksOnWeekends_MAY.Font = new Font("Segoe UI", 15F);
            labelWorksOnWeekends_MAY.Location = new Point(50, 170);
            labelWorksOnWeekends_MAY.Name = "labelWorksOnWeekends_MAY";
            labelWorksOnWeekends_MAY.Size = new Size(211, 28);
            labelWorksOnWeekends_MAY.TabIndex = 0;
            labelWorksOnWeekends_MAY.Text = "Работает в выходные:";
            // 
            // label5LargeClassBus_MAY
            // 
            label5LargeClassBus_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5LargeClassBus_MAY.AutoSize = true;
            label5LargeClassBus_MAY.Font = new Font("Segoe UI", 15F);
            label5LargeClassBus_MAY.Location = new Point(50, 110);
            label5LargeClassBus_MAY.Name = "label5LargeClassBus_MAY";
            label5LargeClassBus_MAY.Size = new Size(364, 28);
            label5LargeClassBus_MAY.TabIndex = 0;
            label5LargeClassBus_MAY.Text = "Транспорт большой вместительности:";
            // 
            // labelModeOfTheTransport_MAY
            // 
            labelModeOfTheTransport_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelModeOfTheTransport_MAY.AutoSize = true;
            labelModeOfTheTransport_MAY.Font = new Font("Segoe UI", 15F);
            labelModeOfTheTransport_MAY.Location = new Point(50, 46);
            labelModeOfTheTransport_MAY.Name = "labelModeOfTheTransport_MAY";
            labelModeOfTheTransport_MAY.Size = new Size(160, 28);
            labelModeOfTheTransport_MAY.TabIndex = 0;
            labelModeOfTheTransport_MAY.Text = "Вид транспорта:";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Вывести информацию";
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Изменить таблицу";
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            toolTip3.ToolTipTitle = "Вывести график";
            // 
            // toolTip4
            // 
            toolTip4.ToolTipIcon = ToolTipIcon.Info;
            toolTip4.ToolTipTitle = "Загрузить файл";
            // 
            // toolTip5
            // 
            toolTip5.ToolTipIcon = ToolTipIcon.Info;
            toolTip5.ToolTipTitle = "Справка";
            // 
            // openFileDialog_MAY
            // 
            openFileDialog_MAY.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panelShowInformationAboutBus_MAY);
            Controls.Add(panelShowTools_MAY);
            Controls.Add(panelShowInformation_MAY);
            MinimumSize = new Size(1000, 600);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            panelShowInformation_MAY.ResumeLayout(false);
            panelShowInformation_MAY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTTC_MAY).EndInit();
            panelShowTools_MAY.ResumeLayout(false);
            panelShowTools_MAY.PerformLayout();
            panelShowInformationAboutBus_MAY.ResumeLayout(false);
            panelShowInformationAboutBus_MAY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelShowInformation_MAY;
        private Panel panelShowTools_MAY;
        private Panel panelShowInformationAboutBus_MAY;
        private PictureBox pictureBoxTTC_MAY;
        private TextBox textBoxRoutesNumber_MAY;
        private Label label2;
        private Label label1;
        private TextBox textBoxStop_MAY;
        private TextBox textBoxStart_MAY;
        private ComboBox comboBoxShowNum_MAY;
        private Button buttonDone_MAY;
        private Button buttonOpenFile;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label label3;
        private Label labelWheelchairRamp_MAY;
        private Label labelCharger_MAY;
        private Label labelWorksOnWeekends_MAY;
        private Label label5LargeClassBus_MAY;
        private Label labelModeOfTheTransport_MAY;
        private Label labelPaymentForSBPSystem_MAY;
        private TextBox textBoxPaymentForSBPSystem_MAY;
        private TextBox textBoxWheelchairRamp_MAY;
        private TextBox textBoxCharger_MAY;
        private TextBox textBoxWorksOnWeekends_MAY;
        private TextBox textBoxLargeClassBus_MAY;
        private TextBox textBoxModeOfTheTransport_MAY;
        private Panel panel4;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip4;
        private ToolTip toolTip3;
        private ToolTip toolTip5;
        private OpenFileDialog openFileDialog_MAY;
    }
}
