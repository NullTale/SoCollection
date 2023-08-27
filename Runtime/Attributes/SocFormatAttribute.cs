using System;
using UnityEngine;

namespace SoCollection
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class SocFormatAttribute : PropertyAttribute
    {
        public string _format;
        public string _regexClear;
        public bool _nicify;
        
        public SocFormatAttribute(string format = "{0}", string regexClear = "", bool nicify = true)
        {
            _format = format;
            _regexClear = regexClear;
            _nicify = nicify; 
        }
    }
}