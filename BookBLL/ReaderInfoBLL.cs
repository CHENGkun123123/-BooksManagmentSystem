using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBLL
{
    /// <summary>
    /// 读者信息相关业务类
    /// </summary>
    public class ReaderInfoBLL
    {
        /// <summary>
        /// 读者信息表数据访问类
        /// </summary>
        ReaderInfoDAL readerInfo = new ReaderInfoDAL();

        /// <summary>
        ///获取读者信息列表 
        /// </summary>
        /// <returns></returns>
        public DataTable FindReaders()
        {
           return readerInfo.FindReaders();
        }

        /// <summary>
        ///根据读者id获取读者信息列表 
        /// </summary>
        /// <returns></returns>
        public DataTable FindReaders(string readerId)
        {
            return readerInfo.GetReader(readerId);
        }

    }
}
