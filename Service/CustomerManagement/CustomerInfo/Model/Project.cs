using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TadbirModels
{
    /// <summary>
    /// پروژه
    /// </summary>
    public class Project
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
        /// کد پروژه
        /// </summary>
        public int PCode
        {
            get;
            set;
        }


        /// <summary>
        /// نام پروژه
        /// </summary>
        public string Name
        {
            get;
            set;
        }


        /// <summary>
        /// تاریخ شروع
        /// </summary>
        private DateTime _StartDate;
        public string StartDate
        {
            get { return _StartDate.ToString("yyyy-MM-dd'T'HH:mm:ss", new CultureInfo("en-US")); }
            set { _StartDate = Convert.ToDateTime(value, new CultureInfo("en-US")); }
        }


        /// <summary>
        /// تاریخ پایان
        /// </summary>
        private DateTime _EndDate;
        public string EndDate
        {
            get { return _EndDate.ToString("yyyy-MM-dd'T'HH:mm:ss", new CultureInfo("en-US")); }
            set { _EndDate = Convert.ToDateTime(value, new CultureInfo("en-US")); }
        }


        /// <summary>
        /// درصد پیشرفت
        /// </summary>
        /// <remarks>
        /// میزان پیشرفت
        /// </remarks>
        public int Progress
        {
            get;
            set;
        }


        /// <summary>
        /// مجری پروژه
        /// </summary>
        public string Mojri
        {
            get;
            set;
        }


        /// <summary>
        /// کارفرما
        /// </summary>
        public string KarFarma
        {
            get;
            set;
        }


        /// <summary>
        /// شرح
        /// </summary>
        public string PDesc
        {
            get;
            set;
        }


        /// <summary>
        /// بدهکار
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
        /// کد دوره مالی
        /// </summary>
        public int FPId
        {
            get;
            set;
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

    }
}
