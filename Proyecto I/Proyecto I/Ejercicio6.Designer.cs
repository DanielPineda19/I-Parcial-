namespace Proyecto_I
{
    partial class Ejercicio6
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
            this.ArreglosListBox = new System.Windows.Forms.ListBox();
            this.ArreglosButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ArreglosListBox
            // 
            this.ArreglosListBox.FormattingEnabled = true;
            this.ArreglosListBox.ItemHeight = 22;
            this.ArreglosListBox.Location = new System.Drawing.Point(12, 12);
            this.ArreglosListBox.Name = "ArreglosListBox";
            this.ArreglosListBox.Size = new System.Drawing.Size(209, 444);
            this.ArreglosListBox.TabIndex = 0;
            // 
            // ArreglosButton
            // 
            this.ArreglosButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArreglosButton.Location = new System.Drawing.Point(303, 202);
            this.ArreglosButton.Name = "ArreglosButton";
            this.ArreglosButton.Size = new System.Drawing.Size(138, 65);
            this.ArreglosButton.TabIndex = 1;
            this.ArreglosButton.Text = "Ejecutar";
            this.ArreglosButton.UseVisualStyleBackColor = true;
            this.ArreglosButton.Click += new System.EventHandler(this.ArreglosButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 30);
            this.comboBox1.TabIndex = 2;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 473);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ArreglosButton);
            this.Controls.Add(this.ArreglosListBox);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ArreglosListBox;
        private System.Windows.Forms.Button ArreglosButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}