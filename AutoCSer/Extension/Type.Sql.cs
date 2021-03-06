﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AutoCSer.Extension
{
    /// <summary>
    /// 类型扩展操作
    /// </summary>
    internal static partial class Type_Sql
    {
        /// <summary>
        /// 判断类型是否可空类型
        /// </summary>
        /// <param name="type">类型</param>
        /// <returns>是否可空类型</returns>
        [MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
        internal static bool isNull(this Type type)
        {
            return type != null && (!type.IsValueType || (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>)));
        }
        /// <summary>
        /// 值类型转换为可空类型
        /// </summary>
        /// <param name="type">值类型</param>
        /// <returns>可空类型,失败返回null</returns>
        [MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
        internal static Type toNullableType(this Type type)
        {
            return type != null && type.IsValueType ? typeof(Nullable<>).MakeGenericType(type) : null;
        }
    }
}
