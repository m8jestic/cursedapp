using System;
using System.Collections;
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
        public int From, To, Weight;

        public Edge(int From, int To, int Weight = 1)
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
        public int R = 15;

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
            /*for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        matrix[i, j] = (int)Math.Sqrt(Math.Pow((V[i].x - V[j].x), 2) + Math.Pow((V[i].y - V[j].y), 2));
                    }
                }
            }*/
            return matrix;
        }
        
        public string nearestNeighborAlgorithm(int startPoint, int[,] a, List<Vertex> V)
        {
            float pathLength = 0;
            int actualPoint = startPoint;
            List<int> visited = new List<int>();
            List<int> unVisited = new List<int>();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                unVisited.Add(i);
            }
            unVisited.Remove(actualPoint);
            visited.Add(actualPoint);
            while (unVisited.Count != 0)
            {
                int nearestPath = 0;
                int nearestPoint = 0;
                
                foreach (int vert in unVisited)
                {
                    if (nearestPath == 0)
                    {
                        nearestPath = a[actualPoint, vert];
                        nearestPoint = vert;
                    }
                    if (a[actualPoint,vert] > 0)
                    {
                        if (nearestPath > a[actualPoint, vert])
                        {
                            nearestPath = a[actualPoint, vert];
                            nearestPoint = vert;
                        }
                    }
                    
                }
               
                pathLength += nearestPath;
                actualPoint = nearestPoint;
                unVisited.Remove(actualPoint);
                visited.Add(actualPoint);
            }
            if (a[actualPoint, 0] > 0)
            {
                pathLength += a[actualPoint, startPoint];
                visited.Add(0);
                var str = Print(visited, pathLength, V);
                return str;
            }
            else
            {
                MessageBox.Show("Для данного графа нет решения");
                var str = "Для данного графа решения нет";
                return str;
            }
                         
        }
        private string Print(List<int> visited,float pathLength, List<Vertex> vertexes)
        {
            string str = " ";
            int sum = 0;
            str += "Ребра\n";
            for(int i = 0; i < visited.Count - 1; i++)
            {
                str += $"{visited[i] + 1} - {visited[i + 1] + 1}\n";
                gr.DrawLine(blackPen, vertexes[visited[i]].x, vertexes[visited[i]].y, vertexes[visited[i+1]].x, vertexes[visited[i+1]].y);
            }
            str += $"Итоговый путь {pathLength}";
            
            MessageBox.Show($"{str}");
            return str;
            
        }
        
    }
}
