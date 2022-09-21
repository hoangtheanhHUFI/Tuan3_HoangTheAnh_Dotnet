namespace Tuan3_HoangTheAnh.Models
{
    public class modelSach
    {
        public string tenSach { get; set; }
        public double dongiaSach { get; set; }
        public string hinhSach { get; set; }
        public modelSach()
        {
            tenSach = "Sach A";
            dongiaSach = 0;
            hinhSach = "/lib/image/img.jpg";

        }
        public modelSach(string tenSach, double dongiaSach, string hinhSach)
        {
            this.tenSach = tenSach;
            this.dongiaSach = dongiaSach;
            this.hinhSach = hinhSach;
        }
    }
}
