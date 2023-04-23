using System;
using WebDeCuong.Api.Models;

namespace WebDeCuong.Api.Repositories.Interfaces
{
    public interface ISubjectRepository
    {
        Task<List<SubjectGetModel>> GetAllSubject();
        Task<ResponseModel> GetSubject(string Id);

        Task<ResponseModel> AddSubject(SubjectModel subject);
        Task<ResponseModel> UpdateSubject(SubjectModel subject);
        Task<ResponseModel> DeleteSubject(string Id);

   
    }
}

