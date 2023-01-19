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
        DataTable dt = new DataTable();
        public FormSolving(DataGridView dataGridView,DataTable dataTable)
        {
            InitializeComponent();
            dataGridVertex = dataGridView;
            dt = dataTable; 
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

        private static void Print(int[] parent, int[,] graph, int verticesCount)
        {
            Console.WriteLine("Edge     Weight");
            for (int i = 1; i < verticesCount; ++i)
                Console.WriteLine("{0} - {1}    {2}", parent[i] + 1, i + 1, graph[i, parent[i]]);
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
        private void GetMatrix(DataGridView dg)
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
        }
        private void FormSolving_Load(object sender, EventArgs e)
        {
            GetMatrix(dataGridVertex);
        }
    }
}

