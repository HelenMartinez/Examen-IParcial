
namespace HelenMartínez
{
    partial class TercerFormulario
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
            this.NumerosListBox = new System.Windows.Forms.ListBox();
            this.CalculoButton = new System.Windows.Forms.Button();
            this.Multiplos3ListBox = new System.Windows.Forms.ListBox();
            this.Multiplos5ListBox2 = new System.Windows.Forms.ListBox();
            this.NombreApellidoListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumerosListBox
            // 
            this.NumerosListBox.FormattingEnabled = true;
            this.NumerosListBox.ItemHeight = 16;
            this.NumerosListBox.Location = new System.Drawing.Point(21, 163);
            this.NumerosListBox.Name = "NumerosListBox";
            this.NumerosListBox.Size = new System.Drawing.Size(189, 388);
            this.NumerosListBox.TabIndex = 0;
            // 
            // CalculoButton
            // 
            this.CalculoButton.Location = new System.Drawing.Point(352, 12);
            this.CalculoButton.Name = "CalculoButton";
            this.CalculoButton.Size = new System.Drawing.Size(147, 46);
            this.CalculoButton.TabIndex = 1;
            this.CalculoButton.Text = "button1";
            this.CalculoButton.UseVisualStyleBackColor = true;
            this.CalculoButton.Click += new System.EventHandler(this.CalculoButton_Click);
            // 
            // Multiplos3ListBox
            // 
            this.Multiplos3ListBox.FormattingEnabled = true;
            this.Multiplos3ListBox.ItemHeight = 16;
            this.Multiplos3ListBox.Location = new System.Drawing.Point(242, 163);
            this.Multiplos3ListBox.Name = "Multiplos3ListBox";
            this.Multiplos3ListBox.Size = new System.Drawing.Size(189, 388);
            this.Multiplos3ListBox.TabIndex = 2;
            // 
            // Multiplos5ListBox2
            // 
            this.Multiplos5ListBox2.FormattingEnabled = true;
            this.Multiplos5ListBox2.ItemHeight = 16;
            this.Multiplos5ListBox2.Location = new System.Drawing.Point(469, 163);
            this.Multiplos5ListBox2.Name = "Multiplos5ListBox2";
            this.Multiplos5ListBox2.Size = new System.Drawing.Size(189, 388);
            this.Multiplos5ListBox2.TabIndex = 3;
            // 
            // NombreApellidoListBox
            // 
            this.NombreApellidoListBox.FormattingEnabled = true;
            this.NombreApellidoListBox.ItemHeight = 16;
            this.NombreApellidoListBox.Location = new System.Drawing.Point(714, 163);
            this.NombreApellidoListBox.Name = "NombreApellidoListBox";
            this.NombreApellidoListBox.Size = new System.Drawing.Size(189, 388);
            this.NombreApellidoListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numeros 1 a 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Multiplos de 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Multiplos de 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(748, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Multiplos de 3 y 5";
            // 
            // TercerFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreApellidoListBox);
            this.Controls.Add(this.Multiplos5ListBox2);
            this.Controls.Add(this.Multiplos3ListBox);
            this.Controls.Add(this.CalculoButton);
            this.Controls.Add(this.NumerosListBox);
            this.Name = "TercerFormulario";
            this.Text = "TercerFormulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NumerosListBox;
        private System.Windows.Forms.Button CalculoButton;
        private System.Windows.Forms.ListBox Multiplos3ListBox;
        private System.Windows.Forms.ListBox Multiplos5ListBox2;
        private System.Windows.Forms.ListBox NombreApellidoListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}