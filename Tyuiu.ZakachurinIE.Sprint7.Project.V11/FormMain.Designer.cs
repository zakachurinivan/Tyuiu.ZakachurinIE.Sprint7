namespace Tyuiu.ZakachurinIE.Sprint7.Project.V11
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
            panelMain_ZIE = new Panel();
            groupBoxMainMenu_ZIE = new GroupBox();
            toolStripToolsPanel_ZIE = new ToolStrip();
            toolStripButtonAdd_ZIE = new ToolStripButton();
            toolStripButtonEdit_ZIE = new ToolStripButton();
            toolStripButtonDelete_ZIE = new ToolStripButton();
            toolStripButtonSave_ZIE = new ToolStripButton();
            toolStripButtonSearch_ZIE = new ToolStripButton();
            toolStripButtonStats_ZIE = new ToolStripButton();
            menuStripMain_ZIE = new MenuStrip();
            ToolStripMenuItemFile_ZIE = new ToolStripMenuItem();
            ToolStripMenuItemSave_ZIE = new ToolStripMenuItem();
            ToolStripMenuItemOpen_ZIE = new ToolStripMenuItem();
            ToolStripMenuItemPravka_ZIE = new ToolStripMenuItem();
            ToolStripMenuItemAdd_ZIE = new ToolStripMenuItem();
            ToolStripMenuItemEdit_ZIE = new ToolStripMenuItem();
            ToolStripMenuItemDelete_ZIE = new ToolStripMenuItem();
            ToolStripMenuItemInf_ZIE = new ToolStripMenuItem();
            ToolStripMenuItemAbout_ZIE = new ToolStripMenuItem();
            ToolStripMenuItemHelp_ZIE = new ToolStripMenuItem();
            panelText_ZIE = new Panel();
            groupBoxInf_ZIE = new GroupBox();
            comboBoxSort_ZIE = new ComboBox();
            textBoxExpStopInput_ZIE = new TextBox();
            buttonReset = new Button();
            buttonStats_ZIE = new Button();
            buttonSearch_ZIE = new Button();
            comboBoxPositionInput_ZIE = new ComboBox();
            textBoxExpStartInput_ZIE = new TextBox();
            textBoxSurnameText_ZIE = new TextBox();
            textBoxExperienceText_ZIE = new TextBox();
            textBoxSurnameInput_ZIE = new TextBox();
            textBoxPhoneInput_ZIE = new TextBox();
            textBoxPositionText_ZIE = new TextBox();
            textBoxPhoneText_ZIE = new TextBox();
            dataGridViewOutPut_ZIE = new DataGridView();
            toolTipHelp = new ToolTip(components);
            panelMain_ZIE.SuspendLayout();
            groupBoxMainMenu_ZIE.SuspendLayout();
            toolStripToolsPanel_ZIE.SuspendLayout();
            menuStripMain_ZIE.SuspendLayout();
            panelText_ZIE.SuspendLayout();
            groupBoxInf_ZIE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_ZIE).BeginInit();
            SuspendLayout();
            // 
            // panelMain_ZIE
            // 
            panelMain_ZIE.Controls.Add(groupBoxMainMenu_ZIE);
            panelMain_ZIE.Dock = DockStyle.Top;
            panelMain_ZIE.Location = new Point(0, 0);
            panelMain_ZIE.Name = "panelMain_ZIE";
            panelMain_ZIE.Size = new Size(685, 80);
            panelMain_ZIE.TabIndex = 0;
            // 
            // groupBoxMainMenu_ZIE
            // 
            groupBoxMainMenu_ZIE.Controls.Add(toolStripToolsPanel_ZIE);
            groupBoxMainMenu_ZIE.Controls.Add(menuStripMain_ZIE);
            groupBoxMainMenu_ZIE.Dock = DockStyle.Top;
            groupBoxMainMenu_ZIE.Location = new Point(0, 0);
            groupBoxMainMenu_ZIE.Name = "groupBoxMainMenu_ZIE";
            groupBoxMainMenu_ZIE.Size = new Size(685, 77);
            groupBoxMainMenu_ZIE.TabIndex = 0;
            groupBoxMainMenu_ZIE.TabStop = false;
            groupBoxMainMenu_ZIE.Text = "Главное меню";
            // 
            // toolStripToolsPanel_ZIE
            // 
            toolStripToolsPanel_ZIE.Items.AddRange(new ToolStripItem[] { toolStripButtonAdd_ZIE, toolStripButtonEdit_ZIE, toolStripButtonDelete_ZIE, toolStripButtonSave_ZIE, toolStripButtonSearch_ZIE, toolStripButtonStats_ZIE });
            toolStripToolsPanel_ZIE.Location = new Point(3, 43);
            toolStripToolsPanel_ZIE.Name = "toolStripToolsPanel_ZIE";
            toolStripToolsPanel_ZIE.Size = new Size(679, 25);
            toolStripToolsPanel_ZIE.TabIndex = 1;
            toolStripToolsPanel_ZIE.Text = "Панель инструментов";
            // 
            // toolStripButtonAdd_ZIE
            // 
            toolStripButtonAdd_ZIE.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAdd_ZIE.Image = (Image)resources.GetObject("toolStripButtonAdd_ZIE.Image");
            toolStripButtonAdd_ZIE.ImageTransparentColor = Color.Magenta;
            toolStripButtonAdd_ZIE.Name = "toolStripButtonAdd_ZIE";
            toolStripButtonAdd_ZIE.Size = new Size(23, 22);
            toolStripButtonAdd_ZIE.Text = "Добавить";
            toolStripButtonAdd_ZIE.Click += ToolStripButtonAdd_Click;
            // 
            // toolStripButtonEdit_ZIE
            // 
            toolStripButtonEdit_ZIE.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEdit_ZIE.Image = (Image)resources.GetObject("toolStripButtonEdit_ZIE.Image");
            toolStripButtonEdit_ZIE.ImageTransparentColor = Color.Magenta;
            toolStripButtonEdit_ZIE.Name = "toolStripButtonEdit_ZIE";
            toolStripButtonEdit_ZIE.Size = new Size(23, 22);
            toolStripButtonEdit_ZIE.Text = "Редактировать";
            toolStripButtonEdit_ZIE.Click += toolStripButtonEdit_ZIE_Click;
            // 
            // toolStripButtonDelete_ZIE
            // 
            toolStripButtonDelete_ZIE.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDelete_ZIE.Image = (Image)resources.GetObject("toolStripButtonDelete_ZIE.Image");
            toolStripButtonDelete_ZIE.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelete_ZIE.Name = "toolStripButtonDelete_ZIE";
            toolStripButtonDelete_ZIE.Size = new Size(23, 22);
            toolStripButtonDelete_ZIE.Text = "Удалить";
            toolStripButtonDelete_ZIE.Click += toolStripButtonDelete_ZIE_Click;
            // 
            // toolStripButtonSave_ZIE
            // 
            toolStripButtonSave_ZIE.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave_ZIE.Image = (Image)resources.GetObject("toolStripButtonSave_ZIE.Image");
            toolStripButtonSave_ZIE.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave_ZIE.Name = "toolStripButtonSave_ZIE";
            toolStripButtonSave_ZIE.Size = new Size(23, 22);
            toolStripButtonSave_ZIE.Text = "Сохранить";
            toolStripButtonSave_ZIE.Click += toolStripButtonSave_ZIE_Click;
            // 
            // toolStripButtonSearch_ZIE
            // 
            toolStripButtonSearch_ZIE.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSearch_ZIE.Image = (Image)resources.GetObject("toolStripButtonSearch_ZIE.Image");
            toolStripButtonSearch_ZIE.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearch_ZIE.Name = "toolStripButtonSearch_ZIE";
            toolStripButtonSearch_ZIE.Size = new Size(23, 22);
            toolStripButtonSearch_ZIE.Text = "Поиск";
            toolStripButtonSearch_ZIE.Click += buttonSearch_Click;
            // 
            // toolStripButtonStats_ZIE
            // 
            toolStripButtonStats_ZIE.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonStats_ZIE.Image = (Image)resources.GetObject("toolStripButtonStats_ZIE.Image");
            toolStripButtonStats_ZIE.ImageTransparentColor = Color.Magenta;
            toolStripButtonStats_ZIE.Name = "toolStripButtonStats_ZIE";
            toolStripButtonStats_ZIE.Size = new Size(23, 22);
            toolStripButtonStats_ZIE.Text = "Статистика";
            toolStripButtonStats_ZIE.Click += toolStripButtonStats_ZIE_Click;
            // 
            // menuStripMain_ZIE
            // 
            menuStripMain_ZIE.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemFile_ZIE, ToolStripMenuItemPravka_ZIE, ToolStripMenuItemInf_ZIE });
            menuStripMain_ZIE.Location = new Point(3, 19);
            menuStripMain_ZIE.Name = "menuStripMain_ZIE";
            menuStripMain_ZIE.Size = new Size(679, 24);
            menuStripMain_ZIE.TabIndex = 0;
            menuStripMain_ZIE.Text = "Главное меню";
            // 
            // ToolStripMenuItemFile_ZIE
            // 
            ToolStripMenuItemFile_ZIE.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemSave_ZIE, ToolStripMenuItemOpen_ZIE });
            ToolStripMenuItemFile_ZIE.Name = "ToolStripMenuItemFile_ZIE";
            ToolStripMenuItemFile_ZIE.Size = new Size(48, 20);
            ToolStripMenuItemFile_ZIE.Text = "Файл";
            // 
            // ToolStripMenuItemSave_ZIE
            // 
            ToolStripMenuItemSave_ZIE.Name = "ToolStripMenuItemSave_ZIE";
            ToolStripMenuItemSave_ZIE.Size = new Size(180, 22);
            ToolStripMenuItemSave_ZIE.Text = "Сохранить";
            ToolStripMenuItemSave_ZIE.Click += toolStripButtonSave_ZIE_Click;
            // 
            // ToolStripMenuItemOpen_ZIE
            // 
            ToolStripMenuItemOpen_ZIE.Name = "ToolStripMenuItemOpen_ZIE";
            ToolStripMenuItemOpen_ZIE.Size = new Size(180, 22);
            ToolStripMenuItemOpen_ZIE.Text = "Открыть";
            ToolStripMenuItemOpen_ZIE.Click += openToolStripMenuItem_Click;
            // 
            // ToolStripMenuItemPravka_ZIE
            // 
            ToolStripMenuItemPravka_ZIE.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAdd_ZIE, ToolStripMenuItemEdit_ZIE, ToolStripMenuItemDelete_ZIE });
            ToolStripMenuItemPravka_ZIE.Name = "ToolStripMenuItemPravka_ZIE";
            ToolStripMenuItemPravka_ZIE.Size = new Size(59, 20);
            ToolStripMenuItemPravka_ZIE.Text = "Правка";
            // 
            // ToolStripMenuItemAdd_ZIE
            // 
            ToolStripMenuItemAdd_ZIE.Name = "ToolStripMenuItemAdd_ZIE";
            ToolStripMenuItemAdd_ZIE.Size = new Size(180, 22);
            ToolStripMenuItemAdd_ZIE.Text = "Добавить";
            ToolStripMenuItemAdd_ZIE.Click += ToolStripButtonAdd_Click;
            // 
            // ToolStripMenuItemEdit_ZIE
            // 
            ToolStripMenuItemEdit_ZIE.Name = "ToolStripMenuItemEdit_ZIE";
            ToolStripMenuItemEdit_ZIE.Size = new Size(180, 22);
            ToolStripMenuItemEdit_ZIE.Text = "Редактировать";
            ToolStripMenuItemEdit_ZIE.Click += toolStripButtonEdit_ZIE_Click;
            // 
            // ToolStripMenuItemDelete_ZIE
            // 
            ToolStripMenuItemDelete_ZIE.Name = "ToolStripMenuItemDelete_ZIE";
            ToolStripMenuItemDelete_ZIE.Size = new Size(180, 22);
            ToolStripMenuItemDelete_ZIE.Text = "Удалить";
            ToolStripMenuItemDelete_ZIE.Click += toolStripButtonDelete_ZIE_Click;
            // 
            // ToolStripMenuItemInf_ZIE
            // 
            ToolStripMenuItemInf_ZIE.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemAbout_ZIE, ToolStripMenuItemHelp_ZIE });
            ToolStripMenuItemInf_ZIE.Name = "ToolStripMenuItemInf_ZIE";
            ToolStripMenuItemInf_ZIE.Size = new Size(65, 20);
            ToolStripMenuItemInf_ZIE.Text = "Справка";
            // 
            // ToolStripMenuItemAbout_ZIE
            // 
            ToolStripMenuItemAbout_ZIE.Name = "ToolStripMenuItemAbout_ZIE";
            ToolStripMenuItemAbout_ZIE.Size = new Size(180, 22);
            ToolStripMenuItemAbout_ZIE.Text = "О программе";
            ToolStripMenuItemAbout_ZIE.Click += AboutToolStripMenuItem_Click;
            // 
            // ToolStripMenuItemHelp_ZIE
            // 
            ToolStripMenuItemHelp_ZIE.Name = "ToolStripMenuItemHelp_ZIE";
            ToolStripMenuItemHelp_ZIE.Size = new Size(180, 22);
            ToolStripMenuItemHelp_ZIE.Text = "Руководство";
            ToolStripMenuItemHelp_ZIE.Click += ToolStripMenuItemHelp_Click;
            // 
            // panelText_ZIE
            // 
            panelText_ZIE.Controls.Add(groupBoxInf_ZIE);
            panelText_ZIE.Dock = DockStyle.Top;
            panelText_ZIE.Location = new Point(0, 80);
            panelText_ZIE.Name = "panelText_ZIE";
            panelText_ZIE.Size = new Size(685, 173);
            panelText_ZIE.TabIndex = 1;
            // 
            // groupBoxInf_ZIE
            // 
            groupBoxInf_ZIE.Controls.Add(comboBoxSort_ZIE);
            groupBoxInf_ZIE.Controls.Add(textBoxExpStopInput_ZIE);
            groupBoxInf_ZIE.Controls.Add(buttonReset);
            groupBoxInf_ZIE.Controls.Add(buttonStats_ZIE);
            groupBoxInf_ZIE.Controls.Add(buttonSearch_ZIE);
            groupBoxInf_ZIE.Controls.Add(comboBoxPositionInput_ZIE);
            groupBoxInf_ZIE.Controls.Add(textBoxExpStartInput_ZIE);
            groupBoxInf_ZIE.Controls.Add(textBoxSurnameText_ZIE);
            groupBoxInf_ZIE.Controls.Add(textBoxExperienceText_ZIE);
            groupBoxInf_ZIE.Controls.Add(textBoxSurnameInput_ZIE);
            groupBoxInf_ZIE.Controls.Add(textBoxPhoneInput_ZIE);
            groupBoxInf_ZIE.Controls.Add(textBoxPositionText_ZIE);
            groupBoxInf_ZIE.Controls.Add(textBoxPhoneText_ZIE);
            groupBoxInf_ZIE.Dock = DockStyle.Top;
            groupBoxInf_ZIE.Location = new Point(0, 0);
            groupBoxInf_ZIE.Name = "groupBoxInf_ZIE";
            groupBoxInf_ZIE.Size = new Size(685, 170);
            groupBoxInf_ZIE.TabIndex = 2;
            groupBoxInf_ZIE.TabStop = false;
            groupBoxInf_ZIE.Text = "Данные  о сотруднике";
            // 
            // comboBoxSort_ZIE
            // 
            comboBoxSort_ZIE.Dock = DockStyle.Bottom;
            comboBoxSort_ZIE.FormattingEnabled = true;
            comboBoxSort_ZIE.Location = new Point(3, 144);
            comboBoxSort_ZIE.Name = "comboBoxSort_ZIE";
            comboBoxSort_ZIE.Size = new Size(450, 23);
            comboBoxSort_ZIE.TabIndex = 5;
            // 
            // textBoxExpStopInput_ZIE
            // 
            textBoxExpStopInput_ZIE.Location = new Point(372, 44);
            textBoxExpStopInput_ZIE.Name = "textBoxExpStopInput_ZIE";
            textBoxExpStopInput_ZIE.Size = new Size(37, 23);
            textBoxExpStopInput_ZIE.TabIndex = 0;
            // 
            // buttonReset
            // 
            buttonReset.Dock = DockStyle.Right;
            buttonReset.Location = new Point(453, 19);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(73, 148);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "Сбросить";
            toolTipHelp.SetToolTip(buttonReset, "Сбросить фильтры");
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonStats_ZIE
            // 
            buttonStats_ZIE.Dock = DockStyle.Right;
            buttonStats_ZIE.Location = new Point(526, 19);
            buttonStats_ZIE.Name = "buttonStats_ZIE";
            buttonStats_ZIE.Size = new Size(79, 148);
            buttonStats_ZIE.TabIndex = 4;
            buttonStats_ZIE.Text = "Статистика";
            toolTipHelp.SetToolTip(buttonStats_ZIE, "Открыть статистику и диаграммы");
            buttonStats_ZIE.UseVisualStyleBackColor = true;
            buttonStats_ZIE.Click += toolStripButtonStats_ZIE_Click;
            // 
            // buttonSearch_ZIE
            // 
            buttonSearch_ZIE.Dock = DockStyle.Right;
            buttonSearch_ZIE.Location = new Point(605, 19);
            buttonSearch_ZIE.Name = "buttonSearch_ZIE";
            buttonSearch_ZIE.Size = new Size(77, 148);
            buttonSearch_ZIE.TabIndex = 2;
            buttonSearch_ZIE.Text = "Найти";
            toolTipHelp.SetToolTip(buttonSearch_ZIE, "Применить фильтры");
            buttonSearch_ZIE.UseVisualStyleBackColor = true;
            buttonSearch_ZIE.Click += buttonSearch_Click;
            // 
            // comboBoxPositionInput_ZIE
            // 
            comboBoxPositionInput_ZIE.FormattingEnabled = true;
            comboBoxPositionInput_ZIE.Items.AddRange(new object[] { "Инженер" });
            comboBoxPositionInput_ZIE.Location = new Point(116, 44);
            comboBoxPositionInput_ZIE.Name = "comboBoxPositionInput_ZIE";
            comboBoxPositionInput_ZIE.Size = new Size(100, 23);
            comboBoxPositionInput_ZIE.TabIndex = 1;
            // 
            // textBoxExpStartInput_ZIE
            // 
            textBoxExpStartInput_ZIE.Location = new Point(328, 44);
            textBoxExpStartInput_ZIE.Name = "textBoxExpStartInput_ZIE";
            textBoxExpStartInput_ZIE.Size = new Size(38, 23);
            textBoxExpStartInput_ZIE.TabIndex = 0;
            // 
            // textBoxSurnameText_ZIE
            // 
            textBoxSurnameText_ZIE.BackColor = SystemColors.Menu;
            textBoxSurnameText_ZIE.BorderStyle = BorderStyle.None;
            textBoxSurnameText_ZIE.Location = new Point(10, 22);
            textBoxSurnameText_ZIE.Name = "textBoxSurnameText_ZIE";
            textBoxSurnameText_ZIE.Size = new Size(100, 16);
            textBoxSurnameText_ZIE.TabIndex = 0;
            textBoxSurnameText_ZIE.Text = "Фамилия:";
            // 
            // textBoxExperienceText_ZIE
            // 
            textBoxExperienceText_ZIE.BackColor = SystemColors.Menu;
            textBoxExperienceText_ZIE.BorderStyle = BorderStyle.None;
            textBoxExperienceText_ZIE.Location = new Point(328, 22);
            textBoxExperienceText_ZIE.Name = "textBoxExperienceText_ZIE";
            textBoxExperienceText_ZIE.Size = new Size(100, 16);
            textBoxExperienceText_ZIE.TabIndex = 0;
            textBoxExperienceText_ZIE.Text = "Стаж от: до:";
            // 
            // textBoxSurnameInput_ZIE
            // 
            textBoxSurnameInput_ZIE.Location = new Point(10, 44);
            textBoxSurnameInput_ZIE.Name = "textBoxSurnameInput_ZIE";
            textBoxSurnameInput_ZIE.Size = new Size(100, 23);
            textBoxSurnameInput_ZIE.TabIndex = 0;
            // 
            // textBoxPhoneInput_ZIE
            // 
            textBoxPhoneInput_ZIE.Location = new Point(222, 44);
            textBoxPhoneInput_ZIE.Name = "textBoxPhoneInput_ZIE";
            textBoxPhoneInput_ZIE.Size = new Size(100, 23);
            textBoxPhoneInput_ZIE.TabIndex = 0;
            // 
            // textBoxPositionText_ZIE
            // 
            textBoxPositionText_ZIE.BackColor = SystemColors.Menu;
            textBoxPositionText_ZIE.BorderStyle = BorderStyle.None;
            textBoxPositionText_ZIE.Location = new Point(116, 22);
            textBoxPositionText_ZIE.Name = "textBoxPositionText_ZIE";
            textBoxPositionText_ZIE.Size = new Size(100, 16);
            textBoxPositionText_ZIE.TabIndex = 0;
            textBoxPositionText_ZIE.Text = "Должность";
            // 
            // textBoxPhoneText_ZIE
            // 
            textBoxPhoneText_ZIE.BackColor = SystemColors.Menu;
            textBoxPhoneText_ZIE.BorderStyle = BorderStyle.None;
            textBoxPhoneText_ZIE.Location = new Point(222, 22);
            textBoxPhoneText_ZIE.Name = "textBoxPhoneText_ZIE";
            textBoxPhoneText_ZIE.Size = new Size(100, 16);
            textBoxPhoneText_ZIE.TabIndex = 0;
            textBoxPhoneText_ZIE.Text = "Телефон:";
            // 
            // dataGridViewOutPut_ZIE
            // 
            dataGridViewOutPut_ZIE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_ZIE.Dock = DockStyle.Fill;
            dataGridViewOutPut_ZIE.Location = new Point(0, 253);
            dataGridViewOutPut_ZIE.Name = "dataGridViewOutPut_ZIE";
            dataGridViewOutPut_ZIE.ReadOnly = true;
            dataGridViewOutPut_ZIE.RowHeadersVisible = false;
            dataGridViewOutPut_ZIE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOutPut_ZIE.Size = new Size(685, 197);
            dataGridViewOutPut_ZIE.TabIndex = 2;
            dataGridViewOutPut_ZIE.CellDoubleClick += dataGridViewOutPut_ZIE_CellDoubleClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 450);
            Controls.Add(dataGridViewOutPut_ZIE);
            Controls.Add(panelText_ZIE);
            Controls.Add(panelMain_ZIE);
            MainMenuStrip = menuStripMain_ZIE;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(700, 480);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 ProjectV11 Закачурин И.Е.";
            panelMain_ZIE.ResumeLayout(false);
            groupBoxMainMenu_ZIE.ResumeLayout(false);
            groupBoxMainMenu_ZIE.PerformLayout();
            toolStripToolsPanel_ZIE.ResumeLayout(false);
            toolStripToolsPanel_ZIE.PerformLayout();
            menuStripMain_ZIE.ResumeLayout(false);
            menuStripMain_ZIE.PerformLayout();
            panelText_ZIE.ResumeLayout(false);
            groupBoxInf_ZIE.ResumeLayout(false);
            groupBoxInf_ZIE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_ZIE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain_ZIE;
        private MenuStrip menuStripMain_ZIE;
        private ToolStripMenuItem ToolStripMenuItemFile_ZIE;
        private ToolStripMenuItem ToolStripMenuItemSave_ZIE;
        private ToolStripMenuItem ToolStripMenuItemPravka_ZIE;
        private ToolStripMenuItem ToolStripMenuItemAdd_ZIE;
        private ToolStripMenuItem ToolStripMenuItemEdit_ZIE;
        private ToolStripMenuItem ToolStripMenuItemDelete_ZIE;
        private ToolStripMenuItem ToolStripMenuItemInf_ZIE;
        private ToolStripMenuItem ToolStripMenuItemAbout_ZIE;
        private ToolStripMenuItem ToolStripMenuItemHelp_ZIE;
        private ToolStrip toolStripToolsPanel_ZIE;
        private ToolStripButton toolStripButtonAdd_ZIE;
        private ToolStripButton toolStripButtonEdit_ZIE;
        private ToolStripButton toolStripButtonDelete_ZIE;
        private ToolStripButton toolStripButtonSave_ZIE;
        private ToolStripButton toolStripButtonSearch_ZIE;
        private ToolStripButton toolStripButtonStats_ZIE;
        private Panel panelText_ZIE;
        private GroupBox groupBoxMainMenu_ZIE;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBoxExpStopInput_ZIE;
        private TextBox textBox9;
        private TextBox textBoxExpStartInput_ZIE;
        private TextBox textBoxExperienceText_ZIE;
        private TextBox textBoxPhoneInput_ZIE;
        private TextBox textBoxPhoneText_ZIE;
        private TextBox textBoxPositionText_ZIE;
        private TextBox textBoxSurnameInput_ZIE;
        private TextBox textBoxSurnameText_ZIE;
        private ComboBox comboBoxPositionInput_ZIE;
        private GroupBox groupBoxInf_ZIE;
        private DataGridView dataGridViewOutPut_ZIE;
        private Button buttonSearch_ZIE;
        private Button buttonReset;
        private ToolStripMenuItem ToolStripMenuItemOpen_ZIE;
        private Button buttonStats_ZIE;
        private ComboBox comboBoxSort_ZIE;
        private ToolTip toolTipHelp;
    }
}
