using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFListViewSelectedItemBackground;
using XFListViewSelectedItemBackground.iOS;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRenderer))]
namespace XFListViewSelectedItemBackground.iOS
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);

            var selectedBackgroundView = new UIView(cell.SelectedBackgroundView.Bounds);
            selectedBackgroundView.Layer.BackgroundColor = Color.FromRgb(127, 210, 255).ToCGColor(); 
            cell.SelectedBackgroundView = selectedBackgroundView;

            item.ForceUpdateSize();
            return cell;
        }

    }
}
