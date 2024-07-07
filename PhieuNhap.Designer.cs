﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DANHOM.Module.QLCuaHangPB
{

    public partial class PhieuNhap : XPLiteObject
    {
        string fMaNhap;
        [Key]
        [Size(10)]
        [DevExpress.Xpo.DisplayName(@"Mã nhập")]
        public string MaNhap
        {
            get { return fMaNhap; }
            set { SetPropertyValue<string>(nameof(MaNhap), ref fMaNhap, value); }
        }
        string fTenNhap;
        [Size(30)]
        [DevExpress.Xpo.DisplayName(@"Tên nhập")]
        public string TenNhap
        {
            get { return fTenNhap; }
            set { SetPropertyValue<string>(nameof(TenNhap), ref fTenNhap, value); }
        }
        int fSoLuong;
        [DevExpress.Xpo.DisplayName(@"Số lượng")]
        public int SoLuong
        {
            get { return fSoLuong; }
            set { SetPropertyValue<int>(nameof(SoLuong), ref fSoLuong, value); }
        }
        int fDonGia;
        [DevExpress.Xpo.DisplayName(@"Đơn giá")]
        public int DonGia
        {
            get { return fDonGia; }
            set { SetPropertyValue<int>(nameof(DonGia), ref fDonGia, value); }
        }
        DateTime fNgayNhap;
        [DevExpress.Xpo.DisplayName(@"Ngày nhập")]
        public DateTime NgayNhap
        {
            get { return fNgayNhap; }
            set { SetPropertyValue<DateTime>(nameof(NgayNhap), ref fNgayNhap, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Thành tiền")]
        public int ThanhTien
        {
            get
            {
                return SoLuong * DonGia;
            }
        }
        NhanVien fMaNV;
        [Size(10)]
        [Association(@"PhieuNhapReferencesNhanVien")]
        [DevExpress.Xpo.DisplayName(@"Mã nhân viên")]
        public NhanVien MaNV
        {
            get { return fMaNV; }
            set { SetPropertyValue<NhanVien>(nameof(MaNV), ref fMaNV, value); }
        }
        DaiLy fMaDL;
        [Size(10)]
        [Association(@"PhieuNhapReferencesDaiLy")]
        [DevExpress.Xpo.DisplayName(@"Mã đại lý")]
        public DaiLy MaDL
        {
            get { return fMaDL; }
            set { SetPropertyValue<DaiLy>(nameof(MaDL), ref fMaDL, value); }
        }
        [Association(@"ThuChiReferencesPhieuNhap")]
        public XPCollection<ThuChi> ThuChis { get { return GetCollection<ThuChi>(nameof(ThuChis)); } }
    }

}
