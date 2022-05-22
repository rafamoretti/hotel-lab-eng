using System;

namespace Assets
{
    public interface IClassReader
    {
        public T1 ClassMapper<T1, T2>(T2 source);
    }

    public class ClassReader : IClassReader
    {
        public T1 ClassMapper<T1, T2>(T2 source)
        {
            var targetObjInstance = Activator.CreateInstance<T1>();

            var properties = typeof(T2).GetProperties();
            var targetProperties = typeof(T1).GetProperties();

            foreach (var props in properties)
            {
                foreach (var targProp in targetProperties)
                {
                    if (props == targProp)
                    {
                        targProp.SetValue(targetObjInstance, props.GetValue(source));
                    }
                }
            }

            return targetObjInstance;
        }
    }
}