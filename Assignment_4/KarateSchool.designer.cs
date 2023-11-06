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

namespace Assignment_4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="KarateSchool")]
	public partial class KarateSchoolDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertInstructor(Instructor instance);
    partial void UpdateInstructor(Instructor instance);
    partial void DeleteInstructor(Instructor instance);
    #endregion
		
		public KarateSchoolDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["KarateSchoolConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KarateSchoolDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KarateSchoolDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KarateSchoolDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KarateSchoolDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Instructor> Instructors
		{
			get
			{
				return this.GetTable<Instructor>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Instructor")]
	public partial class Instructor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _InstructorID;
		
		private string _InstructorFirstName;
		
		private string _InstructorLastName;
		
		private string _InstructorPhoneNumber;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnInstructorIDChanging(int value);
    partial void OnInstructorIDChanged();
    partial void OnInstructorFirstNameChanging(string value);
    partial void OnInstructorFirstNameChanged();
    partial void OnInstructorLastNameChanging(string value);
    partial void OnInstructorLastNameChanged();
    partial void OnInstructorPhoneNumberChanging(string value);
    partial void OnInstructorPhoneNumberChanged();
    #endregion
		
		public Instructor()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstructorID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int InstructorID
		{
			get
			{
				return this._InstructorID;
			}
			set
			{
				if ((this._InstructorID != value))
				{
					this.OnInstructorIDChanging(value);
					this.SendPropertyChanging();
					this._InstructorID = value;
					this.SendPropertyChanged("InstructorID");
					this.OnInstructorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstructorFirstName", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string InstructorFirstName
		{
			get
			{
				return this._InstructorFirstName;
			}
			set
			{
				if ((this._InstructorFirstName != value))
				{
					this.OnInstructorFirstNameChanging(value);
					this.SendPropertyChanging();
					this._InstructorFirstName = value;
					this.SendPropertyChanged("InstructorFirstName");
					this.OnInstructorFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstructorLastName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string InstructorLastName
		{
			get
			{
				return this._InstructorLastName;
			}
			set
			{
				if ((this._InstructorLastName != value))
				{
					this.OnInstructorLastNameChanging(value);
					this.SendPropertyChanging();
					this._InstructorLastName = value;
					this.SendPropertyChanged("InstructorLastName");
					this.OnInstructorLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstructorPhoneNumber", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string InstructorPhoneNumber
		{
			get
			{
				return this._InstructorPhoneNumber;
			}
			set
			{
				if ((this._InstructorPhoneNumber != value))
				{
					this.OnInstructorPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._InstructorPhoneNumber = value;
					this.SendPropertyChanged("InstructorPhoneNumber");
					this.OnInstructorPhoneNumberChanged();
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
}
#pragma warning restore 1591
