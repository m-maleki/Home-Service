using System.ComponentModel.DataAnnotations;

namespace HS.Domain.Core.Enums
{
    public enum OrderStatusEnum
    {
        [Display(Name= "منتظر پیشنهاد متخصصان")]
        WaitingExpertAdvice =1,
        [Display(Name = "منتظر انتخاب متخصص")]
        WaitingSpecialistSelection = 2, 
        [Display(Name = "منتظر آمدن متخصص به محل شما")]
        WaitingSpecialistComeToYourPlace = 3,
        [Display(Name = "شروع شده")]
        Started = 4, 
        [Display(Name = "انجام شده")]
        Done = 5,
        [Display(Name = "پرداخت شده ")]
        Paid = 6
    }
}
