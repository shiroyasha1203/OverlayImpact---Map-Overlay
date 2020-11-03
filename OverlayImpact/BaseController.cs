using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverlayImpact
{
	public partial class BaseOverlay : Form
	{
		public const string WINDOW_NAME = "Genshin Impact";
		RECT _rect;

		IntPtr _Handle = FindWindow(null, WINDOW_NAME);

		[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
		static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll", EntryPoint = "SetWindowLong")]
		static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll", EntryPoint = "FindWindow")]
		static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
		static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

		public struct RECT
		{
			public int left, top, right, bottom;
		}

		Graphics g;
		Pen myPen = new Pen(Color.Red);

		public BaseOverlay()
		{
			InitializeComponent();
		}

		private void BaseOverlay_Load(object sender, EventArgs e)
		{

			this.BackColor = Color.Black;
			this.TransparencyKey = Color.Black;
			this.TopMost = true;
			
			//this.FormBorderStyle = FormBorderStyle.None;

			int initialState = GetWindowLong(this.Handle, -20);
			SetWindowLong(this.Handle, -20, initialState | 0x80000 | 0x20);

			if (GetWindowRect(_Handle, out _rect))
				this.Size = new Size(_rect.right - _rect.left, _rect.bottom - _rect.top);
			this.Top = _rect.top;
			this.Left = _rect.left;


		}

		private void BaseOverlay_Paint(object sender, PaintEventArgs e)
		{
			g = e.Graphics;
			g.DrawRectangle(myPen, 10, 10, 20, 20);
			g.DrawRectangle(myPen, 50, 50, 270, 270);
		}
	}
}
