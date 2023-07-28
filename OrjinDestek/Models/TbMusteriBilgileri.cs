using System.ComponentModel.DataAnnotations;

namespace OrjinDestek.Models
{
	public class TbMusteriBilgileri
	{
		[Key]
		public int MusteriId { get; set; }

		public string? FirmaAdi { get; set; } 
		public string? IpAdres { get; set; } 
		public string? KullaniciKodu { get; set; } 
		public string? Parola { get; set; } 
		public string? SqlSunucu { get; set; } 
		public string? SqlKullanici { get; set; } 
		public string? SqlSifre { get; set; } 
		public string? AnyDeskId { get; set; } 
		public string? AnyDeskSifre { get; set; } 
		public string? TeamViewer { get; set; } 
		public string? TeamViewerSifre { get; set; } 
		public string? VpnKullanici { get; set; } 
		public string? VpnSifre { get; set; } 
		public string? YardimMasasi { get; set; } 
		public string? Aciklama { get; set; } 

	}
}
