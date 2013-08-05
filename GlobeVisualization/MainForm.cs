using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.GlobeCore;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.SystemUI;

namespace GlobeVisualization
{
    public sealed partial class MainForm : Form
    {
        #region private class members
        private IGlobeControl m_globeControl = null;
        private IGlobeViewUtil m_globeViewUtil = null;
        #endregion

        #region calss constructor
        public MainForm()
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
            m_globeControl = axGlobeControl1.Object as IGlobeControl;

            //cast the GlobeViewUtil from the GlobeCamera
            m_globeViewUtil = m_globeControl.GlobeCamera as IGlobeViewUtil;
        }

        #region Main Menu event handlers
        private void menuOpenDoc_Click( object sender, EventArgs e )
        {
            //execute Open Document command
            ICommand command = new ControlsGlobeOpenDocCommandClass();
            command.OnCreate(m_globeControl.Object);
            command.OnClick();
        }

        private void menuExitApp_Click( object sender, EventArgs e )
        {
            //exit the application
            Application.Exit();
        }
        #endregion

        /// <summary>
        /// Mouse move event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axGlobeControl1_OnMouseMove( object sender, IGlobeControlEvents_OnMouseMoveEvent e )
        {
            double dLon, dLat, dAlt;
            //convert the window coordinate into geographic coordinates
            m_globeViewUtil.WindowToGeographic(m_globeControl.GlobeDisplay,
                                               m_globeControl.GlobeDisplay.ActiveViewer,
                                               e.x,
                                               e.y,
                                               true,
                                               out dLon,
                                               out dLat,
                                               out dAlt);

            //report the mouse geographic coordinate onto the statusbar
            statusBarXY.Text = string.Format("{0} {1} {2}", dLon.ToString("###.###"), dLat.ToString("###.###"), dAlt.ToString("###.###"));
        }


    }
}