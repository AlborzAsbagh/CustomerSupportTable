using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbFirma
{
    public int TbFirmaId { get; set; }

    public int? TbIlId { get; set; }

    public string? FirmaUnvan { get; set; }

    public string? IlgiliKisi { get; set; }

    public string? IlgiliKisiPozisyon { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Fax { get; set; }

    public string? Sektor { get; set; }

    public string? Bolge { get; set; }

    public bool? Yeni { get; set; }

    public string? SatisTemsilcisi { get; set; }

    public string? FirmaPuani { get; set; }

    public DateTime? IlkGorusmeTarih { get; set; }

    public DateTime? SonGorusmeTarih { get; set; }

    public DateTime? SonrakiGorusmeTarih { get; set; }

    public string SonrakiGorusmeSaat { get; set; } = null!;

    public short? GorusmeSayisi { get; set; }

    public string? Adres { get; set; }

    public string? PostaKodu { get; set; }

    public string? Ulke { get; set; }

    public string? Web { get; set; }

    public string? Email { get; set; }

    public string? Yorum { get; set; }

    public string? IlgiliUrun { get; set; }

    public bool? Aktif { get; set; }

    public string? Durumu { get; set; }

    public string? Renk { get; set; }

    public int? AracSayisi { get; set; }

    public int? KullaniciSayisi { get; set; }

    public decimal? TeklifMiktar { get; set; }

    public decimal? SatilanFiyat { get; set; }

    public DateTime? TakipEdilmesiGerekenTarih { get; set; }

    public string? KullandigiYazilimlar { get; set; }

    public bool? Satisdurum { get; set; }

    public DateTime? SatisTarih { get; set; }

    public string? Cep { get; set; }

    public int? OlusturanId { get; set; }

    public byte[]? OlusturmaTarih { get; set; }

    /// <summary>
    /// KULLANICI TANIMLARINDAN GELIYOR
    /// </summary>
    public int? SatisTemsilcisiId { get; set; }
}
