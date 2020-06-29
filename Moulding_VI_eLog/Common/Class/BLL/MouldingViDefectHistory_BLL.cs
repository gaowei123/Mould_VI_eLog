
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Common.Model;
namespace Common.BLL
{
	/// <summary>
	/// MouldingViDefectHistory_BLL
	/// </summary>
	public class MouldingViDefectHistory_BLL
	{
		private readonly Common.DAL.MouldingViDefectHistory_DAL dal=new Common.DAL.MouldingViDefectHistory_DAL();
		public MouldingViDefectHistory_BLL()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Common.Model.MouldingViDefectHistory_Model model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public SqlCommand AddCommand(Common.Model.MouldingViDefectHistory_Model model)
		{
			return dal.AddCommand(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Common.Model.MouldingViDefectHistory_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public SqlCommand UpdateCommand(Common.Model.MouldingViDefectHistory_Model model)
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
		public Common.Model.MouldingViDefectHistory_Model GetModel()
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
		public List<Common.Model.MouldingViDefectHistory_Model> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Common.Model.MouldingViDefectHistory_Model> DataTableToList(DataTable dt)
		{
			List<Common.Model.MouldingViDefectHistory_Model> modelList = new List<Common.Model.MouldingViDefectHistory_Model>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Common.Model.MouldingViDefectHistory_Model model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Common.Model.MouldingViDefectHistory_Model();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					model.trackingID=dt.Rows[n]["trackingID"].ToString();
					model.machineID=dt.Rows[n]["machineID"].ToString();
					if(dt.Rows[n]["dateTime"].ToString()!="")
					{
						model.dateTime=DateTime.Parse(dt.Rows[n]["dateTime"].ToString());
					}
					model.partNumber=dt.Rows[n]["partNumber"].ToString();
					model.jigNo=dt.Rows[n]["jigNo"].ToString();
					model.model=dt.Rows[n]["model"].ToString();
					if(dt.Rows[n]["cavityCount"].ToString()!="")
					{
						model.cavityCount=decimal.Parse(dt.Rows[n]["cavityCount"].ToString());
					}
					model.userName=dt.Rows[n]["userName"].ToString();
					model.userID=dt.Rows[n]["userID"].ToString();
					if(dt.Rows[n]["startTime"].ToString()!="")
					{
						model.startTime=DateTime.Parse(dt.Rows[n]["startTime"].ToString());
					}
					if(dt.Rows[n]["stopTime"].ToString()!="")
					{
						model.stopTime=DateTime.Parse(dt.Rows[n]["stopTime"].ToString());
					}
					if(dt.Rows[n]["day"].ToString()!="")
					{
						model.day=DateTime.Parse(dt.Rows[n]["day"].ToString());
					}
					model.shift=dt.Rows[n]["shift"].ToString();
					model.status=dt.Rows[n]["status"].ToString();
					model.matPart01=dt.Rows[n]["matPart01"].ToString();
					model.matPart02=dt.Rows[n]["matPart02"].ToString();
					model.matLot01=dt.Rows[n]["matLot01"].ToString();
					model.matLot02=dt.Rows[n]["matLot02"].ToString();
					model.defectCodeID=dt.Rows[n]["defectCodeID"].ToString();
					model.defectCode=dt.Rows[n]["defectCode"].ToString();
					if(dt.Rows[n]["rejectQty"].ToString()!="")
					{
						model.rejectQty=decimal.Parse(dt.Rows[n]["rejectQty"].ToString());
					}
					model.rejectQtyHour01=dt.Rows[n]["rejectQtyHour01"].ToString();
					model.rejectQtyHour02=dt.Rows[n]["rejectQtyHour02"].ToString();
					model.rejectQtyHour03=dt.Rows[n]["rejectQtyHour03"].ToString();
					model.rejectQtyHour04=dt.Rows[n]["rejectQtyHour04"].ToString();
					model.rejectQtyHour05=dt.Rows[n]["rejectQtyHour05"].ToString();
					model.rejectQtyHour06=dt.Rows[n]["rejectQtyHour06"].ToString();
					model.rejectQtyHour07=dt.Rows[n]["rejectQtyHour07"].ToString();
					model.rejectQtyHour08=dt.Rows[n]["rejectQtyHour08"].ToString();
					model.rejectQtyHour09=dt.Rows[n]["rejectQtyHour09"].ToString();
					model.rejectQtyHour10=dt.Rows[n]["rejectQtyHour10"].ToString();
					model.rejectQtyHour11=dt.Rows[n]["rejectQtyHour11"].ToString();
					model.rejectQtyHour12=dt.Rows[n]["rejectQtyHour12"].ToString();
					if(dt.Rows[n]["lastUpdatedTime"].ToString()!="")
					{
						model.lastUpdatedTime=DateTime.Parse(dt.Rows[n]["lastUpdatedTime"].ToString());
					}
					model.remarks=dt.Rows[n]["remarks"].ToString();
                    if (dt.Rows[n]["QCNGQTY"].ToString() != "")
                    {
                        model.QCNGQTY = decimal.Parse(dt.Rows[n]["QCNGQTY"].ToString());
                    }
                    model.Material_MHCheck = dt.Rows[n]["Material_MHCheck"].ToString();
                    if (dt.Rows[n]["Material_MHCheckTime"].ToString() != "")
                    {
                        model.Material_MHCheckTime = DateTime.Parse(dt.Rows[n]["Material_MHCheckTime"].ToString());
                    }
                    model.Material_Opcheck = dt.Rows[n]["Material_Opcheck"].ToString();
                    if (dt.Rows[n]["Material_OpCheckTime"].ToString() != "")
                    {
                        model.Material_OpCheckTime = DateTime.Parse(dt.Rows[n]["Material_OpCheckTime"].ToString());
                    }
                    model.Material_LeaderCheck = dt.Rows[n]["Material_LeaderCheck"].ToString();
                    if (dt.Rows[n]["Material_LeaderCheckTime"].ToString() != "")
                    {
                        model.Material_LeaderCheckTime = DateTime.Parse(dt.Rows[n]["Material_LeaderCheckTime"].ToString());
                    }
                    model.LeaderCheck = dt.Rows[n]["LeaderCheck"].ToString();
                    if (dt.Rows[n]["LeaderCheckTime"].ToString() != "")
                    {
                        model.LeaderCheckTime = DateTime.Parse(dt.Rows[n]["LeaderCheckTime"].ToString());
                    }
                    model.SupervisorCheck = dt.Rows[n]["SupervisorCheck"].ToString();
                    if (dt.Rows[n]["SupervisorCheckTime"].ToString() != "")
                    {
                        model.SupervisorCheckTime = DateTime.Parse(dt.Rows[n]["SupervisorCheckTime"].ToString());
                    }
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
		public Common.Model.MouldingViDefectHistory_Model CopyObj(Common.Model.MouldingViDefectTracking_Model objModel )
		{
			Common.Model.MouldingViDefectHistory_Model model;
			model = new Common.Model.MouldingViDefectHistory_Model();
			model.id = objModel.id ;
			model.trackingID = objModel.trackingID ;
			model.machineID = objModel.machineID ;
			model.dateTime = objModel.dateTime ;
			model.partNumber = objModel.partNumber ;
			model.jigNo = objModel.jigNo ;
			model.model = objModel.model ;
			model.cavityCount = objModel.cavityCount ;
			model.userName = objModel.userName ;
			model.userID = objModel.userID ;
			model.startTime = objModel.startTime ;
			model.stopTime = objModel.stopTime ;
			model.day = objModel.day ;
			model.shift = objModel.shift ;
			model.status = objModel.status ;
			model.matPart01 = objModel.matPart01 ;
			model.matPart02 = objModel.matPart02 ;
			model.matLot01 = objModel.matLot01 ;
			model.matLot02 = objModel.matLot02 ;
			model.defectCodeID = objModel.defectCodeID ;
			model.defectCode = objModel.defectCode ;
			model.rejectQty = objModel.rejectQty ;
			model.rejectQtyHour01 = objModel.rejectQtyHour01 ;
			model.rejectQtyHour02 = objModel.rejectQtyHour02 ;
			model.rejectQtyHour03 = objModel.rejectQtyHour03 ;
			model.rejectQtyHour04 = objModel.rejectQtyHour04 ;
			model.rejectQtyHour05 = objModel.rejectQtyHour05 ;
			model.rejectQtyHour06 = objModel.rejectQtyHour06 ;
			model.rejectQtyHour07 = objModel.rejectQtyHour07 ;
			model.rejectQtyHour08 = objModel.rejectQtyHour08 ;
			model.rejectQtyHour09 = objModel.rejectQtyHour09 ;
			model.rejectQtyHour10 = objModel.rejectQtyHour10 ;
			model.rejectQtyHour11 = objModel.rejectQtyHour11 ;
			model.rejectQtyHour12 = objModel.rejectQtyHour12 ;
			model.lastUpdatedTime = objModel.lastUpdatedTime ;
			model.remarks = objModel.remarks ;
            model.QCNGQTY = objModel.QCNGQTY;
            model.Material_LeaderCheck = objModel.Material_LeaderCheck;
            model.Material_LeaderCheckTime = objModel.Material_LeaderCheckTime;
            model.Material_MHCheck = objModel.Material_MHCheck;
            model.Material_MHCheckTime = objModel.Material_MHCheckTime;
            model.Material_Opcheck = objModel.Material_Opcheck;
            model.Material_OpCheckTime = objModel.Material_OpCheckTime;
            model.LeaderCheck = objModel.LeaderCheck;
            model.LeaderCheckTime = objModel.LeaderCheckTime;
            model.SupervisorCheck = objModel.SupervisorCheck;
            model.SupervisorCheckTime = objModel.SupervisorCheckTime;
            model.partnumberall = objModel.partnumberall;
            return model;
		}

		#endregion  Method
	}
}

