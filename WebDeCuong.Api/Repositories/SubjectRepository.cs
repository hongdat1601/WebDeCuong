using WebDeCuong.Api.Models;
using WebDeCuong.Api.Repositories.Interfaces;
using WebDeCuong.Data;
using Microsoft.EntityFrameworkCore;
using WebDeCuong.Api.Cons;
using WebDeCuong.Data.Entities;

namespace WebDeCuong.Api.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly ApplicationDbContext _context;

        public SubjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SubjectGetModel>> GetAllSubject()
        {
            var subjects = await _context.Subjects.ToListAsync();
            var result = new List<SubjectGetModel>();

            foreach (var item in subjects)
            {
                SubjectGetModel subject = new SubjectGetModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    RequestUserMail = item.RequestUserMail,
                    TotalCredits = item.TotalCredits
                };

                result.Add(subject);
            }

            return result;
        }

        public async Task<ResponseModel> GetSubject(string Id)
        {
            var resModel = new ResponseModel();
            var subject = await _context.Subjects.FirstOrDefaultAsync(s => s.Id.CompareTo(Id) == 0);

            if (subject == null)
            {
                resModel.Status = Status.Error;
                resModel.Message = "Subject Not Found";

                return resModel;
            }

            var result = new SubjectModel
            {
                Id = Id,
                Name = subject.Name,
                TheoryCredits = subject.TheoryCredits,
                PracticeCredits = subject.PracticeCredits,
                SelfLearningCredits = subject.SelfLearningCredits,
                TotalCredits = subject.TotalCredits,
                Teachers = subject.Teachers,
                Documents = subject.Documents,
                Goals = subject.Goals,
                Abstract = subject.Abstract,
                A = subject.A,
                B = subject.B,
                C = subject.C,
                Other = subject.Other,
                SubjectContents = new List<SubjectContentModel>(),
                SubjectOutputStandards = new List<SubjectOutputStandardModel>(),
                EvalElements = new List<EvalElementModel>(),
                Evaluates = new List<EvaluateModel>(),
                RequestUserMail = subject.RequestUserMail,
            };

            await _context.SubjectOutputStandards
                .Where(so => so.SubjectId.CompareTo(Id) == 0)
                .OrderBy(so => so.Clo)
                .ForEachAsync(so =>
                {
                    result.SubjectOutputStandards.Add(new SubjectOutputStandardModel
                    {
                        Id = so.Id,
                        Clo = so.Clo,
                        Content = so.Content,
                        SoPerPi = so.SoPerPi
                    });
                });

            await _context.SubjectContents
                .Where(sc => sc.SubjectId.CompareTo(Id) == 0)
                .OrderBy(sc => sc.Order)
                .ForEachAsync(sc =>
                {
                    result.SubjectContents.Add(new SubjectContentModel
                    {
                        Id = sc.Id,
                        Clos = sc.Clos,
                        Content = sc.Content,
                        Method = sc.Method,
                        Bonus = sc.Bonus,
                        NLessons = sc.NLessons,
                        Order = sc.Order
                    });
                });

            await _context.Evaluates
                .Where(e => e.SubjectId.CompareTo(Id) == 0)
                .OrderBy(e => e.Order)
                .ForEachAsync(e =>
                {
                    result.Evaluates.Add(new EvaluateModel
                    {
                        Id = e.Id,
                        Method = e.Method,
                        Test = e.Test,
                        Order = e.Order,
                        Clo = e.Clo,
                        Proportion = e.Proportion,
                        Target = e.Target
                    });
                });

            await _context.EvalElements
                .Where(ee => ee.SubjectId.CompareTo(Id) == 0)
                .OrderBy(ee => ee.Order)
                .ForEachAsync(ee =>
                {
                    result.EvalElements.Add(new EvalElementModel
                    {
                        Id = ee.Id,
                        Method = ee.Method,
                        Name = ee.Name,
                        Order = ee.Order,
                        Proportion = ee.Proportion
                    });
                });

            resModel.Status = Status.Success;
            resModel.Result = result;

            return resModel;
        }

        public async Task<ResponseModel> AddSubject(SubjectModel subject)
        {
            var resModel = new ResponseModel();
            var subjectExist = await _context.Subjects.FirstOrDefaultAsync(s => s.Id.CompareTo(subject.Id) == 0);

            if (subjectExist != null)
            {
                resModel.Status = Status.Error;
                resModel.Message = "Subject already exists.";
                return resModel;
            }

            string Id = $"{await _context.Subjects.CountAsync() + 1}".PadLeft(7, '0');

            await _context.Subjects.AddAsync(new Subject
            {
                Id = Id,
                Name = subject.Name,
                TheoryCredits = subject.TheoryCredits,
                PracticeCredits = subject.PracticeCredits,
                SelfLearningCredits = subject.SelfLearningCredits,
                TotalCredits = subject.TotalCredits,
                Teachers = subject.Teachers,
                Documents = subject.Documents,
                Goals = subject.Goals,
                Abstract = subject.Abstract,
                A = subject.A,
                B = subject.B,
                C = subject.C,
                Other = subject.Other
            });

            foreach (var output in subject.SubjectOutputStandards)
            {
                _context.SubjectOutputStandards.AddRange(new SubjectOutputStandard
                {
                    SubjectId = Id,
                    Clo = output.Clo,
                    Content = output.Content,
                    SoPerPi = output.SoPerPi,
                });
            }

            foreach (var output in subject.SubjectContents)
            {
                _context.SubjectContents.AddRange(new SubjectContent
                {
                    SubjectId = Id,
                    Content = output.Content,
                    Bonus = output.Bonus,
                    Clos = output.Clos,
                    Method = output.Method,
                    NLessons = output.NLessons,
                    Order = output.Order,
                });
            }

            foreach (var output in subject.EvalElements)
            {
                _context.EvalElements.AddRange(new EvalElement
                {
                    SubjectId = Id,
                    Method = output.Method,
                    Name = output.Name,
                    Order = output.Order,
                    Proportion = output.Proportion,
                });
            }

            foreach (var output in subject.Evaluates)
            {
                _context.Evaluates.AddRange(new Evaluate
                {
                    SubjectId = Id,
                    Proportion = output.Proportion,
                    Order = output.Order,
                    Method = output.Method,
                    Clo = output.Clo,
                    Target = output.Target,
                    Test = output.Test
                });
            }
            var res = await _context.SaveChangesAsync();

            if (res == 0)
            {
                resModel.Status = Status.Error;
                resModel.Message = "Subject can not create.";
                return resModel;
            }

            resModel.Status = Status.Success;
            resModel.Message = "Subject was created successfull.";
            return resModel;
        }

        public async Task<ResponseModel> UpdateSubject(SubjectModel subject)
        {
            var resModel = new ResponseModel();
            var subjectUpdate = await _context.Subjects.FirstOrDefaultAsync(s => s.Id.CompareTo(subject.Id) == 0);

            if (subjectUpdate == null)
            {
                resModel.Status = Status.Error;
                resModel.Message = "Subject not found.";
                return resModel;
            }

            subjectUpdate.Name = subject.Name;
            subjectUpdate.TheoryCredits = subject.TheoryCredits;
            subjectUpdate.PracticeCredits = subject.PracticeCredits;
            subjectUpdate.SelfLearningCredits = subject.SelfLearningCredits;
            subjectUpdate.TotalCredits = subject.TotalCredits;
            subjectUpdate.Teachers = subject.Teachers;
            subjectUpdate.Documents = subject.Documents;
            subjectUpdate.Goals = subject.Goals;
            subjectUpdate.Abstract = subject.Abstract;
            subjectUpdate.A = subject.A;
            subjectUpdate.B = subject.B;
            subjectUpdate.C = subject.C;
            subjectUpdate.Other = subject.Other;

            // delete child
            _context.SubjectOutputStandards
                .RemoveRange(_context.SubjectOutputStandards
                    .Where(so => so.SubjectId.CompareTo(subjectUpdate.Id) == 0));

            _context.SubjectContents
                .RemoveRange(_context.SubjectContents
                    .Where(so => so.SubjectId.CompareTo(subjectUpdate.Id) == 0));

            _context.EvalElements
                .RemoveRange(_context.EvalElements
                    .Where(so => so.SubjectId.CompareTo(subjectUpdate.Id) == 0));

            _context.Evaluates
                .RemoveRange(_context.Evaluates
                    .Where(so => so.SubjectId.CompareTo(subjectUpdate.Id) == 0));

            // add child
            foreach (var output in subject.SubjectOutputStandards)
            {
                _context.SubjectOutputStandards.AddRange(new SubjectOutputStandard
                {
                    SubjectId = subjectUpdate.Id,
                    Clo = output.Clo,
                    Content = output.Content,
                    SoPerPi = output.SoPerPi,
                });
            }

            foreach (var output in subject.SubjectContents)
            {
                _context.SubjectContents.AddRange(new SubjectContent
                {
                    SubjectId = subjectUpdate.Id,
                    Content = output.Content,
                    Bonus = output.Bonus,
                    Clos = output.Clos,
                    Method = output.Method,
                    NLessons = output.NLessons,
                    Order = output.Order,
                });
            }

            foreach (var output in subject.EvalElements)
            {
                _context.EvalElements.AddRange(new EvalElement
                {
                    SubjectId = subjectUpdate.Id,
                    Method = output.Method,
                    Name = output.Name,
                    Order = output.Order,
                    Proportion = output.Proportion,
                });
            }

            foreach (var output in subject.Evaluates)
            {
                _context.Evaluates.AddRange(new Evaluate
                {
                    SubjectId = subjectUpdate.Id,
                    Proportion = output.Proportion,
                    Order = output.Order,
                    Method = output.Method,
                    Clo = output.Clo,
                    Target = output.Target,
                    Test = output.Test
                });
            }

            _context.Subjects.Update(subjectUpdate);
            var res = await _context.SaveChangesAsync();

            if (res == 0)
            {
                resModel.Status = Status.Error;
                resModel.Message = "Subject can not update.";
                return resModel;
            }

            resModel.Status = Status.Success;
            resModel.Message = "Subject was updated successfull.";
            return resModel;
        }

        public async Task<ResponseModel> DeleteSubject(string Id)
        {
            var responseModel = new ResponseModel();
            var _subject = await _context.Subjects.FirstOrDefaultAsync(s => s.Id.CompareTo(Id) == 0);

            if (_subject != null)
            {
                _context.Subjects.Remove(_subject);
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
                    responseModel.Message = "Subject was deleted succesfully";

                    return responseModel;
                }
            }
            responseModel.Status = Status.Error;
            responseModel.Message = "Subject not found";

            return responseModel;

        }

        public async Task<ResponseModel> RequestSubject(RequestSubjectModel subject)
        {
            var resModel = new ResponseModel();

            var user = await _context.Users.
                FirstOrDefaultAsync(u => u.Email!.CompareTo(subject.RequestUserMail) == 0);

            if (user == null)
            {
                resModel.Status = Status.Error;
                resModel.Message = "User not found.";
                return resModel;
            }


            var lastSubject = await _context.Subjects.OrderByDescending((s) => s.Id).ToListAsync();
            int id = 0;
            if (lastSubject.Count > 0)
            {
                id = int.Parse(lastSubject[0].Id) + 1;
            }

            Subject subjects = new Subject
            {
                Id = id.ToString().PadLeft(7, '0'),
                Name = subject.Name,
                RequestUserMail = subject.RequestUserMail,
            };

            await _context.Subjects.AddAsync(subjects);
            var response = await _context.SaveChangesAsync();

            if (response == 0)
            {
                resModel.Status = Status.Error;
                resModel.Message = "Subject cannot request.";
                return resModel;
            }

            resModel.Status = Status.Success;
            resModel.Message = "Subject was requested.";
            return resModel;
        }
    }
}

