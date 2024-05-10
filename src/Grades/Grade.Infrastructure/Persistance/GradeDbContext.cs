using Grade.Application.Abstractions;
using Grade.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Infrastructure.Persistance
{
    public class GradeDbContext : DbContext, IGradeDbContext
    {
        public GradeDbContext(DbContextOptions<GradeDbContext> options) :
            base(options)
        {

        }
        public DbSet<StudentGrade> Grades { get; set; }
    }
}
