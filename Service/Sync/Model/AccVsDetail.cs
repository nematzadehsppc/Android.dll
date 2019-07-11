using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TadbirModels
{
    /// <summary>
    /// حساب وابسته به تفصیلی شناور
    /// </summary>
    /// <remarks>
    /// ارتباط حساب و تفصیلی شناور
    /// </remarks>
    public class AccVsDetail
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
        /// تفصیلی
        /// </summary>
        public int DetId
        {
            get;
            set;
        }


        /// <summary>
        /// کد تفصیلی
        /// </summary>
        public string DetFullId
        {
            get;
            set;
        }


        /// <summary>
        /// ضروری
        /// </summary>
        /// <remarks>
        /// تفصیلی جز تفصیلیهای ضروری حساب وابسته می‌باشد یا خیر.
        /// </remarks>
        public int Necessary
        {
            get;
            set;
        }


        /// <summary>
        /// کد دوره مالی
        /// </summary>
        public int FPId
        {
            get;
            set;
        }

    }
}
