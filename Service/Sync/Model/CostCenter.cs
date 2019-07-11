using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TadbirModels
{
    /// <summary>
    /// مرکز هزینه
    /// </summary>
    public class CostCenter
    {

        /// <summary>
        /// کد
        /// </summary>
        /// <remarks>
        /// شناسۀ رکورد
        /// </remarks>
        public int Id
        {
            get;
            set;
        }


        /// <summary>
        /// کد مرکز هزینه
        /// </summary>
        public int CCCode
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
        /// شرح
        /// </summary>
        public string CCDesc
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
        /// <remarks>
        /// حدسی
        /// </remarks>
        private string _Budget;
        public Decimal Budget
        {
            get { return decimal.Parse(_Budget); }
            set { _Budget = String.Format("{0:F0}", value); }
        }


        /// <summary>
        /// کد دوره مالی
        /// </summary>
        /// <remarks>
        /// شناسۀ دورۀ مالی
        /// </remarks>
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


        /// <summary>
        /// کد متنی مرکز هزینه
        /// </summary>
        public string CTextCode
        {
            get;
            set;
        }

    }
}
