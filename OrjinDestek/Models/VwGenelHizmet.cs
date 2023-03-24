using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class VwGenelHizmet
{
    public DateTime? Tarih { get; set; }

    public bool? Aktif { get; set; }

    public DateTime? BasTarih { get; set; }

    public DateTime? BitisTarih { get; set; }

    public int? TbCariId { get; set; }

    public string? Cari { get; set; }

    public string? Paket { get; set; }

    public string? IlgiliKisi { get; set; }

    public decimal? OdemeTutar { get; set; }

    public string? OdemeSekli { get; set; }

    public DateTime? OdemeTarih { get; set; }

    public string? Aciklama { get; set; }

    public bool? Iptal { get; set; }

    public bool? Fatura { get; set; }

    public bool? Ucretsiz { get; set; }

    public DateTime? IslemTarih { get; set; }

    public int? KalanSure { get; set; }

    public string? Baslik { get; set; }
}
