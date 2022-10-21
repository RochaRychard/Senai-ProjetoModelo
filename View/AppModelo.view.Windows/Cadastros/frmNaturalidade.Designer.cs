namespace AppModelo.view.Windows.Cadastros
{
    partial class frmNaturalidade
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
            this.dgNaturalidade = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdNaturalidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoNaturalidade = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.btnSalvarDescricaoNaturalidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNaturalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNaturalidade
            // 
            this.dgNaturalidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgNaturalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNaturalidade.Location = new System.Drawing.Point(12, 168);
            this.dgNaturalidade.Name = "dgNaturalidade";
            this.dgNaturalidade.Size = new System.Drawing.Size(436, 150);
            this.dgNaturalidade.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 36);
            this.panel1.TabIndex = 3;
            // 
            // txtIdNaturalidade
            // 
            this.txtIdNaturalidade.Location = new System.Drawing.Point(12, 66);
            this.txtIdNaturalidade.Name = "txtIdNaturalidade";
            this.txtIdNaturalidade.Size = new System.Drawing.Size(100, 20);
            this.txtIdNaturalidade.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // txtDescricaoNaturalidade
            // 
            this.txtDescricaoNaturalidade.Location = new System.Drawing.Point(12, 124);
            this.txtDescricaoNaturalidade.Name = "txtDescricaoNaturalidade";
            this.txtDescricaoNaturalidade.Size = new System.Drawing.Size(100, 20);
            this.txtDescricaoNaturalidade.TabIndex = 7;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(163, 66);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 8;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvarDescricaoNaturalidade
            // 
            this.btnSalvarDescricaoNaturalidade.Location = new System.Drawing.Point(118, 122);
            this.btnSalvarDescricaoNaturalidade.Name = "btnSalvarDescricaoNaturalidade";
            this.btnSalvarDescricaoNaturalidade.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarDescricaoNaturalidade.TabIndex = 10;
            this.btnSalvarDescricaoNaturalidade.Text = "Salvar";
            this.btnSalvarDescricaoNaturalidade.UseVisualStyleBackColor = true;
            // 
            // Naturalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 345);
            this.Controls.Add(this.btnSalvarDescricaoNaturalidade);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.txtDescricaoNaturalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdNaturalidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgNaturalidade);
            this.Name = "Naturalidade";
            this.Text = "Naturalidade";
            ((System.ComponentModel.ISupportInitialize)(this.dgNaturalidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgNaturalidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdNaturalidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoNaturalidade;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Button btnSalvarDescricaoNaturalidade;
    }
}