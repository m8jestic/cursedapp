using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int From, To;

        public Edge(int From, int To)
        {
            this.From = From;
            this.To = To;
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
        public double[,] createMatrix(int n, List<Edge> E, double[,] matrix, List<Vertex> V)
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
                        matrix[i, j] = Math.Sqrt(Math.Pow((V[i].x - V[j].x), 2) + Math.Pow((V[i].y - V[j].y), 2));
                    }
                }
            }
            return matrix;
        }
       /* public void algorithmByPrim(int numberV, List<Edge> E, List<Edge> MST)

        {

            //неиспользованные ребра

            List<Edge> notUsedE = new List<Edge>(E);

            //использованные вершины

            List<int> usedV = new List<int>();

            //неиспользованные вершины

            List<int> notUsedV = new List<int>();

            for (int i = 0; i < numberV; i++)

                notUsedV.Add(i);

            //выбираем случайную начальную вершину

            Random rand = new Random();

            usedV.Add(rand.Next(0, numberV));

            notUsedV.RemoveAt(usedV[0]);

            while (notUsedV.Count > 0)

            {

                int minE = -1; //номер наименьшего ребра

                //поиск наименьшего ребра

                for (int i = 0; i < notUsedE.Count; i++)

                {

                    if ((usedV.IndexOf(notUsedE[i].From) != -1) && (notUsedV.IndexOf(notUsedE[i].To) != -1) ||

                    (usedV.IndexOf(notUsedE[i].To) != -1) && (notUsedV.IndexOf(notUsedE[i].From) != -1))

                    {

                        if (minE != -1)

                        {

                            if (notUsedE[i].weight < notUsedE[minE].weight)

                                minE = i;

                        }

                        else

                            minE = i;

                    }

                }

                //заносим новую вершину в список использованных и удаляем ее из списка неиспользованных

                if (usedV.IndexOf(notUsedE[minE].To) != -1)

                {

                    usedV.Add(notUsedE[minE].To);

                    notUsedV.Remove(notUsedE[minE].To);

                }

                else

                {

                    usedV.Add(notUsedE[minE].From);

                    notUsedV.Remove(notUsedE[minE].From);

                }

                //заносим новое ребро в дерево и удаляем его из списка неиспользованных

                MST.Add(notUsedE[minE]);

                notUsedE.RemoveAt(minE);

            }
        }*/

    }
}
