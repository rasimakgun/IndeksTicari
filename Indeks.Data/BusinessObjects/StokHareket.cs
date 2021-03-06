using System;
using System.Collections.Generic;
using System.Text;
using Indeks.Data.Helper;
using NHibernate;
using Indeks.Data.Base;

namespace Indeks.Data.BusinessObjects
{
  //public enum StHarGCKod : byte
  //{
  //  Cikis=0,Giris
  //}
  //public enum StHarHTur : byte
  //{
  //  Devir=1,Fatura,Irsaliye
  //}
	public partial class StokHareket : BusinessBase<int>
  {
    #region Declarations

    private string _gckod = null;
    private System.DateTime _tarih ;
    private double? _birimFiyat;
    private double? _kdv = null;
    private string _htur = null;
    private double? _satisk1 = null;
    private double? _satisk2 = null;
    private double? _satisk3 = null;
    private double? _satisk4 = null;
    private double? _satisk5 = null;

    //private FatirsUst _fatirsUst = null;
    private Stok _stok = null;
    #endregion

    #region Constructors

    public StokHareket() { }

    #endregion

    #region Methods

    public override int GetHashCode()
    {
      System.Text.StringBuilder sb = new System.Text.StringBuilder();
      sb.Append(this.GetType().FullName);
     
      sb.Append(_gckod);
      sb.Append(_tarih);
      sb.Append(_birimFiyat);
      sb.Append(_kdv);
      sb.Append(_htur);
      sb.Append(_satisk1);
      sb.Append(_satisk2);
      sb.Append(_satisk3);
      sb.Append(_satisk4);
      sb.Append(_satisk5);
      sb.Append(FisNo);
      sb.Append(GCMiktar);
      sb.Append(FTIRSIP);
      sb.Append(DirektSatis);
      sb.Append(SipNum);
      sb.Append(HareketBirim);
      sb.Append(HareketMiktar);
      return sb.ToString().GetHashCode();
    }
    #endregion
    #region Properties
    // Direkt Satiş yapıldığı durumlarda 'E' değeri atanır
    public virtual string HareketBirim { get; set; }
    public virtual double? HareketMiktar { get; set; }
    public virtual string SipNum { get; set; }
    public virtual Sube Sube { get; set; }
    public virtual string DirektSatis { get; set; }
    public virtual FTIRSIP FTIRSIP { get; set; } 
    public virtual string FisNo { get; set; }
    public virtual double GCMiktar { get; set; }
    public virtual string StharGckod
    {
      get { return _gckod; }
      set
      {
        OnStharGckodChanging();
        _gckod = value;
        OnStharGckodChanged();
      }
    }
    partial void OnStharGckodChanging();
    partial void OnStharGckodChanged();

    public virtual System.DateTime Tarih
    {
      get { return _tarih; }
      set
      {
        OnStharTarihChanging();
        _tarih = value;
        OnStharTarihChanged();
      }
    }
    partial void OnStharTarihChanging();
    partial void OnStharTarihChanged();

    public virtual double? BirimFiyat
    {
      get { return _birimFiyat; }
      set
      {
        OnStharBfChanging();
        _birimFiyat = value;
        OnStharBfChanged();
      }
    }
    partial void OnStharBfChanging();
    partial void OnStharBfChanged();

    public virtual double? Kdv
    {
      get { return _kdv; }
      set
      {
        OnStharKdvChanging();
        _kdv = value;
        OnStharKdvChanged();
      }
    }
    partial void OnStharKdvChanging();
    partial void OnStharKdvChanged();

    public virtual string StharHtur
    {
      get { return _htur; }
      set
      {
        OnStharHturChanging();
        _htur = value;
        OnStharHturChanged();
      }
    }
    partial void OnStharHturChanging();
    partial void OnStharHturChanged();

    public virtual double? Isk1
    {
      get { return _satisk1; }
      set
      {
        OnStharSatisk1Changing();
        _satisk1 = value;
        OnStharSatisk1Changed();
      }
    }
    partial void OnStharSatisk1Changing();
    partial void OnStharSatisk1Changed();

    public virtual double? Isk2
    {
      get { return _satisk2; }
      set
      {
        OnStharSatisk2Changing();
        _satisk2 = value;
        OnStharSatisk2Changed();
      }
    }
    partial void OnStharSatisk2Changing();
    partial void OnStharSatisk2Changed();

    public virtual double? Isk3
    {
      get { return _satisk3; }
      set
      {
        OnStharSatisk3Changing();
        _satisk3 = value;
        OnStharSatisk3Changed();
      }
    }
    partial void OnStharSatisk3Changing();
    partial void OnStharSatisk3Changed();

    public virtual double? Isk4
    {
      get { return _satisk4; }
      set
      {
        OnStharSatis4Changing();
        _satisk4 = value;
        OnStharSatis4Changed();
      }
    }
    partial void OnStharSatis4Changing();
    partial void OnStharSatis4Changed();

    public virtual double? Isk5
    {
      get { return _satisk5; }
      set
      {
        OnStharSatisk5Changing();
        _satisk5 = value;
        OnStharSatisk5Changed();
      }
    }
    partial void OnStharSatisk5Changing();
    partial void OnStharSatisk5Changed();

    //public virtual FatirsUst FatirsUst
    //{
    //  get { return _fatirsUst; }
    //  set
    //  {
    //    OnFatirsUstChanging();
    //    _fatirsUst = value;
    //    OnFatirsUstChanged();
    //  }
    //}
  

  
    public virtual Stok Stok
    {
      get { return _stok; }
      set
      {
        OnStokChanging();
        _stok = value;
        OnStokChanged();
      }
    }
    partial void OnStokChanging();
    partial void OnStokChanged();

    #endregion
    public static string DetermineGCKodu(FTIRSIP ftirsip)
    {
      if (ftirsip == FTIRSIP.AlisFat || ftirsip == FTIRSIP.AlisIrs)
        return "G";
      else
        return "C";
    }
    public static string DetermineHarTur(FatNoTip fatNoTip)
    {
      if (fatNoTip == FatNoTip.Fatura)
        return "F";
      else if (fatNoTip == FatNoTip.Irsaliye)
        return "I";
      else
        return "S";
    }
   
  }
}