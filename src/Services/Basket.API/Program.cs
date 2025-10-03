
using Basket.API.gRPCServices;
using Basket.API.Repositories;
using Discount.gRPC.Protos;

namespace Basket.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddStackExchangeRedisCache(op => op.Configuration = builder.Configuration.GetConnectionString("BasketDB"));
            builder.Services.AddScoped<IBasketRepository, BasketRepository>();
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddGrpcClient<DiscountProtoService.DiscountProtoServiceClient>
                (
                    op => op.Address = new Uri(builder.Configuration.GetValue<string>("GrpcSettings:DiscountGrpcUrl"))
                );
            builder.Services.AddScoped<DiscountGrpcService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
