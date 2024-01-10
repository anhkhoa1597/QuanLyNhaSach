using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CNPM.DataAccessTier;
using CNPM.DesignPatterns;

namespace CNPM
{
    interface ISachFactory
    {
        DataTable getTable(Sach sach = null);
        Sach getSachbyID(int ma_sach);
        int Them(Sach sach);
        bool Sua(Sach sach);
    }
    class SachBLT:ISachFactory, IPublisher
    {
        SachDAT objSach = new SachDAT();
        private static SachBLT instance;

        private SachBLT() { }

        public static SachBLT Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SachBLT();
                }
                return instance;
            }
        }

        private List<ISubcriber> subcribers = new List<ISubcriber>();

        public void Subcribe(ISubcriber subcriber)
        {
            subcribers.Add(subcriber);
            Console.WriteLine("this is SachBLT, subcriber updated!!!");
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

        public DataTable getTable(Sach sach = null)
        {
            if (sach == null)
                return objSach.getSachTable();
            else
                return objSach.getTraCuuSachTable(sach);
        }

        public Sach getSachbyID(int ma_sach)
        {
            return objSach.getSach(ma_sach);
        }

        public int Them(Sach sach)
        {
            Notify();
            return objSach.Them(sach);
        }

        public bool Sua(Sach sach)
        {
            if (objSach.Check(sach.MaSach))
                return objSach.Sua(sach);
            return false;
        }
    }
}
