using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbProgramModul
{
    public int TbProgramModulId { get; set; }

    public int? TbProgramId { get; set; }

    public string? PmModulAdi { get; set; }

    public string? PmModulDegeri { get; set; }
}
