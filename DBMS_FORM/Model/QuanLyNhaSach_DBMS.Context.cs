﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBMS_FORM.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class DOAN_QUANLYNHASACH_DBMSEntities : DbContext
    {
        public DOAN_QUANLYNHASACH_DBMSEntities()
            : base("name=DOAN_QUANLYNHASACH_DBMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CungCap> CungCaps { get; set; }
        public DbSet<DaBan> DaBans { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<Muon> Muons { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NV> NVs { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Sach> Saches { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<ThanhVien> ThanhViens { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fluongNV")]
        public virtual IQueryable<fluongNV_Result> fluongNV()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fluongNV_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fluongNV]()");
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fThanhVien")]
        public virtual IQueryable<fThanhVien_Result> fThanhVien()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fThanhVien_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fThanhVien]()");
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fun_DanhSachNhanVien")]
        public virtual IQueryable<fun_DanhSachNhanVien_Result> fun_DanhSachNhanVien()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fun_DanhSachNhanVien_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fun_DanhSachNhanVien]()");
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fun_DanhSachQuanLy")]
        public virtual IQueryable<fun_DanhSachQuanLy_Result> fun_DanhSachQuanLy()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fun_DanhSachQuanLy_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fun_DanhSachQuanLy]()");
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fun_SachCon")]
        public virtual IQueryable<fun_SachCon_Result> fun_SachCon()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fun_SachCon_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fun_SachCon]()");
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fun_SearchNhanVien")]
        public virtual IQueryable<fun_SearchNhanVien_Result> fun_SearchNhanVien(string nv)
        {
            var nvParameter = nv != null ?
                new ObjectParameter("nv", nv) :
                new ObjectParameter("nv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fun_SearchNhanVien_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fun_SearchNhanVien](@nv)", nvParameter);
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fun_SearchSach")]
        public virtual IQueryable<fun_SearchSach_Result> fun_SearchSach(string searchSach)
        {
            var searchSachParameter = searchSach != null ?
                new ObjectParameter("searchSach", searchSach) :
                new ObjectParameter("searchSach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fun_SearchSach_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fun_SearchSach](@searchSach)", searchSachParameter);
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fun_SearchThanhVien")]
        public virtual IQueryable<fun_SearchThanhVien_Result> fun_SearchThanhVien(string searchThanhVien)
        {
            var searchThanhVienParameter = searchThanhVien != null ?
                new ObjectParameter("searchThanhVien", searchThanhVien) :
                new ObjectParameter("searchThanhVien", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fun_SearchThanhVien_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fun_SearchThanhVien](@searchThanhVien)", searchThanhVienParameter);
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fun_ThanhVien")]
        public virtual IQueryable<fun_ThanhVien_Result> fun_ThanhVien()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fun_ThanhVien_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fun_ThanhVien]()");
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fuNhanvienOfQl")]
        public virtual IQueryable<fuNhanvienOfQl_Result> fuNhanvienOfQl(Nullable<int> maNQL)
        {
            var maNQLParameter = maNQL.HasValue ?
                new ObjectParameter("maNQL", maNQL) :
                new ObjectParameter("maNQL", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fuNhanvienOfQl_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fuNhanvienOfQl](@maNQL)", maNQLParameter);
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "LowestSelling")]
        public virtual IQueryable<LowestSelling_Result> LowestSelling()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<LowestSelling_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[LowestSelling]()");
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "MuonQuaHan")]
        public virtual IQueryable<MuonQuaHan_Result> MuonQuaHan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<MuonQuaHan_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[MuonQuaHan]()");
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "NVinHD")]
        public virtual IQueryable<NVinHD_Result> NVinHD(Nullable<int> maHD)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("maHD", maHD) :
                new ObjectParameter("maHD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<NVinHD_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[NVinHD](@maHD)", maHDParameter);
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "SearchNhaCC")]
        public virtual IQueryable<SearchNhaCC_Result> SearchNhaCC(string search)
        {
            var searchParameter = search != null ?
                new ObjectParameter("search", search) :
                new ObjectParameter("search", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SearchNhaCC_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[SearchNhaCC](@search)", searchParameter);
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "TurnoverByDay")]
        public virtual IQueryable<TurnoverByDay_Result> TurnoverByDay()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TurnoverByDay_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[TurnoverByDay]()");
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "TurnoverByMonth")]
        public virtual IQueryable<TurnoverByMonth_Result> TurnoverByMonth(Nullable<System.DateTime> yearNow)
        {
            var yearNowParameter = yearNow.HasValue ?
                new ObjectParameter("yearNow", yearNow) :
                new ObjectParameter("yearNow", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TurnoverByMonth_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[TurnoverByMonth](@yearNow)", yearNowParameter);
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "TurnoverByYear")]
        public virtual IQueryable<TurnoverByYear_Result> TurnoverByYear()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TurnoverByYear_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[TurnoverByYear]()");
        }
    
        public virtual ObjectResult<string> Add_ThanhVien(Nullable<int> maTV, string hoVaTenTV, string soDT, string diaChi, string mail, Nullable<int> conSD, Nullable<int> mDThanThiet)
        {
            var maTVParameter = maTV.HasValue ?
                new ObjectParameter("MaTV", maTV) :
                new ObjectParameter("MaTV", typeof(int));
    
            var hoVaTenTVParameter = hoVaTenTV != null ?
                new ObjectParameter("HoVaTenTV", hoVaTenTV) :
                new ObjectParameter("HoVaTenTV", typeof(string));
    
            var soDTParameter = soDT != null ?
                new ObjectParameter("SoDT", soDT) :
                new ObjectParameter("SoDT", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var conSDParameter = conSD.HasValue ?
                new ObjectParameter("ConSD", conSD) :
                new ObjectParameter("ConSD", typeof(int));
    
            var mDThanThietParameter = mDThanThiet.HasValue ?
                new ObjectParameter("MDThanThiet", mDThanThiet) :
                new ObjectParameter("MDThanThiet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Add_ThanhVien", maTVParameter, hoVaTenTVParameter, soDTParameter, diaChiParameter, mailParameter, conSDParameter, mDThanThietParameter);
        }
    
        public virtual int CheckMuon(Nullable<int> mTV, Nullable<int> mS, Nullable<int> soLuong, ObjectParameter status, ObjectParameter status2)
        {
            var mTVParameter = mTV.HasValue ?
                new ObjectParameter("MTV", mTV) :
                new ObjectParameter("MTV", typeof(int));
    
            var mSParameter = mS.HasValue ?
                new ObjectParameter("MS", mS) :
                new ObjectParameter("MS", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CheckMuon", mTVParameter, mSParameter, soLuongParameter, status, status2);
        }
    
        public virtual int deleteSach(Nullable<int> maSach)
        {
            var maSachParameter = maSach.HasValue ?
                new ObjectParameter("maSach", maSach) :
                new ObjectParameter("maSach", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("deleteSach", maSachParameter);
        }
    
        public virtual int IMPORTSACH(Nullable<int> mS, string tS, Nullable<int> dG, Nullable<System.DateTime> nN, string nXB, Nullable<int> mTL, Nullable<int> soluong, Nullable<int> mNQL, Nullable<int> mNCC)
        {
            var mSParameter = mS.HasValue ?
                new ObjectParameter("MS", mS) :
                new ObjectParameter("MS", typeof(int));
    
            var tSParameter = tS != null ?
                new ObjectParameter("TS", tS) :
                new ObjectParameter("TS", typeof(string));
    
            var dGParameter = dG.HasValue ?
                new ObjectParameter("DG", dG) :
                new ObjectParameter("DG", typeof(int));
    
            var nNParameter = nN.HasValue ?
                new ObjectParameter("NN", nN) :
                new ObjectParameter("NN", typeof(System.DateTime));
    
            var nXBParameter = nXB != null ?
                new ObjectParameter("NXB", nXB) :
                new ObjectParameter("NXB", typeof(string));
    
            var mTLParameter = mTL.HasValue ?
                new ObjectParameter("MTL", mTL) :
                new ObjectParameter("MTL", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("Soluong", soluong) :
                new ObjectParameter("Soluong", typeof(int));
    
            var mNQLParameter = mNQL.HasValue ?
                new ObjectParameter("MNQL", mNQL) :
                new ObjectParameter("MNQL", typeof(int));
    
            var mNCCParameter = mNCC.HasValue ?
                new ObjectParameter("MNCC", mNCC) :
                new ObjectParameter("MNCC", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("IMPORTSACH", mSParameter, tSParameter, dGParameter, nNParameter, nXBParameter, mTLParameter, soluongParameter, mNQLParameter, mNCCParameter);
        }
    
        public virtual int INSERTBAN(Nullable<int> flag, Nullable<int> mANV, Nullable<int> mS, Nullable<int> soLuong, Nullable<System.DateTime> nBan, Nullable<int> mHD, Nullable<System.DateTime> nXuat, Nullable<int> tongTien, Nullable<bool> dXOA)
        {
            var flagParameter = flag.HasValue ?
                new ObjectParameter("flag", flag) :
                new ObjectParameter("flag", typeof(int));
    
            var mANVParameter = mANV.HasValue ?
                new ObjectParameter("MANV", mANV) :
                new ObjectParameter("MANV", typeof(int));
    
            var mSParameter = mS.HasValue ?
                new ObjectParameter("MS", mS) :
                new ObjectParameter("MS", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var nBanParameter = nBan.HasValue ?
                new ObjectParameter("NBan", nBan) :
                new ObjectParameter("NBan", typeof(System.DateTime));
    
            var mHDParameter = mHD.HasValue ?
                new ObjectParameter("MHD", mHD) :
                new ObjectParameter("MHD", typeof(int));
    
            var nXuatParameter = nXuat.HasValue ?
                new ObjectParameter("NXuat", nXuat) :
                new ObjectParameter("NXuat", typeof(System.DateTime));
    
            var tongTienParameter = tongTien.HasValue ?
                new ObjectParameter("TongTien", tongTien) :
                new ObjectParameter("TongTien", typeof(int));
    
            var dXOAParameter = dXOA.HasValue ?
                new ObjectParameter("DXOA", dXOA) :
                new ObjectParameter("DXOA", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTBAN", flagParameter, mANVParameter, mSParameter, soLuongParameter, nBanParameter, mHDParameter, nXuatParameter, tongTienParameter, dXOAParameter);
        }
    
        public virtual int INSERTBANTV(Nullable<int> flag, Nullable<int> mANV, Nullable<int> mS, Nullable<int> soLuong, Nullable<System.DateTime> nBan, Nullable<int> mHD, Nullable<System.DateTime> nXuat, Nullable<int> tongTien, Nullable<int> gIAMGIA, Nullable<int> mTV)
        {
            var flagParameter = flag.HasValue ?
                new ObjectParameter("flag", flag) :
                new ObjectParameter("flag", typeof(int));
    
            var mANVParameter = mANV.HasValue ?
                new ObjectParameter("MANV", mANV) :
                new ObjectParameter("MANV", typeof(int));
    
            var mSParameter = mS.HasValue ?
                new ObjectParameter("MS", mS) :
                new ObjectParameter("MS", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var nBanParameter = nBan.HasValue ?
                new ObjectParameter("NBan", nBan) :
                new ObjectParameter("NBan", typeof(System.DateTime));
    
            var mHDParameter = mHD.HasValue ?
                new ObjectParameter("MHD", mHD) :
                new ObjectParameter("MHD", typeof(int));
    
            var nXuatParameter = nXuat.HasValue ?
                new ObjectParameter("NXuat", nXuat) :
                new ObjectParameter("NXuat", typeof(System.DateTime));
    
            var tongTienParameter = tongTien.HasValue ?
                new ObjectParameter("TongTien", tongTien) :
                new ObjectParameter("TongTien", typeof(int));
    
            var gIAMGIAParameter = gIAMGIA.HasValue ?
                new ObjectParameter("GIAMGIA", gIAMGIA) :
                new ObjectParameter("GIAMGIA", typeof(int));
    
            var mTVParameter = mTV.HasValue ?
                new ObjectParameter("MTV", mTV) :
                new ObjectParameter("MTV", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTBANTV", flagParameter, mANVParameter, mSParameter, soLuongParameter, nBanParameter, mHDParameter, nXuatParameter, tongTienParameter, gIAMGIAParameter, mTVParameter);
        }
    
        public virtual int InsertMuon(Nullable<int> flag, Nullable<int> mATV, Nullable<int> mS, Nullable<int> mANV, Nullable<int> soLuong, Nullable<System.DateTime> nMuon, Nullable<System.DateTime> nTra, Nullable<int> mHD, Nullable<System.DateTime> nXuat, Nullable<int> tongTien, Nullable<int> giamGia, Nullable<bool> dXOA, Nullable<bool> thanhVien)
        {
            var flagParameter = flag.HasValue ?
                new ObjectParameter("flag", flag) :
                new ObjectParameter("flag", typeof(int));
    
            var mATVParameter = mATV.HasValue ?
                new ObjectParameter("MATV", mATV) :
                new ObjectParameter("MATV", typeof(int));
    
            var mSParameter = mS.HasValue ?
                new ObjectParameter("MS", mS) :
                new ObjectParameter("MS", typeof(int));
    
            var mANVParameter = mANV.HasValue ?
                new ObjectParameter("MANV", mANV) :
                new ObjectParameter("MANV", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var nMuonParameter = nMuon.HasValue ?
                new ObjectParameter("NMuon", nMuon) :
                new ObjectParameter("NMuon", typeof(System.DateTime));
    
            var nTraParameter = nTra.HasValue ?
                new ObjectParameter("NTra", nTra) :
                new ObjectParameter("NTra", typeof(System.DateTime));
    
            var mHDParameter = mHD.HasValue ?
                new ObjectParameter("MHD", mHD) :
                new ObjectParameter("MHD", typeof(int));
    
            var nXuatParameter = nXuat.HasValue ?
                new ObjectParameter("NXuat", nXuat) :
                new ObjectParameter("NXuat", typeof(System.DateTime));
    
            var tongTienParameter = tongTien.HasValue ?
                new ObjectParameter("TongTien", tongTien) :
                new ObjectParameter("TongTien", typeof(int));
    
            var giamGiaParameter = giamGia.HasValue ?
                new ObjectParameter("GiamGia", giamGia) :
                new ObjectParameter("GiamGia", typeof(int));
    
            var dXOAParameter = dXOA.HasValue ?
                new ObjectParameter("DXOA", dXOA) :
                new ObjectParameter("DXOA", typeof(bool));
    
            var thanhVienParameter = thanhVien.HasValue ?
                new ObjectParameter("ThanhVien", thanhVien) :
                new ObjectParameter("ThanhVien", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertMuon", flagParameter, mATVParameter, mSParameter, mANVParameter, soLuongParameter, nMuonParameter, nTraParameter, mHDParameter, nXuatParameter, tongTienParameter, giamGiaParameter, dXOAParameter, thanhVienParameter);
        }
    
        public virtual int InsertPersonalDetailsAndAccount(string firstName, string lastName, Nullable<short> age, Nullable<bool> active, Nullable<decimal> salary, Nullable<decimal> pPFDeduction)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var ageParameter = age.HasValue ?
                new ObjectParameter("Age", age) :
                new ObjectParameter("Age", typeof(short));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(bool));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("Salary", salary) :
                new ObjectParameter("Salary", typeof(decimal));
    
            var pPFDeductionParameter = pPFDeduction.HasValue ?
                new ObjectParameter("PPFDeduction", pPFDeduction) :
                new ObjectParameter("PPFDeduction", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPersonalDetailsAndAccount", firstNameParameter, lastNameParameter, ageParameter, activeParameter, salaryParameter, pPFDeductionParameter);
        }
    
        public virtual ObjectResult<string> SettingThanhVien(string action, Nullable<int> maTV, string hoVaTenTV, string soDT, string diaChi, string mail, Nullable<int> mDThanThiet)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var maTVParameter = maTV.HasValue ?
                new ObjectParameter("MaTV", maTV) :
                new ObjectParameter("MaTV", typeof(int));
    
            var hoVaTenTVParameter = hoVaTenTV != null ?
                new ObjectParameter("HoVaTenTV", hoVaTenTV) :
                new ObjectParameter("HoVaTenTV", typeof(string));
    
            var soDTParameter = soDT != null ?
                new ObjectParameter("SoDT", soDT) :
                new ObjectParameter("SoDT", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var mDThanThietParameter = mDThanThiet.HasValue ?
                new ObjectParameter("MDThanThiet", mDThanThiet) :
                new ObjectParameter("MDThanThiet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SettingThanhVien", actionParameter, maTVParameter, hoVaTenTVParameter, soDTParameter, diaChiParameter, mailParameter, mDThanThietParameter);
        }
    
        public virtual ObjectResult<string> sp_AddNV(Nullable<int> manv, string hoten, string sdt, string dc, Nullable<int> sosachban, Nullable<int> luongnv, Nullable<int> ngayvang, string username, string password, Nullable<int> typeId, Nullable<int> manql, Nullable<int> danghi)
        {
            var manvParameter = manv.HasValue ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(int));
    
            var hotenParameter = hoten != null ?
                new ObjectParameter("hoten", hoten) :
                new ObjectParameter("hoten", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var dcParameter = dc != null ?
                new ObjectParameter("dc", dc) :
                new ObjectParameter("dc", typeof(string));
    
            var sosachbanParameter = sosachban.HasValue ?
                new ObjectParameter("sosachban", sosachban) :
                new ObjectParameter("sosachban", typeof(int));
    
            var luongnvParameter = luongnv.HasValue ?
                new ObjectParameter("luongnv", luongnv) :
                new ObjectParameter("luongnv", typeof(int));
    
            var ngayvangParameter = ngayvang.HasValue ?
                new ObjectParameter("ngayvang", ngayvang) :
                new ObjectParameter("ngayvang", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var typeIdParameter = typeId.HasValue ?
                new ObjectParameter("TypeId", typeId) :
                new ObjectParameter("TypeId", typeof(int));
    
            var manqlParameter = manql.HasValue ?
                new ObjectParameter("manql", manql) :
                new ObjectParameter("manql", typeof(int));
    
            var danghiParameter = danghi.HasValue ?
                new ObjectParameter("danghi", danghi) :
                new ObjectParameter("danghi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_AddNV", manvParameter, hotenParameter, sdtParameter, dcParameter, sosachbanParameter, luongnvParameter, ngayvangParameter, usernameParameter, passwordParameter, typeIdParameter, manqlParameter, danghiParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int SP_DeleteUSER_MANAGEMENT(Nullable<int> userId, string method)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var methodParameter = method != null ?
                new ObjectParameter("Method", method) :
                new ObjectParameter("Method", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DeleteUSER_MANAGEMENT", userIdParameter, methodParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_EditNV(Nullable<int> macu, Nullable<int> mamoi, string hotenmoi, string sdtm, string dcm, Nullable<int> luongnvmoi, Nullable<int> ngayvangmoi)
        {
            var macuParameter = macu.HasValue ?
                new ObjectParameter("macu", macu) :
                new ObjectParameter("macu", typeof(int));
    
            var mamoiParameter = mamoi.HasValue ?
                new ObjectParameter("mamoi", mamoi) :
                new ObjectParameter("mamoi", typeof(int));
    
            var hotenmoiParameter = hotenmoi != null ?
                new ObjectParameter("hotenmoi", hotenmoi) :
                new ObjectParameter("hotenmoi", typeof(string));
    
            var sdtmParameter = sdtm != null ?
                new ObjectParameter("sdtm", sdtm) :
                new ObjectParameter("sdtm", typeof(string));
    
            var dcmParameter = dcm != null ?
                new ObjectParameter("dcm", dcm) :
                new ObjectParameter("dcm", typeof(string));
    
            var luongnvmoiParameter = luongnvmoi.HasValue ?
                new ObjectParameter("luongnvmoi", luongnvmoi) :
                new ObjectParameter("luongnvmoi", typeof(int));
    
            var ngayvangmoiParameter = ngayvangmoi.HasValue ?
                new ObjectParameter("ngayvangmoi", ngayvangmoi) :
                new ObjectParameter("ngayvangmoi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EditNV", macuParameter, mamoiParameter, hotenmoiParameter, sdtmParameter, dcmParameter, luongnvmoiParameter, ngayvangmoiParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int thanhvienUpdate(Nullable<int> maTV, Nullable<int> maTVCu, string hoVaTenTV, string soDT, string diaChi, string mail, Nullable<int> mDThanThiet)
        {
            var maTVParameter = maTV.HasValue ?
                new ObjectParameter("MaTV", maTV) :
                new ObjectParameter("MaTV", typeof(int));
    
            var maTVCuParameter = maTVCu.HasValue ?
                new ObjectParameter("MaTVCu", maTVCu) :
                new ObjectParameter("MaTVCu", typeof(int));
    
            var hoVaTenTVParameter = hoVaTenTV != null ?
                new ObjectParameter("HoVaTenTV", hoVaTenTV) :
                new ObjectParameter("HoVaTenTV", typeof(string));
    
            var soDTParameter = soDT != null ?
                new ObjectParameter("SoDT", soDT) :
                new ObjectParameter("SoDT", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var mDThanThietParameter = mDThanThiet.HasValue ?
                new ObjectParameter("MDThanThiet", mDThanThiet) :
                new ObjectParameter("MDThanThiet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("thanhvienUpdate", maTVParameter, maTVCuParameter, hoVaTenTVParameter, soDTParameter, diaChiParameter, mailParameter, mDThanThietParameter);
        }
    
        public virtual int Tv_Delete(Nullable<int> idTV, string method)
        {
            var idTVParameter = idTV.HasValue ?
                new ObjectParameter("IdTV", idTV) :
                new ObjectParameter("IdTV", typeof(int));
    
            var methodParameter = method != null ?
                new ObjectParameter("Method", method) :
                new ObjectParameter("Method", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Tv_Delete", idTVParameter, methodParameter);
        }
    
        public virtual int CheckBan(Nullable<int> mS, Nullable<int> soLuong, ObjectParameter status, ObjectParameter status2)
        {
            var mSParameter = mS.HasValue ?
                new ObjectParameter("MS", mS) :
                new ObjectParameter("MS", typeof(int));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CheckBan", mSParameter, soLuongParameter, status, status2);
        }
    
        public virtual int createDbmsUser(string username, string password, string role)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var roleParameter = role != null ?
                new ObjectParameter("role", role) :
                new ObjectParameter("role", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("createDbmsUser", usernameParameter, passwordParameter, roleParameter);
        }
    
        [EdmFunction("DOAN_QUANLYNHASACH_DBMSEntities", "fun_checkLogin")]
        public virtual IQueryable<fun_checkLogin_Result> fun_checkLogin(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fun_checkLogin_Result>("[DOAN_QUANLYNHASACH_DBMSEntities].[fun_checkLogin](@username, @password)", usernameParameter, passwordParameter);
        }
    }
}
