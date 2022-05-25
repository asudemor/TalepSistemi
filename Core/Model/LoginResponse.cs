using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class LoginResponse
    {
        public EmployeeResponse Employee { get; set; }
        public List<MenuResponse> Auth { get; set; }
    }
    public class EmployeeResponse
    {
        public string username { get; set; }
        public string adsoyad { get; set; }
        public string departman { get; set; }
        public int departmanId { get; set; }
        public string mail { get; set; }
        public string pozisyon { get; set; }
        public string sicil { get; set; }
        public string subeadi { get; set; }
        public string yonetici { get; set; }
        public bool status { get; set; }
        public int subekodu { get; set; }
        public bool isHukukDanismani { get; set; }
        public int locationId { get; set; }
        public bool IsPersonel { get; set; }
    }
    public class MenuResponse
    {
        public int module_id { get; set; }
        public int ana_modul_id { get; set; }
        public string icon { get; set; }
        public int siralama { get; set; }
        public string url { get; set; }
        public string ad { get; set; }
    }
}
