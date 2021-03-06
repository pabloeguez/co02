/*
'===============================================================================
'  Generated From - CSharp_dOOdads_View.vbgen
'
'  The supporting base class SqlClientEntity is in the 
'  Architecture directory in "dOOdads".
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace cfd.FacturaElectronica
{
	public class vwCfdCompannias : SqlClientEntity
	{
		public vwCfdCompannias()
		{
			this.QuerySource = "vwCfdCompannias";
			this.MappingName = "vwCfdCompannias";
		}	

		//14/12/10 jcf Crea constructor con cadena de conexi�n
		public vwCfdCompannias(string connstr)
		{
			this.ConnectionString = connstr;
			this.QuerySource = "vwCfdCompannias";
			this.MappingName = "vwCfdCompannias";
		}	

		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			return base.Query.Load();
		}
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
	
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter CMPANYID
			{
				get
				{
					return new SqlParameter("@CMPANYID", SqlDbType.SmallInt, 0);
				}
			}
			
			public static SqlParameter INTERID
			{
				get
				{
					return new SqlParameter("@INTERID", SqlDbType.Char, 5);
				}
			}
			
			public static SqlParameter CMPNYNAM
			{
				get
				{
					return new SqlParameter("@CMPNYNAM", SqlDbType.Char, 65);
				}
			}
			
			public static SqlParameter CCode
			{
				get
				{
					return new SqlParameter("@CCode", SqlDbType.Char, 7);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string CMPANYID = "CMPANYID";
            public const string INTERID = "INTERID";
            public const string CMPNYNAM = "CMPNYNAM";
            public const string CCode = "CCode";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CMPANYID] = vwCfdCompannias.PropertyNames.CMPANYID;
					ht[INTERID] = vwCfdCompannias.PropertyNames.INTERID;
					ht[CMPNYNAM] = vwCfdCompannias.PropertyNames.CMPNYNAM;
					ht[CCode] = vwCfdCompannias.PropertyNames.CCode;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string CMPANYID = "CMPANYID";
            public const string INTERID = "INTERID";
            public const string CMPNYNAM = "CMPNYNAM";
            public const string CCode = "CCode";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[CMPANYID] = vwCfdCompannias.ColumnNames.CMPANYID;
					ht[INTERID] = vwCfdCompannias.ColumnNames.INTERID;
					ht[CMPNYNAM] = vwCfdCompannias.ColumnNames.CMPNYNAM;
					ht[CCode] = vwCfdCompannias.ColumnNames.CCode;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string CMPANYID = "s_CMPANYID";
            public const string INTERID = "s_INTERID";
            public const string CMPNYNAM = "s_CMPNYNAM";
            public const string CCode = "s_CCode";

		}
		#endregion	
		
		#region Properties
			public virtual short CMPANYID
	    {
			get
	        {
				return base.Getshort(ColumnNames.CMPANYID);
			}
			set
	        {
				base.Setshort(ColumnNames.CMPANYID, value);
			}
		}

		public virtual string INTERID
	    {
			get
	        {
				return base.Getstring(ColumnNames.INTERID);
			}
			set
	        {
				base.Setstring(ColumnNames.INTERID, value);
			}
		}

		public virtual string CMPNYNAM
	    {
			get
	        {
				return base.Getstring(ColumnNames.CMPNYNAM);
			}
			set
	        {
				base.Setstring(ColumnNames.CMPNYNAM, value);
			}
		}

		public virtual string CCode
	    {
			get
	        {
				return base.Getstring(ColumnNames.CCode);
			}
			set
	        {
				base.Setstring(ColumnNames.CCode, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_CMPANYID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CMPANYID) ? string.Empty : base.GetshortAsString(ColumnNames.CMPANYID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CMPANYID);
				else
					this.CMPANYID = base.SetshortAsString(ColumnNames.CMPANYID, value);
			}
		}

		public virtual string s_INTERID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.INTERID) ? string.Empty : base.GetstringAsString(ColumnNames.INTERID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.INTERID);
				else
					this.INTERID = base.SetstringAsString(ColumnNames.INTERID, value);
			}
		}

		public virtual string s_CMPNYNAM
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CMPNYNAM) ? string.Empty : base.GetstringAsString(ColumnNames.CMPNYNAM);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CMPNYNAM);
				else
					this.CMPNYNAM = base.SetstringAsString(ColumnNames.CMPNYNAM, value);
			}
		}

		public virtual string s_CCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CCode) ? string.Empty : base.GetstringAsString(ColumnNames.CCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CCode);
				else
					this.CCode = base.SetstringAsString(ColumnNames.CCode, value);
			}
		}


		#endregion			
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter CMPANYID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CMPANYID, Parameters.CMPANYID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter INTERID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.INTERID, Parameters.INTERID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CMPNYNAM
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CMPNYNAM, Parameters.CMPNYNAM);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CCode, Parameters.CCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter CMPANYID
		    {
				get
		        {
					if(_CMPANYID_W == null)
	        	    {
						_CMPANYID_W = TearOff.CMPANYID;
					}
					return _CMPANYID_W;
				}
			}

			public WhereParameter INTERID
		    {
				get
		        {
					if(_INTERID_W == null)
	        	    {
						_INTERID_W = TearOff.INTERID;
					}
					return _INTERID_W;
				}
			}

			public WhereParameter CMPNYNAM
		    {
				get
		        {
					if(_CMPNYNAM_W == null)
	        	    {
						_CMPNYNAM_W = TearOff.CMPNYNAM;
					}
					return _CMPNYNAM_W;
				}
			}

			public WhereParameter CCode
		    {
				get
		        {
					if(_CCode_W == null)
	        	    {
						_CCode_W = TearOff.CCode;
					}
					return _CCode_W;
				}
			}

			private WhereParameter _CMPANYID_W = null;
			private WhereParameter _INTERID_W = null;
			private WhereParameter _CMPNYNAM_W = null;
			private WhereParameter _CCode_W = null;

			public void WhereClauseReset()
			{
				_CMPANYID_W = null;
				_INTERID_W = null;
				_CMPNYNAM_W = null;
				_CCode_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter CMPANYID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CMPANYID, Parameters.CMPANYID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter INTERID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.INTERID, Parameters.INTERID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CMPNYNAM
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CMPNYNAM, Parameters.CMPNYNAM);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CCode, Parameters.CCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter CMPANYID
		    {
				get
		        {
					if(_CMPANYID_W == null)
	        	    {
						_CMPANYID_W = TearOff.CMPANYID;
					}
					return _CMPANYID_W;
				}
			}

			public AggregateParameter INTERID
		    {
				get
		        {
					if(_INTERID_W == null)
	        	    {
						_INTERID_W = TearOff.INTERID;
					}
					return _INTERID_W;
				}
			}

			public AggregateParameter CMPNYNAM
		    {
				get
		        {
					if(_CMPNYNAM_W == null)
	        	    {
						_CMPNYNAM_W = TearOff.CMPNYNAM;
					}
					return _CMPNYNAM_W;
				}
			}

			public AggregateParameter CCode
		    {
				get
		        {
					if(_CCode_W == null)
	        	    {
						_CCode_W = TearOff.CCode;
					}
					return _CCode_W;
				}
			}

			private AggregateParameter _CMPANYID_W = null;
			private AggregateParameter _INTERID_W = null;
			private AggregateParameter _CMPNYNAM_W = null;
			private AggregateParameter _CCode_W = null;

			public void AggregateClauseReset()
			{
				_CMPANYID_W = null;
				_INTERID_W = null;
				_CMPNYNAM_W = null;
				_CCode_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
			return null;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
			return null;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
			return null;
		}
	}
}
