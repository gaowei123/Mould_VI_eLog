 
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Common.Model;
namespace Common.BLL
{
	/// <summary>
	/// MouldingDefectSetting_BLL
	/// </summary>
	public class MouldingDefectSetting_BLL
	{
		private readonly Common.DAL.MouldingDefectSetting_DAL dal=new Common.DAL.MouldingDefectSetting_DAL();
		public MouldingDefectSetting_BLL()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Common.Model.MouldingDefectSetting_Model model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public SqlCommand AddCommand(Common.Model.MouldingDefectSetting_Model model)
		{
			return dal.AddCommand(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Common.Model.MouldingDefectSetting_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public SqlCommand UpdateCommand(Common.Model.MouldingDefectSetting_Model model)
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
		public Common.Model.MouldingDefectSetting_Model GetModel()
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
		public List<Common.Model.MouldingDefectSetting_Model> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Common.Model.MouldingDefectSetting_Model> DataTableToList(DataTable dt)
		{
			List<Common.Model.MouldingDefectSetting_Model> modelList = new List<Common.Model.MouldingDefectSetting_Model>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Common.Model.MouldingDefectSetting_Model model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Common.Model.MouldingDefectSetting_Model();
					model.defectCodeID=dt.Rows[n]["defectCodeID"].ToString();
					model.defectCode=dt.Rows[n]["defectCode"].ToString();
					model.defectDescription=dt.Rows[n]["defectDescription"].ToString();
					model.partNumber=dt.Rows[n]["partNumber"].ToString();
					model.model=dt.Rows[n]["model"].ToString();
					model.jigNo=dt.Rows[n]["jigNo"].ToString();
					model.machineID=dt.Rows[n]["machineID"].ToString();
					model.userName=dt.Rows[n]["userName"].ToString();
					if(dt.Rows[n]["dateTime"].ToString()!="")
					{
						model.dateTime=DateTime.Parse(dt.Rows[n]["dateTime"].ToString());
					}
					model.remarks=dt.Rows[n]["remarks"].ToString();
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
		public Common.Model.MouldingDefectSetting_Model CopyObj(Common.Model.MouldingDefectSetting_Model objModel )
		{
			Common.Model.MouldingDefectSetting_Model model;
			model = new Common.Model.MouldingDefectSetting_Model();
			model.defectCodeID = objModel.defectCodeID ;
			model.defectCode = objModel.defectCode ;
			model.defectDescription = objModel.defectDescription ;
			model.partNumber = objModel.partNumber ;
			model.model = objModel.model ;
			model.jigNo = objModel.jigNo ;
			model.machineID = objModel.machineID ;
			model.userName = objModel.userName ;
			model.dateTime = objModel.dateTime ;
			model.remarks = objModel.remarks ;
			return model;
		}

        #endregion  Method


        #region MyRegion
        public List<MouldingDefectSetting_Model> GetListByModelPartJig()
        {
            return GetListByModelPartJig(MouldingDefectSetting_Model.sAll, MouldingDefectSetting_Model.sAll, MouldingDefectSetting_Model.sAll);
        }
        public List<MouldingDefectSetting_Model> GetListByModelPartJig(string Model, string PartNumber, string JigNo)
        {
            List<MouldingDefectSetting_Model> objMouldDefSetting_List = new List<MouldingDefectSetting_Model>();
            string sWhere = "1=1 ";
            if (Model.Length > 0)
            {
                sWhere += " and Model ='" + Model + "'";
            }
            if (PartNumber.Length > 0)
            {
                sWhere += " and PartNumber ='" + PartNumber + "'";
            }
            if (JigNo.Length > 0)
            {
                sWhere += " and JigNo ='" + JigNo + "'";
            }
            DataSet ds = new DataSet();
            ds = this.GetList(100,sWhere, " DefectCodeId asc ");
            objMouldDefSetting_List = DataTableToList(ds.Tables[0]);

            if (objMouldDefSetting_List != null && objMouldDefSetting_List.Count >0)
            {
                return objMouldDefSetting_List;
            }
            else
            {
                return this.DataTableToList(GetList(100,
                    " Model='" + MouldingDefectSetting_Model.sAll
                    + "'  and PartNumber ='" + MouldingDefectSetting_Model.sAll
                    + "'  and JigNo ='" + MouldingDefectSetting_Model.sAll + "'",
                     " DefectCodeId asc ").Tables[0]);
;            }
        }
        #endregion
    }
}

