 
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Common.Model;
namespace Common.BLL
{
	/// <summary>
	/// APP_SETTING_BLL
	/// </summary>
	public class APP_SETTING_BLL
	{
		private readonly Common.DAL.APP_SETTING_DAL dal=new Common.DAL.APP_SETTING_DAL();
		public APP_SETTING_BLL()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ITEM,string TYPE)
		{
			DataSet ds = new DataSet();
			ds = dal.Exists(ITEM,TYPE);
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
		public void Add(Common.Model.APP_SETTING_Model model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public SqlCommand AddCommand(Common.Model.APP_SETTING_Model model)
		{
			return dal.AddCommand(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Common.Model.APP_SETTING_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public SqlCommand UpdateCommand(Common.Model.APP_SETTING_Model model)
		{
			return dal.UpdateCommand(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ITEM,string TYPE)
		{
			
			return dal.Delete(ITEM,TYPE);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public SqlCommand DeleteCommand(string ITEM,string TYPE)
		{
			
			return dal.DeleteCommand(ITEM,TYPE);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public SqlCommand DeleteAllCommand()
		{
			
			return dal.DeleteAllCommand();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Common.Model.APP_SETTING_Model GetModel(string ITEM,string TYPE)
		{
			
			return dal.GetModel(ITEM,TYPE);
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
		public List<Common.Model.APP_SETTING_Model> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}

        public List<Common.Model.APP_SETTING_Model> GetModelListWithOrder(int Top, string strWhere, string filedOrder)
        {
            DataSet ds = dal.GetList(Top, strWhere,filedOrder);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Common.Model.APP_SETTING_Model> DataTableToList(DataTable dt)
		{
			List<Common.Model.APP_SETTING_Model> modelList = new List<Common.Model.APP_SETTING_Model>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Common.Model.APP_SETTING_Model model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Common.Model.APP_SETTING_Model();
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
		public Common.Model.APP_SETTING_Model CopyObj(Common.Model.APP_SETTING_Model objModel )
		{
			Common.Model.APP_SETTING_Model model;
			model = new Common.Model.APP_SETTING_Model();
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

        //2017 05 05
        public List<Common.Model.APP_SETTING_Model> getModelList_ByTypeProcessDept(string sType, string sProcess, string sDept)
        { 
            string sqlWhere = " 1=1 ";
            if (sType.Trim().Length > 0)
            {
                sqlWhere += "  and Type ='" + sType + "' ";
            }
            if (sProcess.Trim().Length > 0)
            {
                sqlWhere += "  and Process ='" + sProcess + "' ";
            }
            if (sDept.Trim().Length > 0)
            {
                sqlWhere += "  and Department ='" + sDept + "' ";
            }
            return GetModelList( sqlWhere); 

        }
        //2017 05 17
        public List<Common.Model.APP_SETTING_Model> getColIndex(string sType, string sProcess, string sDept)
        { 
            string sqlWhere = " 1=1 ";
            if (sType.Trim().Length > 0)
            {
                sqlWhere += "  and Type ='" + sType + "' ";
            }
            if (sProcess.Trim().Length > 0)
            {
                sqlWhere += "  and Process ='" + sProcess + "' ";
            }
            if (sDept.Trim().Length > 0)
            {
                sqlWhere += "  and Department ='" + sDept + "' ";
            }
            return GetModelListWithOrder (0, sqlWhere , "   CONVERT(numeric , right('000'+ value, 3)) "); 

        }


        //2017 05 05
        public Dictionary<string, int> getIndexDic_ByTypeProcessDept(string sType, string sProcess, string sDept)
        {
            Dictionary<string, int> dAppSetting = new Dictionary<string, int>();
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();

            lOblAppSetting = getColIndex(sType, sProcess, sDept);

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {
                if (!dAppSetting.ContainsKey(tmpObj.ITEM))
                {
                    int iIndex = 0;
                    if (int.TryParse(tmpObj.VALUE, out iIndex))
                    {
                        dAppSetting.Add(tmpObj.ITEM, iIndex - 1); //need reduce 1 becasue the start index is 1 in table
                    }
                }
            }

            return dAppSetting;
        }
        //2017 05 05
        public Dictionary<string, int> getMixStageList(string sType, string sProcess, string sDept)
        {
            Dictionary<string, int> dAppSetting = new Dictionary<string, int>();
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();

            lOblAppSetting = getModelList_ByTypeProcessDept(sType, sProcess, sDept);

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {
                if (!dAppSetting.ContainsKey(tmpObj.ITEM.Trim()))
                {
                    dAppSetting.Add(tmpObj.ITEM.Trim(), 0);  //set fixed value 0
                }
            }

            return dAppSetting;
        }
        public Dictionary<string, int> getStartRow_ByType(string sType)
        {
            Dictionary<string, int> dAppSetting = new Dictionary<string, int>();
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();

            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.Row  , "");

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {
              
                if ( tmpObj.ITEM == Common.Model.APP_SETTING_Model.RowItems.START_ROW )
                {
                    int iIndex = 0;
                    if (int.TryParse(tmpObj.VALUE, out iIndex))
                    {
                        dAppSetting.Add(tmpObj.ITEM, iIndex - 1);  //START FROM 0 
                    }
                   
                }
                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.RowItems.IDENTIFY_ITEM_COL_NO)
                {
                    int iIndex = 0;
                    if (int.TryParse(tmpObj.VALUE, out iIndex))
                    {
                        dAppSetting.Add(tmpObj.ITEM, iIndex - 1);  //START FROM 0 
                    }

                }
            }
            

            if (! dAppSetting .ContainsKey(Common.Model.APP_SETTING_Model.RowItems.START_ROW)  )
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getStartRow_ByTypeProcessDept", "No START_ROW setting for type=" + sType.ToString() + ", use default value 0.");
                dAppSetting.Add(Common.Model.APP_SETTING_Model.RowItems.START_ROW, 0);
            }
            if (!dAppSetting.ContainsKey(Common.Model.APP_SETTING_Model.RowItems.IDENTIFY_ITEM_COL_NO))
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getStartRow_ByTypeProcessDept", "No IDENTIFY_ITEM_COL_NO setting for type=" + sType.ToString() + ", use default value -1.");
                dAppSetting.Add(Common.Model.APP_SETTING_Model.RowItems.IDENTIFY_ITEM_COL_NO, -1);  //no setting
            }
            return dAppSetting;
        }


        public string getMatForamt_ByType(string sType)
        {
            string sAppSetting="";
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();
            bool hasSetting = false;
            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.Format, "");

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {

                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.FormatItems.VALIDATION_MAT_FORMAT)
                {
                    hasSetting = true;
                    sAppSetting = tmpObj.VALUE.ToString();
                    break;
                }
            }

            if (!hasSetting )
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getForamt_ByType", "No VALIDATION_MAT_FORMAT setting for type=" + sType.ToString() + ", use default empty value .");
                 
            }

            return sAppSetting;
        }
        public string getMixStartForamt_ByType(string sType)
        {
            string sAppSetting = "";
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();
            bool hasSetting = false;
            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.Format, "");

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {

                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.FormatItems.VALIDATION_MIX_START_FORAMT)
                {
                    hasSetting = true;
                    sAppSetting = tmpObj.VALUE.ToString();
                    break;
                }
            }

            if (!hasSetting)
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getMixStartForamt_ByType", "No VALIDATION_MIX_START_FORAMT setting for type=" + sType.ToString() + ", use default empty value .");

            }

            return sAppSetting;
        }
        public string getMixEndForamt_ByType(string sType)
        {
            string sAppSetting = "";
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();
            bool hasSetting = false;
            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.Format, "");

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {

                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.FormatItems.VALIDATION_MIX_END_FORAMT)
                {
                    hasSetting = true;
                    sAppSetting = tmpObj.VALUE.ToString();
                    break;
                }
            }

