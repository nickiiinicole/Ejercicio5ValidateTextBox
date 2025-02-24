namespace Ejercicio5ValidateTextBox
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.validateTextBox1 = new Ejercicio5ValidateTextBox.ValidateTextBox();
            this.SuspendLayout();
            // 
            // validateTextBox1
            // 
            this.validateTextBox1.Location = new System.Drawing.Point(101, 74);
            this.validateTextBox1.Multilinea = false;
            this.validateTextBox1.Name = "validateTextBox1";
            this.validateTextBox1.Size = new System.Drawing.Size(558, 42);
            this.validateTextBox1.TabIndex = 0;
            this.validateTextBox1.Texto = "hola";
            this.validateTextBox1.Tipo = Ejercicio5ValidateTextBox.eTipo.Textual;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validateTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Prueba de txtBox";
            this.ResumeLayout(false);

        }

        #endregion

        private ValidateTextBox validateTextBox1;
    }
}