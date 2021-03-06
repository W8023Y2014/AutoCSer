﻿using System;
/*Type:ulong;long;uint;int;DateTime*/
/*Compare:;Desc*/

namespace AutoCSer.Extension
{
    /// <summary>
    /// 数组子串扩展操作
    /// </summary>
    public static partial class SubArray
    {
        /// <summary>
        /// 数组子串排序
        /// </summary>
        /// <param name="array">待排序数组子串</param>
        /// <returns>排序后的数组子串</returns>
        [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
        public static SubArray</*Type[0]*/ulong/*Type[0]*/> sort/*Compare[0]*//*Compare[0]*/(this SubArray</*Type[0]*/ulong/*Type[0]*/> array)
        {
            if (array.Length > 1) FixedArraySort.Sort/*Compare[0]*//*Compare[0]*/(array.Array, array.Start, array.Length);
            return array;
        }
        /// <summary>
        /// 数组子串排序
        /// </summary>
        /// <param name="array">待排序数组子串</param>
        /// <returns>排序后的新数组</returns>
        [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
        public static /*Type[0]*/ulong/*Type[0]*/[] getSort/*Compare[0]*//*Compare[0]*/(this SubArray</*Type[0]*/ulong/*Type[0]*/> array)
        {
            return array.Length > 1 ? FixedArraySort.GetSort/*Compare[0]*//*Compare[0]*/(array.Array, array.Start, array.Length) : array.GetArray();
        }
        /// <summary>
        /// 数组子串排序
        /// </summary>
        /// <typeparam name="valueType">数据类型</typeparam>
        /// <param name="array">待排序数组子串</param>
        /// <param name="getKey">排序键</param>
        /// <returns>排序后的数组</returns>
        [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
        public static valueType[] getSort/*Compare[0]*//*Compare[0]*/<valueType>(this SubArray<valueType> array, Func<valueType, /*Type[0]*/ulong/*Type[0]*/> getKey)
        {
            return array.Length > 1 ? FixedArraySort.GetSort/*Compare[0]*//*Compare[0]*/(array.Array, getKey, array.Start, array.Length) : array.GetArray();
        }
    }
}
