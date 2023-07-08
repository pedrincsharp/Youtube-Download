namespace YB.DownloadVideos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            cmbFormato = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            txtTitulo = new TextBox();
            label1 = new Label();
            txtDescricao = new RichTextBox();
            thumb = new PictureBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            status = new ToolStripStatusLabel();
            txtDir = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)thumb).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(713, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(632, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(12, 12);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "URL completa do video";
            txtPesquisa.Size = new Size(614, 23);
            txtPesquisa.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(cmbFormato);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(thumb);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 397);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações do video";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(6, 339);
            button2.Name = "button2";
            button2.Size = new Size(360, 52);
            button2.TabIndex = 9;
            button2.Text = "Download";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbFormato
            // 
            cmbFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormato.FormattingEnabled = true;
            cmbFormato.Items.AddRange(new object[] { "MP4", "MP3" });
            cmbFormato.Location = new Point(6, 267);
            cmbFormato.Name = "cmbFormato";
            cmbFormato.Size = new Size(360, 23);
            cmbFormato.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 249);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(6, 40);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(754, 23);
            txtTitulo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 80);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(6, 98);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(360, 144);
            txtDescricao.TabIndex = 1;
            txtDescricao.Text = "";
            // 
            // thumb
            // 
            thumb.BackColor = SystemColors.ActiveCaption;
            thumb.Location = new Point(372, 69);
            thumb.Name = "thumb";
            thumb.Size = new Size(388, 322);
            thumb.SizeMode = PictureBoxSizeMode.StretchImage;
            thumb.TabIndex = 0;
            thumb.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, status });
            statusStrip1.Location = new Point(0, 473);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(51, 17);
            toolStripStatusLabel1.Text = "Internet:";
            // 
            // status
            // 
            status.BackColor = Color.Red;
            status.Name = "status";
            status.Size = new Size(19, 17);
            status.Text = "    ";
            // 
            // txtDir
            // 
            txtDir.Location = new Point(12, 41);
            txtDir.Name = "txtDir";
            txtDir.PlaceholderText = "Diretório final";
            txtDir.Size = new Size(614, 23);
            txtDir.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(632, 41);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 4;
            button3.Text = "Selecionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(button3);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Controls.Add(txtDir);
            Controls.Add(txtPesquisa);
            Controls.Add(btnPesquisar);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Youtube Download";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)thumb).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private GroupBox groupBox1;
        private PictureBox thumb;
        private RichTextBox txtDescricao;
        private Label label1;
        private Label label2;
        private TextBox txtTitulo;
        private Label label4;
        private ComboBox cmbFormato;
        private Button button2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel status;
        private TextBox txtDir;
        private Button button3;
    }
}