using System;

namespace Avalonia.Controls
{
    /// <summary>
    /// Information about a property.
    /// </summary>
    public class ItemPropertyInfo
    {
        /// <summary> Creates a new instance of ItemPropertyInfo. </summary>
        public ItemPropertyInfo(string name, Type type, object descriptor)
        {
            Name = name;
            PropertyType = type;
            Descriptor = descriptor;
        }

        /// <summary> The property's name. </summary>
        public string Name { get; }

        /// <summary> The property's type. </summary>
        public Type PropertyType { get; }

        /// <summary> More information about the property.  This may be null,
        /// the view is unable to provide any more information.  Or it may be
        /// an object that describes the property, such as a PropertyDescriptor,
        /// a PropertyInfo, or the like.
        /// </summary>
        public object Descriptor { get; }
    }
}
