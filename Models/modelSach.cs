namespace Tuan3_HoangTheAnh.Models
{
    public class modelSach
    {
        public String id { get; set; }
        public string tenSach { get; set; }
        public double dongiaSach { get; set; }
        public string hinhSach { get; set; }
        public modelSach()
        {
            id = "0";
            tenSach = "Sach A";
            dongiaSach = 0;
            hinhSach = "/lib/image/img.jpg";

        }
        public modelSach(string id ,string tenSach, double dongiaSach, string hinhSach)
        {
            this.id = id;
            this.tenSach = tenSach;
            this.dongiaSach = dongiaSach;
            this.hinhSach = hinhSach;
        }
    }
}
