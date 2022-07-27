using BookModel;
using Common.Enum;
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
    public class ReaderInfo_BLL
    {
        /// <summary>
        /// 读者信息数据访问类
        /// </summary>
        ReaderInfo_DAL readerInfoDAL = new ReaderInfo_DAL();

        /// <summary>
        /// 图书借还信息数据访问类
        /// </summary>
        BookBorrowReturnInfo_DAL bookBorrowReturnInfoDAL = new BookBorrowReturnInfo_DAL();

        /// <summary>
        ///获取读者信息列表 
        /// </summary>
        /// <returns></returns>
        public DataTable FindReaders()=> readerInfoDAL.FindReaders();

        /// <summary>
        ///根据读者id获取读者信息列表 
        /// </summary>
        /// <returns></returns>
        public DataTable FindReaders(string readerId)=> readerInfoDAL.GetReader(readerId);

        /// <summary>
        /// 根据id删除读者信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Message_Enum DelReader(string readerId)
        {
            //判断读者是否还有未还图书
            if (bookBorrowReturnInfoDAL.FindBookBorrowInfo(readerId).Rows.Count == 0)
            {
                if (readerInfoDAL.DelReader(readerId) > 0)
                {
                    return Message_Enum.Del_OK;
                }
            }else
            {
                return Message_Enum.Reader_BookReturn;
            }

            return Message_Enum.Del_NotErr;
        }

        /// <summary>
        /// 添加读者信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Message_Enum AddReader(ReaderInfoModel model)
        {
            if (readerInfoDAL.AddReader(model)>0)
            {
                return Message_Enum.Add_OK;
            }
            return Message_Enum.Add_NotErr;
        }

        /// <summary>
        /// 修改读者信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Message_Enum UpdReader(ReaderInfoModel model)
        {
            if (readerInfoDAL.ReaderUpd(model) > 0)
            {
                return Message_Enum.Upd_OK;
            }
            return Message_Enum.Upd_NoErr;
        }

    }
}
