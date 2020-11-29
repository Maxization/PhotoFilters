using GK3.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3
{
    public class NodeAET
    {
        public int Ymax;
        public double d, X;
        public NodeAET next;

        public NodeAET(int Ymax, double X, double d, NodeAET next)
        {
            this.Ymax = Ymax;
            this.X = X;
            this.d = d;
            this.next = next;
        }
    }
    public class Vertex
    {
        public int X, Y;

        public Vertex(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static implicit operator Point(Vertex v)
        {
            return new Point(v.X, v.Y);
        }

        public static implicit operator Vertex(Point p)
        {
            return new Vertex(p.X, p.Y);
        }
    }

    public class Edge
    {
        public Vertex A, B;

        public Edge(Vertex a, Vertex b)
        {
            this.A = a;
            this.B = b;
        }

        public double DistanceToVertex(Point p)
        {
            double dsc1 = Math.Sqrt((p.X - A.X) * (p.X - A.X) + (p.Y - A.Y) * (p.Y - A.Y));
            double dsc2 = Math.Sqrt((p.X - B.X) * (p.X - B.X) + (p.Y - B.Y) * (p.Y - B.Y));

            return Math.Min(dsc1, dsc2);
        }

    }

    public class Polygon
    {
        const int MAX = 10000;
        public bool isValid;
        List<Edge> edges;
        IFilter filter;
        FilterType filterType;

        public Polygon(params Edge[] edges)
        {
            this.edges = new List<Edge>();
            this.edges.AddRange(edges);
            isValid = false;
            filterType = FilterType.NoFilter;
        }

        public double DistanceFromPoint(Point p)
        {
            double min = double.MaxValue;
            foreach(Edge e in edges)
            {
                double tmp = e.DistanceToVertex(p);
                if (tmp < min) min = tmp; 
            }
            return min;
        }
        public void setFilterType(FilterType filterType)
        {
            this.filterType = filterType;
        }
        public void setFilter(IFilter filter)
        {
            this.filter = filter;
        }
        public void AddEdge(Edge e)
        {
            edges.Add(e);
        }
        public int Count()
        {
            return edges.Count;
        }
        public void Draw(DirectBitmap b)
        {
            foreach(Edge e in edges)
            {
                using (Graphics g = Graphics.FromImage(b.Bitmap))
                {
                    g.DrawLine(Pens.Black, e.A, e.B);
                }
            }
        }
        public (List<NodeAET>[], int) createET()
        {
            int edgeCounter = 0;
            List<NodeAET>[] ET = new List<NodeAET>[MAX];
            foreach (Edge e in edges)
            {
                int ind;
                double m;
                int Ymax;
                int Xmin;
                NodeAET node;

                if (e.A.Y == e.B.Y) continue;

                edgeCounter++;
                if (e.A.Y < e.B.Y)
                {
                    m = (double)(e.B.X - e.A.X) / (double)(e.B.Y - e.A.Y);
                    Ymax = e.B.Y;
                    Xmin = e.A.X;
                    ind = e.A.Y;
                }
                else
                {
                    m = (double)(e.A.X - e.B.X) / (double)(e.A.Y - e.B.Y);
                    Ymax = e.A.Y;
                    Xmin = e.B.X;
                    ind = e.B.Y;
                }

                node = new NodeAET(Ymax, Xmin, m, null);
                if (ET[ind] != null)
                    ET[ind].Add(node);
                else
                    ET[ind] = new List<NodeAET> { node };
            }
            return (ET, edgeCounter);
        }
        public void Fill(DirectBitmap actualBm, DirectBitmap orginalBm)
        {
            List<NodeAET>[] ET;
            int edgeCounter;
            (ET, edgeCounter) = createET();

            int y = 0;
            while (ET[y] == null)
            {
                y++;
                if (y == MAX) return;
            }

            List<NodeAET> AET = new List<NodeAET>();
            while (AET.Any() || edgeCounter != 0)
            {
                if (ET[y] != null)
                {
                    AET.AddRange(ET[y]);
                    edgeCounter -= ET[y].Count;
                }

                AET.Sort((NodeAET q, NodeAET p) =>
                {
                    if (q.X == p.X) return 0;
                    else if (q.X < p.X) return -1;
                    else return 1;
                });

                for (int i = 0; i < AET.Count; i += 2)
                {
                    int xMin = (int)AET[i].X;
                    int xMax = (int)AET[i + 1].X;

                    for (int x = xMin; x <= xMax; x++)
                    {
                        Color col = orginalBm.GetPixel(x, y);
                        Color color = filter.Handle(filterType, col);
                        actualBm.SetPixel(x, y, color);
                    }
                }

                y++;
                AET.RemoveAll(node => node.Ymax == y);

                foreach (NodeAET node in AET)
                {
                    node.X += node.d;
                }
            }
        }
    }

    public class MyBrush
    {
        int width = 30;
        int height = 30;

        public void Fill(DirectBitmap actualBm, DirectBitmap orginalBm, IFilter filter, FilterType filterType, int X, int Y)
        {
            int Width = actualBm.Width;
            int Height = actualBm.Height;

            int hh = height * height;
            int ww = width * width;
            int hhww = hh * ww;
            int x0 = width;
            int dx = 0;

            for (int x = -width; x <= width; x++)
                if(X+x < Width && X+x>=0)
                {
                    Color color = orginalBm.GetPixel(X + x, Y);
                    Color col = filter.Handle(filterType, color);
                    actualBm.SetPixel(X + x, Y, col);
                }
                    

            for (int y = 1; y <= height; y++)
            {
                int x1 = x0 - (dx - 1);
                for (; x1 > 0; x1--)
                    if (x1 * x1 * hh + y * y * ww <= hhww)
                        break;
                dx = x0 - x1;
                x0 = x1;

                for (int x = -x0; x <= x0; x++)
                {
                    if (X + x < Width && X + x >= 0)
                    {
                        if (Y - y < Height && Y - y >= 0)
                        {
                            Color color = orginalBm.GetPixel(X + x, Y - y);
                            Color col = filter.Handle(filterType, color);
                            actualBm.SetPixel(X + x, Y - y, col);

                        }   
                        if(Y + y < Height && Y + y >= 0)
                        {
                            Color color = orginalBm.GetPixel(X + x, Y + y);
                            Color col = filter.Handle(filterType, color);
                            actualBm.SetPixel(X + x, Y + y, col);
                        }
                    }       
                }
            }
        }
    }
}
