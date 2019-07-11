using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace TadbirModels
{
    /// <summary>
    /// تفصیلی شناور
    /// </summary>
    public class DetailAcc
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
        /// نام
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
        /// 4 = سطح اول
        /// 5 = سطح دوم
        /// 6 = سطح سوم
        /// 7 = سطح چهارم
        /// </remarks>
        public int AccLevel
        {
            get;
            set;
        }


        /// <summary>
        /// کد سطح اول
        /// </summary>
        public string T1
        {
            get;
            set;
        }


        /// <summary>
        /// کد سطح دوم
        /// </summary>
        public string T2
        {
            get;
            set;
        }


        /// <summary>
        /// کد سطح سوم
        /// </summary>
        public string T3
        {
            get;
            set;
        }


        /// <summary>
        /// کد سطح چهارم
        /// </summary>
        public string T4
        {
            get;
            set;
        }


        /// <summary>
        /// کد سطح پنجم
        /// </summary>
        public string T5
        {
            get;
            set;
        }


        /// <summary>
        /// کد سطح ششم
        /// </summary>
        public string T6
        {
            get;
            set;
        }


        /// <summary>
        /// کد سطح هفتم
        /// </summary>
        public string T7
        {
            get;
            set;
        }


        /// <summary>
        /// کد سطح هشتم
        /// </summary>
        public string T8
        {
            get;
            set;
        }


        /// <summary>
        /// مانده ابتدا - بدهکاری
        /// </summary>
        private string _Debit;
        public Decimal Debit
        {
            get { return decimal.Parse(_Debit); }
            set { _Debit = String.Format("{0:F0}", value); }
        }


        /// <summary>
        /// بستانکار
        /// </summary>
        private string _Credit;
        public Decimal Credit
        {
            get { return decimal.Parse(_Credit); }
            set { _Credit = String.Format("{0:F0}", value); }
        }


        /// <summary>
        /// بودجه
        /// </summary>
        private string _Budget;
        public Decimal Budget
        {
            get { return decimal.Parse(_Budget); }
            set { _Budget = String.Format("{0:F0}", value); }
        }


        /// <summary>
        /// بودجهٔ ارزی
        /// </summary>
        /// <remarks>
        /// حدسی
        /// </remarks>
        private string _CurrencyBudget;
        public Decimal CurrencyBudget
        {
            get { return decimal.Parse(_CurrencyBudget); }
            set { _CurrencyBudget = String.Format("{0:F0}", value); }
        }


        /// <summary>
        /// نرخ ارز
        /// </summary>
        private string _CurrencyVal;
        public Decimal CurrencyVal
        {
            get { return decimal.Parse(_CurrencyVal); }
            set { _CurrencyVal = String.Format("{0:F0}", value); }
        }


        /// <summary>
        /// نوع ارز
        /// </summary>
        public int CurrencyId
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
