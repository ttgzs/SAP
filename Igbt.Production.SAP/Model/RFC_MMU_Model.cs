﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igbt.Production.SAP.Model
{
    public class RFC_MMU_Model
    {
        private string _FunctionModule;
        private string _I_MESKEY;
        private DateTime _I_DATE;
        private DateTime _I_TIME;
        private string _I_USER;
        private string _I_MATNR;
        private string _E_SAP_MMU;

        /// <summary>
        /// SAP函数接口名称
        /// </summary>
        public string FunctionModule
        {
            set { _FunctionModule = value; }
            get { return _FunctionModule; }
        }
        /// <summary>
        /// SAP数据库表
        /// </summary>
        public string E_SAP_MMU
        {
            set { _E_SAP_MMU = value; }
            get { return _E_SAP_MMU; }

        }

        /// <summary>
        /// 
        /// </summary>
        public string I_MESKEY
        {
            set { _I_MESKEY = value; }
            get { return _I_MESKEY; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime I_DATE
        {
            set { _I_DATE = value; }
            get { return _I_DATE; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime I_TIME
        {
            set { _I_TIME = value; }
            get { return _I_TIME; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string I_USER
        {
            set { _I_USER = value; }
            get { return _I_USER; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string I_MATNR
        {
            set { _I_MATNR = value; }
            get { return _I_MATNR; }
        }
    }
}
