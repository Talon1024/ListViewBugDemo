using System;
using System.Windows.Forms;

namespace ListViewTest
{
    public class MainWindow : Form
    {
        ListView mapslist;
        public MainWindow()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Level name";
            columnHeader1.Width = -1;
            this.mapslist = new ListView();
            this.mapslist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mapslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1});
            this.mapslist.FullRowSelect = true;
            this.mapslist.HeaderStyle = ColumnHeaderStyle.None;
            this.mapslist.HideSelection = false;
            this.mapslist.LabelWrap = false;
            this.mapslist.Location = new System.Drawing.Point(12, 122);
            this.mapslist.MultiSelect = false;
            this.mapslist.Name = "mapslist";
            this.mapslist.ShowGroups = false;
            this.mapslist.Size = new System.Drawing.Size(396, 118);
            this.mapslist.Sorting = SortOrder.Ascending;
            this.mapslist.TabIndex = 1;
            this.mapslist.UseCompatibleStateImageBehavior = false;
            this.mapslist.View = View.List;

            mapslist.BeginUpdate();
            mapslist.Items.Clear();
            for (int i = 0; i <= 20; i++)
            {
                string itemText = String.Format("ITEM{0,2:D2}", i);
                mapslist.Items.Add(itemText);
            }
            mapslist.Sort();
            mapslist.EndUpdate();

            Controls.Add(mapslist);
        }
    }

    public class ListViewTest
    { 
        public static void Main(string[] args)
        {
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }
    }
}
