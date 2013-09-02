using System;
using System.Diagnostics;
using System.Windows.Forms;
using ESRI.ArcGIS.Analyst3D;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.GlobeCore;
using ESRI.ArcGIS.SystemUI;
using Point = System.Drawing.Point;

namespace GlobeVisualization
{
	public sealed partial class MainForm : Form
	{
		#region private class members
		private IGlobeControl _mGlobeControl = null;
		private IGlobeViewUtil _mGlobeViewUtil = null;
		private ILayer _tocSelectedLayer = null;
		#endregion

		#region calss constructor
		public MainForm( )
		{
			InitializeComponent();
		}
		#endregion

		/// <summary>
		/// Form Load event handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load( object sender, EventArgs e )
		{
			_mGlobeControl = axGlobeControl1.Object as IGlobeControl;
			if (_mGlobeControl == null)
			{
				MessageBox.Show( "�����ϵͳ����" );
				return;
			}
			//cast the GlobeViewUtil from the GlobeCamera
			_mGlobeViewUtil = _mGlobeControl.GlobeCamera as IGlobeViewUtil;
			MouseWheel += axGlobeControl1_OnMouseWheel;
		}

		#region Main Menu event handlers
		private void menuOpenDoc_Click( object sender, EventArgs e )
		{
			//execute Open Document command
			ICommand command = new ControlsGlobeOpenDocCommandClass();
			command.OnCreate( _mGlobeControl.Object );
			command.OnClick();
		}

		private void menuExitApp_Click( object sender, EventArgs e )
		{
			//exit the application
			Application.Exit();
		}
		#endregion

		#region globecontrol event handlers

		private void axGlobeControl1_OnMouseMove( object sender, IGlobeControlEvents_OnMouseMoveEvent e )
		{
			double dLon, dLat, dAlt;

			//convert the window coordinate into geographic coordinates
			_mGlobeViewUtil.WindowToGeographic( _mGlobeControl.GlobeDisplay,
										   _mGlobeControl.GlobeDisplay.ActiveViewer,
										   e.x,
										   e.y,
										   true,
										   out dLon,
										   out dLat,
										   out dAlt );

			//report the mouse geographic coordinate onto the status bar
			statusBarXY.Text = string.Format( "{0} {1} {2}", dLon.ToString( "###.###" ), dLat.ToString( "###.###" ), dAlt.ToString( "###.###" ) );
		}

		private void axGlobeControl1_OnMouseWheel( object sender, MouseEventArgs e )
		{
			//��ȡ(������)axGlobeControl1�ؼ������Ͻ�����������������Ͻǵ�����
			Point controlLocation = axGlobeControl1.PointToScreen( axGlobeControl1.Location );
			//��ȡ��������
			Point mouseLocation = PointToScreen( e.Location );
			//�����ǰ���λ�ò���axGlobeControl1�ؼ��ڣ�����
			if (mouseLocation.X < controlLocation.X ||
				mouseLocation.X > controlLocation.X + axGlobeControl1.Width ||
				mouseLocation.Y < controlLocation.Y ||
				mouseLocation.Y > controlLocation.Y + axGlobeControl1.Height)
			{
				return;
			}

			//�������ű���
			double scale = 0.2;
			//�ж��������ת�����ƶ���������������ת����С��
			if (e.Delta < 0) scale = -scale;
			//��ؼ����
			IGlobeCamera pGlobeCamera = axGlobeControl1.GlobeCamera;
			ICamera pCamera = pGlobeCamera as ICamera;
			if (pCamera == null) return;

			//��ȡ��ͼ
			IGlobeDisplay pGlobeDisplay = axGlobeControl1.GlobeDisplay;
			if (pGlobeDisplay == null) return;

			//�������ķ���ָ��globe�ı���,ȫ��ģʽ
			if (pGlobeCamera.OrientationMode == esriGlobeCameraOrientationMode.esriGlobeCameraOrientationGlobal)
			{
				double zt, xo, yo, zo;
				//��ȡ��ʾΪʮ����γ�Ⱥ;��ȣ��Լ�����Ϊ��λ�ĸ̣߳��Ĺ۲���λ�á�
				pGlobeCamera.GetObserverLatLonAlt( out xo, out yo, out zo );
				//��ȡ�����ĵ���λ��ĳ����ĵ���߳�,ע�⾭γ�����ϸ������෴
				pGlobeDisplay.GetSurfaceElevation( yo, xo, true, out zt );
				//�½��۲��
				IPoint pObserver = new PointClass();
				//�ü���λ�����ù۲������
				pObserver.PutCoords( xo, yo );
				//�����۲��߳�
				zo = ( zo - zt ) * ( 1 + scale );
				//���ù۲��λ�ã���γ��Ϊʮ���ƶȣ��߳��Թ���Ϊ��λ
				pGlobeCamera.SetObserverLatLonAlt( xo, yo, zo );
			}
			else
			{
				//���Ź۲����
				pCamera.ViewingDistance += pCamera.ViewingDistance * scale;
			}
			//ˢ����ͼ
			axGlobeControl1.GlobeDisplay.RefreshViewers();
		}

