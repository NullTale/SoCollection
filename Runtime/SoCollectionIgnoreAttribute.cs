using System;
using UnityEngine;

namespace SoCollection
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class SoCollectionIgnoreAttribute : PropertyAttribute
    {
    }
}