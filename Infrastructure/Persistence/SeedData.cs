using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure.Persistence
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DongHoContext(
                serviceProvider.GetRequiredService<DbContextOptions<DongHoContext>>()))
            {
                //link tham khảo https://stackoverflow.com/questions/38238043how-and-where-to-call-database-ensurecreated-and-database-migrate
                context.Database.Migrate();//Hàm này sẽ tạo db nếu chưa có và sẽ không làm gì nếu có rồi , chạy dựa trên file migration

                if (context.sanPham.Any()) return;       
                context.SaveChanges();
            }
        }
    }
}