using System;
using System.Data;
using System.Collections.Generic;
using Common.Model;
using System.Data.SqlClient;

namespace Common.BLL
{
    public class MouldingMoldLife_BLL
    {
        private readonly Common.DAL.MouldingMoldLife_DAL dal = new Common.DAL.MouldingMoldLife_DAL();
        public MouldingMoldLife_BLL()
        { }

        public bool Update(Common.Model.MouldingMoldLife model)
        {
            return dal.Update(model);
        }

        public bool Add(Common.Model.MouldingMoldLife model)
        {
            return dal.Add(model);
        }

        public Common.Model.MouldingMoldLife GetModel(string partallnumber)
        {
            return dal.GetModel(partallnumber);
        }
    }
}
