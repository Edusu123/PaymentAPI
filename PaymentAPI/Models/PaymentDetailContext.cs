using Microsoft.EntityFrameworkCore;

namespace PaymentAPI.Models
{
    public class PaymentDetailContext : DbContext
    {
        PaymentDetailContext(DbContextOptions<PaymentDetailContext> paymentDetailContext) : base(paymentDetailContext) { }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
