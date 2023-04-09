using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Homework__Restaurant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //public bool CorrectPassword;
        //private List<TableDetails> ReadDataFromXml(string filePath)
//{
         //   XmlSerializer serializer = new XmlSerializer(typeof(List<TableDetails>), new XmlRootAttribute("tables"));
          //  using (TextReader reader = new StreamReader(filePath))
          //  {
          //      data = (List<TableDetails>)serializer.Deserialize(reader);
           // }

        //    return data;
        //}
        private void MainFormLoad(object sender, EventArgs e)
        { 

            //DataSet ds = new DataSet();
            //ds.ReadXml(@"C:\Users\farra\source\repos\Homework__Restaurant\Homework__Restaurant\Tables.xml");
            // dataGridView_reservedplace.DataSource = ds.Tables[0];
            //Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // dataGridView_reservedplace.Columns[0].HeaderText = "Номер столика";
            //dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            //dataGridViewCellStyle1.BackColor = Color.FromArgb(112, 151, 171);
            //dataGridViewCellStyle1.Font = new Font("PT Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            //dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            //Column1.DefaultCellStyle = dataGridViewCellStyle1;
            //Column1.HeaderText = "Номер столика";
            //Column1.MinimumWidth = 10;
            //Column1.Name = "Column1";
            //Column1.Width = 227;

        }
        /*private DataTable CreateTable()
        {
            //создаём таблицу
            DataTable dt = new DataTable("Tables");
            //создаём три колонки
            DataColumn colNum = new DataColumn("Номер столика", typeof(String));
            DataColumn colDate = new DataColumn("Дата", typeof(String));
            DataColumn colEvent = new DataColumn("Мероприятиe", typeof(String));
            DataColumn colDet = new DataColumn("Детали", typeof(String));
            //добавляем колонки в таблицу
            dt.Columns.Add(colNum);
            dt.Columns.Add(colDate);
            dt.Columns.Add(colEvent);
            dt.Columns.Add(colDet);
            return dt;
        //}
        private DataTable ReadXml()
        {
            DataTable dt = null;
            try
            {
                //загружаем xml файл
                XDocument xDoc = XDocument.Load(@"C:\Users\farra\source\repos\Homework__Restaurant\Homework__Restaurant\Tables.xml");
                //создаём таблицу
                dt = CreateTable();
                DataRow newRow = null;
                //получаем все узлы в xml файле
                foreach (XElement elm in xDoc.Descendants("tables"))
                {
                    newRow = dt.NewRow();
                    newRow["number"] = elm.Attribute("number").Value;
                    newRow["date"] = elm.Element("date").Value;
                    newRow["event"] = elm.Element("event").Value;
                    newRow["details"] = elm.Element("details").Value;
                    dt.Rows.Add(newRow);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            return dt;
        }*/
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




        private void ShowTable(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            if (node == null)
            {
                return;
            }
            switch (e.Node.Text)
            {
                case "Бронь":
                    //dataGridView_reservedplace.DataSource = ReadXml();
                    close_table_btn.Visible = false;
                    change_btn.Visible = false;
                    delete_btn.Visible = true;
                    guest_btn.Visible = false;
                    reserveplace_btn.Visible = true;
                    info_btn.Visible = true;
                    dataGridView_archive.Visible = false;
                    dataGridView_employees.Visible = false;
                    dataGridView_guests.Visible = false;
                    dataGridView_reservedplace.Visible = true;
                    break;
                case "Гости в зале":
                    //switch (e.Node.Node.Text)
                    //{
                    //   case "Зарезервировано":
                    //        {
                    //            MessageBox.Show("eeeec");
                    //            break;
                    //       }
                    //}
                    close_table_btn.Visible = true;
                    change_btn.Visible = false;
                    delete_btn.Visible = false;
                    guest_btn.Visible = true;
                    reserveplace_btn.Visible = false;
                    info_btn.Visible = true;
                    dataGridView_archive.Visible = false;
                    dataGridView_employees.Visible = false;
                    dataGridView_guests.Visible = true;
                    dataGridView_reservedplace.Visible = false;
                    break;
                case "Архив посетителей":
                    close_table_btn.Visible = false;
                    change_btn.Visible = false;
                    delete_btn.Visible = false;
                    guest_btn.Visible = false;
                    info_btn.Visible = true;
                    dataGridView_archive.Visible = true;
                    dataGridView_employees.Visible = false;
                    dataGridView_guests.Visible = false;
                    dataGridView_reservedplace.Visible = false;
                    break;
                case "Сотрудники":
                    close_table_btn.Visible = false;
                    change_btn.Visible = false;
                    delete_btn.Visible = false;
                    guest_btn.Visible = false;
                    info_btn.Visible = false;
                    dataGridView_archive.Visible = false;
                    dataGridView_employees.Visible = false;
                    dataGridView_guests.Visible = false;
                    dataGridView_reservedplace.Visible = false;
                    Administration administration = new Administration();
                    administration.ShowDialog();
                    if (administration.DialogResult == DialogResult.OK)
                    {
                        MessageBox.Show("Вход не выполнен");
                        dataGridView_employees.Visible = false;
                    }
                    else
                    {
                        info_btn.Visible = true;
                        dataGridView_employees.Visible = true;
                        change_btn.Visible = true;
                    }
                    break;

            }
        }

        private void dataGridView_employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            change_btn.Visible = true;
        }

        private void activate(object sender, EventArgs e)
        {
            dataGridView_employees.Visible = false;
        }

        private void splitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}