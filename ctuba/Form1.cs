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
            _mydays.Add("1", "��� ���");
            _mydays.Add("2", "��� ����");
            _mydays.Add("3", "���� ����");
            _mydays.Add("4", "����� ����");
            _mydays.Add("5", "����� ����");
            _mydays.Add("6", "���� ����");
            _mydays.Add("7", "���� ����");
            _mydays.Add("8", "����� ����");
            _mydays.Add("9", "���� ����");
            _mydays.Add("10", "���� ����");
            _mydays.Add("11", "��� ��� ���");
            _mydays.Add("12", "���� ��� ���");
            _mydays.Add("13", "���� ��� ���");
            _mydays.Add("14", "����� ��� ����");
            _mydays.Add("15", "����� ��� ����");
            _mydays.Add("16", "��� ��� ���");
            _mydays.Add("17", "���� ��� ����");
            _mydays.Add("18", "����� ��� ����");
            _mydays.Add("19", "���� ��� ����");
            _mydays.Add("20", "����� ���");
            _mydays.Add("21", "����� ���� ����");
            _mydays.Add("22", "����� ������ ����");
            _mydays.Add("23", "����� ������ ����");
            _mydays.Add("24", "����� ������ ����");
            _mydays.Add("25", "����� ������ ����");
            _mydays.Add("26", "����� ���� ����");
            _mydays.Add("27", "����� ����� ����");
            _mydays.Add("28", "����� ������ ����");
            _mydays.Add("29", "����� ����� ����");
            _mydays.Add("30", "��������������");
            _myyears = new Dictionary<string, string>()
            {
                        { "���\"�", "��� ���� ����� ���� ���� ������ ����� ������ �����" },
                        { "���\"�", "��� ���� ����� ���� ���� ������ ���� ������ �����" },
                        { "���\"�", "��� ���� ����� ���� ���� ������ ��� ������ �����" },
                        { "���\"�", "��� ���� ����� ���� ���� ������ ���� ������ �����" },
                        { "���\"�", "��� ���� ����� ���� ���� ������ ������ ������ �����" },
                        { "���\"�", "��� ���� ����� ���� ���� ������ ���� ������ �����" },
                        { "��\"�", "��� ���� ����� ������ ���� ������ ������ �����" },
                        { "���\"�", "��� ���� ����� ������ ���� ������ ���� ������ �����" },
                        { "���\"�", "��� ���� ����� ������ ���� ������ ������ ������ �����" },
                        { "���\"�", "��� ���� ����� ������ ���� ������ ����� ������ �����" }
            };
            _myweekDays = new Dictionary<string, string>()
            {
                { "�����", "���" },
                { "���", "�����" },
                { "�����", "�����" },
                { "�����", "�����" },
                { "�����", "�����" },
                { "���", "����" },
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
                MessageBox.Show("��� ���� �� �� ������, ���� ���");
                return;                
            }
            if (monthDay == "30")
            {
                if (month == "���")
                {
                    month += $" ���� ��� ���� ����";
                }
                else
                {
                    month += $" ���� ��� ���� {comboBox_months.Items[comboBox_months.SelectedIndex + 1]}";
                }
            }
            if (monthDay == "1")
            {
                month += $" ���� ��� ���� {month}";
            }
            string ressult = $" �{_myweekDays[weekDay]} ���� {_mydays[monthDay]} ���� {month} {_myyears[year]}";            
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
