using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5_QuanLyPhongMay
{
    public class clsMayTinh:KetNoiCSDL
    {
        public DBQLPhongHocMayTinhDataContext dt;
        public clsMayTinh()
        {
            dt = getDatacontext();//o lop cha
        }
        public IEnumerable<lblMay> GetMayTinhThuocPhongHoc(String strMaPhong)
        {
            IEnumerable<lblMay> p = from n in dt.lblMays
                                        where n.id_Phong.Equals(strMaPhong)
                                        select n;
            return p;
        }
        /*
        public void InsertNewMT(lblMay newMT)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {

                dt.Transaction = myTran;
                dt.lblMays.InsertOnSubmit(newMT);// dua vao csdl tam thoi
                dt.SubmitChanges(); //dua vao csdl tam thoi
                dt.Transaction.Commit();// cap nhat khong quay lai duoc nhu shift+del
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();// hieu nhu ctrl+Z
                throw new Exception(ex.Message);
            }
        }
        */
        public IEnumerable<lblMay> GetMayTinhThuocPhong(string strMaPhong)
        {
            //var p = dt.tblPhonghocs.Select(a => a);
            //IEnumerable < tblPhonghoc >  p = dt.tblPhonghocs.Select(a => a);

            // var p = from n in dt.tblPhonghocs
            //                               select n;
            IEnumerable<lblMay> p = from n in dt.lblMays
                                        where n.id_Phong.Equals(strMaPhong)
                                        select n;
            //string sql = "select * from tblMayTinh where maphong= strMaPhong"; cac em da hoc
            return p;
        }


        public IEnumerable<lblMay> GetAllMayTinh()
        {
            IEnumerable<lblMay> p = from n in dt.lblMays
                                        select n;
            return p;
        }
        public lblMay TimKhiBietMa(String strMaMay)
        {
           lblMay mt = (from n in dt.lblMays
                             where n.id.Equals(strMaMay)
                             select n).FirstOrDefault();
            return mt;
        }

        public bool ThemMayTinh(lblMay may)
        {
            try
            {
                dt.lblMays.InsertOnSubmit(may);
                dt.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public void ThemMTMoi(lblMay newMT)//hàm thêm máy tính mới
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                dt.lblMays.InsertOnSubmit(newMT);//đưa vào CSDL
                dt.SubmitChanges();
                dt.Transaction.Commit();

            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                // throw new Exception(ex.Message);
            }
        }
    }
}
