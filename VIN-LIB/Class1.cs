using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        private Dictionary<string, int> _years;
        private string _countryData;
        public Class1()
        {
            _years = new Dictionary<string, int>();
            _years.Add("A", 1980);
            _years.Add("B", 1981);
            _years.Add("C", 1982);
            _years.Add("D", 1983);
            _years.Add("E", 1984);
            _years.Add("F", 1985);
            _years.Add("G", 1986);
            _years.Add("H", 1987);
            _years.Add("J", 1988);
            _years.Add("K", 1989);
            _years.Add("L", 1990);
            _years.Add("M", 1991);
            _years.Add("N", 1992);
            _years.Add("P", 1992);
            _years.Add("R", 1994);
            _years.Add("S", 1995);
            _years.Add("T", 1996);
            _years.Add("V", 1997);
            _years.Add("W", 1998);
            _years.Add("X", 1999);
            _years.Add("Y", 2000);
            _years.Add("1", 2001);
            _years.Add("2", 2002);
            _years.Add("3", 2003);
            _years.Add("4", 2004);
            _years.Add("5", 2005);
            _years.Add("6", 2006);
            _years.Add("7", 2007);
            _years.Add("8", 2008);
            _years.Add("9", 2009);
            _countryData = "RU-AD  Республика Адыгея;RU-AL Республика Алтай;RU-BA Республика Башкортостан;RU-BU Республика Бурятия;RU-DA Республика Дагестан;RU-IN Республика Ингушетия;RU-KB Кабардино-Балкарская республика;RU-KL Республика Калмыкия;RU-KC Карачаево-Черкесская республика;RU-KR Республика Карелия;RU-KO Республика Коми;RU-CR Республика Крым;RU-ME Республика Марий Эл;RU-MO Республика Мордовия;RU-SA Республика Саха (Якутия);RU-SE Республика Северная Осетия — Алания;RU-TA Республика Татарстан;RU-TY Республика Тыва;RU-UD Удмуртская республика;RU-KK Республика Хакасия;RU-CE Чеченская республика;RU-CU Чувашская республика;RU-ALT Алтайский край;RU-ZAB Забайкальский край;RU-KAM Камчатский край;RU-KDA Краснодарский край;RU-KYA Красноярский край;RU-PER Пермский край;RU-PRI Приморский край;RU-STA Ставропольский край;RU-KHA Хабаровский край;RU-AMU Амурская область;RU-ARK Архангельская область;RU-AST Астраханская область;RU-BEL Белгородская область;RU-BRY Брянская область;RU-VLA Владимирская область;RU-VGG Волгоградская область;RU-VLG Вологодская область;RU-VOR Воронежская область;RU-IVA Ивановская область;RU-IRK Иркутская область;RU-KGD Калининградская область;RU-KLU Калужская область;RU-KEM Кемеровская область;RU-KIR Кировская область;RU-KOS Костромская область;RU-KGN Курганская область;RU-KRS Курская область;RU-LEN Ленинградская область;RU-LIP Липецкая область;RU-MAG Магаданская область;RU-MOS Московская область;RU-MUR Мурманская область;RU-NIZ Нижегородская область;RU-NGR Новгородская область;RU-NVS Новосибирская область;RU-OMS Омская область;RU-ORE Оренбургская область;RU-ORL Орловская область;RU-PNZ Пензенская область;RU-PSK Псковская область;RU-ROS Ростовская область;RU-RYA Рязанская область;RU-SAM Самарская область;RU-SAR Саратовская область;RU-SAK Сахалинская область;RU-SVE Свердловская область;RU-SMO Смоленская область;RU-TAM Тамбовская область;RU-TVE Тверская область;RU-TOM Томская область;RU-TUL Тульская область;RU-TYU Тюменская область;RU-ULY Ульяновская область;RU-CHE Челябинская область;RU-YAR Ярославская область;RU-MOW Москва;RU-SPE Санкт-Петербург;RU-SEV Севастополь;RU-YEV Еврейская автономная область;RU-NEN Ненецкий автономный округ;RU-KHM Ханты-Мансийский автономный округ - Югра;RU-CHU Чукотский автономный округ;RU-YAN Ямало-Ненецкий автономный округ;— Байконур (Казахстан)";
        }
        public bool CheckVIN(string vin)
        {
            string text = "1234567890ABCDEFGHJKLMNOPRSTUVWXYZ";
            string text2 = text;
            for (int i = 0; i < text2.Length; i++)
            {
                if (!text.Contains(text2[i].ToString()))
                {
                    return false;
                }
            }
            if (vin.Length != 17)
            {
                return false;
            }
            string text3 = vin.Substring(13, 4);
            foreach (char c in text3)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public string GetVINCountry(string vin)
        {
            string text = vin.Substring(0, 2);
            string[] array = _countryData.Split(';');
            List<string> list = new List<string>();
            for (int i = 0; i < 86; i++)
            {
                if (text[0] == array[i][0])
                {
                    list.Add(array[i]);
                }
            }

            for (int j = 0; j < list.Count; j++)
            {
                char c = list[j][1];
                char c2 = list[j][4];
                string text2 = "123457890";
                if (text[1] == c && text[1] <= c2)
                {
                    List<string> list2 = list[j].Split(' ').ToList();
                    string text3 = "";
                    for (int k = 1; k < list2.Count(); k++)
                    {
                        text3 = text3 + list2[k] + " ";
                    }
                    text3 = text3.Trim(' ');
                    return text3.Trim(' ');
                }
            }

            return "Не назначен";
        }
        public int GetTransportYear(string vin)
        {
            string key = vin[9].ToString();
            return _years[key];
        }
    }
}
