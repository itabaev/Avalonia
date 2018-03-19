// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Avalonia.Controls.Utils
{
    internal static class IEnumerableUtils
    {
        public static bool Contains(this IEnumerable items, object item)
        {
            return items.IndexOf(item) != -1;
        }

        public static int Count(this IEnumerable items)
        {
            if (items != null)
            {
                var collection = items as ICollection;

                if (collection != null)
                {
                    return collection.Count;
                }
                else
                {
                    return Enumerable.Count(items.Cast<object>());
                }
            }
            else
            {
                return 0;
            }
        }

        public static int IndexOf(this IEnumerable items, object item)
        {
            Contract.Requires<ArgumentNullException>(items != null);

            var list = items as IList;

            if (list != null)
            {
                return list.IndexOf(item);
            }
            else
            {
                int index = 0;

                foreach (var i in items)
                {
                    if (ReferenceEquals(i, item))
                    {
                        return index;
                    }

                    ++index;
                }

                return -1;
            }
        }

        public static object ElementAt(this IEnumerable items, int index)
        {
            Contract.Requires<ArgumentNullException>(items != null);

            var list = items as IList;

            if (list != null)
            {
                return list[index];
            }
            else
            {
                return Enumerable.ElementAt(items.Cast<object>(), index);
            }
        }

        public static bool IsEmpty(this IEnumerable items)
        {
            Contract.Requires<ArgumentNullException>(items != null);

            var enumerator = items.GetEnumerator();
            var isEmpty = !enumerator.MoveNext();

            (enumerator as IDisposable)?.Dispose();

            return isEmpty;
        }

        public static ReadOnlyCollection<ItemPropertyInfo> GetItemProperties(this IEnumerable items)
        {
            if (items == null)
                return null;

            IEnumerable properties = null;

            ITypedList itl = items as ITypedList;
            Type itemType;
            object item;

            if (itl != null)
            {
                // ITypedList has the information
                properties = itl.GetItemProperties(null);
            }
            else if ((itemType = items.GetItemType()) != null)
            {
                // If we know the item type, use its properties.
                properties = TypeDescriptor.GetProperties(itemType);
            }
            else if ((item = items.GetRepresentativeItem()) != null)
            {
                properties = TypeDescriptor.GetProperties(item);
            }

            if (properties == null)
                return null;

            // Convert the properties to ItemPropertyInfo
            var list = new List<ItemPropertyInfo>();
            foreach (var property in properties)
            {
                if (property is PropertyDescriptor pd)
                {
                    list.Add(new ItemPropertyInfo(pd.Name, pd.PropertyType, pd));
                }
                else if (property is PropertyInfo pi)
                {
                    list.Add(new ItemPropertyInfo(pi.Name, pi.PropertyType, pi));
                }
            }

            // return the result as a read-only collection
            return new ReadOnlyCollection<ItemPropertyInfo>(list);
        }

        private static Type GetItemType(this IEnumerable items)
        {
            var collectionType = items.GetType();
            var interfaces = collectionType.GetInterfaces();

            // Look for IEnumerable<T>.  All generic collections should implement
            // this.  We loop through the interface list, rather than call
            // GetInterface(IEnumerableT), so that we handle an ambiguous match
            // (by using the first match) without an exception.
            for (int i = 0; i < interfaces.Length; ++i)
            {
                var interfaceType = interfaces[i];

                if (interfaceType.Name == s_iEnumerableT)
                {
                    // found IEnumerable<>, extract T
                    var typeParameters = interfaceType.GetGenericArguments();
                    if (typeParameters.Length == 1)
                    {
                        var type = typeParameters[0];

                        if (type == typeof(object))
                        {
                            // IEnumerable<object> is useless;  we need a representative
                            // item.   But keep going - perhaps IEnumerable<T> shows up later.
                            continue;
                        }

                        return type;
                    }
                }
            }

            return null;
        }

        private static object GetRepresentativeItem(this IEnumerable items)
        {
            if (items.IsEmpty())
                return null;

            object result = null;
            IEnumerator ie = items.GetEnumerator();
            while (ie.MoveNext())
            {
                object item = ie.Current;
                if (item != null)
                {
                    result = item;
                    break;
                }
            }

            (ie as IDisposable)?.Dispose();

            return result;
        }

        private static readonly string s_iEnumerableT = typeof(IEnumerable<>).Name;
    }
}
