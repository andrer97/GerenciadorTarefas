namespace Projeto_1
{
    partial class Tarefas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            botaoAtualizar = new Button();
            label4 = new Label();
            txtTarefasAtrasadas = new TextBox();
            panel3 = new Panel();
            datePickerDataVencimento = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTarefa = new TextBox();
            txtDescricao = new TextBox();
            botaoRemover = new Button();
            botaoAdicionar = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(botaoAtualizar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTarefasAtrasadas);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 454);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // botaoAtualizar
            // 
            botaoAtualizar.Location = new Point(508, 61);
            botaoAtualizar.Name = "botaoAtualizar";
            botaoAtualizar.Size = new Size(94, 29);
            botaoAtualizar.TabIndex = 2;
            botaoAtualizar.Text = "Atualizar";
            botaoAtualizar.UseVisualStyleBackColor = true;
            botaoAtualizar.Click += botaoAtualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(628, 38);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 1;
            label4.Text = "Tarefas Atrasadas";
            // 
            // txtTarefasAtrasadas
            // 
            txtTarefasAtrasadas.Enabled = false;
            txtTarefasAtrasadas.Location = new Point(628, 61);
            txtTarefasAtrasadas.Name = "txtTarefasAtrasadas";
            txtTarefasAtrasadas.ReadOnly = true;
            txtTarefasAtrasadas.Size = new Size(125, 27);
            txtTarefasAtrasadas.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(datePickerDataVencimento);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtTarefa);
            panel3.Controls.Add(txtDescricao);
            panel3.Controls.Add(botaoRemover);
            panel3.Controls.Add(botaoAdicionar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 125);
            panel3.TabIndex = 2;
            // 
            // datePickerDataVencimento
            // 
            datePickerDataVencimento.Format = DateTimePickerFormat.Short;
            datePickerDataVencimento.Location = new Point(12, 88);
            datePickerDataVencimento.Name = "datePickerDataVencimento";
            datePickerDataVencimento.Size = new Size(131, 27);
            datePickerDataVencimento.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 7;
            label3.Text = "Data de Vencimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 6);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 6;
            label2.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Tarefa";
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(12, 29);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(125, 27);
            txtTarefa.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(162, 29);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(501, 86);
            txtDescricao.TabIndex = 2;
            // 
            // botaoRemover
            // 
            botaoRemover.Location = new Point(686, 73);
            botaoRemover.Name = "botaoRemover";
            botaoRemover.Size = new Size(94, 29);
            botaoRemover.TabIndex = 1;
            botaoRemover.Text = "Remover";
            botaoRemover.UseVisualStyleBackColor = true;
            botaoRemover.Click += botaoRemover_Click;
            // 
            // botaoAdicionar
            // 
            botaoAdicionar.Location = new Point(686, 25);
            botaoAdicionar.Name = "botaoAdicionar";
            botaoAdicionar.Size = new Size(94, 29);
            botaoAdicionar.TabIndex = 0;
            botaoAdicionar.Text = "Adicionar";
            botaoAdicionar.UseVisualStyleBackColor = true;
            botaoAdicionar.Click += botaoAdicionar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 329);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 329);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome da Tarefa";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descrição da Tarefa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 450;
            // 
            // Column3
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            Column3.DefaultCellStyle = dataGridViewCellStyle1;
            Column3.HeaderText = "Data de Vencimento";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Tarefas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Tarefas";
            Text = "Tarefas Pendentes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox txtTarefasAtrasadas;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTarefa;
        private TextBox txtDescricao;
        private Button botaoRemover;
        private Button botaoAdicionar;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DateTimePicker datePickerDataVencimento;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button botaoAtualizar;
    }
}
