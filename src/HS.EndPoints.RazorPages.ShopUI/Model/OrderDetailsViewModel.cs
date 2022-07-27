namespace HS.EndPoints.RazorPages.UI.Model
{
    public class OrderDetailsViewModel
    {
        public ICollection<SuggestionViewModel> suggestions = new List<SuggestionViewModel>();
        public ICollection<OrderFileViewModel> orderFiles = new List<OrderFileViewModel>();
        public OrderViewModel Order = new OrderViewModel();
    }
}