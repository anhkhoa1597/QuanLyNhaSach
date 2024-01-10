using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CNPM.DataAccessTier;
using CNPM.DesignPatterns;

namespace CNPM
{
    // Strategy...Test....
    interface INhapSachStrategy
    {
        bool KiemTraDieuKien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns);
        void ThucHien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns);
    }

    class DefaultNhapSachStrategy : INhapSachStrategy
    {
        SachBLT objSach = SachBLT.Instance;
        private ThamSoDAT objThamSo = new ThamSoDAT();
        private NhapSachDAT objNhapSach = new NhapSachDAT();

        public bool KiemTraDieuKien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            for (int i = 0; i < list_ctns.Count; i++)
            {
                if (list_ctns[i].SoLuongNhap < objThamSo.GetQDNhapSachVeSoLuong())
                    return false;
                Sach sach = objSach.getSachbyID(list_ctns[i].MaSach);
                if (sach == null || sach.SoLuongTon > objThamSo.GetQDNhapSachVeLuongTon())
                    return false;
            }
            return true;
        }

        public void ThucHien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            nhapSach.MaPhieuNhap = objNhapSach.ThemPhieuNhap(nhapSach);
            for (int i = 0; i < list_ctns.Count; i++)
            {
                list_ctns[i].MaPhieuNhap = nhapSach.MaPhieuNhap;
                objNhapSach.ThemChiTietNhapSach(list_ctns[i]);
                Sach sach = objSach.getSachbyID(list_ctns[i].MaSach);
                sach.SoLuongTon += list_ctns[i].SoLuongNhap;
                objSach.Sua(sach);
            }
        }
    }

    class BackupNhapSachStrategy : INhapSachStrategy
    {
        SachBLT objSach = SachBLT.Instance;
        private ThamSoDAT objThamSo = new ThamSoDAT();
        private NhapSachDAT objNhapSach = new NhapSachDAT();

        public bool KiemTraDieuKien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            for (int i = 0; i < list_ctns.Count; i++)
            {
                if (list_ctns[i].SoLuongNhap < objThamSo.GetQD2A())
                    return false;
                Sach sach = objSach.getSachbyID(list_ctns[i].MaSach);
                if (sach == null || sach.SoLuongTon > objThamSo.GetQD2B())
                    return false;
            }
            return true;
        }

        public void ThucHien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            nhapSach.MaPhieuNhap = objNhapSach.ThemPhieuNhap(nhapSach);
            for (int i = 0; i < list_ctns.Count; i++)
            {
                list_ctns[i].MaPhieuNhap = nhapSach.MaPhieuNhap;
                objNhapSach.ThemChiTietNhapSach(list_ctns[i]);
                Sach sach = objSach.getSachbyID(list_ctns[i].MaSach);
                sach.SoLuongTon += list_ctns[i].SoLuongNhap;
                objSach.Sua(sach);
            }
        }
    }

    class NhapSachBLT//: IPublisher
    {
        //Singleton
        private static NhapSachBLT instance;

        private NhapSachBLT() { }

        public static NhapSachBLT Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhapSachBLT();
                }
                return instance;
            }
        }



        //private INhapSachStrategy strategy;
        SachBLT objSach = SachBLT.Instance;
        private ThamSoDAT objThamSo = new ThamSoDAT();
        private NhapSachDAT objNhapSach = new NhapSachDAT();
        private List<ISubcriber> subcribers = new List<ISubcriber>();

        public void Subcribe(ISubcriber subcriber)
        {
            subcribers.Add(subcriber);
            Console.WriteLine("this is NhapSachBLT, subcriber updated!!!");
        }

        public void Unsubcribe(ISubcriber subcriber)
        {
            subcribers.Remove(subcriber);
        }

        public void Notify()
        {
            foreach (var subcriber in subcribers)
            {
                subcriber.UpdateByPublisher();
            }
        }

        //public NhapSachBLT(INhapSachStrategy strategy)
        //{
        //    this.strategy = strategy;
        //}


        public bool Them(NhapSach nhap_sach, List<ChiTietNhapSach> list_ctns)
        {
            if (this.KiemTraDieuKien(nhap_sach, list_ctns))
            {
                this.ThucHien(nhap_sach, list_ctns);
                return true;
            }
            return false;
        }

        public bool KiemTraDieuKien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            for (int i = 0; i < list_ctns.Count; i++)
            {
                if (list_ctns[i].SoLuongNhap < objThamSo.GetQDNhapSachVeSoLuong())
                    return false;
                Sach sach = objSach.getSachbyID(list_ctns[i].MaSach);
                if (sach == null || sach.SoLuongTon > objThamSo.GetQDNhapSachVeLuongTon())
                    return false;
            }
            return true;
        }

        public void ThucHien(NhapSach nhapSach, List<ChiTietNhapSach> list_ctns)
        {
            nhapSach.MaPhieuNhap = objNhapSach.ThemPhieuNhap(nhapSach);
            for (int i = 0; i < list_ctns.Count; i++)
            {
                list_ctns[i].MaPhieuNhap = nhapSach.MaPhieuNhap;
                objNhapSach.ThemChiTietNhapSach(list_ctns[i]);
                Sach sach = objSach.getSachbyID(list_ctns[i].MaSach);
                sach.SoLuongTon += list_ctns[i].SoLuongNhap;
                objSach.Sua(sach);
            }
        }
    }
}
