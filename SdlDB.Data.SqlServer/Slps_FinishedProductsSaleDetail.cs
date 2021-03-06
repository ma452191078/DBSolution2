﻿using System;
using System.Text;
using System.Data;
using SdlDB.Entity;
using System.Data.SqlClient;

namespace SdlDB.Data.SqlServer
{
    public partial class DataProvider : IDataProvider
    {
        #region  Slps_FinishedProductsSaleDetail

        public DataSet GetSlps_FinishedProductsSaleDetailList(string where)
        {
            string sql = "select * from Slps_FinishedProductsSaleDetail " + where;
            return SQLServerHelper.Query(sql);
        }

        public DataSet GetSlps_FinishedProductsSaleDetailList(string qrcodeScanResult, string sapOrderNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from Slps_FinishedProductsSaleDetail ");
            strSql.Append("where qrcodeScanResult=@qrcodeScanResult ");
            strSql.Append("and sapOrderNo = @sapOrderNo");
            SqlParameter[] parameters = {
                    new SqlParameter("@qrcodeScanResult", SqlDbType.NVarChar,50),
                    new SqlParameter("@sapOrderNo", SqlDbType.NVarChar, 20)
            };
            parameters[0].Value = qrcodeScanResult;
            parameters[1].Value = sapOrderNo;
            return SQLServerHelper.Query(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistSlps_FinishedProductsSaleDetail(string qrcodeScanResult, string sapOrderNo, string lineItemNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Slps_FinishedProductsSaleDetail ");
            strSql.Append("where qrcodeScanResult=@qrcodeScanResult");
            strSql.Append("and sapOrderNo = @sapOrderNo");
            strSql.Append("and lineItemNo = @lineItemNo");
            SqlParameter[] parameters = {
					new SqlParameter("@qrcodeScanResult", SqlDbType.NVarChar,50),
                    new SqlParameter("@sapOrderNo", SqlDbType.NVarChar, 20),
                    new SqlParameter("@lineItemNo", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = qrcodeScanResult;
            parameters[1].Value = sapOrderNo;
            parameters[2].Value = lineItemNo;
            return SQLServerHelper.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int AddSlps_FinishedProductsSaleDetail(Slps_FinishedProductsSaleDetail model)
        {
            if (!ExistSlps_FinishedProductsSaleDetail(model.QrcodeScanResult, model.SapOrderNo, model.LineItemNo))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into Slps_FinishedProductsSaleDetail(");
                strSql.Append("qrcodeScanResult, sapOrderNo, lineItemNo, matnr, maktx,");
                strSql.Append(" lfimg, zfimg, lgort, realZfimg, timeFlag )");
                strSql.Append(" values (");
                strSql.Append("@qrcodeScanResult, @sapOrderNo, @lineItemNo, @matnr, @maktx,");
                strSql.Append(" @lfimg, @zfimg, @lgort, @realZfimg, @timeFlag )");
                SqlParameter[] parameters = {
                    new SqlParameter("@qrcodeScanResult", SqlDbType.NVarChar,50),
					new SqlParameter("@sapOrderNo", SqlDbType.NVarChar,20),
					new SqlParameter("@lineItemNo", SqlDbType.NVarChar,10),
                    new SqlParameter("@matnr", SqlDbType.NVarChar,50),
                    new SqlParameter("@maktx", SqlDbType.NVarChar,50),
                    new SqlParameter("@lfimg", SqlDbType.Decimal),
                    new SqlParameter("@zfimg", SqlDbType.Decimal),
                    new SqlParameter("@lgort", SqlDbType.NVarChar,10),
                    new SqlParameter("@realZfimg", SqlDbType.Decimal),
                    new SqlParameter("@timeFlag", SqlDbType.NVarChar,20)
                    };
                parameters[0].Value = model.QrcodeScanResult;
                parameters[1].Value = model.SapOrderNo;
                parameters[2].Value = model.LineItemNo;
                parameters[3].Value = model.Matnr;
                parameters[4].Value = model.Maktx;
                parameters[5].Value = model.Lfimg;
                parameters[6].Value = model.Zfimg;
                parameters[7].Value = model.Lgort;
                parameters[8].Value = model.RealZfimg;
                parameters[9].Value = model.TimeFlag;

                object obj = SQLServerHelper.GetSingle(strSql.ToString(), parameters);
                if (obj == null)
                {
                    return 1;
                }
                else
                {
                    return Convert.ToInt32(obj);
                }
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateSlps_FinishedProductsSaleDetail(Slps_FinishedProductsSaleDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Slps_FinishedProductsSaleDetail set ");
            strSql.Append("matnr = @matnr,");
            strSql.Append("maktx = @maktx,");
            strSql.Append("lfimg = @lfimg, ");
            strSql.Append("zfimg = @zfimg, ");
            strSql.Append("lgort = @lgort, ");
            strSql.Append("realZfimg = @realZfimg ");
            strSql.Append("where lineItemNo=@lineItemNo ");
            strSql.Append("and sapOrderNo=@sapOrderNo ");
            strSql.Append("and qrcodeScanResult=@qrcodeScanResult ");
            SqlParameter[] parameters = {
                    new SqlParameter("@matnr", SqlDbType.NVarChar,50),
                    new SqlParameter("@maktx", SqlDbType.NVarChar,50),
                    new SqlParameter("@lfimg", SqlDbType.Decimal,13),
                    new SqlParameter("@zfimg", SqlDbType.Decimal,13),
                    new SqlParameter("@lgort", SqlDbType.NVarChar,10),
                    new SqlParameter("@realZfimg", SqlDbType.Decimal,13),
                    new SqlParameter("@lineItemNo", SqlDbType.NVarChar,10),
					new SqlParameter("@sapOrderNo", SqlDbType.NVarChar,20),
					new SqlParameter("@qrcodeScanResult", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Matnr;
            parameters[1].Value = model.Maktx;
            parameters[2].Value = model.Lfimg;
            parameters[3].Value = model.Zfimg;
            parameters[4].Value = model.Lgort;
            parameters[5].Value = model.RealZfimg;
            parameters[6].Value = model.LineItemNo;
            parameters[7].Value = model.SapOrderNo;
            parameters[8].Value = model.QrcodeScanResult;
            
            SQLServerHelper.ExecuteSql(strSql.ToString(), parameters);
        }
        
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteSlps_FinishedProductsSaleDetail(string timeFlag)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Slps_FinishedProductsSaleDetail ");
            strSql.Append("where timeFlag=@timeFlag ");
            SqlParameter[] parameters = {
					new SqlParameter("@timeFlag", SqlDbType.NVarChar,20)};
            parameters[0].Value = timeFlag;
            SQLServerHelper.ExecuteSql(strSql.ToString(), parameters);
        }
        

        #endregion  Slps_FinishedProductsSaleDetail
    }
}
