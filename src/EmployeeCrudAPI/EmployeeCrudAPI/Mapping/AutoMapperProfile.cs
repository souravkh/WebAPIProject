using AutoMapper;
using EmployeeCrudAPI.Model.Domain;
using EmployeeCrudAPI.Model.DTO;

namespace EmployeeCrudAPI.Mapping
{
    /// <summary>
    /// AutoMapper profile to map between domain models and DTOs.
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Maps between Employee and AddEmployeeDto in both directions
            CreateMap<Employee, AddEmployeeDto>().ReverseMap();
        }
    }
}
