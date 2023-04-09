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
            TreeNode treeNode15 = new TreeNode("Бронь");
            TreeNode treeNode16 = new TreeNode("Гости в зале");
            TreeNode treeNode17 = new TreeNode("Архив посетителей");
            TreeNode treeNode18 = new TreeNode("Хостес");
            TreeNode treeNode19 = new TreeNode("Бармены");
            TreeNode treeNode20 = new TreeNode("Менеджеры");
            TreeNode treeNode21 = new TreeNode("Бухгатерия");
            TreeNode treeNode22 = new TreeNode("Маркетологи");
            TreeNode treeNode23 = new TreeNode("Зал", new TreeNode[] { treeNode18, treeNode19, treeNode20, treeNode21, treeNode22 });
            TreeNode treeNode24 = new TreeNode("Официанты");
            TreeNode treeNode25 = new TreeNode("Повара");
            TreeNode treeNode26 = new TreeNode("Разнорабочие");
            TreeNode treeNode27 = new TreeNode("Кухня", new TreeNode[] { treeNode24, treeNode25, treeNode26 });
            TreeNode treeNode28 = new TreeNode("Сотрудники", new TreeNode[] { treeNode23, treeNode27 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            lbl_restaurant = new Label();
            panel1 = new Panel();
            upper_panel = new FlowLayoutPanel();
            upper_panel1 = new FlowLayoutPanel();
            splitContainer = new SplitContainer();
            lbl_menu = new Label();
            menu_tree = new TreeView();
            pictureBox1 = new PictureBox();
            close_table_btn = new Button();
            info_btn = new Button();
            reserveplace_btn = new Button();
            delete_btn = new Button();
            lbl_date = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView_reservedplace = new DataGridView();
            dataGridView_guests = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridView_archive = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridView_employees = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            change_btn = new Button();
            guest_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reservedplace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_guests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_archive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_employees).BeginInit();
            SuspendLayout();
            // 
            // lbl_restaurant
            // 
            lbl_restaurant.AutoSize = true;
            lbl_restaurant.Font = new Font("Vivaldi", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_restaurant.ForeColor = Color.FromArgb(112, 151, 171);
            lbl_restaurant.Location = new Point(48, 24);
            lbl_restaurant.Name = "lbl_restaurant";
            lbl_restaurant.Size = new Size(284, 76);
            lbl_restaurant.TabIndex = 0;
            lbl_restaurant.Text = "Restaurant";
            // 
            // panel1
            // 
            panel1.Controls.Add(upper_panel);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1630, 27);
            panel1.TabIndex = 1;
            // 
            // upper_panel
            // 
            upper_panel.BackColor = Color.FromArgb(112, 151, 171);
            upper_panel.Location = new Point(0, 3);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(1853, 15);
            upper_panel.TabIndex = 0;
            // 
            // upper_panel1
            // 
            upper_panel1.BackColor = Color.FromArgb(112, 151, 171);
            upper_panel1.Location = new Point(-1, 62);
            upper_panel1.Name = "upper_panel1";
            upper_panel1.Size = new Size(1853, 15);
            upper_panel1.TabIndex = 1;
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
            splitContainer.Panel1.Controls.Add(pictureBox1);
            splitContainer.Panel1.Paint += splitContainer_Panel1_Paint;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(close_table_btn);
            splitContainer.Panel2.Controls.Add(info_btn);
            splitContainer.Panel2.Controls.Add(reserveplace_btn);
            splitContainer.Panel2.Controls.Add(guest_btn);
            splitContainer.Panel2.Controls.Add(lbl_date);
            splitContainer.Panel2.Controls.Add(dateTimePicker1);
            splitContainer.Panel2.Controls.Add(dataGridView_reservedplace);
            splitContainer.Panel2.Controls.Add(dataGridView_guests);
            splitContainer.Panel2.Controls.Add(dataGridView_archive);
            splitContainer.Panel2.Controls.Add(dataGridView_employees);
            splitContainer.Panel2.Controls.Add(change_btn);
            splitContainer.Panel2.Controls.Add(delete_btn);
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
            treeNode15.Name = "Узел0";
            treeNode15.Text = "Бронь";
            treeNode16.Name = "Guests";
            treeNode16.Text = "Гости в зале";
            treeNode17.Name = "Узел8";
            treeNode17.Text = "Архив посетителей";
            treeNode18.Name = "Узел1";
            treeNode18.Text = "Хостес";
            treeNode19.Name = "Accounting";
            treeNode19.Text = "Бармены";
            treeNode20.Name = "Узел3";
            treeNode20.Text = "Менеджеры";
            treeNode21.Name = "Узел4";
            treeNode21.Text = "Бухгатерия";
            treeNode22.Name = "Узел6";
            treeNode22.Text = "Маркетологи";
            treeNode23.Name = "Administration";
            treeNode23.Text = "Зал";
            treeNode24.Name = "Узел5";
            treeNode24.Text = "Официанты";
            treeNode25.Name = "Узел2";
            treeNode25.Text = "Повара";
            treeNode26.Name = "Узел7";
            treeNode26.Text = "Разнорабочие";
            treeNode27.Name = "Kitchen";
            treeNode27.Text = "Кухня";
            treeNode28.Name = "Employees";
            treeNode28.Text = "Сотрудники";
            menu_tree.Nodes.AddRange(new TreeNode[] { treeNode15, treeNode16, treeNode17, treeNode28 });
            menu_tree.Size = new Size(380, 587);
            menu_tree.TabIndex = 0;
            menu_tree.NodeMouseClick += ShowTable;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-19, -28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 372);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // close_table_btn
            // 
            close_table_btn.BackColor = Color.FromArgb(221, 224, 221);
            close_table_btn.Font = new Font("PT Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            close_table_btn.Location = new Point(543, 1035);
            close_table_btn.Name = "close_table_btn";
            close_table_btn.Size = new Size(302, 46);
            close_table_btn.TabIndex = 12;
            close_table_btn.Text = "Закрыть стол";
            close_table_btn.UseVisualStyleBackColor = false;
            close_table_btn.Visible = false;
            // 
            // info_btn
            // 
            info_btn.BackColor = Color.FromArgb(221, 224, 221);
            info_btn.Font = new Font("PT Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            info_btn.Location = new Point(19, 1035);
            info_btn.Name = "info_btn";
            info_btn.Size = new Size(387, 46);
            info_btn.TabIndex = 10;
            info_btn.Text = "Просмотреть информацию";
            info_btn.UseVisualStyleBackColor = false;
            info_btn.Visible = false;
            // 
            // reserveplace_btn
            // 
            reserveplace_btn.BackColor = Color.FromArgb(221, 224, 221);
            reserveplace_btn.Font = new Font("PT Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reserveplace_btn.Location = new Point(543, 1035);
            reserveplace_btn.Name = "reserveplace_btn";
            reserveplace_btn.Size = new Size(302, 46);
            reserveplace_btn.TabIndex = 7;
            reserveplace_btn.Text = "Зарезервировать";
            reserveplace_btn.UseVisualStyleBackColor = false;
            reserveplace_btn.Visible = false;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.FromArgb(221, 224, 221);
            delete_btn.Font = new Font("PT Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            delete_btn.Location = new Point(865, 1035);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(302, 46);
            delete_btn.TabIndex = 6;
            delete_btn.Text = "Удалить бронь";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Visible = false;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.ForeColor = Color.Gray;
            lbl_date.Location = new Point(20, 23);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(65, 32);
            lbl_date.TabIndex = 2;
            lbl_date.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CalendarForeColor = Color.FromArgb(84, 113, 128);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(221, 224, 221);
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(112, 151, 171);
            dateTimePicker1.Font = new Font("PT Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(20, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 1;
            // 
            // dataGridView_reservedplace
            // 
            dataGridView_reservedplace.AllowUserToDeleteRows = false;
            dataGridView_reservedplace.BackgroundColor = Color.FromArgb(221, 224, 221);
            dataGridView_reservedplace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_reservedplace.Location = new Point(20, 113);
            dataGridView_reservedplace.Name = "dataGridView_reservedplace";
            dataGridView_reservedplace.RowHeadersWidth = 82;
            dataGridView_reservedplace.RowTemplate.Height = 41;
            dataGridView_reservedplace.Size = new Size(1147, 899);
            dataGridView_reservedplace.TabIndex = 0;
            dataGridView_reservedplace.Visible = false;
            // 
            // dataGridView_guests
            // 
            dataGridView_guests.AllowUserToDeleteRows = false;
            dataGridView_guests.BackgroundColor = Color.FromArgb(221, 224, 221);
            dataGridView_guests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_guests.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView_guests.Location = new Point(19, 108);
            dataGridView_guests.Name = "dataGridView_guests";
            dataGridView_guests.RowHeadersWidth = 82;
            dataGridView_guests.RowTemplate.Height = 41;
            dataGridView_guests.Size = new Size(1147, 899);
            dataGridView_guests.TabIndex = 5;
            dataGridView_guests.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(112, 151, 171);
            dataGridViewCellStyle13.Font = new Font("PT Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.WhiteSmoke;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 112;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTextBoxColumn2.HeaderText = "Номер столика";
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 227;
            // 
            // dataGridView_archive
            // 
            dataGridView_archive.AllowUserToDeleteRows = false;
            dataGridView_archive.BackgroundColor = Color.FromArgb(221, 224, 221);
            dataGridView_archive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_archive.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dataGridView_archive.Location = new Point(35, 124);
            dataGridView_archive.Name = "dataGridView_archive";
            dataGridView_archive.RowHeadersWidth = 82;
            dataGridView_archive.RowTemplate.Height = 41;
            dataGridView_archive.Size = new Size(1147, 899);
            dataGridView_archive.TabIndex = 9;
            dataGridView_archive.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(112, 151, 171);
            dataGridViewCellStyle15.Font = new Font("PT Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.WhiteSmoke;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn7.HeaderText = "ФИО";
            dataGridViewTextBoxColumn7.MinimumWidth = 10;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 112;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn8.HeaderText = "Номер столика";
            dataGridViewTextBoxColumn8.MinimumWidth = 10;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 208;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = Color.White;
            dataGridViewCellStyle17.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn9.HeaderText = "Сумма заказа";
            dataGridViewTextBoxColumn9.MinimumWidth = 10;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 192;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle18.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewTextBoxColumn10.HeaderText = "Дата";
            dataGridViewTextBoxColumn10.MinimumWidth = 10;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridView_employees
            // 
            dataGridView_employees.AllowUserToDeleteRows = false;
            dataGridView_employees.BackgroundColor = Color.FromArgb(221, 224, 221);
            dataGridView_employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_employees.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Column5, Column6 });
            dataGridView_employees.Location = new Point(27, 116);
            dataGridView_employees.Name = "dataGridView_employees";
            dataGridView_employees.RowHeadersWidth = 82;
            dataGridView_employees.RowTemplate.Height = 41;
            dataGridView_employees.Size = new Size(1147, 899);
            dataGridView_employees.TabIndex = 8;
            dataGridView_employees.Visible = false;
            dataGridView_employees.CellContentClick += dataGridView_employees_CellContentClick;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(112, 151, 171);
            dataGridViewCellStyle19.Font = new Font("PT Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = Color.WhiteSmoke;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewTextBoxColumn3.HeaderText = "ФИО";
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 112;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle20.BackColor = Color.White;
            dataGridViewCellStyle20.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewTextBoxColumn4.HeaderText = "Должность";
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 182;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle21.BackColor = Color.White;
            dataGridViewCellStyle21.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewTextBoxColumn5.HeaderText = "Дата приема";
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 201;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle22.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewTextBoxColumn6.HeaderText = "Зарплата";
            dataGridViewTextBoxColumn6.MinimumWidth = 10;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle23.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Column5.DefaultCellStyle = dataGridViewCellStyle23;
            Column5.HeaderText = "Телефон";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 155;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle24.Font = new Font("PT Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            Column6.DefaultCellStyle = dataGridViewCellStyle24;
            Column6.HeaderText = "Карта";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 121;
            // 
            // change_btn
            // 
            change_btn.BackColor = Color.FromArgb(221, 224, 221);
            change_btn.Font = new Font("PT Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            change_btn.Location = new Point(845, 1035);
            change_btn.Name = "change_btn";
            change_btn.Size = new Size(321, 46);
            change_btn.TabIndex = 11;
            change_btn.Text = "Внести изменения";
            change_btn.UseVisualStyleBackColor = false;
            change_btn.Visible = false;
            // 
            // guest_btn
            // 
            guest_btn.BackColor = Color.FromArgb(221, 224, 221);
            guest_btn.Font = new Font("PT Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guest_btn.Location = new Point(865, 1035);
            guest_btn.Name = "guest_btn";
            guest_btn.Size = new Size(302, 46);
            guest_btn.TabIndex = 3;
            guest_btn.Text = "Новый посетитель";
            guest_btn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 244, 235);
            ClientSize = new Size(1617, 1175);
            Controls.Add(lbl_restaurant);
            Controls.Add(upper_panel1);
            Controls.Add(panel1);
            Controls.Add(splitContainer);
            Name = "MainForm";
            Text = "Restaurant";
            Load += MainFormLoad;
            panel1.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_reservedplace).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_guests).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_archive).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_employees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_restaurant;
        private Panel panel1;
        private FlowLayoutPanel upper_panel;
        private FlowLayoutPanel upper_panel1;
        private SplitContainer splitContainer;
        private TreeView menu_tree;
        private Label lbl_menu;
        private Label lbl_date;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button info_btn;
        private Button reserveplace_btn;
        private Button add_btn;
        private DataGridView dataGridView_archive;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridView dataGridView_employees;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button change_btn;
        private DataGridView dataGridView_guests;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dataGridView_reservedplace;
        private Button close_table_btn;
        private Button delete_btn;
        private Button guest_btn;
    }
}