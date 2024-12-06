using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlogPosting.Posting.Infrastructure.Models
{
    public class PublishPostModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PostingId { get; set; }
        public required Guid Id { get; set; }
        public required string UserCode { get; set; }
        public required string Title { get; set; }
        public required string PostingContent { get; set; }
        public bool State { get; set; } = true;
        public string? ImageUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
