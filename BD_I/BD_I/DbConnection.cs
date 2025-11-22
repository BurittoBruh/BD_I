// DbConnection.cs
using System;

namespace PreDiplomaPractice
{
    public static class DbConnection
    {
        public static string ConnectionString =
            "Host=localhost;Port=5432;Username=postgres;Password=226644;Database=Practies_BD;Pooling=true;";
        // Замени ТВОЙ_ПАРОЛЬ на свой. База должна быть создана по SQL-скрипту из предыдущего сообщения.
    }
}