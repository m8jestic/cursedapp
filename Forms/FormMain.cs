using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace cursedapp
{
    public partial class FormMain : Form
    {
        Graph G;
        
        DataTable dt = new DataTable(); 
        int s1; 
        int s2;
        
        List<Vertex> Vertexes;
        List<Edge> Edges;
        int[,] Matrix;
        string res;
        public FormMain()
        {
            InitializeComponent();
          
            Vertexes = new List<Vertex>();
            Edges = new List<Edge>();
            dataGridVertexes.AllowUserToAddRows = false;
            dataGridVertexes.DataSource = dt;
            G = new Graph(cloth.Width, cloth.Height);
            cloth.Image = G.GetBitmap();

        }


        private void updateMatrix()
        {
            dataGridVertexes.DataSource = dt;
            if (vertexButton.Enabled == false)
            {
                Matrix = new int[Vertexes.Count, Vertexes.Count];
                Matrix = G.createMatrix(Vertexes.Count, Edges, Matrix, Vertexes);
                dt.Columns.Add($"{Vertexes.Count}");
                dt.Rows.Add();
                dataGridVertexes.Rows[Vertexes.Count - 1].Cells[Vertexes.Count - 1].Value = 0;
                for (int i = 0; i < Vertexes.Count; i++)
                {
                    for (int j = 0; j < Vertexes.Count; j++)
                    {
                        if (Matrix[i, j] > 0)
                        {
                            dataGridVertexes.Rows[i].Cells[j].Value = Matrix[i, j];
                            dataGridVertexes.Rows[i].Cells[j].ReadOnly = false;
                        }
                        else
                        {
                            dataGridVertexes.Rows[i].Cells[j].Value = Matrix[i, j];
                            dataGridVertexes.Rows[i].Cells[j].ReadOnly = true;
                        }
                    }
                }
            }
            else if(edgeButton.Enabled == false)
            {
                Matrix = new int[Vertexes.Count, Vertexes.Count];
                Matrix = G.createMatrix(Vertexes.Count, Edges, Matrix, Vertexes);
                dataGridVertexes.Rows[Vertexes.Count - 1].Cells[Vertexes.Count - 1].Value = 0;
                for (int i = 0; i < Vertexes.Count; i++)
                {
                    for (int j = 0; j < Vertexes.Count; j++)
                    {
                        if (Matrix[i, j] > 0)
                        {
                            dataGridVertexes.Rows[i].Cells[j].Value = Matrix[i, j];
                            dataGridVertexes.Rows[i].Cells[j].ReadOnly = false;
                        }
                        else
                        {
                            dataGridVertexes.Rows[i].Cells[j].Value = Matrix[i, j];
                            dataGridVertexes.Rows[i].Cells[j].ReadOnly = true;
                        }
                    }
                }
            }
            else if(deleteButton.Enabled == false)
            {
                Matrix = new int[Vertexes.Count, Vertexes.Count];
                Matrix = G.createMatrix(Vertexes.Count, Edges, Matrix, Vertexes);
                dt = new DataTable();
                dataGridVertexes.DataSource = dt;
                if (Vertexes.Count > 0)
                {
                    for (int i = 0; i < Vertexes.Count; i++)
                    {
                    dt.Columns.Add($"{i+1}");
                    dt.Rows.Add();
                    }
                
                    
                    dataGridVertexes.Rows[Vertexes.Count - 1].Cells[Vertexes.Count - 1].Value = 0;
                    for (int i = 0; i < Vertexes.Count; i++)
                    {
                        for (int j = 0; j < Vertexes.Count; j++)
                        {
                            if (Matrix[i, j] > 0)
                            {
                                dataGridVertexes.Rows[i].Cells[j].Value = Matrix[i, j];
                                dataGridVertexes.Rows[i].Cells[j].ReadOnly = false;
                            }
                            else
                            {
                                dataGridVertexes.Rows[i].Cells[j].Value = Matrix[i, j];
                                dataGridVertexes.Rows[i].Cells[j].ReadOnly = true;
                            }
                        }
                    }
                }
                

            }
            else 
            {
                dt = new DataTable();
                dataGridVertexes.DataSource = dt;
            }
            
        }
        private void dataGridVertexes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var col = e.ColumnIndex;
            var row = e.RowIndex;
            var type = dataGridVertexes.Rows[row].Cells[col].Value.ToString();
            bool isNumber = double.TryParse(type, out double number);
            if (isNumber & number > 0 | type != "")
            {
                if (col != row)
                {
                    dataGridVertexes.Rows[col].Cells[row].Value = dataGridVertexes.Rows[row].Cells[col].Value;
                    Matrix[col, row] = int.Parse(dataGridVertexes.Rows[col].Cells[row].Value.ToString());
                    Matrix[row,col] = Matrix[col, row];
                }
                    
                else
                    dataGridVertexes.Rows[col].Cells[row].Value = 1;
            }
            else
            {
                MessageBox.Show("Допускается вводить только положительные численные значения");
                dataGridVertexes.Rows[row].Cells[col].Value = 1;
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }

      
        
        
       
        
        private void buttonSolving_Click(object sender, EventArgs e)
        {
            if (Vertexes.Count >1 & Edges.Count > 0)
            {
                var newWay = new List<Edge>();
                res = G.nearestNeighborAlgorithm(0,Matrix, Vertexes);
                cloth.Image = G.GetBitmap();
            }
            else
                MessageBox.Show("Заполните граф");
        }

       

        private void vertexButton_Click(object sender, EventArgs e)
        {
            vertexButton.Enabled = false;
            
            edgeButton.Enabled = true;
            deleteButton.Enabled = true;
            G.clearSheet();
            
            G.drawALLGraph(Vertexes, Edges);
            cloth.Image = G.GetBitmap();
            
        }

        private void edgeButton_Click(object sender, EventArgs e)
        {
            edgeButton.Enabled = false;
           
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
          
            vertexButton.Enabled = true;
            edgeButton.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(Vertexes, Edges);
            cloth.Image = G.GetBitmap();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
        
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
                updateMatrix();
            }
        }
       
       
        private void cloth_Click(object sender, MouseEventArgs e)
        {
            if (vertexButton.Enabled == false)
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
                        updateMatrix();
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
                updateMatrix();
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
                updateMatrix();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ёрхов Матвей 741-1\nАлгоритм ближайшего соседа — один из простейших эвристических алгоритмов решения задачи коммивояжёра. Относится к категории «жадных» алгоритмов.", "О программе");
        }

        private void buttonSaveSolving_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                try
                {
                    cloth.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveTextSolving_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text Files | *.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                using (StreamWriter SW = new StreamWriter(saveFileDialog.FileName, false))
                {
                    SW.WriteLine("Результаты работы программы.");
                    SW.WriteLine("Граф состоит из {0} точек.", Vertexes.Count);
                    if (Vertexes.Count > 0)
                    {
                        SW.WriteLine();
                        SW.WriteLine(res);
                        
                    }
                    SW.Close();
                }
            }
        }
    }
}
