using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TadbirModels
{
    /// <summary>
    /// ارتباط مرکز هزینه با حساب
    /// </summary>
    /// <remarks>
    /// (ارتباط درختی)
    /// </remarks>
    public class AccVsCC
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
        /// شناسهٔ مرکز هزینه
        /// </summary>
        public int CCId
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
