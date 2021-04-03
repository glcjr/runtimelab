﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Text.Json.Serialization.Metadata
{
    /// <summary>
    /// todo
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class JsonTypeInfo<T> : JsonTypeInfo
    {
        internal JsonTypeInfo(Type type, JsonSerializerOptions options, ClassType classType) :
            base(type, options, classType)
        { }

        /// <summary>
        /// todo
        /// </summary>
        public void RegisterToOptions()
        {
            //_isInitialized = true;
            Options.AddJsonTypeInfoToCompleteInitialization(this);
        }
    }
}
