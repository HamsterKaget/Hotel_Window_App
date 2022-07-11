using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanLKS
{
    public partial class MainForm : Form
    {
        public Form1 login;

        public MainForm()
        {
            InitializeComponent();
            login = new Form1();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm passwordForm = new ChangePasswordForm();
            passwordForm.Show();
        }

        private void bookingRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingRoomForm bookingRoom = new BookingRoomForm();
            bookingRoom.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roomManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBookingForm manageRoom = new ManageBookingForm();
            manageRoom.Show();
        }

        private void inputPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputPaymentForm inputPayment = new InputPaymentForm();
            inputPayment.Show();
        }

        private void viewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPaymentForm viewPayment = new ViewPaymentForm();
            viewPayment.Show();
        }

        private void manageRoomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomTypeForm manageRoomType = new ManageRoomTypeForm();
            manageRoomType.Show();
        }

        private void manageRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomForm manageRoom = new ManageRoomForm();
            manageRoom.Show();
        }

        private void manageRoomFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomFacilityForm manageRoomFacility = new ManageRoomFacilityForm();
            manageRoomFacility.Show();
        }

        private void manageRoomRepairmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomRepairmentForm manageRoomRepairment = new ManageRoomRepairmentForm();
            manageRoomRepairment.Show();
        }

        private void managePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDailyPriceForm manageDailyPrice = new ManageDailyPriceForm();
            manageDailyPrice.Show();
        }

        private void manageHolidayPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageHolidayPriceForm manageHolidayPrice = new ManageHolidayPriceForm();
            manageHolidayPrice.Show();
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployeeForm manageEmployee = new ManageEmployeeForm();
            manageEmployee.Show();
        }

        private void manageGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageGuestForm manageGuest = new ManageGuestForm();
            manageGuest.Show();
        }
    }
}
