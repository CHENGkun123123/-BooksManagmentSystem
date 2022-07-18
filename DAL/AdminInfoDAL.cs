﻿using BookModel;
using Common.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 管理员数据访问层
    /// </summary>
    public class AdminInfoDAL
    {
        /// <summary>
        /// 根据用户名获取管理员信息
        /// </summary>
        /// <param name="admin">管理员实体类</param>
        /// <returns></returns>
        public DataTable GetAdminInfo(AdminInfoModel admin)
        {
            string sql = "select * from AdminInfo where AdminID = @name";

            SqlParameter[] pars =
            {
                new SqlParameter("@name" , admin.AdminID),
            };

            return SqlDBHelper.ExecuteDataTable(sql, pars);
        }
    }
}