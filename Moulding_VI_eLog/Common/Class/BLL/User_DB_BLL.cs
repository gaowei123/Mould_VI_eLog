using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Model;
namespace Common.BLL
{
    public class User_DB_BLL
    {
        private readonly Common.DAL.User_DB_DAL dal = new Common.DAL.User_DB_DAL();
        public User_DB_Model Validate_User(string sUserID, string sPassword)
        {
            User_DB_Model objUser = new User_DB_Model();

            objUser = dal.GetModel(sUserID);
            if (objUser == null)
            { return null; }
            else
            {
                if (objUser.Password != sPassword)
                {
                    return null;
                }
                else
                {
                    return objUser;
                }
            }
        }

        public bool CheckIDPassword(string sUserID, string sPassword)
        {
           return dal.CheckIDPassword(sUserID,sPassword);
        }

    }
}
