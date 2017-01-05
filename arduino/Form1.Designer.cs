namespace arduino
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.textBoxReceber = new System.Windows.Forms.TextBox();
            this.timerCom = new System.Windows.Forms.Timer(this.components);
            this.textBoxEnviar = new System.Windows.Forms.TextBox();
            this.btConenctar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(369, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // btEnviar
            // 
            this.btEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btEnviar.Location = new System.Drawing.Point(307, 30);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 31);
            this.btEnviar.TabIndex = 2;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // textBoxReceber
            // 
            this.textBoxReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxReceber.Location = new System.Drawing.Point(13, 38);
            this.textBoxReceber.Multiline = true;
            this.textBoxReceber.Name = "textBoxReceber";
            this.textBoxReceber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceber.Size = new System.Drawing.Size(369, 137);
            this.textBoxReceber.TabIndex = 3;
            // 
            // timerCom
            // 
            this.timerCom.Enabled = true;
            this.timerCom.Interval = 1000;
            this.timerCom.Tick += new System.EventHandler(this.timerCom_Tick);
            // 
            // textBoxEnviar
            // 
            this.textBoxEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxEnviar.Location = new System.Drawing.Point(13, 34);
            this.textBoxEnviar.Name = "textBoxEnviar";
            this.textBoxEnviar.Size = new System.Drawing.Size(286, 23);
            this.textBoxEnviar.TabIndex = 4;
            // 
            // btConenctar
            // 
            this.btConenctar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btConenctar.Location = new System.Drawing.Point(267, 184);
            this.btConenctar.Name = "btConenctar";
            this.btConenctar.Size = new System.Drawing.Size(115, 37);
            this.btConenctar.TabIndex = 5;
            this.btConenctar.Text = "Conectar";
            this.btConenctar.UseVisualStyleBackColor = true;
            this.btConenctar.Click += new System.EventHandler(this.btConenctar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btEnviar);
            this.groupBox1.Controls.Add(this.textBoxEnviar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(22, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envia dados através da porta serial";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxReceber);
            this.groupBox2.Controls.Add(this.btConenctar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(22, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 232);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recebe dados através da porta serial";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(22, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 84);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecione uma porta serial";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(442, 457);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Leitor de porta serial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.TextBox textBoxReceber;
        private System.Windows.Forms.Timer timerCom;
        private System.Windows.Forms.TextBox textBoxEnviar;
        private System.Windows.Forms.Button btConenctar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

