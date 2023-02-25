
namespace HelenMartínez
{
    partial class PrimerFormulario
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
            this.MesesListBox = new System.Windows.Forms.ListBox();
            this.CalcularInteresButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InteresListBox = new System.Windows.Forms.ListBox();
            this.InteresTotalListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MesesListBox
            // 
            this.MesesListBox.FormattingEnabled = true;
            this.MesesListBox.ItemHeight = 16;
            this.MesesListBox.Location = new System.Drawing.Point(43, 259);
            this.MesesListBox.Name = "MesesListBox";
            this.MesesListBox.Size = new System.Drawing.Size(176, 308);
            this.MesesListBox.TabIndex = 0;
            // 
            // CalcularInteresButton
            // 
            this.CalcularInteresButton.Location = new System.Drawing.Point(272, 97);
            this.CalcularInteresButton.Name = "CalcularInteresButton";
            this.CalcularInteresButton.Size = new System.Drawing.Size(164, 54);
            this.CalcularInteresButton.TabIndex = 1;
            this.CalcularInteresButton.Text = "Calcular";
            this.CalcularInteresButton.UseVisualStyleBackColor = true;
            this.CalcularInteresButton.Click += new System.EventHandler(this.CalcularInteresButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Intereses Ganados Durante el Año 2023";
            // 
            // InteresListBox
            // 
            this.InteresListBox.FormattingEnabled = true;
            this.InteresListBox.ItemHeight = 16;
            this.InteresListBox.Location = new System.Drawing.Point(272, 259);
            this.InteresListBox.Name = "InteresListBox";
            this.InteresListBox.Size = new System.Drawing.Size(176, 308);
            this.InteresListBox.TabIndex = 3;
            // 
            // InteresTotalListBox
            // 
            this.InteresTotalListBox.FormattingEnabled = true;
            this.InteresTotalListBox.ItemHeight = 16;
            this.InteresTotalListBox.Location = new System.Drawing.Point(497, 259);
            this.InteresTotalListBox.Name = "InteresTotalListBox";
            this.InteresTotalListBox.Size = new System.Drawing.Size(176, 308);
            this.InteresTotalListBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interes Mensual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto";
            // 
            // PrimerFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 675);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InteresTotalListBox);
            this.Controls.Add(this.InteresListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularInteresButton);
            this.Controls.Add(this.MesesListBox);
            this.Name = "PrimerFormulario";
            this.Text = "PrimerFormulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MesesListBox;
        private System.Windows.Forms.Button CalcularInteresButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox InteresListBox;
        private System.Windows.Forms.ListBox InteresTotalListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}