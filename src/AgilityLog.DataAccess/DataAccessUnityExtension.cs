using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgilityLog.DataAccess.EntityRepository;
using AgilityLog.DataAccess.EntityRepository.Configurations;
using Microsoft.Practices.Unity;

namespace AgilityLog.DataAccess
{
    /// <summary>
    /// Unity registrations needed by DataAccess
    /// </summary>
    /// <seealso cref="Microsoft.Practices.Unity.UnityContainerExtension" />
    public class DataAccessUnityExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            this.Container.RegisterType<IContext, AgilityLogContext>(new HierarchicalLifetimeManager());

            this.Container.RegisterType<IEntityConfiguration, AgilityClassConfiguration>("AgilityClassConfiguration");
            this.Container.RegisterType<IEntityConfiguration, AgilityShowConfiguration>("AgilityShowConfiguration");
        }
    }
}
