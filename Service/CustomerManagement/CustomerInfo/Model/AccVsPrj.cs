using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TadbirModels
{
    /// <summary>
    /// ارتباط پروژه با حساب
    /// </summary>
    /// <remarks>
    /// (ارتباط درختی)
    /// </remarks>
    public class AccVsPrj
    {

        /// <summary>
        /// کد حساب
        /// </summary>
        public string FullId
        {
            get;
            set;
        }


        /// <summary>
        /// شناسهٔ پروژه
        /// </summary>
        public int PrjId
        {
            get;
            set;
        }


        /// <summary>
        /// شناسهٔ دورهٔ مالی
        /// </summary>
        public int FPId
        {
            get;
            set;
        }

    }
}
