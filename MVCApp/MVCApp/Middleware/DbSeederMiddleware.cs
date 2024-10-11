using DbAccess.Context;
using Entities;
using Route = Entities.Route;

namespace MVCApp.Middleware
{
    public class DbSeederMiddleware
    {
        private readonly RequestDelegate _next;

        public DbSeederMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, LogisticContext dbContext)
        {
            if (!dbContext.Cargos.Any() || !dbContext.Settlements.Any() || !dbContext.Routes.Any())
            {
                // Заполняем базу данных тестовыми данными с использованием цикла
                var settlements = new List<Settlement>();
                var random = new Random();

                // Генерируем 10 населённых пунктов
                for (int i = 1; i <= 10; i++)
                {
                    var settlement = new Settlement
                    {
                        Title = $"Settlement {i}"
                    };
                    settlements.Add(settlement);
                    dbContext.Settlements.Add(settlement);
                }

                // Сохраняем населённые пункты, чтобы потом использовать их для маршрутов
                dbContext.SaveChanges();

                // Генерируем 10 маршрутов, используя случайные населённые пункты
                for (int i = 0; i < 10; i++)
                {
                    var startSettlement = settlements[random.Next(settlements.Count)];
                    var endSettlement = settlements[random.Next(settlements.Count)];

                    // Проверяем, чтобы стартовый и конечный пункт были разными
                    if (startSettlement != endSettlement)
                    {
                        var route = new Route
                        {
                            Distance = random.Next(100, 1000),
                            StartSettlement = startSettlement,
                            EndSettlement = endSettlement
                        };
                        dbContext.Routes.Add(route);
                    }
                }

                // Генерируем 10 грузов с разными параметрами
                for (int i = 1; i <= 10; i++)
                {
                    var cargo = new Cargo
                    {
                        Title = $"Cargo {i}",
                        Weight = random.Next(500, 2000),
                        RegistrationNumber = $"REG-{random.Next(1000, 9999)}"
                    };
                    dbContext.Cargos.Add(cargo);
                }

                // Сохраняем изменения в базе данных
                dbContext.SaveChanges();
            }

            await _next(context);
        }
    }
}
