using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btnhom.Data;

namespace btnhom.Model
{
    public static class MatHangBL
    {
        public static List<MatHang>GetAll()
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                return db.MatHangs.ToList();
            }
            catch (Exception ex) { throw (ex); }
        }
        public static MatHang FindById(int id)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                return db.MatHangs.Find(id);
            }
            catch { return null; }
        }
        public static bool AddMatHang(MatHang x)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                db.MatHangs.Add(x);
                db.SaveChanges();
                return true;
            }catch { return false; } 
        }
        public static bool UpdateMatHang(MatHang x, int id)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                MatHang old = db.MatHangs.Find(id) ;
                old.name = x.name;
                old.GiaBan = x.GiaBan;
                old.GiaNhap = x.GiaNhap;
                old.SoLuongTon = x.SoLuongTon;
                old.NhaSX = x.NhaSX;
                old.idLH= x.idLH;
                old.XuatXu = x.XuatXu;
                old.DoTuoi = x.DoTuoi;
                old.GhiChu = x.GhiChu;
                db.SaveChanges();
                return true;
            }catch { return false; }
        }
        public static bool Remove(int id)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                MatHang x = db.MatHangs.Find(id);
                db.MatHangs.Attach(x);
                db.MatHangs.Remove(x);
                db.SaveChanges();
                return true;
            }catch { return false; }
        }
    }
}
