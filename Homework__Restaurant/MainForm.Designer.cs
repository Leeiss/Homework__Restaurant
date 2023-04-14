namespace Homework__Restaurant
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            lbl_restaurant = new Label();
            panel1 = new Panel();
            upper_panel = new FlowLayoutPanel();
            splitContainer = new SplitContainer();
            lbl_menu = new Label();
            menu_tree = new TreeView();
            mainpicture = new PictureBox();
            tabControl = new TabControl();
            download_page = new TabPage();
            download_btn = new Button();
            guests_list = new ListBox();
            guests_lbl = new Label();
            booking_lbl = new Label();
            booking_list = new ListBox();
            show_page = new TabPage();
            dataGridView_booking = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridView_guests = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            cancel_page = new TabPage();
            close_btn = new Button();
            fio = new DataGridViewTextBoxColumn();
            table = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainpicture).BeginInit();
            tabControl.SuspendLayout();
            download_page.SuspendLayout();
            show_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_booking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_guests).BeginInit();
            cancel_page.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_restaurant
            // 
            lbl_restaurant.AutoSize = true;
            lbl_restaurant.Font = new Font("Vivaldi", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_restaurant.ForeColor = Color.FromArgb(112, 151, 171);
            lbl_restaurant.Location = new Point(48, -2);
            lbl_restaurant.Name = "lbl_restaurant";
            lbl_restaurant.Size = new Size(284, 76);
            lbl_restaurant.TabIndex = 0;
            lbl_restaurant.Text = "Restaurant";
            // 
            // panel1
            // 
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1630, 27);
            panel1.TabIndex = 1;
            // 
            // upper_panel
            // 
            upper_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            upper_panel.BackColor = Color.FromArgb(112, 151, 171);
            upper_panel.Location = new Point(-1, 30);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(1592, 16);
            upper_panel.TabIndex = 0;
            // 
            // splitContainer
            // 
            splitContainer.Location = new Point(-1, 62);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(lbl_menu);
            splitContainer.Panel1.Controls.Add(menu_tree);
            splitContainer.Panel1.Controls.Add(mainpicture);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tabControl);
            splitContainer.Size = new Size(1606, 1114);
            splitContainer.SplitterDistance = 418;
            splitContainer.TabIndex = 2;
            splitContainer.TabStop = false;
            splitContainer.Paint += SplitterColor;
            // 
            // lbl_menu
            // 
            lbl_menu.AutoSize = true;
            lbl_menu.ForeColor = Color.Gray;
            lbl_menu.Location = new Point(13, 312);
            lbl_menu.Name = "lbl_menu";
            lbl_menu.Size = new Size(83, 32);
            lbl_menu.TabIndex = 1;
            lbl_menu.Text = "Меню";
            // 
            // menu_tree
            // 
            menu_tree.BackColor = Color.FromArgb(221, 224, 221);
            menu_tree.BorderStyle = BorderStyle.None;
            menu_tree.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            menu_tree.ForeColor = Color.FromArgb(84, 113, 128);
            menu_tree.Location = new Point(13, 347);
            menu_tree.Name = "menu_tree";
            menu_tree.Size = new Size(380, 587);
            menu_tree.TabIndex = 0;
            menu_tree.AfterSelect += menu_tree_AfterSelect;
            // 
            // mainpicture
            // 
            mainpicture.Image = (Image)resources.GetObject("mainpicture.Image");
            mainpicture.Location = new Point(-19, -28);
            mainpicture.Name = "mainpicture";
            mainpicture.Size = new Size(412, 372);
            mainpicture.TabIndex = 2;
            mainpicture.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(download_page);
            tabControl.Controls.Add(show_page);
            tabControl.Controls.Add(cancel_page);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1184, 1114);
            tabControl.TabIndex = 13;
            // 
            // download_page
            // 
            download_page.BackColor = Color.FromArgb(250, 244, 235);
            download_page.Controls.Add(download_btn);
            download_page.Controls.Add(guests_list);
            download_page.Controls.Add(guests_lbl);
            download_page.Controls.Add(booking_lbl);
            download_page.Controls.Add(booking_list);
            download_page.Font = new Font("XO Courser", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            download_page.Location = new Point(8, 46);
            download_page.Name = "download_page";
            download_page.Padding = new Padding(3);
            download_page.RightToLeft = RightToLeft.No;
            download_page.Size = new Size(1168, 1060);
            download_page.TabIndex = 0;
            download_page.Text = "Загрузить";
            // 
            // download_btn
            // 
            download_btn.BackColor = Color.FromArgb(221, 224, 221);
            download_btn.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            download_btn.ForeColor = Color.FromArgb(84, 113, 128);
            download_btn.Location = new Point(914, 965);
            download_btn.Name = "download_btn";
            download_btn.Size = new Size(224, 48);
            download_btn.TabIndex = 21;
            download_btn.Text = "Загрузить";
            download_btn.UseVisualStyleBackColor = false;
            download_btn.Visible = false;
            download_btn.Click += download_btn_Click;
            // 
            // guests_list
            // 
            guests_list.BackColor = Color.FromArgb(221, 224, 221);
            guests_list.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            guests_list.ForeColor = Color.FromArgb(84, 113, 128);
            guests_list.FormattingEnabled = true;
            guests_list.ItemHeight = 34;
            guests_list.Items.AddRange(new object[] { "Столики 1-10 ", "Столики 10-20 ", "Столики 20-30" });
            guests_list.Location = new Point(35, 503);
            guests_list.Name = "guests_list";
            guests_list.Size = new Size(1049, 140);
            guests_list.TabIndex = 20;
            guests_list.SelectedIndexChanged += guests_list_SelectedIndexChanged;
            // 
            // guests_lbl
            // 
            guests_lbl.AutoSize = true;
            guests_lbl.Font = new Font("PT Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            guests_lbl.ForeColor = Color.Gray;
            guests_lbl.Location = new Point(35, 447);
            guests_lbl.Name = "guests_lbl";
            guests_lbl.Size = new Size(541, 42);
            guests_lbl.TabIndex = 19;
            guests_lbl.Text = "Гости зале (загрузка с JSON-файла)";
            // 
            // booking_lbl
            // 
            booking_lbl.AutoSize = true;
            booking_lbl.Font = new Font("PT Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            booking_lbl.ForeColor = Color.Gray;
            booking_lbl.Location = new Point(35, 130);
            booking_lbl.Name = "booking_lbl";
            booking_lbl.Size = new Size(468, 42);
            booking_lbl.TabIndex = 3;
            booking_lbl.Text = "Бронь (загрузка с XML-файла)";
            // 
            // booking_list
            // 
            booking_list.BackColor = Color.FromArgb(221, 224, 221);
            booking_list.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            booking_list.ForeColor = Color.FromArgb(84, 113, 128);
            booking_list.FormattingEnabled = true;
            booking_list.ItemHeight = 34;
            booking_list.Items.AddRange(new object[] { "Сегодня ", "Завтра ", "Позднее " });
            booking_list.Location = new Point(35, 190);
            booking_list.Name = "booking_list";
            booking_list.Size = new Size(1049, 140);
            booking_list.TabIndex = 18;
            booking_list.SelectedIndexChanged += booking_list_SelectedIndexChanged;
            // 
            // show_page
            // 
            show_page.BackColor = Color.FromArgb(250, 244, 235);
            show_page.Controls.Add(dataGridView_booking);
            show_page.Controls.Add(dataGridView_guests);
            show_page.Location = new Point(8, 46);
            show_page.Name = "show_page";
            show_page.Padding = new Padding(3);
            show_page.Size = new Size(1168, 1060);
            show_page.TabIndex = 3;
            show_page.Text = "Показать";
            // 
            // dataGridView_booking
            // 
            dataGridView_booking.AllowUserToAddRows = false;
            dataGridView_booking.AllowUserToDeleteRows = false;
            dataGridView_booking.BackgroundColor = Color.FromArgb(221, 224, 221);
            dataGridView_booking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_booking.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, date, dataGridViewTextBoxColumn5 });
            dataGridView_booking.Location = new Point(14, 61);
            dataGridView_booking.Name = "dataGridView_booking";
            dataGridView_booking.ReadOnly = true;
            dataGridView_booking.RowHeadersWidth = 82;
            dataGridView_booking.RowTemplate.Height = 41;
            dataGridView_booking.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_booking.Size = new Size(1138, 899);
            dataGridView_booking.TabIndex = 11;
            dataGridView_booking.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(112, 151, 171);
            dataGridViewCellStyle1.Font = new Font("PT Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn3.HeaderText = "ФИО";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("PT Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn4.HeaderText = "Номер столика";
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 227;
            // 
            // date
            // 
            date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("PT Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            date.DefaultCellStyle = dataGridViewCellStyle3;
            date.HeaderText = "Дата";
            date.MinimumWidth = 10;
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("PT Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn5.HeaderText = "Статус";
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 129;
            // 
            // dataGridView_guests
            // 
            dataGridView_guests.AllowUserToAddRows = false;
            dataGridView_guests.AllowUserToDeleteRows = false;
            dataGridView_guests.BackgroundColor = Color.FromArgb(221, 224, 221);
            dataGridView_guests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_guests.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, Column1 });
            dataGridView_guests.Location = new Point(14, 61);
            dataGridView_guests.Name = "dataGridView_guests";
            dataGridView_guests.ReadOnly = true;
            dataGridView_guests.RowHeadersWidth = 82;
            dataGridView_guests.RowTemplate.Height = 41;
            dataGridView_guests.Size = new Size(1138, 899);
            dataGridView_guests.TabIndex = 10;
            dataGridView_guests.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(112, 151, 171);
            dataGridViewCellStyle5.Font = new Font("PT Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.WhiteSmoke;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTextBoxColumn7.HeaderText = "Столик";
            dataGridViewTextBoxColumn7.MinimumWidth = 10;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 137;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("PT Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTextBoxColumn9.HeaderText = "Кол-во человек";
            dataGridViewTextBoxColumn9.MinimumWidth = 10;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 216;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.Font = new Font("PT Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTextBoxColumn10.HeaderText = "Оплата";
            dataGridViewTextBoxColumn10.MinimumWidth = 10;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle8.Font = new Font("PT Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Column1.DefaultCellStyle = dataGridViewCellStyle8;
            Column1.HeaderText = "Статус";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // cancel_page
            // 
            cancel_page.BackColor = Color.FromArgb(250, 244, 235);
            cancel_page.Controls.Add(close_btn);
            cancel_page.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_page.Location = new Point(8, 46);
            cancel_page.Name = "cancel_page";
            cancel_page.Size = new Size(1168, 1060);
            cancel_page.TabIndex = 2;
            cancel_page.Text = "Закрыть";
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.FromArgb(221, 224, 221);
            close_btn.Font = new Font("PT Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            close_btn.ForeColor = Color.FromArgb(84, 113, 128);
            close_btn.Location = new Point(411, 425);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(365, 134);
            close_btn.TabIndex = 0;
            close_btn.Text = "Закрыть программу";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // fio
            // 
            fio.HeaderText = "ФИО";
            fio.MinimumWidth = 10;
            fio.Name = "fio";
            fio.Width = 200;
            // 
            // table
            // 
            table.HeaderText = "Столик";
            table.MinimumWidth = 10;
            table.Name = "table";
            table.Width = 200;
            // 
            // status
            // 
            status.HeaderText = "Статус";
            status.MinimumWidth = 10;
            status.Name = "status";
            status.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(112, 151, 171);
            dataGridViewCellStyle9.Font = new Font("PT Serif", 7.875F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.WhiteSmoke;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTextBoxColumn2.HeaderText = "Номер столика";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 244, 235);
            ClientSize = new Size(1593, 1175);
            Controls.Add(lbl_restaurant);
            Controls.Add(upper_panel);
            Controls.Add(panel1);
            Controls.Add(splitContainer);
            MaximumSize = new Size(1619, 1246);
            Name = "MainForm";
            Text = "Restaurant";
            Resize += MainForm_Resize;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)mainpicture).EndInit();
            tabControl.ResumeLayout(false);
            download_page.ResumeLayout(false);
            download_page.PerformLayout();
            show_page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_booking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_guests).EndInit();
            cancel_page.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_restaurant;
        private Panel panel1;
        private FlowLayoutPanel upper_panel;
        private SplitContainer splitContainer;
        private TreeView menu_tree;
        private Label lbl_menu;
        private PictureBox mainpicture;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button add_btn;
        private TabControl tabControl;
        private TabPage download_page;
        private TabPage cancel_page;
        private ListBox guests_list;
        private Label guests_lbl;
        private Label booking_lbl;
        private ListBox booking_list;
        private DataGridViewTextBoxColumn fio;
        private DataGridViewTextBoxColumn table;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button download_btn;
        private TabPage show_page;
        private DataGridView dataGridView_booking;
        private DataGridView dataGridView_guests;
        private Button close_btn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}