using Grade.Application.Abstractions;
using Grade.Application.UseCases.GradeCases.Commands;
using Grade.Domain;
using Grade.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Application.UseCases.GradeCases.Handlers.CommandHandlers
{
    public class CreateGradeCommandHandler : IRequestHandler<CreateGradeCommand, ResponseModel>
    {
        private readonly IGradeDbContext _context;
public CreateGradeCommandHandler(IGradeDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateGradeCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var grade = new StudentGrade
                {
                    Name = request.Name,
                    Description = request.Description,
                    Type = request.Type
                };
                await _context.Grades.AddAsync(grade, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    Massege = "Grade Created",
                    StatusCode = 201,
                    isSuccess = true
                };

            }
            return new ResponseModel
            {
                Massege = "Grade is maybe null",
                StatusCode = 400
            };
        }
    }
}
