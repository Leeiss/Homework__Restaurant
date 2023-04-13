using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Homework__Restaurant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string path_to_fileXml = @"./../../../Tables.xml";
        string path_to_fileJSON = @"./../../../Guests.xml";
        List<Guests> guestsList = new List<Guests>();



        /// <summary>
        /// Выводим в treeview фио людей из нужной категории
        /// </summary>
        /// <param name="timespan"></param>
        private void DownloadFile(string timespan, int index)
        {
            TreeNode parentNode = menu_tree.Nodes[0];
            int childCount = parentNode.Nodes.Count;

            if (childCount > 0)
            {
                for (int i = 0; i < childCount; i++)
                {
                    TreeNode childNode = parentNode.Nodes[i];
                    childNode.Nodes.Clear();
                }
            }
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path_to_fileXml);
            XmlNodeList personNodes = xmlDoc.SelectNodes($"//{timespan}/person");
            foreach (XmlNode personNode in personNodes)
            {
                TreeNode treeNode = new TreeNode();

                XmlNode fioNode = personNode.SelectSingleNode(".//fio");
                string fioValue = fioNode.InnerText;

                treeNode.Text = fioValue;
                menu_tree.Nodes[index].Nodes.Add(treeNode);
            }
        }


        /// <summary>
        /// Заполняем List guest данными с xml файла
        /// </summary>
        /// <param name="timespan"></param>
        private void FillListWithData(string timespan)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path_to_fileXml);
            XmlElement root = xDoc.DocumentElement;
            foreach (XmlElement node in root)
            {
                if (node.Name == $"{timespan}")
                {
                    foreach (XmlNode child1 in node.ChildNodes)
                    {
                        Guests guest = new Guests();
                        foreach (XmlNode child in child1.ChildNodes)
                        {
                            switch (child.Name)
                            {
                                case "fio":
                                    guest.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                                    break;
                                case "date":
                                    guest.Date = $"{child.ChildNodes[0].InnerText}/{child.ChildNodes[1].InnerText}/{child.ChildNodes[2].InnerText}";
                                    break;
                                case "tabel":
                                    guest.Table = int.Parse(child.InnerText);
                                    break;
                                case "status":
                                    guest.Status = child.InnerText;
                                    break;
                                case "event":
                                    guest.Event = child.InnerText;
                                    break;
                            }
                        }
                        guestsList.Add(guest);
                    }
                }
            }
        }


        /// <summary>
        /// Заполняет DataGridView данными из листа
        /// </summary>
        private void FillDataGrigView()
        {
            foreach (Guests guest in guestsList)
            {
                dataGridView_booking.Rows.Add(guest.Name, guest.Table, guest.Date, guest.Status, guest.Event);
            }
        }

        /// <summary>
        /// Задает параметры для сплиттера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplitterColor(object sender, PaintEventArgs e)
        {
            SplitContainer l_SplitContainer = sender as SplitContainer;

            if (l_SplitContainer != null)
            {
                Rectangle ll_ShrinkedSplitterRectangle = l_SplitContainer.SplitterRectangle;
                ll_ShrinkedSplitterRectangle.Offset(0, 2);
                ll_ShrinkedSplitterRectangle.Height = ll_ShrinkedSplitterRectangle.Height - 2;
                e.Graphics.FillRectangle(Brushes.Silver, ll_ShrinkedSplitterRectangle);
            }
        }

        /// <summary>
        /// Создает treeview
        /// </summary>
        private void CreateTreeView()
        {
            menu_tree.Nodes.Add("Бронь");
            menu_tree.Nodes.Add("Гости в зале");
        }

        private void booking_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            download_btn.Visible = true;
        }

        private void guests_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            download_btn.Visible = true;
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            menu_tree.Nodes.Clear();
            CreateTreeView();
            dataGridView_booking.Visible = true;
            dataGridView_guests.Visible = false;
            if (this.booking_list.SelectedItems.Count != 0 && this.guests_list.SelectedItems.Count == 0)
            {
                guestsList.Clear();
                dataGridView_booking.DataSource = null;
                dataGridView_booking.Rows.Clear();


                int select_category = booking_list.SelectedIndex;
                switch (select_category)
                {
                    case 0:
                        {
                            DownloadFile("today", 0);
                            FillListWithData("today");
                        }

                        break;
                    case 1:
                        {
                            DownloadFile("tomorrow", 0);
                            FillListWithData("tomorrow");
                        }
                        break;
                    case 2:
                        {
                            DownloadFile("later", 0);
                            FillListWithData("later");
                        }
                        break;

                }
                FillDataGrigView();
                MessageBox.Show("Данные успешно загружены");
            }
            else if (this.booking_list.SelectedItems.Count == 0 && this.guests_list.SelectedItems.Count != 0)
            {

            }
            else
            {
                MessageBox.Show("Выберите одну категорию");
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Заполняет даннымы форму InfoBooking
        /// </summary>
        private void menu_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = menu_tree.SelectedNode.Index;
            if (e.Node.Parent != null && e.Node.Parent.Text == "Бронь")
            {
                InfoBooking info = new InfoBooking
                {
                    Name = guestsList[index].Name,
                    Table = guestsList[index].Table.ToString(),
                    Date = guestsList[index].Date,
                    Status = guestsList[index].Status,
                    Event = guestsList[index].Event

                };
                info.ShowDialog();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int pictureBoxHeight = mainpicture.Height;
            int pictureBoxY = (formHeight - pictureBoxHeight) / 2;
            upper_panel.Location = new Point(formWidth * 2, pictureBoxY);

        }
    }
}