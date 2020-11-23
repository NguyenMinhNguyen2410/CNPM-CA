﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DongHoContext))]
    partial class DongHoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Entities.ChiTietHoaDonBan", b =>
                {
                    b.Property<int>("IDChiTietHoaDonBan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IDHoaDon")
                        .HasColumnType("char(5)");

                    b.Property<string>("IDSanPham")
                        .HasColumnType("char(5)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IDChiTietHoaDonBan");

                    b.ToTable("chiTietHoaDonBan");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietHoaDonNhap", b =>
                {
                    b.Property<int>("IDChiTietHoaDonNhap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IDHoaDonNhap")
                        .HasColumnType("char(5)");

                    b.Property<string>("IDSanPham")
                        .HasColumnType("char(5)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IDChiTietHoaDonNhap");

                    b.ToTable("chiTietHoaDonNhap");
                });

            modelBuilder.Entity("Domain.Entities.HoaDonBan", b =>
                {
                    b.Property<string>("IDHoaDonBan")
                        .HasColumnType("char(5)");

                    b.Property<string>("IDKhachHang")
                        .HasColumnType("char(5)");

                    b.Property<DateTime>("NgayBan")
                        .HasColumnType("datetime");

                    b.Property<double>("ThanhTien")
                        .HasColumnType("float");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IDHoaDonBan");

                    b.ToTable("hoaDonBan");
                });

            modelBuilder.Entity("Domain.Entities.HoaDonNhap", b =>
                {
                    b.Property<string>("IDHoaDonNhap")
                        .HasColumnType("char(5)");

                    b.Property<string>("IDNhaCungCap")
                        .HasColumnType("char(5)");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("datetime");

                    b.Property<double>("ThanhTien")
                        .HasColumnType("float");

                    b.HasKey("IDHoaDonNhap");

                    b.ToTable("hoaDonNhap");
                });

            modelBuilder.Entity("Domain.Entities.KhachHang", b =>
                {
                    b.Property<string>("IDKhachHang")
                        .HasColumnType("char(5)");

                    b.Property<string>("DiaChiNhanHang")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("HoKhachHang")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TenKhachHang")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IDKhachHang");

                    b.ToTable("khachHang");
                });

            modelBuilder.Entity("Domain.Entities.LoaiDay", b =>
                {
                    b.Property<string>("IDDay")
                        .HasColumnType("char(5)");

                    b.Property<string>("TenLoaiDay")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IDDay");

                    b.ToTable("loaiDay");
                });

            modelBuilder.Entity("Domain.Entities.NhaCungCap", b =>
                {
                    b.Property<string>("IDNhaCungCap")
                        .HasColumnType("char(5)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TenNhacungCap")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IDNhaCungCap");

                    b.ToTable("nhaCungCap");
                });

            modelBuilder.Entity("Domain.Entities.SanPham", b =>
                {
                    b.Property<string>("IDSanPham")
                        .HasColumnType("char(5)");

                    b.Property<string>("BaoHanh")
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<string>("IDDay")
                        .HasColumnType("char(5)");

                    b.Property<string>("IDNhaCungCap")
                        .HasColumnType("char(5)");

                    b.Property<string>("IDThuongHieu")
                        .HasColumnType("char(5)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IDSanPham");

                    b.ToTable("sanPham");
                });

            modelBuilder.Entity("Domain.Entities.TaiKhoanKH", b =>
                {
                    b.Property<string>("TaiKhoan")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("IDKhachHang")
                        .HasColumnType("char(5)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("varchar(50)");

                    b.HasKey("TaiKhoan");

                    b.ToTable("taiKhoanKH");
                });

            modelBuilder.Entity("Domain.Entities.ThuongHieu", b =>
                {
                    b.Property<string>("IDThuongHieu")
                        .HasColumnType("char(5)");

                    b.Property<string>("TenThuongHieu")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IDThuongHieu");

                    b.ToTable("thuongHieu");
                });
#pragma warning restore 612, 618
        }
    }
}
