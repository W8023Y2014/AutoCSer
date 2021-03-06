﻿using System;

namespace AutoCSer.TestCase
{
    class Json
    {
        /// <summary>
        /// 随机对象生成参数
        /// </summary>
        private static readonly AutoCSer.RandomObject.Config randomConfig = new AutoCSer.RandomObject.Config { IsSecondDateTime = true, IsParseFloat = true };
        /// <summary>
        /// 带成员位图的JSON序列化参数配置
        /// </summary>
        private static readonly AutoCSer.Json.SerializeConfig jsonSerializeConfig = new AutoCSer.Json.SerializeConfig(); 
        
        /// <summary>
        /// JSON 序列化测试
        /// </summary>
        /// <returns></returns>
#if TEST
        [AutoCSer.Metadata.TestMethod]
#endif
        internal static bool TestCase()
        {
            #region 引用类型字段成员JSON序列化测试
            Data.FieldData filedData = AutoCSer.RandomObject.Creator<Data.FieldData>.Create(randomConfig);
            string jsonString = AutoCSer.Json.Serializer.Serialize(filedData);
            //AutoCSer.Log.Trace.Console(jsonString);
            Data.FieldData newFieldData = AutoCSer.Json.Parser.Parse<Data.FieldData>(jsonString);
            if (!AutoCSer.FieldEquals.Comparor<Data.FieldData>.Equals(filedData, newFieldData))
            {
                return false;
            }
            //AutoCSer.Log.Trace.Console(AutoCSer.Json.Serializer.Serialize(newFieldData));
            #endregion

            #region 带成员位图的引用类型字段成员JSON序列化测试
            jsonSerializeConfig.MemberMap = AutoCSer.Metadata.MemberMap<Data.FieldData>.NewFull();
            jsonString = AutoCSer.Json.Serializer.Serialize(filedData, jsonSerializeConfig);
            newFieldData = AutoCSer.Json.Parser.Parse<Data.FieldData>(jsonString);
            if (!AutoCSer.FieldEquals.Comparor<Data.FieldData>.MemberMapEquals(filedData, newFieldData, jsonSerializeConfig.MemberMap))
            {
                return false;
            }
            #endregion

            #region 引用类型属性成员JSON序列化测试
            Data.PropertyData propertyData = AutoCSer.RandomObject.Creator<Data.PropertyData>.Create(randomConfig);
            jsonString = AutoCSer.Json.Serializer.Serialize(propertyData);
            Data.PropertyData newPropertyData = AutoCSer.Json.Parser.Parse<Data.PropertyData>(jsonString);
            if (!AutoCSer.FieldEquals.Comparor<Data.PropertyData>.Equals(propertyData, newPropertyData))
            {
                return false;
            }
            #endregion

            #region 值类型字段成员JSON序列化测试
            Data.StructFieldData structFieldData = AutoCSer.RandomObject.Creator<Data.StructFieldData>.Create(randomConfig);
            jsonString = AutoCSer.Json.Serializer.Serialize(structFieldData);
            Data.StructFieldData newStructFieldData = AutoCSer.Json.Parser.Parse<Data.StructFieldData>(jsonString);
            if (!AutoCSer.FieldEquals.Comparor<Data.StructFieldData>.Equals(structFieldData, newStructFieldData))
            {
                return false;
            }
            #endregion

            #region 带成员位图的值类型字段成员JSON序列化测试
            jsonSerializeConfig.MemberMap = AutoCSer.Metadata.MemberMap<Data.StructFieldData>.NewFull();
            jsonString = AutoCSer.Json.Serializer.Serialize(structFieldData, jsonSerializeConfig);
            newStructFieldData = AutoCSer.Json.Parser.Parse<Data.StructFieldData>(jsonString);
            if (!AutoCSer.FieldEquals.Comparor<Data.StructFieldData>.MemberMapEquals(structFieldData, newStructFieldData, jsonSerializeConfig.MemberMap))
            {
                return false;
            }
            #endregion

            #region 值类型属性成员JSON序列化测试
            Data.StructPropertyData structPropertyData = AutoCSer.RandomObject.Creator<Data.StructPropertyData>.Create(randomConfig);
            jsonString = AutoCSer.Json.Serializer.Serialize(structPropertyData);
            Data.StructPropertyData newStructPropertyData = AutoCSer.Json.Parser.Parse<Data.StructPropertyData>(jsonString);
            if (!AutoCSer.FieldEquals.Comparor<Data.StructPropertyData>.Equals(structPropertyData, newStructPropertyData))
            {
                return false;
            }
            #endregion

            return true;
        }
    }
}
