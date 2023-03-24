using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

public partial class TbKullaniciMaasHrk
{
    public int TbKullaniciMaasHrkId { get; set; }

    public DateTime? BaslangicTarih { get; set; }

    public DateTime? BitisTarih { get; set; }

    /// <summary>
    /// 0
    /// </summary>
    public double? KullaniciSabitMaas { get; set; }

    public double? KullaniciTamMaas { get; set; }

    public double? HedefSatis { get; set; }

    public double? KesintiOran { get; set; }

    public double? EkPrimOran { get; set; }

    public int? KullaniciId { get; set; }

    public double? MaasHesapTip { get; set; }
}
