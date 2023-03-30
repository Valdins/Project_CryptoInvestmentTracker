using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitcoin
{
    public partial class mainPanel : Form
    {
        //Creates classes
        SafteyCheck safteyCheck = new SafteyCheck();
        MathCalc calculations = new MathCalc();
        string[] currencyValues = { "$", "€", "£" };

        //Current currency
        private string currCurrency;
        private string currCurrencySymbol;

        public mainPanel()
        {
            InitializeComponent();

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Establish connection to API
            APIHelper.InitializeClient();

            //Try to load data from XML file
            if (safteyCheck.CheckIfFileExists())
            {
                try
                {
                    Storage<InsertInfo>.GetDataToXML();
                }
                catch
                {

                }
            }

            //Save latest currency data from API
            calculations.SaveCurrencyData();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }


        private Form activeForm = null;

        private void OpenInsertPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void insertMenubutton_Click(object sender, EventArgs e)
        {
            OpenInsertPanel(new Form2());
        }

        private void homeMenuButton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        private void childFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsgm, int wParam, int lParam);

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximiseButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void mainPanel_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void chooseCurrencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currCurrency != chooseCurrencyComboBox.Text)
            {
                currCurrency = chooseCurrencyComboBox.Text;
                calculations.ChangeCurrentCurrency(currCurrency);

                switch(currCurrency)
                {
                    case "USD": currCurrencySymbol = currencyValues[0];
                        break;
                    case "GBP":
                        currCurrencySymbol = currencyValues[2];
                        break;
                    default:
                        currCurrencySymbol = currencyValues[1];
                        break;
                }
            }

            //Show current portfolio balance
            balanceValueLabel.Text = currCurrencySymbol + " " + calculations.PortfolioValue();
            //Show profit 
            profitValueLabel.Text = currCurrencySymbol + " " + calculations.GetReturnOnInv() + "  (" + calculations.GetReturnOnInvPerc()+ "%)";
            //Show current BTC price
            BTCpriceDisplayLabel.Text = currCurrencySymbol + " " + calculations.CurrentBTCprice();
        }

        private void viewListButton_Click(object sender, EventArgs e)
        {
            OpenInsertPanel(new FormViewAllEntries());
        }

        private void balanceValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProfitPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
