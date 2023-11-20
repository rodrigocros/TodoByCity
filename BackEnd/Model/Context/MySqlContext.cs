using Microsoft.EntityFrameworkCore;

namespace ToDoByCity.ListAPI.Model.Context;

public class MySqlContext : DbContext
{
    public DbSet<ToDo> Todos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "server=localhost;port=3306;database=todobycity_list ;uid=root;password=";

        var serverVersion = new MySqlServerVersion(new Version(8, 0, 25));

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}
