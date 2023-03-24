using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbGrup
{
    public int TbGrupId { get; set; }

    public string? TabloAdi { get; set; }

    public string? GrupAdi { get; set; }

    /// <summary>
    /// AYNI TABLOYU KULLANAN FAKAT FARKLI TANIMLAMALARI İÇEREN STOK VE YAKIT GİBİ TABLOLAR İÇİN FİLTRE ALANI KULLANILACAK.
    /// </summary>
    public string? Filtre { get; set; }

    public int? OlusturanId { get; set; }

    public DateTime? OlusturmaTarih { get; set; }

    public int? DegistirenId { get; set; }

    public DateTime? DegistirmeTarih { get; set; }
}
