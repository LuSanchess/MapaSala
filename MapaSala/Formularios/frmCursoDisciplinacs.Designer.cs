﻿
namespace MapaSala.Formularios
{
    partial class frmCursoDisciplinacs
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
            this.Disciplinas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxCursos = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dtCursoDisciplina = new System.Windows.Forms.DataGridView();
            this.CbxDisciplinas = new System.Windows.Forms.ComboBox();
            this.CbxPeriodos = new System.Windows.Forms.ComboBox();
            this.TxtPeriodo = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCursoDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // Disciplinas
            // 
            this.Disciplinas.AutoSize = true;
            this.Disciplinas.Location = new System.Drawing.Point(25, 36);
            this.Disciplinas.Name = "Disciplinas";
            this.Disciplinas.Size = new System.Drawing.Size(57, 13);
            this.Disciplinas.TabIndex = 2;
            this.Disciplinas.Text = "Disciplinas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso";
            // 
            // CbxCursos
            // 
            this.CbxCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CbxCursos.FormattingEnabled = true;
            this.CbxCursos.Location = new System.Drawing.Point(183, 65);
            this.CbxCursos.Name = "CbxCursos";
            this.CbxCursos.Size = new System.Drawing.Size(121, 21);
            this.CbxCursos.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionar.Location = new System.Drawing.Point(495, 63);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dtCursoDisciplina
            // 
            this.dtCursoDisciplina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtCursoDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCursoDisciplina.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtCursoDisciplina.Location = new System.Drawing.Point(28, 174);
            this.dtCursoDisciplina.Name = "dtCursoDisciplina";
            this.dtCursoDisciplina.Size = new System.Drawing.Size(542, 264);
            this.dtCursoDisciplina.TabIndex = 6;
            this.dtCursoDisciplina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCursoDisciplina_CellContentClick);
            // 
            // CbxDisciplinas
            // 
            this.CbxDisciplinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CbxDisciplinas.FormattingEnabled = true;
            this.CbxDisciplinas.Location = new System.Drawing.Point(28, 63);
            this.CbxDisciplinas.Name = "CbxDisciplinas";
            this.CbxDisciplinas.Size = new System.Drawing.Size(121, 21);
            this.CbxDisciplinas.TabIndex = 7;
            // 
            // CbxPeriodos
            // 
            this.CbxPeriodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CbxPeriodos.FormattingEnabled = true;
            this.CbxPeriodos.Items.AddRange(new object[] {
            "1°Ano",
            "2°Ano",
            "3°Ano",
            "1°Modulo",
            "2°Modulo",
            "3°Modulo"});
            this.CbxPeriodos.Location = new System.Drawing.Point(344, 65);
            this.CbxPeriodos.Name = "CbxPeriodos";
            this.CbxPeriodos.Size = new System.Drawing.Size(121, 21);
            this.CbxPeriodos.TabIndex = 8;
            // 
            // TxtPeriodo
            // 
            this.TxtPeriodo.AutoSize = true;
            this.TxtPeriodo.Location = new System.Drawing.Point(341, 36);
            this.TxtPeriodo.Name = "TxtPeriodo";
            this.TxtPeriodo.Size = new System.Drawing.Size(43, 13);
            this.TxtPeriodo.TabIndex = 9;
            this.TxtPeriodo.Text = "Periodo";
            this.TxtPeriodo.Click += new System.EventHandler(this.TxtPeriodo_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPesquisa.Location = new System.Drawing.Point(28, 134);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(209, 20);
            this.txtPesquisa.TabIndex = 10;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(25, 118);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 11;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // frmCursoDisciplinacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.TxtPeriodo);
            this.Controls.Add(this.CbxPeriodos);
            this.Controls.Add(this.CbxDisciplinas);
            this.Controls.Add(this.dtCursoDisciplina);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.CbxCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Disciplinas);
            this.Name = "frmCursoDisciplinacs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCursoDisciplinacs";
            this.Load += new System.EventHandler(this.frmCursoDisciplinacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCursoDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Disciplinas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxCursos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dtCursoDisciplina;
        private System.Windows.Forms.ComboBox CbxDisciplinas;
        private System.Windows.Forms.ComboBox CbxPeriodos;
        private System.Windows.Forms.Label TxtPeriodo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
    }
}