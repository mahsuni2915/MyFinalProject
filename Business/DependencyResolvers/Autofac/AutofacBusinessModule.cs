using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;

using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.İnterceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();// Biri senden Iproduct service isterse
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
          
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();// Biri senden Iproduct service isterse
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            
          builder.RegisterType<IHttpContextAccessor>().As<IHttpContextAccessor>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
