namespace FormPrincipal
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
            rtbAppNoInstaladas = new RichTextBox();
            rtbAppInstaladas = new RichTextBox();
            SuspendLayout();
            // 
            // rtbAppNoInstaladas
            // 
            rtbAppNoInstaladas.BackColor = Color.Black;
            rtbAppNoInstaladas.ForeColor = SystemColors.Window;
            rtbAppNoInstaladas.Location = new Point(252, 12);
            rtbAppNoInstaladas.Name = "rtbAppNoInstaladas";
            rtbAppNoInstaladas.Size = new Size(208, 491);
            rtbAppNoInstaladas.TabIndex = 0;
            rtbAppNoInstaladas.Text = "";
            // 
            // rtbAppInstaladas
            // 
            rtbAppInstaladas.BackColor = Color.Black;
            rtbAppInstaladas.ForeColor = SystemColors.Window;
            rtbAppInstaladas.Location = new Point(12, 12);
            rtbAppInstaladas.Name = "rtbAppInstaladas";
            rtbAppInstaladas.Size = new Size(208, 491);
            rtbAppInstaladas.TabIndex = 1;
            rtbAppInstaladas.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(472, 551);
            Controls.Add(rtbAppInstaladas);
            Controls.Add(rtbAppNoInstaladas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbAppNoInstaladas;
        private RichTextBox rtbAppInstaladas;
    }
}