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
            this.lbl_RPotencia = new System.Windows.Forms.Label();
            this.lbl_RLlantas = new System.Windows.Forms.Label();
            this.lbl_RPuertas = new System.Windows.Forms.Label();
            this.lbl_Potencia = new System.Windows.Forms.Label();
            this.lbl_Llantas = new System.Windows.Forms.Label();
            this.lbl_Puertas = new System.Windows.Forms.Label();
            this.btn_FabricarAuto = new System.Windows.Forms.Button();
            this.cbx_AConv = new System.Windows.Forms.CheckBox();
            this.cbx_ALuj = new System.Windows.Forms.CheckBox();
            this.cbx_AFor1 = new System.Windows.Forms.CheckBox();
            this.pnl_PanleBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_PanleBack
            // 
            this.pnl_PanleBack.Controls.Add(this.cbx_AFor1);
            this.pnl_PanleBack.Controls.Add(this.cbx_ALuj);
            this.pnl_PanleBack.Controls.Add(this.cbx_AConv);
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
            this.pnl_PanleBack.Size = new System.Drawing.Size(339, 297);
            this.pnl_PanleBack.TabIndex = 0;
            // 
            // lbl_RPotencia
            // 
            this.lbl_RPotencia.AutoSize = true;
            this.lbl_RPotencia.Location = new System.Drawing.Point(241, 201);
            this.lbl_RPotencia.Name = "lbl_RPotencia";
            this.lbl_RPotencia.Size = new System.Drawing.Size(58, 13);
            this.lbl_RPotencia.TabIndex = 7;
            this.lbl_RPotencia.Text = "Esperando";
            // 
            // lbl_RLlantas
            // 
            this.lbl_RLlantas.AutoSize = true;
            this.lbl_RLlantas.Location = new System.Drawing.Point(132, 201);
            this.lbl_RLlantas.Name = "lbl_RLlantas";
            this.lbl_RLlantas.Size = new System.Drawing.Size(58, 13);
            this.lbl_RLlantas.TabIndex = 6;
            this.lbl_RLlantas.Text = "Esperando";
            // 
            // lbl_RPuertas
            // 
            this.lbl_RPuertas.AutoSize = true;
            this.lbl_RPuertas.Location = new System.Drawing.Point(29, 201);
            this.lbl_RPuertas.Name = "lbl_RPuertas";
            this.lbl_RPuertas.Size = new System.Drawing.Size(58, 13);
            this.lbl_RPuertas.TabIndex = 5;
            this.lbl_RPuertas.Text = "Esperando";
            // 
            // lbl_Potencia
            // 
            this.lbl_Potencia.AutoSize = true;
            this.lbl_Potencia.Location = new System.Drawing.Point(241, 157);
            this.lbl_Potencia.Name = "lbl_Potencia";
            this.lbl_Potencia.Size = new System.Drawing.Size(49, 13);
            this.lbl_Potencia.TabIndex = 4;
            this.lbl_Potencia.Text = "Potencia";
            // 
            // lbl_Llantas
            // 
            this.lbl_Llantas.AutoSize = true;
            this.lbl_Llantas.Location = new System.Drawing.Point(132, 157);
            this.lbl_Llantas.Name = "lbl_Llantas";
            this.lbl_Llantas.Size = new System.Drawing.Size(41, 13);
            this.lbl_Llantas.TabIndex = 3;
            this.lbl_Llantas.Text = "Llantas";
            // 
            // lbl_Puertas
            // 
            this.lbl_Puertas.AutoSize = true;
            this.lbl_Puertas.Location = new System.Drawing.Point(29, 157);
            this.lbl_Puertas.Name = "lbl_Puertas";
            this.lbl_Puertas.Size = new System.Drawing.Size(98, 13);
            this.lbl_Puertas.TabIndex = 2;
            this.lbl_Puertas.Text = "Numero de Puertas";
            // 
            // btn_FabricarAuto
            // 
            this.btn_FabricarAuto.Location = new System.Drawing.Point(107, 88);
            this.btn_FabricarAuto.Name = "btn_FabricarAuto";
            this.btn_FabricarAuto.Size = new System.Drawing.Size(121, 23);
            this.btn_FabricarAuto.TabIndex = 1;
            this.btn_FabricarAuto.Text = "Fabricar Auto";
            this.btn_FabricarAuto.UseVisualStyleBackColor = true;
            this.btn_FabricarAuto.Click += new System.EventHandler(this.btn_FabricarAuto_Click);
            // 
            // cbx_AConv
            // 
            this.cbx_AConv.AutoSize = true;
            this.cbx_AConv.Location = new System.Drawing.Point(12, 34);
            this.cbx_AConv.Name = "cbx_AConv";
            this.cbx_AConv.Size = new System.Drawing.Size(116, 17);
            this.cbx_AConv.TabIndex = 8;
            this.cbx_AConv.Text = "Auto Convencional";
            this.cbx_AConv.UseVisualStyleBackColor = true;
            // 
            // cbx_ALuj
            // 
            this.cbx_ALuj.AutoSize = true;
            this.cbx_ALuj.Location = new System.Drawing.Point(135, 34);
            this.cbx_ALuj.Name = "cbx_ALuj";
            this.cbx_ALuj.Size = new System.Drawing.Size(89, 17);
            this.cbx_ALuj.TabIndex = 9;
            this.cbx_ALuj.Text = "Auto  de Lujo";
            this.cbx_ALuj.UseVisualStyleBackColor = true;
            // 
            // cbx_AFor1
            // 
            this.cbx_AFor1.AutoSize = true;
            this.cbx_AFor1.Location = new System.Drawing.Point(229, 34);
            this.cbx_AFor1.Name = "cbx_AFor1";
            this.cbx_AFor1.Size = new System.Drawing.Size(94, 17);
            this.cbx_AFor1.TabIndex = 10;
            this.cbx_AFor1.Text = "Auto Formula1";
            this.cbx_AFor1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 297);
            this.Controls.Add(this.pnl_PanleBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_PanleBack.ResumeLayout(false);
            this.pnl_PanleBack.PerformLayout();
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
        private System.Windows.Forms.CheckBox cbx_AFor1;
        private System.Windows.Forms.CheckBox cbx_ALuj;
        private System.Windows.Forms.CheckBox cbx_AConv;
    }
}

