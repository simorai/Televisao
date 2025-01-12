namespace TelevisaoForms
{
    partial class frmNovaBox
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
            label1 = new Label();
            numericUpDownCanais = new NumericUpDown();
            btnOK = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCanais).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 124);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "Numero De Canais";
            // 
            // numericUpDownCanais
            // 
            numericUpDownCanais.Location = new Point(332, 124);
            numericUpDownCanais.Name = "numericUpDownCanais";
            numericUpDownCanais.Size = new Size(150, 31);
            numericUpDownCanais.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(675, 320);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 53);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(560, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 53);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cançelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmNovaBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(numericUpDownCanais);
            Controls.Add(label1);
            Name = "frmNovaBox";
            Text = "Nova Box";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCanais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownCanais;
        private Button btnOK;
        private Button btnCancelar;
    }
}