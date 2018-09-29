using System.ComponentModel.DataAnnotations;

namespace SecretTarot.Module.Comments.ViewModels
{
    public class CommentForm
    {
        [Required]
        public string CommentText { get; set; }

        public string CommenterName { get; set; }

        public long? ParentId { get; set; }

        public long EntityId { get; set; }

        public string EntityTypeId { get; set; }
    }
}
