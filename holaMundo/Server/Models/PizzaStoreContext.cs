namespace holaMundo.Server.Models
{
    using Microsoft.EntityFrameworkCore;
    using holaMundo.Shared;
    public class PizzaStoreContext : DbContext
    {
        public DbSet<PizzaSpecial> Specials { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public PizzaStoreContext(DbContextOptions options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {// Definir la llave primaria de la entidad PizzaTopping
            modelBuilder.Entity<PizzaTopping>()
                 .HasKey(pst => new { pst.PizzaId, pst.ToppingId });
            // UnaPizza puede tener muchos Toppings.
            modelBuilder.Entity<PizzaTopping>()
                   .HasOne<Pizza>().WithMany(ps => ps.Toppings);
            // Un Topping puede estar en muchas Pizzas.
            modelBuilder.Entity<PizzaTopping>()
                   .HasOne(pst => pst.Topping).WithMany();
        }
    }
}
