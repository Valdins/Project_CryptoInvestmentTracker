using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bitcoin
{
    public partial class FormViewAllEntries : Form
    {
        public FormViewAllEntries()
        {
            InitializeComponent();
        }

        private void FormViewAllEntries_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            if (Storage<InsertInfo>.getList().Count != 0)
            {
                List<InsertInfo> displayAllEntries = new List<InsertInfo>();
                Storage<InsertInfo>.ListForDisplay(ref displayAllEntries);

                listViewAllEntries.Items.Clear();
                foreach (InsertInfo en in displayAllEntries)
                {
                    string[] row = new string[] { en.PurchaseDate.ToString(), en.AmountBought.ToString(), en.FeePaid.ToString(), en.PricePerCoin.ToString() };
                    ListViewItem lvi = new ListViewItem(row);
                    lvi.Tag = en.ID;
                    listViewAllEntries.Items.Add(lvi);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string temp = listViewAllEntries.SelectedItems[0].Tag.ToString();
            int currentID = Convert.ToInt32(temp);
            Storage<InsertInfo>.RemoveDataToList(currentID);

            UpdateListView();
        }
    }
}
