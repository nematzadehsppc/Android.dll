using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TadbirModels
{
    /// <summary>
    /// حساب
    /// </summary>
    public class Account
    {

        /// <summary>
        /// شناسه
        /// </summary>
        public int Id
        {
            get;
            set;
        }


        /// <summary>
        /// نام حساب
        /// </summary>
        public string Name
        {
            get;
            set;
        }


        /// <summary>
        /// سطح
        /// </summary>
        /// <remarks>
        /// 1 = کل
        /// 2 = معین
        /// 3 = تفصیلی
        /// </remarks>
        public int AccLevel
        {
            get;
            set;
        }


        /// <summary>
        /// گروه حساب
        /// </summary>
        public int Category
        {
            get;
            set;
        }


        /// <summary>
        /// حساب والد (معین برای تفصیلیها، کل برای معینها)
        /// </summary>
        public string ParentId
        {
            get;
            set;
        }


        /// <summary>
        /// کد حساب
        /// </summary>
        public string FullId
        {
            get;
            set;
        }


        /// <summary>
        /// بدهکار
        /// </summary>
        public double Debit
        {
            get;
            set;
        }


        /// <summary>
        /// بستانکار
        /// </summary>
        public double Credit
        {
            get;
            set;
        }


        /// <summary>
        /// توضیح
        /// </summary>
        public string AccDesc
        {
            get;
            set;
        }


        /// <summary>
        /// بودجه
        /// </summary>
        public double Budget
        {
            get;
            set;
        }


        /// <summary>
        /// سیستم ثبت موجودی
        /// </summary>
        public int SType
        {
            get;
            set;
        }


        /// <summary>
        /// دوره مالی
        /// </summary>
        public int FPId
        {
            get;
            set;
        }


        /// <summary>
        /// حساب والد والد (کل برای تفصیلیها)
        /// </summary>
        public string GrParentId
        {
            get;
            set;
        }


        /// <summary>
        /// بودجه ارزی
        /// </summary>
        /// <remarks>
        /// حدسی
        /// </remarks>
        public double CurrencyBudget
        {
            get;
            set;
        }


        /// <summary>
        /// نرخ ارز
        /// </summary>
        public double CurrencyVal
        {
            get;
            set;
        }


        /// <summary>
        /// کد ارز
        /// </summary>
        public int CurrencyId
        {
            get;
            set;
        }


        /// <summary>
        /// فیلد رزرو از نوع smallint
        /// </summary>
        public int LRes
        {
            get;
            set;
        }


        /// <summary>
        /// فیلد رزرو از نوع real
        /// </summary>
        public double DRes
        {
            get;
            set;
        }


        /// <summary>
        /// فیلد رزرو از نوع متن
        /// </summary>
        public string TRes
        {
            get;
            set;
        }

    }
}
