namespace nanoCad
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCreateHex2D = new System.Windows.Forms.Button();
            this.btnCreateHex3D = new System.Windows.Forms.Button();
            this.btnImportAttributes = new System.Windows.Forms.Button();
            this.btnExportAttributes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtHexRadius2D = new System.Windows.Forms.TextBox();
            this.txtHexRadius3D = new System.Windows.Forms.TextBox();
            this.txtHexHeight3D = new System.Windows.Forms.TextBox();
            this.lblHexRadius2D = new System.Windows.Forms.Label();
            this.lblHexRadius3D = new System.Windows.Forms.Label();
            this.lblHexHeight3D = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateHex2D
            // 
            this.btnCreateHex2D.Location = new System.Drawing.Point(12, 90);
            this.btnCreateHex2D.Name = "btnCreateHex2D";
            this.btnCreateHex2D.Size = new System.Drawing.Size(200, 23);
            this.btnCreateHex2D.TabIndex = 0;
            this.btnCreateHex2D.Text = "Создать Гексагон 2D";
            this.btnCreateHex2D.UseVisualStyleBackColor = true;
            this.btnCreateHex2D.Click += new System.EventHandler(this.btnCreateHex2D_Click);
            // 
            // btnCreateHex3D
            // 
            this.btnCreateHex3D.Location = new System.Drawing.Point(230, 90);
            this.btnCreateHex3D.Name = "btnCreateHex3D";
            this.btnCreateHex3D.Size = new System.Drawing.Size(200, 23);
            this.btnCreateHex3D.TabIndex = 1;
            this.btnCreateHex3D.Text = "Создать Гексагон 3D";
            this.btnCreateHex3D.UseVisualStyleBackColor = true;
            this.btnCreateHex3D.Click += new System.EventHandler(this.btnCreateHex3D_Click);
            // 
            // btnImportAttributes
            // 
            this.btnImportAttributes.Location = new System.Drawing.Point(12, 148);
            this.btnImportAttributes.Name = "btnImportAttributes";
            this.btnImportAttributes.Size = new System.Drawing.Size(200, 23);
            this.btnImportAttributes.TabIndex = 2;
            this.btnImportAttributes.Text = "Импортировать Атрибуты";
            this.btnImportAttributes.UseVisualStyleBackColor = true;
            this.btnImportAttributes.Click += new System.EventHandler(this.btnImportAttributes_Click);
            // 
            // btnExportAttributes
            // 
            this.btnExportAttributes.Location = new System.Drawing.Point(230, 148);
            this.btnExportAttributes.Name = "btnExportAttributes";
            this.btnExportAttributes.Size = new System.Drawing.Size(200, 23);
            this.btnExportAttributes.TabIndex = 3;
            this.btnExportAttributes.Text = "Экспортировать Атрибуты";
            this.btnExportAttributes.UseVisualStyleBackColor = true;
            this.btnExportAttributes.Click += new System.EventHandler(this.btnExportAttributes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(418, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtHexRadius2D
            // 
            this.txtHexRadius2D.Location = new System.Drawing.Point(12, 25);
            this.txtHexRadius2D.Name = "txtHexRadius2D";
            this.txtHexRadius2D.Size = new System.Drawing.Size(200, 20);
            this.txtHexRadius2D.TabIndex = 5;
            // 
            // txtHexRadius3D
            // 
            this.txtHexRadius3D.Location = new System.Drawing.Point(230, 25);
            this.txtHexRadius3D.Name = "txtHexRadius3D";
            this.txtHexRadius3D.Size = new System.Drawing.Size(200, 20);
            this.txtHexRadius3D.TabIndex = 6;
            // 
            // txtHexHeight3D
            // 
            this.txtHexHeight3D.Location = new System.Drawing.Point(230, 64);
            this.txtHexHeight3D.Name = "txtHexHeight3D";
            this.txtHexHeight3D.Size = new System.Drawing.Size(200, 20);
            this.txtHexHeight3D.TabIndex = 7;
            // 
            // lblHexRadius2D
            // 
            this.lblHexRadius2D.AutoSize = true;
            this.lblHexRadius2D.Location = new System.Drawing.Point(12, 9);
            this.lblHexRadius2D.Name = "lblHexRadius2D";
            this.lblHexRadius2D.Size = new System.Drawing.Size(92, 13);
            this.lblHexRadius2D.TabIndex = 8;
            this.lblHexRadius2D.Text = "Радиус Гекса 2D";
            // 
            // lblHexRadius3D
            // 
            this.lblHexRadius3D.AutoSize = true;
            this.lblHexRadius3D.Location = new System.Drawing.Point(230, 9);
            this.lblHexRadius3D.Name = "lblHexRadius3D";
            this.lblHexRadius3D.Size = new System.Drawing.Size(92, 13);
            this.lblHexRadius3D.TabIndex = 9;
            this.lblHexRadius3D.Text = "Радиус Гекса 3D";
            // 
            // lblHexHeight3D
            // 
            this.lblHexHeight3D.AutoSize = true;
            this.lblHexHeight3D.Location = new System.Drawing.Point(230, 48);
            this.lblHexHeight3D.Name = "lblHexHeight3D";
            this.lblHexHeight3D.Size = new System.Drawing.Size(92, 13);
            this.lblHexHeight3D.TabIndex = 10;
            this.lblHexHeight3D.Text = "Высота Гекса 3D";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(442, 241);
            this.Controls.Add(this.lblHexHeight3D);
            this.Controls.Add(this.lblHexRadius3D);
            this.Controls.Add(this.lblHexRadius2D);
            this.Controls.Add(this.txtHexHeight3D);
            this.Controls.Add(this.txtHexRadius3D);
            this.Controls.Add(this.txtHexRadius2D);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExportAttributes);
            this.Controls.Add(this.btnImportAttributes);
            this.Controls.Add(this.btnCreateHex3D);
            this.Controls.Add(this.btnCreateHex2D);
            this.Name = "MainForm";
            this.Text = "Управление Примитивами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnCreateHex2D;
        private System.Windows.Forms.Button btnCreateHex3D;
        private System.Windows.Forms.Button btnImportAttributes;
        private System.Windows.Forms.Button btnExportAttributes;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtHexRadius2D;
        private System.Windows.Forms.TextBox txtHexRadius3D;
        private System.Windows.Forms.TextBox txtHexHeight3D;
        private System.Windows.Forms.Label lblHexRadius2D;
        private System.Windows.Forms.Label lblHexRadius3D;
        private System.Windows.Forms.Label lblHexHeight3D;
    }
}