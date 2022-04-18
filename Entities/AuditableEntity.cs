namespace BookApi.Entities
{
    public class AuditableEntity : IdentifiableEntity
    {
        /// <summary>
        /// Get or set created by
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Get or set created on
        /// </summary>
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Get or set updated by
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Get or set updated on
        /// </summary>
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow; 
    }
}