using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace thongkethongtin
{
    class StatInformationControl
    {
        public bool isEmpty;
        public List<int> Age;
        public List<int> Sex;
        public List<Desease> desease;
        public string type;
        public void StatWeek()
        {
            type = "Week";
            Datacontrol temp = new Datacontrol();
            temp.ChooseWeekData();
            Age=temp.GetAge();
            Sex = temp.GetSex();
            desease = temp.GetDesease();
            isEmpty = temp.IsDataEmpty();
        }
        public void StatMonth()
        {
            type = "Month";
            Datacontrol temp = new Datacontrol();
            temp.ChooseMonthData();
            Age = temp.GetAge();
            Sex = temp.GetSex();
            desease = temp.GetDesease();
            isEmpty = temp.IsDataEmpty();
        }
        public void StatYear()
        {
            type = "Year";
            Datacontrol temp = new Datacontrol();
            temp.ChooseYearData();
            Age = temp.GetAge();
            Sex = temp.GetSex();
            desease = temp.GetDesease();
            isEmpty = temp.IsDataEmpty();
        }
        public void StatAll()
        {
            type = "All";
            Datacontrol temp = new Datacontrol();
            temp.ChooseAllData();
            Age = temp.GetAge();
            Sex = temp.GetSex();
            desease = temp.GetDesease();
            isEmpty = temp.IsDataEmpty();
        }
        public bool MakeStatFile()
        {
            StringBuilder csvcontent = new StringBuilder();
            csvcontent.AppendLine("Under 6,"+Age[0].ToString());
            csvcontent.AppendLine("6 To 18," + Age[1].ToString());
            csvcontent.AppendLine("18 To 60," + Age[2].ToString());
            csvcontent.AppendLine("Above 60," + Age[3].ToString());
            csvcontent.AppendLine("Women," + Sex[0].ToString());
            csvcontent.AppendLine("Men," + Sex[1].ToString());
            for (int i = 0; i < desease.Count; i++)
            {
                csvcontent.AppendLine(desease[i].desease+","+desease[i].count.ToString());
            }
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV|*.csv|All file|*.*";
            save.FilterIndex = 1;
            save.FileName = type+"-"+DateTime.Now.ToString("yyyyMMdd_hhmmss");
            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, csvcontent.ToString());
                return false;
            }
            else return true;
        }
        public bool Error()
        {
            if (isEmpty == true) return true;
            else return false;
        }
    }
}
