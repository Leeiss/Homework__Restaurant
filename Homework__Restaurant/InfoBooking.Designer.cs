namespace Homework__Restaurant
{
    partial class InfoBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            info_lbl = new Label();
            lbl_name = new Label();
            lbl_event = new Label();
            lbl_status = new Label();
            lbl_date = new Label();
            lbl_table = new Label();
            frame1 = new Panel();
            frame2 = new Panel();
            frame3 = new Panel();
            frame4 = new Panel();
            frame5 = new Panel();
            upper_panel1 = new FlowLayoutPanel();
            infolb_name = new Label();
            infolb_table = new Label();
            infolb_date = new Label();
            infolb_status = new Label();
            infolb_event = new Label();
            frame1.SuspendLayout();
            frame2.SuspendLayout();
            frame3.SuspendLayout();
            frame4.SuspendLayout();
            frame5.SuspendLayout();
            SuspendLayout();
            // 
            // info_lbl
            // 
            info_lbl.AutoSize = true;
            info_lbl.Font = new Font("XO Courser", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            info_lbl.ForeColor = Color.FromArgb(112, 151, 171);
            info_lbl.Location = new Point(28, 35);
            info_lbl.Name = "info_lbl";
            info_lbl.Size = new Size(672, 49);
            info_lbl.TabIndex = 0;
            info_lbl.Text = "Бронь: информация о госте";
            // 
            // lbl_name
            // 
            lbl_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_name.AutoSize = true;
            lbl_name.BackColor = Color.FromArgb(221, 224, 221);
            lbl_name.Font = new Font("XO Courser", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_name.Location = new Point(3, 24);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(72, 36);
            lbl_name.TabIndex = 1;
            lbl_name.Text = "Имя";
            // 
            // lbl_event
            // 
            lbl_event.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_event.AutoSize = true;
            lbl_event.Font = new Font("XO Courser", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_event.Location = new Point(3, 27);
            lbl_event.Name = "lbl_event";
            lbl_event.Size = new Size(224, 36);
            lbl_event.TabIndex = 3;
            lbl_event.Text = "Мероприятие";
            // 
            // lbl_status
            // 
            lbl_status.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_status.AutoSize = true;
            lbl_status.Font = new Font("XO Courser", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_status.Location = new Point(3, 28);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(129, 36);
            lbl_status.TabIndex = 4;
            lbl_status.Text = "Статус";
            // 
            // lbl_date
            // 
            lbl_date.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("XO Courser", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_date.Location = new Point(3, 23);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(91, 36);
            lbl_date.TabIndex = 5;
            lbl_date.Text = "Дата";
            // 
            // lbl_table
            // 
            lbl_table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_table.AutoSize = true;
            lbl_table.Font = new Font("XO Courser", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_table.Location = new Point(0, 25);
            lbl_table.Name = "lbl_table";
            lbl_table.Size = new Size(262, 36);
            lbl_table.TabIndex = 6;
            lbl_table.Text = "Номер столика";
            // 
            // frame1
            // 
            frame1.Anchor = AnchorStyles.Left;
            frame1.BackColor = Color.FromArgb(221, 224, 221);
            frame1.Controls.Add(lbl_name);
            frame1.Location = new Point(39, 185);
            frame1.Name = "frame1";
            frame1.Size = new Size(303, 84);
            frame1.TabIndex = 7;
            // 
            // frame2
            // 
            frame2.Anchor = AnchorStyles.Left;
            frame2.BackColor = Color.FromArgb(221, 224, 221);
            frame2.Controls.Add(lbl_table);
            frame2.Location = new Point(39, 292);
            frame2.Name = "frame2";
            frame2.Size = new Size(303, 84);
            frame2.TabIndex = 8;
            // 
            // frame3
            // 
            frame3.Anchor = AnchorStyles.Left;
            frame3.BackColor = Color.FromArgb(221, 224, 221);
            frame3.Controls.Add(lbl_date);
            frame3.Location = new Point(39, 402);
            frame3.Name = "frame3";
            frame3.Size = new Size(303, 84);
            frame3.TabIndex = 8;
            // 
            // frame4
            // 
            frame4.Anchor = AnchorStyles.Left;
            frame4.BackColor = Color.FromArgb(221, 224, 221);
            frame4.Controls.Add(lbl_status);
            frame4.Location = new Point(42, 515);
            frame4.Name = "frame4";
            frame4.Size = new Size(300, 89);
            frame4.TabIndex = 8;
            // 
            // frame5
            // 
            frame5.Anchor = AnchorStyles.Left;
            frame5.BackColor = Color.FromArgb(221, 224, 221);
            frame5.Controls.Add(lbl_event);
            frame5.Location = new Point(39, 630);
            frame5.Name = "frame5";
            frame5.Size = new Size(303, 84);
            frame5.TabIndex = 8;
            // 
            // upper_panel1
            // 
            upper_panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            upper_panel1.BackColor = Color.FromArgb(112, 151, 171);
            upper_panel1.Location = new Point(104, 102);
            upper_panel1.Name = "upper_panel1";
            upper_panel1.Size = new Size(1853, 10);
            upper_panel1.TabIndex = 9;
            // 
            // infolb_name
            // 
            infolb_name.Anchor = AnchorStyles.Right;
            infolb_name.AutoSize = true;
            infolb_name.BackColor = Color.WhiteSmoke;
            infolb_name.Font = new Font("XO Courser", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infolb_name.Location = new Point(464, 185);
            infolb_name.Name = "infolb_name";
            infolb_name.Size = new Size(72, 36);
            infolb_name.TabIndex = 10;
            infolb_name.Text = "Имя";
            // 
            // infolb_table
            // 
            infolb_table.Anchor = AnchorStyles.Right;
            infolb_table.AutoSize = true;
            infolb_table.BackColor = Color.WhiteSmoke;
            infolb_table.Font = new Font("XO Courser", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infolb_table.Location = new Point(464, 317);
            infolb_table.Name = "infolb_table";
            infolb_table.Size = new Size(262, 36);
            infolb_table.TabIndex = 11;
            infolb_table.Text = "Номер столика";
            // 
            // infolb_date
            // 
            infolb_date.Anchor = AnchorStyles.Right;
            infolb_date.AutoSize = true;
            infolb_date.BackColor = Color.WhiteSmoke;
            infolb_date.Font = new Font("XO Courser", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infolb_date.Location = new Point(464, 402);
            infolb_date.Name = "infolb_date";
            infolb_date.Size = new Size(91, 36);
            infolb_date.TabIndex = 12;
            infolb_date.Text = "Дата";
            // 
            // infolb_status
            // 
            infolb_status.Anchor = AnchorStyles.Right;
            infolb_status.AutoSize = true;
            infolb_status.BackColor = Color.WhiteSmoke;
            infolb_status.Font = new Font("XO Courser", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infolb_status.Location = new Point(464, 534);
            infolb_status.Name = "infolb_status";
            infolb_status.Size = new Size(129, 36);
            infolb_status.TabIndex = 13;
            infolb_status.Text = "Статус";
            // 
            // infolb_event
            // 
            infolb_event.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            infolb_event.AutoSize = true;
            infolb_event.BackColor = Color.WhiteSmoke;
            infolb_event.Font = new Font("XO Courser", 12F, FontStyle.Regular, GraphicsUnit.Point);
            infolb_event.Location = new Point(464, 646);
            infolb_event.Name = "infolb_event";
            infolb_event.Size = new Size(224, 36);
            infolb_event.TabIndex = 14;
            infolb_event.Text = "Мероприятие";
            // 
            // InfoBooking
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1212, 756);
            Controls.Add(infolb_event);
            Controls.Add(infolb_status);
            Controls.Add(infolb_date);
            Controls.Add(infolb_table);
            Controls.Add(infolb_name);
            Controls.Add(upper_panel1);
            Controls.Add(info_lbl);
            Controls.Add(frame1);
            Controls.Add(frame5);
            Controls.Add(frame4);
            Controls.Add(frame3);
            Controls.Add(frame2);
            Name = "InfoBooking";
            Text = "Информация о посетителе";
            frame1.ResumeLayout(false);
            frame1.PerformLayout();
            frame2.ResumeLayout(false);
            frame2.PerformLayout();
            frame3.ResumeLayout(false);
            frame3.PerformLayout();
            frame4.ResumeLayout(false);
            frame4.PerformLayout();
            frame5.ResumeLayout(false);
            frame5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label info_lbl;
        private Label lbl_name;
        private Label lbl_event;
        private Label lbl_status;
        private Label lbl_date;
        private Label lbl_table;
        private Panel frame1;
        private Panel frame2;
        private Panel frame3;
        private Panel frame4;
        private Panel frame5;
        private FlowLayoutPanel upper_panel1;
        private Label infolb_name;
        private Label infolb_table;
        private Label infolb_date;
        private Label infolb_status;
        private Label infolb_event;
    }
}