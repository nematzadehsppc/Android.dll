using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TadbirModels
{
    /// <remarks>
    /// خریداران و فروشندگان (فیلد Type نوع طرف حساب شامل خریدار، فروشنده، خریدار و فروشنده و واسطهٔ فروش را مشخص می‌کند).
    /// </remarks>
    public class Customer
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
        /// نوع طرف حساب
        /// </summary>
        /// <remarks>
        /// 0 = فروشنده و خریدار
        /// 1 = فروشنده (تنها در عملیات خرید قابل انتخاب است)
        /// 2 = خریدار (تنها در عملیات فروش قابل انتخاب است)
        /// 3 = واسطهٔ فروش (تنها در عملیات فروش قابل انتخاب است)
        /// </remarks>
        public int Type
        {
            get;
            set;
        }


        /// <summary>
        /// کد حساب
        /// </summary>
        /// <remarks>
        /// حساب وابسته به مشتری
        /// </remarks>
        public string AccId
        {
            get;
            set;
        }


        /// <summary>
        /// شناسهٔ تفصیلی شناور
        /// </summary>
        public int FAccId
        {
            get;
            set;
        }


        /// <summary>
        /// حساب پیش پرداخت
        /// </summary>
        public string PrePayAccId
        {
            get;
            set;
        }


        /// <summary>
        /// حساب پیش دریافت
        /// </summary>
        public string PreRcvAccId
        {
            get;
            set;
        }


        /// <summary>
        /// درصد استهلاک پیش پرداخت
        /// </summary>
        public double PrePayDepr
        {
            get;
            set;
        }


        /// <summary>
        /// درصد استهلاک پیش دریافت
        /// </summary>
        public double PreRcvDepr
        {
            get;
            set;
        }


        /// <summary>
        /// اعتبار
        /// </summary>
        public double Credit
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
        /// تلفن
        /// </summary>
        public string PhoneNo
        {
            get;
            set;
        }


        /// <summary>
        /// فکس
        /// </summary>
        public string FaxNo
        {
            get;
            set;
        }


        /// <summary>
        /// ایمیل
        /// </summary>
        /// <remarks>
        /// آدرس اینترنت
        /// </remarks>
        public string Email
        {
            get;
            set;
        }


        /// <summary>
        /// کد اقتصادی
        /// </summary>
        public string EcCode
        {
            get;
            set;
        }


        /// <summary>
        /// آدرس
        /// </summary>
        public string Address
        {
            get;
            set;
        }


        /// <summary>
        /// توضیحات
        /// </summary>
        public string CDesc
        {
            get;
            set;
        }


        /// <summary>
        /// مبلغ ارز
        /// </summary>
        public double CurrencyVal
        {
            get;
            set;
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
        /// کد پستی
        /// </summary>
        public string ZipCode
        {
            get;
            set;
        }


        /// <summary>
        /// اعتبار
        /// </summary>
        /// <remarks>
        /// ماندهٔ اولیه
        /// مقدار مثبت = بدهکار
        /// مقدار منفی = بستانکار
        /// </remarks>
        public double InitBal
        {
            get;
            set;
        }


        /// <summary>
        /// کاربر
        /// </summary>
        public int UserId
        {
            get;
            set;
        }


        public int SecId
        {
            get;
            set;
        }


        /// <summary>
        /// آخرین ساعت ویرایش
        /// </summary>
        /// <remarks>
        /// در بعضی از نسخه ها به علت وجود باگ در این فیلد تاریخ ذخیره شده
        /// ---
        /// از نسخه 8.2 به بعد این ساعت، ساعت ایجاد است.
        /// </remarks>
        private DateTime _ETime;
        public string ETime
        {
            get { return _ETime.ToString("yyyy-MM-dd'T'HH:mm:ss", new CultureInfo("en-US"));}
            set { _ETime = Convert.ToDateTime(value, new CultureInfo("en-US")); }
        }


        /// <summary>
        /// آخرین تاریخ ویرایش
        /// </summary>
        /// <remarks>
        /// در بعضی از نسخه ها به علت وجود باگ در این فیلد ساعت ذخیره شده
        /// ---
        /// از نسخه 8.2 به بعد این تاریخ، تاریخ ایجاد است.
        /// </remarks>
        private DateTime _EDate;
        public string EDate
        {
            get { return _EDate.ToString("yyyy-MM-dd'T'HH:mm:ss", new CultureInfo("en-US")); }
            set { _EDate = Convert.ToDateTime(value, new CultureInfo("en-US")); }
        }


        /// <summary>
        /// قیمت فروش پیشنهادی
        /// </summary>
        /// <remarks>
        /// برای مشتری متفرقه مقدار قیمت فروش پیشنهادی در یک سطر صفر نگهداری می‌شود.
        /// </remarks>
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
        /// شناسهٔ دوره مالی
        /// </summary>
        public int FPId
        {
            get;
            set;
        }


        /// <summary>
        /// درصد تخفیف نقدی
        /// </summary>
        /// <remarks>
        /// در صورت ایجاد فاکتور خرید یا فروش با فعال بودن گزینهٔ «تسویهٔ نقدی» برای این طرف حساب، با کلیک بر روی دکمهٔ «تخفیف» از این مقدار استفاده می‌شود.
        /// </remarks>
        public double Discount1
        {
            get;
            set;
        }


        /// <summary>
        /// درصد تخفیف غیرنقدی
        /// </summary>
        /// <remarks>
        /// در صورت ایجاد فاکتور خرید یا فروش در صورت غیرفعال بودن گزینهٔ «تسویهٔ نقدی» برای این طرف حساب، با کلیک بر روی دکمهٔ «تخفیف» از این مقدار استفاده می‌شود.
        /// </remarks>
        public double Discount2
        {
            get;
            set;
        }


        /// <summary>
        /// نام گروه
        /// </summary>
        public string GroupName
        {
            get;
            set;
        }


        /// <summary>
        /// استان
        /// </summary>
        public string Province
        {
            get;
            set;
        }


        /// <summary>
        /// شهر
        /// </summary>
        public string City
        {
            get;
            set;
        }


        /// <summary>
        /// منطقه
        /// </summary>
        public string Zone
        {
            get;
            set;
        }


        /// <summary>
        /// شماره اشتراک
        /// </summary>
        public string SubscriptionNo
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
        /// شناسه پروژه
        /// </summary>
        public int PrjId
        {
            get;
            set;
        }


        /// <summary>
        /// تفصیلی شناور پیش پرداخت
        /// </summary>
        public int PrePayFAccId
        {
            get;
            set;
        }


        /// <summary>
        /// مرکز هزینه پیش پرداخت
        /// </summary>
        public int PrePayCCId
        {
            get;
            set;
        }


        /// <summary>
        /// پروژه پیش پرداخت
        /// </summary>
        public int PrePayPrjId
        {
            get;
            set;
        }


        /// <summary>
        /// تفصیلی شناور پیش دریافت
        /// </summary>
        public int PreRcvFAccId
        {
            get;
            set;
        }


        /// <summary>
        /// مرکز هزینه پیش دریافت
        /// </summary>
        public int PreRcvCCId
        {
            get;
            set;
        }


        /// <summary>
        /// پروژه پیش دریافت
        /// </summary>
        public int PreRcvPrjId
        {
            get;
            set;
        }


        /// <summary>
        /// شهرستان
        /// </summary>
        public string TownShip
        {
            get;
            set;
        }


        /// <summary>
        /// کدپستی
        /// </summary>
        public string PostalCode
        {
            get;
            set;
        }


        /// <summary>
        /// شماره ثبت/کد ملی
        /// </summary>
        public string RegisterCode
        {
            get;
            set;
        }


        /// <summary>
        /// فعال
        /// </summary>
        public int Active
        {
            get;
            set;
        }


        /// <summary>
        /// مشمول مالیات
        /// </summary>
        public int MashmoolMaliat
        {
            get;
            set;
        }


        /// <summary>
        /// تلفن همراه
        /// </summary>
        public string MobileNo
        {
            get;
            set;
        }


        /// <summary>
        /// مهلت پرداخت
        /// </summary>
        public int MohlatePardakht
        {
            get;
            set;
        }

    }
}
