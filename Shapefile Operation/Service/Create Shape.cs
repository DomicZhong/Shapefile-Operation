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
    public partial class Form1
    {
        /// <summary>
        /// 创建点文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPointShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        /// <summary>
        /// 创建线文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPolylineShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the mouse cursor
            map1.Cursor = Cursors.Cross;

            //set shape type
            shapeType = "line";

            //set projection
            lineF.Projection = map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("LineID");

            if (!lineF.DataTable.Columns.Contains("LineID"))
            {
                lineF.DataTable.Columns.Add(column);
            }

            //add the featureSet as map layer
            lineLayer = (MapLineLayer)map1.Layers.Add(lineF);

            //Set the symbolizer to the line feature. 
            LineSymbolizer symbol = new LineSymbolizer(Color.Blue, 2);
            lineLayer.Symbolizer = symbol;
            lineLayer.LegendText = "line";

            firstClick = true;

            linemouseClick = true;
        }
        /// <summary>
        /// 创建面文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPloygonShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initialize polyline feature set
            map1.Cursor = Cursors.Cross;

            //set shape type
            shapeType = "polygon";

            //set projection
            polygonF.Projection = map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("PolygonID");

            if (!polygonF.DataTable.Columns.Contains("PolygonID"))
            {
                polygonF.DataTable.Columns.Add(column);
            }

            //add the featureSet as map layer
            MapPolygonLayer polygonLayer = (MapPolygonLayer)map1.Layers.Add(polygonF);

            PolygonSymbolizer symbol = new PolygonSymbolizer(Color.Green);

            polygonLayer.Symbolizer = symbol;
            polygonLayer.LegendText = "polygon";

            firstClick = true;

            polygonmouseClick = true;
        }
        /// <summary>
        /// 保存shapefile文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "请选择面文件路径";
            dialog.Filter = "shp文件(*.*)|*.shp*";
            dialog.AddExtension = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                file = dialog.FileName;
            }
            else
            {
                file = null;
            }

            switch (shapeType)
            {
                case "Point":
                    pointF.SaveAs(file, true);
                    break;
                case "line":
                    lineF.SaveAs(file, true);
                    break;
                case "polygon":
                    polygonF.SaveAs(file, true);
                    break;
            }
            MessageBox.Show("The shapefile has been saved.");
            map1.Cursor = Cursors.Arrow;
        }

    }
}
