using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobeVisualization
{
	public partial class DemSetting : Form
	{
		private MainForm _dMainForm;
		public DemSetting( MainForm mainForm )
		{
			InitializeComponent();
			if (mainForm == null || tboxFactor == null) return;
			_dMainForm = mainForm;
			tboxFactor.Text = "0.000";
		}

		private void btnClose_Click( object sender, EventArgs e )
		{
			Close();
		}

		private void btnOk_Click( object sender, EventArgs e )
		{
			if (tboxFactor == null) return;
			Close();
		}

		private void tboxFactor_KeyPress( object sender, KeyPressEventArgs e )
		{
			if (tboxFactor == null) return;
			bool isDot = DotInString( tboxFactor.Text );
			if (isDot)
			{
				if (e.KeyChar < 48 || e.KeyChar > 57 || e.KeyChar != 8 || e.KeyChar != 13)
				{
					MessageBox.Show( "只能输入数字0~9！", "信息",
						MessageBoxButtons.OK, MessageBoxIcon.Information );
					e.Handled = true;
				}
			}
			else
			{
				if (e.KeyChar < 48 || e.KeyChar > 57 || e.KeyChar != 8 || e.KeyChar != 13 || e.KeyChar != 46)
				{
					MessageBox.Show( "只能输入 . 或数字 0~9！", "信息",
						MessageBoxButtons.OK, MessageBoxIcon.Information );
					e.Handled = true;
				}
			}
		}

		private bool DotInString( string s )
		{
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '.')
					return true;
			}
			return false;
		}

		private void tboxFactor_TextChanged( object sender, EventArgs e )
		{
			if (tboxFactor.Text == "")
			{
				btnOk.Enabled = false;
			}
			else
			{
				btnOk.Enabled = true;
			}
		}
	}
}
