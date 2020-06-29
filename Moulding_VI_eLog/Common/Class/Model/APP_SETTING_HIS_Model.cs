
using System;
namespace Common.Model
{
	/// <summary>
	/// APP_SETTING_HIS_Model:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class APP_SETTING_HIS_Model
	{
		public APP_SETTING_HIS_Model()
		{}
		#region Model
		private string _item;
		private string _value;
		private string _void;
		private string _remark;
		private string _department;
		private string _process;
		private DateTime? _updated_time;
		private string _updated_user;
		private string _type;
		/// <summary>
		/// 
		/// </summary>
		public string ITEM
		{
			set{ _item=value;}
			get{return _item;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VALUE
		{
			set{ _value=value;}
			get{return _value;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VOID
		{
			set{ _void=value;}
			get{return _void;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPARTMENT
		{
			set{ _department=value;}
			get{return _department;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PROCESS
		{
			set{ _process=value;}
			get{return _process;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UPDATED_TIME
		{
			set{ _updated_time=value;}
			get{return _updated_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPDATED_USER
		{
			set{ _updated_user=value;}
			get{return _updated_user;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPE
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model

	}
}

