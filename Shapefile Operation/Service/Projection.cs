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
        private void asiaNorthAlbersEqualAreaConicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.Projection = KnownCoordinateSystems.Projected.Asia.AsiaNorthAlbersEqualAreaConic;
            for (int i = 0; i < map1.Layers.Count; i++)
            {
                map1.GetLayers()[0].Projection = map1.Projection;
            }
            map1.Refresh();
        }

        private void worldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.Projection = KnownCoordinateSystems.Geographic.World.WGS1984;

            for (int i = 0; i < map1.Layers.Count; i++)
            {
                map1.GetLayers()[0].Projection = map1.Projection;
            }
            map1.ResetBuffer();

            //add layer to first map
            //FeatureSet featureSet1 = new FeatureSet();
            //featureSet1.Open(fileDialog.FileName);

            ////Populate the FiledName dropdownlist with the help of featureset1.
            ////We need to pass featureset as an input paramter to FillColumnNames method.
            //FillColumnNames(featureSet1);

            ////set the projection
            //featureSet1.Reproject(map1.Projection);
            //map1.Layers.Add(featureSet1);

        }

        private void beijing1954ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.Projection = KnownCoordinateSystems.Geographic.Asia.Beijing1954;
            for (int i = 0; i < map1.Layers.Count; i++)
            {
                map1.GetLayers()[0].Projection = map1.Projection;
            }
            map1.Refresh();
        }

        private void worldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            map1.Projection = KnownCoordinateSystems.Projected.World.Mercatorworld;
            for (int i = 0; i < map1.Layers.Count; i++)
            {
                map1.GetLayers()[0].Projection = map1.Projection;
            }
            map1.Refresh();
        }

    }
}
