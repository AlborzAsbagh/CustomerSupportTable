using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbLisansProgramModul
{
    public int TbLisansProgramModul1 { get; set; }

    public int? LpmTbLisansId { get; set; }

    public int? LpmTbProgramId { get; set; }

    public int? LpmTbProgramModulId { get; set; }

    public string? LpmModulAdi { get; set; }

    public string? LpmModulDegeri { get; set; }
}
