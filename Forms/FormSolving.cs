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
    public partial class FormSolving : Form
    {
        DataGridView dataGridVertex = new DataGridView();
  
        public FormSolving(DataGridView dataGridView,DataTable dataTable)
        {
            InitializeComponent();
            dataGridVertex = dataGridView;
            
        }
        private static int MinKey(int[] key, bool[] set, int verticesCount)
        {
            int min = int.MaxValue, minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (set[v] == false && key[v] < min)
                {
                    min = key[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private void Print(int[] parent, int[,] graph, int verticesCount)
        {
            string str = " ";

            str +="Ребро    Вес\n";
            for (int i = 1; i < verticesCount; ++i)
                str += $"{parent[i] + 1} - {i + 1}       {graph[i, parent[i]]}\n";
            MessageBox.Show(str);
            
        }
        private void NearestNeighbourAlgorithm(int[,] graph, int verticesCount)
        {
            int[] parent = new int[verticesCount];
            int[] key = new int[verticesCount];
            bool[] mstSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                key[i] = int.MaxValue;
                mstSet[i] = false;
            }

            key[0] = 0;
            parent[0] = -1;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinKey(key, mstSet, verticesCount);
                mstSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                {
                    if (Convert.ToBoolean(graph[u, v]) && mstSet[v] == false && graph[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = graph[u, v];
                    }
                }
            }

            Print(parent, graph, verticesCount);
        }
        private int[,] GetMatrix(DataGridView dg)
        {
            int n = dg.ColumnCount;
            int[,] matrix = new int[n,n];
            for(int i = 0; i< n; i++)
            {
               for(int j = 0; j<n; j++)
                {
                    matrix[i, j] = Int32.Parse(dg.Rows[i].Cells[j].Value.ToString());
                }
            }
            return matrix;
        }
       
        private void FormSolving_Load(object sender, EventArgs e)
        {
            var adjecencyMatrix = GetMatrix(dataGridVertex);
            NearestNeighbourAlgorithm(adjecencyMatrix, dataGridVertex.ColumnCount);
            
        }
    }
}

