using System;
using System.Windows.Forms;

namespace GlobeVisualization
{
	public partial class DemSetting : Form
	{
		private readonly MainForm _dMainForm;
		public DemSetting( MainForm mainForm )
		{
			InitializeComponent();
			if (mainForm == null || tboxFactor == null) return;
			_dMainForm = mainForm;
			double height = _dMainForm.GetElevationHeight();
			if (height < 0)
			{
				MessageBox.Show("系统或程序出错！");
				return;
			}
			tboxFactor.Text = height.ToString();
		}

		private void btnClose_Click( object sender, EventArgs e )
		{
			Close();
		}

		private void btnOk_Click( object sender, EventArgs e )
		{
			if (tboxFactor == null) return;
			_dMainForm.ChangeElevationHeight(tboxFactor.Text);
			Close();
		}

		private void tboxFactor_KeyPress( object sender, KeyPressEventArgs e )
		{
			if (tboxFactor == null) return;
			bool isDot = DotInString( tboxFactor.Text );
			if (isDot)
			{
				if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
				{
					MessageBox.Show( "只能输入数字0~9！", "信息",
						MessageBoxButtons.OK, MessageBoxIcon.Information );
					e.Handled = true;
				}
			}
			else
			{
				if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 46)
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
