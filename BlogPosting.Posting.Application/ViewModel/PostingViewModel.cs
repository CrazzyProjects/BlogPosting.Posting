namespace BlogPosting.Posting.Application.ViewModel
{
    public class PostingViewModel
    {
        public required Guid Id { get; set; }
        public required string UserCode { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public string? ImageUrl { get; set; }
        public required long Likes { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
