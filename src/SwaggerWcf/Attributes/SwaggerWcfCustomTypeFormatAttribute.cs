using SwaggerWcf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerWcf.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SwaggerWcfCustomTypeFormatAttribute : Attribute
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="format">Custom swagger format.</param>
        public SwaggerWcfCustomTypeFormatAttribute(ParameterType type, string format)
        {
            this.Format = format;
            this.Type = type;
        }

        /// <summary>
        /// Custom swagger format.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Parameter type.
        /// </summary>
        public ParameterType Type { get; set; }
    }
}
