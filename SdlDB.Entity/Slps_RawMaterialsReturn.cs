﻿/**
* 原材料退货
* 2017-08-28 15:13:24
**/

namespace SdlDB.Entity
{
    public class Slps_RawMaterialsReturn
    {
        public Slps_RawMaterialsReturn()
        {

        }
        private string qrcodeScanResult;    //二维码扫描结果
        private string sapOrderNo;  //sap订单号
        private string carNo;   //车牌号
        private string timeFlag;    //时间戳
        private string factory; //工厂编号
        private string dbNum;   //地磅编号
        private string enterWeightMan;  //入场司磅员
        private string exitWeightMan;  //出场司磅员
        private string enterTime;   //入场时间
        private string exitTime;    //出场时间
        private decimal tare;   //皮重
        private decimal gross;  //毛重
        private decimal net;    //净重
        private string exitFlag;//空车出场标识
        private decimal deuctNum;   //差异
        private decimal trayWeight;
        private decimal trayQuantity;
        private string hs_flag;

        public string QrcodeScanResult
        {
            get
            {
                return qrcodeScanResult;
            }

            set
            {
                qrcodeScanResult = value;
            }
        }

        public string SapOrderNo
        {
            get
            {
                return sapOrderNo;
            }

            set
            {
                sapOrderNo = value;
            }
        }

        public string CarNo
        {
            get
            {
                return carNo;
            }

            set
            {
                carNo = value;
            }
        }

        public string TimeFlag
        {
            get
            {
                return timeFlag;
            }

            set
            {
                timeFlag = value;
            }
        }

        public string Factory
        {
            get
            {
                return factory;
            }

            set
            {
                factory = value;
            }
        }

        public string DbNum
        {
            get
            {
                return dbNum;
            }

            set
            {
                dbNum = value;
            }
        }

        public string EnterWeightMan
        {
            get
            {
                return enterWeightMan;
            }

            set
            {
                enterWeightMan = value;
            }
        }

        public string ExitWeightMan
        {
            get
            {
                return exitWeightMan;
            }

            set
            {
                exitWeightMan = value;
            }
        }

        public string EnterTime
        {
            get
            {
                return enterTime;
            }

            set
            {
                enterTime = value;
            }
        }

        public string ExitTime
        {
            get
            {
                return exitTime;
            }

            set
            {
                exitTime = value;
            }
        }

        public decimal Tare
        {
            get
            {
                return tare;
            }

            set
            {
                tare = value;
            }
        }

        public decimal Gross
        {
            get
            {
                return gross;
            }

            set
            {
                gross = value;
            }
        }

        public decimal Net
        {
            get
            {
                return net;
            }

            set
            {
                net = value;
            }
        }

        public string ExitFlag
        {
            get
            {
                return exitFlag;
            }

            set
            {
                exitFlag = value;
            }
        }

        public decimal DeuctNum
        {
            get
            {
                return deuctNum;
            }

            set
            {
                deuctNum = value;
            }
        }

        public decimal TrayWeight
        {
            get
            {
                return trayWeight;
            }

            set
            {
                trayWeight = value;
            }
        }

        public decimal TrayQuantity
        {
            get
            {
                return trayQuantity;
            }

            set
            {
                trayQuantity = value;
            }
        }

        public string Hs_flag
        {
            get
            {
                return hs_flag;
            }

            set
            {
                hs_flag = value;
            }
        }
    }
}
