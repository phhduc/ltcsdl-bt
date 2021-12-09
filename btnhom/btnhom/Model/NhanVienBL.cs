using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btnhom.Data;

namespace btnhom.Model
{
    public static class NhanVienBL
    {
        public static List<NhanVien> GetAll()
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                return db.NhanViens.ToList();
            }
            catch { return null; };
        }
        public static NhanVien FindById(int id)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                return db.NhanViens.Find(id);
            }
            catch { return null; }
        }
        public static bool AddNhanVien(NhanVien x)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                db.NhanViens.Add(x);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public static bool UpdateNhanVien(NhanVien x, int id)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                NhanVien old = db.NhanViens.Find(id);
                old.name = x.name;
                old.Sdt = x.Sdt;
                old.DiaChi = x.DiaChi;
                old.userName = x.userName;
                old.passWord = x.passWord;
                old.active=x.active;
                old.VaiTro = x.VaiTro;
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public static bool RemoveNhanVien(int id)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                db.NhanViens.Attach(FindById(id));
                db.NhanViens.Remove(db.NhanViens.Find(id));
                db.SaveChanges();
                return true;
            }catch { return false; }
        }
        
    }
}
