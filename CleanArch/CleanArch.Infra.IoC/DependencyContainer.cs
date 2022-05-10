using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Infra.Data.Repository;

namespace CleanArch.Infra.IoC
{
   public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection service)
        {
            //Application Layer
            service.AddScoped<ICourseService,CourseService>();

            // Infra.Data Layer
            service.AddScoped<Domain.Interfaces.ICourseRepository, CourseRepository>();


        }
    }
}
