using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbDestekLog
{
    public int TbDestekLogId { get; set; }

    public int TbDestekId { get; set; }

    public int DskEskiSonucId { get; set; }

    public int DskYeniSonucId { get; set; }

    public int DskDegistirenId { get; set; }

    public DateTime? DskDegistirmeTarih { get; set; }
}
