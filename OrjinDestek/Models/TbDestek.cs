using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbDestek
{
    public int TbDestekId { get; set; }

    public DateTime? DskBaslamaTarihi { get; set; }

    public string? DskBaslamaSaati { get; set; }

    public DateTime? DskBitisTarihi { get; set; }

    public string? DskBitisSaati { get; set; }

    public string? DskKonuAciklama { get; set; }

    public int? DskGorusulenKisiId { get; set; }

    public string? DskEposta { get; set; }

    public string? DskTelefon { get; set; }

    public bool? DskAktif { get; set; }

    public string? DskSonuc { get; set; }

    public int? DskOlusturanId { get; set; }

    public DateTime? DskOlusturmaTarih { get; set; }

    public int? DskDegistirenId { get; set; }

    public DateTime? DskDegistirmeTarih { get; set; }

    public int? DskProgramId { get; set; }

    public int? DskFirmaId { get; set; }

    public int? DskPersonelId { get; set; }

    public int? DskSure { get; set; }

    public string? DskIstekler { get; set; }

    public int? DskKonuId { get; set; }

    public string? DskKonuBaslik { get; set; }

    public int? DskOncelikId { get; set; }

    public int? DskIsSuresi { get; set; }

    public int? DskSonucId { get; set; }

    public int? DskDestekTipiId { get; set; }

    public int DskTalepSebepId { get; set; }

    public int DskRevizyonId { get; set; }

    public int? DskOnayUserId { get; set; }

    public string? DskSonucAciklama { get; set; }

    public int? DskKapali { get; set; }

    public DateTime? DskGercekkapanistarih { get; set; }
}
