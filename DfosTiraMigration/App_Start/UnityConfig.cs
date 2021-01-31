using DfosTira.Infrastructer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace DfosTiraMigration.App_Start
{
    public class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();


            container.RegisterInstance(new AutoMapperWebProfile().GetMapper());
          
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}