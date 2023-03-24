using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbCari
{
    public int TbCariId { get; set; }

    public int? TbIlId { get; set; }

    public string? CariUnvan { get; set; }

    public string? VergiNo { get; set; }

    public string? OdemeSekli { get; set; }

    public decimal? IskontoOran { get; set; }

    public int? Vade { get; set; }

    public string? Banka { get; set; }

    public string? SubeNo { get; set; }

    public string? HesapNo { get; set; }

    public decimal Bakiye { get; set; }

    public string? Adres { get; set; }

    public string? Ilce { get; set; }

    public string? PostaKodu { get; set; }

    public string? Ulke { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Fax { get; set; }

    public string? Gsm { get; set; }

    public string? WebAdresi { get; set; }

    public string? Email { get; set; }

    public string? IlgiliKisi { get; set; }

    public bool? Aktif { get; set; }

    public string? CariTip { get; set; }

    public bool InternetMusterisi { get; set; }

    public string? Banka2 { get; set; }

    public string? SubeNo2 { get; set; }

    public string? HesapNo2 { get; set; }

    public string? KartSahibi { get; set; }

    public string? KartNo { get; set; }

    public string? KartSonAy { get; set; }

    public string? KartSonYil { get; set; }

    public string? KartCvvNo { get; set; }

    public string? Renk { get; set; }

    public string? VergiDaire { get; set; }

    public decimal Borc { get; set; }

    public decimal Alacak { get; set; }

    public decimal Veresiye { get; set; }

    public int AnaHesapId { get; set; }

    public bool AnaHesap { get; set; }

    public string? CariKod { get; set; }

    public bool? MizandaGoster { get; set; }

    public string? Aciklama { get; set; }

    public string? MusteriTip { get; set; }

    public int? MusteriTipId { get; set; }

    public int? Hizmetsayisi { get; set; }

    public string? FaturaAdres { get; set; }

    public int? FaturaTbIlId { get; set; }

    public string? FaturaIlce { get; set; }

    public string? FaturaPostaKodu { get; set; }

    public string? FaturaUlke { get; set; }

    public string? FaturaEmail { get; set; }

    public string? CariTur { get; set; }

    public DateTime? IseBaslamaTarih { get; set; }

    public DateTime? IstenAyrilmaTarih { get; set; }

    public double? KalanIzinGun { get; set; }

    public string? WhmcsKod { get; set; }
}
