
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Common.Model;
namespace Common.BLL
{
	/// <summary>
	/// MouldingBom_BLL
	/// </summary>
	public class MouldingBom_BLL
	{
		private readonly Common.DAL.MouldingBom_DAL dal=new Common.DAL.MouldingBom_DAL();
		public MouldingBom_BLL()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Common.Model.MouldingBom_Model model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public SqlCommand AddCommand(Common.Model.MouldingBom_Model model)
		{
			return dal.AddCommand(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Common.Model.MouldingBom_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public SqlCommand UpdateCommand(Common.Model.MouldingBom_Model model)
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
		public Common.Model.MouldingBom_Model GetModel()
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
		public List<Common.Model.MouldingBom_Model> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Common.Model.MouldingBom_Model> DataTableToList(DataTable dt)
		{
			List<Common.Model.MouldingBom_Model> modelList = new List<Common.Model.MouldingBom_Model>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Common.Model.MouldingBom_Model model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Common.Model.MouldingBom_Model();
					model.partNumber=dt.Rows[n]["partNumber"].ToString();
					model.matPart01=dt.Rows[n]["matPart01"].ToString();
					model.matPart02=dt.Rows[n]["matPart02"].ToString();
					model.customer=dt.Rows[n]["customer"].ToString();
					model.model=dt.Rows[n]["model"].ToString();
					model.jigNo=dt.Rows[n]["jigNo"].ToString();
					if(dt.Rows[n]["cavityCount"].ToString()!="")
					{
						model.cavityCount=decimal.Parse(dt.Rows[n]["cavityCount"].ToString());
					}
					if(dt.Rows[n]["partsWeight"].ToString()!="")
					{
						model.partsWeight=decimal.Parse(dt.Rows[n]["partsWeight"].ToString());
					}
					if(dt.Rows[n]["cycleTime"].ToString()!="")
					{
						model.cycleTime=decimal.Parse(dt.Rows[n]["cycleTime"].ToString());
					}
					if(dt.Rows[n]["blockCount"].ToString()!="")
					{
						model.blockCount=decimal.Parse(dt.Rows[n]["blockCount"].ToString());
					}
					if(dt.Rows[n]["unitCount"].ToString()!="")
					{
						model.unitCount=decimal.Parse(dt.Rows[n]["unitCount"].ToString());
					}
					model.machineID=dt.Rows[n]["machineID"].ToString();
					model.userName=dt.Rows[n]["userName"].ToString();
					if(dt.Rows[n]["dateTime"].ToString()!="")
					{
						model.dateTime=DateTime.Parse(dt.Rows[n]["dateTime"].ToString());
					}
					model.remarks=dt.Rows[n]["remarks"].ToString();

                    model.partnumberall = dt.Rows[n]["partNumberAll"].ToString();
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
		public Common.Model.MouldingBom_Model CopyObj(Common.Model.MouldingBom_Model objModel )
		{
			Common.Model.MouldingBom_Model model;
			model = new Common.Model.MouldingBom_Model();
			model.partNumber = objModel.partNumber ;
			model.matPart01 = objModel.matPart01 ;
			model.matPart02 = objModel.matPart02 ;
			model.customer = objModel.customer ;
			model.model = objModel.model ;
			model.jigNo = objModel.jigNo ;
			model.cavityCount = objModel.cavityCount ;
			model.partsWeight = objModel.partsWeight ;
			model.cycleTime = objModel.cycleTime ;
			model.blockCount = objModel.blockCount ;
			model.unitCount = objModel.unitCount ;
			model.machineID = objModel.machineID ;
			model.userName = objModel.userName ;
			model.dateTime = objModel.dateTime ;
			model.remarks = objModel.remarks ;
            model.partnumberall = objModel.partnumberall;
			return model;
		}


        #endregion  Method

        #region MyRegion

        public List<MouldingBom_Model> getModelListByJigNo(string sJigNo)
        {
            List<MouldingBom_Model> objBom_List = new List<MouldingBom_Model>();
            try
            {
                string sWhere = " JigNo='" + sJigNo + "'" ;
                objBom_List = GetModelList(sWhere);
            }
            catch (Exception ex)
            {

                throw;
            }

            return objBom_List;
        }
        public List<MouldingBom_Model> getModelListByPartNo(string sPartNumber)
        {
            List<MouldingBom_Model> objBom_List = new List<MouldingBom_Model>();
            try
            {
                string sWhere = " PartNumber='" + sPartNumber + "'" ;
                objBom_List = GetModelList(sWhere);
            }
            catch (Exception ex)
            {

                throw;
            }

            return objBom_List;
        }

        public List<MouldingBom_Model> getAllPartNoListByPartNo(string sPartNumberAll)
        {
            List<MouldingBom_Model> objBom_List = new List<MouldingBom_Model>();
            try
            {
                string sWhere = " PartNumberAll='" + sPartNumberAll + "'";
                objBom_List = GetModelList(sWhere);
            }
            catch (Exception ex)
            {

                throw;
            }

            return objBom_List;
        }


        public List<MouldingBom_Model> getDistinctList( string sCustomer, string sModel, string sPartNumberAll)
        {
            List<MouldingBom_Model> objBom_List = new List<MouldingBom_Model>();
            try
            {

                string sWhere = " 1=1";
                if (sCustomer.Trim().Length >0 )
                {
                    sWhere += " and Customer = '" + sCustomer + "'";
                }
                if (sModel.Trim().Length > 0)
                {
                    sWhere += " and Model = '" + sModel + "'";
                }
                if (sPartNumberAll.Trim().Length > 0)
                {
                    sWhere += " and PartNumberAll = '" + sPartNumberAll + "'";
                }
              
                objBom_List = GetModelList(sWhere);
            }
            catch (Exception ex)
            {
                
            }
            return objBom_List;
        }



        #endregion
    }
}

