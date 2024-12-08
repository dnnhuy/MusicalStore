﻿using System;
using System.Collections.Generic;

namespace DTO.Models;

public partial class BinhLuan
{
    public string? NoiDung { get; set; }

    public DateOnly? NgayDang { get; set; }

    public int? Sao { get; set; }

    public string MaKh { get; set; } = null!;

    public string MaSp { get; set; } = null!;

    public virtual KhachHang MaKhNavigation { get; set; } = null!;

    public virtual SanPham MaSpNavigation { get; set; } = null!;
}