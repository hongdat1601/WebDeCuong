using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using WebDeCuong.Api.Cons;
using WebDeCuong.Api.Models;
using WebDeCuong.Api.Repositories.Interfaces;
using WebDeCuong.Data.Entities;
using WebDeCuong.Data;
using Microsoft.EntityFrameworkCore;

namespace WebDeCuong.Api.Repositories
{
	public class SubjectRepository : ISubjectRepository
	{
        private readonly ApplicationDbContext _context;
        public SubjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<SubjectModel> GetAllSubject()
        {
            var subject = _context.Subjects.Include(x => x.SubjectUsers).Include(x => x.SubjectOutputStandards).Include(x =>x.SubjectContents).ToList();
            var subjectModels = subject.Select(s => new SubjectModel
            {

                Name = s.Name,
                TheoryCredits = s.TheoryCredits,
                PracticeCredits = s.PracticeCredits,
                TotalCredits = s.TotalCredits,
                Documents = s.Documents,
                Goals = s.Goals,
                Abstract = s.Abstract,
                A = s.A,
                B = s.B,
                C = s.C,
                Other = s.Other,

                UserId = s.SubjectUsers.Select(u => u.UserId).ToList(),

                CloName = s.SubjectOutputStandards.Select(u => u.CloName).ToList(),
                OutputContent = s.SubjectOutputStandards.Select(u => u.Content).ToList(),
                SoPerPi = s.SubjectOutputStandards.Select(u => u.SoPerPi).ToList(),

                DetailContent = s.SubjectContents.Select(u => u.Content).ToList(),
                Clos = s.SubjectContents.Select(u => u.Clos).ToList(),
                NLessons = s.SubjectContents.Select(u => u.NLessons).ToList(),
                Bonus = s.SubjectContents.Select(u => u.Bonus).ToList(),
                Method = s.SubjectContents.Select(u=>u.Method).ToList()
            });
        

            return subjectModels.ToList();
        }

        public async Task<ResponseModel> AddSubject(SubjectModel subject)
        {
            var responseModel = new ResponseModel();
            foreach (var userId in subject.UserId)
            {
                var user = await _context.Users.FindAsync(userId);
                if (user == null)
                {
                    responseModel.Status = Status.Error;
                    responseModel.Message = "Id User not found";
                    return responseModel;
                }
            }
            var _subject = new Subject()
            {
                Name = subject.Name,
                TheoryCredits = subject.TheoryCredits,
                PracticeCredits = subject.PracticeCredits,
                TotalCredits = subject.TotalCredits,
                Documents = subject.Documents,
                Goals = subject.Goals,
                Abstract = subject.Abstract,
                A = subject.A,
                B = subject.B,
                C = subject.C,
                Other = subject.Other,
            };
            await _context.Subjects.AddAsync(_subject);
           
            var result = await _context.SaveChangesAsync();
            if (result == 0)
            {
                responseModel.Status = Status.Success;
                responseModel.Message = "Subject create succesfully";

                return responseModel;

            }

            foreach (var userId in subject.UserId)
            {
                var subjectUser = new SubjectUser
                {
                    SubjectId = _subject.Id,
                    UserId = userId
                };
                await _context.SubjectUsers.AddAsync(subjectUser);
            }
            foreach (var cloname in subject.CloName)
            {
                var subjectoutput = new SubjectOutputStandard
                {
                    CloName = cloname,
                    Content = subject.OutputContent[subject.CloName.IndexOf(cloname)],
                    SoPerPi = subject.SoPerPi[subject.CloName.IndexOf(cloname)],
                    SubjectId = _subject.Id
                };
                await _context.SubjectOutputStandards.AddAsync(subjectoutput);
            }
            foreach (var content in subject.DetailContent)
            {
                var subjectContent = new SubjectContent
                {
                   
                    Clos = subject.Clos[subject.DetailContent.IndexOf(content)],
                    Content = content,
                    Method  = subject.Method[subject.DetailContent.IndexOf(content)],
                    NLessons = subject.NLessons[subject.DetailContent.IndexOf(content)],
                    Bonus = subject.Bonus[subject.DetailContent.IndexOf(content)],
                    SubjectId = _subject.Id
                };
                await _context.SubjectContents.AddAsync(subjectContent);
            }
            await _context.SaveChangesAsync();
            responseModel.Status = Status.Success;
            responseModel.Message = "Subject create succesfully";

            return responseModel;
        }

