using System;
using System.Collections.Generic;
using System.Xml;
namespace getRabanut
{


    public partial class Form1 : Form
    {
        private string getDayInWeek;
        private string getDayInMonth;
        private string getYear;
        private string getMonth;
        private Dictionary<string, string> hebrewDate = new Dictionary<string, string>()
        {
            { "dayInWeek", "" },
            { "dayInMonth", "" },
            { "month", "" },
            { "year", "" }
        };
        private Dictionary<string, string> daysInWeek = new Dictionary<string, string>()
        {
            { "�����", "���� ����" },
            { "���", "���� ����" },
            { "�����", "������ ����" },
            { "�����", "������ ����" },
            { "�����", "������� ����" },
            { "����", "���� ����" }
        };
        private Dictionary<int, string> hebrewDaysMonth = new Dictionary<int, string>()
        {
            { 1, "��� ���" },
            { 2, "��� ����" },
            {3, "���� ����" },
            {4, "����� ����" },
            { 5, "����� ����" },
            { 6, "���� ����" },
            { 7, "���� ����" },
            { 8, "����� ����" },
            { 9, "���� ����" },
            { 10, "���� ����" },
            { 11, "��� ��� ���" },
            { 12, "���� ��� ���" },
            { 13, "���� ��� ���" },
            { 14, "����� ��� ����" },
            { 15, "����� ��� ����" },
            { 16, "��� ��� ���" },
            { 17, "���� ��� ����" },
            { 18, "����� ��� ����" },
            { 19, "���� ��� ����" },
            { 20, "����� ����" },
            { 21, "����� ���� ����" },
            { 22, "����� ������ ����" },
            { 23, "����� ������ ����" },
            { 24, "����� ������ ����" },
            { 25, "����� ������ ����" },
            { 26, "����� ���� ����" },
            { 27, "����� ����� ����" },
            { 28, "����� ������ ����" },
            { 29, "����� ���� ����" },
            { 30, "����� ����" }

        };
        private Dictionary<string, string> years = new Dictionary<string, string>()
        {
           {"����", "���� ����� ���� ���� ������ �����"},
           {"����", "���� ����� ���� ���� ������ ����"},
           {"����", "���� ����� ���� ���� ������ ���"},
           {"����", "���� ����� ���� ���� ������ ����"},
           {"����", "���� ����� ���� ���� ������ ������"},
           {"����", "���� ����� ���� ���� ������ ����"},
           {"���", "���� ����� ������ ���� ������"},
           {"����", "���� ����� ������ ���� ������ ����"},
           {"����", "���� ����� ������ ���� ������ ������"},
           {"����", "���� ����� ������ ���� ������ �����"}
        };

        public Form1()
        {
            InitializeComponent();
            comboBoxWeek.Items.AddRange(new string[]
            {
            "�����",
            "���",
            "�����",
            "�����",
            "�����",
            "����"
            });
            comboBoxDayMonth.Items.AddRange(new object[] {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30
            });
            comboBoxMonth.Items.AddRange(new string[]
            {
                "����",
                "������",
                "����",
                "���",
                "���",
                "��� �",
                "��� �",
                "����",
                "����",
                "����� ",
                "����",
                "��",
                "����",
             });
            comboBoxYear.Items.AddRange(new string[]
            {
                "����",
                "����",
                "����",
                "����",
                "����",
                "����",
                "���",
                "����",
                "����",
                "����"
            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hebrewDate["daysInWeek"] = daysInWeek[comboBoxWeek.SelectedItem.ToString()];

        }

        private void comboBoxDayMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(comboBoxDayMonth.SelectedItem.ToString()) == 30)
            {
                hebrewDate["dayInMonth"] = $"���� ���� ��� ����{hebrewDate["month"]}  {hebrewDate["month"]} ��� ����� ";
            }
            else
            {
                hebrewDate["dayInMonth"] = hebrewDaysMonth[int.Parse(comboBoxDayMonth.SelectedItem.ToString())];
            }
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            hebrewDate["month"] = comboBoxMonth.Text.ToString();
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            hebrewDate["year"] = years[comboBoxYear.Text];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{hebrewDate["dayInWeek"]} {hebrewDate["dayInMonth"]} ���� {hebrewDate["month"]} ��� {hebrewDate["year"]} ������ �����");
            XmlDocument doc = new XmlDocument();

            // ������� �� �������� �����
            XmlElement root = doc.CreateElement("date");
            doc.AppendChild(root);

            // ����� �� ���� �����
            XmlElement weekDay = doc.CreateElement("week");
            weekDay.InnerText = hebrewDate["dayInWeek"];
            root.AppendChild(weekDay);
            //������� �� ���� �����
            XmlElement weekMonth = doc.CreateElement("month");
            weekMonth.InnerText = hebrewDate["dayInMonth"];
            root.AppendChild(weekMonth);
            //������� �� �����
            XmlElement Month = doc.CreateElement("monthinyear");
            Month.InnerText = hebrewDate["month"];
            root.AppendChild(Month);
            //������� �� ����
            XmlElement Year = doc.CreateElement("month");
            Year.InnerText = hebrewDate["year"];
            root.AppendChild(Year);

            // Save the document to a file
            doc.Save(@"getRabanut.xml");

            MessageBox.Show("XML file created successfully.");
            this.Close();
        }
    }
}
