using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrpl4net.Client.Models;

namespace Xrpl4net.Tests
{
    public abstract class BaseXRPL4NetTest
    {
        protected static T PropertiesShouldEqual<T, Tm>(T entity, Tm model, params string[] filter)
            where T : BaseResponse
            where Tm : BaseResponse
        {
            var objectProperties = typeof(T).GetProperties();
            var modelProperties = typeof(Tm).GetProperties();

            foreach (var objectProperty in objectProperties)
            {
                var name = objectProperty.Name;

                if (filter.Contains(name))
                    continue;

                var modelProperty = Array.Find(modelProperties, p => p.Name == name);

                if (modelProperty == null)
                    continue;

                var objectPropertyValue = objectProperty.GetValue(entity);
                var modelPropertyValue = modelProperty.GetValue(model);

                objectPropertyValue.Should().Be(modelPropertyValue, $"The property \"{typeof(T).Name}.{objectProperty.Name}\" of these objects is not equal");
            }

            return entity;
        }
    }
}
