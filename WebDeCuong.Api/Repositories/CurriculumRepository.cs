using WebDeCuong.Api.Models;
using WebDeCuong.Api.Repositories.Interfaces;
using WebDeCuong.Data;
using Microsoft.EntityFrameworkCore;
using WebDeCuong.Api.Cons;
using WebDeCuong.Data.Entities;
using System.Runtime.InteropServices.JavaScript;

namespace WebDeCuong.Api.Repositories
{
    public class CurriculumRepository : ICurriculumRepository
    {
        private readonly ApplicationDbContext _context;

        public CurriculumRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> AddCurriculum(CurriculumModel curriculum)
        {
            var resModel = new ResponseModel();
            var CurriculumExist = await _context.Curriculums.FirstOrDefaultAsync(c => c.Name.CompareTo(curriculum.Name)==0);
            if (CurriculumExist != null)
            {
                resModel.Status = Status.Error;
                resModel.Message = "curriculum already exists.";
                return resModel;
            }

            foreach (var subjectcurriculum in curriculum.subjectCurriculumModels)
            {
                foreach (var subject in subjectcurriculum.SubjectId)
                {
                    var _subjectId = _context.Subjects.FirstOrDefault(s => s.Id.CompareTo(subject) == 0);
                    if(_subjectId== null)
                    {
                        resModel.Status = Status.Error;
                        resModel.Message = "subject no exists.";
                        return resModel;
                    }
                }

            }

            var _curriculum = new Curriculum()
            {
                Name = curriculum.Name
            };
            await _context.Curriculums.AddAsync(_curriculum);
            await _context.SaveChangesAsync();

            foreach (var subjectcurriculum in curriculum.subjectCurriculumModels)
            {
                var _semester = _context.Semesters.FirstOrDefault(s => s.Name.CompareTo(subjectcurriculum.SemesterName) == 0);
                if (_semester == null)
                {
                    _semester = new Semester()
                    {
                        Name = subjectcurriculum.SemesterName
                    };
                    await _context.Semesters.AddAsync(_semester);
                    await _context.SaveChangesAsync();
                }

                

                foreach (var subject in subjectcurriculum.SubjectId)
                {
                    _context.SubjectCurriculums.Add(new SubjectCurriculum
                    {
                        SubjectId = subject,
                        SemesterId = _semester.Id,
                        CurriculumId = _curriculum.Id
                    });
                }

            }
            var res = await _context.SaveChangesAsync();

            if (res == 0)
            {
                _context.Curriculums.Remove(_curriculum);
                await _context.SaveChangesAsync();

                resModel.Status = Status.Error;
                resModel.Message = "Curriculum can not create.";

                return resModel;
            }

            resModel.Status = Status.Success;
            resModel.Message = "Curriculum was created successfull.";
            return resModel;

        }

        public async Task<ResponseModel> DeleteCurriculum(int Id)
        {
            var responseModel = new ResponseModel();
            var _curriculum = _context.Curriculums.FirstOrDefault(c => c.Id == Id);
            if (_curriculum != null)
            {
                _context.Curriculums.Remove(_curriculum);
                var result = await _context.SaveChangesAsync();
                if (result == 0)
                {
                    responseModel.Status = Status.Error;
                    responseModel.Message = "Something went wrong.";

                    return responseModel;
                }
                else
                {
                    responseModel.Status = Status.Success;
                    responseModel.Message = "Curriculum, was deleted succesfully";

                    return responseModel;
                }
            }
            responseModel.Status = Status.Error;
            responseModel.Message = "Curriculum not found";

            return responseModel;
        }

        public async Task<List<CurriculumModel>> GetAllCurriculum()
        {
            var curriculum = _context.Curriculums.ToList();
            var result = new List<CurriculumModel>();
            foreach (var item in curriculum)
            {
                var subjectcurriculum = _context.SubjectCurriculums.Where(s => s.CurriculumId == item.Id);
                var _semesterIds = subjectcurriculum.Select(cs => cs.SemesterId).ToList();
                var _semesters = _context.Semesters.Where(s => _semesterIds.Contains(s.Id)).ToList();
                CurriculumModel curiculum = new CurriculumModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    subjectCurriculumModels = new List<SubjectCurriculumModel>(),
                };
                foreach(var semester in _semesters)
                {
                    var subjectids = subjectcurriculum.Where(s => s.SemesterId == semester.Id).ToList();
                    SubjectCurriculumModel subjectCurriculum = new SubjectCurriculumModel
                    {
                        SemesterName = semester.Name,
                        SubjectId = new List<string>()
                    };
                    foreach(var subject in subjectids)
                    {
                        subjectCurriculum.SubjectId.Add(subject.SubjectId);
                    }
                    curiculum.subjectCurriculumModels.Add(subjectCurriculum);
                }
                result.Add(curiculum);
            }
            return result;
        }

