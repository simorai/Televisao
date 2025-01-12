namespace TelevisaoForms
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
            Button btnDiminuiCanal;
            btnOnOff = new Button();
            lblInfo = new Label();
            groupBoxCanais = new GroupBox();
            lblCanal = new Label();
            btnAumentaCanal = new Button();
            groupBoxVolume = new GroupBox();
            progressBarVolume = new ProgressBar();
            btnAumentaVolume = new Button();
            btnDiminuiVolume = new Button();
            menuStrip1 = new MenuStrip();
            novaBoxToolStripMenuItem = new ToolStripMenuItem();
            btnDiminuiCanal = new Button();
            groupBoxCanais.SuspendLayout();
            groupBoxVolume.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDiminuiCanal
            // 
            btnDiminuiCanal.Location = new Point(25, 78);
            btnDiminuiCanal.Name = "btnDiminuiCanal";
            btnDiminuiCanal.Size = new Size(94, 58);
            btnDiminuiCanal.TabIndex = 0;
            btnDiminuiCanal.Text = "-";
            btnDiminuiCanal.UseVisualStyleBackColor = true;
            btnDiminuiCanal.Click += btnDiminuiCanal_Click;
            // 
            // btnOnOff
            // 
            btnOnOff.Enabled = false;
            btnOnOff.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOnOff.Location = new Point(623, 321);
            btnOnOff.Name = "btnOnOff";
            btnOnOff.Size = new Size(103, 53);
            btnOnOff.TabIndex = 0;
            btnOnOff.Text = "Ligar";
            btnOnOff.UseVisualStyleBackColor = true;
            btnOnOff.Click += btnOnOff_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(63, 336);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(276, 25);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Não existem nenhuma box criada";
            // 
            // groupBoxCanais
            // 
            groupBoxCanais.Controls.Add(lblCanal);
            groupBoxCanais.Controls.Add(btnAumentaCanal);
            groupBoxCanais.Controls.Add(btnDiminuiCanal);
            groupBoxCanais.Enabled = false;
            groupBoxCanais.Location = new Point(384, 57);
            groupBoxCanais.Name = "groupBoxCanais";
            groupBoxCanais.Size = new Size(343, 172);
            groupBoxCanais.TabIndex = 2;
            groupBoxCanais.TabStop = false;
            groupBoxCanais.Text = "Canais";
            // 
            // lblCanal
            // 
            lblCanal.AutoSize = true;
            lblCanal.Location = new Point(164, 95);
            lblCanal.Name = "lblCanal";
            lblCanal.Size = new Size(19, 25);
            lblCanal.TabIndex = 2;
            lblCanal.Text = "-";
            // 
            // btnAumentaCanal
            // 
            btnAumentaCanal.Location = new Point(239, 78);
            btnAumentaCanal.Name = "btnAumentaCanal";
            btnAumentaCanal.Size = new Size(94, 58);
            btnAumentaCanal.TabIndex = 1;
            btnAumentaCanal.Text = "+";
            btnAumentaCanal.UseVisualStyleBackColor = true;
            btnAumentaCanal.Click += btnAumentaVolume_Click;
            // 
            // groupBoxVolume
            // 
            groupBoxVolume.Controls.Add(progressBarVolume);
            groupBoxVolume.Controls.Add(btnAumentaVolume);
            groupBoxVolume.Controls.Add(btnDiminuiVolume);
            groupBoxVolume.Enabled = false;
            groupBoxVolume.Location = new Point(12, 57);
            groupBoxVolume.Name = "groupBoxVolume";
            groupBoxVolume.Size = new Size(342, 172);
            groupBoxVolume.TabIndex = 3;
            groupBoxVolume.TabStop = false;
            groupBoxVolume.Text = "Volume";
            // 
            // progressBarVolume
            // 
            progressBarVolume.Location = new Point(42, 126);
            progressBarVolume.Name = "progressBarVolume";
            progressBarVolume.Size = new Size(219, 29);
            progressBarVolume.TabIndex = 5;
            // 
            // btnAumentaVolume
            // 
            btnAumentaVolume.Location = new Point(201, 30);
            btnAumentaVolume.Name = "btnAumentaVolume";
            btnAumentaVolume.Size = new Size(94, 58);
            btnAumentaVolume.TabIndex = 4;
            btnAumentaVolume.Text = "+";
            btnAumentaVolume.UseVisualStyleBackColor = true;
            btnAumentaVolume.Click += btnAumentaVolume_Click_1;
            // 
            // btnDiminuiVolume
            // 
            btnDiminuiVolume.Location = new Point(6, 30);
            btnDiminuiVolume.Name = "btnDiminuiVolume";
            btnDiminuiVolume.Size = new Size(94, 58);
            btnDiminuiVolume.TabIndex = 0;
            btnDiminuiVolume.Text = "-";
            btnDiminuiVolume.UseVisualStyleBackColor = true;
            btnDiminuiVolume.Click += btnDiminuiVolume_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { novaBoxToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // novaBoxToolStripMenuItem
            // 
            novaBoxToolStripMenuItem.Name = "novaBoxToolStripMenuItem";
            novaBoxToolStripMenuItem.Size = new Size(102, 29);
            novaBoxToolStripMenuItem.Text = "Nova Box";
            novaBoxToolStripMenuItem.Click += novaBoxToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxVolume);
            Controls.Add(groupBoxCanais);
            Controls.Add(lblInfo);
            Controls.Add(btnOnOff);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            groupBoxCanais.ResumeLayout(false);
            groupBoxCanais.PerformLayout();
            groupBoxVolume.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOnOff;
        private Label lblInfo;
        private GroupBox groupBoxCanais;
        private Label lblCanal;
        private Button btnAumentaCanal;
        private Button btnDiminuiCanal;
        private GroupBox groupBoxVolume;
        private Button btnAumentaVolume;
        private Button btnDiminuiVolume;
        private ProgressBar progressBarVolume;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem novaBoxToolStripMenuItem;
    }
}
