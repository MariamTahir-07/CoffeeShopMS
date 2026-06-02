using System.Data.SQLite;

namespace CoffeeShopMS.Data;

public static class DatabaseHelper
{
    private static readonly string DbPath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory, "CoffeeShop.db");

    // Pooling=False  → each connection fully closes, no shared file handle left open
    // Journal Mode=Delete → no WAL (-wal / -shm) files, zero ghost locks
    public static string ConnectionString =>
        $"Data Source={DbPath};Version=3;Pooling=False;Journal Mode=Delete;";

    public static void InitializeDatabase()
    {
        if (!File.Exists(DbPath))
            SQLiteConnection.CreateFile(DbPath);

        using var conn = new SQLiteConnection(ConnectionString);
        conn.Open();

        string[] commands =
        {
            @"PRAGMA journal_mode=DELETE;",

            @"CREATE TABLE IF NOT EXISTS Users (
                Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT    NOT NULL UNIQUE,
                Password TEXT    NOT NULL,
                Role     TEXT    NOT NULL DEFAULT 'Staff',
                Created  TEXT    NOT NULL DEFAULT (datetime('now'))
            );",

            @"CREATE TABLE IF NOT EXISTS Products (
                Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                Name        TEXT    NOT NULL,
                Category    TEXT    NOT NULL DEFAULT 'Coffee',
                Price       REAL    NOT NULL,
                Description TEXT,
                IsActive    INTEGER NOT NULL DEFAULT 1
            );",

            @"CREATE TABLE IF NOT EXISTS Orders (
                Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                OrderDate    TEXT NOT NULL DEFAULT (datetime('now')),
                CustomerName TEXT,
                TotalAmount  REAL NOT NULL DEFAULT 0,
                Status       TEXT NOT NULL DEFAULT 'Pending',
                CreatedBy    INTEGER NOT NULL REFERENCES Users(Id)
            );",

            @"CREATE TABLE IF NOT EXISTS OrderDetails (
                Id        INTEGER PRIMARY KEY AUTOINCREMENT,
                OrderId   INTEGER NOT NULL REFERENCES Orders(Id) ON DELETE CASCADE,
                ProductId INTEGER NOT NULL REFERENCES Products(Id),
                Quantity  INTEGER NOT NULL DEFAULT 1,
                UnitPrice REAL    NOT NULL,
                SubTotal  REAL    NOT NULL
            );"
        };

        foreach (var sql in commands)
        {
            using var cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        SeedAdminUser(conn);
        SeedSampleProducts(conn);
    }   // <-- conn disposed here, file fully released

    private static void SeedAdminUser(SQLiteConnection conn)
    {
        using var check = new SQLiteCommand(
            "SELECT COUNT(*) FROM Users WHERE Username='admin'", conn);
        if (Convert.ToInt32(check.ExecuteScalar()) > 0) return;

        string hashed = BCrypt.Net.BCrypt.HashPassword("admin123");
        using var cmd = new SQLiteCommand(
            "INSERT INTO Users (Username, Password, Role) VALUES ('admin', @pw, 'Admin')", conn);
        cmd.Parameters.AddWithValue("@pw", hashed);
        cmd.ExecuteNonQuery();
    }

    private static void SeedSampleProducts(SQLiteConnection conn)
    {
        using var check = new SQLiteCommand("SELECT COUNT(*) FROM Products", conn);
        if (Convert.ToInt32(check.ExecuteScalar()) > 0) return;

        var products = new[]
        {
            ("Espresso",      "Coffee",  150.0, "Strong Italian espresso"),
            ("Cappuccino",    "Coffee",  250.0, "Espresso with steamed milk foam"),
            ("Latte",         "Coffee",  280.0, "Espresso with lots of steamed milk"),
            ("Cold Brew",     "Coffee",  300.0, "Cold brewed coffee"),
            ("Green Tea",     "Tea",     180.0, "Japanese green tea"),
            ("Chai Latte",    "Tea",     200.0, "Spiced Indian chai"),
            ("Croissant",     "Food",    120.0, "Buttery French croissant"),
            ("Muffin",        "Food",     90.0, "Blueberry muffin"),
            ("Club Sandwich", "Food",    350.0, "Triple layer sandwich"),
            ("Cheesecake",    "Dessert", 220.0, "New York style cheesecake")
        };

        foreach (var (name, cat, price, desc) in products)
        {
            using var cmd = new SQLiteCommand(
                "INSERT INTO Products (Name,Category,Price,Description) VALUES (@n,@c,@p,@d)", conn);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@c", cat);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.Parameters.AddWithValue("@d", desc);
            cmd.ExecuteNonQuery();
        }
    }

    // Returns an OPEN connection — caller MUST wrap in using() so it disposes immediately
    public static SQLiteConnection GetConnection()
    {
        var conn = new SQLiteConnection(ConnectionString);
        conn.Open();
        return conn;
    }

    // Helper: run a single non-query safely (open → execute → close in one call)
    public static void ExecuteNonQuery(string sql, Action<SQLiteCommand>? paramSetup = null)
    {
        using var conn = GetConnection();
        using var cmd  = new SQLiteCommand(sql, conn);
        paramSetup?.Invoke(cmd);
        cmd.ExecuteNonQuery();
    }

    // Helper: run a scalar safely
    public static object? ExecuteScalar(string sql, Action<SQLiteCommand>? paramSetup = null)
    {
        using var conn = GetConnection();
        using var cmd  = new SQLiteCommand(sql, conn);
        paramSetup?.Invoke(cmd);
        return cmd.ExecuteScalar();
    }
}
