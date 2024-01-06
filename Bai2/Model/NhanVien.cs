using System.ComponentModel.DataAnnotations;

namespace lab2_2.Model
{
    public class NhanVien
    {
        public string? Honv { get; set; }
        public string? TenLot { get; set; }
        public string? TenNV { get; set; }
        [Key]
        public string MaNV { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DChi { get; set; }
        public string? Phai { get; set; }
        public float? Luong { get; set; }
        public string? MaNQL { get; set; }
        public int PHG { get; set; }
        public List<ThanNhan> thanNhans { get; set; }

    }
}
