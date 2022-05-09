using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _context;
        public CourseRepository(UniversityDBContext context)
        {
            _context = context; 
        }
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
