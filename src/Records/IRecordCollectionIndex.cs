﻿/*  Copyright (c) 2016 Upstream Research, Inc.  */
/*  Subject to the MIT License. See LICENSE file in top-level directory. */

using System;
using System.Collections.Generic;

namespace Upstream.System.Records
{
    /// <summary>
    /// Defines an interface for a searchable index on an underlying record collection.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <remarks>
    /// This interface could be implemented by a database query, 
    /// so it is by design that the underlying record collection is not exposed.
    /// </remarks>
    public interface IRecordCollectionIndex<TValue>
    {
        /// <summary>
        /// Get an enumeration of the key field names used for this index
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> KeyFieldNames { get; }

        /// <summary>
        /// Get the first record that matches the input record
        /// </summary>
        /// <param name="keyRecord"></param>
        /// <returns>null reference if no record was found</returns>
        IRecordAccessor<TValue> FindFirst(IRecordAccessor<TValue> keyRecord);

        /// <summary>
        /// Get record enumerator that can enumerate all records that match the input record
        /// </summary>
        /// <param name="keyRecord"></param>
        /// <returns></returns>
        IRecordEnumerator<TValue> GetRecordEnumerator(IRecordAccessor<TValue> keyRecord);

    } // /interface
} // /namespace
