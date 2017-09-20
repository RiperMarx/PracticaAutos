namespace PracticaAutos
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
            this.pnl_PanleBack = new System.Windows.Forms.Panel();
            this.gbx_Radiobtn = new System.Windows.Forms.GroupBox();
            this.rdb_Moto = new System.Windows.Forms.RadioButton();
            this.rdb_AFor1 = new System.Windows.Forms.RadioButton();
            this.rdb_ALujo = new System.Windows.Forms.RadioButton();
            this.rdb_AConv = new System.Windows.Forms.RadioButton();
            this.lbl_RPotencia = new System.Windows.Forms.Label();
            this.lbl_RLlantas = new System.Windows.Forms.Label();
            this.lbl_RPuertas = new System.Windows.Forms.Label();
            this.lbl_Potencia = new System.Windows.Forms.Label();
            this.lbl_Llantas = new System.Windows.Forms.Label();
            this.lbl_Puertas = new System.Windows.Forms.Label();
            this.btn_FabricarAuto = new System.Windows.Forms.Button();
            this.pnl_PanleBack.SuspendLayout();
            this.gbx_Radiobtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_PanleBack
            // 
            this.pnl_PanleBack.Controls.Add(this.gbx_Radiobtn);
            this.pnl_PanleBack.Controls.Add(this.lbl_RPotencia);
            this.pnl_PanleBack.Controls.Add(this.lbl_RLlantas);
            this.pnl_PanleBack.Controls.Add(this.lbl_RPuertas);
            this.pnl_PanleBack.Controls.Add(this.lbl_Potencia);
            this.pnl_PanleBack.Controls.Add(this.lbl_Llantas);
            this.pnl_PanleBack.Controls.Add(this.lbl_Puertas);
            this.pnl_PanleBack.Controls.Add(this.btn_FabricarAuto);
            this.pnl_PanleBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PanleBack.Location = new System.Drawing.Point(0, 0);
            this.pnl_PanleBack.Name = "pnl_PanleBack";
            this.pnl_PanleBack.Size = new System.Drawing.Size(501, 439);
            this.pnl_PanleBack.TabIndex = 0;
            // 
            // gbx_Radiobtn
            // 
            this.gbx_Radiobtn.Controls.Add(this.rdb_Moto);
            this.gbx_Radiobtn.Controls.Add(this.rdb_AFor1);
            this.gbx_Radiobtn.Controls.Add(this.rdb_ALujo);
            this.gbx_Radiobtn.Controls.Add(this.rdb_AConv);
            this.gbx_Radiobtn.Location = new System.Drawing.Point(12, 39);
            this.gbx_Radiobtn.Name = "gbx_Radiobtn";
            this.gbx_Radiobtn.Size = new System.Drawing.Size(475, 77);
            this.gbx_Radiobtn.TabIndex = 11;
            this.gbx_Radiobtn.TabStop = false;
            // 
            // rdb_Moto
            // 
            this.rdb_Moto.AutoSize = true;
            this.rdb_Moto.Location = new System.Drawing.Point(343, 33);
            this.rdb_Moto.Name = "rdb_Moto";
            this.rdb_Moto.Size = new System.Drawing.Size(80, 17);
            this.rdb_Moto.TabIndex = 3;
            this.rdb_Moto.TabStop = true;
            this.rdb_Moto.Text = "Motocicleta";
            this.rdb_Moto.UseVisualStyleBackColor = true;
            // 
            // rdb_AFor1
            // 
            this.rdb_AFor1.AutoSize = true;
            this.rdb_AFor1.Location = new System.Drawing.Point(231, 33);
            this.rdb_AFor1.Name = "rdb_AFor1";
            this.rdb_AFor1.Size = new System.Drawing.Size(93, 17);
            this.rdb_AFor1.TabIndex = 2;
            this.rdb_AFor1.TabStop = true;
            this.rdb_AFor1.Text = "Auto Formula1";
            this.rdb_AFor1.UseVisualStyleBackColor = true;
            // 
            // rdb_ALujo
            // 
            this.rdb_ALujo.AutoSize = true;
            this.rdb_ALujo.Location = new System.Drawing.Point(135, 33);
            this.rdb_ALujo.Name = "rdb_ALujo";
            this.rdb_ALujo.Size = new System.Drawing.Size(85, 17);
            this.rdb_ALujo.TabIndex = 1;
            this.rdb_ALujo.TabStop = true;
            this.rdb_ALujo.Text = "Auto de Lujo";
            this.rdb_ALujo.UseVisualStyleBackColor = true;
            // 
            // rdb_AConv
            // 
            this.rdb_AConv.AutoSize = true;
            this.rdb_AConv.Location = new System.Drawing.Point(6, 33);
            this.rdb_AConv.Name = "rdb_AConv";
            this.rdb_AConv.Size = new System.Drawing.Size(115, 17);
            this.rdb_AConv.TabIndex = 0;
            this.rdb_AConv.TabStop = true;
            this.rdb_AConv.Text = "Auto Convencional";
            this.rdb_AConv.UseVisualStyleBackColor = true;
            // 
            // lbl_RPotencia
            // 
            this.lbl_RPotencia.AutoSize = true;
            this.lbl_RPotencia.Location = new System.Drawing.Point(314, 321);
            this.lbl_RPotencia.Name = "lbl_RPotencia";
            this.lbl_RPotencia.Size = new System.Drawing.Size(58, 13);
            this.lbl_RPotencia.TabIndex = 7;
            this.lbl_RPotencia.Text = "Esperando";
            // 
            // lbl_RLlantas
            // 
            this.lbl_RLlantas.AutoSize = true;
            this.lbl_RLlantas.Location = new System.Drawing.Point(205, 321);
            this.lbl_RLlantas.Name = "lbl_RLlantas";
            this.lbl_RLlantas.Size = new System.Drawing.Size(58, 13);
            this.lbl_RLlantas.TabIndex = 6;
            this.lbl_RLlantas.Text = "Esperando";
            // 
            // lbl_RPuertas
            // 
            this.lbl_RPuertas.AutoSize = true;
            this.lbl_RPuertas.Location = new System.Drawing.Point(102, 321);
            this.lbl_RPuertas.Name = "lbl_RPuertas";
            this.lbl_RPuertas.Size = new System.Drawing.Size(58, 13);
            this.lbl_RPuertas.TabIndex = 5;
            this.lbl_RPuertas.Text = "Esperando";
            // 
            // lbl_Potencia
            // 
            this.lbl_Potencia.AutoSize = true;
            this.lbl_Potencia.Location = new System.Drawing.Point(314, 277);
            this.lbl_Potencia.Name = "lbl_Potencia";
            this.lbl_Potencia.Size = new System.Drawing.Size(49, 13);
            this.lbl_Potencia.TabIndex = 4;
            this.lbl_Potencia.Text = "Potencia";
            // 
            // lbl_Llantas
            // 
            this.lbl_Llantas.AutoSize = true;
            this.lbl_Llantas.Location = new System.Drawing.Point(205, 277);
            this.lbl_Llantas.Name = "lbl_Llantas";
            this.lbl_Llantas.Size = new System.Drawing.Size(41, 13);
            this.lbl_Llantas.TabIndex = 3;
            this.lbl_Llantas.Text = "Llantas";
            // 
            // lbl_Puertas
            // 
            this.lbl_Puertas.AutoSize = true;
            this.lbl_Puertas.Location = new System.Drawing.Point(102, 277);
            this.lbl_Puertas.Name = "lbl_Puertas";
            this.lbl_Puertas.Size = new System.Drawing.Size(98, 13);
            this.lbl_Puertas.TabIndex = 2;
            this.lbl_Puertas.Text = "Numero de Puertas";
            // 
            // btn_FabricarAuto
            // 
            this.btn_FabricarAuto.Location = new System.Drawing.Point(159, 140);
            this.btn_FabricarAuto.Name = "btn_FabricarAuto";
            this.btn_FabricarAuto.Size = new System.Drawing.Size(152, 56);
            this.btn_FabricarAuto.TabIndex = 1;
            this.btn_FabricarAuto.Text = "Fabricar Auto";
            this.btn_FabricarAuto.UseVisualStyleBackColor = true;
            this.btn_FabricarAuto.Click += new System.EventHandler(this.btn_FabricarAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 439);
            this.Controls.Add(this.pnl_PanleBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_PanleBack.ResumeLayout(false);
            this.pnl_PanleBack.PerformLayout();
            this.gbx_Radiobtn.ResumeLayout(false);
            this.gbx_Radiobtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_PanleBack;
        private System.Windows.Forms.Button btn_FabricarAuto;
        private System.Windows.Forms.Label lbl_Potencia;
        private System.Windows.Forms.Label lbl_Llantas;
        private System.Windows.Forms.Label lbl_Puertas;
        public System.Windows.Forms.Label lbl_RPuertas;
        public System.Windows.Forms.Label lbl_RPotencia;
        public System.Windows.Forms.Label lbl_RLlantas;
        private System.Windows.Forms.GroupBox gbx_Radiobtn;
        private System.Windows.Forms.RadioButton rdb_Moto;
        private System.Windows.Forms.RadioButton rdb_AFor1;
        private System.Windows.Forms.RadioButton rdb_ALujo;
        private System.Windows.Forms.RadioButton rdb_AConv;
    }
}

