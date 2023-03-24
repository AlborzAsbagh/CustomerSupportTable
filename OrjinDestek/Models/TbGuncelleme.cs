using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbGuncelleme
{
    public int GuncellemeId { get; set; }

    public DateTime? GuncellemeTarihi { get; set; }

    public int? FirmaId { get; set; }

    public int? OrjinPersId { get; set; }

    public bool? Anahtar { get; set; }

    public string? Aciklama { get; set; }

    public string? VersiyonNo { get; set; }

    public string? ProgramAdi { get; set; }
}
