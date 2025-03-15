namespace ExercicioLogica
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
            txtPlaca = new MaskedTextBox();
            txtValidar = new Button();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(184, 99);
            txtPlaca.Mask = "aaa-0000";
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(60, 23);
            txtPlaca.TabIndex = 0;
            txtPlaca.MaskInputRejected += txtPlaca_MaskInputRejected;
            // 
            // txtValidar
            // 
            txtValidar.Location = new Point(184, 143);
            txtValidar.Name = "txtValidar";
            txtValidar.Size = new Size(75, 23);
            txtValidar.TabIndex = 1;
            txtValidar.Text = "Valídar";
            txtValidar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValidar);
            Controls.Add(txtPlaca);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtPlaca;
        private Button txtValidar;
    }
}
