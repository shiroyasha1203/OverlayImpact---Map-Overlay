using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverlayImpact
{
	public partial class StartUp : Form
	{
		BaseOverlay Form = new BaseOverlay();
		public StartUp()
		{
			InitializeComponent();
		}

		private void chkOverlay_CheckedChanged(object sender, EventArgs e)
		{
			if (chkOverlay.Checked)
			{
				Form.Show();
			}
			else
			{
				Form.Hide();
			}

		}
	}
}
