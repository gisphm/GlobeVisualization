using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Analyst3D;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.GlobeCore;
using ESRI.ArcGIS.esriSystem;
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
				MessageBox.Show( "程序或系统出错！" );
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

			//report the mouse geographic coordinate onto the statusbar
			statusBarXY.Text = string.Format( "{0} {1} {2}", dLon.ToString( "###.###" ), dLat.ToString( "###.###" ), dAlt.ToString( "###.###" ) );
		}

		private void axGlobeControl1_OnMouseWheel( object sender, MouseEventArgs e )
		{
			//获取(或设置)axGlobeControl1控件的左上角相对于其容器的左上角的坐标
			Point controlLocation = axGlobeControl1.PointToScreen( axGlobeControl1.Location );
			//获取鼠标的坐标
			Point mouseLocation = PointToScreen( e.Location );
			//如果当前鼠标位置不在axGlobeControl1控件内，返回
			if (mouseLocation.X < controlLocation.X ||
				mouseLocation.X > controlLocation.X + axGlobeControl1.Width ||
				mouseLocation.Y < controlLocation.Y ||
				mouseLocation.Y > controlLocation.Y + axGlobeControl1.Height)
			{
				return;
			}

			//定义缩放倍率
			double scale = 0.2;
			//判断鼠标轮已转动的制动器数的正负，反转则缩小。
			if (e.Delta < 0) scale = -scale;
			//或控件相机
			IGlobeCamera pGlobeCamera = axGlobeControl1.GlobeCamera;
			ICamera pCamera = pGlobeCamera as ICamera;
			if (pCamera == null) return;

			//获取视图
			IGlobeDisplay pGlobeDisplay = axGlobeControl1.GlobeDisplay;
			if (pGlobeDisplay == null) return;

			//如果相机的方向指向globe的北方,全球模式
			if (pGlobeCamera.OrientationMode == esriGlobeCameraOrientationMode.esriGlobeCameraOrientationGlobal)
			{
				double zt, xo, yo, zo;
				//获取表示为十进制纬度和经度，以及公里为单位的高程，的观察者位置。
				pGlobeCamera.GetObserverLatLonAlt( out xo, out yo, out zo );
				//获取给定的地理位置某个点的地面高程,注意经纬度与上个函数相反
				pGlobeDisplay.GetSurfaceElevation( yo, xo, true, out zt );
				//新建观察点
				IPoint pObserver = new PointClass();
				//用既有位置设置观察点坐标
				pObserver.PutCoords( xo, yo );
				//升降观查点高程
				zo = ( zo - zt ) * ( 1 + scale );
				//设置观察点位置，经纬度为十进制度，高程以公里为单位
				pGlobeCamera.SetObserverLatLonAlt( xo, yo, zo );
			}
			else
			{
				//缩放观测距离
				pCamera.ViewingDistance += pCamera.ViewingDistance * scale;
			}
			//刷新视图
			axGlobeControl1.GlobeDisplay.RefreshViewers();
		}

		#endregion

		#region toccontrol events handlers
		/// <summary>
		/// axTOCControl左击选择图层和右击弹出菜单操作
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
		/// 属性表查看点击事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AttributeTable_Click( object sender, EventArgs e )
		{
			AttributeTable table = new AttributeTable();
			table.Show();
		}

		/// <summary>
		/// 右击菜单的属性项
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Property_Click( object sender, EventArgs e )
		{
			//PropertyBase property = new PropertyBase( axGlobeControl1.Globe );
			//property.Show();
			DemSetting demSetting=new DemSetting(this);
			demSetting.Show();
		}

		/// <summary>
		/// 缩放至所选的图层
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
	}
}