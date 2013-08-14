using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.GlobeCore;

namespace GlobeVisualization
{
    /// <summary>
    /// 这个类包含对由<c>PropertyBase</c>派生出的类的操作
    /// </summary>
    public class PropertyControl
    {
        private readonly IGlobe _cGlobe;
        private readonly ArrayList _propertyList;
        private PropertyInfo _propertyInfo;
        public PropertyControl(IGlobe cGlobe)
        {
            if(cGlobe==null) return;
            _cGlobe = cGlobe;
            _propertyList.Add(new PropertyBase(_cGlobe));
            _propertyInfo = null;
        }
    }
}
