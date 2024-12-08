using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class ListViewEx : ListView
	{
		public ContextMenuStrip HeaderContextMenu { get; set; }

		public ListViewEx() : base()
		{
			HeaderContextMenu = null;
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg == 0x7b) // context menu
			{
				if (m.WParam != this.Handle) HeaderContextMenu.Show(Control.MousePosition);
			}
		}
	}
}
