
namespace HelenMartínez
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulario1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulario2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulario3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulario1ToolStripMenuItem,
            this.formulario2ToolStripMenuItem,
            this.formulario3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(395, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulario1ToolStripMenuItem
            // 
            this.formulario1ToolStripMenuItem.Name = "formulario1ToolStripMenuItem";
            this.formulario1ToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.formulario1ToolStripMenuItem.Text = "Formulario 1";
            this.formulario1ToolStripMenuItem.Click += new System.EventHandler(this.formulario1ToolStripMenuItem_Click);
            // 
            // formulario2ToolStripMenuItem
            // 
            this.formulario2ToolStripMenuItem.Name = "formulario2ToolStripMenuItem";
            this.formulario2ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.formulario2ToolStripMenuItem.Text = " Formulario 2";
            this.formulario2ToolStripMenuItem.Click += new System.EventHandler(this.formulario2ToolStripMenuItem_Click);
            // 
            // formulario3ToolStripMenuItem
            // 
            this.formulario3ToolStripMenuItem.Name = "formulario3ToolStripMenuItem";
            this.formulario3ToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.formulario3ToolStripMenuItem.Text = "Formulario 3";
            this.formulario3ToolStripMenuItem.Click += new System.EventHandler(this.formulario3ToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 189);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulario1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulario2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulario3ToolStripMenuItem;
    }
}