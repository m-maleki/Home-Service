using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Enums
{
    public enum OrderStatusEnum
    {
        WaitingExpertAdvice , // منتظر پیشنهاد متخصصان
        WaitingSpecialistSelection, // منتظر انتخاب متخصص
        WaitingSpecialistComeToYourPlace, //منتشر آمدن متخصص به محل شما
        Started, // شروع شده 
        Done, // انجام شده
        Paid  //پرداخت شده 
    }
}
