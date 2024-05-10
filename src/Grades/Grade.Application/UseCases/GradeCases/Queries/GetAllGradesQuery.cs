using Grade.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Application.UseCases.GradeCases.Queries
{
    public class GetAllGradesQuery : IRequest<IEnumerable<StudentGrade>>
    {
    }
}
 