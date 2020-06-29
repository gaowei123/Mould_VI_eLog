 
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Common.Model;
namespace Common.BLL
{
	/// <summary>
	/// APP_SETTING_HIS_BLL
	/// </summary>
	public class APP_SETTING_HIS_BLL
	{
		private readonly Common.DAL.APP_SETTING_HIS_DAL dal=new Common.DAL.APP_SETTING_HIS_DAL();
		public APP_SETTING_HIS_BLL()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Common.Model.APP_SETTING_HIS_Model model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public SqlCommand AddCommand(Common.Model.APP_SETTING_HIS_Model model)
		{
			return dal.AddCommand(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Common.Model.APP_SETTING_HIS_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public SqlCommand UpdateCommand(Common.Model.APP_SETTING_HIS_Model model)
		{
			return dal.UpdateCommand(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public SqlCommand DeleteCommand()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.DeleteCommand();
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public SqlCommand DeleteAllCommand()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.DeleteAllCommand();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Common.Model.APP_SETTING_HIS_Model GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Common.Model.APP_SETTING_HIS_Model> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Common.Model.APP_SETTING_HIS_Model> DataTableToList(DataTable dt)
		{
			List<Common.Model.APP_SETTING_HIS_Model> modelList = new List<Common.Model.APP_SETTING_HIS_Model>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Common.Model.APP_SETTING_HIS_Model model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Common.Model.APP_SETTING_HIS_Model();
					model.ITEM=dt.Rows[n]["ITEM"].ToString();
					model.VALUE=dt.Rows[n]["VALUE"].ToString();
					model.VOID=dt.Rows[n]["VOID"].ToString();
					model.REMARK=dt.Rows[n]["REMARK"].ToString();
					model.DEPARTMENT=dt.Rows[n]["DEPARTMENT"].ToString();
					model.PROCESS=dt.Rows[n]["PROCESS"].ToString();
					if(dt.Rows[n]["UPDATED_TIME"].ToString()!="")
					{
						model.UPDATED_TIME=DateTime.Parse(dt.Rows[n]["UPDATED_TIME"].ToString());
					}
					model.UPDATED_USER=dt.Rows[n]["UPDATED_USER"].ToString();
					model.TYPE=dt.Rows[n]["TYPE"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public Common.Model.APP_SETTING_HIS_Model CopyObj(Common.Model.APP_SETTING_HIS_Model objModel )
		{
			Common.Model.APP_SETTING_HIS_Model model;
			model = new Common.Model.APP_SETTING_HIS_Model();
			model.ITEM = objModel.ITEM ;
			model.VALUE = objModel.VALUE ;
			model.VOID = objModel.VOID ;
			model.REMARK = objModel.REMARK ;
			model.DEPARTMENT = objModel.DEPARTMENT ;
			model.PROCESS = objModel.PROCESS ;
			model.UPDATED_TIME = objModel.UPDATED_TIME ;
			model.UPDATED_USER = objModel.UPDATED_USER ;
			model.TYPE = objModel.TYPE ;
			return model;
		}

		#endregion  Method
	}
}

