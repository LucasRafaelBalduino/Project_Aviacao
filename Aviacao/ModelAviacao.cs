namespace Aviacao
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelAviacao : DbContext
    {        
        public ModelAviacao()
            : base("name=ModelAviacao")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Passagem>()
                .HasOptional<FormaDePagamento>(f => f.Pagamento)
                .WithOptionalPrincipal<Passagem>(f => f.Passagem);
                
        }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}