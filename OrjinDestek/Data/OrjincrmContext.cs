using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OrjinDestek.Models;

public partial class OrjincrmContext : DbContext
{
    public OrjincrmContext()
    {
    }

    public OrjincrmContext(DbContextOptions<OrjincrmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FİzİkselSunucular> FİzİkselSunuculars { get; set; }

    public virtual DbSet<IpListesiAk> IpListesiAks { get; set; }

    public virtual DbSet<Sayfa1> Sayfa1s { get; set; }

    public virtual DbSet<Sayfa11> Sayfa1s1 { get; set; }

    public virtual DbSet<Sayfa2> Sayfa2s { get; set; }

    public virtual DbSet<TbAyar> TbAyars { get; set; }

    public virtual DbSet<TbBakimAnlasmasi> TbBakimAnlasmasis { get; set; }

    public virtual DbSet<TbBakimAnlasmasiHrk> TbBakimAnlasmasiHrks { get; set; }

    public virtual DbSet<TbBakimAnlasmasiTeklif> TbBakimAnlasmasiTeklifs { get; set; }

    public virtual DbSet<TbBanka> TbBankas { get; set; }

    public virtual DbSet<TbBankahrk> TbBankahrks { get; set; }

    public virtual DbSet<TbBelge> TbBelges { get; set; }

    public virtual DbSet<TbBirim> TbBirims { get; set; }

    public virtual DbSet<TbBirimset> TbBirimsets { get; set; }

    public virtual DbSet<TbCari> TbCaris { get; set; }

    public virtual DbSet<TbCariPersonel> TbCariPersonels { get; set; }

    public virtual DbSet<TbCariUser> TbCariUsers { get; set; }

    public virtual DbSet<TbCarifaturaAdre> TbCarifaturaAdres { get; set; }

    public virtual DbSet<TbCarifi> TbCarifis { get; set; }

    public virtual DbSet<TbCarihrk> TbCarihrks { get; set; }

    public virtual DbSet<TbCek> TbCeks { get; set; }

    public virtual DbSet<TbCekhrk> TbCekhrks { get; set; }

    public virtual DbSet<TbCrmUser> TbCrmUsers { get; set; }

    public virtual DbSet<TbCrmUserYetki> TbCrmUserYetkis { get; set; }

    public virtual DbSet<TbDepo> TbDepos { get; set; }

    public virtual DbSet<TbDestek> TbDesteks { get; set; }

    public virtual DbSet<TbDestekCevap> TbDestekCevaps { get; set; }

    public virtual DbSet<TbDestekKonu> TbDestekKonus { get; set; }

    public virtual DbSet<TbDestekLog> TbDestekLogs { get; set; }

    public virtual DbSet<TbDomain> TbDomains { get; set; }

    public virtual DbSet<TbDomainhrk> TbDomainhrks { get; set; }

    public virtual DbSet<TbDonanimMarka> TbDonanimMarkas { get; set; }

    public virtual DbSet<TbDonanimModel> TbDonanimModels { get; set; }

    public virtual DbSet<TbFaaliyetDisiGider> TbFaaliyetDisiGiders { get; set; }

    public virtual DbSet<TbFaturaStok> TbFaturaStoks { get; set; }

    public virtual DbSet<TbFirma> TbFirmas { get; set; }

    public virtual DbSet<TbFirmaSatistemsilciLog> TbFirmaSatistemsilciLogs { get; set; }

    public virtual DbSet<TbGelirgider> TbGelirgiders { get; set; }

    public virtual DbSet<TbGelirgiderhrk> TbGelirgiderhrks { get; set; }

    public virtual DbSet<TbGorusme> TbGorusmes { get; set; }

    public virtual DbSet<TbGrup> TbGrups { get; set; }

    public virtual DbSet<TbGuncelleme> TbGuncellemes { get; set; }

    public virtual DbSet<TbHatirlaticiAyar> TbHatirlaticiAyars { get; set; }

    public virtual DbSet<TbHosting> TbHostings { get; set; }

    public virtual DbSet<TbHostinghrk> TbHostinghrks { get; set; }

    public virtual DbSet<TbIl> TbIls { get; set; }

    public virtual DbSet<TbIpler> TbIplers { get; set; }

    public virtual DbSet<TbIsListesi> TbIsListesis { get; set; }

    public virtual DbSet<TbIsTipleri> TbIsTipleris { get; set; }

    public virtual DbSet<TbKasa> TbKasas { get; set; }

    public virtual DbSet<TbKasahrk> TbKasahrks { get; set; }

    public virtual DbSet<TbKod> TbKods { get; set; }

    public virtual DbSet<TbKodtip> TbKodtips { get; set; }

    public virtual DbSet<TbKullanici> TbKullanicis { get; set; }

    public virtual DbSet<TbKullaniciMaasHrk> TbKullaniciMaasHrks { get; set; }

    public virtual DbSet<TbKur> TbKurs { get; set; }

    public virtual DbSet<TbLisan> TbLisans { get; set; }

    public virtual DbSet<TbLisansProgramModul> TbLisansProgramModuls { get; set; }

    public virtual DbSet<TbLog> TbLogs { get; set; }

    public virtual DbSet<TbMail> TbMails { get; set; }

    public virtual DbSet<TbMesaj> TbMesajs { get; set; }

    public virtual DbSet<TbNumarator> TbNumarators { get; set; }

    public virtual DbSet<TbOdemeDiger> TbOdemeDigers { get; set; }

    public virtual DbSet<TbPaket> TbPakets { get; set; }

    public virtual DbSet<TbParabirimi> TbParabirimis { get; set; }

    public virtual DbSet<TbPersonelIzin> TbPersonelIzins { get; set; }

    public virtual DbSet<TbPersonelIzinYil> TbPersonelIzinYils { get; set; }

    public virtual DbSet<TbPo> TbPos { get; set; }

    public virtual DbSet<TbPoshrk> TbPoshrks { get; set; }

    public virtual DbSet<TbProgram> TbPrograms { get; set; }

    public virtual DbSet<TbProgramModul> TbProgramModuls { get; set; }

    public virtual DbSet<TbServisOncelik> TbServisOnceliks { get; set; }

    public virtual DbSet<TbSeyahat> TbSeyahats { get; set; }

    public virtual DbSet<TbSeyahatPersonel> TbSeyahatPersonels { get; set; }

    public virtual DbSet<TbSorun> TbSoruns { get; set; }

    public virtual DbSet<TbSsl> TbSsls { get; set; }

    public virtual DbSet<TbSslhrk> TbSslhrks { get; set; }

    public virtual DbSet<TbStok> TbStoks { get; set; }

    public virtual DbSet<TbStokfi> TbStokfis { get; set; }

    public virtual DbSet<TbStokfisdetay> TbStokfisdetays { get; set; }

    public virtual DbSet<TbStokhrk> TbStokhrks { get; set; }

    public virtual DbSet<TbSunucu> TbSunucus { get; set; }

    public virtual DbSet<TbSunucuKaydi> TbSunucuKaydis { get; set; }

    public virtual DbSet<TbSunucuKaydipp> TbSunucuKaydipps { get; set; }

    public virtual DbSet<TbSunucuhrk> TbSunucuhrks { get; set; }

    public virtual DbSet<TbTaksit> TbTaksits { get; set; }

    public virtual DbSet<TbTakvim> TbTakvims { get; set; }

    public virtual DbSet<TbTanimtabloistasyon> TbTanimtabloistasyons { get; set; }

    public virtual DbSet<TbTelefonRehber> TbTelefonRehbers { get; set; }

    public virtual DbSet<TbVardiya> TbVardiyas { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

    public virtual DbSet<VwDestek> VwDesteks { get; set; }

    public virtual DbSet<VwFatura> VwFaturas { get; set; }

    public virtual DbSet<VwFaturaHavuz> VwFaturaHavuzs { get; set; }

    public virtual DbSet<VwFiyatListesi> VwFiyatListesis { get; set; }

    public virtual DbSet<VwGenelHizmet> VwGenelHizmets { get; set; }

    public virtual DbSet<VwGuncelTutar> VwGuncelTutars { get; set; }

    public virtual DbSet<VwIptalHizmetler> VwIptalHizmetlers { get; set; }

    public virtual DbSet<VwMusteriHrk> VwMusteriHrks { get; set; }

    public virtual DbSet<VwOdemeListesi> VwOdemeListesis { get; set; }

    public virtual DbSet<VwServisOncelik> VwServisOnceliks { get; set; }

    public virtual DbSet<VwSunucuKaydi> VwSunucuKaydis { get; set; }

    public virtual DbSet<VwSunucuKaydiy> VwSunucuKaydiys { get; set; }

    public virtual DbSet<WebpagesMembership> WebpagesMemberships { get; set; }

    public virtual DbSet<WebpagesOauthMembership> WebpagesOauthMemberships { get; set; }

    public virtual DbSet<WebpagesRole> WebpagesRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:SqlServer");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Turkish_CI_AS");

        modelBuilder.Entity<FİzİkselSunucular>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FİZİKSEL_SUNUCULAR");

            entity.Property(e => e.BİrhostKodu)
                .HasMaxLength(255)
                .HasColumnName("BİRHOST KODU");
            entity.Property(e => e.DgnKodu)
                .HasMaxLength(255)
                .HasColumnName("DGN KODU");
            entity.Property(e => e.DonanimTipi)
                .HasMaxLength(255)
                .HasColumnName("DONANIM TIPI");
            entity.Property(e => e.Ip).HasColumnName("IP");
            entity.Property(e => e.MüşterİAciklama)
                .HasMaxLength(255)
                .HasColumnName("MÜŞTERİ ACIKLAMA");
            entity.Property(e => e.RafNo)
                .HasMaxLength(255)
                .HasColumnName("RAF NO");
            entity.Property(e => e.SanalSunucu1Var0Yok).HasColumnName("SANAL SUNUCU - 1 (VAR) - 0 (YOK)");
            entity.Property(e => e.İşlemcİMarka).HasColumnName("İŞLEMCİ MARKA");
            entity.Property(e => e.İşlemcİModel).HasColumnName("İŞLEMCİ MODEL");
        });

        modelBuilder.Entity<IpListesiAk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IP_LISTESI_AK");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.IpAdres).HasColumnName("IP ADRES");
            entity.Property(e => e.IpDurum)
                .HasMaxLength(255)
                .HasColumnName("IP DURUM");
            entity.Property(e => e.IpTipi)
                .HasMaxLength(255)
                .HasColumnName("IP TIPI");
            entity.Property(e => e.NetworkBİlgİsİ)
                .HasMaxLength(255)
                .HasColumnName("NETWORK BİLGİSİ");
        });

        modelBuilder.Entity<Sayfa1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SAYFA_1$");

            entity.Property(e => e.DskAktif).HasColumnName("DSK_AKTIF");
            entity.Property(e => e.DskBaslamaSaati)
                .HasMaxLength(255)
                .HasColumnName("DSK_BASLAMA_SAATI");
            entity.Property(e => e.DskBaslamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DSK_BASLAMA_TARIHI");
            entity.Property(e => e.DskBitisSaati)
                .HasMaxLength(255)
                .HasColumnName("DSK_BITIS_SAATI");
            entity.Property(e => e.DskBitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DSK_BITIS_TARIHI");
            entity.Property(e => e.DskDegistirenId)
                .HasMaxLength(255)
                .HasColumnName("DSK_DEGISTIREN_ID");
            entity.Property(e => e.DskDegistirmeTarih)
                .HasMaxLength(255)
                .HasColumnName("DSK_DEGISTIRME_TARIH");
            entity.Property(e => e.DskDestekTipiId).HasColumnName("DSK_DESTEK_TIPI_ID");
            entity.Property(e => e.DskEposta)
                .HasMaxLength(255)
                .HasColumnName("DSK_EPOSTA");
            entity.Property(e => e.DskFirmaId).HasColumnName("DSK_FIRMA_ID");
            entity.Property(e => e.DskGercekkapanistarih)
                .HasMaxLength(255)
                .HasColumnName("DSK_GERCEKKAPANISTARIH");
            entity.Property(e => e.DskGorusulenKisiId).HasColumnName("DSK_GORUSULEN_KISI_ID");
            entity.Property(e => e.DskIsSuresi).HasColumnName("DSK_IS_SURESI");
            entity.Property(e => e.DskIstekler).HasColumnName("DSK_ISTEKLER");
            entity.Property(e => e.DskKapali).HasColumnName("DSK_KAPALI");
            entity.Property(e => e.DskKonuAciklama).HasColumnName("DSK_KONU_ACIKLAMA");
            entity.Property(e => e.DskKonuBaslik)
                .HasMaxLength(255)
                .HasColumnName("DSK_KONU_BASLIK");
            entity.Property(e => e.DskKonuId).HasColumnName("DSK_KONU_ID");
            entity.Property(e => e.DskOlusturanId)
                .HasMaxLength(255)
                .HasColumnName("DSK_OLUSTURAN_ID");
            entity.Property(e => e.DskOlusturmaTarih)
                .HasMaxLength(255)
                .HasColumnName("DSK_OLUSTURMA_TARIH");
            entity.Property(e => e.DskOnayUserId)
                .HasMaxLength(255)
                .HasColumnName("DSK_ONAY_USER_ID");
            entity.Property(e => e.DskOncelikId)
                .HasMaxLength(255)
                .HasColumnName("DSK_ONCELIK_ID");
            entity.Property(e => e.DskPersonelId).HasColumnName("DSK_PERSONEL_ID");
            entity.Property(e => e.DskProgramId).HasColumnName("DSK_PROGRAM_ID");
            entity.Property(e => e.DskRevizyonId).HasColumnName("DSK_REVIZYON_ID");
            entity.Property(e => e.DskSonuc)
                .HasMaxLength(255)
                .HasColumnName("DSK_SONUC");
            entity.Property(e => e.DskSonucAciklama)
                .HasMaxLength(255)
                .HasColumnName("DSK_SONUC_ACIKLAMA");
            entity.Property(e => e.DskSonucId).HasColumnName("DSK_SONUC_ID");
            entity.Property(e => e.DskSure).HasColumnName("DSK_SURE");
            entity.Property(e => e.DskTalepSebepId).HasColumnName("DSK_TALEP_SEBEP_ID");
            entity.Property(e => e.DskTelefon)
                .HasMaxLength(255)
                .HasColumnName("DSK_TELEFON");
            entity.Property(e => e.TbDestekId).HasColumnName("TB_DESTEK_ID");
        });

        modelBuilder.Entity<Sayfa11>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sayfa1");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.IpAdres)
                .HasMaxLength(255)
                .HasColumnName("IP ADRES");
            entity.Property(e => e.IpDurum)
                .HasMaxLength(255)
                .HasColumnName("IP DURUM");
            entity.Property(e => e.IpTipi)
                .HasMaxLength(255)
                .HasColumnName("IP TIPI");
            entity.Property(e => e.NetworkBİlgİsİ)
                .HasMaxLength(255)
                .HasColumnName("NETWORK BİLGİSİ");
        });

        modelBuilder.Entity<Sayfa2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sayfa2");

            entity.Property(e => e.F5).HasMaxLength(255);
            entity.Property(e => e.MusteriUnvan)
                .HasMaxLength(255)
                .HasColumnName("MUSTERI_UNVAN");
            entity.Property(e => e.MüşteriTipi)
                .HasMaxLength(255)
                .HasColumnName("Müşteri Tipi");
            entity.Property(e => e.Whmcs).HasColumnName("WHMCS");
            entity.Property(e => e.İlgiliKişi)
                .HasMaxLength(255)
                .HasColumnName("İlgili Kişi");
        });

        modelBuilder.Entity<TbAyar>(entity =>
        {
            entity.ToTable("TB_AYAR");

            entity.Property(e => e.TbAyarId).HasColumnName("TB_AYAR_ID");
            entity.Property(e => e.Adres1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADRES1");
            entity.Property(e => e.Adres2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADRES2");
            entity.Property(e => e.AktifParabirimiId).HasColumnName("AKTIF_PARABIRIMI_ID");
            entity.Property(e => e.AyrDbSonYedekDosya)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AYR_DB_SON_YEDEK_DOSYA");
            entity.Property(e => e.AyrDbYedekKayitDizin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AYR_DB_YEDEK_KAYIT_DIZIN");
            entity.Property(e => e.AyrDbYedekOnEk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AYR_DB_YEDEK_ON_EK");
            entity.Property(e => e.AyrDbYedekRewrite).HasColumnName("AYR_DB_YEDEK_REWRITE");
            entity.Property(e => e.DovizliTakip).HasColumnName("DOVIZLI_TAKIP");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FaturaHareketFormu)
                .HasComment("FATURA AÇILIŞNDA FATURA HAREKET FORMUNU GÖSTERİP GÖSTERMEYECEĞİ BİLGİSİNİ TUTAR")
                .HasColumnName("FATURA_HAREKET_FORMU");
            entity.Property(e => e.FaturaSatir)
                .HasDefaultValueSql("((1))")
                .HasComment("FATURA AÇILIŞINDA KAÇ SATIR DETAY AÇILACAĞI")
                .HasColumnName("FATURA_SATIR");
            entity.Property(e => e.FaturaSatirTip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FATURA_SATIR_TIP");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.FisSatir)
                .HasDefaultValueSql("((1))")
                .HasColumnName("FIS_SATIR");
            entity.Property(e => e.FiyatDegisimiYansisin)
                .HasComment("VARDİYA ALINMA ESNASINDA YAPILAN SATIŞLAR İLE KARTLARDAKİ BİRİM FİYATLARIN FARKLI OLMASI DURUMUNDA. SATIŞLARDAKİ FİYATIN KARTLARA YANSIYIP YANSIMAYACAĞI BILGISI")
                .HasColumnName("FIYAT_DEGISIMI_YANSISIN");
            entity.Property(e => e.FiyatDegisimiYansiyacakFiyat)
                .HasComment("FIYAT DEĞİŞİMİNİN STOK KARTINDA HANGİ(1,2,3) BİRİM FİYATINI DEĞİŞTİRECEĞİ BİLGİSİ")
                .HasColumnName("FIYAT_DEGISIMI_YANSIYACAK_FIYAT");
            entity.Property(e => e.FiyatGuncelle).HasColumnName("FIYAT_GUNCELLE");
            entity.Property(e => e.FormAcilisTip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("MDI, TAB")
                .HasColumnName("FORM_ACILIS_TIP");
            entity.Property(e => e.FormlarDosyayolu)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FORMLAR_DOSYAYOLU");
            entity.Property(e => e.GuncelleFiyat1).HasColumnName("GUNCELLE_FIYAT1");
            entity.Property(e => e.GuncelleFiyat2).HasColumnName("GUNCELLE_FIYAT2");
            entity.Property(e => e.GuncelleFiyat3).HasColumnName("GUNCELLE_FIYAT3");
            entity.Property(e => e.HizliVardiya).HasColumnName("HIZLI_VARDIYA");
            entity.Property(e => e.IlId).HasColumnName("IL_ID");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILCE");
            entity.Property(e => e.Kdv)
                .HasDefaultValueSql("((18))")
                .HasColumnName("KDV");
            entity.Property(e => e.KdvDahil)
                .HasComment("FATURA VE İRSALİYELERDE VARSAYILAN KDV DAHİL VEYA HARİÇ DEĞERİ")
                .HasColumnName("KDV_DAHIL");
            entity.Property(e => e.KurTip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasComment("varsayılan alış veya satış kurunun kullanılacağını belirtir.")
                .HasColumnName("KUR_TIP");
            entity.Property(e => e.Pop3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POP3");
            entity.Property(e => e.PostaKodu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("POSTA_KODU");
            entity.Property(e => e.RaporlarDosyayolu)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RAPORLAR_DOSYAYOLU");
            entity.Property(e => e.SabitKur)
                .HasComment("SABİT KUR TAKİBİ YAPILACAKMI?")
                .HasColumnName("SABIT_KUR");
            entity.Property(e => e.SabitKurDeger)
                .HasComment("SABİT KUR DEĞERİ")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SABIT_KUR_DEGER");
            entity.Property(e => e.SigortaOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SIGORTA_ORAN");
            entity.Property(e => e.Smtp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMTP");
            entity.Property(e => e.Stil)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("LUNA,BLUE,GRAY,XP ..")
                .HasColumnName("STIL");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFON");
            entity.Property(e => e.Tts)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTS");
            entity.Property(e => e.TtsCariId).HasColumnName("TTS_CARI_ID");
            entity.Property(e => e.Unvan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
            entity.Property(e => e.VardiyaMesaj).HasColumnName("VARDIYA_MESAJ");
            entity.Property(e => e.Web)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("WEB");
            entity.Property(e => e.YerelParabirimiId).HasColumnName("YEREL_PARABIRIMI_ID");
        });

        modelBuilder.Entity<TbBakimAnlasmasi>(entity =>
        {
            entity.HasKey(e => e.TbBakimAnlasmasiId).HasName("PK__TB_BAKIM_ANLASMA__762C88DA");

            entity.ToTable("TB_BAKIM_ANLASMASI", tb =>
            {
                tb.HasComment("Şirketlerle olan bakım anlaşmalarının tutulacağı tablo.");
                tb.HasTrigger("TRG_BAKIM_ANLASMASI_EKLE");
                tb.HasTrigger("TRG_BAKIM_ANLASMASI_SIL");
            });

            entity.Property(e => e.TbBakimAnlasmasiId).HasColumnName("TB_BAKIM_ANLASMASI_ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Anahtar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANAHTAR");
            entity.Property(e => e.BaBaslangicTarih)
                .HasComment("BAKIM ANLAŞMASI BAŞLANGIÇ TARİHİ")
                .HasColumnType("datetime")
                .HasColumnName("BA_BASLANGIC_TARIH");
            entity.Property(e => e.BaBitisTarih)
                .HasComment("BAKIM ANLAŞMASI BİTİŞ TARİHİ")
                .HasColumnType("datetime")
                .HasColumnName("BA_BITIS_TARIH");
            entity.Property(e => e.BaTutar)
                .HasComment("BAKIM ANLAŞMASI TUTARI")
                .HasColumnName("BA_TUTAR");
            entity.Property(e => e.PersonelKodId).HasColumnName("PERSONEL_KOD_ID");
            entity.Property(e => e.Tarih)
                .HasComment("İŞLEM TARİHİ")
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbStokId).HasColumnName("TB_STOK_ID");
            entity.Property(e => e.UrunTutar)
                .HasComment("SATILAN ÜRÜNÜN TUTARI")
                .HasColumnName("URUN_TUTAR");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YETKILI");
        });

        modelBuilder.Entity<TbBakimAnlasmasiHrk>(entity =>
        {
            entity.HasKey(e => e.TbBakimAnlasmasiHrkId).HasName("PK__TB_BAKIM_ANLASMA__79FD19BE");

            entity.ToTable("TB_BAKIM_ANLASMASI_HRK", tb =>
            {
                tb.HasComment("BAKIM ANLAŞMALARINDA YAPILAN GÜNCELLEMELERİN TUTULACAĞI TABLODUR.");
                tb.HasTrigger("TRG_BAKIM_ANLASMASI_HRK_EKLE_DEGISTIR");
            });

            entity.Property(e => e.TbBakimAnlasmasiHrkId).HasColumnName("TB_BAKIM_ANLASMASI_HRK_ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BaBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("BA_BASLANGIC_TARIH");
            entity.Property(e => e.BaBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("BA_BITIS_TARIH");
            entity.Property(e => e.BaTutar).HasColumnName("BA_TUTAR");
            entity.Property(e => e.PersonelKodId).HasColumnName("PERSONEL_KOD_ID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbBakimAnlasmasiId).HasColumnName("TB_BAKIM_ANLASMASI_ID");
            entity.Property(e => e.TbStokId).HasColumnName("TB_STOK_ID");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YETKILI");
        });

        modelBuilder.Entity<TbBakimAnlasmasiTeklif>(entity =>
        {
            entity.HasKey(e => e.TbBakimAnlasmasiTeklifId).HasName("PK__TB_BAKIM__5BAAB1D635DCF99B");

            entity.ToTable("TB_BAKIM_ANLASMASI_TEKLIF");

            entity.Property(e => e.TbBakimAnlasmasiTeklifId).HasColumnName("TB_BAKIM_ANLASMASI_TEKLIF_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(4000)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.IlgiDurumuKodId).HasColumnName("ILGI_DURUMU_KOD_ID");
            entity.Property(e => e.IlgiliKisi)
                .HasMaxLength(50)
                .HasColumnName("ILGILI_KISI");
            entity.Property(e => e.SatisTemsilcisiId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("SATIS_TEMSILCISI_ID");
            entity.Property(e => e.TbBakimAnlasmasiId).HasColumnName("TB_BAKIM_ANLASMASI_ID");
            entity.Property(e => e.TeklifFiyat).HasColumnName("TEKLIF_FIYAT");
            entity.Property(e => e.TeklifSaat)
                .HasMaxLength(10)
                .HasColumnName("TEKLIF_SAAT");
            entity.Property(e => e.TeklifTarih)
                .HasColumnType("datetime")
                .HasColumnName("TEKLIF_TARIH");
        });

        modelBuilder.Entity<TbBanka>(entity =>
        {
            entity.ToTable("TB_BANKA", tb => tb.HasTrigger("TRG_BANKA_EKLE_DEGISTIR"));

            entity.Property(e => e.TbBankaId).HasColumnName("TB_BANKA_ID");
            entity.Property(e => e.Adres1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADRES1");
            entity.Property(e => e.Adres2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADRES2");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Bakiye)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BAKIYE");
            entity.Property(e => e.BankaKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANKA_KOD");
            entity.Property(e => e.BankaTanim)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BANKA_TANIM");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.HesapNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HESAP_NO");
            entity.Property(e => e.KesilenCek)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KESILEN_CEK");
            entity.Property(e => e.MuhasebeKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MUHASEBE_KOD");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.PosBakiye)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("POS_BAKIYE");
            entity.Property(e => e.Sube)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBE");
            entity.Property(e => e.SubeNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SUBE_NO");
            entity.Property(e => e.TakasCek)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TAKAS_CEK");
            entity.Property(e => e.TbGrupId).HasColumnName("TB_GRUP_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFON");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("YETKILI");
        });

        modelBuilder.Entity<TbBankahrk>(entity =>
        {
            entity.ToTable("TB_BANKAHRK", tb =>
            {
                tb.HasTrigger("TRG_BANKAHRK_EKLE");
                tb.HasTrigger("TRG_BANKAHRK_SIL");
            });

            entity.Property(e => e.TbBankahrkId).HasColumnName("TB_BANKAHRK_ID");
            entity.Property(e => e.BankaKur)
                .HasComment("DÖVİZ HESAPLARINDAN YAPILAN İŞLEMLERDE DÖNÜŞTÜRME YAPMAK İÇİN KULLANILIR. YEREL PARABİRİMİ HESAPLARINDA SABİT 1 DEĞERİNİ ALIR")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BANKA_KUR");
            entity.Property(e => e.Cekilen)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CEKILEN");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.DovizTutar)
                .HasComment("KARŞI HESABA ETKİ EDEN TUTARDIR. ÇEKİLEN VEYA YATIRILAN TUTARIN BANKA KURU İLE ÇARPIMININ KARŞI HESAP KURUNA BÖLÜMÜDÜR.")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DOVIZ_TUTAR");
            entity.Property(e => e.FisSiraNo).HasColumnName("FIS_SIRA_NO");
            entity.Property(e => e.HedefBankaId).HasColumnName("HEDEF_BANKA_ID");
            entity.Property(e => e.Islem)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("CARİ\r\nPOS\r\nKASA\r\nGELİR\r\nGİDER\r\nÇEK-SENET\r\nBANKA\r\nPOS-AKTARIM (POSLARDAN AKTARIMLARDA OLUŞUR)")
                .HasColumnName("ISLEM");
            entity.Property(e => e.IslemAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ISLEM_ACIKLAMA");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KUR");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.Prosedur)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("PROSEDUR");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbBankaId).HasColumnName("TB_BANKA_ID");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbCekId).HasColumnName("TB_CEK_ID");
            entity.Property(e => e.TbDevirfisDetayId).HasColumnName("TB_DEVIRFIS_DETAY_ID");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbGelirgiderId).HasColumnName("TB_GELIRGIDER_ID");
            entity.Property(e => e.TbIslemId).HasColumnName("TB_ISLEM_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbKasaId).HasColumnName("TB_KASA_ID");
            entity.Property(e => e.TbKasahrkId).HasColumnName("TB_KASAHRK_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.TbPosId).HasColumnName("TB_POS_ID");
            entity.Property(e => e.TbSeyahatHarcamaTipId).HasColumnName("TB_SEYAHAT_HARCAMA_TIP_ID");
            entity.Property(e => e.TbSeyahatId).HasColumnName("TB_SEYAHAT_ID");
            entity.Property(e => e.Yatirilan)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("YATIRILAN");
        });

        modelBuilder.Entity<TbBelge>(entity =>
        {
            entity.HasKey(e => e.TbBelgeId).HasName("PK__TB_BELGE__74444068");

            entity.ToTable("TB_BELGE");

            entity.Property(e => e.TbBelgeId).HasColumnName("TB_BELGE_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Belge)
                .HasColumnType("image")
                .HasColumnName("BELGE");
            entity.Property(e => e.BelgeAdi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BELGE_ADI");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.KayitId).HasColumnName("KAYIT_ID");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.TabloAdi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TABLO_ADI");
        });

        modelBuilder.Entity<TbBirim>(entity =>
        {
            entity.ToTable("TB_BIRIM");

            entity.Property(e => e.TbBirimId).HasColumnName("TB_BIRIM_ID");
            entity.Property(e => e.AnaBirim).HasColumnName("ANA_BIRIM");
            entity.Property(e => e.AnaBirimKatsayi)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ANA_BIRIM_KATSAYI");
            entity.Property(e => e.BirimKatsayi)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BIRIM_KATSAYI");
            entity.Property(e => e.BirimKod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BIRIM_KOD");
            entity.Property(e => e.BirimTanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BIRIM_TANIM");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.TbBirimsetId).HasColumnName("TB_BIRIMSET_ID");
        });

        modelBuilder.Entity<TbBirimset>(entity =>
        {
            entity.ToTable("TB_BIRIMSET");

            entity.Property(e => e.TbBirimsetId).HasColumnName("TB_BIRIMSET_ID");
            entity.Property(e => e.BirimsetKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BIRIMSET_KOD");
            entity.Property(e => e.BirimsetTanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BIRIMSET_TANIM");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
        });

        modelBuilder.Entity<TbCari>(entity =>
        {
            entity.HasKey(e => e.TbCariId).HasName("TB_CARI_pk");

            entity.ToTable("TB_CARI", tb =>
            {
                tb.HasTrigger("TRG_CARI_DEGISTIR");
                tb.HasTrigger("TRG_CARI_SIL");
            });

            entity.HasIndex(e => e.CariUnvan, "TB_CARI_uq").IsUnique();

            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktif)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Alacak)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ALACAK");
            entity.Property(e => e.AnaHesap).HasColumnName("ANA_HESAP");
            entity.Property(e => e.AnaHesapId).HasColumnName("ANA_HESAP_ID");
            entity.Property(e => e.Bakiye)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BAKIYE");
            entity.Property(e => e.Banka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANKA");
            entity.Property(e => e.Banka2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANKA_2");
            entity.Property(e => e.Borc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BORC");
            entity.Property(e => e.CariKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARI_KOD");
            entity.Property(e => e.CariTip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARI_TIP");
            entity.Property(e => e.CariTur)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARI_TUR");
            entity.Property(e => e.CariUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FaturaAdres)
                .HasMaxLength(2000)
                .HasColumnName("FATURA_ADRES");
            entity.Property(e => e.FaturaEmail)
                .HasMaxLength(50)
                .HasColumnName("FATURA_EMAIL");
            entity.Property(e => e.FaturaIlce)
                .HasMaxLength(50)
                .HasColumnName("FATURA_ILCE");
            entity.Property(e => e.FaturaPostaKodu)
                .HasMaxLength(40)
                .HasColumnName("FATURA_POSTA_KODU");
            entity.Property(e => e.FaturaTbIlId).HasColumnName("FATURA_TB_IL_ID");
            entity.Property(e => e.FaturaUlke)
                .HasMaxLength(40)
                .HasColumnName("FATURA_ULKE");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Gsm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GSM");
            entity.Property(e => e.HesapNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HESAP_NO");
            entity.Property(e => e.HesapNo2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HESAP_NO_2");
            entity.Property(e => e.Hizmetsayisi).HasColumnName("HIZMETSAYISI");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILCE");
            entity.Property(e => e.IlgiliKisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILGILI_KISI");
            entity.Property(e => e.InternetMusterisi).HasColumnName("INTERNET_MUSTERISI");
            entity.Property(e => e.IseBaslamaTarih)
                .HasColumnType("datetime")
                .HasColumnName("ISE_BASLAMA_TARIH");
            entity.Property(e => e.IskontoOran)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ISKONTO_ORAN");
            entity.Property(e => e.IstenAyrilmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("ISTEN_AYRILMA_TARIH");
            entity.Property(e => e.KalanIzinGun).HasColumnName("KALAN_IZIN_GUN");
            entity.Property(e => e.KartCvvNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KART_CVV_NO");
            entity.Property(e => e.KartNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KART_NO");
            entity.Property(e => e.KartSahibi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KART_SAHIBI");
            entity.Property(e => e.KartSonAy)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KART_SON_AY");
            entity.Property(e => e.KartSonYil)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KART_SON_YIL");
            entity.Property(e => e.MizandaGoster)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("MIZANDA_GOSTER");
            entity.Property(e => e.MusteriTip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_TIP");
            entity.Property(e => e.MusteriTipId).HasColumnName("MUSTERI_TIP_ID");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.PostaKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POSTA_KODU");
            entity.Property(e => e.Renk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RENK");
            entity.Property(e => e.SubeNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBE_NO");
            entity.Property(e => e.SubeNo2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBE_NO_2");
            entity.Property(e => e.TbIlId).HasColumnName("TB_IL_ID");
            entity.Property(e => e.Tel1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEL_1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEL_2");
            entity.Property(e => e.Ulke)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ULKE");
            entity.Property(e => e.Vade).HasColumnName("VADE");
            entity.Property(e => e.Veresiye)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("VERESIYE");
            entity.Property(e => e.VergiDaire)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRE");
            entity.Property(e => e.VergiNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERGI_NO");
            entity.Property(e => e.WebAdresi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WEB_ADRESI");
            entity.Property(e => e.WhmcsKod)
                .HasMaxLength(50)
                .HasColumnName("WHMCS_KOD");
        });

        modelBuilder.Entity<TbCariPersonel>(entity =>
        {
            entity.HasKey(e => e.TbCariPersonelId).HasName("PK__TB_CARI___B043E85A3AA1AEB8");

            entity.ToTable("TB_CARI_PERSONEL");

            entity.Property(e => e.TbCariPersonelId).HasColumnName("TB_CARI_PERSONEL_ID");
            entity.Property(e => e.CpsCariId).HasColumnName("CPS_CARI_ID");
            entity.Property(e => e.CpsCepTel)
                .HasMaxLength(15)
                .HasColumnName("CPS_CEP_TEL");
            entity.Property(e => e.CpsGorev)
                .HasMaxLength(50)
                .HasColumnName("CPS_GOREV");
            entity.Property(e => e.CpsIsim)
                .HasMaxLength(50)
                .HasColumnName("CPS_ISIM");
            entity.Property(e => e.CpsMail)
                .HasMaxLength(50)
                .HasColumnName("CPS_MAIL");
            entity.Property(e => e.CpsMobil)
                .HasMaxLength(15)
                .HasColumnName("CPS_MOBIL");
            entity.Property(e => e.CpsTel)
                .HasMaxLength(15)
                .HasColumnName("CPS_TEL");
        });

        modelBuilder.Entity<TbCariUser>(entity =>
        {
            entity.HasKey(e => e.TbCariUserId).HasName("PK__TB_CARI___B6C407C01446FBA6");

            entity.ToTable("TB_CARI_USER");

            entity.HasIndex(e => e.UserName, "UQ__TB_CARI___E0B75F6F17236851").IsUnique();

            entity.Property(e => e.TbCariUserId).HasColumnName("TB_CARI_USER_ID");
            entity.Property(e => e.UserName)
                .HasMaxLength(56)
                .HasColumnName("USER_NAME");
        });

        modelBuilder.Entity<TbCarifaturaAdre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TB_CARIF__3214EC272ADF1596");

            entity.ToTable("TB_CARIFATURA_ADRES", tb => tb.HasTrigger("Adres_Varsayilan"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adres)
                .HasMaxLength(2000)
                .HasColumnName("ADRES");
            entity.Property(e => e.FaturaUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FATURA_UNVAN");
            entity.Property(e => e.Il)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILCE");
            entity.Property(e => e.PostaKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POSTA_KODU");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbIlId).HasColumnName("TB_IL_ID");
            entity.Property(e => e.Varsayilan).HasColumnName("VARSAYILAN");
            entity.Property(e => e.VergiDaire)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRE");
            entity.Property(e => e.VergiNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERGI_NO");
        });

        modelBuilder.Entity<TbCarifi>(entity =>
        {
            entity.HasKey(e => e.TbCarifisId);

            entity.ToTable("TB_CARIFIS", tb =>
            {
                tb.HasTrigger("TRG_CARIFIS_DEGISTIR");
                tb.HasTrigger("TRG_CARIFIS_EKLE");
                tb.HasTrigger("TRG_CARIFIS_EKLE_DEGISTIR");
                tb.HasTrigger("TRG_CARIFIS_SIL");
            });

            entity.Property(e => e.TbCarifisId).HasColumnName("TB_CARIFIS_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ae)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AE");
            entity.Property(e => e.Aktarim).HasColumnName("AKTARIM");
            entity.Property(e => e.AktarimTip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("T = TAHSİL, A = C/H AKTARILDI, F=FATURALANDI, V = VERESİYE FİŞLERDEN")
                .HasColumnName("AKTARIM_TIP");
            entity.Property(e => e.AraToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ARA_TOPLAM");
            entity.Property(e => e.BagliEvrakId).HasColumnName("BAGLI_EVRAK_ID");
            entity.Property(e => e.BelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO");
            entity.Property(e => e.CekToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CEK_TOPLAM");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.FaturaVade)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_VADE");
            entity.Property(e => e.Faturalanmis).HasColumnName("FATURALANMIS");
            entity.Property(e => e.FisAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIS_ACIKLAMA");
            entity.Property(e => e.FisNo)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("FIS_NO");
            entity.Property(e => e.FisTip)
                .HasComment("1  - TAHSİL FİŞİ\r\n2  - TEDİYE FİŞİ\r\n3  - BORÇ DEKONTU\r\n4  - ALACAK DEKONTU\r\n6  - VERESİYE FİŞ\r\n9  - GİDER PUSULASI\r\n10 - GELİR PUSULASI\r\n12 - BANKA HAVALESİ\r\n13 - BANKA HAVALESİ\r\n15 - EYF Fişi\r\n-------------------\r\n7 - VARDIYA AÇIĞI\r\n8 - VARDİYA FAZLASI")
                .HasColumnName("FIS_TIP");
            entity.Property(e => e.FisTur)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("BORÇ VEYA ALACAK FİŞİ OLDUĞUNU BELİRTİR. B VEYA A DEĞERİ ALIR")
                .HasColumnName("FIS_TUR");
            entity.Property(e => e.GenelToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("GENEL_TOPLAM");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.IskontoOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ISKONTO_ORAN");
            entity.Property(e => e.IskontoToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ISKONTO_TOPLAM");
            entity.Property(e => e.Kalan)
                .HasComputedColumnSql("([GENEL_TOPLAM]-[ODENEN])", false)
                .HasColumnType("decimal(19, 3)")
                .HasColumnName("KALAN");
            entity.Property(e => e.KdvToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KDV_TOPLAM");
            entity.Property(e => e.Km)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KM");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KUR");
            entity.Property(e => e.Muhasebelesmis).HasColumnName("MUHASEBELESMIS");
            entity.Property(e => e.NakitToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NAKIT_TOPLAM");
            entity.Property(e => e.OdemeVade)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_VADE");
            entity.Property(e => e.Odenen)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ODENEN");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.OzelKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD");
            entity.Property(e => e.PosToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("POS_TOPLAM");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SAAT");
            entity.Property(e => e.SatisTarih)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_TARIH");
            entity.Property(e => e.SatisTur)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SATIS_TUR");
            entity.Property(e => e.SenetToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SENET_TOPLAM");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbBankaId).HasColumnName("TB_BANKA_ID");
            entity.Property(e => e.TbBankahrkId).HasColumnName("TB_BANKAHRK_ID");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbCariplakaId).HasColumnName("TB_CARIPLAKA_ID");
            entity.Property(e => e.TbDevirfisDetayId).HasColumnName("TB_DEVIRFIS_DETAY_ID");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbEyffisId).HasColumnName("TB_EYFFIS_ID");
            entity.Property(e => e.TbGelirgiderId).HasColumnName("TB_GELIRGIDER_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbKasaId).HasColumnName("TB_KASA_ID");
            entity.Property(e => e.TbKasahrkId).HasColumnName("TB_KASAHRK_ID");
            entity.Property(e => e.TbMarketsatisId).HasColumnName("TB_MARKETSATIS_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.TbVardiyaId).HasColumnName("TB_VARDIYA_ID");
            entity.Property(e => e.UygulananFiyat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("VERESİYE SATIŞTA KULLANILIYOR.")
                .HasColumnName("UYGULANAN_FIYAT");
            entity.Property(e => e.VadeFarki)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("VADE_FARKI");
            entity.Property(e => e.VardiyaIslem)
                .HasComment("VARDİYA İŞLEMİ OLUP OLMADIĞI")
                .HasColumnName("VARDIYA_ISLEM");
            entity.Property(e => e.Yazdirma).HasColumnName("YAZDIRMA");
            entity.Property(e => e.YeniFiyatUygulandi).HasColumnName("YENI_FIYAT_UYGULANDI");
        });

        modelBuilder.Entity<TbCarihrk>(entity =>
        {
            entity.ToTable("TB_CARIHRK", tb => tb.HasTrigger("TRG_CARIHRK_EKLE"));

            entity.Property(e => e.TbCarihrkId).HasColumnName("TB_CARIHRK_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ba)
                .HasComment("-1 = BORÇ\r\n1 = ALACAK")
                .HasColumnName("BA");
            entity.Property(e => e.BirimFiyat)
                .HasComment("VERESİYE FİŞTE KULLANILIYOR")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BIRIM_FIYAT");
            entity.Property(e => e.CariFisTip)
                .HasComment("1  - TAHSİL\r\n2  - TEDIYE\r\n3  - BORC DEKONT\r\n4  - ALACAK DEKONT\r\n6  - VERESİYE SATIŞ\r\n13 - BANKA HAVALESİ\r\n31 - MAAŞ TAHAKKUK\r\n32 - MAAŞ ÖDEMESİ / AVANS\r\n99 - DEVİR")
                .HasColumnName("CARI_FIS_TIP");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.FisSiraNo).HasColumnName("FIS_SIRA_NO");
            entity.Property(e => e.HareketAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HAREKET_ACIKLAMA");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KUR");
            entity.Property(e => e.Miktar)
                .HasComment("VERESİYE FİŞTE KULLANILIYOR")
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Muhasebelesmis).HasColumnName("MUHASEBELESMIS");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.Prosedur)
                .HasDefaultValueSql("((1))")
                .HasComment("TRİGERLERİN ÇALIP ÇALIŞMAYACAĞININ KONTROLU İÇİN KULLANILACAK")
                .HasColumnName("PROSEDUR");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SAAT");
            entity.Property(e => e.SatisTur)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("VERESİYE FİŞTE KULLANILIYOR / TANKER VEYA POMPA SATIŞI OLDUĞU")
                .HasColumnName("SATIS_TUR");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbBankaId).HasColumnName("TB_BANKA_ID");
            entity.Property(e => e.TbBankahrkId).HasColumnName("TB_BANKAHRK_ID");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbCarifisId).HasColumnName("TB_CARIFIS_ID");
            entity.Property(e => e.TbCekId).HasColumnName("TB_CEK_ID");
            entity.Property(e => e.TbDepoId)
                .HasComment("VERESİYE FİŞTE KULLANILIYOR")
                .HasColumnName("TB_DEPO_ID");
            entity.Property(e => e.TbDevirfisDetayId).HasColumnName("TB_DEVIRFIS_DETAY_ID");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbEyfhrkId).HasColumnName("TB_EYFHRK_ID");
            entity.Property(e => e.TbGelirgiderId)
                .HasComment("VERESİYE FİŞTE KULLANILIYOR")
                .HasColumnName("TB_GELIRGIDER_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbKasaId).HasColumnName("TB_KASA_ID");
            entity.Property(e => e.TbKasahrkId).HasColumnName("TB_KASAHRK_ID");
            entity.Property(e => e.TbMarketsatisId).HasColumnName("TB_MARKETSATIS_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.TbPoshrkId).HasColumnName("TB_POSHRK_ID");
            entity.Property(e => e.TbSayacId).HasColumnName("TB_SAYAC_ID");
            entity.Property(e => e.TbStokId)
                .HasComment("VERESİYE FİŞTE KULLANILIYOR")
                .HasColumnName("TB_STOK_ID");
            entity.Property(e => e.TbStokhrkId).HasColumnName("TB_STOKHRK_ID");
            entity.Property(e => e.TbVardiyaId).HasColumnName("TB_VARDIYA_ID");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.UygulananFiyat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UYGULANAN_FIYAT");
            entity.Property(e => e.YeniFiyatUygulandi).HasColumnName("YENI_FIYAT_UYGULANDI");
        });

        modelBuilder.Entity<TbCek>(entity =>
        {
            entity.ToTable("TB_CEK", tb =>
            {
                tb.HasTrigger("TRG_CEK_DEGISTIR");
                tb.HasTrigger("TRG_CEK_EKLE");
                tb.HasTrigger("TRG_CEK_EKLE_DEGISTIR");
                tb.HasTrigger("TRG_CEK_SIL");
            });

            entity.Property(e => e.TbCekId).HasColumnName("TB_CEK_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BankaTanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANKA_TANIM");
            entity.Property(e => e.Borclu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BORCLU");
            entity.Property(e => e.CeksenetNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CEKSENET_NO");
            entity.Property(e => e.Cs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CS");
            entity.Property(e => e.CsTip).HasColumnName("CS_TIP");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.Durum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DURUM");
            entity.Property(e => e.DurumAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURUM_ACIKLAMA");
            entity.Property(e => e.FisSiraNo).HasColumnName("FIS_SIRA_NO");
            entity.Property(e => e.HesapNo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("HESAP_NO");
            entity.Property(e => e.KesideEden)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KESIDE_EDEN");
            entity.Property(e => e.KesideYeri)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KESIDE_YERI");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KUR");
            entity.Property(e => e.Muhasebelesmis).HasColumnName("MUHASEBELESMIS");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.PortfoyNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PORTFOY_NO");
            entity.Property(e => e.ReferansNo).HasColumnName("REFERANS_NO");
            entity.Property(e => e.SeriNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SERI_NO");
            entity.Property(e => e.SubeAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBE_ADI");
            entity.Property(e => e.SubeKod)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SUBE_KOD");
            entity.Property(e => e.TahsilTarih)
                .HasColumnType("datetime")
                .HasColumnName("TAHSIL_TARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbBankaId).HasColumnName("TB_BANKA_ID");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbCarifisId).HasColumnName("TB_CARIFIS_ID");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbKasaId).HasColumnName("TB_KASA_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Vade)
                .HasColumnType("datetime")
                .HasColumnName("VADE");
            entity.Property(e => e.VerilenBankaId).HasColumnName("VERILEN_BANKA_ID");
            entity.Property(e => e.VerilenCariId).HasColumnName("VERILEN_CARI_ID");
            entity.Property(e => e.VerilenFisId).HasColumnName("VERILEN_FIS_ID");
            entity.Property(e => e.VerilenTarih)
                .HasColumnType("datetime")
                .HasColumnName("VERILEN_TARIH");
        });

        modelBuilder.Entity<TbCekhrk>(entity =>
        {
            entity.ToTable("TB_CEKHRK");

            entity.Property(e => e.TbCekhrkId).HasColumnName("TB_CEKHRK_ID");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.DurumAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURUM_ACIKLAMA");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbBankaId).HasColumnName("TB_BANKA_ID");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbCekId).HasColumnName("TB_CEK_ID");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbFisId).HasColumnName("TB_FIS_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.VerilenBankaId).HasColumnName("VERILEN_BANKA_ID");
            entity.Property(e => e.VerilenCariId).HasColumnName("VERILEN_CARI_ID");
            entity.Property(e => e.VerilenFisId).HasColumnName("VERILEN_FIS_ID");
        });

        modelBuilder.Entity<TbCrmUser>(entity =>
        {
            entity.ToTable("TB_CRM_USER");

            entity.Property(e => e.TbCrmUserId).HasColumnName("TB_CRM_USER_ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Eposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.EskiUserId).HasColumnName("ESKI_USER_ID");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.Telefonno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONNO");
            entity.Property(e => e.UserAdmin).HasColumnName("USER_ADMIN");
            entity.Property(e => e.UserCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_CODE");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_PASSWORD");
        });

        modelBuilder.Entity<TbCrmUserYetki>(entity =>
        {
            entity.ToTable("TB_CRM_USER_YETKI");

            entity.Property(e => e.TbCrmUserYetkiId).HasColumnName("TB_CRM_USER_YETKI_ID");
            entity.Property(e => e.TbCrmUserId).HasColumnName("TB_CRM_USER_ID");
            entity.Property(e => e.YetkiAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YETKI_ACIKLAMA");
            entity.Property(e => e.YetkiDurum).HasColumnName("YETKI_DURUM");
        });

        modelBuilder.Entity<TbDepo>(entity =>
        {
            entity.ToTable("TB_DEPO", tb =>
            {
                tb.HasTrigger("TRG_DEPO_DEGISTIR");
                tb.HasTrigger("TRG_DEPO_EKLE_DEGISTIR");
            });

            entity.Property(e => e.TbDepoId).HasColumnName("TB_DEPO_ID");
            entity.Property(e => e.Aktif)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("AKTIF");
            entity.Property(e => e.CikanMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CIKAN_MIKTAR");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.DepoKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPO_KOD");
            entity.Property(e => e.DepoTanim)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DEPO_TANIM");
            entity.Property(e => e.GirenMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("GIREN_MIKTAR");
            entity.Property(e => e.Kapasite)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KAPASITE");
            entity.Property(e => e.Kesafet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KESAFET");
            entity.Property(e => e.KgStokMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KG_STOK_MIKTAR");
            entity.Property(e => e.KritikMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KRITIK_MIKTAR");
            entity.Property(e => e.KritikMiktarUyari)
                .HasComment("KRITIK MİKTARIN ALTINA DÜŞTÜĞÜNDE UYARI VERİP VERMEMESİ")
                .HasColumnName("KRITIK_MIKTAR_UYARI");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.StokMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("STOK_MIKTAR");
            entity.Property(e => e.Tanker)
                .HasComment("TANKER İSE 1 DEĞİL İSE 0 DEĞERİNİ ALIR")
                .HasColumnName("TANKER");
            entity.Property(e => e.TbGrupId).HasColumnName("TB_GRUP_ID");
            entity.Property(e => e.TbStokId).HasColumnName("TB_STOK_ID");
            entity.Property(e => e.Tip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("D = DEPO, T = TANK")
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<TbDestek>(entity =>
        {
            entity.HasKey(e => e.TbDestekId).HasName("PK__TB_DESTE__2AF6574F2A6B46EF");

            entity.ToTable("TB_DESTEK", tb => tb.HasTrigger("TB_DESTEK_tru"));

            entity.Property(e => e.TbDestekId).HasColumnName("TB_DESTEK_ID");
            entity.Property(e => e.DskAktif).HasColumnName("DSK_AKTIF");
            entity.Property(e => e.DskBaslamaSaati)
                .HasMaxLength(20)
                .HasColumnName("DSK_BASLAMA_SAATI");
            entity.Property(e => e.DskBaslamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DSK_BASLAMA_TARIHI");
            entity.Property(e => e.DskBitisSaati)
                .HasMaxLength(20)
                .HasColumnName("DSK_BITIS_SAATI");
            entity.Property(e => e.DskBitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DSK_BITIS_TARIHI");
            entity.Property(e => e.DskDegistirenId).HasColumnName("DSK_DEGISTIREN_ID");
            entity.Property(e => e.DskDegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DSK_DEGISTIRME_TARIH");
            entity.Property(e => e.DskDestekTipiId).HasColumnName("DSK_DESTEK_TIPI_ID");
            entity.Property(e => e.DskEposta)
                .HasMaxLength(100)
                .HasColumnName("DSK_EPOSTA");
            entity.Property(e => e.DskFirmaId).HasColumnName("DSK_FIRMA_ID");
            entity.Property(e => e.DskGercekkapanistarih)
                .HasColumnType("datetime")
                .HasColumnName("DSK_GERCEKKAPANISTARIH");
            entity.Property(e => e.DskGorusulenKisiId).HasColumnName("DSK_GORUSULEN_KISI_ID");
            entity.Property(e => e.DskIsSuresi).HasColumnName("DSK_IS_SURESI");
            entity.Property(e => e.DskIstekler)
                .IsUnicode(false)
                .HasColumnName("DSK_ISTEKLER");
            entity.Property(e => e.DskKapali)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DSK_KAPALI");
            entity.Property(e => e.DskKonuAciklama).HasColumnName("DSK_KONU_ACIKLAMA");
            entity.Property(e => e.DskKonuBaslik)
                .HasMaxLength(100)
                .HasColumnName("DSK_KONU_BASLIK");
            entity.Property(e => e.DskKonuId).HasColumnName("DSK_KONU_ID");
            entity.Property(e => e.DskOlusturanId).HasColumnName("DSK_OLUSTURAN_ID");
            entity.Property(e => e.DskOlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("DSK_OLUSTURMA_TARIH");
            entity.Property(e => e.DskOnayUserId).HasColumnName("DSK_ONAY_USER_ID");
            entity.Property(e => e.DskOncelikId).HasColumnName("DSK_ONCELIK_ID");
            entity.Property(e => e.DskPersonelId).HasColumnName("DSK_PERSONEL_ID");
            entity.Property(e => e.DskProgramId).HasColumnName("DSK_PROGRAM_ID");
            entity.Property(e => e.DskRevizyonId).HasColumnName("DSK_REVIZYON_ID");
            entity.Property(e => e.DskSonuc)
                .HasMaxLength(100)
                .HasColumnName("DSK_SONUC");
            entity.Property(e => e.DskSonucAciklama)
                .IsUnicode(false)
                .HasColumnName("DSK_SONUC_ACIKLAMA");
            entity.Property(e => e.DskSonucId).HasColumnName("DSK_SONUC_ID");
            entity.Property(e => e.DskSure).HasColumnName("DSK_SURE");
            entity.Property(e => e.DskTalepSebepId).HasColumnName("DSK_TALEP_SEBEP_ID");
            entity.Property(e => e.DskTelefon)
                .HasMaxLength(100)
                .HasColumnName("DSK_TELEFON");
        });

        modelBuilder.Entity<TbDestekCevap>(entity =>
        {
            entity.ToTable("TB_DESTEK_CEVAP");

            entity.Property(e => e.TbDestekCevapId).HasColumnName("TB_DESTEK_CEVAP_ID");
            entity.Property(e => e.BaslamaZamani)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BASLAMA_ZAMANI");
            entity.Property(e => e.BitisZamani)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BITIS_ZAMANI");
            entity.Property(e => e.DestekTarihi)
                .HasColumnType("date")
                .HasColumnName("DESTEK_TARIHI");
            entity.Property(e => e.TbCrmUserId).HasColumnName("TB_CRM_USER_ID");
            entity.Property(e => e.TbDestekId).HasColumnName("TB_DESTEK_ID");
            entity.Property(e => e.YapilanIslem)
                .HasColumnType("text")
                .HasColumnName("YAPILAN_ISLEM");
        });

        modelBuilder.Entity<TbDestekKonu>(entity =>
        {
            entity.HasKey(e => e.TbDestekKonuId).HasName("PK__TB_DESTE__0921214B3E723F9C");

            entity.ToTable("TB_DESTEK_KONU");

            entity.Property(e => e.TbDestekKonuId).HasColumnName("TB_DESTEK_KONU_ID");
            entity.Property(e => e.TbDestekKonuBaslik)
                .HasMaxLength(100)
                .HasColumnName("TB_DESTEK_KONU_BASLIK");
            entity.Property(e => e.TbDestekKonuIcerik).HasColumnName("TB_DESTEK_KONU_ICERIK");
        });

        modelBuilder.Entity<TbDestekLog>(entity =>
        {
            entity.HasKey(e => e.TbDestekLogId).HasName("PK__TB_DESTE__30A2B36A0CA5D9DE");

            entity.ToTable("TB_DESTEK_LOG");

            entity.Property(e => e.TbDestekLogId).HasColumnName("TB_DESTEK_LOG_ID");
            entity.Property(e => e.DskDegistirenId).HasColumnName("DSK_DEGISTIREN_ID");
            entity.Property(e => e.DskDegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DSK_DEGISTIRME_TARIH");
            entity.Property(e => e.DskEskiSonucId).HasColumnName("DSK_ESKI_SONUC_ID");
            entity.Property(e => e.DskYeniSonucId).HasColumnName("DSK_YENI_SONUC_ID");
            entity.Property(e => e.TbDestekId).HasColumnName("TB_DESTEK_ID");
        });

        modelBuilder.Entity<TbDomain>(entity =>
        {
            entity.ToTable("TB_DOMAIN", tb =>
            {
                tb.HasTrigger("TRG_DOMAIN_EKLE");
                tb.HasTrigger("TRG_DOMAIN_SIL");
            });

            entity.HasIndex(e => e.DomainAdi, "TB_DOMAIN_uq").IsUnique();

            entity.Property(e => e.TbDomainId).HasColumnName("TB_DOMAIN_ID");
            entity.Property(e => e.Aciklama)
                .HasColumnType("text")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Banka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANKA");
            entity.Property(e => e.CpanelKullaniciAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CPANEL_KULLANICI_ADI");
            entity.Property(e => e.CpanelSifre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CPANEL_SIFRE");
            entity.Property(e => e.DomainAciklama)
                .HasDefaultValueSql("((1))")
                .HasColumnName("DOMAIN_ACIKLAMA");
            entity.Property(e => e.DomainAciklamaId).HasColumnName("DOMAIN_ACIKLAMA_ID");
            entity.Property(e => e.DomainAdi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DOMAIN_ADI");
            entity.Property(e => e.DomainBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("DOMAIN_BASLANGIC_TARIH");
            entity.Property(e => e.DomainBirhost).HasColumnName("DOMAIN_BIRHOST");
            entity.Property(e => e.DomainBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("DOMAIN_BITIS_TARIH");
            entity.Property(e => e.DomainHostingId).HasColumnName("DOMAIN_HOSTING_ID");
            entity.Property(e => e.DomainKyer).HasColumnName("DOMAIN_KYER");
            entity.Property(e => e.DomainSanalSunucuId).HasColumnName("DOMAIN_SANAL_SUNUCU_ID");
            entity.Property(e => e.DomainSslId).HasColumnName("DOMAIN_SSL_ID");
            entity.Property(e => e.DomainSunucuId).HasColumnName("DOMAIN_SUNUCU_ID");
            entity.Property(e => e.DomainSure).HasColumnName("DOMAIN_SURE");
            entity.Property(e => e.DomainVar).HasColumnName("DOMAIN_VAR");
            entity.Property(e => e.DomainYil)
                .HasDefaultValueSql("((1))")
                .HasColumnName("DOMAIN_YIL");
            entity.Property(e => e.DuzenlemeSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DUZENLEME_SAAT");
            entity.Property(e => e.DuzenlemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DUZENLEME_TARIH");
            entity.Property(e => e.Farklifirma).HasColumnName("FARKLIFIRMA");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.FaturaId).HasColumnName("FATURA_ID");
            entity.Property(e => e.Faturao)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FATURAO");
            entity.Property(e => e.FtpKullaniciAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FTP_KULLANICI_ADI");
            entity.Property(e => e.FtpSifre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FTP_SIFRE");
            entity.Property(e => e.Grup)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GRUP");
            entity.Property(e => e.GuncelAciklama)
                .HasMaxLength(50)
                .HasColumnName("GUNCEL_ACIKLAMA");
            entity.Property(e => e.GuncelTutar)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("GUNCEL_TUTAR");
            entity.Property(e => e.Hatirlat).HasColumnName("HATIRLAT");
            entity.Property(e => e.HostingBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("HOSTING_BASLANGIC_TARIH");
            entity.Property(e => e.HostingBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("HOSTING_BITIS_TARIH");
            entity.Property(e => e.HostingPaket)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HOSTING_PAKET");
            entity.Property(e => e.HostingVar).HasColumnName("HOSTING_VAR");
            entity.Property(e => e.HostingYil)
                .HasDefaultValueSql("((1))")
                .HasColumnName("HOSTING_YIL");
            entity.Property(e => e.Indirimfiyat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("INDIRIMFIYAT");
            entity.Property(e => e.Kdvtutar)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("KDVTUTAR");
            entity.Property(e => e.Kimde).HasColumnName("KIMDE");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.OdemeYapildi).HasColumnName("ODEME_YAPILDI");
            entity.Property(e => e.OdemetipId).HasColumnName("ODEMETIP_ID");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PARA_BIRIMI");
            entity.Property(e => e.RegisterFirma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGISTER_FIRMA");
            entity.Property(e => e.TaksitSayisi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TAKSIT_SAYISI");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbPaketId).HasColumnName("TB_PAKET_ID");
            entity.Property(e => e.TescilYer)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TESCIL_YER");
            entity.Property(e => e.Toplam)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TOPLAM");
            entity.Property(e => e.Ucretsiz)
                .HasDefaultValueSql("((0))")
                .HasColumnName("UCRETSIZ");
        });

        modelBuilder.Entity<TbDomainhrk>(entity =>
        {
            entity.HasKey(e => e.TbDomainhrkId).HasName("TB_DOMAINHRK_pk");

            entity.ToTable("TB_DOMAINHRK", tb =>
            {
                tb.HasTrigger("TRG_DOMAINHRK_EKLE");
                tb.HasTrigger("TRG_DOMAINHRK_SIL");
            });

            entity.Property(e => e.TbDomainhrkId).HasColumnName("TB_DOMAINHRK_ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.AlanadiDegistir).HasColumnName("ALANADI_DEGISTIR");
            entity.Property(e => e.DomainBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("DOMAIN_BASLANGIC_TARIH");
            entity.Property(e => e.DomainBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("DOMAIN_BITIS_TARIH");
            entity.Property(e => e.DomainYenileme).HasColumnName("DOMAIN_YENILEME");
            entity.Property(e => e.DomainYil)
                .HasDefaultValueSql("((1))")
                .HasColumnName("DOMAIN_YIL");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.FaturaId).HasColumnName("FATURA_ID");
            entity.Property(e => e.Hatirlat).HasColumnName("HATIRLAT");
            entity.Property(e => e.HostingBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("HOSTING_BASLANGIC_TARIH");
            entity.Property(e => e.HostingBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("HOSTING_BITIS_TARIH");
            entity.Property(e => e.HostingPaket)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HOSTING_PAKET");
            entity.Property(e => e.HostingYenileme).HasColumnName("HOSTING_YENILEME");
            entity.Property(e => e.HostingYenilemeTip).HasColumnName("HOSTING_YENILEME_TIP");
            entity.Property(e => e.HostingYil)
                .HasDefaultValueSql("((1))")
                .HasColumnName("HOSTING_YIL");
            entity.Property(e => e.Iptal)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IPTAL");
            entity.Property(e => e.IslemTip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("YENİLEME\r\nAÇILIŞ")
                .HasColumnName("ISLEM_TIP");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.OdemeYapildi).HasColumnName("ODEME_YAPILDI");
            entity.Property(e => e.OdemetipId).HasColumnName("ODEMETIP_ID");
            entity.Property(e => e.ParaBirimi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PARA_BIRIMI");
            entity.Property(e => e.RegisterFirma)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGISTER_FIRMA");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbDomainId).HasColumnName("TB_DOMAIN_ID");
            entity.Property(e => e.TbHostingId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("TB_HOSTING_ID");
            entity.Property(e => e.TescilYeri)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("TESCIL_YERI");
        });

        modelBuilder.Entity<TbDonanimMarka>(entity =>
        {
            entity.HasKey(e => e.TbMarkaId);

            entity.ToTable("TB_DONANIM_MARKA");

            entity.Property(e => e.TbMarkaId).HasColumnName("TB_MARKA_ID");
            entity.Property(e => e.MarkaTanim)
                .HasMaxLength(50)
                .HasColumnName("MARKA_TANIM");
            entity.Property(e => e.MarkaTip)
                .HasMaxLength(50)
                .HasColumnName("MARKA_TIP");
        });

        modelBuilder.Entity<TbDonanimModel>(entity =>
        {
            entity.HasKey(e => e.TbModelId);

            entity.ToTable("TB_DONANIM_MODEL");

            entity.Property(e => e.TbModelId).HasColumnName("TB_MODEL_ID");
            entity.Property(e => e.MarkaId).HasColumnName("MARKA_ID");
            entity.Property(e => e.ModelTanim)
                .HasMaxLength(50)
                .HasColumnName("MODEL_TANIM");
        });

        modelBuilder.Entity<TbFaaliyetDisiGider>(entity =>
        {
            entity.HasKey(e => e.TbFaaliyetDisiGiderId).HasName("PK__TB_FAALIYET_DISI__16644E42");

            entity.ToTable("TB_FAALIYET_DISI_GIDER");

            entity.Property(e => e.TbFaaliyetDisiGiderId).HasColumnName("TB_FAALIYET_DISI_GIDER_ID");
            entity.Property(e => e.TbFaaliyetDisiGiderAciklama)
                .HasMaxLength(250)
                .HasColumnName("TB_FAALIYET_DISI_GIDER_ACIKLAMA");
            entity.Property(e => e.TbFaaliyetDisiGiderCariId)
                .HasComment("KIMDEN GELDIYSE")
                .HasColumnName("TB_FAALIYET_DISI_GIDER_CARI_ID");
            entity.Property(e => e.TbFaaliyetDisiGiderGrupId).HasColumnName("TB_FAALIYET_DISI_GIDER_GRUP_ID");
            entity.Property(e => e.TbFaaliyetDisiGiderKdv)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TB_FAALIYET_DISI_GIDER_KDV");
            entity.Property(e => e.TbFaaliyetDisiGiderKdvsizToplam)
                .HasComputedColumnSql("([TB_FAALIYET_DISI_GIDER_TUTAR]-[TB_FAALIYET_DISI_GIDER_KDV])", false)
                .HasColumnType("decimal(19, 3)")
                .HasColumnName("TB_FAALIYET_DISI_GIDER_KDVSIZ_TOPLAM");
            entity.Property(e => e.TbFaaliyetDisiGiderTarih)
                .HasColumnType("datetime")
                .HasColumnName("TB_FAALIYET_DISI_GIDER_TARIH");
            entity.Property(e => e.TbFaaliyetDisiGiderTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TB_FAALIYET_DISI_GIDER_TUTAR");
        });

        modelBuilder.Entity<TbFaturaStok>(entity =>
        {
            entity.ToTable("TB_FATURA_STOK");

            entity.Property(e => e.TbFaturaStokId).HasColumnName("TB_FATURA_STOK_ID");
            entity.Property(e => e.DomainDeger)
                .HasMaxLength(50)
                .HasColumnName("DOMAIN_DEGER");
            entity.Property(e => e.DomainId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("DOMAIN_ID");
            entity.Property(e => e.HostingDeger)
                .HasMaxLength(50)
                .HasColumnName("HOSTING_DEGER");
            entity.Property(e => e.HostingId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("HOSTING_ID");
            entity.Property(e => e.SslDeger)
                .HasMaxLength(50)
                .HasColumnName("SSL_DEGER");
            entity.Property(e => e.SslId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("SSL_ID");
            entity.Property(e => e.SunucuDeger)
                .HasMaxLength(50)
                .HasColumnName("SUNUCU_DEGER");
            entity.Property(e => e.SunucuId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("SUNUCU_ID");
        });

        modelBuilder.Entity<TbFirma>(entity =>
        {
            entity.HasKey(e => e.TbFirmaId).HasName("TB_FIRMA_pk");

            entity.ToTable("TB_FIRMA");

            entity.HasIndex(e => e.FirmaUnvan, "TB_FIRMA_uq").IsUnique();

            entity.Property(e => e.TbFirmaId).HasColumnName("TB_FIRMA_ID");
            entity.Property(e => e.Adres)
                .HasColumnType("text")
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktif)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("AKTIF");
            entity.Property(e => e.AracSayisi).HasColumnName("ARAC_SAYISI");
            entity.Property(e => e.Bolge)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOLGE");
            entity.Property(e => e.Cep)
                .HasMaxLength(30)
                .HasColumnName("CEP");
            entity.Property(e => e.Durumu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DURUMU");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.FirmaPuani)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRMA_PUANI");
            entity.Property(e => e.FirmaUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIRMA_UNVAN");
            entity.Property(e => e.GorusmeSayisi).HasColumnName("GORUSME_SAYISI");
            entity.Property(e => e.IlgiliKisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILGILI_KISI");
            entity.Property(e => e.IlgiliKisiPozisyon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILGILI_KISI_POZISYON");
            entity.Property(e => e.IlgiliUrun)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILGILI_URUN");
            entity.Property(e => e.IlkGorusmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ILK_GORUSME_TARIH");
            entity.Property(e => e.KullandigiYazilimlar)
                .HasColumnType("ntext")
                .HasColumnName("KULLANDIGI_YAZILIMLAR");
            entity.Property(e => e.KullaniciSayisi).HasColumnName("KULLANICI_SAYISI");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.PostaKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POSTA_KODU");
            entity.Property(e => e.Renk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RENK");
            entity.Property(e => e.SatilanFiyat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATILAN_FIYAT");
            entity.Property(e => e.SatisTarih)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_TARIH");
            entity.Property(e => e.SatisTemsilcisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SATIS_TEMSILCISI");
            entity.Property(e => e.SatisTemsilcisiId)
                .HasComment("KULLANICI TANIMLARINDAN GELIYOR")
                .HasColumnName("SATIS_TEMSILCISI_ID");
            entity.Property(e => e.Satisdurum)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SATISDURUM");
            entity.Property(e => e.Sektor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEKTOR");
            entity.Property(e => e.SonGorusmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("SON_GORUSME_TARIH");
            entity.Property(e => e.SonrakiGorusmeSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('00:00:00')")
                .HasColumnName("SONRAKI_GORUSME_SAAT");
            entity.Property(e => e.SonrakiGorusmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("SONRAKI_GORUSME_TARIH");
            entity.Property(e => e.TakipEdilmesiGerekenTarih)
                .HasColumnType("datetime")
                .HasColumnName("TAKIP_EDILMESI_GEREKEN_TARIH");
            entity.Property(e => e.TbIlId).HasColumnName("TB_IL_ID");
            entity.Property(e => e.TeklifMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TEKLIF_MIKTAR");
            entity.Property(e => e.Tel1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEL_1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEL_2");
            entity.Property(e => e.Ulke)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ULKE");
            entity.Property(e => e.Web)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WEB");
            entity.Property(e => e.Yeni)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("YENI");
            entity.Property(e => e.Yorum)
                .HasColumnType("text")
                .HasColumnName("YORUM");
        });

        modelBuilder.Entity<TbFirmaSatistemsilciLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TB_FIRMA__3214EC273AA1AEB8");

            entity.ToTable("TB_FIRMA_SATISTEMSILCI_LOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FslAciklama)
                .HasMaxLength(1000)
                .HasColumnName("FSL_ACIKLAMA");
            entity.Property(e => e.FslEskiTemsilciId).HasColumnName("FSL_ESKI_TEMSILCI_ID");
            entity.Property(e => e.FslFirmaId).HasColumnName("FSL_FIRMA_ID");
            entity.Property(e => e.FslHareketTipi)
                .HasMaxLength(20)
                .HasColumnName("FSL_HAREKET_TIPI");
            entity.Property(e => e.FslTarih)
                .HasColumnType("datetime")
                .HasColumnName("FSL_TARIH");
            entity.Property(e => e.FslYeniTemsilciId).HasColumnName("FSL_YENI_TEMSILCI_ID");
        });

        modelBuilder.Entity<TbGelirgider>(entity =>
        {
            entity.ToTable("TB_GELIRGIDER", tb =>
            {
                tb.HasTrigger("TRG_GELIRGIDER_EKLE_DEGISTIR");
                tb.HasTrigger("TRG_GELIRGIDER_SIL");
            });

            entity.Property(e => e.TbGelirgiderId).HasColumnName("TB_GELIRGIDER_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Bakiye)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BAKIYE");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.GelirgiderKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GELIRGIDER_KOD");
            entity.Property(e => e.GelirgiderTanim)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("GELIRGIDER_TANIM");
            entity.Property(e => e.Mizandagosterme)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MIZANDAGOSTERME");
            entity.Property(e => e.MuhasebeKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MUHASEBE_KOD");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.TbGrupId).HasColumnName("TB_GRUP_ID");
            entity.Property(e => e.TbUstId).HasColumnName("TB_UST_ID");
            entity.Property(e => e.Tip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('GELİR')")
                .IsFixedLength()
                .HasComment("GELİR VEYA GİDER DEĞERİNİ ALIR")
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<TbGelirgiderhrk>(entity =>
        {
            entity.ToTable("TB_GELIRGIDERHRK", tb =>
            {
                tb.HasTrigger("TRG_GELIRGIDERHRK_DEGISTIR");
                tb.HasTrigger("TRG_GELIRGIDERHRK_EKLE");
                tb.HasTrigger("TRG_GELIRGIDERHRK_SIL");
            });

            entity.Property(e => e.TbGelirgiderhrkId).HasColumnName("TB_GELIRGIDERHRK_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BelgeNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.FisNo)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("FIS_NO");
            entity.Property(e => e.HareketAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HAREKET_ACIKLAMA");
            entity.Property(e => e.IslemTip)
                .HasComment("9 = GELİR\r\n8 = GİDER")
                .HasColumnName("ISLEM_TIP");
            entity.Property(e => e.KdvTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KDV_TUTAR");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KUR");
            entity.Property(e => e.Muhasebelesmis).HasColumnName("MUHASEBELESMIS");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.OzelKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SAAT");
            entity.Property(e => e.SatisPersonelId).HasColumnName("SATIS_PERSONEL_ID");
            entity.Property(e => e.SatisTarih)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_TARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbBankahrkId).HasColumnName("TB_BANKAHRK_ID");
            entity.Property(e => e.TbDevirfisDetayId).HasColumnName("TB_DEVIRFIS_DETAY_ID");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbGelirgiderId).HasColumnName("TB_GELIRGIDER_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbKasahrkId).HasColumnName("TB_KASAHRK_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.TbStokfisdetayId).HasColumnName("TB_STOKFISDETAY_ID");
            entity.Property(e => e.TbStokhrkId).HasColumnName("TB_STOKHRK_ID");
            entity.Property(e => e.TbVardiyaId).HasColumnName("TB_VARDIYA_ID");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<TbGorusme>(entity =>
        {
            entity.HasKey(e => e.TbGorusmeId).HasName("TB_GORUSME_pk");

            entity.ToTable("TB_GORUSME", tb =>
            {
                tb.HasTrigger("TRG_GORUSME_DEGISTIR");
                tb.HasTrigger("TRG_GORUSME_EKLE");
                tb.HasTrigger("TRG_GORUSME_SIL");
            });

            entity.Property(e => e.TbGorusmeId).HasColumnName("TB_GORUSME_ID");
            entity.Property(e => e.GorusmeNeticesi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GORUSME_NETICESI");
            entity.Property(e => e.GorusmeNotu)
                .HasColumnType("text")
                .HasColumnName("GORUSME_NOTU");
            entity.Property(e => e.GorusmeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GORUSME_SEKLI");
            entity.Property(e => e.GorusmeSuresi)
                .HasComment("SANİYE")
                .HasColumnName("GORUSME_SURESI");
            entity.Property(e => e.GorusmeTipi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TEKNİK DESTEK (KURULUM SONRASI)\r\nKURULUM")
                .HasColumnName("GORUSME_TIPI");
            entity.Property(e => e.GorusulenKisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GORUSULEN_KISI");
            entity.Property(e => e.IlgiliUrun)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILGILI_URUN");
            entity.Property(e => e.PlanSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('00:00:00')")
                .HasColumnName("PLAN_SAAT");
            entity.Property(e => e.PlanTarih)
                .HasColumnType("datetime")
                .HasColumnName("PLAN_TARIH");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('00:00:00')")
                .HasColumnName("SAAT");
            entity.Property(e => e.SatisTemsilciId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SATIS_TEMSILCI_ID");
            entity.Property(e => e.SatisTemsilcisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SATIS_TEMSILCISI");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbFirmaId).HasColumnName("TB_FIRMA_ID");
            entity.Property(e => e.TbStokId).HasColumnName("TB_STOK_ID");
        });

        modelBuilder.Entity<TbGrup>(entity =>
        {
            entity.ToTable("TB_GRUP");

            entity.Property(e => e.TbGrupId).HasColumnName("TB_GRUP_ID");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.Filtre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("AYNI TABLOYU KULLANAN FAKAT FARKLI TANIMLAMALARI İÇEREN STOK VE YAKIT GİBİ TABLOLAR İÇİN FİLTRE ALANI KULLANILACAK.")
                .HasColumnName("FILTRE");
            entity.Property(e => e.GrupAdi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("GRUP_ADI");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.TabloAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLO_ADI");
        });

        modelBuilder.Entity<TbGuncelleme>(entity =>
        {
            entity.HasKey(e => e.GuncellemeId);

            entity.ToTable("TB_GUNCELLEME");

            entity.Property(e => e.GuncellemeId).HasColumnName("GUNCELLEME_ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Anahtar).HasColumnName("ANAHTAR");
            entity.Property(e => e.FirmaId).HasColumnName("FIRMA_ID");
            entity.Property(e => e.GuncellemeTarihi)
                .HasColumnType("date")
                .HasColumnName("GUNCELLEME_TARIHI");
            entity.Property(e => e.OrjinPersId).HasColumnName("ORJIN_PERS_ID");
            entity.Property(e => e.ProgramAdi)
                .HasMaxLength(50)
                .HasColumnName("PROGRAM_ADI");
            entity.Property(e => e.VersiyonNo)
                .HasMaxLength(50)
                .HasColumnName("VERSIYON_NO");
        });

        modelBuilder.Entity<TbHatirlaticiAyar>(entity =>
        {
            entity.HasKey(e => e.TbHatirlaticiAyarId).HasName("PK__TB_HATIRLATICI_A__4B0D20AB");

            entity.ToTable("TB_HATIRLATICI_AYAR");

            entity.Property(e => e.TbHatirlaticiAyarId).HasColumnName("TB_HATIRLATICI_AYAR_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Grup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUP");
            entity.Property(e => e.HHatirlaticiKapat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("hHATIRLATICI_KAPAT");
            entity.Property(e => e.Hatirlat)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HATIRLAT");
            entity.Property(e => e.HatirlatmaSure)
                .HasDefaultValueSql("((1))")
                .HasColumnName("HATIRLATMA_SURE");
            entity.Property(e => e.HizmetRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HIZMET_RENK");
            entity.Property(e => e.HizmetRenkG)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HIZMET_RENK_G");
            entity.Property(e => e.HizmetRenkYazi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HIZMET_RENK_YAZI");
            entity.Property(e => e.HizmetRenkYaziG)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HIZMET_RENK_YAZI_G");
            entity.Property(e => e.MesajRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MESAJ_RENK");
            entity.Property(e => e.MesajRenkG)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MESAJ_RENK_G");
            entity.Property(e => e.MesajRenkYazi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MESAJ_RENK_YAZI");
            entity.Property(e => e.MesajRenkYaziG)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MESAJ_RENK_YAZI_G");
            entity.Property(e => e.OdemeRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_RENK");
            entity.Property(e => e.OdemeRenkG)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_RENK_G");
            entity.Property(e => e.OdemeRenkYazi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_RENK_YAZI");
            entity.Property(e => e.OdemeRenkYaziG)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_RENK_YAZI_G");
            entity.Property(e => e.UyariSuresi).HasColumnName("UYARI_SURESI");
            entity.Property(e => e.UyariSuresiH).HasColumnName("UYARI_SURESI_H");
            entity.Property(e => e.UyariSuresiHG).HasColumnName("UYARI_SURESI_H_G");
            entity.Property(e => e.UyariSuresiM).HasColumnName("UYARI_SURESI_M");
            entity.Property(e => e.UyariSuresiMG).HasColumnName("UYARI_SURESI_M_G");
            entity.Property(e => e.UyariSuresiO).HasColumnName("UYARI_SURESI_O");
            entity.Property(e => e.UyariSuresiOG).HasColumnName("UYARI_SURESI_O_G");
        });

        modelBuilder.Entity<TbHosting>(entity =>
        {
            entity.HasKey(e => e.TbHostingId).HasName("PK__TB_HOSTING__220B0B18");

            entity.ToTable("TB_HOSTING", tb =>
            {
                tb.HasTrigger("TRG_HOSTING_EKLE");
                tb.HasTrigger("TRG_HOSTING_SIL");
            });

            entity.Property(e => e.TbHostingId).HasColumnName("TB_HOSTING_ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Banka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANKA");
            entity.Property(e => e.DuzenlemeSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DUZENLEME_SAAT");
            entity.Property(e => e.DuzenlemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DUZENLEME_TARIH");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.FaturaId).HasColumnName("FATURA_ID");
            entity.Property(e => e.Faturao)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FATURAO");
            entity.Property(e => e.GuncelAciklama)
                .HasMaxLength(50)
                .HasColumnName("GUNCEL_ACIKLAMA");
            entity.Property(e => e.GuncelTutar)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("GUNCEL_TUTAR");
            entity.Property(e => e.Hatirlat).HasColumnName("HATIRLAT");
            entity.Property(e => e.HostingBantGenislik)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("HOSTING_BANT_GENISLIK");
            entity.Property(e => e.HostingBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("HOSTING_BASLANGIC_TARIH");
            entity.Property(e => e.HostingBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("HOSTING_BITIS_TARIH");
            entity.Property(e => e.HostingDiskAlan)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("HOSTING_DISK_ALAN");
            entity.Property(e => e.HostingPaket)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HOSTING_PAKET");
            entity.Property(e => e.HostingSure)
                .HasComment("1: Ay\r\n2: Yıl")
                .HasColumnName("HOSTING_SURE");
            entity.Property(e => e.HostingYil)
                .HasDefaultValueSql("((1))")
                .HasColumnName("HOSTING_YIL");
            entity.Property(e => e.Indirimfiyat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("INDIRIMFIYAT");
            entity.Property(e => e.Kdvtutar)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("KDVTUTAR");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.OdemeYapildi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ODEME_YAPILDI");
            entity.Property(e => e.OdemetipId).HasColumnName("ODEMETIP_ID");
            entity.Property(e => e.TaksitSayisi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAKSIT_SAYISI");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbPaketId).HasColumnName("TB_PAKET_ID");
            entity.Property(e => e.Toplam)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TOPLAM");
            entity.Property(e => e.Ucretsiz)
                .HasDefaultValueSql("((0))")
                .HasColumnName("UCRETSIZ");
        });

        modelBuilder.Entity<TbHostinghrk>(entity =>
        {
            entity.HasKey(e => e.TbHostinghrkId).HasName("PK__TB_HOSTINGHRK__27C3E46E");

            entity.ToTable("TB_HOSTINGHRK", tb => tb.HasTrigger("TB_HOSTINGHRK_GUNCELLE"));

            entity.Property(e => e.TbHostinghrkId).HasColumnName("TB_HOSTINGHRK_ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BantGenisligiYenileme)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BANT_GENISLIGI_YENILEME");
            entity.Property(e => e.DiskAlanYenileme)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DISK_ALAN_YENILEME");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.FaturaId).HasColumnName("FATURA_ID");
            entity.Property(e => e.Hatirlat).HasColumnName("HATIRLAT");
            entity.Property(e => e.HostingBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("HOSTING_BASLANGIC_TARIH");
            entity.Property(e => e.HostingBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("HOSTING_BITIS_TARIH");
            entity.Property(e => e.HostingSure).HasColumnName("HOSTING_SURE");
            entity.Property(e => e.HostingYil).HasColumnName("HOSTING_YIL");
            entity.Property(e => e.Iptal)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IPTAL");
            entity.Property(e => e.IslemTip)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ISLEM_TIP");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.OdemeYapildi).HasColumnName("ODEME_YAPILDI");
            entity.Property(e => e.PaketDegisiklik)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PAKET_DEGISIKLIK");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SAAT");
            entity.Property(e => e.SureYenileme)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SURE_YENILEME");
            entity.Property(e => e.TaksitId).HasColumnName("TAKSIT_ID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbHostingId).HasColumnName("TB_HOSTING_ID");
            entity.Property(e => e.TbPaketId).HasColumnName("TB_PAKET_ID");
        });

        modelBuilder.Entity<TbIl>(entity =>
        {
            entity.HasKey(e => e.TbIlId).HasName("TB_IL_pk");

            entity.ToTable("TB_IL");

            entity.Property(e => e.TbIlId).HasColumnName("TB_IL_ID");
            entity.Property(e => e.AlanKod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ALAN_KOD");
            entity.Property(e => e.IlTanim)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IL_TANIM");
            entity.Property(e => e.TelKod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TEL_KOD");
            entity.Property(e => e.Ulke)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ULKE");
        });

        modelBuilder.Entity<TbIpler>(entity =>
        {
            entity.HasKey(e => e.TbIpId);

            entity.ToTable("TB_IPLER");

            entity.Property(e => e.TbIpId).HasColumnName("TB_IP_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(250)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.CariId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("CARI_ID");
            entity.Property(e => e.IpAdres)
                .HasMaxLength(50)
                .HasColumnName("IP_ADRES");
            entity.Property(e => e.IpDurumu).HasColumnName("IP_DURUMU");
            entity.Property(e => e.IpNetwork)
                .HasMaxLength(250)
                .HasColumnName("IP_NETWORK");
            entity.Property(e => e.IpTipiId).HasColumnName("IP_TIPI_ID");
            entity.Property(e => e.SunucuId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("SUNUCU_ID");
        });

        modelBuilder.Entity<TbIsListesi>(entity =>
        {
            entity.HasKey(e => e.IsListesiId);

            entity.ToTable("TB_IS_LISTESI");

            entity.Property(e => e.IsListesiId).HasColumnName("IS_LISTESI_ID");
            entity.Property(e => e.Aciklama)
                .HasColumnType("text")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AcilisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ACILIS_TARIHI");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.EPosta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("E_POSTA");
            entity.Property(e => e.IlgiliPersonelId).HasColumnName("ILGILI_PERSONEL_ID");
            entity.Property(e => e.IsAdi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IS_ADI");
            entity.Property(e => e.IsTipi).HasColumnName("IS_TIPI");
            entity.Property(e => e.KapanisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAPANIS_TARIHI");
            entity.Property(e => e.MusteriAdi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_ADI");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TARIH");
            entity.Property(e => e.Telefon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TELEFON");
            entity.Property(e => e.Yapilan)
                .HasColumnType("text")
                .HasColumnName("YAPILAN");
        });

        modelBuilder.Entity<TbIsTipleri>(entity =>
        {
            entity.HasKey(e => e.IsTipleriId);

            entity.ToTable("TB_IS_TIPLERI");

            entity.Property(e => e.IsTipleriId).HasColumnName("IS_TIPLERI_ID");
            entity.Property(e => e.IsTipi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IS_TIPI");
        });

        modelBuilder.Entity<TbKasa>(entity =>
        {
            entity.ToTable("TB_KASA", tb =>
            {
                tb.HasTrigger("TRG_KASA_DEGISTIR");
                tb.HasTrigger("TRG_KASA_EKLE_DEGISTIR");
            });

            entity.Property(e => e.TbKasaId).HasColumnName("TB_KASA_ID");
            entity.Property(e => e.Aktif)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Bakiye)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BAKIYE");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.KasaAciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("KASA_ACIKLAMA");
            entity.Property(e => e.KasaKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KASA_KOD");
            entity.Property(e => e.KasaTanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KASA_TANIM");
            entity.Property(e => e.OdemeToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ODEME_TOPLAM");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.TahsilatToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TAHSILAT_TOPLAM");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbKullaniciId)
                .HasComment("BU KASA ÜZERİNDE YETKİLİ OLAN KULLANICI")
                .HasColumnName("TB_KULLANICI_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
        });

        modelBuilder.Entity<TbKasahrk>(entity =>
        {
            entity.ToTable("TB_KASAHRK", tb =>
            {
                tb.HasTrigger("TRG_KASAHRK_EKLE");
                tb.HasTrigger("TRG_KASAHRK_SIL");
            });

            entity.Property(e => e.TbKasahrkId).HasColumnName("TB_KASAHRK_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BelgeNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO");
            entity.Property(e => e.Cikan)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CIKAN");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.Giren)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("GIREN");
            entity.Property(e => e.HareketAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HAREKET_ACIKLAMA");
            entity.Property(e => e.Islem)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("NAKİT")
                .HasColumnName("ISLEM");
            entity.Property(e => e.IslemTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("CARİ\r\nVARDİYA\r\nGELİR\r\nGİDER")
                .HasColumnName("ISLEM_TIP");
            entity.Property(e => e.KdvTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KDV_TUTAR");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KUR");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.Prosedur)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("PROSEDUR");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('00:00:00')")
                .IsFixedLength()
                .HasColumnName("SAAT");
            entity.Property(e => e.SatisPersonelId).HasColumnName("SATIS_PERSONEL_ID");
            entity.Property(e => e.SatisTarih)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_TARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbBankaId).HasColumnName("TB_BANKA_ID");
            entity.Property(e => e.TbBankahrkId).HasColumnName("TB_BANKAHRK_ID");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbCarifisId).HasColumnName("TB_CARIFIS_ID");
            entity.Property(e => e.TbDevirfisDetayId).HasColumnName("TB_DEVIRFIS_DETAY_ID");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbGelirgiderId).HasColumnName("TB_GELIRGIDER_ID");
            entity.Property(e => e.TbIslemId).HasColumnName("TB_ISLEM_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbKasaId).HasColumnName("TB_KASA_ID");
            entity.Property(e => e.TbKasatransferId).HasColumnName("TB_KASATRANSFER_ID");
            entity.Property(e => e.TbMarketsatisId).HasColumnName("TB_MARKETSATIS_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.TbSeyahatHarcamaTipId).HasColumnName("TB_SEYAHAT_HARCAMA_TIP_ID");
            entity.Property(e => e.TbSeyahatId).HasColumnName("TB_SEYAHAT_ID");
            entity.Property(e => e.TbVardiyaId).HasColumnName("TB_VARDIYA_ID");
            entity.Property(e => e.VardiyaIslemi).HasColumnName("VARDIYA_ISLEMI");
        });

        modelBuilder.Entity<TbKod>(entity =>
        {
            entity.HasKey(e => e.TbKodId).HasName("TB_KOD_pk");

            entity.ToTable("TB_KOD");

            entity.Property(e => e.TbKodId).HasColumnName("TB_KOD_ID");
            entity.Property(e => e.Deger)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEGER");
            entity.Property(e => e.Kod).HasColumnName("KOD");
            entity.Property(e => e.OzelKod1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD_1");
            entity.Property(e => e.OzelKod2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD_2");
            entity.Property(e => e.OzelKod3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD_3");
            entity.Property(e => e.Userindex).HasColumnName("USERINDEX");
        });

        modelBuilder.Entity<TbKodtip>(entity =>
        {
            entity.HasKey(e => e.TbKodtipId).HasName("TB_KODTIP_pk");

            entity.ToTable("TB_KODTIP");

            entity.Property(e => e.TbKodtipId).HasColumnName("TB_KODTIP_ID");
            entity.Property(e => e.Kod).HasColumnName("KOD");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TANIM");
        });

        modelBuilder.Entity<TbKullanici>(entity =>
        {
            entity.HasKey(e => e.TbKullaniciId).HasName("PK__TB_KULLANICI__15A53433");

            entity.ToTable("TB_KULLANICI");

            entity.Property(e => e.TbKullaniciId).HasColumnName("TB_KULLANICI_ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Analiz).HasColumnName("ANALIZ");
            entity.Property(e => e.Bakim).HasColumnName("BAKIM");
            entity.Property(e => e.Banka).HasColumnName("BANKA");
            entity.Property(e => e.Cari).HasColumnName("CARI");
            entity.Property(e => e.DefaultModul)
                .HasComment("  0-SATIS\r\n  1-DOMAIN\r\n  2-CARI\r\n  3-GOREV\r\n  4-STOK\r\n  5-FATURA\r\n  6-BANKA\r\n  7-KASA\r\n  8-ANALIZ\r\n  9-BAKIM\r\n  10-LISANS\r\n  11-HOSTING")
                .HasColumnName("DEFAULT_MODUL");
            entity.Property(e => e.Domain).HasColumnName("DOMAIN");
            entity.Property(e => e.EkPrimOran).HasColumnName("EK_PRIM_ORAN");
            entity.Property(e => e.FaaliyetGiderleri).HasColumnName("FAALIYET_GIDERLERI");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.Gorev).HasColumnName("GOREV");
            entity.Property(e => e.HedefSatis).HasColumnName("HEDEF_SATIS");
            entity.Property(e => e.Kasa).HasColumnName("KASA");
            entity.Property(e => e.KesintiOran)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KESINTI_ORAN");
            entity.Property(e => e.KodYonetim).HasColumnName("KOD_YONETIM");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");
            entity.Property(e => e.KullaniciIsim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ISIM");
            entity.Property(e => e.KullaniciSabitMaas)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KULLANICI_SABIT_MAAS");
            entity.Property(e => e.KullaniciTamMaas).HasColumnName("KULLANICI_TAM_MAAS");
            entity.Property(e => e.Lisans).HasColumnName("LISANS");
            entity.Property(e => e.ModulKullanici).HasColumnName("MODUL_KULLANICI");
            entity.Property(e => e.PersonelTakip).HasColumnName("PERSONEL_TAKIP");
            entity.Property(e => e.Satis).HasColumnName("SATIS");
            entity.Property(e => e.SatisTemsilcisi).HasColumnName("SATIS_TEMSILCISI");
            entity.Property(e => e.Seyahat).HasColumnName("SEYAHAT");
            entity.Property(e => e.Sifre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIFRE");
            entity.Property(e => e.SistemYoneticisi).HasColumnName("SISTEM_YONETICISI");
            entity.Property(e => e.Stok).HasColumnName("STOK");
            entity.Property(e => e.TbCrmUserId).HasColumnName("TB_CRM_USER_ID");
        });

        modelBuilder.Entity<TbKullaniciMaasHrk>(entity =>
        {
            entity.HasKey(e => e.TbKullaniciMaasHrkId).HasName("PK__TB_KULLA__6B1BC259405A880E");

            entity.ToTable("TB_KULLANICI_MAAS_HRK");

            entity.Property(e => e.TbKullaniciMaasHrkId).HasColumnName("TB_KULLANICI_MAAS_HRK_ID");
            entity.Property(e => e.BaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIH");
            entity.Property(e => e.BitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIH");
            entity.Property(e => e.EkPrimOran)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EK_PRIM_ORAN");
            entity.Property(e => e.HedefSatis)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HEDEF_SATIS");
            entity.Property(e => e.KesintiOran)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KESINTI_ORAN");
            entity.Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");
            entity.Property(e => e.KullaniciSabitMaas)
                .HasComment("0")
                .HasColumnName("KULLANICI_SABIT_MAAS");
            entity.Property(e => e.KullaniciTamMaas)
                .HasDefaultValueSql("((0))")
                .HasColumnName("KULLANICI_TAM_MAAS");
            entity.Property(e => e.MaasHesapTip)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MAAS_HESAP_TIP");
        });

        modelBuilder.Entity<TbKur>(entity =>
        {
            entity.ToTable("TB_KUR", tb =>
            {
                tb.HasTrigger("TRG_KUR_DEGISTIR");
                tb.HasTrigger("TRG_KUR_EKLE");
            });

            entity.Property(e => e.TbKurId).HasColumnName("TB_KUR_ID");
            entity.Property(e => e.AlisKur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ALIS_KUR");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.SatisKur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_KUR");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
        });

        modelBuilder.Entity<TbLisan>(entity =>
        {
            entity.HasKey(e => e.TbLisansId).HasName("PK__TB_LISANS__13BCEBC1");

            entity.ToTable("TB_LISANS");

            entity.Property(e => e.TbLisansId).HasColumnName("TB_LISANS_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.FirmaKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMA_KOD");
            entity.Property(e => e.FirmaUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIRMA_UNVAN");
            entity.Property(e => e.HaspBaglantiSayisi).HasColumnName("HASP_BAGLANTI_SAYISI");
            entity.Property(e => e.HaspSeriNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("HASP_SERI_NO");
            entity.Property(e => e.HaspTip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HASP_TIP");
            entity.Property(e => e.KurulumTarih)
                .HasColumnType("datetime")
                .HasColumnName("KURULUM_TARIH");
            entity.Property(e => e.LisansAtsAracSayisi).HasColumnName("LISANS_ATS_ARAC_SAYISI");
            entity.Property(e => e.LisansBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("LISANS_BITIS_TARIH");
            entity.Property(e => e.LisansCalisagiGunSayisi).HasColumnName("LISANS_CALISAGI_GUN_SAYISI");
            entity.Property(e => e.LisansKullaniciSayisi).HasColumnName("LISANS_KULLANICI_SAYISI");
            entity.Property(e => e.LisansModuller)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LISANS_MODULLER");
            entity.Property(e => e.LisansOmegaFirmaSayisi).HasColumnName("LISANS_OMEGA_FIRMA_SAYISI");
            entity.Property(e => e.LisansPbtplusFirmaSayisi).HasColumnName("LISANS_PBTPLUS_FIRMA_SAYISI");
            entity.Property(e => e.LisansPbtproFirmaSayisi).HasColumnName("LISANS_PBTPRO_FIRMA_SAYISI");
            entity.Property(e => e.LisansSonGirisTarih)
                .HasColumnType("datetime")
                .HasColumnName("LISANS_SON_GIRIS_TARIH");
            entity.Property(e => e.LisansUyariVerme).HasColumnName("LISANS_UYARI_VERME");
            entity.Property(e => e.Tanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TANIM");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbProgramId).HasColumnName("TB_PROGRAM_ID");
        });

        modelBuilder.Entity<TbLisansProgramModul>(entity =>
        {
            entity.HasKey(e => e.TbLisansProgramModul1).HasName("PK__TB_LISAN__9BC99545278EDA44");

            entity.ToTable("TB_LISANS_PROGRAM_MODUL");

            entity.Property(e => e.TbLisansProgramModul1).HasColumnName("TB_LISANS_PROGRAM_MODUL");
            entity.Property(e => e.LpmModulAdi)
                .HasMaxLength(120)
                .HasColumnName("LPM_MODUL_ADI");
            entity.Property(e => e.LpmModulDegeri)
                .HasMaxLength(5)
                .HasColumnName("LPM_MODUL_DEGERI");
            entity.Property(e => e.LpmTbLisansId).HasColumnName("LPM_TB_LISANS_ID");
            entity.Property(e => e.LpmTbProgramId).HasColumnName("LPM_TB_PROGRAM_ID");
            entity.Property(e => e.LpmTbProgramModulId).HasColumnName("LPM_TB_PROGRAM_MODUL_ID");
        });

        modelBuilder.Entity<TbLog>(entity =>
        {
            entity.HasKey(e => e.TbLogsId);

            entity.ToTable("TB_LOGS");

            entity.Property(e => e.TbLogsId).HasColumnName("TB_LOGS_ID");
            entity.Property(e => e.Islem)
                .HasColumnType("text")
                .HasColumnName("ISLEM");
            entity.Property(e => e.IslemId).HasColumnName("ISLEM_ID");
            entity.Property(e => e.IslemYeri)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ISLEM_YERI");
            entity.Property(e => e.Kisi).HasColumnName("KISI");
            entity.Property(e => e.Zaman)
                .HasColumnType("text")
                .HasColumnName("ZAMAN");
        });

        modelBuilder.Entity<TbMail>(entity =>
        {
            entity.HasKey(e => e.TbMailId).HasName("PK__TB_MAIL__2E70E1FD");

            entity.ToTable("TB_MAIL");

            entity.Property(e => e.TbMailId).HasColumnName("TB_MAIL_ID");
            entity.Property(e => e.MailAciklama)
                .IsUnicode(false)
                .HasColumnName("MAIL_ACIKLAMA");
            entity.Property(e => e.MailKonu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MAIL_KONU");
            entity.Property(e => e.MailTip).HasColumnName("MAIL_TIP");
        });

        modelBuilder.Entity<TbMesaj>(entity =>
        {
            entity.HasKey(e => e.TbMesajId).HasName("PK__TB_MESAJ__71D1E811");

            entity.ToTable("TB_MESAJ");

            entity.Property(e => e.TbMesajId).HasColumnName("TB_MESAJ_ID");
            entity.Property(e => e.Aciklama)
                .HasColumnType("text")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Baslik)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.DomainId).HasColumnName("DOMAIN_ID");
            entity.Property(e => e.GorusmeNedeni)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GORUSME_NEDENI");
            entity.Property(e => e.GorusulenKisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GORUSULEN_KISI");
            entity.Property(e => e.Grup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUP");
            entity.Property(e => e.Hatirlat).HasColumnName("HATIRLAT");
            entity.Property(e => e.HatirlatmaSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('00:00:00')")
                .HasColumnName("HATIRLATMA_SAAT");
            entity.Property(e => e.HatirlatmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("HATIRLATMA_TARIH");
            entity.Property(e => e.IlgiliKisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILGILI_KISI");
            entity.Property(e => e.IlgiliUrun)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILGILI_URUN");
            entity.Property(e => e.Kisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KISI");
            entity.Property(e => e.MusteriId).HasColumnName("MUSTERI_ID");
            entity.Property(e => e.Renk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('16777215')")
                .HasColumnName("RENK");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('00:00:00')")
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Yeni).HasColumnName("YENI");
        });

        modelBuilder.Entity<TbNumarator>(entity =>
        {
            entity.HasKey(e => e.TbNumaratorId).HasName("PK__TB_NUMARATOR__3B40CD36");

            entity.ToTable("TB_NUMARATOR", tb => tb.HasComment("SERİ NUMARASI İLE TAKİP EDİLEN TÜM ALANLARIN TAKİP EDİLDİĞİ TABLODUR. İSTASYON BAZINDA SERİ NUMARALARINI SAKLAR. YENİ İSTASYON OLUŞTURULDUĞUNDA VARSAYILAN DEĞERLER İLE OLUŞTURULUR. KULLANICI YENİ FİŞ AÇTIĞINDA NO ALANINDAKİ DEĞERİN  1 FAZLASI DEĞERİNİ ALIR. KAYDEDERKEN DE BU DEĞER FARKLI BİR KULLANICI TARAFINDAN KULLANILMIŞ MI DİYE KONTROL EDİLEREK. KULLANICIDAKİ NO BU TABLOYA YAZILIR. DOLAYISIYLA KULLANICININ YAZDIĞI NO SON SERİ NO OLMUŞ OLUR."));

            entity.Property(e => e.TbNumaratorId).HasColumnName("TB_NUMARATOR_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BelgeTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BELGE_TIP");
            entity.Property(e => e.Numara).HasColumnName("NUMARA");
            entity.Property(e => e.NumaratorTanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUMARATOR_TANIM");
            entity.Property(e => e.Seri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasComment("TAHSİL FİŞİ İÇİN THL GİBİ ÖN EK DEĞERİDİR. FATURA GİBİ BELGELERDE DE SERİ YERİNE KULLANILIR")
                .HasColumnName("SERI");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
        });

        modelBuilder.Entity<TbOdemeDiger>(entity =>
        {
            entity.HasKey(e => e.TbDigerId);

            entity.ToTable("TB_ODEME_DIGER");

            entity.Property(e => e.TbDigerId).HasColumnName("TB_DIGER_ID");
            entity.Property(e => e.OdemeTipi)
                .HasMaxLength(50)
                .HasColumnName("ODEME_TIPI");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbDomainId).HasColumnName("TB_DOMAIN_ID");
            entity.Property(e => e.TbHostingId).HasColumnName("TB_HOSTING_ID");
            entity.Property(e => e.TbSslId).HasColumnName("TB_SSL_ID");
            entity.Property(e => e.TbSunucuId).HasColumnName("TB_SUNUCU_ID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<TbPaket>(entity =>
        {
            entity.HasKey(e => e.TbPaketId).HasName("PK__TB_PAKET__30592A6F");

            entity.ToTable("TB_PAKET", tb => tb.HasTrigger("TRG_PAKET_SIL"));

            entity.Property(e => e.TbPaketId).HasColumnName("TB_PAKET_ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BantGenislik)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BANT_GENISLIK");
            entity.Property(e => e.DiskAlan)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DISK_ALAN");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.HostingTip)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("HOSTING_TIP");
            entity.Property(e => e.IpAdres)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("IP_ADRES");
            entity.Property(e => e.PaketTanim)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PAKET_TANIM");
            entity.Property(e => e.PaketTip)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PAKET_TIP");
            entity.Property(e => e.SslSertifika).HasColumnName("SSL_SERTIFIKA");
            entity.Property(e => e.Sure).HasColumnName("SURE");
            entity.Property(e => e.SureTip).HasColumnName("SURE_TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<TbParabirimi>(entity =>
        {
            entity.ToTable("TB_PARABIRIMI");

            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.Kisaltma)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KISALTMA");
            entity.Property(e => e.ParabirimiKod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARABIRIMI_KOD");
            entity.Property(e => e.ParabirimiTanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PARABIRIMI_TANIM");
            entity.Property(e => e.SonAlisKur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SON_ALIS_KUR");
            entity.Property(e => e.SonGuncellemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("SON_GUNCELLEME_TARIH");
            entity.Property(e => e.SonSatisKur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SON_SATIS_KUR");
        });

        modelBuilder.Entity<TbPersonelIzin>(entity =>
        {
            entity.HasKey(e => e.TbIzinId);

            entity.ToTable("TB_PERSONEL_IZIN");

            entity.Property(e => e.TbIzinId).HasColumnName("TB_IZIN_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(350)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BaslamaTarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA_TARIH");
            entity.Property(e => e.BitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIH");
            entity.Property(e => e.IzinKimdenAlindi)
                .HasMaxLength(50)
                .HasColumnName("IZIN_KIMDEN_ALINDI");
            entity.Property(e => e.IzinNedenKodId).HasColumnName("IZIN_NEDEN_KOD_ID");
            entity.Property(e => e.PersonelId).HasColumnName("PERSONEL_ID");
            entity.Property(e => e.Sure).HasColumnName("SURE");
            entity.Property(e => e.YillikIzin).HasColumnName("YILLIK_IZIN");
        });

        modelBuilder.Entity<TbPersonelIzinYil>(entity =>
        {
            entity.ToTable("TB_PERSONEL_IZIN_YIL");

            entity.Property(e => e.TbPersonelIzinYilId).HasColumnName("TB_PERSONEL_IZIN_YIL_ID");
            entity.Property(e => e.CariId).HasColumnName("CARI_ID");
            entity.Property(e => e.Fark).HasColumnName("FARK");
        });

        modelBuilder.Entity<TbPo>(entity =>
        {
            entity.HasKey(e => e.TbPosId);

            entity.ToTable("TB_POS", tb => tb.HasTrigger("TRG_POS_EKLE_DEGISTIR"));

            entity.Property(e => e.TbPosId).HasColumnName("TB_POS_ID");
            entity.Property(e => e.Aktif)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("AKTIF");
            entity.Property(e => e.Bakiye)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BAKIYE");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.Komisyon)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KOMISYON");
            entity.Property(e => e.MuhasebeKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MUHASEBE_KOD");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.PosKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POS_KOD");
            entity.Property(e => e.PosTanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POS_TANIM");
            entity.Property(e => e.TbBankaId).HasColumnName("TB_BANKA_ID");
            entity.Property(e => e.TbGrupId).HasColumnName("TB_GRUP_ID");
            entity.Property(e => e.Vade).HasColumnName("VADE");
            entity.Property(e => e.VadesiGelen)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("VADESI_GELEN");
        });

        modelBuilder.Entity<TbPoshrk>(entity =>
        {
            entity.ToTable("TB_POSHRK", tb =>
            {
                tb.HasTrigger("TRG_POSHRK_EKLE_DEGISTIR");
                tb.HasTrigger("TRG_POSHRK_SIL");
            });

            entity.Property(e => e.TbPoshrkId).HasColumnName("TB_POSHRK_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BatchNo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("BATCH_NO");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.FisSiraNo).HasColumnName("FIS_SIRA_NO");
            entity.Property(e => e.HareketAciklama)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("HAREKET_ACIKLAMA");
            entity.Property(e => e.Komisyon)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KOMISYON");
            entity.Property(e => e.KomisyonMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KOMISYON_MIKTAR");
            entity.Property(e => e.KredikartNo).HasColumnName("KREDIKART_NO");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.ReferansNo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("REFERANS_NO");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SAAT");
            entity.Property(e => e.TahsilEdildi).HasColumnName("TAHSIL_EDILDI");
            entity.Property(e => e.TahsilTarih)
                .HasColumnType("datetime")
                .HasColumnName("TAHSIL_TARIH");
            entity.Property(e => e.TahsilTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TAHSIL_TUTAR");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbBankaId).HasColumnName("TB_BANKA_ID");
            entity.Property(e => e.TbBankahrkId).HasColumnName("TB_BANKAHRK_ID");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbCarifisId).HasColumnName("TB_CARIFIS_ID");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbMarketsatisId).HasColumnName("TB_MARKETSATIS_ID");
            entity.Property(e => e.TbPompaId).HasColumnName("TB_POMPA_ID");
            entity.Property(e => e.TbPosId).HasColumnName("TB_POS_ID");
            entity.Property(e => e.TbStokId).HasColumnName("TB_STOK_ID");
            entity.Property(e => e.TbVardiyaId).HasColumnName("TB_VARDIYA_ID");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Vade).HasColumnName("VADE");
            entity.Property(e => e.VardiyaIslemi).HasColumnName("VARDIYA_ISLEMI");
        });

        modelBuilder.Entity<TbProgram>(entity =>
        {
            entity.HasKey(e => e.TbProgramId).HasName("PK__TB_PROGRAM__11D4A34F");

            entity.ToTable("TB_PROGRAM");

            entity.Property(e => e.TbProgramId).HasColumnName("TB_PROGRAM_ID");
            entity.Property(e => e.ConnectionString)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CONNECTION_STRING");
            entity.Property(e => e.LisansDosyaYolu)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LISANS_DOSYA_YOLU");
            entity.Property(e => e.Tanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TANIM");
            entity.Property(e => e.VeritabaniAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERITABANI_ADI");
            entity.Property(e => e.VeritabaniDataYol)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VERITABANI_DATA_YOL");
            entity.Property(e => e.VeritabaniLogYol)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VERITABANI_LOG_YOL");
            entity.Property(e => e.VeritabaniYedekAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERITABANI_YEDEK_ADI");
        });

        modelBuilder.Entity<TbProgramModul>(entity =>
        {
            entity.ToTable("TB_PROGRAM_MODUL");

            entity.Property(e => e.TbProgramModulId).HasColumnName("TB_PROGRAM_MODUL_ID");
            entity.Property(e => e.PmModulAdi)
                .HasMaxLength(50)
                .HasColumnName("PM_MODUL_ADI");
            entity.Property(e => e.PmModulDegeri)
                .HasMaxLength(5)
                .HasColumnName("PM_MODUL_DEGERI");
            entity.Property(e => e.TbProgramId).HasColumnName("TB_PROGRAM_ID");
        });

        modelBuilder.Entity<TbServisOncelik>(entity =>
        {
            entity.ToTable("TB_SERVIS_ONCELIK");

            entity.Property(e => e.TbServisOncelikId).HasColumnName("TB_SERVIS_ONCELIK_ID");
            entity.Property(e => e.SocAktif).HasColumnName("SOC_AKTIF");
            entity.Property(e => e.SocCozumSureDk).HasColumnName("SOC_COZUM_SURE_DK");
            entity.Property(e => e.SocCozumSureGun).HasColumnName("SOC_COZUM_SURE_GUN");
            entity.Property(e => e.SocCozumSureSaat).HasColumnName("SOC_COZUM_SURE_SAAT");
            entity.Property(e => e.SocDegistirenId).HasColumnName("SOC_DEGISTIREN_ID");
            entity.Property(e => e.SocDegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("SOC_DEGISTIRME_TARIH");
            entity.Property(e => e.SocGecikmeIkonIndex).HasColumnName("SOC_GECIKME_IKON_INDEX");
            entity.Property(e => e.SocGecikmeRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOC_GECIKME_RENK");
            entity.Property(e => e.SocGecikmeSureDakika).HasColumnName("SOC_GECIKME_SURE_DAKIKA");
            entity.Property(e => e.SocGecikmeYaziRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOC_GECIKME_YAZI_RENK");
            entity.Property(e => e.SocIkonIndexId).HasColumnName("SOC_IKON_INDEX_ID");
            entity.Property(e => e.SocKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOC_KOD");
            entity.Property(e => e.SocKritikIkonIndex).HasColumnName("SOC_KRITIK_IKON_INDEX");
            entity.Property(e => e.SocKritikRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOC_KRITIK_RENK");
            entity.Property(e => e.SocKritikSureDakika).HasColumnName("SOC_KRITIK_SURE_DAKIKA");
            entity.Property(e => e.SocKritikYaziRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOC_KRITIK_YAZI_RENK");
            entity.Property(e => e.SocOlusturanId).HasColumnName("SOC_OLUSTURAN_ID");
            entity.Property(e => e.SocOlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("SOC_OLUSTURMA_TARIH");
            entity.Property(e => e.SocTanim)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SOC_TANIM");
            entity.Property(e => e.SocVarsayilan).HasColumnName("SOC_VARSAYILAN");
        });

        modelBuilder.Entity<TbSeyahat>(entity =>
        {
            entity.ToTable("TB_SEYAHAT", tb => tb.HasTrigger("TB_SEYAHAT_SIL"));

            entity.Property(e => e.TbSeyahatId).HasColumnName("TB_SEYAHAT_ID");
            entity.Property(e => e.TbFirmaId).HasColumnName("TB_FIRMA_ID");
            entity.Property(e => e.TbIlId).HasColumnName("TB_IL_ID");
            entity.Property(e => e.TbSeyahatAciklama)
                .HasMaxLength(255)
                .HasColumnName("TB_SEYAHAT_ACIKLAMA");
            entity.Property(e => e.TbSeyahatDonusTarih)
                .HasColumnType("datetime")
                .HasColumnName("TB_SEYAHAT_DONUS_TARIH");
            entity.Property(e => e.TbSeyahatGidisTarih)
                .HasColumnType("datetime")
                .HasColumnName("TB_SEYAHAT_GIDIS_TARIH");
            entity.Property(e => e.TbSeyahatSure)
                .HasComputedColumnSql("(datediff(day,[TB_SEYAHAT_GIDIS_TARIH],[TB_SEYAHAT_DONUS_TARIH])+(1))", false)
                .HasColumnName("TB_SEYAHAT_SURE");
            entity.Property(e => e.TbSeyahatTanimi)
                .HasMaxLength(100)
                .HasColumnName("TB_SEYAHAT_TANIMI");
            entity.Property(e => e.TbSeyahatTipId)
                .HasComment("TB_KOD TABLOSUNDAN KOD=117 OLANLAR")
                .HasColumnName("TB_SEYAHAT_TIP_ID");
            entity.Property(e => e.TbSeyahatToplamMasraf)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TB_SEYAHAT_TOPLAM_MASRAF");
            entity.Property(e => e.TbSeyahatUlasimTurId).HasColumnName("TB_SEYAHAT_ULASIM_TUR_ID");
        });

        modelBuilder.Entity<TbSeyahatPersonel>(entity =>
        {
            entity.HasKey(e => e.TbSeyahatPersonelId).HasName("PK__TB_SEYAH__D063C4FB35DCF99B");

            entity.ToTable("TB_SEYAHAT_PERSONEL");

            entity.Property(e => e.TbSeyahatPersonelId).HasColumnName("TB_SEYAHAT_PERSONEL_ID");
            entity.Property(e => e.SprAciklama)
                .HasMaxLength(4000)
                .HasColumnName("SPR_ACIKLAMA");
            entity.Property(e => e.SprKullaniciId).HasColumnName("SPR_KULLANICI_ID");
            entity.Property(e => e.SprSeyahatId).HasColumnName("SPR_SEYAHAT_ID");
        });

        modelBuilder.Entity<TbSorun>(entity =>
        {
            entity.HasKey(e => e.TbSorunId).HasName("PK__TB_SORUN__0FEC5ADD");

            entity.ToTable("TB_SORUN");

            entity.Property(e => e.TbSorunId).HasColumnName("TB_SORUN_ID");
            entity.Property(e => e.Baslik)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Cozum)
                .HasColumnType("ntext")
                .HasColumnName("COZUM");
            entity.Property(e => e.Grup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRUP");
            entity.Property(e => e.Sorun)
                .HasColumnType("ntext")
                .HasColumnName("SORUN");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<TbSsl>(entity =>
        {
            entity.HasKey(e => e.TbSslId).HasName("PK__TB_SSL__436BFEE3");

            entity.ToTable("TB_SSL", tb => tb.HasTrigger("TRG_SSLHRK_EKLE"));

            entity.Property(e => e.TbSslId).HasColumnName("TB_SSL_ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Banka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANKA");
            entity.Property(e => e.DuzenlemeSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DUZENLEME_SAAT");
            entity.Property(e => e.DuzenlemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DUZENLEME_TARIH");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.Faturao)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FATURAO");
            entity.Property(e => e.GuncelAciklama)
                .HasMaxLength(50)
                .HasColumnName("GUNCEL_ACIKLAMA");
            entity.Property(e => e.GuncelTutar)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("GUNCEL_TUTAR");
            entity.Property(e => e.Hatirlat).HasColumnName("HATIRLAT");
            entity.Property(e => e.Indirimfiyat)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("INDIRIMFIYAT");
            entity.Property(e => e.Kdvtutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("KDVTUTAR");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.OdemeYapildi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ODEME_YAPILDI");
            entity.Property(e => e.SslBantGenislik)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SSL_BANT_GENISLIK");
            entity.Property(e => e.SslBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("SSL_BASLANGIC_TARIH");
            entity.Property(e => e.SslBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("SSL_BITIS_TARIH");
            entity.Property(e => e.SslDiskAlan)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SSL_DISK_ALAN");
            entity.Property(e => e.SslSure).HasColumnName("SSL_SURE");
            entity.Property(e => e.SslYil).HasColumnName("SSL_YIL");
            entity.Property(e => e.TaksitSayisi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAKSIT_SAYISI");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbDomainId).HasColumnName("TB_DOMAIN_ID");
            entity.Property(e => e.TbPaketId).HasColumnName("TB_PAKET_ID");
            entity.Property(e => e.Toplam)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TOPLAM");
            entity.Property(e => e.Ucretsiz)
                .HasDefaultValueSql("((0))")
                .HasColumnName("UCRETSIZ");
        });

        modelBuilder.Entity<TbSslhrk>(entity =>
        {
            entity.HasKey(e => e.TbSslhrkId).HasName("PK__TB_SSLHRK__4830B400");

            entity.ToTable("TB_SSLHRK");

            entity.Property(e => e.TbSslhrkId).HasColumnName("TB_SSLHRK_ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BantGenisligiYenileme)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BANT_GENISLIGI_YENILEME");
            entity.Property(e => e.DiskAlanYenileme)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DISK_ALAN_YENILEME");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.FaturaId).HasColumnName("FATURA_ID");
            entity.Property(e => e.Hatirlat).HasColumnName("HATIRLAT");
            entity.Property(e => e.Iptal)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IPTAL");
            entity.Property(e => e.IslemTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ISLEM_TIP");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.OdemeYapildi).HasColumnName("ODEME_YAPILDI");
            entity.Property(e => e.PaketDegisiklik)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PAKET_DEGISIKLIK");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SAAT");
            entity.Property(e => e.SslBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("SSL_BASLANGIC_TARIH");
            entity.Property(e => e.SslBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("SSL_BITIS_TARIH");
            entity.Property(e => e.SslSure).HasColumnName("SSL_SURE");
            entity.Property(e => e.SslYil).HasColumnName("SSL_YIL");
            entity.Property(e => e.SureYenileme)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SURE_YENILEME");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbPaketId).HasColumnName("TB_PAKET_ID");
            entity.Property(e => e.TbSslId).HasColumnName("TB_SSL_ID");
        });

        modelBuilder.Entity<TbStok>(entity =>
        {
            entity.ToTable("TB_STOK", tb =>
            {
                tb.HasTrigger("TRG_STOK_DEGISTIR");
                tb.HasTrigger("TRG_STOK_SIL");
            });

            entity.Property(e => e.TbStokId).HasColumnName("TB_STOK_ID");
            entity.Property(e => e.Aktif)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("1 = AKTİF, 0 = PASİF")
                .HasColumnName("AKTIF");
            entity.Property(e => e.AlisFiyat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ALIS_FIYAT");
            entity.Property(e => e.AlisIndirimOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ALIS_INDIRIM_ORAN");
            entity.Property(e => e.AlisIndirimTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ALIS_INDIRIM_TUTAR");
            entity.Property(e => e.AlisKdvDahil).HasColumnName("ALIS_KDV_DAHIL");
            entity.Property(e => e.AlisKdvOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ALIS_KDV_ORAN");
            entity.Property(e => e.AlisMuhasebeKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALIS_MUHASEBE_KOD");
            entity.Property(e => e.AlisOtvOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ALIS_OTV_ORAN");
            entity.Property(e => e.AlisOtvTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ALIS_OTV_TUTAR");
            entity.Property(e => e.AlisParabirimId).HasColumnName("ALIS_PARABIRIM_ID");
            entity.Property(e => e.AzamiStokMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AZAMI_STOK_MIKTAR");
            entity.Property(e => e.Bolum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOLUM");
            entity.Property(e => e.CikanMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CIKAN_MIKTAR");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.GirenMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("GIREN_MIKTAR");
            entity.Property(e => e.GrupKodId).HasColumnName("GRUP_KOD_ID");
            entity.Property(e => e.KesafetOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KESAFET_ORAN");
            entity.Property(e => e.KgStokMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KG_STOK_MIKTAR");
            entity.Property(e => e.KritikStokMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KRITIK_STOK_MIKTAR");
            entity.Property(e => e.Notlar)
                .HasColumnType("text")
                .HasColumnName("NOTLAR");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.OtomasyonKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTOMASYON_KOD");
            entity.Property(e => e.OzelKod1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD1");
            entity.Property(e => e.OzelKod2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD2");
            entity.Property(e => e.OzelKod3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD3");
            entity.Property(e => e.OzelKod4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD4");
            entity.Property(e => e.RafNo).HasColumnName("RAF_NO");
            entity.Property(e => e.SatisFiyat1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_FIYAT1");
            entity.Property(e => e.SatisFiyat2)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_FIYAT2");
            entity.Property(e => e.SatisFiyat3)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_FIYAT3");
            entity.Property(e => e.SatisIndirimOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_INDIRIM_ORAN");
            entity.Property(e => e.SatisIndirimTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_INDIRIM_TUTAR");
            entity.Property(e => e.SatisKdvDahil1).HasColumnName("SATIS_KDV_DAHIL1");
            entity.Property(e => e.SatisKdvDahil2).HasColumnName("SATIS_KDV_DAHIL2");
            entity.Property(e => e.SatisKdvDahil3).HasColumnName("SATIS_KDV_DAHIL3");
            entity.Property(e => e.SatisKdvOran1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_KDV_ORAN1");
            entity.Property(e => e.SatisKdvOran2)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_KDV_ORAN2");
            entity.Property(e => e.SatisKdvOran3)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_KDV_ORAN3");
            entity.Property(e => e.SatisMuhasebeKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SATIS_MUHASEBE_KOD");
            entity.Property(e => e.SatisOtvOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_OTV_ORAN");
            entity.Property(e => e.SatisOtvTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_OTV_TUTAR");
            entity.Property(e => e.SatisParabirim1Id).HasColumnName("SATIS_PARABIRIM1_ID");
            entity.Property(e => e.SatisParabirim2Id).HasColumnName("SATIS_PARABIRIM2_ID");
            entity.Property(e => e.SatisParabirim3Id).HasColumnName("SATIS_PARABIRIM3_ID");
            entity.Property(e => e.SonSayim)
                .HasColumnType("datetime")
                .HasColumnName("SON_SAYIM");
            entity.Property(e => e.StokKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STOK_KOD");
            entity.Property(e => e.StokMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("STOK_MIKTAR");
            entity.Property(e => e.StokTanim)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("STOK_TANIM");
            entity.Property(e => e.StokTur)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("M = MALZEME, H = HİZMET, S = SARF MALZEME")
                .HasColumnName("STOK_TUR");
            entity.Property(e => e.TbBirimsetId).HasColumnName("TB_BIRIMSET_ID");
            entity.Property(e => e.TbCariId)
                .HasComment("TEDARİKÇİ")
                .HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbDepoId).HasColumnName("TB_DEPO_ID");
            entity.Property(e => e.TbGelirgiderId).HasColumnName("TB_GELIRGIDER_ID");
            entity.Property(e => e.Tip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('E')")
                .IsFixedLength()
                .HasComment("E = EMTIA, Y = YAKIT, H = HİZMET, S = SARF MALZEME")
                .HasColumnName("TIP");
            entity.Property(e => e.ToplamSatisTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TOPLAM_SATIS_TUTAR");
            entity.Property(e => e.ZayiatOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ZAYIAT_ORAN");
        });

        modelBuilder.Entity<TbStokfi>(entity =>
        {
            entity.HasKey(e => e.TbStokfisId).HasName("PK_TB_FATURA");

            entity.ToTable("TB_STOKFIS", tb =>
            {
                tb.HasTrigger("TRG_FATURA_EKLE");
                tb.HasTrigger("TRG_FATURA_SIL");
                tb.HasTrigger("TRG_STOKFIS_DEGISTIR");
                tb.HasTrigger("TRG_STOKFIS_EKLE_DEGISTIR");
            });

            entity.Property(e => e.TbStokfisId).HasColumnName("TB_STOKFIS_ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktarim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AKTARIM");
            entity.Property(e => e.AraToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ARA_TOPLAM");
            entity.Property(e => e.CarifaturaUnvan)
                .HasMaxLength(100)
                .HasColumnName("CARIFATURA_UNVAN");
            entity.Property(e => e.CarifaturaUnvanId).HasColumnName("CARIFATURA_UNVAN_ID");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.DovizKur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DOVIZ_KUR");
            entity.Property(e => e.FaturaAciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FATURA_ACIKLAMA");
            entity.Property(e => e.FaturaBelgeNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FATURA_BELGE_NO");
            entity.Property(e => e.FaturaIptalFisId).HasColumnName("FATURA_IPTAL_FIS_ID");
            entity.Property(e => e.FaturaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO");
            entity.Property(e => e.FaturaSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FATURA_SAAT");
            entity.Property(e => e.FaturaTarih)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIH");
            entity.Property(e => e.FirmaAdi)
                .HasMaxLength(150)
                .HasColumnName("FIRMA_ADI");
            entity.Property(e => e.GenelToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("GENEL_TOPLAM");
            entity.Property(e => e.Hizmet)
                .HasMaxLength(150)
                .HasColumnName("HIZMET");
            entity.Property(e => e.IndirimOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("INDIRIM_ORAN");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.KapaliFatura).HasColumnName("KAPALI_FATURA");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KUR");
            entity.Property(e => e.Muhasebelesmis).HasColumnName("MUHASEBELESMIS");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("NAKİT\r\nÇEK\r\nSENET\r\nHAVALE\r\nKREDİ KARTI\r\n\r\nSADECE BİLGİ AMAÇLI!")
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTakipEt).HasColumnName("ODEME_TAKIP_ET");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeYapildi).HasColumnName("ODEME_YAPILDI");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.OzelKod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OZEL_KOD");
            entity.Property(e => e.Prosedur).HasColumnName("PROSEDUR");
            entity.Property(e => e.Rg)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasComment("1 = R\r\n0 = GR")
                .HasColumnName("RG");
            entity.Property(e => e.SatisPersonelId).HasColumnName("SATIS_PERSONEL_ID");
            entity.Property(e => e.SatisTarih)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_TARIH");
            entity.Property(e => e.SonOdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("SON_ODEME_TARIH");
            entity.Property(e => e.StokFisTip)
                .HasComment("  SFT_FATURA_ALIS         =  1;\r\n  SFT_FATURA_SATIS        =  2;\r\n  SFT_FATURA_SATIS_IADE   =  3;\r\n  SFT_FATURA_ALIS_IADE    =  4;\r\n\r\n  SFT_IRSALIYE_ALIS       = 11;\r\n  SFT_IRSALIYE_SATIS      = 12;\r\n  SFT_IRSALIYE_SATIS_IADE = 13;\r\n  SFT_IRSALIYE_ALIS_IADE  = 14;")
                .HasColumnName("STOK_FIS_TIP");
            entity.Property(e => e.StokfisTur)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STOKFIS_TUR");
            entity.Property(e => e.StokfisTurAciklama)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("STOKFIS_TUR_ACIKLAMA");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbCarifisId).HasColumnName("TB_CARIFIS_ID");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.TbVardiyaId).HasColumnName("TB_VARDIYA_ID");
            entity.Property(e => e.ToplamIndirim)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TOPLAM_INDIRIM");
            entity.Property(e => e.ToplamKdv)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TOPLAM_KDV");
            entity.Property(e => e.ToplamOtv)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TOPLAM_OTV");
            entity.Property(e => e.UygulananFiyat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((2))")
                .IsFixedLength()
                .HasComment("1. Mİ 2. Mİ 3. MÜ FİYATIN UGULANDIĞI FİLGİSİNİ İÇERİR")
                .HasColumnName("UYGULANAN_FIYAT");
            entity.Property(e => e.Yazdirma)
                .HasComment("YAZDIRMA SAYISI")
                .HasColumnName("YAZDIRMA");
            entity.Property(e => e.Yuvarlama)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("YUVARLAMA");
        });

        modelBuilder.Entity<TbStokfisdetay>(entity =>
        {
            entity.HasKey(e => e.TbStokfisdetayId).HasName("PK_TB_FATURADETAY");

            entity.ToTable("TB_STOKFISDETAY", tb =>
            {
                tb.HasTrigger("TRG_STOKFISDETAY_DEGISTIR");
                tb.HasTrigger("TRG_STOKFISDETAY_EKLE");
                tb.HasTrigger("TRG_STOKFISDETAY_SIL");
            });

            entity.Property(e => e.TbStokfisdetayId).HasColumnName("TB_STOKFISDETAY_ID");
            entity.Property(e => e.BirimFiyat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BIRIM_FIYAT");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.DovizBirimFiyat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DOVIZ_BIRIM_FIYAT");
            entity.Property(e => e.DovizId).HasColumnName("DOVIZ_ID");
            entity.Property(e => e.DovizTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DOVIZ_TUTAR");
            entity.Property(e => e.IndirimOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("INDIRIM_ORAN");
            entity.Property(e => e.IndirimTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("INDIRIM_TUTAR");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.KdvDh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('H')")
                .IsFixedLength()
                .HasComment("KDV DAHIL/HARİÇ DAHIL = D HARİÇ = H")
                .HasColumnName("KDV_DH");
            entity.Property(e => e.KdvOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KDV_ORAN");
            entity.Property(e => e.KdvTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KDV_TUTAR");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KUR");
            entity.Property(e => e.Miktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.OtvOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OTV_ORAN");
            entity.Property(e => e.OtvTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OTV_TUTAR");
            entity.Property(e => e.OzelKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD");
            entity.Property(e => e.SatirTip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("EMTİA\r\nYAKIT\r\nGELİR/GİDER")
                .HasColumnName("SATIR_TIP");
            entity.Property(e => e.SiraNo).HasColumnName("SIRA_NO");
            entity.Property(e => e.TbBirimId).HasColumnName("TB_BIRIM_ID");
            entity.Property(e => e.TbCarihrkId).HasColumnName("TB_CARIHRK_ID");
            entity.Property(e => e.TbGelirgiderId).HasColumnName("TB_GELIRGIDER_ID");
            entity.Property(e => e.TbStokId).HasColumnName("TB_STOK_ID");
            entity.Property(e => e.TbStokfisId).HasColumnName("TB_STOKFIS_ID");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.UygulananFiyat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .IsFixedLength()
                .HasColumnName("UYGULANAN_FIYAT");
        });

        modelBuilder.Entity<TbStokhrk>(entity =>
        {
            entity.ToTable("TB_STOKHRK", tb =>
            {
                tb.HasTrigger("TRG_STOKHRK_EKLE");
                tb.HasTrigger("TRG_STOKHRK_SIL");
            });

            entity.Property(e => e.TbStokhrkId).HasColumnName("TB_STOKHRK_ID");
            entity.Property(e => e.BirimFiyat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BIRIM_FIYAT");
            entity.Property(e => e.CariFisTip).HasColumnName("CARI_FIS_TIP");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.DovizBirimFiyat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DOVIZ_BIRIM_FIYAT");
            entity.Property(e => e.DovizTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DOVIZ_TUTAR");
            entity.Property(e => e.Faturalanmis).HasColumnName("FATURALANMIS");
            entity.Property(e => e.Gc)
                .HasComment(" 1 = GİRİŞ \r\n-1 = ÇIKIŞ")
                .HasColumnName("GC");
            entity.Property(e => e.HareketAciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HAREKET_ACIKLAMA");
            entity.Property(e => e.IndirimOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("INDIRIM_ORAN");
            entity.Property(e => e.IndirimTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("INDIRIM_TUTAR");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.Katik)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KATIK");
            entity.Property(e => e.KdvDh)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Hariç\r\nDahil")
                .HasColumnName("KDV_DH");
            entity.Property(e => e.KdvOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KDV_ORAN");
            entity.Property(e => e.KdvTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KDV_TUTAR");
            entity.Property(e => e.Kesafet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KESAFET");
            entity.Property(e => e.KgMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KG_MIKTAR");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KUR");
            entity.Property(e => e.Miktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.OtvOran)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OTV_ORAN");
            entity.Property(e => e.OtvTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("OTV_TUTAR");
            entity.Property(e => e.OzelKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OZEL_KOD");
            entity.Property(e => e.PersonelId).HasColumnName("PERSONEL_ID");
            entity.Property(e => e.Prosedur)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("PROSEDUR");
            entity.Property(e => e.StokFisTip).HasColumnName("STOK_FIS_TIP");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbBirimId).HasColumnName("TB_BIRIM_ID");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbCarifisId).HasColumnName("TB_CARIFIS_ID");
            entity.Property(e => e.TbCarihrkId).HasColumnName("TB_CARIHRK_ID");
            entity.Property(e => e.TbDepoId).HasColumnName("TB_DEPO_ID");
            entity.Property(e => e.TbDevirfisDetayId).HasColumnName("TB_DEVIRFIS_DETAY_ID");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbMarketsatisId).HasColumnName("TB_MARKETSATIS_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.TbSayacId).HasColumnName("TB_SAYAC_ID");
            entity.Property(e => e.TbStokId).HasColumnName("TB_STOK_ID");
            entity.Property(e => e.TbStokfisdetayId).HasColumnName("TB_STOKFISDETAY_ID");
            entity.Property(e => e.TbVardiyaId).HasColumnName("TB_VARDIYA_ID");
            entity.Property(e => e.TbVrdsayacId).HasColumnName("TB_VRDSAYAC_ID");
            entity.Property(e => e.Tutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.UygulananFiyat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UYGULANAN_FIYAT");
            entity.Property(e => e.Yakit).HasColumnName("YAKIT");
        });

        modelBuilder.Entity<TbSunucu>(entity =>
        {
            entity.HasKey(e => e.TbSunucuId).HasName("PK__TB_SUNUCU__3335971A");

            entity.ToTable("TB_SUNUCU", tb =>
            {
                tb.HasTrigger("TRG_SUNUCU_EKLE");
                tb.HasTrigger("TRG_SUNUCU_SIL");
            });

            entity.Property(e => e.TbSunucuId).HasColumnName("TB_SUNUCU_ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Banka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANKA");
            entity.Property(e => e.DuzenlemeSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DUZENLEME_SAAT");
            entity.Property(e => e.DuzenlemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DUZENLEME_TARIH");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.FaturaPeriyod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FATURA_PERIYOD");
            entity.Property(e => e.Faturao)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FATURAO");
            entity.Property(e => e.GuncelAciklama)
                .HasMaxLength(50)
                .HasColumnName("GUNCEL_ACIKLAMA");
            entity.Property(e => e.GuncelTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("GUNCEL_TUTAR");
            entity.Property(e => e.Hatirlat).HasColumnName("HATIRLAT");
            entity.Property(e => e.HizmetPeriyod)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HIZMET_PERIYOD");
            entity.Property(e => e.Indirimfiyat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("INDIRIMFIYAT");
            entity.Property(e => e.IslemTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ISLEM_TIP");
            entity.Property(e => e.Kdvtutar)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("KDVTUTAR");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeTutar)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.OdemeYapildi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ODEME_YAPILDI");
            entity.Property(e => e.SanalSunucu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SANAL_SUNUCU");
            entity.Property(e => e.SunucuBantGenislik)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SUNUCU_BANT_GENISLIK");
            entity.Property(e => e.SunucuBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("SUNUCU_BASLANGIC_TARIH");
            entity.Property(e => e.SunucuBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("SUNUCU_BITIS_TARIH");
            entity.Property(e => e.SunucuDiskAlan)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("SUNUCU_DISK_ALAN");
            entity.Property(e => e.SunucuId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("SUNUCU_ID");
            entity.Property(e => e.SunucuSure).HasColumnName("SUNUCU_SURE");
            entity.Property(e => e.SunucuYil).HasColumnName("SUNUCU_YIL");
            entity.Property(e => e.TaksitSayisi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAKSIT_SAYISI");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbDomainId).HasColumnName("TB_DOMAIN_ID");
            entity.Property(e => e.TbPaketId).HasColumnName("TB_PAKET_ID");
            entity.Property(e => e.Toplam)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TOPLAM");
            entity.Property(e => e.Ucretsiz)
                .HasDefaultValueSql("((0))")
                .HasColumnName("UCRETSIZ");
        });

        modelBuilder.Entity<TbSunucuKaydi>(entity =>
        {
            entity.HasKey(e => e.TbSunucuId);

            entity.ToTable("TB_SUNUCU_KAYDI");

            entity.Property(e => e.TbSunucuId).HasColumnName("TB_SUNUCU_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BirhostKodu)
                .HasMaxLength(50)
                .HasColumnName("BIRHOST_KODU");
            entity.Property(e => e.Bosta)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BOSTA");
            entity.Property(e => e.CariId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("CARI_ID");
            entity.Property(e => e.CpuId).HasColumnName("CPU_ID");
            entity.Property(e => e.CpuMdlId).HasColumnName("CPU_MDL_ID");
            entity.Property(e => e.DgnKodu)
                .HasMaxLength(50)
                .HasColumnName("DGN_KODU");
            entity.Property(e => e.DonanimTipId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("DONANIM_TIP_ID");
            entity.Property(e => e.FizikselSunucuId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("FIZIKSEL_SUNUCU_ID");
            entity.Property(e => e.HdId).HasColumnName("HD_ID");
            entity.Property(e => e.HdMdlId).HasColumnName("HD_MDL_ID");
            entity.Property(e => e.RafNo)
                .HasMaxLength(50)
                .HasColumnName("RAF_NO");
            entity.Property(e => e.RamId).HasColumnName("RAM_ID");
            entity.Property(e => e.RamMdlId).HasColumnName("RAM_MDL_ID");
            entity.Property(e => e.SanalSonucu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SANAL_SONUCU");
        });

        modelBuilder.Entity<TbSunucuKaydipp>(entity =>
        {
            entity.HasKey(e => e.TbSunucuId);

            entity.ToTable("TB_SUNUCU_KAYDIPP");

            entity.Property(e => e.TbSunucuId).HasColumnName("TB_SUNUCU_ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BirhostKodu)
                .HasMaxLength(50)
                .HasColumnName("BIRHOST_KODU");
            entity.Property(e => e.Bosta)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BOSTA");
            entity.Property(e => e.CariId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("CARI_ID");
            entity.Property(e => e.CpuId).HasColumnName("CPU_ID");
            entity.Property(e => e.CpuMdlId).HasColumnName("CPU_MDL_ID");
            entity.Property(e => e.DgnKodu)
                .HasMaxLength(50)
                .HasColumnName("DGN_KODU");
            entity.Property(e => e.DonanimTipId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("DONANIM_TIP_ID");
            entity.Property(e => e.FizikselSunucuId)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("FIZIKSEL_SUNUCU_ID");
            entity.Property(e => e.HdId).HasColumnName("HD_ID");
            entity.Property(e => e.HdMdlId).HasColumnName("HD_MDL_ID");
            entity.Property(e => e.RafNo)
                .HasMaxLength(50)
                .HasColumnName("RAF_NO");
            entity.Property(e => e.RamId).HasColumnName("RAM_ID");
            entity.Property(e => e.RamMdlId).HasColumnName("RAM_MDL_ID");
            entity.Property(e => e.SanalSonucu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SANAL_SONUCU");
        });

        modelBuilder.Entity<TbSunucuhrk>(entity =>
        {
            entity.HasKey(e => e.TbSunucuhrkId).HasName("PK__TB_SUNUCUHRK__38EE7070");

            entity.ToTable("TB_SUNUCUHRK", tb => tb.HasTrigger("TB_SUNUCU_GUNCELLE"));

            entity.Property(e => e.TbSunucuhrkId).HasColumnName("TB_SUNUCUHRK_ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BantGenisligiYenileme)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BANT_GENISLIGI_YENILEME");
            entity.Property(e => e.DiskAlanYenileme)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DISK_ALAN_YENILEME");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.FaturaId).HasColumnName("FATURA_ID");
            entity.Property(e => e.Hatirlat).HasColumnName("HATIRLAT");
            entity.Property(e => e.Iptal)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IPTAL");
            entity.Property(e => e.IslemTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ISLEM_TIP");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.OdemeYapildi).HasColumnName("ODEME_YAPILDI");
            entity.Property(e => e.PaketDegisiklik)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PAKET_DEGISIKLIK");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SAAT");
            entity.Property(e => e.SanalSunucu)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SANAL_SUNUCU");
            entity.Property(e => e.SunucuBaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("SUNUCU_BASLANGIC_TARIH");
            entity.Property(e => e.SunucuBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("SUNUCU_BITIS_TARIH");
            entity.Property(e => e.SunucuSure).HasColumnName("SUNUCU_SURE");
            entity.Property(e => e.SunucuYil).HasColumnName("SUNUCU_YIL");
            entity.Property(e => e.SureYenileme)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SURE_YENILEME");
            entity.Property(e => e.TaksitId).HasColumnName("TAKSIT_ID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbPaketId).HasColumnName("TB_PAKET_ID");
            entity.Property(e => e.TbSunucuId).HasColumnName("TB_SUNUCU_ID");
        });

        modelBuilder.Entity<TbTaksit>(entity =>
        {
            entity.HasKey(e => e.TbTaksitId).HasName("PK__TB_TAKSIT__408F9238");

            entity.ToTable("TB_TAKSIT", tb =>
            {
                tb.HasTrigger("TAKSIT_EKLE");
                tb.HasTrigger("TAKSIT_GUNCELLE");
            });

            entity.Property(e => e.TbTaksitId).HasColumnName("TB_TAKSIT_ID");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeYapildi)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ODEME_YAPILDI");
            entity.Property(e => e.Sayi).HasColumnName("SAYI");
            entity.Property(e => e.Sure)
                .HasComment("1: Ay\r\n2: Yıl")
                .HasColumnName("SURE");
            entity.Property(e => e.TbDomainId).HasColumnName("TB_DOMAIN_ID");
            entity.Property(e => e.TbHostingId).HasColumnName("TB_HOSTING_ID");
            entity.Property(e => e.TbSslId).HasColumnName("TB_SSL_ID");
            entity.Property(e => e.TbSsunucuId).HasColumnName("TB_SSUNUCU_ID");
            entity.Property(e => e.TbSunucuId).HasColumnName("TB_SUNUCU_ID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<TbTakvim>(entity =>
        {
            entity.HasKey(e => e.TbTakvimId).HasName("PK__TB_TAKVIM__0E04126B");

            entity.ToTable("TB_TAKVIM");

            entity.Property(e => e.TbTakvimId).HasColumnName("TB_TAKVIM_ID");
            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.BaslamaTarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA_TARIH");
            entity.Property(e => e.BitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIH");
            entity.Property(e => e.Durum)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DURUM");
            entity.Property(e => e.Etiket)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ETIKET");
            entity.Property(e => e.Hatirlatici)
                .IsUnicode(false)
                .HasColumnName("HATIRLATICI");
            entity.Property(e => e.Konu)
                .IsUnicode(false)
                .HasColumnName("KONU");
            entity.Property(e => e.Tipi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TIPI");
            entity.Property(e => e.Tumgun).HasColumnName("TUMGUN");
            entity.Property(e => e.Yer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("YER");
        });

        modelBuilder.Entity<TbTanimtabloistasyon>(entity =>
        {
            entity.ToTable("TB_TANIMTABLOISTASYON");

            entity.Property(e => e.TbTanimtabloistasyonId).HasColumnName("TB_TANIMTABLOISTASYON_ID");
            entity.Property(e => e.Tanimtablo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TANIMTABLO");
            entity.Property(e => e.TanimtabloId).HasColumnName("TANIMTABLO_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
        });

        modelBuilder.Entity<TbTelefonRehber>(entity =>
        {
            entity.HasKey(e => e.TbTelefonRehberId).HasName("PK__TB_TELEF__EF8B93D56B79F03D");

            entity.ToTable("TB_TELEFON_REHBER");

            entity.Property(e => e.TbTelefonRehberId).HasColumnName("TB_TELEFON_REHBER_ID");
            entity.Property(e => e.TbTelefonRehberCariId).HasColumnName("TB_TELEFON_REHBER_CARI_ID");
            entity.Property(e => e.TbTelefonRehberCep)
                .HasMaxLength(30)
                .HasColumnName("TB_TELEFON_REHBER_CEP");
            entity.Property(e => e.TbTelefonRehberFaks)
                .HasMaxLength(30)
                .HasColumnName("TB_TELEFON_REHBER_FAKS");
            entity.Property(e => e.TbTelefonRehberFirma)
                .HasMaxLength(50)
                .HasColumnName("TB_TELEFON_REHBER_FIRMA");
            entity.Property(e => e.TbTelefonRehberFirmaId).HasColumnName("TB_TELEFON_REHBER_FIRMA_ID");
            entity.Property(e => e.TbTelefonRehberFirmaTipId).HasColumnName("TB_TELEFON_REHBER_FIRMA_TIP_ID");
            entity.Property(e => e.TbTelefonRehberIlgili)
                .HasMaxLength(40)
                .HasColumnName("TB_TELEFON_REHBER_ILGILI");
            entity.Property(e => e.TbTelefonRehberTelefon)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TELEFON_REHBER_TELEFON");
            entity.Property(e => e.TbTelefonRehberTelefon2)
                .HasMaxLength(30)
                .HasColumnName("TB_TELEFON_REHBER_TELEFON_2");
        });

        modelBuilder.Entity<TbVardiya>(entity =>
        {
            entity.ToTable("TB_VARDIYA", tb =>
            {
                tb.HasTrigger("TRG_VARDIYA_SIL");
                tb.HasTrigger("TRG_VARDIYA_UPDATE");
            });

            entity.Property(e => e.TbVardiyaId).HasColumnName("TB_VARDIYA_ID");
            entity.Property(e => e.AcikFazla)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ACIK_FAZLA");
            entity.Property(e => e.AcikFazlaIslem).HasColumnName("ACIK_FAZLA_ISLEM");
            entity.Property(e => e.Aciklama)
                .HasColumnType("text")
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AcilisSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACILIS_SAAT");
            entity.Property(e => e.AcilisTarih)
                .HasColumnType("datetime")
                .HasColumnName("ACILIS_TARIH");
            entity.Property(e => e.CariOdemeToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CARI_ODEME_TOPLAM");
            entity.Property(e => e.CariTahsilatToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CARI_TAHSILAT_TOPLAM");
            entity.Property(e => e.DegistirenId).HasColumnName("DEGISTIREN_ID");
            entity.Property(e => e.DegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("DEGISTIRME_TARIH");
            entity.Property(e => e.EmtiaToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EMTIA_TOPLAM");
            entity.Property(e => e.EyfToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("EYF_TOPLAM");
            entity.Property(e => e.GelirToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("GELIR_TOPLAM");
            entity.Property(e => e.GiderToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("GIDER_TOPLAM");
            entity.Property(e => e.IrsaliyeToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("IRSALIYE_TOPLAM");
            entity.Property(e => e.IskontoToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ISKONTO_TOPLAM");
            entity.Property(e => e.Islem).HasColumnName("ISLEM");
            entity.Property(e => e.Kabul).HasColumnName("KABUL");
            entity.Property(e => e.KabulSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KABUL_SAAT");
            entity.Property(e => e.KabulTarih)
                .HasColumnType("datetime")
                .HasColumnName("KABUL_TARIH");
            entity.Property(e => e.KapanisSaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KAPANIS_SAAT");
            entity.Property(e => e.KapanisTarih)
                .HasColumnType("datetime")
                .HasColumnName("KAPANIS_TARIH");
            entity.Property(e => e.KartliVeresiyeIslem)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KARTLI_VERESIYE_ISLEM");
            entity.Property(e => e.KartliVeresiyeMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KARTLI_VERESIYE_MIKTAR");
            entity.Property(e => e.KartliVeresiyeToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KARTLI_VERESIYE_TOPLAM");
            entity.Property(e => e.Kur)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("KUR");
            entity.Property(e => e.NakitToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NAKIT_TOPLAM");
            entity.Property(e => e.OlusturanId).HasColumnName("OLUSTURAN_ID");
            entity.Property(e => e.OlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("OLUSTURMA_TARIH");
            entity.Property(e => e.Om)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("O = OTOMASYON, M = MANUEL")
                .HasColumnName("OM");
            entity.Property(e => e.PosToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("POS_TOPLAM");
            entity.Property(e => e.SatisMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_MIKTAR");
            entity.Property(e => e.SatisTutar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("SATIS_TUTAR");
            entity.Property(e => e.TbDonemId).HasColumnName("TB_DONEM_ID");
            entity.Property(e => e.TbGelirgiderId).HasColumnName("TB_GELIRGIDER_ID");
            entity.Property(e => e.TbIstasyonId).HasColumnName("TB_ISTASYON_ID");
            entity.Property(e => e.TbKasaId).HasColumnName("TB_KASA_ID");
            entity.Property(e => e.TbKullaniciId).HasColumnName("TB_KULLANICI_ID");
            entity.Property(e => e.TbParabirimiId).HasColumnName("TB_PARABIRIMI_ID");
            entity.Property(e => e.Teslimat)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TESLIMAT");
            entity.Property(e => e.TtsIslem)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TTS_ISLEM");
            entity.Property(e => e.TtsMiktar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TTS_MIKTAR");
            entity.Property(e => e.TtsToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TTS_TOPLAM");
            entity.Property(e => e.VardiyaNo)
                .HasComment("Günün kaçıncı vardiyasının olduğunu belirtir.")
                .HasColumnName("VARDIYA_NO");
            entity.Property(e => e.VardiyaSirano).HasColumnName("VARDIYA_SIRANO");
            entity.Property(e => e.VardiyaTanim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VARDIYA_TANIM");
            entity.Property(e => e.VardiyaTarih)
                .HasColumnType("datetime")
                .HasColumnName("VARDIYA_TARIH");
            entity.Property(e => e.VardiyaToplam)
                .HasComputedColumnSql("(([TESLIMAT]+[TTS_TOPLAM])+[KARTLI_VERESIYE_TOPLAM])", false)
                .HasColumnType("decimal(20, 3)")
                .HasColumnName("VARDIYA_TOPLAM");
            entity.Property(e => e.VeresiyeToplam)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("VERESIYE_TOPLAM");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity.ToTable("test");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Detay).HasColumnName("detay");
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserProf__1788CC4C4F9CCB9E");

            entity.ToTable("UserProfile");

            entity.HasIndex(e => e.UserName, "UQ__UserProf__C9F2845652793849").IsUnique();

            entity.Property(e => e.UserName).HasMaxLength(56);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "WebpagesUsersInRole",
                    r => r.HasOne<WebpagesRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_RoleId"),
                    l => l.HasOne<UserProfile>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__webpages__AF2760AD668030F6");
                        j.ToTable("webpages_UsersInRoles");
                    });
        });

        modelBuilder.Entity<VwDestek>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_DESTEK");

            entity.Property(e => e.Dk).HasColumnName("DK");
            entity.Property(e => e.DskBaslamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DSK_BASLAMA_TARIHI");
            entity.Property(e => e.DskBitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DSK_BITIS_TARIHI");
            entity.Property(e => e.DskDestekTipiId).HasColumnName("DSK_DESTEK_TIPI_ID");
            entity.Property(e => e.DskFirmaId).HasColumnName("DSK_FIRMA_ID");
            entity.Property(e => e.DskKapali).HasColumnName("DSK_KAPALI");
            entity.Property(e => e.DskSonucId).HasColumnName("DSK_SONUC_ID");
            entity.Property(e => e.DskTalepSebepId).HasColumnName("DSK_TALEP_SEBEP_ID");
            entity.Property(e => e.TbDestekId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TB_DESTEK_ID");
            entity.Property(e => e.ZamanAraligi)
                .HasMaxLength(63)
                .IsUnicode(false)
                .HasColumnName("ZAMAN_ARALIGI");
        });

        modelBuilder.Entity<VwFatura>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FATURA");

            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIH");
            entity.Property(e => e.CariId).HasColumnName("CARI_ID");
            entity.Property(e => e.CariUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.Hizmet)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("HIZMET");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idd).HasColumnName("IDD");
            entity.Property(e => e.Indirimfiyat)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("INDIRIMFIYAT");
            entity.Property(e => e.Isim)
                .HasMaxLength(355)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("KDV");
            entity.Property(e => e.Odeme)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME");
            entity.Property(e => e.Toplam)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TOPLAM");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<VwFaturaHavuz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FATURA_HAVUZ");

            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslangic)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC");
            entity.Property(e => e.Baslik)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Bitis)
                .HasColumnType("datetime")
                .HasColumnName("BITIS");
            entity.Property(e => e.CariUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");
            entity.Property(e => e.Deger)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DEGER");
            entity.Property(e => e.DomainAdi)
                .HasMaxLength(356)
                .IsUnicode(false)
                .HasColumnName("DOMAIN_ADI");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.FaturaId).HasColumnName("FATURA_ID");
            entity.Property(e => e.FaturaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO");
            entity.Property(e => e.HrkId).HasColumnName("HRK_ID");
            entity.Property(e => e.Idd).HasColumnName("IDD");
            entity.Property(e => e.Kdvtutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("KDVTUTAR");
            entity.Property(e => e.No).HasColumnName("NO");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.Paket).HasColumnName("PAKET");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.Yazdirma).HasColumnName("YAZDIRMA");
        });

        modelBuilder.Entity<VwFiyatListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_FIYAT_LISTESI");

            entity.Property(e => e.Aciklama)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Alacak)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ALACAK");
            entity.Property(e => e.Bakiye)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BAKIYE");
            entity.Property(e => e.Banka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANKA");
            entity.Property(e => e.Borc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("BORC");
            entity.Property(e => e.CariTur)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARI_TUR");
            entity.Property(e => e.CariUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");
            entity.Property(e => e.DomainAdi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DOMAIN_ADI");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAX");
            entity.Property(e => e.Gsm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GSM");
            entity.Property(e => e.GuncelAciklama)
                .HasMaxLength(50)
                .HasColumnName("GUNCEL_ACIKLAMA");
            entity.Property(e => e.GuncelTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("GUNCEL_TUTAR");
            entity.Property(e => e.HesapNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HESAP_NO");
            entity.Property(e => e.Hizmet)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("HIZMET");
            entity.Property(e => e.HizmetBitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("HIZMET_BITIS_TARIH");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILCE");
            entity.Property(e => e.IlgiliKisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILGILI_KISI");
            entity.Property(e => e.KartCvvNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KART_CVV_NO");
            entity.Property(e => e.KartNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KART_NO");
            entity.Property(e => e.KartSahibi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KART_SAHIBI");
            entity.Property(e => e.KartSonAy)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KART_SON_AY");
            entity.Property(e => e.KartSonYil)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KART_SON_YIL");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.PaketAd)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PAKET_AD");
            entity.Property(e => e.PostaKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POSTA_KODU");
            entity.Property(e => e.Renk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RENK");
            entity.Property(e => e.SubeNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBE_NO");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.TbHizmetId).HasColumnName("TB_HIZMET_ID");
            entity.Property(e => e.TbIlId).HasColumnName("TB_IL_ID");
            entity.Property(e => e.Tel1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEL_1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEL_2");
            entity.Property(e => e.Ulke)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ULKE");
            entity.Property(e => e.VergiDaire)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRE");
            entity.Property(e => e.VergiNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERGI_NO");
        });

        modelBuilder.Entity<VwGenelHizmet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GENEL_HIZMET");

            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BasTarih)
                .HasColumnType("datetime")
                .HasColumnName("BAS_TARIH");
            entity.Property(e => e.Baslik)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.BitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIH");
            entity.Property(e => e.Cari)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.IlgiliKisi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ILGILI_KISI");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.IslemTarih)
                .HasColumnType("datetime")
                .HasColumnName("ISLEM_TARIH");
            entity.Property(e => e.KalanSure).HasColumnName("KALAN_SURE");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIH");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.Paket)
                .HasMaxLength(355)
                .HasColumnName("PAKET");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
            entity.Property(e => e.Ucretsiz).HasColumnName("UCRETSIZ");
        });

        modelBuilder.Entity<VwGuncelTutar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_GUNCEL_TUTAR");

            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIH");
            entity.Property(e => e.CariId).HasColumnName("CARI_ID");
            entity.Property(e => e.CariUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");
            entity.Property(e => e.Domain)
                .HasMaxLength(355)
                .IsUnicode(false)
                .HasColumnName("DOMAIN");
            entity.Property(e => e.GuncelAciklama)
                .HasMaxLength(50)
                .HasColumnName("GUNCEL_ACIKLAMA");
            entity.Property(e => e.GuncelTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("GUNCEL_TUTAR");
            entity.Property(e => e.Hizmet)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("HIZMET");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(355)
                .HasColumnName("ISIM");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<VwIptalHizmetler>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_IPTAL_HIZMETLER");

            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.BaslangicTarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC_TARIH");
            entity.Property(e => e.BitisTarih)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIH");
            entity.Property(e => e.Cari)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI");
            entity.Property(e => e.Durum)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("DURUM");
            entity.Property(e => e.Paket)
                .HasMaxLength(355)
                .HasColumnName("PAKET");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<VwMusteriHrk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_MUSTERI_HRK");

            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslangic)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGIC");
            entity.Property(e => e.Baslik)
                .HasMaxLength(39)
                .IsUnicode(false)
                .HasColumnName("BASLIK");
            entity.Property(e => e.Bitis)
                .HasColumnType("datetime")
                .HasColumnName("BITIS");
            entity.Property(e => e.CariUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");
            entity.Property(e => e.Deger)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DEGER");
            entity.Property(e => e.DomainAdi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DOMAIN_ADI");
            entity.Property(e => e.Fatura).HasColumnName("FATURA");
            entity.Property(e => e.FaturaId).HasColumnName("FATURA_ID");
            entity.Property(e => e.FaturaNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO");
            entity.Property(e => e.HrkId).HasColumnName("HRK_ID");
            entity.Property(e => e.Idd).HasColumnName("IDD");
            entity.Property(e => e.Kdvtutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("KDVTUTAR");
            entity.Property(e => e.No).HasColumnName("NO");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.Paket).HasColumnName("PAKET");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TbCariId).HasColumnName("TB_CARI_ID");
        });

        modelBuilder.Entity<VwOdemeListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_ODEME_LISTESI");

            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.BaslamaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BASLAMA_TARIHI");
            entity.Property(e => e.BitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BITIS_TARIHI");
            entity.Property(e => e.Cari)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI");
            entity.Property(e => e.GuncelTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("GUNCEL_TUTAR");
            entity.Property(e => e.KdvliTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("KDVLI_TUTAR");
            entity.Property(e => e.OdemeSekli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");
            entity.Property(e => e.OdemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIHI");
            entity.Property(e => e.OdemeTutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ODEME_TUTAR");
            entity.Property(e => e.Paket)
                .HasMaxLength(355)
                .HasColumnName("PAKET");
        });

        modelBuilder.Entity<VwServisOncelik>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SERVIS_ONCELIK");

            entity.Property(e => e.SocAktif).HasColumnName("SOC_AKTIF");
            entity.Property(e => e.SocCozumSureDk).HasColumnName("SOC_COZUM_SURE_DK");
            entity.Property(e => e.SocCozumSureGun).HasColumnName("SOC_COZUM_SURE_GUN");
            entity.Property(e => e.SocCozumSureSaat).HasColumnName("SOC_COZUM_SURE_SAAT");
            entity.Property(e => e.SocDegistirenId).HasColumnName("SOC_DEGISTIREN_ID");
            entity.Property(e => e.SocDegistirmeTarih)
                .HasColumnType("datetime")
                .HasColumnName("SOC_DEGISTIRME_TARIH");
            entity.Property(e => e.SocGecikmeIkonIndex).HasColumnName("SOC_GECIKME_IKON_INDEX");
            entity.Property(e => e.SocGecikmeRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOC_GECIKME_RENK");
            entity.Property(e => e.SocGecikmeSureDakika).HasColumnName("SOC_GECIKME_SURE_DAKIKA");
            entity.Property(e => e.SocGecikmeYaziRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOC_GECIKME_YAZI_RENK");
            entity.Property(e => e.SocIkonIndexId).HasColumnName("SOC_IKON_INDEX_ID");
            entity.Property(e => e.SocKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOC_KOD");
            entity.Property(e => e.SocKritikIkonIndex).HasColumnName("SOC_KRITIK_IKON_INDEX");
            entity.Property(e => e.SocKritikRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOC_KRITIK_RENK");
            entity.Property(e => e.SocKritikSureDakika).HasColumnName("SOC_KRITIK_SURE_DAKIKA");
            entity.Property(e => e.SocKritikYaziRenk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOC_KRITIK_YAZI_RENK");
            entity.Property(e => e.SocOlusturanId).HasColumnName("SOC_OLUSTURAN_ID");
            entity.Property(e => e.SocOlusturmaTarih)
                .HasColumnType("datetime")
                .HasColumnName("SOC_OLUSTURMA_TARIH");
            entity.Property(e => e.SocTanim)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SOC_TANIM");
            entity.Property(e => e.SocVarsayilan).HasColumnName("SOC_VARSAYILAN");
            entity.Property(e => e.SocZaman)
                .HasMaxLength(49)
                .IsUnicode(false)
                .HasColumnName("SOC_ZAMAN");
            entity.Property(e => e.TbServisOncelikId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TB_SERVIS_ONCELIK_ID");
        });

        modelBuilder.Entity<VwSunucuKaydi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SUNUCU_KAYDI");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AnaSunucu)
                .HasMaxLength(50)
                .HasColumnName("ANA_SUNUCU");
            entity.Property(e => e.BirhostKodu)
                .HasMaxLength(50)
                .HasColumnName("BIRHOST_KODU");
            entity.Property(e => e.Bosta).HasColumnName("BOSTA");
            entity.Property(e => e.CariId).HasColumnName("CARI_ID");
            entity.Property(e => e.CariUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");
            entity.Property(e => e.CpuId).HasColumnName("CPU_ID");
            entity.Property(e => e.CpuMarka)
                .HasMaxLength(50)
                .HasColumnName("CPU_MARKA");
            entity.Property(e => e.CpuMdlId).HasColumnName("CPU_MDL_ID");
            entity.Property(e => e.CpuModel)
                .HasMaxLength(50)
                .HasColumnName("CPU_MODEL");
            entity.Property(e => e.DgnKodu)
                .HasMaxLength(50)
                .HasColumnName("DGN_KODU");
            entity.Property(e => e.DonanimTip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DONANIM_TIP");
            entity.Property(e => e.DonanimTipId).HasColumnName("DONANIM_TIP_ID");
            entity.Property(e => e.FSunucu).HasColumnName("F_SUNUCU");
            entity.Property(e => e.FizikselSunucuId).HasColumnName("FIZIKSEL_SUNUCU_ID");
            entity.Property(e => e.HdId).HasColumnName("HD_ID");
            entity.Property(e => e.HdMarka)
                .HasMaxLength(50)
                .HasColumnName("HD_MARKA");
            entity.Property(e => e.HdMdlId).HasColumnName("HD_MDL_ID");
            entity.Property(e => e.HdModel)
                .HasMaxLength(50)
                .HasColumnName("HD_MODEL");
            entity.Property(e => e.RafNo)
                .HasMaxLength(50)
                .HasColumnName("RAF_NO");
            entity.Property(e => e.RamId).HasColumnName("RAM_ID");
            entity.Property(e => e.RamMarka)
                .HasMaxLength(50)
                .HasColumnName("RAM_MARKA");
            entity.Property(e => e.RamMdlId).HasColumnName("RAM_MDL_ID");
            entity.Property(e => e.RamModel)
                .HasMaxLength(50)
                .HasColumnName("RAM_MODEL");
            entity.Property(e => e.SanalSonucu).HasColumnName("SANAL_SONUCU");
            entity.Property(e => e.TbSunucuId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TB_SUNUCU_ID");
        });

        modelBuilder.Entity<VwSunucuKaydiy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VW_SUNUCU_KAYDIY");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AnaSunucu)
                .HasMaxLength(50)
                .HasColumnName("ANA_SUNUCU");
            entity.Property(e => e.BirhostKodu)
                .HasMaxLength(50)
                .HasColumnName("BIRHOST_KODU");
            entity.Property(e => e.Bosta).HasColumnName("BOSTA");
            entity.Property(e => e.CariId).HasColumnName("CARI_ID");
            entity.Property(e => e.CariUnvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");
            entity.Property(e => e.CpuId).HasColumnName("CPU_ID");
            entity.Property(e => e.CpuMarka)
                .HasMaxLength(50)
                .HasColumnName("CPU_MARKA");
            entity.Property(e => e.CpuMdlId).HasColumnName("CPU_MDL_ID");
            entity.Property(e => e.CpuModel)
                .HasMaxLength(50)
                .HasColumnName("CPU_MODEL");
            entity.Property(e => e.DgnKodu)
                .HasMaxLength(50)
                .HasColumnName("DGN_KODU");
            entity.Property(e => e.DonanimTip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DONANIM_TIP");
            entity.Property(e => e.DonanimTipId).HasColumnName("DONANIM_TIP_ID");
            entity.Property(e => e.FSunucu).HasColumnName("F_SUNUCU");
            entity.Property(e => e.FizikselSunucuId).HasColumnName("FIZIKSEL_SUNUCU_ID");
            entity.Property(e => e.HdId).HasColumnName("HD_ID");
            entity.Property(e => e.HdMarka)
                .HasMaxLength(50)
                .HasColumnName("HD_MARKA");
            entity.Property(e => e.HdMdlId).HasColumnName("HD_MDL_ID");
            entity.Property(e => e.HdModel)
                .HasMaxLength(50)
                .HasColumnName("HD_MODEL");
            entity.Property(e => e.RafNo)
                .HasMaxLength(50)
                .HasColumnName("RAF_NO");
            entity.Property(e => e.RamId).HasColumnName("RAM_ID");
            entity.Property(e => e.RamMarka)
                .HasMaxLength(50)
                .HasColumnName("RAM_MARKA");
            entity.Property(e => e.RamMdlId).HasColumnName("RAM_MDL_ID");
            entity.Property(e => e.RamModel)
                .HasMaxLength(50)
                .HasColumnName("RAM_MODEL");
            entity.Property(e => e.SanalSonucu).HasColumnName("SANAL_SONUCU");
            entity.Property(e => e.TbSunucuId)
                .ValueGeneratedOnAdd()
                .HasColumnName("TB_SUNUCU_ID");
        });

        modelBuilder.Entity<WebpagesMembership>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__webpages__1788CC4C5A1A5A11");

            entity.ToTable("webpages_Membership");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.ConfirmationToken).HasMaxLength(128);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.IsConfirmed).HasDefaultValueSql("((0))");
            entity.Property(e => e.LastPasswordFailureDate).HasColumnType("datetime");
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.PasswordSalt).HasMaxLength(128);
            entity.Property(e => e.PasswordVerificationToken).HasMaxLength(128);
            entity.Property(e => e.PasswordVerificationTokenExpirationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<WebpagesOauthMembership>(entity =>
        {
            entity.HasKey(e => new { e.Provider, e.ProviderUserId }).HasName("PK__webpages__F53FC0ED5649C92D");

            entity.ToTable("webpages_OAuthMembership");

            entity.Property(e => e.Provider).HasMaxLength(30);
            entity.Property(e => e.ProviderUserId).HasMaxLength(100);
        });

        modelBuilder.Entity<WebpagesRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__webpages__8AFACE1A5FD33367");

            entity.ToTable("webpages_Roles");

            entity.HasIndex(e => e.RoleName, "UQ__webpages__8A2B616062AFA012").IsUnique();

            entity.Property(e => e.RoleName).HasMaxLength(256);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
