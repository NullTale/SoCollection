using System;
using UnityEngine;

namespace SoCollection
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class SoCollectionTypesAttribute : PropertyAttribute
    {
        public Type[] Types;

        public SoCollectionTypesAttribute(params Type[] types)
        {
            Types = types;
        }
    }
}