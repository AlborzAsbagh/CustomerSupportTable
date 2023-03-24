using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbDestekCevap
{
    public int TbDestekCevapId { get; set; }

    public DateTime? DestekTarihi { get; set; }

    public string? YapilanIslem { get; set; }

    public string? BaslamaZamani { get; set; }

    public string? BitisZamani { get; set; }

    public int TbCrmUserId { get; set; }

    public int TbDestekId { get; set; }
    
    public string? CrmUser { get; set; }
    
}
