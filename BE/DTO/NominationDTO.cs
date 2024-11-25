namespace BE.DTO
{
    public class NominationDTO
    {
        public int NominationId { get; set; }
        public Guid NominatorId { get; set; }
        public string Nominator { get; set; }
        public Guid NomineeId { get; set; }
        public string Nominee { get; set; }
        public string Category {get; set; }
        public decimal Points { get; set; }
        public string StatusName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}