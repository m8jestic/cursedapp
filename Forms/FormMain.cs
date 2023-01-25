using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursedapp
{
    public partial class FormMain : Form
    {
        Graph G;
        int count = 0;
        DataTable dt = new DataTable();
        int s1; 
        int s2;
        List<Vertex> Vertexes;
        List<Edge> Edges;
        double[,] Matrix;
        public FormMain()
        {
            InitializeComponent();
            dataGridVertexes.AllowUserToAddRows = false;
            dataGridVertexes.DataSource = dt;
            Vertexes = new List<Vertex>();
            Edges = new List<Edge>();
            G = new Graph(cloth.Width, cloth.Height);
            cloth.Image = G.GetBitmap();
        }
       
        private void AddVertexes(DataTable dt)
        {
            count++; 
            dt.Columns.Add($"{count}");
            dt.Rows.Add();
            
            dataGridVertexes.Rows[count-1].Cells[count-1].Value = 0;
            
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
            if (isNumber & number >= 0 | type == "")
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
        private bool isFilled()
        {
            var countNumbers = 0;
            for(int i = 0; i<dataGridVertexes.ColumnCount; i++)
            {
                for(int j = 0; j < dataGridVertexes.ColumnCount; j++)
                {
                    var type = dataGridVertexes.Rows[i].Cells[j].Value.GetType();
                    if (dataGridVertexes.Rows[i].Cells[j].Value == "" | type.Name.ToString() == "DBNull")
                    {
                        return false;
                    }
                    if (i != j)
                    {
                        if (Int32.Parse(dataGridVertexes.Rows[i].Cells[j].Value.ToString()) > 0)
                        {
                            countNumbers += 2;
                        }
                    }
                }
            }
            if (countNumbers > 0)
            {
                return true;
            }
            else { 
                return false; 
            }
        }
        
        private void buttonSolving_Click(object sender, EventArgs e)
        {
           
            Matrix = new double[Vertexes.Count, Vertexes.Count];
            Matrix = G.createMatrix(Vertexes.Count, Edges, Matrix, Vertexes);

        }

        private void MouseButton_Click(object sender, EventArgs e)
        {
            mouseButton.Enabled = false;
            vertexButton.Enabled = true;
            edgeButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(Vertexes, Edges);
            cloth.Image = G.GetBitmap();
            s1 = -1;
        }

        private void vertexButton_Click(object sender, EventArgs e)
        {
            vertexButton.Enabled = false;
            mouseButton.Enabled = true;
            edgeButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(Vertexes, Edges);
            cloth.Image = G.GetBitmap();
        }

        private void edgeButton_Click(object sender, EventArgs e)
        {
            edgeButton.Enabled = false;
            mouseButton.Enabled = true;
            vertexButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(Vertexes, Edges);
            cloth.Image = G.GetBitmap();
            s1 = -1;
            s2 = -1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            mouseButton.Enabled = true;
            vertexButton.Enabled = true;
            edgeButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(Vertexes, Edges);
            cloth.Image = G.GetBitmap();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            mouseButton.Enabled = true;
            vertexButton.Enabled = true;
            edgeButton.Enabled = true;
            deleteButton.Enabled = true;
            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
               
                Vertexes.Clear();
                Edges.Clear();
                G.clearSheet();
                cloth.Image = G.GetBitmap();
            }
        }
        private void cloth_Click(object sender, MouseEventArgs e)
        {
            if (vertexButton.Enabled == false)
            {
                if (Vertexes.Count < 9)
                {
                    bool flag = true;
                    for (int i = 0; i < Vertexes.Count; i++)
                    {
                        if ((e.X > Vertexes[i].x - 35) && (e.X < Vertexes[i].x + 35) && (e.Y > Vertexes[i].y - 35) && (e.Y < Vertexes[i].y + 35))
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        Vertexes.Add(new Vertex(e.X, e.Y));
                        G.drawVertex(e.X, e.Y, Vertexes.Count.ToString());
                        
                        cloth.Image = G.GetBitmap();
                       
                    }
                }
            }
            if (edgeButton.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < Vertexes.Count; i++)
                    {
                        if (Math.Pow((Vertexes[i].x - e.X), 2) + Math.Pow((Vertexes[i].y - e.Y), 2) <= G.R * G.R)
                        {
                            if (s1 == -1)
                            {
                                G.drawSelectedVertex(Vertexes[i].x, Vertexes[i].y);
                                s1 = i;
                                cloth.Image = G.GetBitmap();
                                break;
                            }
                            if (s2 == -1)
                            {
                                G.drawSelectedVertex(Vertexes[i].x, Vertexes[i].y);
                                s2 = i;
                                Edges.Add(new Edge(s1, s2));
                                G.drawEdge(Vertexes[s1], Vertexes[s2], Edges[Edges.Count - 1], Edges.Count - 1);
                                s1 = -1;
                                s2 = -1;
                                cloth.Image = G.GetBitmap();
                                
                                break;
                            }
                        }
                    }
                }
            }
            if (deleteButton.Enabled == false)
            {
                bool flag = false;
                for (int i = 0; i < Vertexes.Count; i++)
                {
                    if (Math.Pow((Vertexes[i].x - e.X), 2) + Math.Pow((Vertexes[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        for (int j = 0; j < Edges.Count; j++)
                        {
                            if ((Edges[j].From == i) || (Edges[j].To == i))
                            {
                                Edges.RemoveAt(j);
                                j--;
                            }
                            else
                            {
                                if (Edges[j].From > i) Edges[j].From--;
                                if (Edges[j].To > i) Edges[j].To--;
                            }
                        }
                        Vertexes.RemoveAt(i);
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    for (int i = 0; i < Edges.Count; i++)
                    {
                        if (Edges[i].From == Edges[i].To)
                        {
                        }
                        else
                        {
                            if (((e.X - Vertexes[Edges[i].From].x) * (Vertexes[Edges[i].To].y - Vertexes[Edges[i].From].y) / (Vertexes[Edges[i].To].x - Vertexes[Edges[i].From].x) + Vertexes[Edges[i].From].y) <= (e.Y + 4) &&
                                ((e.X - Vertexes[Edges[i].From].x) * (Vertexes[Edges[i].To].y - Vertexes[Edges[i].From].y) / (Vertexes[Edges[i].To].x - Vertexes[Edges[i].From].x) + Vertexes[Edges[i].From].y) >= (e.Y - 4))
                            {
                                if ((Vertexes[Edges[i].From].x <= Vertexes[Edges[i].To].x && Vertexes[Edges[i].From].x <= e.X && e.X <= Vertexes[Edges[i].To].x) ||
                                    (Vertexes[Edges[i].From].x >= Vertexes[Edges[i].To].x && Vertexes[Edges[i].From].x >= e.X && e.X >= Vertexes[Edges[i].To].x))
                                {
                                    Edges.RemoveAt(i);
                                    flag = true;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (flag)
                {
                    G.clearSheet();
                    G.drawALLGraph(Vertexes, Edges);
                    cloth.Image = G.GetBitmap();
                    
                }
            }
        }

        
    }
}
