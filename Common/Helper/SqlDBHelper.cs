using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Common.Helper
{
    /// <summary>
    /// 数据库访问帮助类
    /// </summary>
    public class SqlDBHelper
    {
        //数据库连接字符串字段
        protected static string _connString;
        //数据库连接字符串属性
        public static string ConnString
        {
            //指向app.config配置文件配置好的数据库连接字符串
            get => ConfigurationManager.ConnectionStrings["SQLServerBooks"].ToString();
        }

        /// <summary>
        /// 执行非查询操作，增删改
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">可变参数</param>
        /// <returns>受影响行数</returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] pars)
        {
            //创建连接对象
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                //打开连接
                conn.Open();
                //创建command连接对象
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //判断参数是否为空
                    if (pars != null)
                    {
                        //添加参数
                        cmd.Parameters.AddRange(pars);
                    }
                    //返回受影响行数
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 执行事务非查询操作，增删改
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">可变参数</param>
        /// <returns>受影响行数</returns>
        public static bool ExecuteNonQueryT(string[] sql, List<SqlParameter[]> parslist)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                using (SqlTransaction stn = conn.BeginTransaction())
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        try
                        {
                            cmd.Connection = conn;
                            cmd.Transaction = stn;
                            for (int i = 0; i < sql.Length; i++)
                            {
                                cmd.CommandText = sql[i];
                                cmd.Parameters.AddRange(parslist[i]);
                                cmd.ExecuteNonQuery();
                            }
                            stn.Commit();
                            return true;
                            
                        }
                        catch (Exception ex)
                        {
                            //事务回滚
                            stn.Rollback();
                            return false;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 执行首行查询方法
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="pms">可变参数</param>
        /// <returns>返回查询结果中的第一行第一列的值</returns>
        public static Object ExecuteScaler(string sql, params SqlParameter[] pars)
        {
            //创建连接对象
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                //打开连接
                conn.Open();
                //创建command连接对象
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //判断参数是否为空
                    if (pars != null)
                    {
                        //添加参数
                        cmd.Parameters.AddRange(pars);
                    }
                    //返回结果集中的第一行第一列
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 执行DataTable查询方法
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="pars">可变参数</param>
        /// <returns>返回DataTable数据表</returns>
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] pars)
        {
            //创建连接对象
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                //创建适配器对象
                using (SqlDataAdapter sda = new SqlDataAdapter(sql, conn))
                {

                    //创建数据表接收查询结果集
                    DataSet ds = new DataSet();
                    //判断参数是否为空
                    if (pars != null)
                    {
                        //添加参数
                        sda.SelectCommand.Parameters.AddRange(pars);
                    }
                    //执行结果，fill方法内部自动打开连接，不需要comm.open();
                    sda.Fill(ds, "table");
                    //返回结果集
                    return ds.Tables["table"];
                }

            }
        }

        /// <summary>
        /// 使用DataReader方式读取数据
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="pars">可变参数</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteDataReader(string sql, params SqlParameter[] pars)
        {
            //创建连接对象
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                //打开连接
                conn.Open();
                //创建command连接对象
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //判断参数是否为空
                    if (pars != null)
                    {
                        //添加参数
                        cmd.Parameters.AddRange(pars);
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //判断是否有数据
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                return reader;
                            } 
                        }
                        
                    }
                }
            }
            return null;
        }

    }
}
