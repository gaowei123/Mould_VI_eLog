using System;
using System.Data;
using System.Collections.Generic;
using Common.Model;
namespace Common.BLL
{
    /// <summary>
    /// MouldingMachineEvent_BLL
    /// </summary>
    public class MouldingMachineEvent_BLL
    {
        private readonly Common.DAL.MouldingMachineEvent_DAL dal = new Common.DAL.MouldingMachineEvent_DAL();
        public MouldingMachineEvent_BLL()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string MachineID, string PQMmachineID, string Event_Type, string error_code, string error_name, DateTime? event_time, string remarks)
        {
            DataSet ds = new DataSet();
            ds = dal.Exists(MachineID, PQMmachineID, Event_Type, error_code, error_name, event_time, remarks);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Common.Model.MouldingMachineEvent_Model model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Common.Model.MouldingMachineEvent_Model model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string MachineID, string PQMmachineID, string Event_Type, string error_code, string error_name, DateTime? event_time, string remarks)
        {

            return dal.Delete(MachineID, PQMmachineID, Event_Type, error_code, error_name, event_time, remarks);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Common.Model.MouldingMachineEvent_Model GetModel(string MachineID, string PQMmachineID, string Event_Type, string error_code, string error_name, DateTime? event_time, string remarks)
        {

            return dal.GetModel(MachineID, PQMmachineID, Event_Type, error_code, error_name, event_time, remarks);
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Common.Model.MouldingMachineEvent_Model> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Common.Model.MouldingMachineEvent_Model> DataTableToList(DataTable dt)
        {
            List<Common.Model.MouldingMachineEvent_Model> modelList = new List<Common.Model.MouldingMachineEvent_Model>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Common.Model.MouldingMachineEvent_Model model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Common.Model.MouldingMachineEvent_Model();
                    model.MachineID = dt.Rows[n]["MachineID"].ToString();
                    model.PQMmachineID = dt.Rows[n]["PQMmachineID"].ToString();
                    model.Event_Type = dt.Rows[n]["Event_Type"].ToString();
                    model.error_code = dt.Rows[n]["error_code"].ToString();
                    model.error_name = dt.Rows[n]["error_name"].ToString();
                    if (dt.Rows[n]["event_time"].ToString() != "")
                    {
                        model.event_time = DateTime.Parse(dt.Rows[n]["event_time"].ToString());
                    }
                    model.remarks = dt.Rows[n]["remarks"].ToString();
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

        #endregion  Method
    }
}

