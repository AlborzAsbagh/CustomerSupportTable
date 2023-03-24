using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class VwDestek
{
    public string? ZamanAraligi { get; set; }

    public int? DskDestekTipiId { get; set; }

    public int TbDestekId { get; set; }

    public int? DskKapali { get; set; }

    public int? DskSonucId { get; set; }

    public DateTime? DskBaslamaTarihi { get; set; }

    public DateTime? DskBitisTarihi { get; set; }

    public int DskTalepSebepId { get; set; }

    public int? Dk { get; set; }

    public int? DskFirmaId { get; set; }
}
