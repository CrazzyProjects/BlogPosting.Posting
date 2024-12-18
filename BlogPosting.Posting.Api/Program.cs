using BlogPosting.Posting.Api.Options;
using BlogPosting.Posting.Application.Commands;
using BlogPosting.Posting.Domain.Interfaces;
using BlogPosting.Posting.Infrastructure.Context;
using BlogPosting.Posting.Infrastructure.Mappers;
using BlogPosting.Posting.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlogPosting.Posting.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Configure MediatR
            builder.Services.AddMediatR(option => option.RegisterServicesFromAssemblies(typeof(PublishPostCommand).Assembly));

            // Configure SQL Server
            SqlOptions sqlOptions = new();
            builder.Configuration.GetSection(sqlOptions.SectionName)
                .Bind(sqlOptions);
            builder.Services.AddDbContext<BlogPostingDBContext>(options =>
                options.UseSqlServer(sqlOptions.DbConnection), ServiceLifetime.Singleton);

            builder.Services.AddSingleton<IPostingRepository, SqlPostingRepository>();
            builder.Services.AddSingleton<IPostingMapper, PostingMapper>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
