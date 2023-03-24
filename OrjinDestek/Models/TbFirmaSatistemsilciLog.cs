using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbFirmaSatistemsilciLog
{
    public int Id { get; set; }

    public int? FslFirmaId { get; set; }

    public int? FslEskiTemsilciId { get; set; }

    public DateTime? FslTarih { get; set; }

    public string? FslAciklama { get; set; }

    public string? FslHareketTipi { get; set; }

    public int? FslYeniTemsilciId { get; set; }
}
