using System.Xml.Linq;

namespace ctuba
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> _mydays = new Dictionary<string, string>();
        public Dictionary<string, string> _myyears;
        public Dictionary<string, string> _myweekDays;
        public Form1()
        {
            InitializeComponent();
            FillDicts();
        }
        public void FillDicts()
        {
            _mydays.Add("1", "יום אחד");
            _mydays.Add("2", "שני ימים");
            _mydays.Add("3", "שלשה ימים");
            _mydays.Add("4", "ארבעה ימים");
            _mydays.Add("5", "חמישה ימים");
            _mydays.Add("6", "שישה ימים");
            _mydays.Add("7", "שבעה ימים");
            _mydays.Add("8", "שמונה ימים");
            _mydays.Add("9", "תשעה ימים");
            _mydays.Add("10", "עשרה ימים");
            _mydays.Add("11", "אחד עשר יום");
            _mydays.Add("12", "שנים עשר יום");
            _mydays.Add("13", "שלשה עשר יום");
            _mydays.Add("14", "ארבעה עשר ימים");
            _mydays.Add("15", "חמישה עשר ימים");
            _mydays.Add("16", "ששה עשר יום");
            _mydays.Add("17", "שבעה עשר ימים");
            _mydays.Add("18", "שמונה עשר ימים");
            _mydays.Add("19", "תשעה עשר ימים");
            _mydays.Add("20", "עשרים יום");
            _mydays.Add("21", "עשרים ואחד ימים");
            _mydays.Add("22", "עשרים ושתיים ימים");
            _mydays.Add("23", "עשרים ושלושה ימים");
            _mydays.Add("24", "עשרים וארבעה ימים");
            _mydays.Add("25", "עשרים וחמישה ימים");
            _mydays.Add("26", "עשרים וששה ימים");
            _mydays.Add("27", "עשרים ושבעה ימים");
            _mydays.Add("28", "עשרים ושמונה ימים");
            _mydays.Add("29", "עשרים ותשעה ימים");
            _mydays.Add("30", "שלושים ימים ימים");
            _myyears = new Dictionary<string, string>()
            {
                        { "תשפ\"ד", "שנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם" },
                        { "תשפ\"ה", "שנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם" },
                        { "תשפ\"ו", "שנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם" },
                        { "תשפ\"ז", "שנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם" },
                        { "תשפ\"ח", "שנת חמשת אלפים ושבע מאות ושמנים ושמונה לבריאת העולם" },
                        { "תשפ\"ט", "שנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם" },
                        { "תש\"צ", "שנת חמשת אלפים ושמונה מאות ותשעים לבריאת העולם" },
                        { "תשצ\"א", "שנת חמשת אלפים ושמונה מאות ותשעים ואחת לבריאת העולם" },
                        { "תשצ\"ב", "שנת חמשת אלפים ושמונה מאות ותשעים ושתיים לבריאת העולם" },
                        { "תשצ\"ג", "שנת חמשת אלפים ושמונה מאות ותשעים ושלוש לבריאת העולם" }
            };
            _myweekDays = new Dictionary<string, string>()
            {
                { "ראשון", "אחד" },
                { "שני", "שניים" },
                { "שלישי", "שלישי" },
                { "רביעי", "רביעי" },
                { "חמישי", "חמישי" },
                { "ששי", "שישי" },
            };
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string weekDay = comboBox_weekDays.Text.Trim();
            string year = comboBox_year.Text.Trim();
            string monthDay = comboBox_monthDays.Text.Trim();
            string month = comboBox_months.Text.Trim();
            if (string.IsNullOrEmpty(weekDay) || string.IsNullOrEmpty(year) || string.IsNullOrEmpty(month) || string.IsNullOrEmpty(monthDay))
            {
                MessageBox.Show("אנה הכנס את כל הערכים, כבוד הרב");
                return;                
            }
            if (monthDay == "30")
            {
                if (month == "אדר")
                {
                    month += $" שהוא ראש חודש ניסן";
                }
                else
                {
                    month += $" שהוא ראש חודש {comboBox_months.Items[comboBox_months.SelectedIndex + 1]}";
                }
            }
            if (monthDay == "1")
            {
                month += $" שהוא ראש חודש {month}";
            }
            string ressult = $" ב{_myweekDays[weekDay]} בשבת {_mydays[monthDay]} לירח {month} {_myyears[year]}";            
            MessageBox.Show(ressult);
            string path = "ctuba.xml";
            month = comboBox_months.Text.Trim();
            //adding to xml
            XDocument xDocument = XDocument.Load(path);
            XElement xmlmonth = new XElement("Month", month);
            XElement xmlyear = new XElement("Year", year);
            XElement xmlweekDay = new XElement("Day", weekDay);
            XElement xmlmonthDay = new XElement("DayMonth", monthDay);  
            XElement xmlressult = new XElement("Ressult", ressult);
            XElement query = new XElement("Query", xmlweekDay, xmlmonthDay, xmlmonth, xmlyear, xmlressult);
            xDocument.Root.Add(query);
            xDocument.Save(path);
        }
    }
}
