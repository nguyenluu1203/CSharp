using System.Collections.Generic;
using System.Linq;

namespace CShar.Lab5
{
    public class QuanLyThuoc
{
    private List<Thuoc> danhSachThuoc = new List<Thuoc>();

    // Thêm thuốc mới vào danh sách
    public void ThemThuoc(Thuoc thuoc)
    {
        danhSachThuoc.Add(thuoc);
    }

    // Hiển thị danh sách thuốc theo danh mục
    public void HienThiTheoDanhMuc(string danhMuc)
    {
        Console.WriteLine($"Danh sách thuốc trong danh mục {danhMuc}:");
        foreach (var thuoc in danhSachThuoc.Where(t => t.DanhMuc == danhMuc))
        {
            Console.WriteLine($"Tên thuốc: {thuoc.Ten}, Số lượng: {thuoc.SoLuong}, Giá bán: {thuoc.GiaBan}");
        }
    }

    // Hiển thị thông tin chi tiết về một loại thuốc
    public void HienThiChiTietThuoc(string tenThuoc)
    {
        var thuoc = danhSachThuoc.FirstOrDefault(t => t.Ten == tenThuoc);
        if (thuoc != null)
        {
            thuoc.HienThiThongTin();
        }
        else
        {
            Console.WriteLine($"Không tìm thấy thông tin về thuốc {tenThuoc}");
        }
    }

    // Tìm kiếm thuốc theo tên
    public void TimKiemThuoc(string tenThuoc)
    {
        var thuoc = danhSachThuoc.FirstOrDefault(t => t.Ten == tenThuoc);
        if (thuoc != null)
        {
            Console.WriteLine($"Thông tin về thuốc {tenThuoc}:");
            Console.WriteLine($"Tên thuốc: {thuoc.Ten}, Số lượng: {thuoc.SoLuong}, Giá bán: {thuoc.GiaBan}, Danh mục: {thuoc.DanhMuc}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy thuốc có tên {tenThuoc}");
        }
    }

    // Cập nhật thông tin thuốc
    public void CapNhatThuoc(string tenThuoc, int soLuong, double giaBan, List<DuocPham> danhSachDuocPham)
    {
        var thuoc = danhSachThuoc.FirstOrDefault(t => t.Ten == tenThuoc);
        if (thuoc != null)
        {
            thuoc.SoLuong = soLuong;
            thuoc.GiaBan = giaBan;
            thuoc.DanhSachDuocPham = danhSachDuocPham;
            Console.WriteLine($"Đã cập nhật thông tin cho thuốc {tenThuoc}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy thuốc có tên {tenThuoc}");
        }
    }

    // Xóa thuốc
    public void XoaThuoc(string tenThuoc)
    {
        var thuoc = danhSachThuoc.FirstOrDefault(t => t.Ten == tenThuoc);
        if (thuoc != null)
        {
            danhSachThuoc.Remove(thuoc);
            Console.WriteLine($"Đã xóa thuốc {tenThuoc} khỏi danh sách");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy thuốc có tên {tenThuoc}");
        }
    }
}

}