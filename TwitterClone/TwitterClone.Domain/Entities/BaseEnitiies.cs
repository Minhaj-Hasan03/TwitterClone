
namespace TwitterClone.Domain.Entities
{
    public class BaseEnitiies
    {
       


        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }
        public Guid CreatedBy { get; private set; }
        public Guid? ModifiedBy { get; private set; }

     

        public BaseEnitiies( Guid id ) {
            Id = id;
            CreatedAt = DateTime.UtcNow;
        }

        public void MarkAsModified()
        {
            ModifiedAt = DateTime.UtcNow;
        }


        public virtual string Description()
        {
            return $"BaseEntity: Id: {Id}, CreatedAt: {CreatedAt}, ModifiedAt: {ModifiedAt}, CreatedBy: {CreatedBy}, ModifiedBy: {ModifiedAt}";
        }




    }
}
