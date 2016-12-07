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

namespace mega_book
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
    using System.Globalization;
    using Newtonsoft.Json;

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="mega-book")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertReview(Review instance);
    partial void UpdateReview(Review instance);
    partial void DeleteReview(Review instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["mega_bookConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<Review> Reviews
		{
			get
			{
				return this.GetTable<Review>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _name;
		
		private System.DateTime _releaseDate;
		
		private string _content;
		
		private string _isbn;
		
		private EntitySet<Review> _Reviews;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnreleaseDateChanging(System.DateTime value);
    partial void OnreleaseDateChanged();
    partial void OncontentChanging(string value);
    partial void OncontentChanged();
    partial void OnisbnChanging(string value);
    partial void OnisbnChanged();
    #endregion
		
		public Book()
		{
			this._Reviews = new EntitySet<Review>(new Action<Review>(this.attach_Reviews), new Action<Review>(this.detach_Reviews));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_releaseDate", DbType="Date NOT NULL")]
		public System.DateTime releaseDate
		{
			get
			{
				return this._releaseDate;
			}
			set
			{
				if ((this._releaseDate != value))
				{
					this.OnreleaseDateChanging(value);
					this.SendPropertyChanging();
					this._releaseDate = value;
					this.SendPropertyChanged("releaseDate");
					this.OnreleaseDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_content", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string content
		{
			get
			{
				return this._content;
			}
			set
			{
				if ((this._content != value))
				{
					this.OncontentChanging(value);
					this.SendPropertyChanging();
					this._content = value;
					this.SendPropertyChanged("content");
					this.OncontentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isbn", DbType="Char(13) NOT NULL", CanBeNull=false)]
		public string isbn
		{
			get
			{
				return this._isbn;
			}
			set
			{
				if ((this._isbn != value))
				{
					this.OnisbnChanging(value);
					this.SendPropertyChanging();
					this._isbn = value;
					this.SendPropertyChanged("isbn");
					this.OnisbnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Review", Storage="_Reviews", ThisKey="Id", OtherKey="bookId")]
		public EntitySet<Review> Reviews
		{
			get
			{
				return this._Reviews;
			}
			set
			{
				this._Reviews.Assign(value);
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
		
		private void attach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_Reviews(Review entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Review")]
	public partial class Review : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _reviewerName;
		
		private System.DateTime _reviewDate;
		
		private string _content;
		
		private int _rating;
		
		private int _bookId;
		
		private EntityRef<Book> _Book;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnreviewerNameChanging(string value);
    partial void OnreviewerNameChanged();
    partial void OnreviewDateChanging(System.DateTime value);
    partial void OnreviewDateChanged();
    partial void OncontentChanging(string value);
    partial void OncontentChanged();
    partial void OnratingChanging(int value);
    partial void OnratingChanged();
    partial void OnbookIdChanging(int value);
    partial void OnbookIdChanged();
    #endregion
		
		public Review()
		{
			this._Book = default(EntityRef<Book>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reviewerName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string reviewerName
		{
			get
			{
				return this._reviewerName;
			}
			set
			{
				if ((this._reviewerName != value))
				{
					this.OnreviewerNameChanging(value);
					this.SendPropertyChanging();
					this._reviewerName = value;
					this.SendPropertyChanged("reviewerName");
					this.OnreviewerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reviewDate", DbType="Date NOT NULL")]
		public System.DateTime reviewDate
		{
			get
			{
				return this._reviewDate;
			}
			set
			{
				if ((this._reviewDate != value))
				{
					this.OnreviewDateChanging(value);
					this.SendPropertyChanging();
					this._reviewDate = value;
					this.SendPropertyChanged("reviewDate");
					this.OnreviewDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_content", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string content
		{
			get
			{
				return this._content;
			}
			set
			{
				if ((this._content != value))
				{
					this.OncontentChanging(value);
					this.SendPropertyChanging();
					this._content = value;
					this.SendPropertyChanged("content");
					this.OncontentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rating", DbType="Int NOT NULL")]
		public int rating
		{
			get
			{
				return this._rating;
			}
			set
			{
				if ((this._rating != value))
				{
					this.OnratingChanging(value);
					this.SendPropertyChanging();
					this._rating = value;
					this.SendPropertyChanged("rating");
					this.OnratingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookId", DbType="Int NOT NULL")]
		public int bookId
		{
			get
			{
				return this._bookId;
			}
			set
			{
				if ((this._bookId != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnbookIdChanging(value);
					this.SendPropertyChanging();
					this._bookId = value;
					this.SendPropertyChanged("bookId");
					this.OnbookIdChanged();
				}
			}
		}
		
        [JsonIgnore]
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Review", Storage="_Book", ThisKey="bookId", OtherKey="Id", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.Reviews.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.Reviews.Add(this);
						this._bookId = value.Id;
					}
					else
					{
						this._bookId = default(int);
					}
					this.SendPropertyChanged("Book");
				}
			}
		}

        public override string ToString()
        {
            return $"ID: {_Id}, ReviewerName: {_reviewerName}, ReviewDate: {_reviewDate}, Rating: {_rating}, BookId: {_bookId}";
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

    //public class ReviewConverter : TypeConverter
    //{
    //    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    //    {
    //        if (sourceType == typeof(string))
    //            return true;

    //        return base.CanConvertFrom(context, sourceType);
    //    }

    //    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    //    {
    //        if (value is string)
    //        {
    //            Review review;

    //            if (Review.TryParse((string)value, out review))
    //            {
    //                return review;
    //            }
    //        }
    //        return base.ConvertFrom(context, culture, value);
    //    }
    //}

}
#pragma warning restore 1591
