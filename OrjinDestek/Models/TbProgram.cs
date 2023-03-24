using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbProgram
{
    public int TbProgramId { get; set; }

    public string? Tanim { get; set; }

    public string? VeritabaniAdi { get; set; }

    public string? VeritabaniDataYol { get; set; }

    public string? VeritabaniLogYol { get; set; }

    public string? VeritabaniYedekAdi { get; set; }

    public string? ConnectionString { get; set; }

    public string? LisansDosyaYolu { get; set; }
}
