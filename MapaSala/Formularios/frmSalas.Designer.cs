
namespace MapaSala.Formularios
{
    partial class frmSalas
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.llll = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsLab = new System.Windows.Forms.CheckBox();
            this.chkDisponivel = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtGridSalas = new System.Windows.Forms.DataGridView();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.wedfwsdf = new System.Windows.Forms.Label();
            this.txtNumPc = new System.Windows.Forms.TextBox();
            this.txtNumCadeira = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNome.Location = new System.Drawing.Point(82, 55);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(117, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da sala";
            // 
            // llll
            // 
            this.llll.AutoSize = true;
            this.llll.Location = new System.Drawing.Point(385, 33);
            this.llll.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.llll.Name = "llll";
            this.llll.Size = new System.Drawing.Size(138, 17);
            this.llll.TabIndex = 5;
            this.llll.Text = "Numero de Cadeiras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id";
            // 
            // chkIsLab
            // 
            this.chkIsLab.AutoSize = true;
            this.chkIsLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkIsLab.Location = new System.Drawing.Point(571, 56);
            this.chkIsLab.Margin = new System.Windows.Forms.Padding(5);
            this.chkIsLab.Name = "chkIsLab";
            this.chkIsLab.Size = new System.Drawing.Size(108, 21);
            this.chkIsLab.TabIndex = 8;
            this.chkIsLab.Text = "É laboratório";
            this.chkIsLab.UseVisualStyleBackColor = false;
            // 
            // chkDisponivel
            // 
            this.chkDisponivel.AutoSize = true;
            this.chkDisponivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chkDisponivel.Location = new System.Drawing.Point(571, 90);
            this.chkDisponivel.Margin = new System.Windows.Forms.Padding(5);
            this.chkDisponivel.Name = "chkDisponivel";
            this.chkDisponivel.Size = new System.Drawing.Size(92, 21);
            this.chkDisponivel.TabIndex = 9;
            this.chkDisponivel.Text = "Disponível";
            this.chkDisponivel.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(706, 49);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 31);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtGridSalas
            // 
            this.dtGridSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridSalas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtGridSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridSalas.Location = new System.Drawing.Point(18, 217);
            this.dtGridSalas.Margin = new System.Windows.Forms.Padding(5);
            this.dtGridSalas.Name = "dtGridSalas";
            this.dtGridSalas.RowHeadersWidth = 51;
            this.dtGridSalas.Size = new System.Drawing.Size(951, 257);
            this.dtGridSalas.TabIndex = 13;
            this.dtGridSalas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridSalas_CellClick);
            // 
            // numId
            // 
            this.numId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numId.Location = new System.Drawing.Point(19, 53);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(43, 23);
            this.numId.TabIndex = 14;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btneditar.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(849, 50);
            this.btneditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(120, 32);
            this.btneditar.TabIndex = 17;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnexcluir.Location = new System.Drawing.Point(851, 93);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(120, 29);
            this.btnexcluir.TabIndex = 16;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpar.Location = new System.Drawing.Point(706, 90);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 32);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(31, 139);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(71, 17);
            this.lblPesquisa.TabIndex = 18;
            this.lblPesquisa.Text = "Pesquisar";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPesquisa.Location = new System.Drawing.Point(34, 159);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(341, 23);
            this.txtPesquisa.TabIndex = 19;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // wedfwsdf
            // 
            this.wedfwsdf.AutoSize = true;
            this.wedfwsdf.Location = new System.Drawing.Point(201, 28);
            this.wedfwsdf.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.wedfwsdf.Name = "wedfwsdf";
            this.wedfwsdf.Size = new System.Drawing.Size(174, 17);
            this.wedfwsdf.TabIndex = 4;
            this.wedfwsdf.Text = "Numero de Computadores";
            this.wedfwsdf.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumPc
            // 
            this.txtNumPc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNumPc.Location = new System.Drawing.Point(232, 57);
            this.txtNumPc.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumPc.Name = "txtNumPc";
            this.txtNumPc.Size = new System.Drawing.Size(117, 23);
            this.txtNumPc.TabIndex = 22;
            // 
            // txtNumCadeira
            // 
            this.txtNumCadeira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNumCadeira.Location = new System.Drawing.Point(388, 59);
            this.txtNumCadeira.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumCadeira.Name = "txtNumCadeira";
            this.txtNumCadeira.Size = new System.Drawing.Size(117, 23);
            this.txtNumCadeira.TabIndex = 23;
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(983, 488);
            this.Controls.Add(this.txtNumCadeira);
            this.Controls.Add(this.txtNumPc);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.dtGridSalas);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkDisponivel);
            this.Controls.Add(this.chkIsLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.llll);
            this.Controls.Add(this.wedfwsdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalas";
            this.Load += new System.EventHandler(this.frmSalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label llll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsLab;
        private System.Windows.Forms.CheckBox chkDisponivel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtGridSalas;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label wedfwsdf;
        private System.Windows.Forms.TextBox txtNumPc;
        private System.Windows.Forms.TextBox txtNumCadeira;
    }
}