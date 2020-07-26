using System.Linq;

using ManyToManyExample.Helpers;
using ManyToManyExample.Repositories;

using Microsoft.EntityFrameworkCore;

namespace ManyToManyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository.Initialize();

            PrintHelper.Title("-Entity Framework Core 5 ToQueryString example -");

            PrintHelper.SubTitle("Example using contains");
            var queryString = Repository.Context
                .Posts
                .Where(p => p.Title.Contains("Post"))
                .ToQueryString();

            PrintHelper.Text(queryString);

            PrintHelper.BlankLine();

            PrintHelper.SubTitle("Example using EF.Functions.Like");
            queryString = Repository.Context
                .Posts
                .Where(p => EF.Functions.Like(p.Title, "%Post%"))
                .ToQueryString();

            PrintHelper.Text(queryString);
        }
    }
}