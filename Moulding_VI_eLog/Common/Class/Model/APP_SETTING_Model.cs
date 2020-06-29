
using System;
namespace Common.Model
{
    /// <summary>
    /// APP_SETTING_Model:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class APP_SETTING_Model
    {
        public APP_SETTING_Model()
        { }
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
            set { _item = value; }
            get { return _item; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VALUE
        {
            set { _value = value; }
            get { return _value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VOID
        {
            set { _void = value; }
            get { return _void; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string REMARK
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DEPARTMENT
        {
            set { _department = value; }
            get { return _department; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROCESS
        {
            set { _process = value; }
            get { return _process; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UPDATED_TIME
        {
            set { _updated_time = value; }
            get { return _updated_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED_USER
        {
            set { _updated_user = value; }
            get { return _updated_user; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TYPE
        {
            set { _type = value; }
            get { return _type; }
        }
        #endregion Model

        public static class TypeItems
        {
            public const string BOM_MatList = "Material list and information";
            public const string Bom_SM = "SM_FN014_BOM";
            public const string Invy_SAP = "Invy_SAP";
            public const string Invy_Promis = "Invy_Promis";
            public const string CBP_PLAN = "CBP_PLAN";
            public const string IC_BUILD_PLAN = "IC_BUILD_PLAN";
            public const string AUTO_PLAN = "AUTO_PLAN";
            public const string HVM_PLAN = "HVM_PLAN";
            public const string PDMIX_ONLINE = "PDMIX_ONLINE";
            public const string PDMIX01_ONLINE = "PDMIX01_ONLINE"; //for mms wastage report
            public const string OPEN_PO = "OPEN_PO";

           public const string SAP_RECEIVED = "SAP_RECEIVED";
            public const string PRE_ALARM = "PRE_ALARM";

        }

        public static class ProcessItems
        {
            public const string Col = "COL";
            public const string Row = "ROW";
            public const string Filter = "FILTER";
            public const string Format = "FORMAT";
            public const string File = "FILE";
            public const string Mixed_Stage = "MIXED_STAGE";
        }


        public static class RowItems
        {
            public const string START_ROW = "START_ROW";
            public const string IDENTIFY_ITEM_COL_NO = "IDENTIFY_ITEM_COL_NO";
        }
        public static class ColItems
        {
             
        }
        public static class FormatItems
        {
            public const string VALIDATION_MAT_FORMAT = "VALIDATION_MAT_FORMAT"; 
            public const string SPLIT_CHAR = "SPLIT_CHAR";
           
            public const string HAS_HEADER = "HAS_HEADER";

            //MIX REPORT
            public const string VALIDATION_MIX_START_FORAMT = "VALIDATION_MIX_START_FORMAT";
            public const string VALIDATION_MIX_END_FORAMT = "VALIDATION_MIX_END_FORMAT";
            public const string MIX_SPLIT_CHAR_PKG = "SPLIT_CHAR_PACKAGE";
        }
        public static class FileItems
        {
            public const string FILE_EXT_NAME = "FILE_EXT_NAME";

            public const string FILE_TYPE = "FILE_TYPE";
            public const string SHEET_NAME = "SHEET_NAME";
        }

    }
}
