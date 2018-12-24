﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_1_FirmaKayit.Hangar
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FirmaKayit")]
	public partial class DBFirmaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertbgFirmaKayit(bgFirmaKayit instance);
    partial void UpdatebgFirmaKayit(bgFirmaKayit instance);
    partial void DeletebgFirmaKayit(bgFirmaKayit instance);
    partial void InsertbgFirmaTipi(bgFirmaTipi instance);
    partial void UpdatebgFirmaTipi(bgFirmaTipi instance);
    partial void DeletebgFirmaTipi(bgFirmaTipi instance);
    #endregion
		
		public DBFirmaDataContext() : 
				base(global::Project_1_FirmaKayit.Properties.Settings.Default.FirmaKayitConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBFirmaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBFirmaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBFirmaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBFirmaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<bgFirmaKayit> bgFirmaKayits
		{
			get
			{
				return this.GetTable<bgFirmaKayit>();
			}
		}
		
		public System.Data.Linq.Table<bgFirmaTipi> bgFirmaTipis
		{
			get
			{
				return this.GetTable<bgFirmaTipi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bgFirmaKayit")]
	public partial class bgFirmaKayit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _Firma_No;
		
		private System.Nullable<int> _Firma_Tipi;
		
		private string _Firma_Adi;
		
		private string _Firma_Adres;
		
		private string _Firma_Tel1;
		
		private string _Firma_Tel2;
		
		private string _Firma_Fax;
		
		private string _Firma_Yetkili;
		
		private string _Firma_Departman;
		
		private string _Firma_Web;
		
		private string _Firma_Email;
		
		private string _Firma_Vergi_Dairesi;
		
		private string _Firma_Vergi_No;
		
		private System.Nullable<int> _saveUser;
		
		private System.Nullable<System.DateTime> _saveDate;
		
		private System.Nullable<int> _updateUser;
		
		private System.Nullable<System.DateTime> _updateDate;
		
		private EntityRef<bgFirmaTipi> _bgFirmaTipi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirma_NoChanging(System.Nullable<int> value);
    partial void OnFirma_NoChanged();
    partial void OnFirma_TipiChanging(System.Nullable<int> value);
    partial void OnFirma_TipiChanged();
    partial void OnFirma_AdiChanging(string value);
    partial void OnFirma_AdiChanged();
    partial void OnFirma_AdresChanging(string value);
    partial void OnFirma_AdresChanged();
    partial void OnFirma_Tel1Changing(string value);
    partial void OnFirma_Tel1Changed();
    partial void OnFirma_Tel2Changing(string value);
    partial void OnFirma_Tel2Changed();
    partial void OnFirma_FaxChanging(string value);
    partial void OnFirma_FaxChanged();
    partial void OnFirma_YetkiliChanging(string value);
    partial void OnFirma_YetkiliChanged();
    partial void OnFirma_DepartmanChanging(string value);
    partial void OnFirma_DepartmanChanged();
    partial void OnFirma_WebChanging(string value);
    partial void OnFirma_WebChanged();
    partial void OnFirma_EmailChanging(string value);
    partial void OnFirma_EmailChanged();
    partial void OnFirma_Vergi_DairesiChanging(string value);
    partial void OnFirma_Vergi_DairesiChanged();
    partial void OnFirma_Vergi_NoChanging(string value);
    partial void OnFirma_Vergi_NoChanged();
    partial void OnsaveUserChanging(System.Nullable<int> value);
    partial void OnsaveUserChanged();
    partial void OnsaveDateChanging(System.Nullable<System.DateTime> value);
    partial void OnsaveDateChanged();
    partial void OnupdateUserChanging(System.Nullable<int> value);
    partial void OnupdateUserChanged();
    partial void OnupdateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnupdateDateChanged();
    #endregion
		
		public bgFirmaKayit()
		{
			this._bgFirmaTipi = default(EntityRef<bgFirmaTipi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_No", DbType="Int")]
		public System.Nullable<int> Firma_No
		{
			get
			{
				return this._Firma_No;
			}
			set
			{
				if ((this._Firma_No != value))
				{
					this.OnFirma_NoChanging(value);
					this.SendPropertyChanging();
					this._Firma_No = value;
					this.SendPropertyChanged("Firma_No");
					this.OnFirma_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Tipi", DbType="Int")]
		public System.Nullable<int> Firma_Tipi
		{
			get
			{
				return this._Firma_Tipi;
			}
			set
			{
				if ((this._Firma_Tipi != value))
				{
					if (this._bgFirmaTipi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFirma_TipiChanging(value);
					this.SendPropertyChanging();
					this._Firma_Tipi = value;
					this.SendPropertyChanged("Firma_Tipi");
					this.OnFirma_TipiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Adi", DbType="NVarChar(250)")]
		public string Firma_Adi
		{
			get
			{
				return this._Firma_Adi;
			}
			set
			{
				if ((this._Firma_Adi != value))
				{
					this.OnFirma_AdiChanging(value);
					this.SendPropertyChanging();
					this._Firma_Adi = value;
					this.SendPropertyChanged("Firma_Adi");
					this.OnFirma_AdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Adres", DbType="NVarChar(MAX)")]
		public string Firma_Adres
		{
			get
			{
				return this._Firma_Adres;
			}
			set
			{
				if ((this._Firma_Adres != value))
				{
					this.OnFirma_AdresChanging(value);
					this.SendPropertyChanging();
					this._Firma_Adres = value;
					this.SendPropertyChanged("Firma_Adres");
					this.OnFirma_AdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Tel1", DbType="NVarChar(20)")]
		public string Firma_Tel1
		{
			get
			{
				return this._Firma_Tel1;
			}
			set
			{
				if ((this._Firma_Tel1 != value))
				{
					this.OnFirma_Tel1Changing(value);
					this.SendPropertyChanging();
					this._Firma_Tel1 = value;
					this.SendPropertyChanged("Firma_Tel1");
					this.OnFirma_Tel1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Tel2", DbType="NVarChar(20)")]
		public string Firma_Tel2
		{
			get
			{
				return this._Firma_Tel2;
			}
			set
			{
				if ((this._Firma_Tel2 != value))
				{
					this.OnFirma_Tel2Changing(value);
					this.SendPropertyChanging();
					this._Firma_Tel2 = value;
					this.SendPropertyChanged("Firma_Tel2");
					this.OnFirma_Tel2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Fax", DbType="NVarChar(20)")]
		public string Firma_Fax
		{
			get
			{
				return this._Firma_Fax;
			}
			set
			{
				if ((this._Firma_Fax != value))
				{
					this.OnFirma_FaxChanging(value);
					this.SendPropertyChanging();
					this._Firma_Fax = value;
					this.SendPropertyChanged("Firma_Fax");
					this.OnFirma_FaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Yetkili", DbType="NVarChar(120)")]
		public string Firma_Yetkili
		{
			get
			{
				return this._Firma_Yetkili;
			}
			set
			{
				if ((this._Firma_Yetkili != value))
				{
					this.OnFirma_YetkiliChanging(value);
					this.SendPropertyChanging();
					this._Firma_Yetkili = value;
					this.SendPropertyChanged("Firma_Yetkili");
					this.OnFirma_YetkiliChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Departman", DbType="NVarChar(500)")]
		public string Firma_Departman
		{
			get
			{
				return this._Firma_Departman;
			}
			set
			{
				if ((this._Firma_Departman != value))
				{
					this.OnFirma_DepartmanChanging(value);
					this.SendPropertyChanging();
					this._Firma_Departman = value;
					this.SendPropertyChanged("Firma_Departman");
					this.OnFirma_DepartmanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Web", DbType="NVarChar(100)")]
		public string Firma_Web
		{
			get
			{
				return this._Firma_Web;
			}
			set
			{
				if ((this._Firma_Web != value))
				{
					this.OnFirma_WebChanging(value);
					this.SendPropertyChanging();
					this._Firma_Web = value;
					this.SendPropertyChanged("Firma_Web");
					this.OnFirma_WebChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Email", DbType="NVarChar(100)")]
		public string Firma_Email
		{
			get
			{
				return this._Firma_Email;
			}
			set
			{
				if ((this._Firma_Email != value))
				{
					this.OnFirma_EmailChanging(value);
					this.SendPropertyChanging();
					this._Firma_Email = value;
					this.SendPropertyChanged("Firma_Email");
					this.OnFirma_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Vergi_Dairesi", DbType="NVarChar(80)")]
		public string Firma_Vergi_Dairesi
		{
			get
			{
				return this._Firma_Vergi_Dairesi;
			}
			set
			{
				if ((this._Firma_Vergi_Dairesi != value))
				{
					this.OnFirma_Vergi_DairesiChanging(value);
					this.SendPropertyChanging();
					this._Firma_Vergi_Dairesi = value;
					this.SendPropertyChanged("Firma_Vergi_Dairesi");
					this.OnFirma_Vergi_DairesiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Vergi_No", DbType="NVarChar(20)")]
		public string Firma_Vergi_No
		{
			get
			{
				return this._Firma_Vergi_No;
			}
			set
			{
				if ((this._Firma_Vergi_No != value))
				{
					this.OnFirma_Vergi_NoChanging(value);
					this.SendPropertyChanging();
					this._Firma_Vergi_No = value;
					this.SendPropertyChanged("Firma_Vergi_No");
					this.OnFirma_Vergi_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_saveUser", DbType="Int")]
		public System.Nullable<int> saveUser
		{
			get
			{
				return this._saveUser;
			}
			set
			{
				if ((this._saveUser != value))
				{
					this.OnsaveUserChanging(value);
					this.SendPropertyChanging();
					this._saveUser = value;
					this.SendPropertyChanged("saveUser");
					this.OnsaveUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_saveDate", DbType="Date")]
		public System.Nullable<System.DateTime> saveDate
		{
			get
			{
				return this._saveDate;
			}
			set
			{
				if ((this._saveDate != value))
				{
					this.OnsaveDateChanging(value);
					this.SendPropertyChanging();
					this._saveDate = value;
					this.SendPropertyChanged("saveDate");
					this.OnsaveDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updateUser", DbType="Int")]
		public System.Nullable<int> updateUser
		{
			get
			{
				return this._updateUser;
			}
			set
			{
				if ((this._updateUser != value))
				{
					this.OnupdateUserChanging(value);
					this.SendPropertyChanging();
					this._updateUser = value;
					this.SendPropertyChanged("updateUser");
					this.OnupdateUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updateDate", DbType="Date")]
		public System.Nullable<System.DateTime> updateDate
		{
			get
			{
				return this._updateDate;
			}
			set
			{
				if ((this._updateDate != value))
				{
					this.OnupdateDateChanging(value);
					this.SendPropertyChanging();
					this._updateDate = value;
					this.SendPropertyChanged("updateDate");
					this.OnupdateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="bgFirmaTipi_bgFirmaKayit", Storage="_bgFirmaTipi", ThisKey="Firma_Tipi", OtherKey="ID", IsForeignKey=true)]
		public bgFirmaTipi bgFirmaTipi
		{
			get
			{
				return this._bgFirmaTipi.Entity;
			}
			set
			{
				bgFirmaTipi previousValue = this._bgFirmaTipi.Entity;
				if (((previousValue != value) 
							|| (this._bgFirmaTipi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._bgFirmaTipi.Entity = null;
						previousValue.bgFirmaKayits.Remove(this);
					}
					this._bgFirmaTipi.Entity = value;
					if ((value != null))
					{
						value.bgFirmaKayits.Add(this);
						this._Firma_Tipi = value.ID;
					}
					else
					{
						this._Firma_Tipi = default(Nullable<int>);
					}
					this.SendPropertyChanged("bgFirmaTipi");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bgFirmaTipi")]
	public partial class bgFirmaTipi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Firma_Tipi;
		
		private EntitySet<bgFirmaKayit> _bgFirmaKayits;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirma_TipiChanging(string value);
    partial void OnFirma_TipiChanged();
    #endregion
		
		public bgFirmaTipi()
		{
			this._bgFirmaKayits = new EntitySet<bgFirmaKayit>(new Action<bgFirmaKayit>(this.attach_bgFirmaKayits), new Action<bgFirmaKayit>(this.detach_bgFirmaKayits));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firma_Tipi", DbType="NVarChar(20)")]
		public string Firma_Tipi
		{
			get
			{
				return this._Firma_Tipi;
			}
			set
			{
				if ((this._Firma_Tipi != value))
				{
					this.OnFirma_TipiChanging(value);
					this.SendPropertyChanging();
					this._Firma_Tipi = value;
					this.SendPropertyChanged("Firma_Tipi");
					this.OnFirma_TipiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="bgFirmaTipi_bgFirmaKayit", Storage="_bgFirmaKayits", ThisKey="ID", OtherKey="Firma_Tipi")]
		public EntitySet<bgFirmaKayit> bgFirmaKayits
		{
			get
			{
				return this._bgFirmaKayits;
			}
			set
			{
				this._bgFirmaKayits.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_bgFirmaKayits(bgFirmaKayit entity)
		{
			this.SendPropertyChanging();
			entity.bgFirmaTipi = this;
		}
		
		private void detach_bgFirmaKayits(bgFirmaKayit entity)
		{
			this.SendPropertyChanging();
			entity.bgFirmaTipi = null;
		}
	}
}
#pragma warning restore 1591
