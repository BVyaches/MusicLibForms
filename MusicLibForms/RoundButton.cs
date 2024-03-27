using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibForms
{
	public class RoundButton : Button
	{
		protected override void OnPaint(PaintEventArgs e)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
			Region = new Region(graphicsPath);
			base.OnPaint(e);
		}
	}
}
