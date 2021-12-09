using btnhom.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btnhom.Model
{
    public static class LoaiBL
    {
        public static List<LoaiHang> GetAll()
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                return db.LoaiHangs.ToList();
            } catch { return null; }
        }
        public static LoaiHang FindById(int? id)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                 return db.LoaiHangs.Find(id);

            } catch { return null; }
        }
        public static bool AddLoaiHang(LoaiHang x)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                db.LoaiHangs.Add(x);
                db.SaveChanges();
                return true;
            } catch { return false; }
        }
        public static bool UpdateLoaiHang(LoaiHang x , int id)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                LoaiHang old = db.LoaiHangs.Find(id);
                old.name = x.name;
                old.idLH = x.idLH;
                old.description = x.description;
                db.SaveChanges();
                return true;
            } catch {  return false; }
        }
        public static bool RemoveLoaiHang(int id)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                db.LoaiHangs.Remove(db.LoaiHangs.Find(id));
                db.SaveChanges();
                return true;
            } catch {  return false; }
        }
        public static List<MatHang> GetMatHangOfLoaiHang(int id)
        {
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                return db.MatHangs.Where(x => x.idLH == id).ToList();
            }
            catch { return null; }
        }
        public static List<LoaiHang> GetLoaiHangCon(int? id)
        {
            if(id==null) return null;
            List<LoaiHang> rs = new List<LoaiHang> ();
            try
            {
                ToyStoreEntities db = new ToyStoreEntities();
                rs.AddRange(db.LoaiHangs.Where(x => x.idLH == id).ToList());
            }
            catch { };
            return rs;
        }
        public static List<MatHang> GetAllMatHangOfLoaiHang(int id)
        {
            List<MatHang> rs = new List<MatHang> ();
            rs.AddRange(GetMatHangOfLoaiHang(id));
            List<LoaiHang> lh = GetLoaiHangCon(id);
            foreach (var x in lh)
                rs.AddRange(GetAllMatHangOfLoaiHang(x.id));
            return rs.Distinct().ToList();
        }
        public static List<LoaiHang> GetBigestLoaiHangs()
        {
            return LoaiBL.GetAll().FindAll(x => x.idLH == null);
        }
    }
}
