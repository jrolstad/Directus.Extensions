﻿using System.Collections.Generic;

namespace Directus.Extensions.Core
{
    /// <summary>
    /// Extension methods for ICollection
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Adds a range of items to the collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="itemsToAdd"></param>
        public static ICollection<T> AddRange<T>(this ICollection<T> source, IEnumerable<T> itemsToAdd)
        {
            itemsToAdd.Each(source.Add);
            
            return source;
        }
    }
}