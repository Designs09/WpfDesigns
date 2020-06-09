using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFramework.Controls
{
    public class DateRangeDesignModel : DateRangeViewModel
    {
        #region 单例

        /// <summary>
        /// 同步锁
        /// </summary>
        private static readonly object _objLock = new object();

        /// <summary>
        /// 单例字段
        /// </summary>
        private static DateRangeDesignModel _instance = null;

        /// <summary>
        /// 单例属性
        /// </summary>
        public static DateRangeDesignModel Instance
        {
            get
            {
                if (_instance == null)
                    lock (_objLock)
                        if (_instance == null)
                            _instance = new DateRangeDesignModel();
                return _instance;
            }
        }

        #endregion

        private DateRangeDesignModel() { }
    }
}
