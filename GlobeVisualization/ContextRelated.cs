using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Analyst3D;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.GlobeCore;

namespace GlobeVisualization {
	public class ContextRelated {
		private readonly IGlobe _cGlobe;
		public ContextRelated( IGlobe cGlobe ) {
			if (cGlobe != null) {
				_cGlobe = cGlobe;
			}
		}

		public void ZoomToGlobeLayer( int layerIndex ) {
			IGlobeDisplay globeDisplay = _cGlobe.GlobeDisplay;
			if (globeDisplay == null) return;
			ISceneViewer sceneViewer = globeDisplay.ActiveViewer;
			ICamera camera = sceneViewer.Camera;
			IGlobeCamera globeCamera = camera as IGlobeCamera;
			if (globeCamera == null) return;
			IScene scene = _cGlobe as IScene;
			if (scene == null) return;
			ILayer layer = scene.Layer[layerIndex];
			IEnvelope envelope = layer.AreaOfInterest.Envelope;
			globeCamera.SetToZoomToExtents( envelope, _cGlobe, sceneViewer );
		}
	}
}