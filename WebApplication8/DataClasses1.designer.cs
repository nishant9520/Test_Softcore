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

namespace WebApplication8
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="demo1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["demo1ConnectionString"].ConnectionString, mappingSource)
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
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Save_Customer_Details")]
		public ISingleResult<Save_Customer_DetailsResult> Save_Customer_Details([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Create_Date", DbType="Date")] System.Nullable<System.DateTime> create_Date, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Mobile_Number", DbType="VarChar(20)")] string mobile_Number, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Delivery_date", DbType="Date")] System.Nullable<System.DateTime> delivery_date)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), create_Date, mobile_Number, delivery_date);
			return ((ISingleResult<Save_Customer_DetailsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.get_customer")]
		public ISingleResult<get_customerResult> get_customer()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<get_customerResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Delete_item")]
		public ISingleResult<Delete_itemResult> Delete_item([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> item_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), item_id);
			return ((ISingleResult<Delete_itemResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Save_item")]
		public ISingleResult<Save_itemResult> Save_item([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> customer_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string item_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Number_of_item", DbType="Int")] System.Nullable<int> number_of_item, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> item_price, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Float")] System.Nullable<double> total_Amount, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Bill_id", DbType="VarChar(10)")] string bill_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), customer_id, item_Name, number_of_item, item_price, total_Amount, bill_id);
			return ((ISingleResult<Save_itemResult>)(result.ReturnValue));
		}
	}
	
	public partial class Save_Customer_DetailsResult
	{
		
		private int _id;
		
		private string _Create_Date;
		
		private string _Mobile_Number;
		
		private string _Delivery_date;
		
		public Save_Customer_DetailsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Create_Date", DbType="NVarChar(30)")]
		public string Create_Date
		{
			get
			{
				return this._Create_Date;
			}
			set
			{
				if ((this._Create_Date != value))
				{
					this._Create_Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile_Number", DbType="VarChar(50)")]
		public string Mobile_Number
		{
			get
			{
				return this._Mobile_Number;
			}
			set
			{
				if ((this._Mobile_Number != value))
				{
					this._Mobile_Number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Delivery_date", DbType="NVarChar(30)")]
		public string Delivery_date
		{
			get
			{
				return this._Delivery_date;
			}
			set
			{
				if ((this._Delivery_date != value))
				{
					this._Delivery_date = value;
				}
			}
		}
	}
	
	public partial class get_customerResult
	{
		
		private int _id;
		
		private string _Create_Date;
		
		private string _Mobile_Number;
		
		private string _Delivery_date;
		
		public get_customerResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Create_Date", DbType="NVarChar(30)")]
		public string Create_Date
		{
			get
			{
				return this._Create_Date;
			}
			set
			{
				if ((this._Create_Date != value))
				{
					this._Create_Date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile_Number", DbType="VarChar(50)")]
		public string Mobile_Number
		{
			get
			{
				return this._Mobile_Number;
			}
			set
			{
				if ((this._Mobile_Number != value))
				{
					this._Mobile_Number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Delivery_date", DbType="NVarChar(30)")]
		public string Delivery_date
		{
			get
			{
				return this._Delivery_date;
			}
			set
			{
				if ((this._Delivery_date != value))
				{
					this._Delivery_date = value;
				}
			}
		}
	}
	
	public partial class Delete_itemResult
	{
		
		private int _id;
		
		private System.Nullable<int> _customer_id;
		
		private string _Bil_Number;
		
		private string _item_Name;
		
		private System.Nullable<int> _Number_of_item;
		
		private System.Nullable<double> _item_price;
		
		private System.Nullable<double> _total_Amount;
		
		public Delete_itemResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="Int")]
		public System.Nullable<int> customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					this._customer_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bil_Number", DbType="VarChar(50)")]
		public string Bil_Number
		{
			get
			{
				return this._Bil_Number;
			}
			set
			{
				if ((this._Bil_Number != value))
				{
					this._Bil_Number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_Name", DbType="VarChar(50)")]
		public string item_Name
		{
			get
			{
				return this._item_Name;
			}
			set
			{
				if ((this._item_Name != value))
				{
					this._item_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Number_of_item", DbType="Int")]
		public System.Nullable<int> Number_of_item
		{
			get
			{
				return this._Number_of_item;
			}
			set
			{
				if ((this._Number_of_item != value))
				{
					this._Number_of_item = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_price", DbType="Float")]
		public System.Nullable<double> item_price
		{
			get
			{
				return this._item_price;
			}
			set
			{
				if ((this._item_price != value))
				{
					this._item_price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_Amount", DbType="Float")]
		public System.Nullable<double> total_Amount
		{
			get
			{
				return this._total_Amount;
			}
			set
			{
				if ((this._total_Amount != value))
				{
					this._total_Amount = value;
				}
			}
		}
	}
	
	public partial class Save_itemResult
	{
		
		private int _id;
		
		private System.Nullable<int> _customer_id;
		
		private string _Bil_Number;
		
		private string _item_Name;
		
		private System.Nullable<int> _Number_of_item;
		
		private System.Nullable<double> _item_price;
		
		private System.Nullable<double> _total_Amount;
		
		public Save_itemResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL")]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customer_id", DbType="Int")]
		public System.Nullable<int> customer_id
		{
			get
			{
				return this._customer_id;
			}
			set
			{
				if ((this._customer_id != value))
				{
					this._customer_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bil_Number", DbType="VarChar(50)")]
		public string Bil_Number
		{
			get
			{
				return this._Bil_Number;
			}
			set
			{
				if ((this._Bil_Number != value))
				{
					this._Bil_Number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_Name", DbType="VarChar(50)")]
		public string item_Name
		{
			get
			{
				return this._item_Name;
			}
			set
			{
				if ((this._item_Name != value))
				{
					this._item_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Number_of_item", DbType="Int")]
		public System.Nullable<int> Number_of_item
		{
			get
			{
				return this._Number_of_item;
			}
			set
			{
				if ((this._Number_of_item != value))
				{
					this._Number_of_item = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_item_price", DbType="Float")]
		public System.Nullable<double> item_price
		{
			get
			{
				return this._item_price;
			}
			set
			{
				if ((this._item_price != value))
				{
					this._item_price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_total_Amount", DbType="Float")]
		public System.Nullable<double> total_Amount
		{
			get
			{
				return this._total_Amount;
			}
			set
			{
				if ((this._total_Amount != value))
				{
					this._total_Amount = value;
				}
			}
		}
	}
}
#pragma warning restore 1591