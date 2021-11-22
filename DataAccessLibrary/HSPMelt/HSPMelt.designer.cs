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

namespace DataAccessLibrary.HSPMelt
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HSPMelt")]
	public partial class HSPMeltDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBagHouse(BagHouse instance);
    partial void UpdateBagHouse(BagHouse instance);
    partial void DeleteBagHouse(BagHouse instance);
    partial void InsertStation(Station instance);
    partial void UpdateStation(Station instance);
    partial void DeleteStation(Station instance);
    #endregion
		
		public HSPMeltDataContext() : 
				base(global::DataAccessLibrary.Properties.Settings.Default.HSPMeltConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HSPMeltDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HSPMeltDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HSPMeltDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HSPMeltDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BagHouse> BagHouses
		{
			get
			{
				return this.GetTable<BagHouse>();
			}
		}
		
		public System.Data.Linq.Table<Station> Stations
		{
			get
			{
				return this.GetTable<Station>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BagHouse")]
	public partial class BagHouse : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BagHouseRecID;
		
		private string _StationID;
		
		private System.Nullable<int> _Fan1MTRLoad;
		
		private System.Nullable<int> _Fan2MTRLoad;
		
		private System.Nullable<int> _Fan3MTRLoad;
		
		private System.Nullable<int> _Fan4MTRLoad;
		
		private System.Nullable<System.DateTime> _CreateDate;
		
		private System.Nullable<System.DateTime> _UpdateDate;
		
		private System.Nullable<int> _Fan1BearingATemp;
		
		private System.Nullable<int> _Fan1BearingBTemp;
		
		private System.Nullable<int> _Fan1CBearingMtrTemp;
		
		private System.Nullable<int> _Fan1DBearingMtrTemp;
		
		private System.Nullable<int> _Fan1MtrRTD_1_Temp;
		
		private System.Nullable<int> _Fan1MtrRTD_2_Temp;
		
		private System.Nullable<int> _Fan1MtrRTD_3_Temp;
		
		private System.Nullable<int> _Fan2BearingATemp;
		
		private System.Nullable<int> _Fan2BearingBTemp;
		
		private System.Nullable<int> _Fan2CBearingMtrTemp;
		
		private System.Nullable<int> _Fan2DBearingMtrTemp;
		
		private System.Nullable<int> _Fan2MtrRTD_1_Temp;
		
		private System.Nullable<int> _Fan2MtrRTD_2_Temp;
		
		private System.Nullable<int> _Fan2MtrRTD_3_Temp;
		
		private System.Nullable<int> _Fan3BearingATemp;
		
		private System.Nullable<int> _Fan3BearingBTemp;
		
		private System.Nullable<int> _Fan3CBearingMtrTemp;
		
		private System.Nullable<int> _Fan3DBearingMtrTemp;
		
		private System.Nullable<int> _Fan3MtrRTD_1_Temp;
		
		private System.Nullable<int> _Fan3MtrRTD_2_Temp;
		
		private System.Nullable<int> _Fan3MtrRTD_3_Temp;
		
		private System.Nullable<int> _Fan4BearingATemp;
		
		private System.Nullable<int> _Fan4BearingBTemp;
		
		private System.Nullable<int> _Fan4CBearingMtrTemp;
		
		private System.Nullable<int> _Fan4DBearingMtrTemp;
		
		private System.Nullable<int> _Fan4MtrRTD_1_Temp;
		
		private System.Nullable<int> _Fan4MtrRTD_2_Temp;
		
		private System.Nullable<int> _Fan4MtrRTD_3_Temp;
		
		private System.Nullable<decimal> _PSIDifferential;
		
		private EntityRef<Station> _Station;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBagHouseRecIDChanging(int value);
    partial void OnBagHouseRecIDChanged();
    partial void OnStationIDChanging(string value);
    partial void OnStationIDChanged();
    partial void OnFan1MTRLoadChanging(System.Nullable<int> value);
    partial void OnFan1MTRLoadChanged();
    partial void OnFan2MTRLoadChanging(System.Nullable<int> value);
    partial void OnFan2MTRLoadChanged();
    partial void OnFan3MTRLoadChanging(System.Nullable<int> value);
    partial void OnFan3MTRLoadChanged();
    partial void OnFan4MTRLoadChanging(System.Nullable<int> value);
    partial void OnFan4MTRLoadChanged();
    partial void OnCreateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreateDateChanged();
    partial void OnUpdateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdateDateChanged();
    partial void OnFan1BearingATempChanging(System.Nullable<int> value);
    partial void OnFan1BearingATempChanged();
    partial void OnFan1BearingBTempChanging(System.Nullable<int> value);
    partial void OnFan1BearingBTempChanged();
    partial void OnFan1CBearingMtrTempChanging(System.Nullable<int> value);
    partial void OnFan1CBearingMtrTempChanged();
    partial void OnFan1DBearingMtrTempChanging(System.Nullable<int> value);
    partial void OnFan1DBearingMtrTempChanged();
    partial void OnFan1MtrRTD_1_TempChanging(System.Nullable<int> value);
    partial void OnFan1MtrRTD_1_TempChanged();
    partial void OnFan1MtrRTD_2_TempChanging(System.Nullable<int> value);
    partial void OnFan1MtrRTD_2_TempChanged();
    partial void OnFan1MtrRTD_3_TempChanging(System.Nullable<int> value);
    partial void OnFan1MtrRTD_3_TempChanged();
    partial void OnFan2BearingATempChanging(System.Nullable<int> value);
    partial void OnFan2BearingATempChanged();
    partial void OnFan2BearingBTempChanging(System.Nullable<int> value);
    partial void OnFan2BearingBTempChanged();
    partial void OnFan2CBearingMtrTempChanging(System.Nullable<int> value);
    partial void OnFan2CBearingMtrTempChanged();
    partial void OnFan2DBearingMtrTempChanging(System.Nullable<int> value);
    partial void OnFan2DBearingMtrTempChanged();
    partial void OnFan2MtrRTD_1_TempChanging(System.Nullable<int> value);
    partial void OnFan2MtrRTD_1_TempChanged();
    partial void OnFan2MtrRTD_2_TempChanging(System.Nullable<int> value);
    partial void OnFan2MtrRTD_2_TempChanged();
    partial void OnFan2MtrRTD_3_TempChanging(System.Nullable<int> value);
    partial void OnFan2MtrRTD_3_TempChanged();
    partial void OnFan3BearingATempChanging(System.Nullable<int> value);
    partial void OnFan3BearingATempChanged();
    partial void OnFan3BearingBTempChanging(System.Nullable<int> value);
    partial void OnFan3BearingBTempChanged();
    partial void OnFan3CBearingMtrTempChanging(System.Nullable<int> value);
    partial void OnFan3CBearingMtrTempChanged();
    partial void OnFan3DBearingMtrTempChanging(System.Nullable<int> value);
    partial void OnFan3DBearingMtrTempChanged();
    partial void OnFan3MtrRTD_1_TempChanging(System.Nullable<int> value);
    partial void OnFan3MtrRTD_1_TempChanged();
    partial void OnFan3MtrRTD_2_TempChanging(System.Nullable<int> value);
    partial void OnFan3MtrRTD_2_TempChanged();
    partial void OnFan3MtrRTD_3_TempChanging(System.Nullable<int> value);
    partial void OnFan3MtrRTD_3_TempChanged();
    partial void OnFan4BearingATempChanging(System.Nullable<int> value);
    partial void OnFan4BearingATempChanged();
    partial void OnFan4BearingBTempChanging(System.Nullable<int> value);
    partial void OnFan4BearingBTempChanged();
    partial void OnFan4CBearingMtrTempChanging(System.Nullable<int> value);
    partial void OnFan4CBearingMtrTempChanged();
    partial void OnFan4DBearingMtrTempChanging(System.Nullable<int> value);
    partial void OnFan4DBearingMtrTempChanged();
    partial void OnFan4MtrRTD_1_TempChanging(System.Nullable<int> value);
    partial void OnFan4MtrRTD_1_TempChanged();
    partial void OnFan4MtrRTD_2_TempChanging(System.Nullable<int> value);
    partial void OnFan4MtrRTD_2_TempChanged();
    partial void OnFan4MtrRTD_3_TempChanging(System.Nullable<int> value);
    partial void OnFan4MtrRTD_3_TempChanged();
    partial void OnPSIDifferentialChanging(System.Nullable<decimal> value);
    partial void OnPSIDifferentialChanged();
    #endregion
		
		public BagHouse()
		{
			this._Station = default(EntityRef<Station>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BagHouseRecID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BagHouseRecID
		{
			get
			{
				return this._BagHouseRecID;
			}
			set
			{
				if ((this._BagHouseRecID != value))
				{
					this.OnBagHouseRecIDChanging(value);
					this.SendPropertyChanging();
					this._BagHouseRecID = value;
					this.SendPropertyChanged("BagHouseRecID");
					this.OnBagHouseRecIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationID", DbType="Char(2)")]
		public string StationID
		{
			get
			{
				return this._StationID;
			}
			set
			{
				if ((this._StationID != value))
				{
					if (this._Station.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStationIDChanging(value);
					this.SendPropertyChanging();
					this._StationID = value;
					this.SendPropertyChanged("StationID");
					this.OnStationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan1MTRLoad", DbType="Int")]
		public System.Nullable<int> Fan1MTRLoad
		{
			get
			{
				return this._Fan1MTRLoad;
			}
			set
			{
				if ((this._Fan1MTRLoad != value))
				{
					this.OnFan1MTRLoadChanging(value);
					this.SendPropertyChanging();
					this._Fan1MTRLoad = value;
					this.SendPropertyChanged("Fan1MTRLoad");
					this.OnFan1MTRLoadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan2MTRLoad", DbType="Int")]
		public System.Nullable<int> Fan2MTRLoad
		{
			get
			{
				return this._Fan2MTRLoad;
			}
			set
			{
				if ((this._Fan2MTRLoad != value))
				{
					this.OnFan2MTRLoadChanging(value);
					this.SendPropertyChanging();
					this._Fan2MTRLoad = value;
					this.SendPropertyChanged("Fan2MTRLoad");
					this.OnFan2MTRLoadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan3MTRLoad", DbType="Int")]
		public System.Nullable<int> Fan3MTRLoad
		{
			get
			{
				return this._Fan3MTRLoad;
			}
			set
			{
				if ((this._Fan3MTRLoad != value))
				{
					this.OnFan3MTRLoadChanging(value);
					this.SendPropertyChanging();
					this._Fan3MTRLoad = value;
					this.SendPropertyChanged("Fan3MTRLoad");
					this.OnFan3MTRLoadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan4MTRLoad", DbType="Int")]
		public System.Nullable<int> Fan4MTRLoad
		{
			get
			{
				return this._Fan4MTRLoad;
			}
			set
			{
				if ((this._Fan4MTRLoad != value))
				{
					this.OnFan4MTRLoadChanging(value);
					this.SendPropertyChanging();
					this._Fan4MTRLoad = value;
					this.SendPropertyChanged("Fan4MTRLoad");
					this.OnFan4MTRLoadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdateDate
		{
			get
			{
				return this._UpdateDate;
			}
			set
			{
				if ((this._UpdateDate != value))
				{
					this.OnUpdateDateChanging(value);
					this.SendPropertyChanging();
					this._UpdateDate = value;
					this.SendPropertyChanged("UpdateDate");
					this.OnUpdateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan1BearingATemp", DbType="Int")]
		public System.Nullable<int> Fan1BearingATemp
		{
			get
			{
				return this._Fan1BearingATemp;
			}
			set
			{
				if ((this._Fan1BearingATemp != value))
				{
					this.OnFan1BearingATempChanging(value);
					this.SendPropertyChanging();
					this._Fan1BearingATemp = value;
					this.SendPropertyChanged("Fan1BearingATemp");
					this.OnFan1BearingATempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan1BearingBTemp", DbType="Int")]
		public System.Nullable<int> Fan1BearingBTemp
		{
			get
			{
				return this._Fan1BearingBTemp;
			}
			set
			{
				if ((this._Fan1BearingBTemp != value))
				{
					this.OnFan1BearingBTempChanging(value);
					this.SendPropertyChanging();
					this._Fan1BearingBTemp = value;
					this.SendPropertyChanged("Fan1BearingBTemp");
					this.OnFan1BearingBTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan1CBearingMtrTemp", DbType="Int")]
		public System.Nullable<int> Fan1CBearingMtrTemp
		{
			get
			{
				return this._Fan1CBearingMtrTemp;
			}
			set
			{
				if ((this._Fan1CBearingMtrTemp != value))
				{
					this.OnFan1CBearingMtrTempChanging(value);
					this.SendPropertyChanging();
					this._Fan1CBearingMtrTemp = value;
					this.SendPropertyChanged("Fan1CBearingMtrTemp");
					this.OnFan1CBearingMtrTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan1DBearingMtrTemp", DbType="Int")]
		public System.Nullable<int> Fan1DBearingMtrTemp
		{
			get
			{
				return this._Fan1DBearingMtrTemp;
			}
			set
			{
				if ((this._Fan1DBearingMtrTemp != value))
				{
					this.OnFan1DBearingMtrTempChanging(value);
					this.SendPropertyChanging();
					this._Fan1DBearingMtrTemp = value;
					this.SendPropertyChanged("Fan1DBearingMtrTemp");
					this.OnFan1DBearingMtrTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan1MtrRTD_1_Temp", DbType="Int")]
		public System.Nullable<int> Fan1MtrRTD_1_Temp
		{
			get
			{
				return this._Fan1MtrRTD_1_Temp;
			}
			set
			{
				if ((this._Fan1MtrRTD_1_Temp != value))
				{
					this.OnFan1MtrRTD_1_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan1MtrRTD_1_Temp = value;
					this.SendPropertyChanged("Fan1MtrRTD_1_Temp");
					this.OnFan1MtrRTD_1_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan1MtrRTD_2_Temp", DbType="Int")]
		public System.Nullable<int> Fan1MtrRTD_2_Temp
		{
			get
			{
				return this._Fan1MtrRTD_2_Temp;
			}
			set
			{
				if ((this._Fan1MtrRTD_2_Temp != value))
				{
					this.OnFan1MtrRTD_2_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan1MtrRTD_2_Temp = value;
					this.SendPropertyChanged("Fan1MtrRTD_2_Temp");
					this.OnFan1MtrRTD_2_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan1MtrRTD_3_Temp", DbType="Int")]
		public System.Nullable<int> Fan1MtrRTD_3_Temp
		{
			get
			{
				return this._Fan1MtrRTD_3_Temp;
			}
			set
			{
				if ((this._Fan1MtrRTD_3_Temp != value))
				{
					this.OnFan1MtrRTD_3_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan1MtrRTD_3_Temp = value;
					this.SendPropertyChanged("Fan1MtrRTD_3_Temp");
					this.OnFan1MtrRTD_3_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan2BearingATemp", DbType="Int")]
		public System.Nullable<int> Fan2BearingATemp
		{
			get
			{
				return this._Fan2BearingATemp;
			}
			set
			{
				if ((this._Fan2BearingATemp != value))
				{
					this.OnFan2BearingATempChanging(value);
					this.SendPropertyChanging();
					this._Fan2BearingATemp = value;
					this.SendPropertyChanged("Fan2BearingATemp");
					this.OnFan2BearingATempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan2BearingBTemp", DbType="Int")]
		public System.Nullable<int> Fan2BearingBTemp
		{
			get
			{
				return this._Fan2BearingBTemp;
			}
			set
			{
				if ((this._Fan2BearingBTemp != value))
				{
					this.OnFan2BearingBTempChanging(value);
					this.SendPropertyChanging();
					this._Fan2BearingBTemp = value;
					this.SendPropertyChanged("Fan2BearingBTemp");
					this.OnFan2BearingBTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan2CBearingMtrTemp", DbType="Int")]
		public System.Nullable<int> Fan2CBearingMtrTemp
		{
			get
			{
				return this._Fan2CBearingMtrTemp;
			}
			set
			{
				if ((this._Fan2CBearingMtrTemp != value))
				{
					this.OnFan2CBearingMtrTempChanging(value);
					this.SendPropertyChanging();
					this._Fan2CBearingMtrTemp = value;
					this.SendPropertyChanged("Fan2CBearingMtrTemp");
					this.OnFan2CBearingMtrTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan2DBearingMtrTemp", DbType="Int")]
		public System.Nullable<int> Fan2DBearingMtrTemp
		{
			get
			{
				return this._Fan2DBearingMtrTemp;
			}
			set
			{
				if ((this._Fan2DBearingMtrTemp != value))
				{
					this.OnFan2DBearingMtrTempChanging(value);
					this.SendPropertyChanging();
					this._Fan2DBearingMtrTemp = value;
					this.SendPropertyChanged("Fan2DBearingMtrTemp");
					this.OnFan2DBearingMtrTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan2MtrRTD_1_Temp", DbType="Int")]
		public System.Nullable<int> Fan2MtrRTD_1_Temp
		{
			get
			{
				return this._Fan2MtrRTD_1_Temp;
			}
			set
			{
				if ((this._Fan2MtrRTD_1_Temp != value))
				{
					this.OnFan2MtrRTD_1_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan2MtrRTD_1_Temp = value;
					this.SendPropertyChanged("Fan2MtrRTD_1_Temp");
					this.OnFan2MtrRTD_1_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan2MtrRTD_2_Temp", DbType="Int")]
		public System.Nullable<int> Fan2MtrRTD_2_Temp
		{
			get
			{
				return this._Fan2MtrRTD_2_Temp;
			}
			set
			{
				if ((this._Fan2MtrRTD_2_Temp != value))
				{
					this.OnFan2MtrRTD_2_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan2MtrRTD_2_Temp = value;
					this.SendPropertyChanged("Fan2MtrRTD_2_Temp");
					this.OnFan2MtrRTD_2_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan2MtrRTD_3_Temp", DbType="Int")]
		public System.Nullable<int> Fan2MtrRTD_3_Temp
		{
			get
			{
				return this._Fan2MtrRTD_3_Temp;
			}
			set
			{
				if ((this._Fan2MtrRTD_3_Temp != value))
				{
					this.OnFan2MtrRTD_3_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan2MtrRTD_3_Temp = value;
					this.SendPropertyChanged("Fan2MtrRTD_3_Temp");
					this.OnFan2MtrRTD_3_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan3BearingATemp", DbType="Int")]
		public System.Nullable<int> Fan3BearingATemp
		{
			get
			{
				return this._Fan3BearingATemp;
			}
			set
			{
				if ((this._Fan3BearingATemp != value))
				{
					this.OnFan3BearingATempChanging(value);
					this.SendPropertyChanging();
					this._Fan3BearingATemp = value;
					this.SendPropertyChanged("Fan3BearingATemp");
					this.OnFan3BearingATempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan3BearingBTemp", DbType="Int")]
		public System.Nullable<int> Fan3BearingBTemp
		{
			get
			{
				return this._Fan3BearingBTemp;
			}
			set
			{
				if ((this._Fan3BearingBTemp != value))
				{
					this.OnFan3BearingBTempChanging(value);
					this.SendPropertyChanging();
					this._Fan3BearingBTemp = value;
					this.SendPropertyChanged("Fan3BearingBTemp");
					this.OnFan3BearingBTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan3CBearingMtrTemp", DbType="Int")]
		public System.Nullable<int> Fan3CBearingMtrTemp
		{
			get
			{
				return this._Fan3CBearingMtrTemp;
			}
			set
			{
				if ((this._Fan3CBearingMtrTemp != value))
				{
					this.OnFan3CBearingMtrTempChanging(value);
					this.SendPropertyChanging();
					this._Fan3CBearingMtrTemp = value;
					this.SendPropertyChanged("Fan3CBearingMtrTemp");
					this.OnFan3CBearingMtrTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan3DBearingMtrTemp", DbType="Int")]
		public System.Nullable<int> Fan3DBearingMtrTemp
		{
			get
			{
				return this._Fan3DBearingMtrTemp;
			}
			set
			{
				if ((this._Fan3DBearingMtrTemp != value))
				{
					this.OnFan3DBearingMtrTempChanging(value);
					this.SendPropertyChanging();
					this._Fan3DBearingMtrTemp = value;
					this.SendPropertyChanged("Fan3DBearingMtrTemp");
					this.OnFan3DBearingMtrTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan3MtrRTD_1_Temp", DbType="Int")]
		public System.Nullable<int> Fan3MtrRTD_1_Temp
		{
			get
			{
				return this._Fan3MtrRTD_1_Temp;
			}
			set
			{
				if ((this._Fan3MtrRTD_1_Temp != value))
				{
					this.OnFan3MtrRTD_1_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan3MtrRTD_1_Temp = value;
					this.SendPropertyChanged("Fan3MtrRTD_1_Temp");
					this.OnFan3MtrRTD_1_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan3MtrRTD_2_Temp", DbType="Int")]
		public System.Nullable<int> Fan3MtrRTD_2_Temp
		{
			get
			{
				return this._Fan3MtrRTD_2_Temp;
			}
			set
			{
				if ((this._Fan3MtrRTD_2_Temp != value))
				{
					this.OnFan3MtrRTD_2_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan3MtrRTD_2_Temp = value;
					this.SendPropertyChanged("Fan3MtrRTD_2_Temp");
					this.OnFan3MtrRTD_2_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan3MtrRTD_3_Temp", DbType="Int")]
		public System.Nullable<int> Fan3MtrRTD_3_Temp
		{
			get
			{
				return this._Fan3MtrRTD_3_Temp;
			}
			set
			{
				if ((this._Fan3MtrRTD_3_Temp != value))
				{
					this.OnFan3MtrRTD_3_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan3MtrRTD_3_Temp = value;
					this.SendPropertyChanged("Fan3MtrRTD_3_Temp");
					this.OnFan3MtrRTD_3_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan4BearingATemp", DbType="Int")]
		public System.Nullable<int> Fan4BearingATemp
		{
			get
			{
				return this._Fan4BearingATemp;
			}
			set
			{
				if ((this._Fan4BearingATemp != value))
				{
					this.OnFan4BearingATempChanging(value);
					this.SendPropertyChanging();
					this._Fan4BearingATemp = value;
					this.SendPropertyChanged("Fan4BearingATemp");
					this.OnFan4BearingATempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan4BearingBTemp", DbType="Int")]
		public System.Nullable<int> Fan4BearingBTemp
		{
			get
			{
				return this._Fan4BearingBTemp;
			}
			set
			{
				if ((this._Fan4BearingBTemp != value))
				{
					this.OnFan4BearingBTempChanging(value);
					this.SendPropertyChanging();
					this._Fan4BearingBTemp = value;
					this.SendPropertyChanged("Fan4BearingBTemp");
					this.OnFan4BearingBTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan4CBearingMtrTemp", DbType="Int")]
		public System.Nullable<int> Fan4CBearingMtrTemp
		{
			get
			{
				return this._Fan4CBearingMtrTemp;
			}
			set
			{
				if ((this._Fan4CBearingMtrTemp != value))
				{
					this.OnFan4CBearingMtrTempChanging(value);
					this.SendPropertyChanging();
					this._Fan4CBearingMtrTemp = value;
					this.SendPropertyChanged("Fan4CBearingMtrTemp");
					this.OnFan4CBearingMtrTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan4DBearingMtrTemp", DbType="Int")]
		public System.Nullable<int> Fan4DBearingMtrTemp
		{
			get
			{
				return this._Fan4DBearingMtrTemp;
			}
			set
			{
				if ((this._Fan4DBearingMtrTemp != value))
				{
					this.OnFan4DBearingMtrTempChanging(value);
					this.SendPropertyChanging();
					this._Fan4DBearingMtrTemp = value;
					this.SendPropertyChanged("Fan4DBearingMtrTemp");
					this.OnFan4DBearingMtrTempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan4MtrRTD_1_Temp", DbType="Int")]
		public System.Nullable<int> Fan4MtrRTD_1_Temp
		{
			get
			{
				return this._Fan4MtrRTD_1_Temp;
			}
			set
			{
				if ((this._Fan4MtrRTD_1_Temp != value))
				{
					this.OnFan4MtrRTD_1_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan4MtrRTD_1_Temp = value;
					this.SendPropertyChanged("Fan4MtrRTD_1_Temp");
					this.OnFan4MtrRTD_1_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan4MtrRTD_2_Temp", DbType="Int")]
		public System.Nullable<int> Fan4MtrRTD_2_Temp
		{
			get
			{
				return this._Fan4MtrRTD_2_Temp;
			}
			set
			{
				if ((this._Fan4MtrRTD_2_Temp != value))
				{
					this.OnFan4MtrRTD_2_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan4MtrRTD_2_Temp = value;
					this.SendPropertyChanged("Fan4MtrRTD_2_Temp");
					this.OnFan4MtrRTD_2_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fan4MtrRTD_3_Temp", DbType="Int")]
		public System.Nullable<int> Fan4MtrRTD_3_Temp
		{
			get
			{
				return this._Fan4MtrRTD_3_Temp;
			}
			set
			{
				if ((this._Fan4MtrRTD_3_Temp != value))
				{
					this.OnFan4MtrRTD_3_TempChanging(value);
					this.SendPropertyChanging();
					this._Fan4MtrRTD_3_Temp = value;
					this.SendPropertyChanged("Fan4MtrRTD_3_Temp");
					this.OnFan4MtrRTD_3_TempChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PSIDifferential", DbType="Decimal(9,6)")]
		public System.Nullable<decimal> PSIDifferential
		{
			get
			{
				return this._PSIDifferential;
			}
			set
			{
				if ((this._PSIDifferential != value))
				{
					this.OnPSIDifferentialChanging(value);
					this.SendPropertyChanging();
					this._PSIDifferential = value;
					this.SendPropertyChanged("PSIDifferential");
					this.OnPSIDifferentialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Station_BagHouse", Storage="_Station", ThisKey="StationID", OtherKey="StationID", IsForeignKey=true)]
		public Station Station
		{
			get
			{
				return this._Station.Entity;
			}
			set
			{
				Station previousValue = this._Station.Entity;
				if (((previousValue != value) 
							|| (this._Station.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Station.Entity = null;
						previousValue.BagHouses.Remove(this);
					}
					this._Station.Entity = value;
					if ((value != null))
					{
						value.BagHouses.Add(this);
						this._StationID = value.StationID;
					}
					else
					{
						this._StationID = default(string);
					}
					this.SendPropertyChanged("Station");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Station")]
	public partial class Station : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _StationID;
		
		private string _StationName;
		
		private string _DefaultPrinter;
		
		private EntitySet<BagHouse> _BagHouses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStationIDChanging(string value);
    partial void OnStationIDChanged();
    partial void OnStationNameChanging(string value);
    partial void OnStationNameChanged();
    partial void OnDefaultPrinterChanging(string value);
    partial void OnDefaultPrinterChanged();
    #endregion
		
		public Station()
		{
			this._BagHouses = new EntitySet<BagHouse>(new Action<BagHouse>(this.attach_BagHouses), new Action<BagHouse>(this.detach_BagHouses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationID", DbType="Char(2) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string StationID
		{
			get
			{
				return this._StationID;
			}
			set
			{
				if ((this._StationID != value))
				{
					this.OnStationIDChanging(value);
					this.SendPropertyChanging();
					this._StationID = value;
					this.SendPropertyChanged("StationID");
					this.OnStationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationName", DbType="VarChar(50)")]
		public string StationName
		{
			get
			{
				return this._StationName;
			}
			set
			{
				if ((this._StationName != value))
				{
					this.OnStationNameChanging(value);
					this.SendPropertyChanging();
					this._StationName = value;
					this.SendPropertyChanged("StationName");
					this.OnStationNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DefaultPrinter", DbType="VarChar(50)")]
		public string DefaultPrinter
		{
			get
			{
				return this._DefaultPrinter;
			}
			set
			{
				if ((this._DefaultPrinter != value))
				{
					this.OnDefaultPrinterChanging(value);
					this.SendPropertyChanging();
					this._DefaultPrinter = value;
					this.SendPropertyChanged("DefaultPrinter");
					this.OnDefaultPrinterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Station_BagHouse", Storage="_BagHouses", ThisKey="StationID", OtherKey="StationID")]
		public EntitySet<BagHouse> BagHouses
		{
			get
			{
				return this._BagHouses;
			}
			set
			{
				this._BagHouses.Assign(value);
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
		
		private void attach_BagHouses(BagHouse entity)
		{
			this.SendPropertyChanging();
			entity.Station = this;
		}
		
		private void detach_BagHouses(BagHouse entity)
		{
			this.SendPropertyChanging();
			entity.Station = null;
		}
	}
}
#pragma warning restore 1591
