namespace Proyecto_I
{
    partial class Ejercicio4
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EjecutarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiaTextBox = new System.Windows.Forms.TextBox();
            this.AnioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MesTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SemanaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiasTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CitasTextBox = new System.Windows.Forms.TextBox();
            this.NuevaFechaTextBox = new System.Windows.Forms.TextBox();
            this.DiasRestaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(246, 12);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(119, 26);
            this.DateTimePicker.TabIndex = 0;
            // 
            // EjecutarButton
            // 
            this.EjecutarButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EjecutarButton.Location = new System.Drawing.Point(382, 8);
            this.EjecutarButton.Name = "EjecutarButton";
            this.EjecutarButton.Size = new System.Drawing.Size(119, 34);
            this.EjecutarButton.TabIndex = 1;
            this.EjecutarButton.Text = "Ejecutar";
            this.EjecutarButton.UseVisualStyleBackColor = true;
            this.EjecutarButton.Click += new System.EventHandler(this.EjecutarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Día: ";
            // 
            // DiaTextBox
            // 
            this.DiaTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaTextBox.Location = new System.Drawing.Point(246, 67);
            this.DiaTextBox.Name = "DiaTextBox";
            this.DiaTextBox.ReadOnly = true;
            this.DiaTextBox.Size = new System.Drawing.Size(168, 26);
            this.DiaTextBox.TabIndex = 3;
            // 
            // AnioTextBox
            // 
            this.AnioTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnioTextBox.Location = new System.Drawing.Point(246, 154);
            this.AnioTextBox.Name = "AnioTextBox";
            this.AnioTextBox.ReadOnly = true;
            this.AnioTextBox.Size = new System.Drawing.Size(168, 26);
            this.AnioTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año:";
            // 
            // MesTextBox
            // 
            this.MesTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesTextBox.Location = new System.Drawing.Point(246, 111);
            this.MesTextBox.Name = "MesTextBox";
            this.MesTextBox.ReadOnly = true;
            this.MesTextBox.Size = new System.Drawing.Size(168, 26);
            this.MesTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mes: ";
            // 
            // SemanaTextBox
            // 
            this.SemanaTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemanaTextBox.Location = new System.Drawing.Point(246, 200);
            this.SemanaTextBox.Name = "SemanaTextBox";
            this.SemanaTextBox.ReadOnly = true;
            this.SemanaTextBox.Size = new System.Drawing.Size(168, 26);
            this.SemanaTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dia de la semana:";
            // 
            // DiasTextBox
            // 
            this.DiasTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasTextBox.Location = new System.Drawing.Point(246, 245);
            this.DiasTextBox.Name = "DiasTextBox";
            this.DiasTextBox.Size = new System.Drawing.Size(168, 26);
            this.DiasTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Suma de días para cita:";
            // 
            // CitasTextBox
            // 
            this.CitasTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitasTextBox.Location = new System.Drawing.Point(436, 245);
            this.CitasTextBox.Name = "CitasTextBox";
            this.CitasTextBox.ReadOnly = true;
            this.CitasTextBox.Size = new System.Drawing.Size(168, 26);
            this.CitasTextBox.TabIndex = 12;
            // 
            // NuevaFechaTextBox
            // 
            this.NuevaFechaTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaFechaTextBox.Location = new System.Drawing.Point(436, 291);
            this.NuevaFechaTextBox.Name = "NuevaFechaTextBox";
            this.NuevaFechaTextBox.ReadOnly = true;
            this.NuevaFechaTextBox.Size = new System.Drawing.Size(355, 26);
            this.NuevaFechaTextBox.TabIndex = 15;
            // 
            // DiasRestaTextBox
            // 
            this.DiasRestaTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasRestaTextBox.Location = new System.Drawing.Point(246, 291);
            this.DiasRestaTextBox.Name = "DiasRestaTextBox";
            this.DiasRestaTextBox.Size = new System.Drawing.Size(168, 26);
            this.DiasRestaTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Resta de días:";
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 356);
            this.Controls.Add(this.NuevaFechaTextBox);
            this.Controls.Add(this.DiasRestaTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CitasTextBox);
            this.Controls.Add(this.DiasTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SemanaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EjecutarButton);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button EjecutarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiaTextBox;
        private System.Windows.Forms.TextBox AnioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MesTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SemanaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiasTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CitasTextBox;
        private System.Windows.Forms.TextBox NuevaFechaTextBox;
        private System.Windows.Forms.TextBox DiasRestaTextBox;
        private System.Windows.Forms.Label label6;
    }
}