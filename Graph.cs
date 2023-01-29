using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace cursedapp
{

    class Vertex
    {
        public int x, y;

        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Edge
    {
        public int From, To,Weight;

        public Edge(int From, int To, int Weight =1)
        {
            this.From = From;
            this.To = To;
            this.Weight = Weight;
        }
    }
    class Graph
    {
        Bitmap bitmap;
        Pen blackPen;
        Pen redPen;
        Pen darkGoldPen;
        Graphics gr;
        Font fo;
        Brush br;
        PointF point;
        public int R = 15; //радиус окружности вершины

        public Graph(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            gr = Graphics.FromImage(bitmap);
            clearSheet();
            blackPen = new Pen(Color.Black);
            blackPen.Width = 2;
            redPen = new Pen(Color.Red);
            redPen.Width = 2;
            darkGoldPen = new Pen(Color.DarkGoldenrod);
            darkGoldPen.Width = 2;
            fo = new Font("Arial", 15);
            br = Brushes.Black;
        }

        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        public void clearSheet()
        {
            gr.Clear(Color.White);
        }

        public void drawVertex(int x, int y, string number)
        {
            gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
            gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
            point = new PointF(x - 9, y - 9);
            gr.DrawString(number, fo, br, point);
            
        }

        public void drawSelectedVertex(int x, int y)
        {
            gr.DrawEllipse(redPen, (x - R), (y - R), 2 * R, 2 * R);
        }

        public void drawEdge(Vertex V1, Vertex V2, Edge E, int numberE)
        {
            if (E.From != E.To)
            {
                gr.DrawLine(darkGoldPen, V1.x, V1.y, V2.x, V2.y);
                point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                drawVertex(V1.x, V1.y, (E.From + 1).ToString());
                drawVertex(V2.x, V2.y, (E.To + 1).ToString());
            }
        }

        public void drawALLGraph(List<Vertex> V, List<Edge> E)
        {
            for (int i = 0; i < E.Count; i++)
            {
                if (E[i].From != E[i].To)
                {
                    gr.DrawLine(darkGoldPen, V[E[i].From].x, V[E[i].From].y, V[E[i].To].x, V[E[i].To].y);
                    point = new PointF((V[E[i].From].x + V[E[i].To].x) / 2, (V[E[i].From].y + V[E[i].To].y) / 2);
                }
            }
            for (int i = 0; i < V.Count; i++)
            {
                drawVertex(V[i].x, V[i].y, (i + 1).ToString());
            }
        }
        public int[,] createMatrix(int n, List<Edge> E, int[,] matrix, List<Vertex> V)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            for (int i = 0; i < E.Count; i++)
            {
                matrix[E[i].From, E[i].To] = 1;
                matrix[E[i].To, E[i].From] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        matrix[i, j] = (int)Math.Sqrt(Math.Pow((V[i].x - V[j].x), 2) + Math.Pow((V[i].y - V[j].y), 2));
                    }
                }
            }
            return matrix;
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
        public void nearestNeighbourAlgorithm(int[,] graph, int verticesCount,List<Edge> edges, List<Vertex> vertexes)
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
            int countZeros = 0;
            for(int i = 1; i < verticesCount; ++i)
            {
                if (graph[i, parent[i]] == 0)
                {
                    countZeros++;
                }
            }
            if(countZeros == 0)
            {
                Print(parent, graph, verticesCount, edges, vertexes);
            }
            else
            {
                MessageBox.Show("Заполните граф");
            }
             
        }
        private void Print(int[] parent, int[,] graph, int verticesCount,List<Edge> edges,List<Vertex> vertexes)
        {
            string str = " ";
            int sum = 0;
            str += "Ребро    Вес\n";
            for (int i = 1; i < verticesCount; ++i)
            {
               
                    str += $"{parent[i] + 1} - {i + 1}       {graph[i, parent[i]]}\n";
                    sum += graph[i, parent[i]];
                    gr.DrawLine(blackPen, vertexes[i].x, vertexes[i].y, vertexes[parent[i]].x, vertexes[parent[i]].y);
                
            }
            str += $"Итоговая сумма: {sum}";
                
            MessageBox.Show(str);

        }
       
    }
}
