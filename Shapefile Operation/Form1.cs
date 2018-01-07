using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Shapefile_Operation
{
    public partial class Form1 : Form
    {

        #region Point ShapeFile class level variable

        //the new point feature set
        FeatureSet pointF = new FeatureSet(FeatureType.Point);

        //the id of point
        int pointID = 0;

        //to differentiate the right and left mouse click
        bool pointmouseClick = false;

        #endregion

        #region Polyline  ShapeFile class level variables

        MapLineLayer lineLayer = default(MapLineLayer);

        //the line feature set
        FeatureSet lineF = new FeatureSet(FeatureType.Line);

        int lineID = 0;

        //boolean variable for first time mouse click
        bool firstClick = false;

        //It controls the drawing the polyline after the polyline saved operation.
        bool linemouseClick = false;

        #endregion

        #region Polygon ShapeFile class level variables

        FeatureSet polygonF = new FeatureSet(FeatureType.Polygon);

        int polygonID = 0;

        bool polygonmouseClick = false;

        #endregion

        string shapeType;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void map1_MouseDown(object sender, MouseEventArgs e)
        {

            switch (shapeType)
            {
                case "Point":
                    if (e.Button == MouseButtons.Left)
                    {
                        if ((pointmouseClick))
                        {
                            //This method is used to convert the screen cordinate to map coordinate
                            //e.location is the mouse click point on the map control
                            DotSpatial.Topology.Coordinate coord = map1.PixelToProj(e.Location);

                            //Create a new point
                            //Input parameter is clicked point coordinate
                            DotSpatial.Topology.Point point = new DotSpatial.Topology.Point(coord);

                            //Add the point into the Point Feature
                            //assigning the point feature to IFeature because via it only we can set the attributes.
                            IFeature currentFeature = pointF.AddFeature(point);

                            //increase the point id
                            pointID = pointID + 1;

                            //set the ID attribute
                            currentFeature.DataRow["ID"] = pointID;

                            //refresh the map
                            map1.ResetBuffer();
                        }
                    }

                    else
                    {
                        //mouse right click
                        map1.Cursor = Cursors.Default;
                        pointmouseClick = false;
                    }
                    break;

                case "line":
                    if (e.Button == MouseButtons.Left)
                    {
                        //left click - fill array of coordinates
                        //coordinate of clicked point
                        DotSpatial.Topology.Coordinate coord = map1.PixelToProj(e.Location);
                        if (linemouseClick)
                        {
                            //first time left click - create empty line feature
                            if (firstClick)
                            {
                                //Create a new List called lineArray.                          
                                //This list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.
                                List<DotSpatial.Topology.Coordinate> lineArray = new List<DotSpatial.Topology.Coordinate>();

                                //Create an instance for LineString class.
                                //We need to pass collection of list coordinates
                                LineString lineGeometry = new LineString(lineArray);

                                //Add the linegeometry to line feature
                                IFeature lineFeature = lineF.AddFeature(lineGeometry);

                                //add first coordinate to the line feature
                                lineFeature.Coordinates.Add(coord);
                                //set the line feature attribute
                                lineID = lineID + 1;
                                lineFeature.DataRow["LineID"] = lineID;
                                firstClick = false;
                            }
                            else
                            {
                                //second or more clicks - add points to the existing feature
                                IFeature existingFeature = lineF.Features[lineF.Features.Count - 1];
                                existingFeature.Coordinates.Add(coord);

                                //refresh the map if line has 2 or more points
                                if (existingFeature.Coordinates.Count >= 2)
                                {
                                    lineF.InitializeVertices();
                                    map1.ResetBuffer();
                                }
                            }
                        }
                    }
                    else
                    {
                        //right click - reset first mouse click
                        firstClick = true;
                        map1.ResetBuffer();
                    }
                    break;
                case "polygon":

                    if (e.Button == MouseButtons.Left)
                    {
                        //left click - fill array of coordinates
                        DotSpatial.Topology.Coordinate coord = map1.PixelToProj(e.Location);

                        if (polygonmouseClick)
                        {
                            //first time left click - create empty line feature
                            if (firstClick)
                            {
                                //Create a new List called polygonArray.

                                //this list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.

                                List<DotSpatial.Topology.Coordinate> polygonArray = new List<DotSpatial.Topology.Coordinate>();

                                //Create an instance for LinearRing class.
                                //We pass the polygon List to the constructor of this class
                                LinearRing polygonGeometry = new LinearRing(polygonArray);

                                //Add the polygonGeometry instance to PolygonFeature
                                IFeature polygonFeature = polygonF.AddFeature(polygonGeometry);

                                //add first coordinate to the polygon feature
                                polygonFeature.Coordinates.Add(coord);

                                //set the polygon feature attribute
                                polygonID = polygonID + 1;
                                polygonFeature.DataRow["PolygonID"] = polygonID;
                                firstClick = false;
                            }
                            else
                            {
                                //second or more clicks - add points to the existing feature
                                IFeature existingFeature = (IFeature)polygonF.Features[polygonF.Features.Count - 1];

                                existingFeature.Coordinates.Add(coord);

                                //refresh the map if line has 2 or more points
                                if (existingFeature.Coordinates.Count >= 3)
                                {
                                    //refresh the map
                                    polygonF.InitializeVertices();
                                    map1.ResetBuffer();
                                }
                            }
                        }
                    }
                    else
                    {
                        //right click - reset first mouse click
                        firstClick = true;
                    }
                    break;

            }

        }

        /// <summary>
        /// 坐标状态栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">鼠标指针</param>
        private void map1_GeoMouseMove(object sender, GeoMouseArgs e)
        {
            toolStripStatusLabel1.Text = "X:" + e.GeographicLocation.X.ToString() + ",Y:" + e.GeographicLocation.Y.ToString();
        }


    }
}
