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


namespace Shapefile_Operation
{
    public partial class Form1 : Form
    {
        string shapeType;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createPointShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Point ShapeFile class level variable

            //the new point feature set
            FeatureSet pointF = new FeatureSet(FeatureType.Point);

            //the id of point
            int pointID = 0;

            //to differentiate the right and left mouse click
            bool pointmouseClick = false;

            #endregion
            //Change the cursor style
            map1.Cursor = Cursors.Cross;
            //set the shape type to the classlevel string variable
            //we are going to use this variable in select case statement
            shapeType = "Point";
            //set projection
            pointF.Projection = map1.Projection;
            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("ID");
            pointF.DataTable.Columns.Add(column);
            //add the featureSet as map layer
            MapPointLayer pointLayer = (MapPointLayer)map1.Layers.Add(pointF);
            //Create a new symbolizer
            PointSymbolizer symbol = new PointSymbolizer(Color.Red, DotSpatial.Symbology.PointShape.Ellipse, 3);
            //Set the symbolizer to the point layer
            pointLayer.Symbolizer = symbol;
            //Set the legentText as point
            pointLayer.LegendText = "point";
            //Set left mouse click as true
            pointmouseClick = true;


        }

        private void createPointShapefileToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
         

        }

        private void savePointShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pointF.SaveAs("point.shp", true);
            MessageBox.Show("The point shapefile has been saved.");
            map1.Cursor = Cursors.Arrow;
        }
    }
