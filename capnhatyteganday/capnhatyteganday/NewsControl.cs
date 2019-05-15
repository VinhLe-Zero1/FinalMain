using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thongkethongtin;

namespace capnhatyteganday
{
    class NewsControl
    {
        public List<Desease> MostDesease;
        public List<Desease> IncreaseDesease;
        public List<Desease> DecreaseDesease;
        public List<Desease> SeasonalDesease;
        public bool isEmpty;
        public void UpdateNews()
        {
            Datacontrol news = new Datacontrol();
            MostDesease = news.GetMostDesease();
            IncreaseDesease = news.GetIncreaseDesease();
            DecreaseDesease = news.GetDecreaseDesease();
            SeasonalDesease = news.GetSeasonalDesease();
            isEmpty = news.IsDataEmpty();
        }
        public bool Error()
        {
            if (isEmpty == true) return true;
            else return false;
        }
    }
}
