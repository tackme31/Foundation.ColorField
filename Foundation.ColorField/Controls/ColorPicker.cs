using Sitecore.Globalization;
using Sitecore.Shell.Applications.ContentEditor;
using System.Web.UI;

namespace Foundation.ColorField.Controls
{
    public class ColorPicker : Text
    {
        public ColorPicker()
        {
            Class = "scContentControlColorPicker scContentControl";
            Width = new System.Web.UI.WebControls.Unit(100);
        }

        protected override void DoRender(HtmlTextWriter output)
        {
            Attributes["placeholder"] = Translate.Text(Placeholder);
            SetWidthAndHeightStyle();
            output.Write("<input" + ControlAttributes + " type=\"color\">");
            RenderChildren(output);
        }
    }
}