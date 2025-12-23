namespace Tyuiu.ZakachurinIE.Sprint7.Project.V11
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            textBox1 = new TextBox();
            buttonOK_ZIE = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(464, 176);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonOK_ZIE
            // 
            buttonOK_ZIE.Location = new Point(389, 153);
            buttonOK_ZIE.Name = "buttonOK_ZIE";
            buttonOK_ZIE.Size = new Size(75, 23);
            buttonOK_ZIE.TabIndex = 1;
            buttonOK_ZIE.Text = "ОК";
            buttonOK_ZIE.UseVisualStyleBackColor = true;
            buttonOK_ZIE.Click += buttonOK_ZIE_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 176);
            Controls.Add(buttonOK_ZIE);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MaximumSize = new Size(480, 215);
            MinimizeBox = false;
            MinimumSize = new Size(480, 215);
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonOK_ZIE;
    }
}