using System;
using System.Collections.Generic;

namespace OrjinDestek.Models;

/// <summary>
/// SERİ NUMARASI İLE TAKİP EDİLEN TÜM ALANLARIN TAKİP EDİLDİĞİ TABLODUR. İSTASYON BAZINDA SERİ NUMARALARINI SAKLAR. YENİ İSTASYON OLUŞTURULDUĞUNDA VARSAYILAN DEĞERLER İLE OLUŞTURULUR. KULLANICI YENİ FİŞ AÇTIĞINDA NO ALANINDAKİ DEĞERİN  1 FAZLASI DEĞERİNİ ALIR. KAYDEDERKEN DE BU DEĞER FARKLI BİR KULLANICI TARAFINDAN KULLANILMIŞ MI DİYE KONTROL EDİLEREK. KULLANICIDAKİ NO BU TABLOYA YAZILIR. DOLAYISIYLA KULLANICININ YAZDIĞI NO SON SERİ NO OLMUŞ OLUR.
/// </summary>
public partial class TbNumarator
{
    public int TbNumaratorId { get; set; }

    /// <summary>
    /// TAHSİL FİŞİ İÇİN THL GİBİ ÖN EK DEĞERİDİR. FATURA GİBİ BELGELERDE DE SERİ YERİNE KULLANILIR
    /// </summary>
    public string? Seri { get; set; }

    public double Numara { get; set; }

    public string? NumaratorTanim { get; set; }

    public int TbIstasyonId { get; set; }

    public string? Aciklama { get; set; }

    public string? BelgeTip { get; set; }
}
