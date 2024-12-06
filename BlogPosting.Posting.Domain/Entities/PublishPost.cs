namespace BlogPosting.Posting.Domain.Entities
{
    public class PublishPost
    {
        public long PostingId { get; set; }
        public required Guid Id { get; set; }
        public required string UserCode { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public bool State { get; set; } = true;
        public string? ImageUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
