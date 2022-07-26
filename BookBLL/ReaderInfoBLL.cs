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
    public class ReaderInfoBLL
    {
        /// <summary>
        /// 读者信息表数据访问类
        /// </summary>
        ReaderInfoDAL readerInfo = new ReaderInfoDAL();

        /// <summary>
        /// 图书借还信息表数据访问类
        /// </summary>
        BookBorrowReturnInfoDAL bookBorrowReturnInfoDAL = new BookBorrowReturnInfoDAL();

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

        /// <summary>
        /// 根据id删除读者信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MessageEnum DelReader(string readerId)
        {
            //判断读者是否还有未还图书
            if (bookBorrowReturnInfoDAL.FindBookBorrowInfo(readerId).Rows.Count == 0)
            {
                if (readerInfo.DelReader(readerId) > 0)
                {
                    return MessageEnum.Del_OK;
                }
            }else
            {
                return MessageEnum.Reader_BookReturn;
            }

            return MessageEnum.Del_NotErr;
        }

        /// <summary>
        /// 添加读者信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public MessageEnum AddReader(ReaderInfoModel model)
        {
            if (readerInfo.AddReader(model)>0)
            {
                return MessageEnum.Add_OK;
            }
            return MessageEnum.Add_NotErr;
        }

        /// <summary>
        /// 修改读者信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public MessageEnum UpdReader(ReaderInfoModel model)
        {
            if (readerInfo.ReaderUpd(model) > 0)
            {
                return MessageEnum.Upd_OK;
            }
            return MessageEnum.Upd_NoErr;
        }

    }
}
