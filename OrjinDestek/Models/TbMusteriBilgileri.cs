using System.ComponentModel.DataAnnotations;

namespace OrjinDestek.Models
{
	public class TbMusteriBilgileri
	{
		[Key]
		public int TB_MB_ID { get; set; }

		public string? TB_MB_FIRMA_ISMI { get; set; } 
		public string? TB_MB_IP_ADRESI { get; set; } 
		public string? TB_MB_KULLANICI_KODU { get; set; } 
		public string? TB_MB_PAROLA { get; set; } 
		public string? TB_MB_SQL_SUNUCU { get; set; } 
		public string? TB_MB_SQL_KULLANICI { get; set; } 
		public string? TB_MB_SQL_SIFRE { get; set; } 
		public string? TB_MB_ANY_DESK_ID { get; set; } 
		public string? TB_MB_ANY_SIFRE { get; set; } 
		public string? TB_MB_TEAM_VIEWER { get; set; } 
		public string? TB_MB_TEAM_SIFRE { get; set; } 
		public string? TB_MB_VPN_KULLANICI { get; set; } 
		public string? TB_MB_VPN_SIFRE { get; set; } 
		public string? TB_MB_YARDIM_MASASI { get; set; } 
		public string? TB_MB_ACIKLAMA { get; set; } 

	}
}
