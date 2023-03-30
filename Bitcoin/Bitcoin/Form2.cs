using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bitcoin
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void insertDataButton_Click(object sender, EventArgs e)
        {
            DateTime dateInput = new DateTime(purchaseDateTimePicker.Value.Year, purchaseDateTimePicker.Value.Month, (int)purchaseDateTimePicker.Value.DayOfWeek);
            InsertInfo userInputData = new InsertInfo(dateInput.ToShortDateString(), decimal.Parse(amountBoughtTextBox.Text), decimal.Parse(feeTextBox.Text), decimal.Parse(pricePerCoinTextBox.Text));
            Storage<InsertInfo>.AddDataToList(userInputData);
        }
    }
}