		#endregion

		#region toccontrol events handlers
		/// <summary>
		/// axTOCControl���ѡ��ͼ����һ������˵�����
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void axTOCControl1_OnMouseDown( object sender, ITOCControlEvents_OnMouseDownEvent e )
		{
			if (e.button == 4 || tocContextMenu == null)
			{
				return;
			}

			esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
			IBasicMap map = null;
			ILayer layer = null;
			object other = null;
			object index = null;
			axTOCControl1.HitTest( e.x, e.y, ref item, ref map, ref layer, ref other, ref index );

			if (item != esriTOCControlItem.esriTOCControlItemLayer) return;
			_tocSelectedLayer = layer;
			axTOCControl1.SelectItem( layer, null );
			if (e.button == 2)
			{
				tocContextMenu.Show( axTOCControl1, new Point( e.x, e.y ) );
			}
		}

		private void axTOCControl1_OnMouseMove( object sender, ITOCControlEvents_OnMouseMoveEvent e )
		{
			esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
			IBasicMap map = null;
			ILayer layer = null;
			object other = null;
			object index = null;
			if (e.button == 1)
			{
				axTOCControl1.HitTest( e.x, e.y, ref item, ref map, ref layer, ref other, ref index );
				if (item != esriTOCControlItem.esriTOCControlItemNone)
				{
					axTOCControl1.MousePointer = esriControlsMousePointer.esriPointerCustom;
				}
			}
		}

		private void axTOCControl1_OnMouseUp( object sender, ITOCControlEvents_OnMouseUpEvent e )
		{
			esriTOCControlItem item = esriTOCControlItem.esriTOCControlItemNone;
			IBasicMap map = null;
			ILayer layer = null;
			object other = null;
			object index = null;
			if (e.button == 1)
			{
				axTOCControl1.HitTest( e.x, e.y, ref item, ref map, ref layer, ref other, ref index );
				if (item == esriTOCControlItem.esriTOCControlItemLayer)
				{
					if (_tocSelectedLayer != layer && layer != null)
					{
						axTOCControl1.SelectItem( layer, null );
						axGlobeControl1.Globe.GlobeDisplay.Scene.MoveLayer( _tocSelectedLayer, GetIndexByLayer( layer ) );
						axGlobeControl1.Globe.GlobeDisplay.RefreshViewers();
						axTOCControl1.Refresh();
						axTOCControl1.SelectItem( _tocSelectedLayer, null );
					}
				}
			}
		}

		#endregion

		#region context menu event handlers in toccontrol

		/// <summary>
		/// ���Ա�鿴����¼�
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AttributeTable_Click( object sender, EventArgs e )
		{
			AttributeTable table = new AttributeTable();
			table.Show();
		}

		/// <summary>
		/// �һ��˵���������
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Property_Click( object sender, EventArgs e )
		{
			//PropertyBase property = new PropertyBase( axGlobeControl1.Globe );
			//property.Show();
			DemSetting demSetting = new DemSetting( this );
			demSetting.Show();
		}

		/// <summary>
		/// ��������ѡ��ͼ��
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ZoomToLayer_Click( object sender, EventArgs e )
		{
			ContextRelated context = new ContextRelated( axGlobeControl1.Globe );
			context.ZoomToGlobeLayer( GetIndexByLayer( _tocSelectedLayer ) );
		}

		private int GetIndexByLayer( ILayer layer )
		{
			IScene scene = axGlobeControl1.GlobeDisplay.Scene;
			for (int i = 0; i < scene.LayerCount; i++)
			{
				if (scene.Layer[i] == layer)
				{
					return i;
				}
			}
			return -1;
		}

		private void RemoveLayer_Click( object sender, EventArgs e )
		{
			axGlobeControl1.GlobeDisplay.Scene.DeleteLayer( _tocSelectedLayer );
		}

		#endregion

		public void ChangeElevationHeight( string elevation )
		{
			ILayer layer = _tocSelectedLayer;
			IGlobeDisplayLayers layers = axGlobeControl1.GlobeDisplay as IGlobeDisplayLayers;
			if (layers == null) return;
			IGlobeLayerProperties layerProperties = layers.FindGlobeProperties( layer );
			layerProperties.Type = esriGlobeDataType.esriGlobeDataElevation;
			IGlobeHeightProperties heightProperties = layerProperties.HeightProperties;
			heightProperties.ZFactor = Convert.ToDouble( elevation );
			layers.RefreshLayer( _tocSelectedLayer );
			axGlobeControl1.GlobeDisplay.RefreshViewers();
		}

		public double GetElevationHeight( )
		{
			IGlobeDisplayLayers layers = axGlobeControl1.GlobeDisplay as IGlobeDisplayLayers;
			if (layers != null)
			{
				IGlobeLayerProperties layerProperties = layers.FindGlobeProperties(_tocSelectedLayer);
				if (layerProperties != null)
				{
					layerProperties.Type = esriGlobeDataType.esriGlobeDataElevation;
					IGlobeHeightProperties heightProperties = layerProperties.HeightProperties;
					return heightProperties.ZFactor;
				}
			}
			return -1;
		}
	}
}