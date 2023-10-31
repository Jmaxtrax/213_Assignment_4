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
    partial void InsertMember(Member instance);
    partial void UpdateMember(Member instance);
    partial void DeleteMember(Member instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertSection(Section instance);
    partial void UpdateSection(Section instance);
    partial void DeleteSection(Section instance);
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
		
		public System.Data.Linq.Table<Member> Members
		{
			get
			{
				return this.GetTable<Member>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Section> Sections
		{
			get
			{
				return this.GetTable<Section>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Instructor")]
	public partial class Instructor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _User_UserID;
		
		private string _InstructorFirstName;
		
		private string _InstructorLastName;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_UserIDChanging(int value);
    partial void OnUser_UserIDChanged();
    partial void OnInstructorFirstNameChanging(string value);
    partial void OnInstructorFirstNameChanged();
    partial void OnInstructorLastNameChanging(string value);
    partial void OnInstructorLastNameChanged();
    #endregion
		
		public Instructor()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_UserID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int User_UserID
		{
			get
			{
				return this._User_UserID;
			}
			set
			{
				if ((this._User_UserID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_UserIDChanging(value);
					this.SendPropertyChanging();
					this._User_UserID = value;
					this.SendPropertyChanged("User_UserID");
					this.OnUser_UserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InstructorFirstName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Instructor", Storage="_User", ThisKey="User_UserID", OtherKey="UserID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Instructors.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Instructors.Add(this);
						this._User_UserID = value.UserID;
					}
					else
					{
						this._User_UserID = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Member")]
	public partial class Member : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _User_UserID;
		
		private string _MemberFirstName;
		
		private string _MemberLastName;
		
		private System.DateTime _MemberDateJoined;
		
		private string _MemberPhoneNumber;
		
		private string _MemberEmail;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_UserIDChanging(int value);
    partial void OnUser_UserIDChanged();
    partial void OnMemberFirstNameChanging(string value);
    partial void OnMemberFirstNameChanged();
    partial void OnMemberLastNameChanging(string value);
    partial void OnMemberLastNameChanged();
    partial void OnMemberDateJoinedChanging(System.DateTime value);
    partial void OnMemberDateJoinedChanged();
    partial void OnMemberPhoneNumberChanging(string value);
    partial void OnMemberPhoneNumberChanged();
    partial void OnMemberEmailChanging(string value);
    partial void OnMemberEmailChanged();
    #endregion
		
		public Member()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_UserID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int User_UserID
		{
			get
			{
				return this._User_UserID;
			}
			set
			{
				if ((this._User_UserID != value))
				{
					this.OnUser_UserIDChanging(value);
					this.SendPropertyChanging();
					this._User_UserID = value;
					this.SendPropertyChanged("User_UserID");
					this.OnUser_UserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberFirstName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string MemberFirstName
		{
			get
			{
				return this._MemberFirstName;
			}
			set
			{
				if ((this._MemberFirstName != value))
				{
					this.OnMemberFirstNameChanging(value);
					this.SendPropertyChanging();
					this._MemberFirstName = value;
					this.SendPropertyChanged("MemberFirstName");
					this.OnMemberFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberLastName", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string MemberLastName
		{
			get
			{
				return this._MemberLastName;
			}
			set
			{
				if ((this._MemberLastName != value))
				{
					this.OnMemberLastNameChanging(value);
					this.SendPropertyChanging();
					this._MemberLastName = value;
					this.SendPropertyChanged("MemberLastName");
					this.OnMemberLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberDateJoined", DbType="DateTime NOT NULL")]
		public System.DateTime MemberDateJoined
		{
			get
			{
				return this._MemberDateJoined;
			}
			set
			{
				if ((this._MemberDateJoined != value))
				{
					this.OnMemberDateJoinedChanging(value);
					this.SendPropertyChanging();
					this._MemberDateJoined = value;
					this.SendPropertyChanged("MemberDateJoined");
					this.OnMemberDateJoinedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberPhoneNumber", DbType="VarChar(25) NOT NULL", CanBeNull=false)]
		public string MemberPhoneNumber
		{
			get
			{
				return this._MemberPhoneNumber;
			}
			set
			{
				if ((this._MemberPhoneNumber != value))
				{
					this.OnMemberPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._MemberPhoneNumber = value;
					this.SendPropertyChanged("MemberPhoneNumber");
					this.OnMemberPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberEmail", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string MemberEmail
		{
			get
			{
				return this._MemberEmail;
			}
			set
			{
				if ((this._MemberEmail != value))
				{
					this.OnMemberEmailChanging(value);
					this.SendPropertyChanging();
					this._MemberEmail = value;
					this.SendPropertyChanged("MemberEmail");
					this.OnMemberEmailChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _UserName;
		
		private string _UserPassword;
		
		private string _UserType;
		
		private EntitySet<Instructor> _Instructors;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnUserPasswordChanging(string value);
    partial void OnUserPasswordChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    #endregion
		
		public User()
		{
			this._Instructors = new EntitySet<Instructor>(new Action<Instructor>(this.attach_Instructors), new Action<Instructor>(this.detach_Instructors));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPassword", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string UserPassword
		{
			get
			{
				return this._UserPassword;
			}
			set
			{
				if ((this._UserPassword != value))
				{
					this.OnUserPasswordChanging(value);
					this.SendPropertyChanging();
					this._UserPassword = value;
					this.SendPropertyChanged("UserPassword");
					this.OnUserPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Instructor", Storage="_Instructors", ThisKey="UserID", OtherKey="User_UserID")]
		public EntitySet<Instructor> Instructors
		{
			get
			{
				return this._Instructors;
			}
			set
			{
				this._Instructors.Assign(value);
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
		
		private void attach_Instructors(Instructor entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Instructors(Instructor entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Section")]
	public partial class Section : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SectionID;
		
		private string _SectionName;
		
		private System.DateTime _SectionDate;
		
		private int _Member_User_UserID;
		
		private int _Instructor_User_UserID;
		
		private decimal _SectionFee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSectionIDChanging(int value);
    partial void OnSectionIDChanged();
    partial void OnSectionNameChanging(string value);
    partial void OnSectionNameChanged();
    partial void OnSectionDateChanging(System.DateTime value);
    partial void OnSectionDateChanged();
    partial void OnMember_User_UserIDChanging(int value);
    partial void OnMember_User_UserIDChanged();
    partial void OnInstructor_User_UserIDChanging(int value);
    partial void OnInstructor_User_UserIDChanged();
    partial void OnSectionFeeChanging(decimal value);
    partial void OnSectionFeeChanged();
    #endregion
		
		public Section()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SectionID
		{
			get
			{
				return this._SectionID;
			}
			set
			{
				if ((this._SectionID != value))
				{
					this.OnSectionIDChanging(value);
					this.SendPropertyChanging();
					this._SectionID = value;
					this.SendPropertyChanged("SectionID");
					this.OnSectionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SectionName
		{
			get
			{
				return this._SectionName;
			}
			set
			{
				if ((this._SectionName != value))
				{
					this.OnSectionNameChanging(value);
					this.SendPropertyChanging();
					this._SectionName = value;
					this.SendPropertyChanged("SectionName");
					this.OnSectionNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionDate", DbType="DateTime NOT NULL")]
		public System.DateTime SectionDate
		{
			get
			{
				return this._SectionDate;
			}
			set
			{
				if ((this._SectionDate != value))
				{
					this.OnSectionDateChanging(value);
					this.SendPropertyChanging();
					this._SectionDate = value;
					this.SendPropertyChanged("SectionDate");
					this.OnSectionDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Member_User_UserID", DbType="Int NOT NULL")]
		public int Member_User_UserID
		{
			get
			{
				return this._Member_User_UserID;
			}
			set
			{
				if ((this._Member_User_UserID != value))
				{
					this.OnMember_User_UserIDChanging(value);
					this.SendPropertyChanging();
					this._Member_User_UserID = value;
					this.SendPropertyChanged("Member_User_UserID");
					this.OnMember_User_UserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Instructor_User_UserID", DbType="Int NOT NULL")]
		public int Instructor_User_UserID
		{
			get
			{
				return this._Instructor_User_UserID;
			}
			set
			{
				if ((this._Instructor_User_UserID != value))
				{
					this.OnInstructor_User_UserIDChanging(value);
					this.SendPropertyChanging();
					this._Instructor_User_UserID = value;
					this.SendPropertyChanged("Instructor_User_UserID");
					this.OnInstructor_User_UserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionFee", DbType="Decimal(6,2) NOT NULL")]
		public decimal SectionFee
		{
			get
			{
				return this._SectionFee;
			}
			set
			{
				if ((this._SectionFee != value))
				{
					this.OnSectionFeeChanging(value);
					this.SendPropertyChanging();
					this._SectionFee = value;
					this.SendPropertyChanged("SectionFee");
					this.OnSectionFeeChanged();
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