            if (!hasSetting)
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getMixEndForamt_ByType", "No VALIDATION_MIX_END_FORAMT setting for type=" + sType.ToString() + ", use default empty value .");

            }

            return sAppSetting;
        }
        public char getSplitChar_ByType(string sType)
        {

            char cAppSetting = new char();
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();
            bool hasSetting = false;
            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.Format, "");

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {
              
                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.FormatItems.SPLIT_CHAR)
                {
                    hasSetting = true;
                    char cChar;
                    if (char.TryParse(tmpObj.VALUE.Replace(@"\t","\t").Replace(@"\r","\r").Replace(@"\n", "\n"), out cChar))
                    {
                        cAppSetting = cChar;
                        break;
                    }

                }
            }

            if (!hasSetting)
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getSplitChar_ByType", "No SPLIT_CHAR setting for type=" + sType.ToString() + ", use default value.");
                
            }

            return cAppSetting;
        }
        public char getMixSplitCharPkg_ByType(string sType)
        {

            char cAppSetting = new char();
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();
            bool hasSetting = false;
            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.Format, "");

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {

                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.FormatItems.MIX_SPLIT_CHAR_PKG)
                {
                    hasSetting = true;
                    char cChar;
                    if (char.TryParse(tmpObj.VALUE.Replace(@"\t", "\t").Replace(@"\r", "\r").Replace(@"\n", "\n"), out cChar))
                    {
                        cAppSetting = cChar;
                        break;
                    }

                }
            }

            if (!hasSetting)
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getMixSplitCharPkg_ByType", "No SPLIT_CHAR setting for type=" + sType.ToString() + ", use default value.");

            }

            return cAppSetting;
        }

        public Dictionary<string, int> getMix01StageList(string sType, string sProcess, string sDept)
        {
            Dictionary<string, int> dAppSetting = new Dictionary<string, int>();
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();

            lOblAppSetting = getModelList_ByTypeProcessDept(sType, sProcess, sDept);

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {
                if (!dAppSetting.ContainsKey(tmpObj.ITEM.Trim()))
                {
                    dAppSetting.Add(tmpObj.ITEM.Trim(), 0);  //set fixed value 0
                }
            }

            return dAppSetting;
        }
        public string getMix01StartForamt_ByType(string sType)
        {
            string sAppSetting = "";
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();
            bool hasSetting = false;
            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.Format, "");

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {

                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.FormatItems.VALIDATION_MIX_START_FORAMT)
                {
                    hasSetting = true;
                    sAppSetting = tmpObj.VALUE.ToString();
                    break;
                }
            }

            if (!hasSetting)
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getMix02StartForamt_ByType", "No VALIDATION_MIX_START_FORAMT setting for type=" + sType.ToString() + ", use default empty value .");

            }

            return sAppSetting;
        }
        public string getMix01EndForamt_ByType(string sType)
        {
            string sAppSetting = "";
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();
            bool hasSetting = false;
            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.Format, "");

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {

                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.FormatItems.VALIDATION_MIX_END_FORAMT)
                {
                    hasSetting = true;
                    sAppSetting = tmpObj.VALUE.ToString();
                    break;
                }
            }

            if (!hasSetting)
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getMix02EndForamt_ByType", "No VALIDATION_MIX_END_FORAMT setting for type=" + sType.ToString() + ", use default empty value .");

            }

            return sAppSetting;
        }   
        public char getMix01SplitCharPkg_ByType(string sType)
        {

            char cAppSetting = new char();
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();
            bool hasSetting = false;
            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.Format, "");

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {

                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.FormatItems.MIX_SPLIT_CHAR_PKG)
                {
                    hasSetting = true;
                    char cChar;
                    if (char.TryParse(tmpObj.VALUE.Replace(@"\t", "\t").Replace(@"\r", "\r").Replace(@"\n", "\n"), out cChar))
                    {
                        cAppSetting = cChar;
                        break;
                    }

                }
            }

            if (!hasSetting)
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getMix02SplitCharPkg_ByType", "No SPLIT_CHAR setting for type=" + sType.ToString() + ", use default value.");

            }

            return cAppSetting;
        }


        public bool getHasHeader_ByType(string sType)
        {
            bool bAppSetting = false;
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();

            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.Format, "");

            bool hasSetting = false;
            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {

                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.FormatItems.HAS_HEADER)
                {
                    hasSetting = true;
                    bool bValue;
                    if (bool.TryParse(tmpObj.VALUE, out bValue))
                    {
                        bAppSetting = bValue;
                        break;
                    }

                }
            }

            if (!hasSetting  )
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getHasHeader_ByType", "No HAS_HEADER setting for type=" + sType.ToString() + ", use default value false.");

            }

            return bAppSetting;
        }
        public string getSheetName_ByType(string sType)
        {
            string sAppSetting = "";
            List<Common.Model.APP_SETTING_Model> lOblAppSetting = new List<APP_SETTING_Model>();
            bool hasSetting = false;
            lOblAppSetting = getModelList_ByTypeProcessDept(sType, Common.Model.APP_SETTING_Model.ProcessItems.File, "");

            foreach (Common.Model.APP_SETTING_Model tmpObj in lOblAppSetting)
            {

                if (tmpObj.ITEM == Common.Model.APP_SETTING_Model.FileItems.SHEET_NAME)
                {
                    hasSetting = true;

                    sAppSetting = tmpObj.VALUE.ToString();
                    break;
                }
            }

            if (!hasSetting)
            {
                DBHelp.Reports.LogFile.DebugLog("Debug", "Common.BLL", "APP_SETTING_BLL", "getSheetName_ByType", "No SHEET_NAME setting for type=" + sType.ToString() + ", use default empty value NA.");

            }
            return sAppSetting;
        }
    }
}

