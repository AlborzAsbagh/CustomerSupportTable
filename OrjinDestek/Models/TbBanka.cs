using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbBanka
{
    public int TbBankaId { get; set; }

    public int? TbParabirimiId { get; set; }

    public int? TbGrupId { get; set; }

    public string? BankaKod { get; set; }

    public string? BankaTanim { get; set; }

    public string? HesapNo { get; set; }

    public bool? Aktif { get; set; }

    public string? Sube { get; set; }

    public string? SubeNo { get; set; }

    public string? Adres1 { get; set; }

    public string? Adres2 { get; set; }

    public string? Telefon { get; set; }

    public string? Fax { get; set; }

    public string? Yetkili { get; set; }

    public decimal Bakiye { get; set; }

    public decimal TakasCek { get; set; }

    public decimal KesilenCek { get; set; }

    public decimal PosBakiye { get; set; }

    public string? MuhasebeKod { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
