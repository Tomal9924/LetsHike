using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using EntityClass;
using Repository;
using InterfaceClass;


namespace Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();


            container.RegisterType<ICustomerRepository , CustomerRepository>();
            container.RegisterType<ITravellerRepository, TravellerRepository>();
            container.RegisterType<IPackageRepository, PackageRepository>();
            container.RegisterType<IAdminRepository, AdminRepository>();
           container.RegisterType<IProductRepository, ProductRepository>();
            

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}