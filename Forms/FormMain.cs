using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursedapp
{
    public partial class FormMain : Form
    {
        int count = 0;
        DataTable dt = new DataTable();

        public FormMain()
        {
            InitializeComponent();
        }
        private void AddVertexes(DataTable dt)
        {
            count++; 
            dt.Columns.Add($"{count}", typeof(string));
            dt.Rows.Add();
            dataGridVertexes.Rows[count-1].Cells[count-1].Value = 0;
            dataGridVertexes.Rows[count - 1].Cells[count - 1].ReadOnly = true;
            
        }
        private void RemoveVertexes(DataTable dt) 
        {
            if (count > 0)
            {
                dt.Columns.Remove($"{count}");
                dt.Rows.RemoveAt(count - 1);
                count--;
            }
            else
            {
                MessageBox.Show("Матрица пуста");
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridVertexes.AllowUserToAddRows = false;
            dataGridVertexes.DataSource = dt;
            AddVertexes(dt);
            AddVertexes(dt);
        }

        private void addVertexButton_Click(object sender, EventArgs e)
        {
            AddVertexes(dt);
        }

        private void deleteCityButton_Click(object sender, EventArgs e)
        {
            RemoveVertexes(dt);
        }

        private void dataGridVertexes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var col = e.ColumnIndex;
            var row = e.RowIndex;
            var type = dataGridVertexes.Rows[row].Cells[col].Value.ToString();
            bool isNumber = double.TryParse(type, out double number);
            if (isNumber & number > 0 | type == "")
            {
                if (col != row)
                    dataGridVertexes.Rows[col].Cells[row].Value = dataGridVertexes.Rows[row].Cells[col].Value;
                else
                    dataGridVertexes.Rows[col].Cells[row].Value = 0;
            }
            else
            { 
                MessageBox.Show("Допускается вводить только положительные численные значения");
                dataGridVertexes.Rows[row].Cells[col].Value = "";
            }
        }
    }
}
