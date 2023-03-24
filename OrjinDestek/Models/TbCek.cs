using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbCek
{
    public int TbCekId { get; set; }

    public int TbKasaId { get; set; }

    public int TbCarifisId { get; set; }

    public int TbBankaId { get; set; }

    public int TbCariId { get; set; }

    public int VerilenFisId { get; set; }

    public int VerilenCariId { get; set; }

    public int VerilenBankaId { get; set; }

    public DateTime? VerilenTarih { get; set; }

    public int TbParabirimiId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbDonemId { get; set; }

    public string? PortfoyNo { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Cs { get; set; }

    public byte CsTip { get; set; }

    public string? HesapNo { get; set; }

    public string? BankaTanim { get; set; }

    public string? SubeKod { get; set; }

    public string? SubeAdi { get; set; }

    public string? CeksenetNo { get; set; }

    public string? SeriNo { get; set; }

    public int ReferansNo { get; set; }

    public DateTime? Vade { get; set; }

    public decimal Tutar { get; set; }

    public string? KesideEden { get; set; }

    public string? KesideYeri { get; set; }

    public string? Borclu { get; set; }

    public string? Durum { get; set; }

    public string? DurumAciklama { get; set; }

    public bool Muhasebelesmis { get; set; }

    public byte FisSiraNo { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? TahsilTarih { get; set; }

    public DateTime? OdemeTarih { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }

    public decimal Kur { get; set; }
}
