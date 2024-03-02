using System.Collections.Generic;

namespace CShar.Lab5
{
    public class Thuoc
    {
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public double GiaBan { get; set; }
        public string DanhMuc { get; set; }
        public List<DuocPham> DanhSachDuocPham { get; set; }

        public Thuoc(string ten, int soLuong, double giaBan, string danhMuc)
        {
            Ten = ten;
            SoLuong = soLuong;
            GiaBan = giaBan;
            DanhMuc = danhMuc;
            DanhSachDuocPham = new List<DuocPham>();
        }

        // Thêm dược phẩm vào danh sách
        public void ThemDuocPham(DuocPham duocPham)
        {
            DanhSachDuocPham.Add(duocPham);
        }

        // Hiển thị thông tin chi tiết về thuốc
        public void HienThiThongTin()
        {
            Console.WriteLine($"Tên thuốc: {Ten}, Số lượng: {SoLuong}, Giá bán: {GiaBan}, Danh mục: {DanhMuc}");
            Console.WriteLine("Danh sách dược phẩm:");
            foreach (var duocPham in DanhSachDuocPham)
            {
                Console.WriteLine(duocPham);
            }
        }
    }

}