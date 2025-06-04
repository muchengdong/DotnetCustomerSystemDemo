using System.ComponentModel;
using System.Windows.Forms.Design;
using AntdUI;

namespace CustomerSystem.UI.Views {


    [Description("DataTable 面板")]
    [ToolboxItem(true)]
    [Designer(typeof(ParentControlDesigner))]
    public class DataTable : AntdUI.GridPanel{


        private Panel _pnlContent;

        [Browsable(true), Category("Layout")]

        public Panel ContentPanel => this._pnlContent;

        public DataTable() {

            _pnlContent = new Panel();
            _pnlContent.AllowDrop = true;
            this.Controls.Add(this._pnlContent);
        }
    }
}
