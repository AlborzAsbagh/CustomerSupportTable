using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbCrmUserYetki
{
    public int TbCrmUserYetkiId { get; set; }

    public int TbCrmUserId { get; set; }

    public string? YetkiAciklama { get; set; }

    public int YetkiDurum { get; set; }
}
