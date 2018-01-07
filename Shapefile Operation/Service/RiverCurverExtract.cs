using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Symbology;
using DotSpatial.Topology;
using DotSpatial.Projections;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Reflection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Data.Common;
using System.Data.SQLite;

namespace Shapefile_Operation
{
    public partial class Form1
    {
        #region Polyline  ShapeFile class level variables

        MapLineLayer lineLayer_ = default(MapLineLayer);

        //the line feature set
        FeatureSet lineF_ = new FeatureSet(FeatureType.Line);
        
        int lineID_ = 0;
        #endregion

        System.Data.DataTable Argumenttable = new System.Data.DataTable("Arguments");
        List<List<DotSpatial.Topology.Coordinate>> FeaturePoints = new List<List<DotSpatial.Topology.Coordinate>>();

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)    //绘制曲流颈和曲流轴
        {
            //DataColumn column = new DataColumn("LineID");
            //if (!lineF_.DataTable.Columns.Contains("LineID"))
            //{
            //    lineF_.DataTable.Columns.Add(column);
            //}

            foreach (List<DotSpatial.Topology.Coordinate> FeaturePoint in FeaturePoints)
            {
                //Create a new List called lineArray.                          
                //This list will store the Coordinates
                //We are going to store the mouse click coordinates into this array.
                List<DotSpatial.Topology.Coordinate> lineArray = new List<DotSpatial.Topology.Coordinate>();
                //Create an instance for LineString class.
                //We need to pass collection of list coordinates
                LineString lineGeometry = new LineString(lineArray);

                //Add the linegeometry to line feature
                //add 曲流颈 coordinate to the line feature
                IFeature lineFeature1 = lineF_.AddFeature(lineGeometry); //添加线要素
                lineFeature1.Coordinates.Add(FeaturePoint[0]);
                lineFeature1.Coordinates.Add(FeaturePoint[1]);

                //DataRowBuilder dataRowBuilder1 = new DataRowBuilder();
                //lineFeature1.DataRow = new DataRow();

                //Add the linegeometry to line feature
                //add 曲流轴 coordinate to the line feature
                IFeature lineFeature2 = lineF_.AddFeature(lineGeometry); //添加线要素
                lineFeature2.Coordinates.Add(FeaturePoint[2]);
                lineFeature2.Coordinates.Add(FeaturePoint[3]);
                
                //refresh the map if line has 2 or more points
                if (lineFeature1.Coordinates.Count >= 2 && lineFeature2.Coordinates.Count >= 2)
                {
                    lineF_.InitializeVertices();
                    map1.ResetBuffer();
                }
            }

            //set projection
            lineF_.Projection = map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("LineID");

            if (!lineF_.DataTable.Columns.Contains("LineID"))
            {
                lineF_.DataTable.Columns.Add(column);
            }

            //add the featureSet as map layer
            lineLayer = (MapLineLayer)map1.Layers.Add(lineF_);

            //Set the symbolizer to the line feature. 
            LineSymbolizer symbol = new LineSymbolizer(Color.Red, Color.Red, 2, DashStyle.Dot, LineCap.Square);
            lineLayer.Symbolizer = symbol;
            lineLayer.LegendText = "line";
            MessageBox.Show("Draw Over！！！");
        }

        private void extractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Argumenttable.Columns.Add("ID", typeof(int));
            Argumenttable.Columns.Add("曲流颈坐标", typeof(String));
            Argumenttable.Columns.Add("曲流颈长度L", typeof(double));
            Argumenttable.Columns.Add("河道长度S", typeof(double));
            Argumenttable.Columns.Add("曲折率C", typeof(double));
            Argumenttable.Columns.Add("封闭率e", typeof(double));
            Argumenttable.Columns.Add("河曲轴夹角β", typeof(double));
            Argumenttable.Columns.Add("河曲轴长M", typeof(double));

