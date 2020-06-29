
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Common.Model;
namespace Common.BLL
{
	/// <summary>
	/// MouldingViHistory_BLL
	/// </summary>
	public class MouldingViHistory_BLL
	{
		private readonly Common.DAL.MouldingViHistory_DAL dal=new Common.DAL.MouldingViHistory_DAL();
		public MouldingViHistory_BLL()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Common.Model.MouldingViHistory_Model model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public SqlCommand AddCommand(Common.Model.MouldingViHistory_Model model)
		{
			return dal.AddCommand(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Common.Model.MouldingViHistory_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public SqlCommand UpdateCommand(Common.Model.MouldingViHistory_Model model)
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
		public Common.Model.MouldingViHistory_Model GetModel()
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
		public List<Common.Model.MouldingViHistory_Model> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Common.Model.MouldingViHistory_Model> DataTableToList(DataTable dt)
		{
			List<Common.Model.MouldingViHistory_Model> modelList = new List<Common.Model.MouldingViHistory_Model>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Common.Model.MouldingViHistory_Model model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Common.Model.MouldingViHistory_Model();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
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
					if(dt.Rows[n]["partsWeight"].ToString()!="")
					{
						model.partsWeight=decimal.Parse(dt.Rows[n]["partsWeight"].ToString());
					}
					if(dt.Rows[n]["cycleTime"].ToString()!="")
					{
						model.cycleTime=decimal.Parse(dt.Rows[n]["cycleTime"].ToString());
					}
					if(dt.Rows[n]["targetQty"].ToString()!="")
					{
						model.targetQty=decimal.Parse(dt.Rows[n]["targetQty"].ToString());
					}
					model.userName=dt.Rows[n]["userName"].ToString();
					model.userID=dt.Rows[n]["userID"].ToString();
					if(dt.Rows[n]["acountReading"].ToString()!="")
					{
						model.acountReading=decimal.Parse(dt.Rows[n]["acountReading"].ToString());
					}
                    if (dt.Rows[n]["QCNGQTY"].ToString() != "")
                    {
                        model.QCNGQTY = decimal.Parse(dt.Rows[n]["QCNGQTY"].ToString());
                    }
                    if (dt.Rows[n]["rejectQty"].ToString()!="")
					{
						model.rejectQty=decimal.Parse(dt.Rows[n]["rejectQty"].ToString());
					}
					if(dt.Rows[n]["acceptQty"].ToString()!="")
					{
						model.acceptQty=decimal.Parse(dt.Rows[n]["acceptQty"].ToString());
					}
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
					model.opSign01=dt.Rows[n]["opSign01"].ToString();
					model.opSign02=dt.Rows[n]["opSign02"].ToString();
					model.opSign03=dt.Rows[n]["opSign03"].ToString();
					model.opSign04=dt.Rows[n]["opSign04"].ToString();
					model.opSign05=dt.Rows[n]["opSign05"].ToString();
					model.opSign06=dt.Rows[n]["opSign06"].ToString();
					model.opSign07=dt.Rows[n]["opSign07"].ToString();
					model.opSign08=dt.Rows[n]["opSign08"].ToString();
					model.opSign09=dt.Rows[n]["opSign09"].ToString();
					model.opSign10=dt.Rows[n]["opSign10"].ToString();
					model.opSign11=dt.Rows[n]["opSign11"].ToString();
					model.opSign12=dt.Rows[n]["opSign12"].ToString();
					model.qaSign01=dt.Rows[n]["qaSign01"].ToString();
					model.qaSign02=dt.Rows[n]["qaSign02"].ToString();
					model.qaSign03=dt.Rows[n]["qaSign03"].ToString();
					model.qaSign04=dt.Rows[n]["qaSign04"].ToString();
					model.qaSign05=dt.Rows[n]["qaSign05"].ToString();
					model.qaSign06=dt.Rows[n]["qaSign06"].ToString();
					model.qaSign07=dt.Rows[n]["qaSign07"].ToString();
					model.qaSign08=dt.Rows[n]["qaSign08"].ToString();
					model.qaSign09=dt.Rows[n]["qaSign09"].ToString();
					model.qaSign10=dt.Rows[n]["qaSign10"].ToString();
					model.qaSign11=dt.Rows[n]["qaSign11"].ToString();
					model.qaSign12=dt.Rows[n]["qaSign12"].ToString();
					model.customer=dt.Rows[n]["customer"].ToString();
					if(dt.Rows[n]["lastUpdatedTime"].ToString()!="")
					{
						model.lastUpdatedTime=DateTime.Parse(dt.Rows[n]["lastUpdatedTime"].ToString());
					}
					model.trackingID=dt.Rows[n]["trackingID"].ToString();
					model.remarks=dt.Rows[n]["remarks"].ToString();
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
                    if (dt.Rows[n]["parts2Weight"].ToString() != "")
                    {
                        model.parts2Weight = decimal.Parse(dt.Rows[n]["parts2Weight"].ToString());
                    }
                    if (dt.Rows[n]["lastQty"].ToString() != "")
                    {
                        model.lastQty = decimal.Parse(dt.Rows[n]["lastQty"].ToString());
                    }
                    model.OkAccumulation = dt.Rows[n]["OkAccumulation"].ToString();
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
		public Common.Model.MouldingViHistory_Model CopyObj(Common.Model.MouldingViTracking_Model objModel )
		{
			Common.Model.MouldingViHistory_Model model;
			model = new Common.Model.MouldingViHistory_Model();
			model.id = objModel.id ;
			model.machineID = objModel.machineID ;
			model.dateTime = objModel.dateTime ;
			model.partNumber = objModel.partNumber ;
			model.jigNo = objModel.jigNo ;
			model.model = objModel.model ;
			model.cavityCount = objModel.cavityCount ;
			model.partsWeight = objModel.partsWeight ;
			model.cycleTime = objModel.cycleTime ;
			model.targetQty = objModel.targetQty ;
			model.userName = objModel.userName ;
			model.userID = objModel.userID ;
			model.acountReading = objModel.acountReading ;
			model.rejectQty = objModel.rejectQty ;
            model.QCNGQTY = objModel.QCNGQTY;
			model.acceptQty = objModel.acceptQty ;
			model.startTime = objModel.startTime ;
			model.stopTime = objModel.stopTime ;
			model.day = objModel.day ;
			model.shift = objModel.shift ;
			model.status = objModel.status ;
			model.matPart01 = objModel.matPart01 ;
			model.matPart02 = objModel.matPart02 ;
			model.matLot01 = objModel.matLot01 ;
			model.matLot02 = objModel.matLot02 ;
			model.opSign01 = objModel.opSign01 ;
			model.opSign02 = objModel.opSign02 ;
			model.opSign03 = objModel.opSign03 ;
			model.opSign04 = objModel.opSign04 ;
			model.opSign05 = objModel.opSign05 ;
			model.opSign06 = objModel.opSign06 ;
			model.opSign07 = objModel.opSign07 ;
			model.opSign08 = objModel.opSign08 ;
			model.opSign09 = objModel.opSign09 ;
			model.opSign10 = objModel.opSign10 ;
			model.opSign11 = objModel.opSign11 ;
			model.opSign12 = objModel.opSign12 ;
			model.qaSign01 = objModel.qaSign01 ;
			model.qaSign02 = objModel.qaSign02 ;
			model.qaSign03 = objModel.qaSign03 ;
			model.qaSign04 = objModel.qaSign04 ;
			model.qaSign05 = objModel.qaSign05 ;
			model.qaSign06 = objModel.qaSign06 ;
			model.qaSign07 = objModel.qaSign07 ;
			model.qaSign08 = objModel.qaSign08 ;
			model.qaSign09 = objModel.qaSign09 ;
			model.qaSign10 = objModel.qaSign10 ;
			model.qaSign11 = objModel.qaSign11 ;
			model.qaSign12 = objModel.qaSign12 ;
			model.customer = objModel.customer ;
			model.lastUpdatedTime = objModel.lastUpdatedTime ;
			model.trackingID = objModel.trackingID ;
			model.remarks = objModel.remarks ;
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
            model.parts2Weight = objModel.parts2Weight;
            model.lastQty = objModel.lastQty;
            model.OkAccumulation = objModel.OkAccumulation;
            return model;
		}

		#endregion  Method
	}
}

