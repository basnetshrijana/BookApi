namespace BookApi.Models.RequestModel
{
    public class BookRequestModel
    {
        public string AuthorName{get;set;}=string.Empty;

        public decimal BookPrice{get;set;}
        
        public string BookTitle{get;set;}=string.Empty;
    }
}