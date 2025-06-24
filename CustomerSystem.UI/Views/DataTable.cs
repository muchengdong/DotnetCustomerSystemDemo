using System.ComponentModel;
using System.Windows.Forms.Design;
using AntdUI;

namespace CustomerSystem.UI.Views {
    [Description("DataTable 面板")]
    [ToolboxItem(true)]
    [Designer(typeof(ParentControlDesigner))]
    public class DataTable : GridPanel {
        public DataTable() {
            ContentPanel = new Panel();
            ContentPanel.AllowDrop = true;
            Controls.Add(ContentPanel);
        }

        [Browsable(true)] [Category("Layout")] public Panel ContentPanel { get; }
    }
}