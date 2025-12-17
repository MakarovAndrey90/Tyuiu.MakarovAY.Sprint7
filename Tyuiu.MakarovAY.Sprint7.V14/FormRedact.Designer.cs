namespace Tyuiu.MakarovAY.Sprint7.V14
{
    partial class FormRedact
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRedact));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            labelValue_MAY = new Label();
            labelSort_MAY = new Label();
            comboBoxSortValue_MAY = new ComboBox();
            comboBoxSortСriterion_MAY = new ComboBox();
            buttonDeleteValue_MAY = new Button();
            buttonAddFile_MAY = new Button();
            buttonDoneSaveToFile_MAY = new Button();
            buttonAddValue_MAY = new Button();
            panel2 = new Panel();
            dataGridViewTransport_MAY = new DataGridView();
            splitter1 = new Splitter();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            toolTip4 = new ToolTip(components);
            openFileDialog_MAY = new OpenFileDialog();
            saveFileDialog_MAY = new SaveFileDialog();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransport_MAY).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 561);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(labelValue_MAY);
            groupBox1.Controls.Add(labelSort_MAY);
            groupBox1.Controls.Add(comboBoxSortValue_MAY);
            groupBox1.Controls.Add(comboBoxSortСriterion_MAY);
            groupBox1.Controls.Add(buttonDeleteValue_MAY);
            groupBox1.Controls.Add(buttonAddFile_MAY);
            groupBox1.Controls.Add(buttonDoneSaveToFile_MAY);
            groupBox1.Controls.Add(buttonAddValue_MAY);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 561);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "сортировать, добавить, удалить";
            // 
            // labelValue_MAY
            // 
            labelValue_MAY.AutoSize = true;
            labelValue_MAY.Font = new Font("Segoe UI", 12F);
            labelValue_MAY.Location = new Point(25, 259);
            labelValue_MAY.Name = "labelValue_MAY";
            labelValue_MAY.Size = new Size(79, 21);
            labelValue_MAY.TabIndex = 3;
            labelValue_MAY.Text = "Значение";
            // 
            // labelSort_MAY
            // 
            labelSort_MAY.AutoSize = true;
            labelSort_MAY.Font = new Font("Segoe UI", 12F);
            labelSort_MAY.Location = new Point(25, 194);
            labelSort_MAY.Name = "labelSort_MAY";
            labelSort_MAY.Size = new Size(125, 21);
            labelSort_MAY.TabIndex = 2;
            labelSort_MAY.Text = "Сортировать по";
            // 
            // comboBoxSortValue_MAY
            // 
            comboBoxSortValue_MAY.FormattingEnabled = true;
            comboBoxSortValue_MAY.Location = new Point(25, 297);
            comboBoxSortValue_MAY.Name = "comboBoxSortValue_MAY";
            comboBoxSortValue_MAY.Size = new Size(151, 23);
            comboBoxSortValue_MAY.TabIndex = 1;
            comboBoxSortValue_MAY.SelectedIndexChanged += comboBoxSortValue_MAY_SelectedIndexChanged;
            // 
            // comboBoxSortСriterion_MAY
            // 
            comboBoxSortСriterion_MAY.FormattingEnabled = true;
            comboBoxSortСriterion_MAY.Location = new Point(25, 218);
            comboBoxSortСriterion_MAY.Name = "comboBoxSortСriterion_MAY";
            comboBoxSortСriterion_MAY.Size = new Size(151, 23);
            comboBoxSortСriterion_MAY.TabIndex = 1;
            comboBoxSortСriterion_MAY.SelectedIndexChanged += comboBoxSortСriterion_MAY_SelectedIndexChanged;
            // 
            // buttonDeleteValue_MAY
            // 
            buttonDeleteValue_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDeleteValue_MAY.Cursor = Cursors.Hand;
            buttonDeleteValue_MAY.Image = (Image)resources.GetObject("buttonDeleteValue_MAY.Image");
            buttonDeleteValue_MAY.Location = new Point(110, 427);
            buttonDeleteValue_MAY.Name = "buttonDeleteValue_MAY";
            buttonDeleteValue_MAY.Size = new Size(75, 51);
            buttonDeleteValue_MAY.TabIndex = 0;
            toolTip3.SetToolTip(buttonDeleteValue_MAY, "удалить данные из файла ");
            buttonDeleteValue_MAY.UseVisualStyleBackColor = true;
            buttonDeleteValue_MAY.Click += buttonDeleteValue_MAY_Click_1;
            // 
            // buttonAddFile_MAY
            // 
            buttonAddFile_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddFile_MAY.Cursor = Cursors.Hand;
            buttonAddFile_MAY.Image = (Image)resources.GetObject("buttonAddFile_MAY.Image");
            buttonAddFile_MAY.Location = new Point(12, 498);
            buttonAddFile_MAY.Name = "buttonAddFile_MAY";
            buttonAddFile_MAY.Size = new Size(75, 51);
            buttonAddFile_MAY.TabIndex = 0;
            toolTip1.SetToolTip(buttonAddFile_MAY, "загрузить файл в формате csv");
            buttonAddFile_MAY.UseVisualStyleBackColor = true;
            buttonAddFile_MAY.Click += buttonAddFile_MAY_Click_1;
            // 
            // buttonDoneSaveToFile_MAY
            // 
            buttonDoneSaveToFile_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDoneSaveToFile_MAY.Cursor = Cursors.Hand;
            buttonDoneSaveToFile_MAY.Image = (Image)resources.GetObject("buttonDoneSaveToFile_MAY.Image");
            buttonDoneSaveToFile_MAY.Location = new Point(110, 498);
            buttonDoneSaveToFile_MAY.Name = "buttonDoneSaveToFile_MAY";
            buttonDoneSaveToFile_MAY.Size = new Size(75, 51);
            buttonDoneSaveToFile_MAY.TabIndex = 0;
            toolTip2.SetToolTip(buttonDoneSaveToFile_MAY, "сохранить данные в файл");
            buttonDoneSaveToFile_MAY.UseVisualStyleBackColor = true;
            buttonDoneSaveToFile_MAY.Click += buttonDoneSaveToFile_MAY_Click;
            // 
            // buttonAddValue_MAY
            // 
            buttonAddValue_MAY.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddValue_MAY.Cursor = Cursors.Hand;
            buttonAddValue_MAY.Image = (Image)resources.GetObject("buttonAddValue_MAY.Image");
            buttonAddValue_MAY.Location = new Point(12, 427);
            buttonAddValue_MAY.Name = "buttonAddValue_MAY";
            buttonAddValue_MAY.Size = new Size(75, 51);
            buttonAddValue_MAY.TabIndex = 0;
            toolTip4.SetToolTip(buttonAddValue_MAY, "добавить данные в файл");
            buttonAddValue_MAY.UseVisualStyleBackColor = true;
            buttonAddValue_MAY.Click += buttonAddValue_MAY_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewTransport_MAY);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(213, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 561);
            panel2.TabIndex = 0;
            // 
            // dataGridViewTransport_MAY
            // 
            dataGridViewTransport_MAY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransport_MAY.Dock = DockStyle.Fill;
            dataGridViewTransport_MAY.Location = new Point(0, 0);
            dataGridViewTransport_MAY.Name = "dataGridViewTransport_MAY";
            dataGridViewTransport_MAY.Size = new Size(771, 561);
            dataGridViewTransport_MAY.TabIndex = 0;
            dataGridViewTransport_MAY.CellContentClick += dataGridView1_CellContentClick;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(213, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 561);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Загрузить данные";
            // 
            // toolTip2
            // 
            toolTip2.Tag = "Сохранить";
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.ToolTipTitle = "Сохранить";
            // 
            // toolTip3
            // 
            toolTip3.ToolTipIcon = ToolTipIcon.Info;
            toolTip3.ToolTipTitle = "Удалить";
            // 
            // toolTip4
            // 
            toolTip4.ToolTipIcon = ToolTipIcon.Info;
            toolTip4.ToolTipTitle = "Добавить";
            // 
            // openFileDialog_MAY
            // 
            openFileDialog_MAY.FileName = "openFileDialog1";
            // 
            // FormRedact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 600);
            Name = "FormRedact";
            Text = "FormRedact";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransport_MAY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Button buttonDeleteValue_MAY;
        private Button buttonAddFile_MAY;
        private Button buttonDoneSaveToFile_MAY;
        private Button buttonAddValue_MAY;
        private Panel panel2;
        private DataGridView dataGridViewTransport_MAY;
        private Splitter splitter1;
        private ComboBox comboBoxSortValue_MAY;
        private ComboBox comboBoxSortСriterion_MAY;
        private Label labelValue_MAY;
        private Label labelSort_MAY;
        private ToolTip toolTip3;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip4;
        private OpenFileDialog openFileDialog_MAY;
        private SaveFileDialog saveFileDialog_MAY;
    }
}