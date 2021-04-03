﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Text.Json.Serialization.Metadata
{
    /// <summary>
    /// todo
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class JsonCollectionTypeInfo<T> : JsonTypeInfo<T>
    {
        /// <summary>
        /// todo
        /// </summary>
        /// <param name="createObjectFunc"></param>
        /// <param name="converter"></param>
        /// <param name="elementInfo"></param>
        /// <param name="options"></param>
        public JsonCollectionTypeInfo(
            ConstructorDelegate createObjectFunc,
            JsonConverter<T> converter,
            JsonTypeInfo elementInfo,
            JsonSerializerOptions options) : base(typeof(T), options, ClassType.Enumerable)
        {
            ConverterBase = converter;

            ElementType = converter.ElementType;
            ElementTypeInfo = elementInfo;
            CreateObject = createObjectFunc;

            PropertyInfoForTypeInfo = SourceGenCreatePropertyInfoForTypeInfo<T>(Type, runtimeTypeInfo: this, converter, Options);
        }
    }
}
