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

    public partial class SanPham : XPLiteObject
    {
        string fMaSP;
        [Key]
        [Size(10)]
        [DevExpress.Xpo.DisplayName(@"Mã sản phẩm")]
        public string MaSP
        {
            get { return fMaSP; }
            set { SetPropertyValue<string>(nameof(MaSP), ref fMaSP, value); }
        }
        string fTenSP;
        [Size(30)]
        [DevExpress.Xpo.DisplayName(@"Tên sản phẩm")]
        public string TenSP
        {
            get { return fTenSP; }
            set { SetPropertyValue<string>(nameof(TenSP), ref fTenSP, value); }
        }
        string fLoaiSP;
        [Size(30)]
        [DevExpress.Xpo.DisplayName(@"Loại sản phẩm")]
        public string LoaiSP
        {
            get { return fLoaiSP; }
            set { SetPropertyValue<string>(nameof(LoaiSP), ref fLoaiSP, value); }
        }
        string fHinh;
        [Size(50)]
        [DevExpress.Xpo.DisplayName(@"Hình ảnh")]
        public string Hinh
        {
            get { return fHinh; }
            set { SetPropertyValue<string>(nameof(Hinh), ref fHinh, value); }
        }
        int fDonGia;
        [DevExpress.Xpo.DisplayName(@"Đơn giá")]
        public int DonGia
        {
            get { return fDonGia; }
            set { SetPropertyValue<int>(nameof(DonGia), ref fDonGia, value); }
        }
        int fSoLuong;
        [DevExpress.Xpo.DisplayName(@"Số lượng")]
        public int SoLuong
        {
            get { return fSoLuong; }
            set { SetPropertyValue<int>(nameof(SoLuong), ref fSoLuong, value); }
        }
        string fMoTa;
        [Size(30)]
        [DevExpress.Xpo.DisplayName(@"Mô tả")]
        public string MoTa
        {
            get { return fMoTa; }
            set { SetPropertyValue<string>(nameof(MoTa), ref fMoTa, value); }
        }
        Khach fMaKH;
        [Size(10)]
        [Association(@"SanPhamReferencesKhach")]
        [DevExpress.Xpo.DisplayName(@"Mã khách hàng")]
        public Khach MaKH
        {
            get { return fMaKH; }
            set { SetPropertyValue<Khach>(nameof(MaKH), ref fMaKH, value); }
        }
        LoaiSanPham fMaLoai;
        [Size(10)]
        [Association(@"SanPhamReferencesLoaiSanPham")]
        [DevExpress.Xpo.DisplayName(@"Mã loại sản phẩm")]
        public LoaiSanPham MaLoai
        {
            get { return fMaLoai; }
            set
            {
                if (SetPropertyValue<LoaiSanPham>(nameof(MaLoai), ref fMaLoai, value)
                    && value != null && !IsLoading)
                    LoaiSP = value.TenLoai;
            }
        }
        [Association(@"ChiTietHDReferencesSanPham")]
        public XPCollection<ChiTietHD> ChiTietHDs { get { return GetCollection<ChiTietHD>(nameof(ChiTietHDs)); } }
    }

}