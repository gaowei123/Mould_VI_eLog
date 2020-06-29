using System;
using System.Data;
using System.Collections.Generic;
using Common.Model;
using System.Data.SqlClient;

namespace Common.BLL
{
    /// <summary>
    /// MouldingPqm_BLL
    /// </summary>
    public class MouldingPqm_BLL
    {
        private readonly Common.DAL.MouldingPqm_DAL dal = new Common.DAL.MouldingPqm_DAL();
        public MouldingPqm_BLL()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string machineID, DateTime? updatedTime, decimal totalQTY, decimal tempature11, decimal tempature12, decimal tempature13, decimal tempature14, decimal tempature15, decimal tempature21, decimal tempature22, decimal tempature23, decimal tempature24, decimal tempature25, string status1, string status2, string partNumber, string matPart01, string matPart02, string customer, string model, string jigNo, decimal cavityCount, decimal partsWeight, decimal cycleTime, int blockCount, int unitCount, string userName, string remarks, string refField01, string refField02, string refField03, string refField04, string refField05, string refField06, string refField07, string refField08, string refField09, string refField10, string refField11, string refField12, string refField13, string refField14, string refField15, string refField16, string refField17, string refField18, string refField19, string refField20)
        {
            DataSet ds = new DataSet();
            ds = dal.Exists(machineID, updatedTime, totalQTY, tempature11, tempature12, tempature13, tempature14, tempature15, tempature21, tempature22, tempature23, tempature24, tempature25, status1, status2, partNumber, matPart01, matPart02, customer, model, jigNo, cavityCount, partsWeight, cycleTime, blockCount, unitCount, userName, remarks, refField01, refField02, refField03, refField04, refField05, refField06, refField07, refField08, refField09, refField10, refField11, refField12, refField13, refField14, refField15, refField16, refField17, refField18, refField19, refField20);
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
        public void Add(Common.Model.MouldingPqm_Model model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Common.Model.MouldingPqm_Model model)
        {
            return dal.Update(model);
        }

        public SqlCommand UpdateCommand(Common.Model.MouldingPqm_Model model)
        {
            return dal.UpdateCommand(model);
        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string machineID, DateTime? updatedTime, decimal totalQTY, decimal tempature11, decimal tempature12, decimal tempature13, decimal tempature14, decimal tempature15, decimal tempature21, decimal tempature22, decimal tempature23, decimal tempature24, decimal tempature25, string status1, string status2, string partNumber, string matPart01, string matPart02, string customer, string model, string jigNo, decimal cavityCount, decimal partsWeight, decimal cycleTime, int blockCount, int unitCount, string userName, string remarks, string refField01, string refField02, string refField03, string refField04, string refField05, string refField06, string refField07, string refField08, string refField09, string refField10, string refField11, string refField12, string refField13, string refField14, string refField15, string refField16, string refField17, string refField18, string refField19, string refField20)
        {

            return dal.Delete(machineID, updatedTime, totalQTY, tempature11, tempature12, tempature13, tempature14, tempature15, tempature21, tempature22, tempature23, tempature24, tempature25, status1, status2, partNumber, matPart01, matPart02, customer, model, jigNo, cavityCount, partsWeight, cycleTime, blockCount, unitCount, userName, remarks, refField01, refField02, refField03, refField04, refField05, refField06, refField07, refField08, refField09, refField10, refField11, refField12, refField13, refField14, refField15, refField16, refField17, refField18, refField19, refField20);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Common.Model.MouldingPqm_Model GetModel(string machineID, DateTime? updatedTime, decimal totalQTY, decimal tempature11, decimal tempature12, decimal tempature13, decimal tempature14, decimal tempature15, decimal tempature21, decimal tempature22, decimal tempature23, decimal tempature24, decimal tempature25, string status1, string status2, string partNumber, string matPart01, string matPart02, string customer, string model, string jigNo, decimal cavityCount, decimal partsWeight, decimal cycleTime, int blockCount, int unitCount, string userName, string remarks, string refField01, string refField02, string refField03, string refField04, string refField05, string refField06, string refField07, string refField08, string refField09, string refField10, string refField11, string refField12, string refField13, string refField14, string refField15, string refField16, string refField17, string refField18, string refField19, string refField20)
        {

            return dal.GetModel(machineID, updatedTime, totalQTY, tempature11, tempature12, tempature13, tempature14, tempature15, tempature21, tempature22, tempature23, tempature24, tempature25, status1, status2, partNumber, matPart01, matPart02, customer, model, jigNo, cavityCount, partsWeight, cycleTime, blockCount, unitCount, userName, remarks, refField01, refField02, refField03, refField04, refField05, refField06, refField07, refField08, refField09, refField10, refField11, refField12, refField13, refField14, refField15, refField16, refField17, refField18, refField19, refField20);
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
        public List<Common.Model.MouldingPqm_Model> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Common.Model.MouldingPqm_Model> DataTableToList(DataTable dt)
        {
            List<Common.Model.MouldingPqm_Model> modelList = new List<Common.Model.MouldingPqm_Model>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Common.Model.MouldingPqm_Model model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Common.Model.MouldingPqm_Model();
                    model.machineID = dt.Rows[n]["machineID"].ToString();
                    if (dt.Rows[n]["updatedTime"].ToString() != "")
                    {
                        model.updatedTime = DateTime.Parse(dt.Rows[n]["updatedTime"].ToString());
                    }
                    if (dt.Rows[n]["totalQTY"].ToString() != "")
                    {
                        model.totalQTY = decimal.Parse(dt.Rows[n]["totalQTY"].ToString());
                    }
                    if (dt.Rows[n]["tempature11"].ToString() != "")
                    {
                        model.tempature11 = decimal.Parse(dt.Rows[n]["tempature11"].ToString());
                    }
                    if (dt.Rows[n]["tempature12"].ToString() != "")
                    {
                        model.tempature12 = decimal.Parse(dt.Rows[n]["tempature12"].ToString());
                    }
                    if (dt.Rows[n]["tempature13"].ToString() != "")
                    {
                        model.tempature13 = decimal.Parse(dt.Rows[n]["tempature13"].ToString());
                    }
                    if (dt.Rows[n]["tempature14"].ToString() != "")
                    {
                        model.tempature14 = decimal.Parse(dt.Rows[n]["tempature14"].ToString());
                    }
                    if (dt.Rows[n]["tempature15"].ToString() != "")
                    {
                        model.tempature15 = decimal.Parse(dt.Rows[n]["tempature15"].ToString());
                    }
                    if (dt.Rows[n]["tempature21"].ToString() != "")
                    {
                        model.tempature21 = decimal.Parse(dt.Rows[n]["tempature21"].ToString());
                    }
                    if (dt.Rows[n]["tempature22"].ToString() != "")
                    {
                        model.tempature22 = decimal.Parse(dt.Rows[n]["tempature22"].ToString());
                    }
                    if (dt.Rows[n]["tempature23"].ToString() != "")
                    {
                        model.tempature23 = decimal.Parse(dt.Rows[n]["tempature23"].ToString());
                    }
                    if (dt.Rows[n]["tempature24"].ToString() != "")
                    {
                        model.tempature24 = decimal.Parse(dt.Rows[n]["tempature24"].ToString());
                    }
                    if (dt.Rows[n]["tempature25"].ToString() != "")
                    {
                        model.tempature25 = decimal.Parse(dt.Rows[n]["tempature25"].ToString());
                    }
                    model.status1 = dt.Rows[n]["status1"].ToString();
                    model.status2 = dt.Rows[n]["status2"].ToString();
                    model.partNumber = dt.Rows[n]["partNumber"].ToString();
                    model.matPart01 = dt.Rows[n]["matPart01"].ToString();
                    model.matPart02 = dt.Rows[n]["matPart02"].ToString();
                    model.customer = dt.Rows[n]["customer"].ToString();
                    model.model = dt.Rows[n]["model"].ToString();
                    model.jigNo = dt.Rows[n]["jigNo"].ToString();
                    if (dt.Rows[n]["cavityCount"].ToString() != "")
                    {
                        model.cavityCount = decimal.Parse(dt.Rows[n]["cavityCount"].ToString());
                    }
                    if (dt.Rows[n]["partsWeight"].ToString() != "")
                    {
                        model.partsWeight = decimal.Parse(dt.Rows[n]["partsWeight"].ToString());
                    }
                    if (dt.Rows[n]["cycleTime"].ToString() != "")
                    {
                        model.cycleTime = decimal.Parse(dt.Rows[n]["cycleTime"].ToString());
                    }
                    if (dt.Rows[n]["blockCount"].ToString() != "")
                    {
                        model.blockCount = int.Parse(dt.Rows[n]["blockCount"].ToString());
                    }
                    if (dt.Rows[n]["unitCount"].ToString() != "")
                    {
                        model.unitCount = int.Parse(dt.Rows[n]["unitCount"].ToString());
                    }
                    model.userName = dt.Rows[n]["userName"].ToString();
                    model.remarks = dt.Rows[n]["remarks"].ToString();
                    model.refField01 = dt.Rows[n]["refField01"].ToString();
                    model.refField02 = dt.Rows[n]["refField02"].ToString();
                    model.refField03 = dt.Rows[n]["refField03"].ToString();
                    model.refField04 = dt.Rows[n]["refField04"].ToString();
                    model.refField05 = dt.Rows[n]["refField05"].ToString();
                    model.refField06 = dt.Rows[n]["refField06"].ToString();
                    model.refField07 = dt.Rows[n]["refField07"].ToString();
                    model.refField08 = dt.Rows[n]["refField08"].ToString();
                    model.refField09 = dt.Rows[n]["refField09"].ToString();
                    model.refField10 = dt.Rows[n]["refField10"].ToString();
                    model.refField11 = dt.Rows[n]["refField11"].ToString();
                    model.refField12 = dt.Rows[n]["refField12"].ToString();
                    model.refField13 = dt.Rows[n]["refField13"].ToString();
                    model.refField14 = dt.Rows[n]["refField14"].ToString();
                    model.refField15 = dt.Rows[n]["refField15"].ToString();
                    model.refField16 = dt.Rows[n]["refField16"].ToString();
                    model.refField17 = dt.Rows[n]["refField17"].ToString();
                    model.refField18 = dt.Rows[n]["refField18"].ToString();
                    model.refField19 = dt.Rows[n]["refField19"].ToString();
                    model.refField20 = dt.Rows[n]["refField20"].ToString();
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

