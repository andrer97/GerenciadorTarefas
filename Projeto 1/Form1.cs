namespace Projeto_1
{
    public partial class Tarefas : Form
    {

        public Tarefas()
        {
            InitializeComponent();
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            string tarefa = txtTarefa.Text;
            DateOnly data = DateOnly.FromDateTime(datePickerDataVencimento.Value);
            string descricao = txtDescricao.Text;

            if (string.IsNullOrEmpty(tarefa))
            {
                MessageBox.Show("Preencha o campo Tarefa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTarefa.Focus();
                return;
            }
            if (string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Preencha o campo Descrição!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescricao.Focus();
                return;
            }

            dataGridView1.Rows.Add(tarefa, descricao, data);

            txtTarefa.Clear();
            txtDescricao.Clear();
            txtTarefa.Focus();

            botaoAtualizar_Click(sender, e);
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }

            botaoAtualizar_Click(sender, e);
        }
        
        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            int tarefasAtrasadas = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((DateOnly)dataGridView1.Rows[i].Cells[2].Value < DateOnly.FromDateTime(DateTime.Now))
                {
                    tarefasAtrasadas++;
                }
            }
            txtTarefasAtrasadas.Text = tarefasAtrasadas.ToString();
        }
    }
}
