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
            { "ראשון", "באחד בשבת" },
            { "שני", "בשני בשבת" },
            { "שלישי", "בשלישי בשבת" },
            { "רביעי", "ברביעי בשבת" },
            { "חמישי", "בחמישיי בשבת" },
            { "שישי", "בששי בשבת" }
        };
        private Dictionary<int, string> hebrewDaysMonth = new Dictionary<int, string>()
        {
            { 1, "יום אחד" },
            { 2, "שני ימים" },
            {3, "שלשה ימים" },
            {4, "ארבעה ימים" },
            { 5, "חמישה ימים" },
            { 6, "שישה ימים" },
            { 7, "שבעה ימים" },
            { 8, "שמונה ימים" },
            { 9, "תשעה ימים" },
            { 10, "עשרה ימים" },
            { 11, "אחד עשר יום" },
            { 12, "שנים עשר יום" },
            { 13, "שלשה עשר יום" },
            { 14, "ארבעה עשר ימים" },
            { 15, "חמישה עשר ימים" },
            { 16, "ששה עשר יום" },
            { 17, "שבעה עשר ימים" },
            { 18, "שמונה עשר ימים" },
            { 19, "תשעה עשר ימים" },
            { 20, "עשרים ימים" },
            { 21, "עשרים ואחד ימים" },
            { 22, "עשרים ושתיים ימים" },
            { 23, "עשרים ושלושה ימים" },
            { 24, "עשרים וארבעה ימים" },
            { 25, "עשרים וחמישה ימים" },
            { 26, "עשרים וששה ימים" },
            { 27, "עשרים ושבעה ימים" },
            { 28, "עשרים ושמונה ימים" },
            { 29, "עשרים ותשע ימים" },
            { 30, "שלשים ימים" }

        };
        private Dictionary<string, string> years = new Dictionary<string, string>()
        {
           {"תשפד", "חמשת אלפים ושבע מאות שמונים וארבע"},
           {"תשפה", "חמשת אלפים ושבע מאות שמונים וחמש"},
           {"תשפו", "חמשת אלפים ושבע מאות שמונים ושש"},
           {"תשפז", "חמשת אלפים ושבע מאות שמונים ושבע"},
           {"תשפח", "חמשת אלפים ושבע מאות שמונים ושמונה"},
           {"תשפט", "חמשת אלפים ושבע מאות שמונים ותשע"},
           {"תשצ", "חמשת אלפים ושמונה מאות ותשעים"},
           {"תשצא", "חמשת אלפים ושמונה מאות ותשעים ואחת"},
           {"תשצב", "חמשת אלפים ושמונה מאות ותשעים ושתיים"},
           {"תשצג", "חמשת אלפים ושמונה מאות ותשעים ושלוש"}
        };

        public Form1()
        {
            InitializeComponent();
            comboBoxWeek.Items.AddRange(new string[]
            {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "שישי"
            });
            comboBoxDayMonth.Items.AddRange(new object[] {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30
            });
            comboBoxMonth.Items.AddRange(new string[]
            {
                "תשרי",
                "מרחשון",
                "כסלו",
                "טבת",
                "שבט",
                "אדר א",
                "אדר ב",
                "ניסן",
                "אייר",
                "סיוון ",
                "תמוז",
                "אב",
                "אלול",
             });
            comboBoxYear.Items.AddRange(new string[]
            {
                "תשפד",
                "תשפה",
                "תשפו",
                "תשפז",
                "תשפח",
                "תשפט",
                "תשצ",
                "תשצא",
                "תשצב",
                "תשצג"
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
                hebrewDate["dayInMonth"] = $"לחדש שהוא ראש חודש{hebrewDate["month"]}  {hebrewDate["month"]} יום שלשים ";
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
            MessageBox.Show($"{hebrewDate["dayInWeek"]} {hebrewDate["dayInMonth"]} לירח {hebrewDate["month"]} שנת {hebrewDate["year"]} לבריאת העולם");
            XmlDocument doc = new XmlDocument();

            // מייצרים את האובייקט הראשי
            XmlElement root = doc.CreateElement("date");
            doc.AppendChild(root);

            // ייצור של היום בשבוע
            XmlElement weekDay = doc.CreateElement("week");
            weekDay.InnerText = hebrewDate["dayInWeek"];
            root.AppendChild(weekDay);
            //מייצרים את היום בחודש
            XmlElement weekMonth = doc.CreateElement("month");
            weekMonth.InnerText = hebrewDate["dayInMonth"];
            root.AppendChild(weekMonth);
            //מייצרים את החודש
            XmlElement Month = doc.CreateElement("monthinyear");
            Month.InnerText = hebrewDate["month"];
            root.AppendChild(Month);
            //מייצרים את השנה
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
