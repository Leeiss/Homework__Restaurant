using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework__Restaurant
{
    public partial class InfoBooking : Form
    {
        public InfoBooking()
        {
            InitializeComponent();
        }

        public new string Name
        {
            get { return infolb_name.Text; }
            set { infolb_name.Text = value; }
        }
        public new string Table
        {
            get { return infolb_name.Text; }
            set { infolb_table.Text = value; }
        }
        public new string Date
        {
            get { return infolb_name.Text; }
            set { infolb_date.Text = value; }
        }
        public new string Status
        {
            get { return infolb_name.Text; }
            set { infolb_status.Text = value; }
        }
        public new string Event
        {
            get { return infolb_name.Text; }
            set { infolb_event.Text = value; }
        }
    }
}
