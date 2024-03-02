namespace CShar.Lab5
{
    public class DuocPham
    {
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public double DonViTinh { get; set; } // Đơn vị tính là miligram

        public DuocPham(string ten, int soLuong, double donViTinh)
        {
            Ten = ten;
            SoLuong = soLuong;
            DonViTinh = donViTinh;
        }

        public override string ToString()
        {
            return $"Tên: {Ten}, Số lượng: {SoLuong}, Đơn vị tính: {DonViTinh} mg";
        }
    }


}