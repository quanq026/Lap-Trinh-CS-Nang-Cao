sing System;
public interface IHinh
{
    double TinhDienTich();
    double TinhChuVi();
}
public class HinhTron : IHinh
{
    public double BanKinh { get; set ; }

    public HinhTron(double banKinh)
    {
        if (banKinh <= 0)
        {
            throw new ArgumentException("Ban kinh phai lon hon 0.");
        }   
        BanKinh = banKinh;
    }

    public double TinhDienTich()
    {
        return Math.PI * BanKinh * BanKinh;
    }

    public double TinhChuVi()
    {
        return 2 * Math.PI * BanKinh;
    }
}
