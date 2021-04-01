using System;
using System.Reflection;

namespace TypewiseAlert
{
    public class InstanceFactory
    {
        public static Object GetInstance(string className)
        {
            Type instance = null;
            foreach (Type type in Assembly.Load(Assembly.GetExecutingAssembly().GetName()).GetTypes())
            {
                if (type.Name.Contains(className))
                {
                    instance = type;
                    break;
                }
            }
            return Activator.CreateInstance(instance);
        }
    }
}