        public SubjectModel GetById(int id)
        {
            var subject = _context.Subjects.Include(x => x.SubjectUsers).Include(x=>x.SubjectOutputStandards).SingleOrDefault(x=> x.Id == id);
            if (subject != null)
            {
                return new SubjectModel
                {

                    Name = subject.Name,
                    TheoryCredits = subject.TheoryCredits,
                    PracticeCredits = subject.PracticeCredits,
                    TotalCredits = subject.TotalCredits,
                    Documents = subject.Documents,
                    Goals = subject.Goals,
                    Abstract = subject.Abstract,
                    A = subject.A,
                    B = subject.B,
                    C = subject.C,
                    Other = subject.Other,
                    UserId = subject.SubjectUsers.Select(u => u.UserId).ToList(),
                    CloName = subject.SubjectOutputStandards.Select(u => u.CloName).ToList(),
                    OutputContent = subject.SubjectOutputStandards.Select(u => u.Content).ToList(),
                    SoPerPi = subject.SubjectOutputStandards.Select(u => u.SoPerPi).ToList(),
                    DetailContent = subject.SubjectContents.Select(u => u.Content).ToList(),
                    Clos = subject.SubjectContents.Select(u => u.Clos).ToList(),
                    Method = subject.SubjectContents.Select(u => u.Method).ToList(),
                    NLessons = subject.SubjectContents.Select(u => u.NLessons).ToList(),
                    Bonus = subject.SubjectContents.Select(u => u.Bonus).ToList(),
                };
            }
            return null;
                 
        }

        public async Task<ResponseModel> UpdateSubject(SubjectModel subject, int id)
        {
            var responseModel = new ResponseModel();
            foreach (var userId in subject.UserId)
            {
                var user = await _context.Users.FindAsync(userId);
                if (user == null)
                {
                    responseModel.Status = Status.Error;
                    responseModel.Message = "Id User not found";
                    return responseModel;
                }
            }
            var _subject = _context.Subjects.Include(x => x.SubjectUsers).Include(x => x.SubjectOutputStandards).Include(x => x.SubjectContents).SingleOrDefault(x => x.Id == id);
            if (_subject != null)
            {
                _subject.Name = subject.Name;
                _subject.TheoryCredits = subject.TheoryCredits;
                _subject.PracticeCredits = subject.PracticeCredits;
                _subject.TotalCredits = subject.TotalCredits;
                _subject.Documents = subject.Documents;
                _subject.Goals = subject.Goals;
                _subject.Abstract = subject.Abstract;
                _subject.A = subject.A;
                _subject.B = subject.B;
                _subject.C = subject.C;
                _subject.Other = subject.Other;
                _subject.SubjectUsers.Clear();
                foreach (var userId in subject.UserId)
                {
                    var subjectuser = new SubjectUser
                    {
                        UserId = userId,  
                        SubjectId = _subject.Id
                    };
                    await _context.SubjectUsers.AddAsync(subjectuser);
                }
                _subject.SubjectOutputStandards.Clear();
                foreach (var cloname in subject.CloName)
                {
                    var subjectoutput = new SubjectOutputStandard
                    {
                        CloName = cloname,
                        Content = subject.OutputContent[subject.CloName.IndexOf(cloname)],
                        SoPerPi = subject.SoPerPi[subject.CloName.IndexOf(cloname)],
                        SubjectId = _subject.Id
                    };
                    await _context.SubjectOutputStandards.AddAsync(subjectoutput);
                }
                _subject.SubjectContents.Clear();
                foreach (var content in subject.DetailContent)
                {
                    var subjectContent = new SubjectContent
                    {

                        Clos = subject.Clos[subject.DetailContent.IndexOf(content)],
                        Content = content,
                        Method = subject.Method[subject.DetailContent.IndexOf(content)],
                        NLessons = subject.NLessons[subject.DetailContent.IndexOf(content)],
                        Bonus = subject.Bonus[subject.DetailContent.IndexOf(content)],
                        SubjectId = _subject.Id
                    };
                    await _context.SubjectContents.AddAsync(subjectContent);
                }
                await _context.SaveChangesAsync();
                responseModel.Status = Status.Success;
                responseModel.Message = "Update Succesfully";
                return responseModel;
            }
            responseModel.Status = Status.Error;
            responseModel.Message = "Update Failed";
            return responseModel;


        }

        public async Task<ResponseModel> DeleteSubject(int id)
        {
            var responseModel = new ResponseModel();
            var _subject = await _context.Subjects.Include(x => x.SubjectUsers).Include(x => x.SubjectContents).Include(x => x.SubjectOutputStandards).SingleOrDefaultAsync(x => x.Id == id);
            if(_subject != null)
            {
                _context.Subjects.Remove(_subject);
                var result = await _context.SaveChangesAsync();
                if(result == 0)
                {
                    responseModel.Status = Status.Success;
                    responseModel.Message = "";

                    return responseModel;
                }
                else
                {
                    responseModel.Status = Status.Success;
                    responseModel.Message = "Subject  succesfully";

                    return responseModel;
                }    
            }
            responseModel.Status = Status.Success;
            responseModel.Message = "Id Subject not found";

            return responseModel;
             
        }
    }
}

