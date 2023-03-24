using System.Collections;

namespace OrjinDestek.Models;

public class DestekTabloModel 
{
    public int RefNo { get; set; }
    
    public string? Proje { get; set; }
    
    public string? Tarih { get; set; }
    
    public string? Firma { get; set; }
    
    public string? RevizyonBilgisi { get; set; }
    
    public int? RevizyonId { get; set; }
    
    public string? GecenSure { get; set; }
    public string? TalepEden { get; set; }
    
    public string? DestekTipi { get; set; }
    
    public string? DestekPersonel { get; set; }
    
    public string? EmailHesabi { get; set; }
    public string? Konu { get; set; }
    
    public string? Oncelik { get; set; }
    
    public string? TelNo { get; set; }
    
    public string? DestekSekli { get; set; }
    public string? Durum { get; set; }
    
    public string? Aciklama { get; set; }
    
    public int? AcikBekleyenTalepler { get; set; }
    
    public int? KapaliTalepler { get; set; }
    
    public int? TumTalepler { get; set; }
}