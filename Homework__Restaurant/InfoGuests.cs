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
    public partial class InfoGuests : Form
    {
        public InfoGuests()
        {
            InitializeComponent();
        }

        public new string Table
        {
            get { return infolb_table.Text; }
            set { infolb_table.Text = value; }
        }
        public new string Order
        {
            get { return infolb_order.Text; }
            set { infolb_order.Text = value; }
        }
        public new string Persons
        {
            get { return infolb_persons.Text; }
            set { infolb_persons.Text = value; }
        }
        public new string Status
        {
            get { return infolb_status.Text; }
            set { infolb_status.Text = value; }
        }
        public new string Payment
        {
            get { return infolb_payment.Text; }
            set { infolb_payment.Text = value; }
        }

    }
}
