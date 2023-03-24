using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbPoshrk
{
    public int TbPoshrkId { get; set; }

    public int TbPosId { get; set; }

    public int TbCariId { get; set; }

    public int TbCarifisId { get; set; }

    public int TbBankaId { get; set; }

    public int TbBankahrkId { get; set; }

    public int TbPompaId { get; set; }

    public int TbStokId { get; set; }

    public int TbMarketsatisId { get; set; }

    public int TbVardiyaId { get; set; }

    public int TbIstasyonId { get; set; }

    public int TbDonemId { get; set; }

    public int KredikartNo { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public decimal Komisyon { get; set; }

    public int Vade { get; set; }

    public decimal Tutar { get; set; }

    public string? Aciklama { get; set; }

    public string? BatchNo { get; set; }

    public string? ReferansNo { get; set; }

    public string? HareketAciklama { get; set; }

    public bool VardiyaIslemi { get; set; }

    public byte FisSiraNo { get; set; }

    public bool TahsilEdildi { get; set; }

    public DateTime? TahsilTarih { get; set; }

    public decimal TahsilTutar { get; set; }

    public decimal KomisyonMiktar { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
