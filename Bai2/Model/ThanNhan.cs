namespace lab2_2.Model
{
    public class ThanNhan
    {
        public string Ma_NV {  get; set; }
        public string TenTN { get; set; }
        public string? Phai { get; set; }
        public DateTime? NgSinh { get; set; }
        public string? QuanHe { get; set; }
       public NhanVien NhanVien { get; set; }
    }
}
