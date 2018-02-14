namespace NavegadorWebAbas
{
    partial class FormNavegador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavegador));
            this.btnRetorna = new System.Windows.Forms.Button();
            this.btnAvanca = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnNovaGuia = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timerFechar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRetorna
            // 
            this.btnRetorna.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRetorna.Image = ((System.Drawing.Image)(resources.GetObject("btnRetorna.Image")));
            this.btnRetorna.Location = new System.Drawing.Point(3, 1);
            this.btnRetorna.Name = "btnRetorna";
            this.btnRetorna.Size = new System.Drawing.Size(39, 28);
            this.btnRetorna.TabIndex = 0;
            this.btnRetorna.UseVisualStyleBackColor = false;
            this.btnRetorna.Click += new System.EventHandler(this.btnRetorna_Click);
            // 
            // btnAvanca
            // 
            this.btnAvanca.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAvanca.Image = ((System.Drawing.Image)(resources.GetObject("btnAvanca.Image")));
            this.btnAvanca.Location = new System.Drawing.Point(45, 1);
            this.btnAvanca.Name = "btnAvanca";
            this.btnAvanca.Size = new System.Drawing.Size(39, 28);
            this.btnAvanca.TabIndex = 0;
            this.btnAvanca.UseVisualStyleBackColor = false;
            this.btnAvanca.Click += new System.EventHandler(this.btnAvanca_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(87, 1);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(798, 26);
            this.txtUrl.TabIndex = 1;
            // 
            // btnIr
            // 
            this.btnIr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIr.Location = new System.Drawing.Point(891, 0);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(45, 28);
            this.btnIr.TabIndex = 0;
            this.btnIr.Text = "IR";
            this.btnIr.UseVisualStyleBackColor = false;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // btnNovaGuia
            // 
            this.btnNovaGuia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaGuia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovaGuia.Location = new System.Drawing.Point(942, 1);
            this.btnNovaGuia.Name = "btnNovaGuia";
            this.btnNovaGuia.Size = new System.Drawing.Size(71, 28);
            this.btnNovaGuia.TabIndex = 0;
            this.btnNovaGuia.Text = "Nova Guia";
            this.btnNovaGuia.UseVisualStyleBackColor = false;
            this.btnNovaGuia.Click += new System.EventHandler(this.btnNovaGuia_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Location = new System.Drawing.Point(3, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 703);
            this.tabControl1.TabIndex = 2;
            // 
            // timerFechar
            // 
            this.timerFechar.Interval = 10000;
            this.timerFechar.Tick += new System.EventHandler(this.timerFechar_Tick);
            // 
            // FormNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 737);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnNovaGuia);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.btnAvanca);
            this.Controls.Add(this.btnRetorna);
            this.Name = "FormNavegador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NavegadorWeb Integrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetorna;
        private System.Windows.Forms.Button btnAvanca;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnNovaGuia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Timer timerFechar;
    }
}

