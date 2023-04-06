using System;
using WebDeCuong.Api.Models;

namespace WebDeCuong.Api.Repositories.Interfaces
{
    public interface ISubjectRepository
    {
        List<SubjectModel> GetAllSubject();
        SubjectModel GetById(int id);
        Task<ResponseModel> AddSubject(SubjectModel subject);
        Task<ResponseModel> UpdateSubject(SubjectModel subject,int id);
        Task<ResponseModel> DeleteSubject(int id);

   
    }
}

