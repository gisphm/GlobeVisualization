using System;
using System.Windows.Forms;
using ESRI.ArcGIS.GlobeCore;

namespace GlobeVisualization
{
    /// <summary>
    /// 图层属性的基类，包含所有图层属性的公共部分
    /// </summary>
    public partial class PropertyBase : Form
    {
        private readonly IGlobe _bGlobe;
        public PropertyBase(IGlobe bGlobe)
        {
            InitializeComponent();
            if (bGlobe == null) return;
            _bGlobe = bGlobe;
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            Close();
        }
    }
}
