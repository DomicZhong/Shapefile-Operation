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

namespace Shapefile_Operation
{
    public partial class Form1
    {
        private void riverCurveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void extractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMapFeatureLayer[] layers = map1.GetFeatureLayers();
            foreach (IMapFeatureLayer singlelayer in layers)            //每个图层
            {
                foreach (Feature featureset in singlelayer.DataSet.Features)  //每个要素
                {
                    foreach (Coordinate Coo in featureset.Coordinates)  //逐个点
                    {
                        Console.WriteLine("X:{0},Y:{1}", Coo.X, Coo.Y);

                    }
                }
            }
        }
    }
}
