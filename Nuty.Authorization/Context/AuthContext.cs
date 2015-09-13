using System.Data;

namespace Nuty.Authorization.Context {

    using System.Data.Entity;
    public class AuthContext : DbContext {

        public AuthContext(string connectionString) : base(connectionString) { }

        public DataSet<>
    }
}