        public async Task<ResponseModel> GetCurriculum(int Id)
        {
            var resModel = new ResponseModel();
            var _curriculum = _context.Curriculums.FirstOrDefault(c => c.Id == Id);
            if(_curriculum== null)
            {
                resModel.Status = Status.Error;
                resModel.Message = "Curriculum was not existed";

                return resModel;

            }
            var subjectcurriculum = _context.SubjectCurriculums.Where(s => s.CurriculumId == _curriculum.Id);
            var _semesterIds = subjectcurriculum.Select(cs => cs.SemesterId).ToList();
            var _semesters = _context.Semesters.Where(s => _semesterIds.Contains(s.Id)).ToList();
            CurriculumModel curiculum = new CurriculumModel
            {
                Id = _curriculum.Id,
                Name = _curriculum.Name,
                subjectCurriculumModels = new List<SubjectCurriculumModel>(),
            };
            foreach (var semester in _semesters)
            {
                var subjectids = subjectcurriculum.Where(s => s.SemesterId == semester.Id).ToList();
                SubjectCurriculumModel subjectCurriculum = new SubjectCurriculumModel
                {
                    SemesterName = semester.Name,
                    SubjectId = new List<string>()
                };
                foreach (var subject in subjectids)
                {
                    subjectCurriculum.SubjectId.Add(subject.SubjectId);
                }
                curiculum.subjectCurriculumModels.Add(subjectCurriculum);
            }
            resModel.Status = Status.Success;
            resModel.Result = curiculum;

            return resModel;
        }

        public async Task<ResponseModel> UpdateCurriculum(CurriculumModel curriculum)
        {
            var resModel = new ResponseModel();
            foreach (var subjectcurriculum in curriculum.subjectCurriculumModels)
            {
                foreach (var subject in subjectcurriculum.SubjectId)
                {
                    var _subjectId = _context.Subjects.FirstOrDefault(s => s.Id.CompareTo(subject) == 0);
                    if (_subjectId == null)
                    {
                        resModel.Status = Status.Error;
                        resModel.Message = "subject no exists.";
                        return resModel;
                    }
                }
            }
            var _curriculum = _context.Curriculums.FirstOrDefault(c => c.Id == curriculum.Id);

            if(_curriculum == null)
            {
                resModel.Status = Status.Error;
                resModel.Message = "Curriculum not found.";
                return resModel;
            }
            _curriculum.Name = curriculum.Name;
            _context.SubjectCurriculums.RemoveRange(_context.SubjectCurriculums.Where(c => c.CurriculumId == curriculum.Id));
            foreach (var subjectcurriculum in curriculum.subjectCurriculumModels)
            {
                var _semester = _context.Semesters.FirstOrDefault(s => s.Name.CompareTo(subjectcurriculum.SemesterName) == 0);
                if (_semester == null)
                {
                    _semester = new Semester()
                    {
                        Name = subjectcurriculum.SemesterName
                    };
                    await _context.Semesters.AddAsync(_semester);
                    await _context.SaveChangesAsync();
                }
                foreach (var subject in subjectcurriculum.SubjectId)
                {
                    _context.SubjectCurriculums.AddRange(new SubjectCurriculum
                    {
                        SubjectId = subject,
                        SemesterId = _semester.Id,
                        CurriculumId = _curriculum.Id
                    });
                }

            }
            var res = await _context.SaveChangesAsync();
            if (res == 0)
            {
                resModel.Status = Status.Error;
                resModel.Message = "Curriculum can not create.";
                return resModel;
            }
            resModel.Status = Status.Success;
            resModel.Message = "Curriculum was update successfull.";
            return resModel;
        }
    }
}

