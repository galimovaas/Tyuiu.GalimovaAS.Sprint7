namespace Tyuiu.GalimovaAS.Sprint7.Project.V12
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
            groupBoxInfo_GAS = new GroupBox();
            radioButtonBattery_GAS = new RadioButton();
            radioButtonDate_GAS = new RadioButton();
            radioButtonScreen_GAS = new RadioButton();
            labelSpecifications_GAS = new Label();
            radioButtonSSD_GAS = new RadioButton();
            radioButtonFrequency_GAS = new RadioButton();
            radioButtonProcessor_GAS = new RadioButton();
            labelModel_GAS = new Label();
            textBoxModel_GAS = new TextBox();
            textBoxBrand_GAS = new TextBox();
            labelBrand_GAS = new Label();
            panelResult_GAS = new Panel();
            textBoxShopInfo_GAS = new TextBox();
            textBoxShowModels_GAS = new TextBox();
            labelResult_GAS = new Label();
            textBoxResult_GAS = new TextBox();
            buttonShow_GAS = new Button();
            buttonShopInfo_GAS = new Button();
            buttonDone_GAS = new Button();
            buttonInfo_GAS = new Button();
            toolTip_GAS = new ToolTip(components);
            groupBoxInfo_GAS.SuspendLayout();
            panelResult_GAS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInfo_GAS
            // 
            groupBoxInfo_GAS.BackColor = Color.FromArgb(255, 192, 255);
            groupBoxInfo_GAS.Controls.Add(radioButtonBattery_GAS);
            groupBoxInfo_GAS.Controls.Add(radioButtonDate_GAS);
            groupBoxInfo_GAS.Controls.Add(radioButtonScreen_GAS);
            groupBoxInfo_GAS.Controls.Add(labelSpecifications_GAS);
            groupBoxInfo_GAS.Controls.Add(radioButtonSSD_GAS);
            groupBoxInfo_GAS.Controls.Add(radioButtonFrequency_GAS);
            groupBoxInfo_GAS.Controls.Add(radioButtonProcessor_GAS);
            groupBoxInfo_GAS.Controls.Add(labelModel_GAS);
            groupBoxInfo_GAS.Controls.Add(textBoxModel_GAS);
            groupBoxInfo_GAS.Controls.Add(textBoxBrand_GAS);
            groupBoxInfo_GAS.Controls.Add(labelBrand_GAS);
            groupBoxInfo_GAS.Location = new Point(12, 12);
            groupBoxInfo_GAS.Name = "groupBoxInfo_GAS";
            groupBoxInfo_GAS.Size = new Size(753, 272);
            groupBoxInfo_GAS.TabIndex = 0;
            groupBoxInfo_GAS.TabStop = false;
            groupBoxInfo_GAS.Text = "Ввод данных:";
            // 
            // radioButtonBattery_GAS
            // 
            radioButtonBattery_GAS.AutoSize = true;
            radioButtonBattery_GAS.Location = new Point(330, 227);
            radioButtonBattery_GAS.Name = "radioButtonBattery_GAS";
            radioButtonBattery_GAS.Size = new Size(155, 24);
            radioButtonBattery_GAS.TabIndex = 10;
            radioButtonBattery_GAS.TabStop = true;
            radioButtonBattery_GAS.Text = "Тип аккумулятора";
            radioButtonBattery_GAS.UseVisualStyleBackColor = true;
            // 
            // radioButtonDate_GAS
            // 
            radioButtonDate_GAS.AutoSize = true;
            radioButtonDate_GAS.Location = new Point(613, 227);
            radioButtonDate_GAS.Name = "radioButtonDate_GAS";
            radioButtonDate_GAS.Size = new Size(123, 24);
            radioButtonDate_GAS.TabIndex = 2;
            radioButtonDate_GAS.TabStop = true;
            radioButtonDate_GAS.Text = "Дата выпуска";
            radioButtonDate_GAS.UseVisualStyleBackColor = true;
            // 
            // radioButtonScreen_GAS
            // 
            radioButtonScreen_GAS.AutoSize = true;
            radioButtonScreen_GAS.Location = new Point(330, 183);
            radioButtonScreen_GAS.Name = "radioButtonScreen_GAS";
            radioButtonScreen_GAS.Size = new Size(161, 24);
            radioButtonScreen_GAS.TabIndex = 9;
            radioButtonScreen_GAS.TabStop = true;
            radioButtonScreen_GAS.Text = "Диагональ экрана ";
            radioButtonScreen_GAS.UseVisualStyleBackColor = true;
            // 
            // labelSpecifications_GAS
            // 
            labelSpecifications_GAS.AutoSize = true;
            labelSpecifications_GAS.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSpecifications_GAS.Location = new Point(312, 157);
            labelSpecifications_GAS.Name = "labelSpecifications_GAS";
            labelSpecifications_GAS.Size = new Size(160, 23);
            labelSpecifications_GAS.TabIndex = 8;
            labelSpecifications_GAS.Text = "Характеристики";
            // 
            // radioButtonSSD_GAS
            // 
            radioButtonSSD_GAS.AutoSize = true;
            radioButtonSSD_GAS.Location = new Point(613, 183);
            radioButtonSSD_GAS.Name = "radioButtonSSD_GAS";
            radioButtonSSD_GAS.Size = new Size(112, 24);
            radioButtonSSD_GAS.TabIndex = 6;
            radioButtonSSD_GAS.TabStop = true;
            radioButtonSSD_GAS.Text = "Объём SDD";
            radioButtonSSD_GAS.UseVisualStyleBackColor = true;
            // 
            // radioButtonFrequency_GAS
            // 
            radioButtonFrequency_GAS.AutoSize = true;
            radioButtonFrequency_GAS.Location = new Point(6, 227);
            radioButtonFrequency_GAS.Name = "radioButtonFrequency_GAS";
            radioButtonFrequency_GAS.Size = new Size(148, 24);
            radioButtonFrequency_GAS.TabIndex = 5;
            radioButtonFrequency_GAS.TabStop = true;
            radioButtonFrequency_GAS.Text = "Тактовая частота";
            radioButtonFrequency_GAS.UseVisualStyleBackColor = true;
            // 
            // radioButtonProcessor_GAS
            // 
            radioButtonProcessor_GAS.AutoSize = true;
            radioButtonProcessor_GAS.Location = new Point(6, 183);
            radioButtonProcessor_GAS.Name = "radioButtonProcessor_GAS";
            radioButtonProcessor_GAS.Size = new Size(144, 24);
            radioButtonProcessor_GAS.TabIndex = 4;
            radioButtonProcessor_GAS.TabStop = true;
            radioButtonProcessor_GAS.Text = "Тип процессора";
            radioButtonProcessor_GAS.UseVisualStyleBackColor = true;
            // 
            // labelModel_GAS
            // 
            labelModel_GAS.AutoSize = true;
            labelModel_GAS.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelModel_GAS.Location = new Point(6, 98);
            labelModel_GAS.Name = "labelModel_GAS";
            labelModel_GAS.Size = new Size(469, 23);
            labelModel_GAS.TabIndex = 3;
            labelModel_GAS.Text = "Введите название модели необходимого продукта:";
            // 
            // textBoxModel_GAS
            // 
            textBoxModel_GAS.Location = new Point(6, 121);
            textBoxModel_GAS.Multiline = true;
            textBoxModel_GAS.Name = "textBoxModel_GAS";
            textBoxModel_GAS.Size = new Size(741, 34);
            textBoxModel_GAS.TabIndex = 1;
            // 
            // textBoxBrand_GAS
            // 
            textBoxBrand_GAS.Location = new Point(6, 56);
            textBoxBrand_GAS.Multiline = true;
            textBoxBrand_GAS.Name = "textBoxBrand_GAS";
            textBoxBrand_GAS.Size = new Size(741, 34);
            textBoxBrand_GAS.TabIndex = 0;
            // 
            // labelBrand_GAS
            // 
            labelBrand_GAS.AutoSize = true;
            labelBrand_GAS.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBrand_GAS.Location = new Point(6, 35);
            labelBrand_GAS.Name = "labelBrand_GAS";
            labelBrand_GAS.Size = new Size(465, 46);
            labelBrand_GAS.TabIndex = 0;
            labelBrand_GAS.Text = "Введите название бренда необходимого продукта:\r\n\r\n";
            // 
            // panelResult_GAS
            // 
            panelResult_GAS.BackColor = SystemColors.Info;
            panelResult_GAS.Controls.Add(textBoxShopInfo_GAS);
            panelResult_GAS.Controls.Add(textBoxShowModels_GAS);
            panelResult_GAS.Controls.Add(labelResult_GAS);
            panelResult_GAS.Controls.Add(textBoxResult_GAS);
            panelResult_GAS.Location = new Point(12, 290);
            panelResult_GAS.Name = "panelResult_GAS";
            panelResult_GAS.Size = new Size(1214, 306);
            panelResult_GAS.TabIndex = 1;
            // 
            // textBoxShopInfo_GAS
            // 
            textBoxShopInfo_GAS.Font = new Font("Segoe UI", 13F);
            textBoxShopInfo_GAS.Location = new Point(649, 20);
            textBoxShopInfo_GAS.Multiline = true;
            textBoxShopInfo_GAS.Name = "textBoxShopInfo_GAS";
            textBoxShopInfo_GAS.Size = new Size(527, 263);
            textBoxShopInfo_GAS.TabIndex = 3;
            // 
            // textBoxShowModels_GAS
            // 
            textBoxShowModels_GAS.Font = new Font("Segoe UI", 13F);
            textBoxShowModels_GAS.Location = new Point(6, 64);
            textBoxShowModels_GAS.Multiline = true;
            textBoxShowModels_GAS.Name = "textBoxShowModels_GAS";
            textBoxShowModels_GAS.Size = new Size(609, 219);
            textBoxShowModels_GAS.TabIndex = 2;
            // 
            // labelResult_GAS
            // 
            labelResult_GAS.AutoSize = true;
            labelResult_GAS.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResult_GAS.Location = new Point(9, 7);
            labelResult_GAS.Name = "labelResult_GAS";
            labelResult_GAS.Size = new Size(190, 23);
            labelResult_GAS.TabIndex = 1;
            labelResult_GAS.Text = "Результаты поиска:";
            // 
            // textBoxResult_GAS
            // 
            textBoxResult_GAS.Location = new Point(9, 33);
            textBoxResult_GAS.Multiline = true;
            textBoxResult_GAS.Name = "textBoxResult_GAS";
            textBoxResult_GAS.Size = new Size(606, 25);
            textBoxResult_GAS.TabIndex = 0;
            // 
            // buttonShow_GAS
            // 
            buttonShow_GAS.BackColor = Color.White;
            buttonShow_GAS.FlatStyle = FlatStyle.Flat;
            buttonShow_GAS.Image = (Image)resources.GetObject("buttonShow_GAS.Image");
            buttonShow_GAS.Location = new Point(792, 180);
            buttonShow_GAS.Name = "buttonShow_GAS";
            buttonShow_GAS.Size = new Size(162, 83);
            buttonShow_GAS.TabIndex = 2;
            toolTip_GAS.SetToolTip(buttonShow_GAS, "Выводит модели ноутбуков, которые необходимы");
            buttonShow_GAS.UseVisualStyleBackColor = false;
            buttonShow_GAS.Click += buttonShow_GAS_Click;
            // 
            // buttonShopInfo_GAS
            // 
            buttonShopInfo_GAS.BackColor = SystemColors.Info;
            buttonShopInfo_GAS.FlatStyle = FlatStyle.Flat;
            buttonShopInfo_GAS.Image = (Image)resources.GetObject("buttonShopInfo_GAS.Image");
            buttonShopInfo_GAS.Location = new Point(1118, 207);
            buttonShopInfo_GAS.Name = "buttonShopInfo_GAS";
            buttonShopInfo_GAS.Size = new Size(94, 56);
            buttonShopInfo_GAS.TabIndex = 3;
            toolTip_GAS.SetToolTip(buttonShopInfo_GAS, "Выводит информацию о производителе");
            buttonShopInfo_GAS.UseVisualStyleBackColor = false;
            buttonShopInfo_GAS.Click += buttonShopInfo_GAS_Click;
            // 
            // buttonDone_GAS
            // 
            buttonDone_GAS.BackColor = SystemColors.Info;
            buttonDone_GAS.FlatStyle = FlatStyle.Flat;
            buttonDone_GAS.Image = (Image)resources.GetObject("buttonDone_GAS.Image");
            buttonDone_GAS.Location = new Point(992, 207);
            buttonDone_GAS.Name = "buttonDone_GAS";
            buttonDone_GAS.Size = new Size(94, 56);
            buttonDone_GAS.TabIndex = 4;
            toolTip_GAS.SetToolTip(buttonDone_GAS, "Выводит информацию о моделе ноутбука");
            buttonDone_GAS.UseVisualStyleBackColor = false;
            buttonDone_GAS.Click += buttonDone_GAS_Click;
            // 
            // buttonInfo_GAS
            // 
            buttonInfo_GAS.BackColor = Color.White;
            buttonInfo_GAS.FlatStyle = FlatStyle.Flat;
            buttonInfo_GAS.Image = (Image)resources.GetObject("buttonInfo_GAS.Image");
            buttonInfo_GAS.Location = new Point(1171, 12);
            buttonInfo_GAS.Name = "buttonInfo_GAS";
            buttonInfo_GAS.Size = new Size(41, 42);
            buttonInfo_GAS.TabIndex = 5;
            toolTip_GAS.SetToolTip(buttonInfo_GAS, "Информация о разработчике");
            buttonInfo_GAS.UseVisualStyleBackColor = false;
            buttonInfo_GAS.Click += buttonInfo_GAS_Click;
            // 
            // toolTip_GAS
            // 
            toolTip_GAS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1238, 602);
            Controls.Add(buttonInfo_GAS);
            Controls.Add(buttonDone_GAS);
            Controls.Add(buttonShopInfo_GAS);
            Controls.Add(buttonShow_GAS);
            Controls.Add(panelResult_GAS);
            Controls.Add(groupBoxInfo_GAS);
            Name = "FormMain";
            Text = "Form1";
            groupBoxInfo_GAS.ResumeLayout(false);
            groupBoxInfo_GAS.PerformLayout();
            panelResult_GAS.ResumeLayout(false);
            panelResult_GAS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInfo_GAS;
        private Label labelModel_GAS;
        private Label labelBrand_GAS;
        private TextBox textBoxModel_GAS;
        private TextBox textBoxBrand_GAS;
        private RadioButton radioButtonProcessor_GAS;
        private Label labelSpecifications_GAS;
        private RadioButton radioButtonDate_GAS;
        private RadioButton radioButtonSSD_GAS;
        private RadioButton radioButtonFrequency_GAS;
        private RadioButton radioButtonBattery_GAS;
        private RadioButton radioButtonScreen_GAS;
        private Panel panelResult_GAS;
        private TextBox textBoxResult_GAS;
        private TextBox textBoxShopInfo_GAS;
        private TextBox textBoxShowModels_GAS;
        private Label labelResult_GAS;
        private Button buttonShow_GAS;
        private Button buttonShopInfo_GAS;
        private Button buttonDone_GAS;
        private Button buttonInfo_GAS;
        private ToolTip toolTip_GAS;
    }
}
