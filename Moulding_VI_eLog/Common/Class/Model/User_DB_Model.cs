 
using System;
namespace Common.Model
{
	/// <summary>
	/// MouldingViTracking_Model:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class User_DB_Model
    {
		public User_DB_Model()
		{}
        #region Model
        string _userID;
        string _userName;
        string _Password;
        string _User_group;
        DateTime? _Updated_time;
        string _Updated_By;
        string _Department;
        string _Finger_Template;
        string _Shift;
        string _Finger_Template_1;
        /// <summary>
        /// 
        /// </summary>

		/// <summary>
		/// 
		/// </summary>
		public string userID
        {
			set{ _userID = value;}
			get{return _userID; }
		}

		public string userName
        {
			set{ _userName = value;}
			get{return _userName; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
        {
			set{ _Password = value;}
			get{return _Password; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_group
        {
			set{ _User_group = value;}
			get{return _User_group; }
		}

		public DateTime? Updated_time
        {
			set{ _Updated_time = value;}
			get{return _Updated_time; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string Updated_By
        {
			set{ _Updated_By = value;}
			get{return _Updated_By; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string Department
        {
			set{ _Department = value;}
			get{return _Department; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string Finger_Template
        {
			set{ _Finger_Template = value;}
			get{return _Finger_Template; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string Shift
        {
			set{ _Shift = value;}
			get{return _Shift; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string Finger_Template_1
        {
			set{ _Finger_Template_1 = value;}
			get{return _Finger_Template_1; }
		}
		#endregion Model

	}
}

