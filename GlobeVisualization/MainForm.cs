using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Analyst3D;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.GlobeCore;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.SystemUI;

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
		/// <summary>
		/// Mouse move event handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
			PropertyBase property = new PropertyBase( axGlobeControl1.Globe );
			property.Show();
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

		#endregion
	}
}