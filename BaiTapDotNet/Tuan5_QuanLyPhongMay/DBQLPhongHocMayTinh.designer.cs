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

namespace Tuan5_QuanLyPhongMay
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyPhongMay")]
	public partial class DBQLPhongHocMayTinhDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertlblMay(lblMay instance);
    partial void UpdatelblMay(lblMay instance);
    partial void DeletelblMay(lblMay instance);
    partial void InsertlblPhong(lblPhong instance);
    partial void UpdatelblPhong(lblPhong instance);
    partial void DeletelblPhong(lblPhong instance);
    #endregion
		
		public DBQLPhongHocMayTinhDataContext() : 
				base(global::Tuan5_QuanLyPhongMay.Properties.Settings.Default.QuanLyPhongMayConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBQLPhongHocMayTinhDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBQLPhongHocMayTinhDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBQLPhongHocMayTinhDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBQLPhongHocMayTinhDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<lblMay> lblMays
		{
			get
			{
				return this.GetTable<lblMay>();
			}
		}
		
		public System.Data.Linq.Table<lblPhong> lblPhongs
		{
			get
			{
				return this.GetTable<lblPhong>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.lblMay")]
	public partial class lblMay : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _id_Phong;
		
		private string _cpu;
		
		private string _hdd;
		
		private string _ram;
		
		private string _vga;
		
		private string _monitor;
		
		private EntityRef<lblPhong> _lblPhong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void Onid_PhongChanging(string value);
    partial void Onid_PhongChanged();
    partial void OncpuChanging(string value);
    partial void OncpuChanged();
    partial void OnhddChanging(string value);
    partial void OnhddChanged();
    partial void OnramChanging(string value);
    partial void OnramChanged();
    partial void OnvgaChanging(string value);
    partial void OnvgaChanged();
    partial void OnmonitorChanging(string value);
    partial void OnmonitorChanged();
    #endregion
		
		public lblMay()
		{
			this._lblPhong = default(EntityRef<lblPhong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_Phong", DbType="NChar(10)")]
		public string id_Phong
		{
			get
			{
				return this._id_Phong;
			}
			set
			{
				if ((this._id_Phong != value))
				{
					if (this._lblPhong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_PhongChanging(value);
					this.SendPropertyChanging();
					this._id_Phong = value;
					this.SendPropertyChanged("id_Phong");
					this.Onid_PhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cpu", DbType="NVarChar(50)")]
		public string cpu
		{
			get
			{
				return this._cpu;
			}
			set
			{
				if ((this._cpu != value))
				{
					this.OncpuChanging(value);
					this.SendPropertyChanging();
					this._cpu = value;
					this.SendPropertyChanged("cpu");
					this.OncpuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hdd", DbType="NVarChar(50)")]
		public string hdd
		{
			get
			{
				return this._hdd;
			}
			set
			{
				if ((this._hdd != value))
				{
					this.OnhddChanging(value);
					this.SendPropertyChanging();
					this._hdd = value;
					this.SendPropertyChanged("hdd");
					this.OnhddChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ram", DbType="NVarChar(50)")]
		public string ram
		{
			get
			{
				return this._ram;
			}
			set
			{
				if ((this._ram != value))
				{
					this.OnramChanging(value);
					this.SendPropertyChanging();
					this._ram = value;
					this.SendPropertyChanged("ram");
					this.OnramChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_vga", DbType="NVarChar(50)")]
		public string vga
		{
			get
			{
				return this._vga;
			}
			set
			{
				if ((this._vga != value))
				{
					this.OnvgaChanging(value);
					this.SendPropertyChanging();
					this._vga = value;
					this.SendPropertyChanged("vga");
					this.OnvgaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_monitor", DbType="NVarChar(50)")]
		public string monitor
		{
			get
			{
				return this._monitor;
			}
			set
			{
				if ((this._monitor != value))
				{
					this.OnmonitorChanging(value);
					this.SendPropertyChanging();
					this._monitor = value;
					this.SendPropertyChanged("monitor");
					this.OnmonitorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="lblPhong_lblMay", Storage="_lblPhong", ThisKey="id_Phong", OtherKey="id_Phong", IsForeignKey=true)]
		public lblPhong lblPhong
		{
			get
			{
				return this._lblPhong.Entity;
			}
			set
			{
				lblPhong previousValue = this._lblPhong.Entity;
				if (((previousValue != value) 
							|| (this._lblPhong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._lblPhong.Entity = null;
						previousValue.lblMays.Remove(this);
					}
					this._lblPhong.Entity = value;
					if ((value != null))
					{
						value.lblMays.Add(this);
						this._id_Phong = value.id_Phong;
					}
					else
					{
						this._id_Phong = default(string);
					}
					this.SendPropertyChanged("lblPhong");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.lblPhong")]
	public partial class lblPhong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id_Phong;
		
		private string _tenPhong;
		
		private string _toaNha;
		
		private string _tangLau;
		
		private EntitySet<lblMay> _lblMays;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_PhongChanging(string value);
    partial void Onid_PhongChanged();
    partial void OntenPhongChanging(string value);
    partial void OntenPhongChanged();
    partial void OntoaNhaChanging(string value);
    partial void OntoaNhaChanged();
    partial void OntangLauChanging(string value);
    partial void OntangLauChanged();
    #endregion
		
		public lblPhong()
		{
			this._lblMays = new EntitySet<lblMay>(new Action<lblMay>(this.attach_lblMays), new Action<lblMay>(this.detach_lblMays));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_Phong", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id_Phong
		{
			get
			{
				return this._id_Phong;
			}
			set
			{
				if ((this._id_Phong != value))
				{
					this.Onid_PhongChanging(value);
					this.SendPropertyChanging();
					this._id_Phong = value;
					this.SendPropertyChanged("id_Phong");
					this.Onid_PhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenPhong", DbType="NVarChar(30)")]
		public string tenPhong
		{
			get
			{
				return this._tenPhong;
			}
			set
			{
				if ((this._tenPhong != value))
				{
					this.OntenPhongChanging(value);
					this.SendPropertyChanging();
					this._tenPhong = value;
					this.SendPropertyChanged("tenPhong");
					this.OntenPhongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_toaNha", DbType="NVarChar(50)")]
		public string toaNha
		{
			get
			{
				return this._toaNha;
			}
			set
			{
				if ((this._toaNha != value))
				{
					this.OntoaNhaChanging(value);
					this.SendPropertyChanging();
					this._toaNha = value;
					this.SendPropertyChanged("toaNha");
					this.OntoaNhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tangLau", DbType="NVarChar(50)")]
		public string tangLau
		{
			get
			{
				return this._tangLau;
			}
			set
			{
				if ((this._tangLau != value))
				{
					this.OntangLauChanging(value);
					this.SendPropertyChanging();
					this._tangLau = value;
					this.SendPropertyChanged("tangLau");
					this.OntangLauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="lblPhong_lblMay", Storage="_lblMays", ThisKey="id_Phong", OtherKey="id_Phong")]
		public EntitySet<lblMay> lblMays
		{
			get
			{
				return this._lblMays;
			}
			set
			{
				this._lblMays.Assign(value);
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
		
		private void attach_lblMays(lblMay entity)
		{
			this.SendPropertyChanging();
			entity.lblPhong = this;
		}
		
		private void detach_lblMays(lblMay entity)
		{
			this.SendPropertyChanging();
			entity.lblPhong = null;
		}
	}
}
#pragma warning restore 1591