            int rowID = 1;
            double limitRatio = 0.3;
            IMapFeatureLayer[] layers = map1.GetFeatureLayers();
            foreach (IMapFeatureLayer singlelayer in layers)            //每个图层
            {
                foreach (Feature featureset in singlelayer.DataSet.Features)  //每个要素
                {
                    List<ArrayList> RiverCurvePoint = new List<ArrayList>(); 

                    for (int i = 0; i < featureset.Coordinates.Count; i++)  //逐个点
                    {
                        Coordinate startpo = (Coordinate)featureset.Coordinates[i];                          //曲流颈起点
                        double minRatio = 999.99,minD=999999,minL=999999;         //弯曲率 和 弯曲率限制参数
                        int endindex = i;
                        ArrayList FeaturePoint = new ArrayList();

                        for (int k = i + 1; k < featureset.Coordinates.Count; k++)   //找曲流颈终点
                        {
                            Coordinate MarkPoint = (Coordinate)featureset.Coordinates[k];
                            double D, L = 0, Ratio;

                            D = Distance(MarkPoint, startpo);  //求两点直接的距离

                            for (int range = i+1; range <= k; range++)   //求两点在河流中的长度
                            {
                                Coordinate temppo1 = (Coordinate)featureset.Coordinates[range-1];
                                Coordinate temppo2 = (Coordinate)featureset.Coordinates[range];
                                L += Distance(temppo1, temppo2);
                            }
                            Ratio = D / L;

                            if (Ratio < minRatio)   //取最小比例的终点
                            {
                                minRatio = Ratio;minD = D;minL = L;
                                endindex = k;
                                //Console.WriteLine("{0},{1}", Ratio, 1 / D);
                            }
                        }     //找到终点

                        if (minRatio<limitRatio)
                        {
                            FeaturePoint.Add(i);     //起始、终点、比例、
                            FeaturePoint.Add(endindex);
                            FeaturePoint.Add(minRatio);
                            FeaturePoint.Add(minD);
                            FeaturePoint.Add(minL);
                            RiverCurvePoint.Add(FeaturePoint);
                        }
                    }

                    int startIndex =0 , endIndex =0; //得到最佳河曲颈起始点和终点
                    double Dis=0, Len=0, c=999999;
                    for (int i = 0; i < RiverCurvePoint.Count; i++) 
                    {
                        if ((double)RiverCurvePoint[i][2] < c)
                        {
                            c = (double)RiverCurvePoint[i][2];
                            startIndex = (int)RiverCurvePoint[i][0];
                            endIndex = (int)RiverCurvePoint[i][1];
                            Dis = (double)RiverCurvePoint[i][3];
                            Len = (double)RiverCurvePoint[i][4];
                        }
                    }
                    c = 1 / c;

                    if(startIndex!=endIndex)
                    {
                        Coordinate startpo = (Coordinate)featureset.Coordinates[startIndex];                          //曲流颈起点
                        Coordinate endpo = (Coordinate)featureset.Coordinates[endIndex];                            //曲流颈终点
                        Coordinate CentralPoint = new Coordinate();                            //曲流轴起点
                        Coordinate AxisEndPoint = new Coordinate();                            //曲流轴终点
                        double M = 0;

                        CentralPoint.X = (startpo.X + endpo.X) / 2; CentralPoint.Y = (startpo.Y + endpo.Y) / 2;  //取曲流颈中点

                        //根据距离最大找曲流轴
                        for (int axispointindex = startIndex; axispointindex < endIndex; axispointindex++)
                        {
                            Coordinate temppo = (Coordinate)featureset.Coordinates[axispointindex];
                            double temdis = Distance(CentralPoint, temppo);

                            if (temdis > M)
                            {
                                M = temdis;
                                AxisEndPoint = temppo;
                            }
                        }

                        List<Coordinate> RiverFeaturePoint = new List<Coordinate>{startpo,endpo,CentralPoint,AxisEndPoint};

                        FeaturePoints.Add(RiverFeaturePoint);   //加到曲流特征点数组中
                        
                        string tempStr = startpo.X.ToString() + "," + startpo.Y.ToString()+" , "+ endpo.X.ToString() + "," + endpo.Y.ToString(); ;
                        double 弯曲率e = c / (c + 1);
                        double cosA = ((AxisEndPoint.X - CentralPoint.X) * (startpo.X - CentralPoint.X) + (AxisEndPoint.Y - CentralPoint.Y) * (startpo.Y - CentralPoint.Y))/(Distance(CentralPoint,startpo)*Distance(CentralPoint,AxisEndPoint));
                        Console.WriteLine(cosA);
                        double angle = Math.Acos(cosA)*180/Math.PI;
                        Console.WriteLine("angle:"+angle);
                        if (angle>90)
                        {
                            angle = 180 - angle; 
                        }

                        Argumenttable.Rows.Add(rowID,tempStr,Dis,Len,c, 弯曲率e,angle, M);
                        rowID++;

                    }
                }
            }

            MessageBox.Show("Extract Over!!!");
        }

        private void viewArgTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 DataTableForm = new Form2(Argumenttable);
            DataTableForm.ShowDialog();
        }


        //get the distance of to Coordinate Point
        private static double Distance(Coordinate A, Coordinate B)
        {
            return Math.Pow(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2), 0.5);
        }
    }
}
