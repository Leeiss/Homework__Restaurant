using System.Xml;
using System.Xml.Linq;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Homework__Restaurant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string path_to_fileXml = @"./../../../BookigTables.xml";
        string path_to_fileJSON = @"./../../../Guests.json";
        List<Guests> guestsList = new List<Guests>();
        List<OccupiedTables> occupiedTablesList = new List<OccupiedTables>();



        /// <summary>
        /// Выводим в treeview фио людей из нужной категории c xml файла
        /// </summary>
        /// <param name="timespan"></param>
        private void DownloadXMLFile(string timespan, int index)
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
        /// Выводим в treeview фио людей из нужной категории c JSON файла
        /// </summary>
        /// <param name="tablenumbers"></param>
        /// <param name="index"></param>
        private void DownloadJSONFile(string tablenumbers, int index)
        {
            var jsonString = File.ReadAllText(path_to_fileJSON);

            var jsonDoc = JsonDocument.Parse(jsonString);

            var firstTables = jsonDoc.RootElement.GetProperty($"{tablenumbers}");

            foreach (var table in firstTables.EnumerateArray())
            {
                var number = table.GetProperty("table").GetProperty("number").GetString();
                menu_tree.Nodes[index].Nodes.Add(number);
            }
        }



        /// <summary>
        /// Заполняем List guest данными с XML файла
        /// </summary>
        /// <param name="timespan"></param>
        private void FillListWithDataFromXML(string timespan)
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
        /// Десериализуем JSON файл и добавляем данные в классы
        /// </summary>
        /// <param name="tablenumbers"></param>
        private void FillListWithDataFromJSON(string tablenumbers)
        {
            string path = File.ReadAllText(path_to_fileJSON);
            JsonNode data = JsonNode.Parse(path);
            for (int i = 0; i < 3; i++)
            {
                OccupiedTables occupiedTable = new OccupiedTables();
                JsonNode root = data[$"{tablenumbers}"][i];
                occupiedTable.Table = $"{(string)root["table"]["number"]}, вместимостью {(string)root["table"]["capacity"]}";
                occupiedTable.Order = $"Из основного меню: {(string)root["order"]["food"]}.Напитки: {(string)root["order"]["beverages"]}";
                occupiedTable.Persons = (string)root["persons"];
                occupiedTable.Payment = (string)root["payment"];
                occupiedTable.Status = (string)root["status"];
                occupiedTablesList.Add(occupiedTable);
            }
        }


        /// <summary>
        /// Заполняет DataGridView данными из листа (XML)
        /// </summary>
        private void FillDataGrigViewFromXML()
        {
            foreach (Guests guest in guestsList)
            {
                dataGridView_booking.Rows.Add(guest.Name, guest.Table, guest.Date, guest.Status, guest.Event);
            }
        }



        /// <summary>
        /// Заполняет DataGridView данными из листа (JSON)
        /// </summary>
        private void FillDataGrigViewFromJSON()
        {
            foreach (OccupiedTables occupiedTable in occupiedTablesList)
            {
                dataGridView_guests.Rows.Add(occupiedTable.Table, occupiedTable.Persons, occupiedTable.Payment, occupiedTable.Status);
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
            menu_tree.Nodes.Add("Гости в зале (занятые столики)");
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

            if (this.booking_list.SelectedItems.Count != 0 && this.guests_list.SelectedItems.Count == 0)
            {
                dataGridView_booking.Visible = true;
                dataGridView_guests.Visible = false;
                guestsList.Clear();
                dataGridView_booking.DataSource = null;
                dataGridView_guests.DataSource = null;
                dataGridView_booking.Rows.Clear();
                dataGridView_guests.Rows.Clear();

                int select_category = booking_list.SelectedIndex;
                switch (select_category)
                {
                    case 0:
                        {
                            DownloadXMLFile("today", 0);
                            FillListWithDataFromXML("today");
                        }

                        break;
                    case 1:
                        {
                            DownloadXMLFile("tomorrow", 0);
                            FillListWithDataFromXML("tomorrow");
                        }
                        break;
                    case 2:
                        {
                            DownloadXMLFile("later", 0);
                            FillListWithDataFromXML("later");
                        }
                        break;

                }
                FillDataGrigViewFromXML();
                booking_list.ClearSelected();
                guests_list.ClearSelected();
                MessageBox.Show("Данные успешно загружены");
            }
            else if (this.booking_list.SelectedItems.Count == 0 && this.guests_list.SelectedItems.Count != 0)
            {
                dataGridView_booking.Visible = false;
                dataGridView_guests.Visible = true;
                occupiedTablesList.Clear();
                int select_category = guests_list.SelectedIndex;
                switch (select_category)
                {
                    case 0:
                        {
                            DownloadJSONFile("tables_first10", 1);
                            FillListWithDataFromJSON("tables_first10");
                        }

                        break;
                    case 1:
                        {
                            DownloadJSONFile("tables_from10to20", 1);
                            FillListWithDataFromJSON("tables_from10to20");
                        }
                        break;
                    case 2:
                        {
                            DownloadJSONFile("tables_from20to30", 1);
                            FillListWithDataFromJSON("tables_from20to30");
                        }
                        break;
                }
                FillDataGrigViewFromJSON();
                booking_list.ClearSelected();
                guests_list.ClearSelected();
                MessageBox.Show("Данные успешно загружены");
            }
            else
            {
                MessageBox.Show("Выберите одну категорию");
                booking_list.ClearSelected();
                guests_list.ClearSelected();
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
            else if (e.Node.Parent != null && e.Node.Parent.Text == "Гости в зале (занятые столики)")
            {
                InfoGuests info = new InfoGuests
                {
                    Table = occupiedTablesList[index].Table,
                    Order = occupiedTablesList[index].Order,
                    Persons = occupiedTablesList[index].Persons,
                    Status = occupiedTablesList[index].Status,
                    Payment = occupiedTablesList[index].Payment,

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

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}