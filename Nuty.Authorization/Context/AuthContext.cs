namespace Nuty.Authorization.Context {

    using System.Data.Entity;
    using Module;

    public class AuthContext : DbContext {

        public AuthContext(string connectionString) : base(connectionString) { }
        public DbSet<Controller> Controllers { get; set; }
        public DbSet<Action> Actions { get; set; }
    }
}
