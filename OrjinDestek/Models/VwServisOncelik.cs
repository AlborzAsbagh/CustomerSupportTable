using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class VwServisOncelik
{
    public int TbServisOncelikId { get; set; }

    public string? SocKod { get; set; }

    public string? SocTanim { get; set; }

    public int? SocIkonIndexId { get; set; }

    public bool? SocVarsayilan { get; set; }

    public bool? SocAktif { get; set; }

    public int? SocOlusturanId { get; set; }

    public DateTime? SocOlusturmaTarih { get; set; }

    public int? SocDegistirenId { get; set; }

    public DateTime? SocDegistirmeTarih { get; set; }

    public int? SocCozumSureGun { get; set; }

    public int? SocCozumSureSaat { get; set; }

    public int? SocCozumSureDk { get; set; }

    public int? SocGecikmeSureDakika { get; set; }

    public string? SocGecikmeRenk { get; set; }

    public int? SocGecikmeIkonIndex { get; set; }

    public int? SocKritikSureDakika { get; set; }

    public string? SocKritikRenk { get; set; }

    public int? SocKritikIkonIndex { get; set; }

    public string? SocGecikmeYaziRenk { get; set; }

    public string? SocKritikYaziRenk { get; set; }

    public string? SocZaman { get; set; }
}
