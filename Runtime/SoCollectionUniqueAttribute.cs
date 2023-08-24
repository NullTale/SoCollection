using System;
using UnityEngine;

namespace SoCollection
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class SoCollectionUniqueAttribute : PropertyAttribute
    {
        public Type[] _except;
        
        public SoCollectionUniqueAttribute(params Type[] except)
        {
            _except = except;
        }
    }
}