using Grade.Application.Abstractions;
using Grade.Application.UseCases.GradeCases.Queries;
using Grade.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Application.UseCases.GradeCases.Handlers.QueryHandlers
{
    public class GetAllGradeQueryHandler : IRequestHandler<GetAllGradesQuery, IEnumerable<StudentGrade>>
    {
        private readonly IGradeDbContext _context;

        public GetAllGradeQueryHandler(IGradeDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StudentGrade>> Handle(GetAllGradesQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.Grades.ToListAsync(cancellationToken);
            return result;
        }
    }
}
