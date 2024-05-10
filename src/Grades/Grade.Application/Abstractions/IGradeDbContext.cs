using Microsoft.EntityFrameworkCore;
using Grade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Application.Abstractions
{
    public interface IGradeDbContext
    {
        public DbSet<StudentGrade> Grades { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellation);
    }
}
