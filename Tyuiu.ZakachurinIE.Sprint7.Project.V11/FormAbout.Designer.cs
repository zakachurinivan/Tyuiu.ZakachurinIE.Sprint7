
namespace Tyuiu.ZakachurinIE.Sprint7.Project.V11
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
            textBoxInfo_ZIE = new TextBox();
            buttonOK_ZIE = new Button();
            SuspendLayout();
            // 
            // textBoxInfo_ZIE
            // 
            textBoxInfo_ZIE.Dock = DockStyle.Fill;
            textBoxInfo_ZIE.Location = new Point(0, 0);
            textBoxInfo_ZIE.Multiline = true;
            textBoxInfo_ZIE.Name = "textBoxInfo_ZIE";
            textBoxInfo_ZIE.ReadOnly = true;
            textBoxInfo_ZIE.Size = new Size(384, 161);
            textBoxInfo_ZIE.TabIndex = 5;
            textBoxInfo_ZIE.Text = resources.GetString("textBoxInfo_ZIE.Text");
            // 
            // buttonOK_ZIE
            // 
            buttonOK_ZIE.Location = new Point(313, 117);
            buttonOK_ZIE.Name = "buttonOK_ZIE";
            buttonOK_ZIE.Size = new Size(71, 44);
            buttonOK_ZIE.TabIndex = 6;
            buttonOK_ZIE.Text = "OK";
            buttonOK_ZIE.UseVisualStyleBackColor = true;
            buttonOK_ZIE.Click += buttonOK_ZIE_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(buttonOK_ZIE);
            Controls.Add(textBoxInfo_ZIE);
            MaximizeBox = false;
            MaximumSize = new Size(400, 200);
            MinimizeBox = false;
            MinimumSize = new Size(400, 200);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBoxInfo_ZIE;
        private Button buttonOK_ZIE;
    }
}