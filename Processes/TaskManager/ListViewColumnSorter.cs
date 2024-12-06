using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	internal class ListViewColumnSorter : IComparer
	{
		int sortColumn;
		SortOrder sortOrder;
		CaseInsensitiveComparer caseInsensitiveComparer;

		public int SortColumn
		{
			get => sortColumn;
			set => sortColumn = value;
		}

		public SortOrder Order
		{
			get => sortOrder;
			set => sortOrder = value;
		}

		public ListViewColumnSorter()
		{
			sortColumn = 0;
			sortOrder = SortOrder.None;
			caseInsensitiveComparer = new CaseInsensitiveComparer();
		}

		public int Compare(object x, object y)
		{
			int result;
			ListViewItem itemX = (ListViewItem)x;
			ListViewItem itemY = (ListViewItem)y;

			if (double.TryParse(itemX.SubItems[sortColumn].Text, out _))
			{
				result = caseInsensitiveComparer.Compare
					(
						Convert.ToDouble(itemX.SubItems[sortColumn].Text),
						Convert.ToDouble(itemY.SubItems[sortColumn].Text)
					);
			}
			else
			{
				result = caseInsensitiveComparer.Compare(itemX.SubItems[sortColumn].Text, itemY.SubItems[sortColumn].Text);
			}


			if (sortOrder == SortOrder.Ascending) return result;
			else if (sortOrder == SortOrder.Descending) return (-result);
			else return 0;
		}
	}
}