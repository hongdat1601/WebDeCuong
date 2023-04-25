using System;
using WebDeCuong.Api.Models;

namespace WebDeCuong.Api.Repositories.Interfaces
{
	public interface ICurriculumRepository
	{
        Task<List<CurriculumModel>> GetAllCurriculum();
        Task<ResponseModel> GetCurriculum(int Id);

        Task<ResponseModel> AddCurriculum(CurriculumModel curriculum);
        Task<ResponseModel> UpdateCurriculum(CurriculumModel curriculum);
        Task<ResponseModel> DeleteCurriculum(int Id);

    }
}

