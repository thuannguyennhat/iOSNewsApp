using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace iOSNewsApp
{
    public class ListNewsTableViewSource : UITableViewSource
    {
        private string CellIdentifier = "TableCell";
        
        public string[] Items { get; set; }

        public ListNewsTableViewSource()
        {
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = Items[indexPath.Row];

            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            }
            cell.TextLabel.Text = item;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Items.Length;
        }
    }
}
