using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbKullanici
{
    public int TbKullaniciId { get; set; }

    public string? KullaniciAdi { get; set; }

    public string? Sifre { get; set; }

    public bool Satis { get; set; }

    public bool Domain { get; set; }

    public bool Cari { get; set; }

    public bool Gorev { get; set; }

    public bool Stok { get; set; }

    public bool Fatura { get; set; }

    public bool Banka { get; set; }

    public bool Kasa { get; set; }

    public bool Analiz { get; set; }

    public bool Bakim { get; set; }

    public bool? PersonelTakip { get; set; }

    public bool Lisans { get; set; }

    public bool KodYonetim { get; set; }

    /// <summary>
    ///   0-SATIS
    ///   1-DOMAIN
    ///   2-CARI
    ///   3-GOREV
    ///   4-STOK
    ///   5-FATURA
    ///   6-BANKA
    ///   7-KASA
    ///   8-ANALIZ
    ///   9-BAKIM
    ///   10-LISANS
    ///   11-HOSTING
    /// </summary>
    public int? DefaultModul { get; set; }

    public bool? FaaliyetGiderleri { get; set; }

    public bool? Seyahat { get; set; }

    public string? KullaniciIsim { get; set; }

    public bool? Aktif { get; set; }

    public bool? SistemYoneticisi { get; set; }

    public bool? SatisTemsilcisi { get; set; }

    public bool? ModulKullanici { get; set; }

    public double? EkPrimOran { get; set; }

    public double? KullaniciTamMaas { get; set; }

    public double? HedefSatis { get; set; }

    public double? KullaniciSabitMaas { get; set; }

    public double? KesintiOran { get; set; }

    public int? TbCrmUserId { get; set; }
}
