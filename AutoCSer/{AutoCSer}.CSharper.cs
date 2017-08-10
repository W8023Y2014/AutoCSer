//本文件由程序自动生成,请不要自行修改
using System;
using AutoCSer;

#if NoAutoCSer
#else
#pragma warning disable

namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal partial class Ajax
    {
    internal partial class Generator
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.CSharp, _isOut_))
            {
                
            _code_.Add(@"
        /// <summary>
        /// AJAX函数调用
        /// </summary>
        [AutoCSer.WebView.Call]
        [AutoCSer.WebView.ClearMember(IsIgnoreCurrent = true)]
        public sealed class AjaxLoader : AutoCSer.WebView.AjaxLoader<AjaxLoader>
        {
            [AutoCSer.WebView.CallMethod(FullName = ""/Ajax"")]
            [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
            public void Load()
            {
                load();
            }
            protected override void loadView(AutoCSer.WebView.AjaxMethodInfo ajaxInfo)
            {
                switch (ajaxInfo.MethodIndex)
                {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.ViewMethod[] _value1_;
                    _value1_ = ViewMethods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.ViewMethod _value2_ in _value1_)
                        {
            _code_.Add(@"
                    case ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@": loadView(");
            _if_ = false;
                    if (_value2_.IsPoolType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebViewMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.Pop() ?? ");
            }
            _code_.Add(@"new ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebViewMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"(), ajaxInfo); return;");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    default: return;
                }
            }
            protected override void loadAjax(AutoCSer.WebView.AjaxMethodInfo ajaxInfo)
            {
                switch (ajaxInfo.MethodIndex)
                {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.AjaxMethod[] _value1_;
                    _value1_ = Methods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.AjaxMethod _value2_ in _value1_)
                        {
            _code_.Add(@"
                    case ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@": loadAjax(");
            _if_ = false;
                    if (_value2_.IsPoolType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebAjaxMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.Pop() ?? ");
            }
            _code_.Add(@"new ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebAjaxMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"(), ajaxInfo); return;");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _if_ = false;
                if (!(bool)IsPubError)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    case ");
            _code_.Add(MethodCount.ToString());
            _code_.Add(@" - 1: pubError(); return;");
            }
            _code_.Add(@"
                    default: return;
                }
            }
            protected override bool callAjax(int callIndex, AutoCSer.WebView.AjaxBase page)
            {
                switch (callIndex)
                {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.AjaxMethod[] _value1_;
                    _value1_ = Methods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.AjaxMethod _value2_ in _value1_)
                        {
            _code_.Add(@"
                    case ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@":
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" inputParameter = new ");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"();
                            if (page.ParseParameter(ref inputParameter))");
            }
            _code_.Add(@"
                            {
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebAjaxMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ajax = (");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebAjaxMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@")page;");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" outputParameter = new ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" { ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _if_ = false;
                    if (_value4_.IsRef)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@" = inputParameter.");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@", ");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"};");
            }
            _if_ = false;
                    if (_value2_.IsAsynchronousCallback)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value2_.AsyncIndexName);
            _code_.Add(@" returnCallbak = new ");
            _code_.Add(_value2_.AsyncIndexName);
            _code_.Add(@" { Ajax = ajax, Parameter = outputParameter };
                                ajax.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _code_.Add(@"inputParameter.");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@", ");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"returnCallbak.Callback);");
            }
            _if_ = false;
                if (!(bool)_value2_.MethodIsReturn)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsPoolType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                AjaxCallbackPool<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebAjaxMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(_value2_.OutputParameterTypeName);
            }
            _code_.Add(@"> callbackPool = new AjaxCallbackPool<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebAjaxMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(_value2_.OutputParameterTypeName);
            }
            _code_.Add(@"> { Ajax = ajax");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", Parameter = outputParameter");
            }
            _code_.Add(@" };
                                ajax.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _code_.Add(@"inputParameter.");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@", ");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"callbackPool.Callback);");
            }
            _if_ = false;
                if (!(bool)_value2_.IsPoolType)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                AjaxCallback");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" callback = new AjaxCallback");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" { Ajax = ajax");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", Parameter = outputParameter");
            }
            _code_.Add(@" };
                                ajax.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _code_.Add(@"inputParameter.");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@", ");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"callback.Callback);");
            }
            }
            }
            _if_ = false;
                if (!(bool)_value2_.IsAsynchronousCallback)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                try
                                {
                                    ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    outputParameter.Return = ");
            }
            _code_.Add(@"ajax.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"outputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterJoin);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    outputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                                }
                                finally { responseAjax(ajax");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref outputParameter");
            }
            _code_.Add(@"); }");
            }
            _code_.Add(@"
                                return true;
                            }
                        }
                        return false;");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    default: return false;
                }
            }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.AjaxMethod[] _value1_;
                    _value1_ = Methods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.AjaxMethod _value2_ in _value1_)
                        {
            _if_ = false;
                    if (_value2_.IsAsynchronousCallback)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            sealed class ");
            _code_.Add(_value2_.AsyncIndexName);
            _code_.Add(@" : ");
            _code_.Add(_value2_.AjaxCallbackPool);
            _code_.Add(@"<");
            _if_ = false;
                    if (_value2_.IsPoolType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebAjaxMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@", ");
            }
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">
            {
                public void Callback(AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> value)
                {
                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebAjaxMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ajax = System.Threading.Interlocked.Exchange(ref Ajax, null);
                    if (ajax != null)
                    {
                        Parameter.Return = value.Value;
                        response(ajax, value.Type);
                    }
                }
            }");
            }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterTypeNames[] _value1_;
                    _value1_ = ParameterTypes;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterTypeNames _value2_ in _value1_)
                        {
            _if_ = false;
                    if (_value2_.IsSerializeBox)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            [AutoCSer.Metadata.BoxSerialize]");
            }
            _code_.Add(@"
            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
            struct ");
            _code_.Add(_value2_.ParameterTypeName);
            _code_.Add(@"
            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.Parameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(@"
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.ParameterType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
                    if (_value3_.Type != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" Return;");
            }
            _code_.Add(@"
            }");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
            static AjaxLoader()
            {
                string[] names = new string[");
            _code_.Add(MethodCount.ToString());
            _code_.Add(@"];
                AutoCSer.WebView.AjaxMethodInfo[] infos = new AutoCSer.WebView.AjaxMethodInfo[");
            _code_.Add(MethodCount.ToString());
            _code_.Add(@"];");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.AjaxMethod[] _value1_;
                    _value1_ = Methods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.AjaxMethod _value2_ in _value1_)
                        {
            _code_.Add(@"
                names[");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@"] = """);
            _code_.Add(_value2_.CallName);
            _code_.Add(@""";
                infos[");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@"] = new AutoCSer.WebView.AjaxMethodInfo { MethodIndex = ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@", MaxMemoryStreamSize = (AutoCSer.SubBuffer.Size)");
            _code_.Add(_value2_.MaxMemoryStreamSize.ToString());
                {
                    AutoCSer.WebView.AjaxMethodAttribute _value3_ = default(AutoCSer.WebView.AjaxMethodAttribute);
                    _value3_ = _value2_.Attribute;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", MaxPostDataSize = ");
            _code_.Add(_value3_.MaxPostDataSize.ToString());
            _code_.Add(@", IsPost = ");
            _code_.Add(_value3_.IsOnlyPost ? "true" : "false");
            _code_.Add(@", IsReferer = ");
            _code_.Add(_value3_.IsReferer ? "true" : "false");
            }
                }
            _code_.Add(@", IsAsynchronous = ");
            _code_.Add(_value2_.IsAsynchronousCallback ? "true" : "false");
            _code_.Add(@" };");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.ViewMethod[] _value1_;
                    _value1_ = ViewMethods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.ViewMethod _value2_ in _value1_)
                        {
            _code_.Add(@"
                names[");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@"] = """);
            _code_.Add(_value2_.CallName);
            _code_.Add(@""";
                infos[");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@"] = new AutoCSer.WebView.AjaxMethodInfo { MethodIndex = ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@", MaxMemoryStreamSize = (AutoCSer.SubBuffer.Size)");
            _code_.Add(_value2_.MaxMemoryStreamSize.ToString());
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = default(AutoCSer.WebView.ViewAttribute);
                    _value3_ = _value2_.Attribute;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", MaxPostDataSize = ");
            _code_.Add(_value3_.MaxPostDataSize.ToString());
            _code_.Add(@", IsAsynchronous = ");
            _code_.Add(_value3_.IsAsynchronous ? "true" : "false");
            }
                }
            _code_.Add(@", IsReferer = false, IsViewPage = true };");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _if_ = false;
                if (!(bool)IsPubError)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                names[");
            _code_.Add(MethodCount.ToString());
            _code_.Add(@" - 1] = AutoCSer.WebView.AjaxBase.PubErrorCallName");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value1_ = AutoParameter;
                    if (_value1_ != null)
                    {
                {
                    AutoCSer.WebView.Config _value2_ = _value1_.WebConfig;
                    if (_value2_ != null)
                    {
                    if (_value2_.IgnoreCase)
                    {
                        _if_ = true;
                    }
                }
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@".ToLower()");
            }
            _code_.Add(@";
                infos[");
            _code_.Add(MethodCount.ToString());
            _code_.Add(@" - 1] = new AutoCSer.WebView.AjaxMethodInfo { MethodIndex = ");
            _code_.Add(MethodCount.ToString());
            _code_.Add(@" - 1, MaxPostDataSize = 2048, MaxMemoryStreamSize = AutoCSer.SubBuffer.Size.Kilobyte2, IsReferer = true, IsAsynchronous = true, IsPost = true };");
            }
            _code_.Add(@"
                setMethods(names, infos);
            }
        }");
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal partial class Ajax
    {
    internal partial class TypeScript
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.TypeScript, _isOut_))
            {
                
            _code_.Add(@"module ");
            _code_.Add(Namespace);
            _code_.Add(@" {
	export class ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                {
                    System.Type _value2_ = _value1_.Type;
                    if (_value2_ != null)
                    {
            _code_.Add(_value2_.Name);
                    }
                }
                    }
                }
            _code_.Add(@" {
		");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.AjaxMethod[] _value1_;
                    _value1_ = Methods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.Ajax.Generator.AjaxMethod _value2_ in _value1_)
                        {
            _code_.Add(@"
		static ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                {
                    System.Reflection.MethodInfo _value4_ = _value3_.Method;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.Name);
                    }
                }
                    }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.NotOutParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterName);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.ParameterType;
                    if (_value5_ != null)
                    {
                    if (_value5_.ScriptType != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@":");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.ParameterType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.ScriptType);
                    }
                }
            }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"Callback = null) {
			AutoCSer.Pub.");
            _if_ = false;
                {
                    AutoCSer.WebView.AjaxMethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsOnlyPost)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"GetAjaxPost");
            }
            _if_ = false;
                {
                    AutoCSer.WebView.AjaxMethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsOnlyPost)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"GetAjaxGet");
            }
            _code_.Add(@"()('");
            _code_.Add(_value2_.CallName);
            _code_.Add(@"',");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_ = _value2_.NotOutParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"{");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.NotOutParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@": ");
            _code_.Add(_value4_.ParameterJoinName);
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@" }");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                if (_value3_.Length == 0)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"null");
            }
            _code_.Add(@", Callback");
            _if_ = false;
                {
                    AutoCSer.WebView.AjaxMethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsOnlyPost)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.WebView.AjaxMethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsVersion)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", true");
            }
            _if_ = false;
                {
                    AutoCSer.WebView.AjaxMethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsVersion)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@", false");
            }
            }
            _code_.Add(@");	
		}
		");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
	}
}");
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal abstract partial class DataPrimaryKey
    {
    internal partial class Generator
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.CSharp, _isOut_))
            {
                
            _code_.Add(@"
        ");
            _code_.Add(TypeNameDefinition);
            _code_.Add(@"
        {
            /// <summary>
            /// 关键字
            /// </summary>
            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
            public struct DataPrimaryKey : IEquatable<DataPrimaryKey>");
            _if_ = false;
                {
                    AutoCSer.Data.PrimaryKeyAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsComparable)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", IComparable<DataPrimaryKey>");
            }
            _code_.Add(@"
            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = PrimaryKeys;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _if_ = false;
                    if (_value2_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
            _code_.Add(_value2_.XmlDocument);
            _code_.Add(@"
                /// </summary>");
            }
            _code_.Add(@"
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MemberType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                /// <summary>
                /// 关键字比较
                /// </summary>
                /// <param name=""other"">关键字</param>
                /// <returns>是否相等</returns>
                public bool Equals(DataPrimaryKey other)
                {
                    return ");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value1_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value1_ = PrimaryKey0;
            _if_ = false;
                    if (_value1_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value1_.MemberName);
            _code_.Add(@"/**/.Equals(other.");
            _code_.Add(_value1_.MemberName);
            _code_.Add(@")");
            }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = NextPrimaryKeys;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _code_.Add(@" && ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@"/**/.Equals(other.");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@")");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@";
                }
                /// <summary>
                /// 哈希编码
                /// </summary>
                /// <returns></returns>
                public override int GetHashCode()
                {
                    return ");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value1_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value1_ = PrimaryKey0;
            _if_ = false;
                    if (_value1_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value1_.MemberName);
            }
                }
            _code_.Add(@".GetHashCode()");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = NextPrimaryKeys;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _code_.Add(@" ^ ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@"/**/.GetHashCode()");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@";
                }
                /// <summary>
                /// 关键字比较
                /// </summary>
                /// <param name=""obj""></param>
                /// <returns></returns>
                public override bool Equals(object obj)
                {
                    return Equals((DataPrimaryKey)obj);
                }");
            _if_ = false;
                {
                    AutoCSer.Data.PrimaryKeyAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsComparable)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 关键字比较
                /// </summary>
                /// <param name=""other""></param>
                /// <returns></returns>
                public int CompareTo(DataPrimaryKey other)
                {
                    int _value_ = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value1_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value1_ = PrimaryKey0;
            _if_ = false;
                    if (_value1_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value1_.MemberName);
            _code_.Add(@"/**/.CompareTo(other.");
            _code_.Add(_value1_.MemberName);
            _code_.Add(@")");
            }
                }
            _code_.Add(@";");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = NextPrimaryKeys;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _code_.Add(@"
                    if (_value_ == 0)
                    {
                        _value_ = ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@"/**/.CompareTo(other.");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@");");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = NextPrimaryKeys;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _code_.Add(@"
                    }");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    return _value_;
                }");
            }
            _code_.Add(@"
            }
        }");
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
#if DOTNET2
#else
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal abstract partial class SqlModel
    {
    internal partial class Generator
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.CSharp, _isOut_))
            {
                
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsDefaultSerialize)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
        [AutoCSer.Json.Serialize]
        [AutoCSer.Json.Parse]
        [AutoCSer.BinarySerialize.Serialize(IsReferenceMember = false");
            _if_ = false;
                if (!(bool)IsDefaultSerializeIsMemberMap)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsMemberMap = false");
            }
            _code_.Add(@")]");
            }
            _code_.Add(@"
        ");
            _code_.Add(TypeNameDefinition);
            _code_.Add(@"
        {
            /// <summary>
            /// 数据库表格模型
            /// </summary>
            /// <typeparam name=""tableType"">表格映射类型</typeparam>");
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            /// <typeparam name=""memberCacheType"">成员绑定缓存类型</typeparam>");
            }
            _code_.Add(@"
            public abstract class SqlModel<tableType");
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", memberCacheType");
            }
            _code_.Add(@"> : ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.LogServerName != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", AutoCSer.Sql.LogStream.IMemberMapValueLink<tableType>");
            }
            _code_.Add(@"
                where tableType : SqlModel<tableType");
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", memberCacheType");
            }
            _code_.Add(@">");
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                where memberCacheType : ");
            _code_.Add(MemberCacheBaseType);
            _if_ = false;
                if (CounterCacheType.ToString() == @"CreateIdentityCounterMemberQueue")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"AutoCSer.Sql.Cache.Whole.MemberCacheCounter<tableType, memberCacheType>");
            }
            }
            _code_.Add(@"
            {
                /// <summary>
                /// SQL表格操作工具
                /// </summary>
                protected static readonly AutoCSer.Sql.Table<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = PrimaryKeys;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            }
            _code_.Add(@"> sqlTable = AutoCSer.Sql.Table<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = PrimaryKeys;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            }
            _code_.Add(@">.Get(");
            _code_.Add(IsCreateEventCache ? "true" : "false");
            _code_.Add(@");
                private static bool isSqlLoaded;
                /// <summary>
                /// 等待数据初始化完成
                /// </summary>
                public static void WaitSqlLoaded()
                {
                    if (!isSqlLoaded)
                    {
                        sqlTable/**/.WaitLoad();
                        isSqlLoaded = true;
                    }
                }");
            _if_ = false;
                    if (IsEventCacheLoaded)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                private static bool isEventCacheLoaded;
                /// <summary>
                /// 等待数据事件缓存数据初始化完成
                /// </summary>
                public static void WaitEventCacheLoaded()
                {
                    if (!isEventCacheLoaded)
                    {");
            _if_ = false;
                    if (IsCreateEventCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        sqlTable/**/.WaitCreateCache();");
            }
            _if_ = false;
                if (!(bool)IsCreateEventCache)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        if (");
            _code_.Add(IdentityArrayCacheName);
            _code_.Add(@" == null) throw new NullReferenceException(AutoCSer.Extension.TypeExtension.fullName(typeof(tableType)) + "".");
            _code_.Add(IdentityArrayCacheName);
            _code_.Add(@" is null"");");
            }
            _code_.Add(@"
                        isEventCacheLoaded = true;
                    }
                }");
            }
            _if_ = false;
                    if (IsSqlLoaded)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 数据加载完成
                /// </summary>");
            _if_ = false;
                    if (IsSqlCacheLoaded)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""onInserted"">添加记录事件</param>
                /// <param name=""onUpdated"">更新记录事件</param>
                /// <param name=""onDeleted"">删除记录事件</param>");
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.LogServerName != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""isMemberMap"">是否支持成员位图</param>");
            }
            }
            _code_.Add(@"
                protected static void sqlLoaded(");
            _if_ = false;
                    if (IsSqlCacheLoaded)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"Action<tableType> onInserted = null, Action<");
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsLoadedCache)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"tableType, ");
            }
            _code_.Add(@"tableType, tableType, AutoCSer.Metadata.MemberMap<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">> onUpdated = null, Action<tableType> onDeleted = null");
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.LogServerName != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", bool isMemberMap = true");
            }
            }
            _code_.Add(@")
                {");
            _if_ = false;
                    if (IsSqlCacheLoaded)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.LogServerName != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    sqlStream/**/.Set(");
            _code_.Add(IdentityArrayCacheName);
            _code_.Add(@", isMemberMap);");
            }
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsLoadedCache)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(IdentityArrayCacheName);
            _code_.Add(@"/**/.Loaded(onInserted, onUpdated, onDeleted");
            _if_ = false;
                    if (SqlStreamTypeCount != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", false");
            }
            _code_.Add(@");");
            }
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                if (!(bool)_value1_.IsLoadedCache)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    sqlTable/**/.CacheLoaded(onInserted, onUpdated, onDeleted");
            _if_ = false;
                    if (SqlStreamTypeCount != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", false");
            }
            _code_.Add(@");");
            }
            }
            _if_ = false;
                    if (SqlStreamTypeCount != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    sqlTable/**/.AddLogStreamLoadedType(SqlLogMembers._LoadCount_");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.LogCountType[] _value1_;
                    _value1_ = SqlStreamCountTypes;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.LogCountType _value2_ in _value1_)
                        {
            _code_.Add(@", new AutoCSer.Sql.LogStream.LoadedType(typeof(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.SqlStreamCountType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"), ");
            _code_.Add(_value2_.CountTypeNumber.ToString());
            _code_.Add(@")");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@");");
            }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                if (CacheType.ToString() == @"IdentityArray")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static readonly AutoCSer.Sql.Cache.Whole.Event.IdentityArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType> ");
            _code_.Add(IdentityArrayCacheName);
            _code_.Add(@" = sqlTable == null ? null : new AutoCSer.Sql.Cache.Whole.Event.IdentityArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType>(sqlTable, null);");
            }
            _if_ = false;
                if (CacheType.ToString() == @"IdentityTree")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static readonly AutoCSer.Sql.Cache.Whole.Event.IdentityTree<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType> ");
            _code_.Add(IdentityTreeCacheName);
            _code_.Add(@" = sqlTable == null ? null : new AutoCSer.Sql.Cache.Whole.Event.IdentityTree<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType>(sqlTable, null);");
            }
            _if_ = false;
                if (CacheType.ToString() == @"PrimaryKey")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static readonly AutoCSer.Sql.Cache.Whole.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> ");
            _code_.Add(PrimaryKeyCacheName);
            _code_.Add(@" = sqlTable == null ? null : new AutoCSer.Sql.Cache.Whole.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(sqlTable, null);");
            }
            _if_ = false;
                if (CacheType.ToString() == @"PrimaryKeyArray")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static readonly AutoCSer.Sql.Cache.Whole.Event.PrimaryKeyArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> ");
            _code_.Add(PrimaryKeyArrayCacheName);
            _code_.Add(@" = sqlTable == null ? null : new AutoCSer.Sql.Cache.Whole.Event.PrimaryKeyArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(sqlTable, null);");
            }
            _code_.Add(@"
");
            _if_ = false;
                if (CacheType.ToString() == @"CreateIdentityArray")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType> ");
            _code_.Add(CreateIdentityArrayMemberCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <typeparam name=""memberCacheType""></typeparam>
                /// <param name=""memberCache"">成员缓存</param>
                /// <param name=""group"">数据分组</param>
                /// <param name=""baseIdentity"">基础ID</param>
                /// <param name=""isReset"">是否初始化事件与数据</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType> createCache(System.Linq.Expressions.Expression<Func<tableType, memberCacheType>> memberCache, int group = 0, int baseIdentity = 0, bool isReset = true)
                {
                    if (sqlTable == null) return null;
                    ");
            _code_.Add(CreateIdentityArrayMemberCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Whole.Event.IdentityArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType>(sqlTable, memberCache, group, baseIdentity, isReset);
                    sqlTable/**/.CacheCreated();");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    NowTimes.Load(");
            _code_.Add(CreateIdentityArrayMemberCacheName);
            _code_.Add(@"/**/.Values);");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.CountMember[] _value1_ = CounterMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    createCounter(");
            _code_.Add(CreateIdentityArrayMemberCacheName);
            _code_.Add(@");");
            }
            _code_.Add(@"
                    return ");
            _code_.Add(CreateIdentityArrayMemberCacheName);
            _code_.Add(@";
                }");
            }
            _if_ = false;
                if (!(bool)IsMemberCache)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType> ");
            _code_.Add(CreateIdentityArrayCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <param name=""baseIdentity"">基础ID</param>
                /// <param name=""group"">数据分组</param>
                /// <param name=""isReset"">是否初始化事件与数据</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType> createCache(int group = 0, int baseIdentity = 0, bool isReset = true)
                {
                    if (sqlTable == null) return null;
                    ");
            _code_.Add(CreateIdentityArrayCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Whole.Event.IdentityArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType>(sqlTable, null, group, baseIdentity, isReset);
                    sqlTable/**/.CacheCreated();");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    NowTimes.Load(");
            _code_.Add(CreateIdentityArrayCacheName);
            _code_.Add(@"/**/.Values);");
            }
            _code_.Add(@"
                    return ");
            _code_.Add(CreateIdentityArrayCacheName);
            _code_.Add(@";
                }");
            }
            }
            _if_ = false;
                if (CacheType.ToString() == @"CreateIdentityArrayWhere")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <param name=""memberCache"">成员缓存</param>
                /// <param name=""group"">数据分组</param>
                /// <param name=""baseIdentity"">基础ID</param>
                /// <param name=""isReset"">是否初始化事件与数据</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityArrayWhere<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType> createCache(System.Linq.Expressions.Expression<Func<tableType, memberCacheType>> memberCache, Func<tableType, bool> isValue, int group = 0, int baseIdentity = 0)
                {
                    if (sqlTable == null) return null;
                    return new AutoCSer.Sql.Cache.Whole.Event.IdentityArrayWhere<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType>(sqlTable, memberCache, isValue, group, baseIdentity);
                }");
            }
            _if_ = false;
                if (!(bool)IsMemberCache)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <param name=""isValue"">数据匹配器,必须保证更新数据的匹配一致性</param>
                /// <param name=""baseIdentity"">基础ID</param>
                /// <param name=""group"">数据分组</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityArrayWhere<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType> createCache(Func<tableType, bool> isValue, int group = 0, int baseIdentity = 0)
                {
                    if (sqlTable == null) return null;
                    return new AutoCSer.Sql.Cache.Whole.Event.IdentityArrayWhere<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType>(sqlTable, null, isValue, group, baseIdentity);
                }");
            }
            }
            _if_ = false;
                if (CacheType.ToString() == @"CreateIdentityArrayWhereExpression")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <param name=""memberCache"">成员缓存</param>
                /// <param name=""group"">数据分组</param>
                /// <param name=""baseIdentity"">基础ID</param>
                /// <param name=""isReset"">是否初始化事件与数据</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityArrayWhereExpression<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType> createCache(System.Linq.Expressions.Expression<Func<tableType, memberCacheType>> memberCache, System.Linq.Expressions.Expression<Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", bool>> isValue, int group = 0, int baseIdentity = 0)
                {
                    if (sqlTable == null) return null;
                    return new AutoCSer.Sql.Cache.Whole.Event.IdentityArrayWhereExpression<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType>(sqlTable, memberCache, isValue, group, baseIdentity);
                }");
            }
            _if_ = false;
                if (!(bool)IsMemberCache)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <param name=""isValue"">数据匹配器,必须保证更新数据的匹配一致性</param>
                /// <param name=""baseIdentity"">基础ID</param>
                /// <param name=""group"">数据分组</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityArrayWhereExpression<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType> createCache(System.Linq.Expressions.Expression<Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", bool>> isValue, int group = 0, int baseIdentity = 0)
                {
                    if (sqlTable == null) return null;
                    return new AutoCSer.Sql.Cache.Whole.Event.IdentityArrayWhereExpression<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType>(sqlTable, null, isValue, group, baseIdentity);
                }");
            }
            }
            _if_ = false;
                if (CacheType.ToString() == @"CreateIdentityTree")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityTree<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType> ");
            _code_.Add(CreateIdentityTreeMemberCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <param name=""memberCache"">成员缓存</param>
                /// <param name=""group"">数据分组</param>
                /// <param name=""baseIdentity"">基础ID</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityTree<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType> createCache(System.Linq.Expressions.Expression<Func<tableType, memberCacheType>> memberCache, int group = 0, int baseIdentity = 0)
                {
                    if (sqlTable == null) return null;
                    ");
            _code_.Add(CreateIdentityTreeMemberCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Whole.Event.IdentityTree<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType>(sqlTable, memberCache, group, baseIdentity);
                    sqlTable/**/.CacheCreated();");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    NowTimes.Load(");
            _code_.Add(CreateIdentityTreeMemberCacheName);
            _code_.Add(@"/**/.Values);");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.CountMember[] _value1_ = CounterMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    createCounter(");
            _code_.Add(CreateIdentityTreeMemberCacheName);
            _code_.Add(@");");
            }
            _code_.Add(@"
                    return ");
            _code_.Add(CreateIdentityTreeMemberCacheName);
            _code_.Add(@";
                }");
            }
            _if_ = false;
                if (!(bool)IsMemberCache)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityTree<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType> ");
            _code_.Add(CreateIdentityTreeCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <param name=""group"">数据分组</param>
                /// <param name=""baseIdentity"">基础ID</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.IdentityTree<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType> createCache(int group = 0, int baseIdentity = 0)
                {
                    if (sqlTable == null) return null;
                    ");
            _code_.Add(CreateIdentityTreeCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Whole.Event.IdentityTree<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType>(sqlTable, null, group, baseIdentity);
                    sqlTable/**/.CacheCreated();");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    NowTimes.Load(");
            _code_.Add(CreateIdentityTreeCacheName);
            _code_.Add(@"/**/.Values);");
            }
            _code_.Add(@"
                    return ");
            _code_.Add(CreateIdentityTreeCacheName);
            _code_.Add(@";
                }");
            }
            }
            _if_ = false;
                if (CacheType.ToString() == @"CreatePrimaryKey")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Whole.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> ");
            _code_.Add(CreatePrimaryKeyMemberCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <typeparam name=""memberCacheType""></typeparam>
                /// <param name=""memberCache"">成员缓存</param>
                /// <param name=""group"">数据分组</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> createCache(System.Linq.Expressions.Expression<Func<tableType, memberCacheType>> memberCache, int group = 0)
                {
                    if (sqlTable == null) return null;
                    ");
            _code_.Add(CreatePrimaryKeyMemberCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Whole.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(sqlTable, memberCache, group);
                    sqlTable/**/.CacheCreated();");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    NowTimes.Load(");
            _code_.Add(CreatePrimaryKeyMemberCacheName);
            _code_.Add(@"/**/.Values);");
            }
            _code_.Add(@"
                    return ");
            _code_.Add(CreatePrimaryKeyMemberCacheName);
            _code_.Add(@";
                }");
            }
            _if_ = false;
                if (!(bool)IsMemberCache)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Whole.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> ");
            _code_.Add(CreatePrimaryKeyCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <param name=""group"">数据分组</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> createCache(int group = 0)
                {
                    if (sqlTable == null) return null;
                    ");
            _code_.Add(CreatePrimaryKeyCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Whole.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(sqlTable, null, group);
                    sqlTable/**/.CacheCreated();");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    NowTimes.Load(");
            _code_.Add(CreatePrimaryKeyCacheName);
            _code_.Add(@"/**/.Values);");
            }
            _code_.Add(@"
                    return ");
            _code_.Add(CreatePrimaryKeyCacheName);
            _code_.Add(@";
                }");
            }
            }
            _if_ = false;
                if (CacheType.ToString() == @"CreatePrimaryKeyArray")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Whole.Event.PrimaryKeyArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> ");
            _code_.Add(CreatePrimaryKeyArrayMemberCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <typeparam name=""memberCacheType""></typeparam>
                /// <param name=""memberCache"">成员缓存</param>
                /// <param name=""group"">数据分组</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.PrimaryKeyArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> createCache(System.Linq.Expressions.Expression<Func<tableType, memberCacheType>> memberCache, int group = 0)
                {
                    if (sqlTable == null) return null;
                    ");
            _code_.Add(CreatePrimaryKeyArrayMemberCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Whole.Event.PrimaryKeyArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(sqlTable, memberCache, group);
                    sqlTable/**/.CacheCreated();");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    NowTimes.Load(");
            _code_.Add(CreatePrimaryKeyArrayMemberCacheName);
            _code_.Add(@"/**/.Values);");
            }
            _code_.Add(@"
                    return ");
            _code_.Add(CreatePrimaryKeyArrayMemberCacheName);
            _code_.Add(@";
                }");
            }
            _if_ = false;
                if (!(bool)IsMemberCache)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Whole.Event.PrimaryKeyArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> ");
            _code_.Add(CreatePrimaryKeyArrayCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <param name=""group"">数据分组</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.PrimaryKeyArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> createCache(int group = 0)
                {
                    if (sqlTable == null) return null;
                    ");
            _code_.Add(CreatePrimaryKeyArrayCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Whole.Event.PrimaryKeyArray<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(sqlTable, null, group);
                    sqlTable/**/.CacheCreated();");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    NowTimes.Load(");
            _code_.Add(CreatePrimaryKeyArrayCacheName);
            _code_.Add(@"/**/.Values);");
            }
            _code_.Add(@"
                    return ");
            _code_.Add(CreatePrimaryKeyArrayCacheName);
            _code_.Add(@";
                }");
            }
            }
            _if_ = false;
                if (CacheType.ToString() == @"CreateMemberKey")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Whole.Event.Cache<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType> ");
            _code_.Add(CreateMemberKeyMemberCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <typeparam name=""targetType""></typeparam>
                /// <typeparam name=""targetModelType""></typeparam>
                /// <typeparam name=""targetMemberCacheType""></typeparam>
                /// <typeparam name=""keyType""></typeparam>
                /// <typeparam name=""memberKeyType""></typeparam>
                /// <param name=""targetCache"">目标缓存</param>
                /// <param name=""memberCache"">成员缓存</param>
                /// <param name=""getKey"">键值获取器</param>
                /// <param name=""getMemberKey"">成员缓存键值获取器</param>
                /// <param name=""member"">缓存成员</param>
                /// <param name=""group"">数据分组</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.MemberKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType, keyType, memberKeyType, targetMemberCacheType> createCache<targetType, targetModelType, targetMemberCacheType, keyType, memberKeyType>(AutoCSer.Sql.Cache.Whole.Event.Key<targetType, targetModelType, targetMemberCacheType, keyType> targetCache, System.Linq.Expressions.Expression<Func<tableType, memberCacheType>> memberCache, Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", keyType> getKey, Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberKeyType> getMemberKey, System.Linq.Expressions.Expression<Func<targetMemberCacheType, System.Collections.Generic.Dictionary<AutoCSer.RandomKey<memberKeyType>, tableType>>> member, int group = 0)
                    where keyType : struct, IEquatable<keyType>
                    where memberKeyType : struct, IEquatable<memberKeyType>
                    where targetType : class, targetModelType
                    where targetModelType : class
                    where targetMemberCacheType : class
                {
                    if (sqlTable == null) return null;
                    AutoCSer.Sql.Cache.Whole.Event.MemberKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType, keyType, memberKeyType, targetMemberCacheType> cache = new AutoCSer.Sql.Cache.Whole.Event.MemberKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType, keyType, memberKeyType, targetMemberCacheType>(sqlTable, memberCache, getKey, getMemberKey, targetCache.GetMemberCacheByKey, member, targetCache.GetAllMemberCache, group);
                    ");
            _code_.Add(CreateMemberKeyMemberCacheName);
            _code_.Add(@" = cache;
                    sqlTable/**/.CacheCreated();");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    NowTimes.Load(cache.Values);");
            }
            _code_.Add(@"
                    return cache;
                }");
            }
            _if_ = false;
                if (!(bool)IsMemberCache)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Whole.Event.Cache<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType> ");
            _code_.Add(CreateMemberKeyCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认缓存
                /// </summary>
                /// <typeparam name=""targetType""></typeparam>
                /// <typeparam name=""targetModelType""></typeparam>
                /// <typeparam name=""targetMemberCacheType""></typeparam>
                /// <typeparam name=""keyType""></typeparam>
                /// <typeparam name=""memberKeyType""></typeparam>
                /// <param name=""targetCache"">目标缓存</param>
                /// <param name=""memberCache"">成员缓存</param>
                /// <param name=""getKey"">键值获取器</param>
                /// <param name=""getMemberKey"">成员缓存键值获取器</param>
                /// <param name=""member"">缓存成员</param>
                /// <param name=""group"">数据分组</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Whole.Event.MemberKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, keyType, memberKeyType, targetMemberCacheType> createCache<targetType, targetModelType, targetMemberCacheType, keyType, memberKeyType>(AutoCSer.Sql.Cache.Whole.Event.Key<targetType, targetModelType, targetMemberCacheType, keyType> targetCache, Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", keyType> getKey, Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberKeyType> getMemberKey, System.Linq.Expressions.Expression<Func<targetMemberCacheType, System.Collections.Generic.Dictionary<AutoCSer.RandomKey<memberKeyType>, tableType>>> member, int group = 0)
                    where keyType : struct, IEquatable<keyType>
                    where memberKeyType : struct, IEquatable<memberKeyType>
                    where targetType : class, targetModelType
                    where targetModelType : class
                    where targetMemberCacheType : class
                {
                    if (sqlTable == null) return null;
                    AutoCSer.Sql.Cache.Whole.Event.MemberKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, keyType, memberKeyType, targetMemberCacheType> cache = new AutoCSer.Sql.Cache.Whole.Event.MemberKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", tableType, keyType, memberKeyType, targetMemberCacheType>(sqlTable, null, getKey, getMemberKey, targetCache.GetMemberCacheByKey, member, targetCache.GetAllMemberCache, group);
                    ");
            _code_.Add(CreateMemberKeyCacheName);
            _code_.Add(@" = cache;
                    sqlTable/**/.CacheCreated();");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    NowTimes.Load(cache.Values);");
            }
            _code_.Add(@"
                    return cache;
                }");
            }
            }
            _code_.Add(@"
");
            _if_ = false;
                if (CounterCacheType.ToString() == @"IdentityCounter")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认计数缓存
                /// </summary>");
            _if_ = false;
                    if (IsIdentity64)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                protected static readonly AutoCSer.Sql.Cache.Counter.Event.Identity64<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"> ");
            _code_.Add(IdentityCounterCacheName);
            _code_.Add(@" = sqlTable == null ? null : new AutoCSer.Sql.Cache.Counter.Event.Identity64<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">(sqlTable, 1);");
            }
            _if_ = false;
                if (!(bool)IsIdentity64)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                protected static readonly AutoCSer.Sql.Cache.Counter.Event.Identity<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"> ");
            _code_.Add(IdentityCounter32CacheName);
            _code_.Add(@" = sqlTable == null ? null : new AutoCSer.Sql.Cache.Counter.Event.Identity<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">(sqlTable, 1);");
            }
            }
            _if_ = false;
                if (CounterCacheType.ToString() == @"PrimaryKeyCounter")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认计数缓存
                /// </summary>
                protected static readonly AutoCSer.Sql.Cache.Counter.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> ");
            _code_.Add(PrimaryKeyCounterCacheName);
            _code_.Add(@" = sqlTable == null ? null : new AutoCSer.Sql.Cache.Counter.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(sqlTable, 1);");
            }
            _code_.Add(@"
");
            _if_ = false;
                if (CounterCacheType.ToString() == @"CreateIdentityCounterMemberQueue")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认计数缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Counter.Event.MemberIdentity<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType> ");
            _code_.Add(CreateIdentityCounterMemberQueueCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认先进先出优先队列缓存
                /// </summary>
                /// <param name=""cache"">自增ID整表缓存</param>
                /// <param name=""group"">数据分组</param>
                /// <param name=""maxCount"">缓存默认最大容器大小</param>
                /// <returns></returns>
                protected static AutoCSer.Sql.Cache.Counter.MemberQueue<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType, int> createCounterMemberQueue(AutoCSer.Sql.Cache.Whole.Event.IdentityMemberMap<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType> cache, int group = 1, int maxCount = 0)
                {
                    ");
            _code_.Add(CreateIdentityCounterMemberQueueCacheName);
            _code_.Add(@" = cache.CreateCounter(value => value.Counter, group);
                    return ");
            _code_.Add(CreateIdentityCounterMemberQueueCacheName);
            _code_.Add(@"/**/.CreateMemberQueue(value => value.NodeValue, value => value.PreviousNode, value => value.NextNode, maxCount);
                }");
            }
            _if_ = false;
                if (CounterCacheType.ToString() == @"CreateIdentityCounterQueue")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认计数缓存
                /// </summary>");
            _if_ = false;
                    if (IsIdentity64)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                protected static AutoCSer.Sql.Cache.Counter.Event.Identity64<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"> ");
            _code_.Add(CreateIdentityCounterQueueCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认先进先出优先队列缓存
                /// </summary>
                /// <param name=""group"">数据分组</param>
                /// <param name=""maxCount"">缓存默认最大容器大小</param>
                /// <returns>数据分组</returns>
                protected static AutoCSer.Sql.Cache.Counter.Queue<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", long> createIdentityCounterQueue(int group = 1, int maxCount = 0)
                {
                    return new AutoCSer.Sql.Cache.Counter.Queue<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", long>(");
            _code_.Add(CreateIdentityCounterQueueCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Counter.Event.Identity64<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">(sqlTable, group), sqlTable/**/.Get, maxCount);
                }");
            }
            _if_ = false;
                if (!(bool)IsIdentity64)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                protected static AutoCSer.Sql.Cache.Counter.Event.Identity<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"> ");
            _code_.Add(CreateIdentityCounter32QueueCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认先进先出优先队列缓存
                /// </summary>
                /// <param name=""group"">数据分组</param>
                /// <param name=""maxCount"">缓存默认最大容器大小</param>
                /// <returns>数据分组</returns>
                protected static AutoCSer.Sql.Cache.Counter.Queue<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", int> ");
            _code_.Add(CreateIdentityCounterQueueMethodName);
            _code_.Add(@"(int group = 1, int maxCount = 0)
                {
                    return new AutoCSer.Sql.Cache.Counter.Queue<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", int>(");
            _code_.Add(CreateIdentityCounter32QueueCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Counter.Event.Identity<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">(sqlTable, group), sqlTable/**/.Get, maxCount);
                }");
            }
            }
            _if_ = false;
                if (CounterCacheType.ToString() == @"CreateIdentityCounterQueueList")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认计数缓存
                /// </summary>");
            _if_ = false;
                    if (IsIdentity64)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                protected static AutoCSer.Sql.Cache.Counter.Event.Identity64<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"> ");
            _code_.Add(CreateIdentityCounterQueueListCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认先进先出优先队列缓存
                /// </summary>
                /// <param name=""group"">数据分组</param>
                /// <param name=""maxCount"">缓存默认最大容器大小</param>
                /// <returns>数据分组</returns>
                protected static AutoCSer.Sql.Cache.Counter.QueueList<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", long, keyType> createIdentityCounterQueueList<keyType>(System.Linq.Expressions.Expression<Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", keyType>> getKey, Func<keyType, System.Linq.Expressions.Expression<Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", bool>>> getWhere, int group = 0, int maxCount = 0)
                    where keyType : IEquatable<keyType>
                {
                    return new AutoCSer.Sql.Cache.Counter.QueueList<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", long, keyType>(");
            _code_.Add(CreateIdentityCounterQueueListCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Counter.Event.Identity64<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">(sqlTable, group), getKey, getWhere, maxCount);
                }");
            }
            _if_ = false;
                if (!(bool)IsIdentity64)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                protected static AutoCSer.Sql.Cache.Counter.Event.Identity<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"> ");
            _code_.Add(CreateIdentityCounter32QueueListCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认先进先出优先队列缓存
                /// </summary>
                /// <param name=""group"">数据分组</param>
                /// <param name=""maxCount"">缓存默认最大容器大小</param>
                /// <returns>数据分组</returns>
                protected static AutoCSer.Sql.Cache.Counter.QueueList<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", int, keyType> ");
            _code_.Add(CreateIdentityCounterQueueListMethodName);
            _code_.Add(@"<keyType>(System.Linq.Expressions.Expression<Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", keyType>> getKey, Func<keyType, System.Linq.Expressions.Expression<Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", bool>>> getWhere, int group = 0, int maxCount = 0)
                    where keyType : IEquatable<keyType>
                {
                    return new AutoCSer.Sql.Cache.Counter.QueueList<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", int, keyType>(");
            _code_.Add(CreateIdentityCounter32QueueCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Counter.Event.Identity<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">(sqlTable, group), getKey, getWhere, maxCount);
                }");
            }
            }
            _if_ = false;
                if (CounterCacheType.ToString() == @"CreatePrimaryKeyCounterQueue")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认计数缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Counter.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> ");
            _code_.Add(CreatePrimaryKeyCounterQueueCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认先进先出优先队列缓存
                /// </summary>
                /// <param name=""group"">数据分组</param>
                /// <param name=""maxCount"">缓存默认最大容器大小</param>
                /// <returns>数据分组</returns>
                protected static AutoCSer.Sql.Cache.Counter.Queue<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> createPrimaryKeyCounterQueue(int group = 1, int maxCount = 0)
                {
                    return new AutoCSer.Sql.Cache.Counter.Queue<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(");
            _code_.Add(CreatePrimaryKeyCounterQueueCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Counter.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(sqlTable, group), sqlTable/**/.GetByPrimaryKey, maxCount);
                }");
            }
            _if_ = false;
                if (CounterCacheType.ToString() == @"CreatePrimaryKeyCounterQueueList")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认计数缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Counter.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> ");
            _code_.Add(CreatePrimaryKeyCounterQueueListCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认先进先出优先队列缓存
                /// </summary>
                /// <param name=""getKey"">缓存关键字获取器</param>
                /// <param name=""getWhere"">条件表达式获取器</param>
                /// <param name=""group"">数据分组</param>
                /// <param name=""maxCount"">缓存默认最大容器大小</param>
                /// <returns>数据分组</returns>
                protected static AutoCSer.Sql.Cache.Counter.QueueList<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@", keyType> createPrimaryKeyCounterQueueList<keyType>(System.Linq.Expressions.Expression<Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", keyType>> getKey, Func<keyType, System.Linq.Expressions.Expression<Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", bool>>> getWhere, int group = 1, int maxCount = 0)
                    where keyType : IEquatable<keyType>
                {
                    return new AutoCSer.Sql.Cache.Counter.QueueList<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@", keyType>(");
            _code_.Add(CreatePrimaryKeyCounterQueueListCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Counter.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(sqlTable, group), getKey, getWhere, maxCount);
                }");
            }
            _if_ = false;
                if (CounterCacheType.ToString() == @"CreatePrimaryKeyCounterQueueDictionary")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// SQL默认计数缓存
                /// </summary>
                protected static AutoCSer.Sql.Cache.Counter.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@"> ");
            _code_.Add(CreatePrimaryKeyCounterQueueDictionaryCacheName);
            _code_.Add(@";
                /// <summary>
                /// 创建SQL默认先进先出优先队列缓存
                /// </summary>
                /// <param name=""getKey"">缓存关键字获取器</param>
                /// <param name=""getWhere"">条件表达式获取器</param>
                /// <param name=""getDictionaryKey"">缓存字典关键字获取器</param>
                /// <param name=""group"">数据分组</param>
                /// <param name=""maxCount"">缓存默认最大容器大小</param>
                /// <returns>数据分组</returns>
                protected static AutoCSer.Sql.Cache.Counter.QueueDictionary<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@", keyType, dictionaryKeyType> createPrimaryKeyCounterQueueDictionary<keyType, dictionaryKeyType>(System.Linq.Expressions.Expression<Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", keyType>> getKey, Func<keyType, System.Linq.Expressions.Expression<Func<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", bool>>> getWhere, Func<tableType, dictionaryKeyType> getDictionaryKey, int group = 1, int maxCount = 0)
                    where keyType : IEquatable<keyType>
                    where dictionaryKeyType : IEquatable<dictionaryKeyType>
                {
                    return new AutoCSer.Sql.Cache.Counter.QueueDictionary<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@", keyType, dictionaryKeyType>(");
            _code_.Add(CreatePrimaryKeyCounterQueueDictionaryCacheName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Counter.Event.PrimaryKey<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", ");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@">(sqlTable, group), getKey, getWhere, getDictionaryKey, maxCount);
                }");
            }
            _code_.Add(@"
");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = IndexMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 成员索引定义
                /// </summary>
                protected static class MemberIndexs
                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = IndexMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
                {
                    System.Reflection.MemberInfo _value3_ = default(System.Reflection.MemberInfo);
                    _value3_ = _value2_.Member;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    /// <summary>
                    /// ");
            _code_.Add(_value2_.XmlDocument);
            _code_.Add(@" (成员索引)
                    /// </summary>");
            }
            _code_.Add(@"
                    public static readonly AutoCSer.Metadata.MemberMap<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = Type;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.FullName);
                    }
                }
            _code_.Add(@">.MemberIndex ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@" = AutoCSer.Metadata.MemberMap<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = Type;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.FullName);
                    }
                }
            _code_.Add(@">.MemberIndex.Create(value => value.");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@");");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.LogServerName != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                [AutoCSer.Metadata.Ignore]
                tableType AutoCSer.Sql.LogStream.IMemberMapValueLink<tableType>.MemberMapValueLink { get; set; }
                private readonly static AutoCSer.Sql.LogStream.Log<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"> sqlStream = sqlTable == null ? null : new AutoCSer.Sql.LogStream.Log<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">(sqlTable");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.LogMember[] _value1_;
                    _value1_ = LogMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.LogMember _value2_ in _value1_)
                        {
            _if_ = false;
                    if (_value2_.IsSqlStreamCount)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value3_ = _value2_.Member;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(_value3_.MemberIndex.ToString());
            }
                }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@");
                /// <summary>
                /// 日志处理
                /// </summary>
                /// <param name=""onLog""></param>
                [AutoCSer.Net.TcpStaticServer.KeepCallbackMethod(");
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                if (!(bool)_value1_.IsLogSerializeReferenceMember)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"ParameterFlags = AutoCSer.Net.TcpServer.ParameterFlags.OutputSerializeBox, ");
            }
            _code_.Add(@"ServerName = """);
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.LogServerName);
                    }
                }
            _code_.Add(@""")]
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                protected static void onSqlLog(Func<AutoCSer.Net.TcpServer.ReturnValue<AutoCSer.Sql.LogStream.Log<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">.Data>, bool> onLog)
                {
                    sqlStream/**/.Add(onLog);
                }");
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsLogClientGetCache)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                    if (Identity != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value1_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value1_ = Identity;
            _if_ = false;
                    if (_value1_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 获取数据
                /// </summary>
                /// <param name=""");
            _code_.Add(_value1_.MemberName);
            _code_.Add(@""">");
            _code_.Add(_value1_.XmlDocument);
            _code_.Add(@"</param>
                /// <returns></returns>
                [AutoCSer.Net.TcpStaticServer.Method(");
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value2_ = Attribute;
                    if (_value2_ != null)
                    {
                if (!(bool)_value2_.IsLogSerializeReferenceMember)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"ParameterFlags = AutoCSer.Net.TcpServer.ParameterFlags.OutputSerializeBox, ");
            }
            _code_.Add(@"ServerTask = AutoCSer.Net.TcpServer.ServerTaskType.Synchronous, ServerName = """);
                {
                    AutoCSer.Sql.ModelAttribute _value2_ = Attribute;
                    if (_value2_ != null)
                    {
            _code_.Add(_value2_.LogServerName);
                    }
                }
            _code_.Add(@""")]
                protected static tableType getSqlCache(int ");
            _code_.Add(_value1_.MemberName);
            _code_.Add(@")
                {
                    return ");
            _code_.Add(IdentityArrayCacheName);
            _code_.Add(@"[");
            _code_.Add(_value1_.MemberName);
            _code_.Add(@"];
                }");
            }
                }
            }
            _if_ = false;
                if (Identity == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (CacheType.ToString() != @"CreateMemberKey")
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 获取数据
                /// </summary>
                /// <param name=""key"">关键字</param>
                /// <returns></returns>
                [AutoCSer.Net.TcpStaticServer.Method(");
            _if_ = false;
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                if (!(bool)_value1_.IsLogSerializeReferenceMember)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"ParameterFlags = AutoCSer.Net.TcpServer.ParameterFlags.OutputSerializeBox, ");
            }
            _code_.Add(@"ServerTask = AutoCSer.Net.TcpServer.ServerTaskType.Synchronous, ServerName = """);
                {
                    AutoCSer.Sql.ModelAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.LogServerName);
                    }
                }
            _code_.Add(@""")]
                protected static tableType getSqlCache(");
            _code_.Add(PrimaryKeyType);
            _code_.Add(@" key)
                {
                    return ");
            _code_.Add(PrimaryKeyCacheName);
            _code_.Add(@"[key];
                }");
            }
            }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.LogMember[] _value1_ = LogMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 计算字段日志流
                /// </summary>
                [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
                public struct SqlLogMembers
                {
                    /// <summary>
                    /// 数据对象
                    /// </summary>
                    internal SqlModel<tableType");
            _if_ = false;
                    if (IsMemberCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", memberCacheType");
            }
            _code_.Add(@"> _value_;");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.LogMember[] _value1_;
                    _value1_ = LogMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.LogMember _value2_ in _value1_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value3_ = _value2_.Member;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    private static readonly AutoCSer.Metadata.MemberMap<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = Type;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.FullName);
                    }
                }
            _code_.Add(@"> ");
            _code_.Add(_value2_.MemberMapName);
            _code_.Add(@" = sqlStream/**/.CreateMemberMap(value => value.");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@");");
            _if_ = false;
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    /// <summary>
                    /// ");
            _code_.Add(_value3_.XmlDocument);
            _code_.Add(@" (更新日志流)
                    /// </summary>
                    /// <param name=""value""></param>");
            }
            _code_.Add(@"
                    [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                    public void ");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = _value3_.MemberType;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.FullName);
                    }
                }
            _code_.Add(@" value)
                    {");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = _value3_.MemberType;
                    if (_value4_ != null)
                    {
                    if (_value4_.IsIEquatable)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        if (!value.Equals(_value_.");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@"))");
            }
            _code_.Add(@"
                        {
                            _value_.");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@" = value;
                            ");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@"();
                        }
                    }");
            _if_ = false;
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    /// <summary>
                    /// ");
            _code_.Add(_value3_.XmlDocument);
            _code_.Add(@" (更新日志流)
                    /// </summary>");
            }
            _code_.Add(@"
                    [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                    public void ");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@"()
                    {
                        sqlStream/**/.Update((tableType)_value_, ");
            _code_.Add(_value2_.MemberMapName);
            _code_.Add(@");
                    }");
            _if_ = false;
                    if (_value2_.IsSqlStreamCount)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.SqlStreamCountType == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    /// <summary>
                    /// ");
            _code_.Add(_value3_.XmlDocument);
            _code_.Add(@" 计算初始化完毕
                    /// </summary>
                    public static void ");
            _code_.Add(_value2_.MemberLoadedMethodName);
            _code_.Add(@"() { sqlStream/**/.LoadMember(");
            _code_.Add(_value3_.MemberIndex.ToString());
            _code_.Add(@"); }");
            }
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _if_ = false;
                    if (SqlStreamTypeCount != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    /// <summary>
                    /// 根据日志流计数完成类型初始化完毕
                    /// </summary>
                    /// <param name=""type""></param>
                    internal static void _LoadCount_(AutoCSer.Sql.LogStream.LoadedType type)
                    {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.LogMember[] _value1_;
                    _value1_ = LogMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.LogMember _value2_ in _value1_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value3_ = _value2_.Member;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.SqlStreamCountType != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        if (type.Equals(typeof(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = _value2_.SqlStreamCountType;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.FullName);
                    }
                }
            _code_.Add(@"), ");
            _code_.Add(_value2_.CountTypeNumber.ToString());
            _code_.Add(@")) sqlStream/**/.LoadMember(");
            _code_.Add(_value3_.MemberIndex.ToString());
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    }");
            }
            _code_.Add(@"
                }
                /// <summary>
                /// 计算字段日志流
                /// </summary>
                [AutoCSer.Metadata.Ignore]
                public SqlLogMembers ");
            _code_.Add(LogMemberName);
            _code_.Add(@"
                {
                    get { return new SqlLogMembers { _value_ = this }; }
                }");
            }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 当前时间定义
                /// </summary>
                protected static class NowTimes
                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _if_ = false;
                    if (_value2_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    /// <summary>
                    /// ");
            _code_.Add(_value2_.XmlDocument);
            _code_.Add(@" 当前时间
                    /// </summary>");
            }
            _code_.Add(@"
                    public static readonly AutoCSer.Sql.NowTime ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@" = sqlTable == null ? null : new AutoCSer.Sql.NowTime(sqlTable.NowTimeMilliseconds);");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    /// <summary>
                    /// 初始化当前时间
                    /// </summary>
                    /// <param name=""values"">缓存数据</param>
                    public static void Load(System.Collections.Generic.IEnumerable<tableType> values)
                    {
                        foreach (tableType value in values)
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@"/**/.SetMaxTime(");
                {
                    System.Reflection.MemberInfo _value3_ = default(System.Reflection.MemberInfo);
                    _value3_ = _value2_.Member;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"value.");
            _code_.Add(_value2_.MemberName);
            }
                }
            _code_.Add(@");");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                        }");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = NowTimeMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _code_.Add(@"
                        ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@"/**/.SetMaxTime();");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    }
                }");
            _if_ = false;
                    if (IsLoadNowTimeCache)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                static SqlModel()
                {
                    if (");
            _code_.Add(IdentityArrayCacheName);
            _code_.Add(@" != null) NowTimes.Load(");
            _code_.Add(IdentityArrayCacheName);
            _code_.Add(@"/**/.Values);
                }");
            }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.CountMember[] _value1_ = CounterMembers;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 计数成员
                /// </summary>
                protected static class SqlCounter
                {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.CountMember[] _value1_;
                    _value1_ = CounterMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.CountMember _value2_ in _value1_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value3_ = _value2_.Member;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    /// <summary>
                    /// ");
            _code_.Add(_value3_.XmlDocument);
            _code_.Add(@" 当前时间
                    /// </summary>");
            }
            _code_.Add(@"
                    public static AutoCSer.Sql.Cache.Whole.CountMember ");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@" = AutoCSer.Sql.Cache.Whole.CountMember.Null;");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.CountMember[] _value1_;
                    _value1_ = CounterMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.CountMember _value2_ in _value1_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value3_ = _value2_.Member;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.Sql.CountAttribute _value4_ = _value2_.Attribute;
                    if (_value4_ != null)
                    {
                    if (_value4_.ReadServerName != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// 获取 ");
            _code_.Add(_value3_.XmlDocument);
            _code_.Add(@"
                /// </summary>");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value4_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value4_ = Identity;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value4_.MemberName);
            _code_.Add(@""">");
            _code_.Add(_value4_.XmlDocument);
            _code_.Add(@"</param>");
            }
                }
            _code_.Add(@"
                /// <returns>");
            _code_.Add(_value3_.XmlDocument);
            _code_.Add(@"</returns>
                [AutoCSer.Net.TcpStaticServer.Method(ParameterFlags = AutoCSer.Net.TcpServer.ParameterFlags.OutputSerializeBox, ServerTask = AutoCSer.Net.TcpServer.ServerTaskType.Synchronous, ServerName = """);
                {
                    AutoCSer.Sql.CountAttribute _value4_ = _value2_.Attribute;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.ReadServerName);
                    }
                }
            _code_.Add(@""")]
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                protected static int ");
            _code_.Add(_value2_.GetMethodName);
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value4_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value4_ = Identity;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.MemberType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value4_.MemberName);
            }
                }
            _code_.Add(@")
                {
                    return SqlCounter.");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@"/**/.Get(");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value4_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value4_ = Identity;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value4_.MemberName);
            }
                }
            _code_.Add(@");
                }");
            _if_ = false;
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
            _code_.Add(_value3_.XmlDocument);
            _code_.Add(@" 总计数
                /// </summary>");
            }
            _code_.Add(@"
                [AutoCSer.Net.TcpStaticServer.Method(ParameterFlags = AutoCSer.Net.TcpServer.ParameterFlags.OutputSerializeBox, ServerTask = AutoCSer.Net.TcpServer.ServerTaskType.Synchronous, ServerName = """);
                {
                    AutoCSer.Sql.CountAttribute _value4_ = _value2_.Attribute;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.ReadServerName);
                    }
                }
            _code_.Add(@""")]
                protected static long ");
            _code_.Add(_value2_.TotalMemberName);
            _code_.Add(@"
                {
                    get { return SqlCounter.");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@"/**/.TotalCount; }
                }");
            }
            _if_ = false;
                {
                    AutoCSer.Sql.CountAttribute _value4_ = _value2_.Attribute;
                    if (_value4_ != null)
                    {
                    if (_value4_.WriteServerName != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
            _code_.Add(_value3_.XmlDocument);
            _code_.Add(@" 增加计数
                /// </summary>");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value4_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value4_ = Identity;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value4_.MemberName);
            _code_.Add(@""">");
            _code_.Add(_value4_.XmlDocument);
            _code_.Add(@"</param>");
            }
                }
            _code_.Add(@"
                [AutoCSer.Net.TcpStaticServer.Method(ParameterFlags = AutoCSer.Net.TcpServer.ParameterFlags.OutputSerializeBox, ClientTask = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous, IsClientAsynchronous = true, IsClientSynchronous = false, ServerName = """);
                {
                    AutoCSer.Sql.CountAttribute _value4_ = _value2_.Attribute;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.WriteServerName);
                    }
                }
            _code_.Add(@""")]
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                protected static void ");
            _code_.Add(_value2_.IncMethodName);
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value4_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value4_ = Identity;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.MemberType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value4_.MemberName);
            }
                }
            _code_.Add(@")
                {
                    SqlCounter.");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@"/**/.Inc(");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value4_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value4_ = Identity;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value4_.MemberName);
            }
                }
            _code_.Add(@");
                }");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                /// <summary>
                /// 初始化计数成员
                /// </summary>
                /// <param name=""cache""></param>
                protected static void createCounter(AutoCSer.Sql.Cache.Whole.Event.IdentityCache<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType> cache)
                {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.CountMember[] _value1_;
                    _value1_ = CounterMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.CountMember _value2_ in _value1_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MemberIndex);
                    _value3_ = _value2_.Member;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    SqlCounter.");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@" = new AutoCSer.Sql.Cache.Whole.CountMember<tableType, ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = Type;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.FullName);
                    }
                }
            _code_.Add(@", memberCacheType>(cache, value => value.");
            _code_.Add(_value3_.MemberName);
            _code_.Add(@", ");
                {
                    AutoCSer.Sql.CountAttribute _value4_ = default(AutoCSer.Sql.CountAttribute);
                    _value4_ = _value2_.Attribute;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value4_.Timeout.ToString());
            }
                }
            _code_.Add(@");");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                }");
            }
                {
                    AutoCSer.LeftArray<AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.WebPathType> _value1_;
                    _value1_ = WebPaths;
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _getCount_(_value1_);
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.SqlModel.Generator.WebPathType _value2_ in _value1_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MemberType;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MemberType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
            _code_.Add(@"
                [AutoCSer.Metadata.Ignore]
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MemberType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.PathMemberName);
            _code_.Add(@"
                {
                    get { return new ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MemberType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" { ");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value3_;
                    _value3_ = _value2_.Members;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value4_ in _value3_)
                        {
            _code_.Add(_value4_.MemberName);
            _code_.Add(@" = ");
            _code_.Add(_value4_.MemberName);
            _if_ = false;
                    if (_value4_.MemberIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@" }; }
                }");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
            }
        }");
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
#endif
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal partial class TcpInternalServer
    {
    internal partial class Generator
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.CSharp, _isOut_))
            {
                
            _code_.Add(@"
        ");
            _code_.Add(TypeNameDefinition);
            _if_ = false;
                    if (IsSetTcpServer)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (IsServerCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
#if NOJIT
#else
             : AutoCSer.Net.TcpServer.ISetTcpServer<AutoCSer.Net.TcpInternalServer.Server, AutoCSer.Net.TcpInternalServer.ServerAttribute>
#endif");
            }
            }
            _code_.Add(@"
        {");
            _if_ = false;
                    if (IsServerCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.Net.TcpInternalServer.ServerAttribute _value1_ = ServiceAttribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsRememberCommand)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
            /// <summary>
            /// 命令序号记忆数据
            /// </summary>
            private static KeyValue<string, int>[] ");
            _code_.Add(RememberIdentityCommeandName);
            _code_.Add(@"()
            {
                KeyValue<string, int>[] names = new KeyValue<string, int>[");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.Length.ToString());
                    }
                }
            _code_.Add(@"];");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                names[");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@"].Set(@""");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.MethodKeyName);
                    }
                }
            _code_.Add(@""", ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@");");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                return names;
            }");
            }
            }
            _code_.Add(@"
            /// <summary>
            /// ");
            _code_.Add(ServerRegisterName);
            _code_.Add(@" TCP服务");
            _if_ = false;
                if (!(bool)IsServerCode)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"参数");
            }
            _code_.Add(@"
            /// </summary>
            public sealed class TcpInternalServer");
            _if_ = false;
                    if (IsServerCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" : AutoCSer.Net.TcpInternalServer.Server");
            }
            _code_.Add(@"
            {");
            _if_ = false;
                    if (IsServerCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public readonly ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@" Value;
                /// <summary>
                /// ");
            _code_.Add(ServerRegisterName);
            _code_.Add(@" TCP调用服务端
                /// </summary>
                /// <param name=""attribute"">TCP 调用服务器端配置信息</param>
                /// <param name=""verify"">套接字验证委托</param>");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                {
                    System.Type _value2_ = _value1_.Type;
                    if (_value2_ != null)
                    {
                    if (_value2_.IsPublic)
                    {
                        _if_ = true;
                    }
                }
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""value"">TCP 服务目标对象</param>");
            }
            _code_.Add(@"
                /// <param name=""log"">日志接口</param>
                /// <param name=""onCustomData"">自定义数据包处理</param>
                public TcpInternalServer(AutoCSer.Net.TcpInternalServer.ServerAttribute attribute = null, Func<System.Net.Sockets.Socket, bool> verify = null");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                {
                    System.Type _value2_ = _value1_.Type;
                    if (_value2_ != null)
                    {
                    if (_value2_.IsPublic)
                    {
                        _if_ = true;
                    }
                }
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@" value = null");
            }
            _code_.Add(@", Action<SubArray<byte>> onCustomData = null, AutoCSer.Log.ILog log = null)
                    : base(attribute ?? (attribute = AutoCSer.Net.TcpInternalServer.ServerAttribute.GetConfig(""");
            _code_.Add(ServerRegisterName);
            _code_.Add(@""", typeof(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"))), verify, onCustomData, log, ");
            _code_.Add(IsCallQueue ? "true" : "false");
            _code_.Add(@")
                {
                    Value =");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                {
                    System.Type _value2_ = _value1_.Type;
                    if (_value2_ != null)
                    {
                    if (_value2_.IsPublic)
                    {
                        _if_ = true;
                    }
                }
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@" value ?? ");
            }
            _code_.Add(@"new ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"();
                    setCommandData(");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.Length.ToString());
                    }
                }
            _code_.Add(@");");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    setVerifyCommand(");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@");");
            }
            _if_ = false;
                if (!(bool)_value2_.IsVerifyMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    setCommand(");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@");");
            }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _if_ = false;
                    if (IsSetTcpServer)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    Value.SetTcpServer(this);");
            }
            _code_.Add(@"
                    if (attribute.IsAutoServer) Start();
                }
                /// <summary>
                /// 命令处理
                /// </summary>
                /// <param name=""index"">命令序号</param>
                /// <param name=""sender"">TCP 内部服务套接字数据发送</param>
                /// <param name=""data"">命令数据</param>
                public override void DoCommand(int index, AutoCSer.Net.TcpInternalServer.ServerSocketSender sender, ref SubArray<byte> data)
                {
                    AutoCSer.Net.TcpServer.ReturnType returnType;
                    switch (index - ");
            _code_.Add(CommandStartIndex.ToString());
            _code_.Add(@")
                    {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        case ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@":");
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            sender.Push(AutoCSer.Net.TcpServer.ReturnType.VersionExpired);");
            }
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;");
            }
            _code_.Add(@"
                            try
                            {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" inputParameter = new ");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"();
                                if (sender.DeSerialize(ref data, ref inputParameter");
            _if_ = false;
                    if (_value2_.IsSimpleSerializeInputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", true");
            }
            _code_.Add(@"))");
            }
            _code_.Add(@"
                                {");
            _if_ = false;
                    if (_value2_.IsAsynchronousCallback)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" outputParameter = new ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"();
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    Value.");
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"sender.GetCallback<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@", ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref outputParameter));");
            }
            _if_ = false;
                if (!(bool)_value2_.MethodIsReturn)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    Value.");
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"sender.GetCallback(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@"));");
            }
            }
            _if_ = false;
                if (!(bool)_value2_.IsAsynchronousCallback)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsMethodServerCall)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    (");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@"/**/.Pop()?? new ");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@"()).Set(sender, Value, ");
            _code_.Add(_value2_.ServerTask);
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref inputParameter");
            }
            _code_.Add(@");");
            }
            _if_ = false;
                if (!(bool)_value2_.IsMethodServerCall)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" _outputParameter_ = new ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"();");
            }
            }
            _code_.Add(@"
                                    ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            _if_ = false;
                    if (_value2_.MemberIndex != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsGetMember)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.PropertyParameter != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = Value[");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(_value5_.ParameterJoin);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"];");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (_value3_.PropertyParameter == null)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = Value.");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@";");
            }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsGetMember)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.PropertyParameter != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    Value[");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsPropertyValue)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(_value5_.ParameterJoin);
            }
                }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"] = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsPropertyValue)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@";");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (_value3_.PropertyParameter == null)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    Value.");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@";");
            }
            }
            }
            _if_ = false;
                if (_value2_.MemberIndex == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"Value.");
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_outputParameter_.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterJoin);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");");
            }
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    if (");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@") sender.SetVerifyMethod();");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    _outputParameter_.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    _outputParameter_.");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            _code_.Add(@"
                                    sender.Push(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref _outputParameter_);");
            }
            _if_ = false;
                if (_value2_.OutputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    sender.Push();");
            }
            }
            }
            }
            _code_.Add(@"
                                    return;
                                }");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerDeSerializeError;");
            }
            }
            _code_.Add(@"
                            }
                            catch (Exception error)
                            {");
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;");
            }
            _code_.Add(@"
                                sender.Log(error);
                            }");
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            sender.Push(returnType);");
            }
            }
            _code_.Add(@"
                            return;");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                        default: return;
                    }
                }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (!(bool)_value2_.IsAsynchronousCallback)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsMethodServerCall)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                sealed class ");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@" : AutoCSer.Net.TcpInternalServer.ServerCall<");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@", ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = Type;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(_value2_.InputParameterTypeName);
            }
            _code_.Add(@">
                {
                    private void get(ref AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" value)
                    {
                        try
                        {
                            ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            _if_ = false;
                    if (_value2_.MemberIndex != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsGetMember)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.PropertyParameter != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = serverValue[");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"Sender");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(_value5_.ParameterJoin);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"];");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (_value3_.PropertyParameter == null)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = serverValue.");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@";");
            }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsGetMember)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.PropertyParameter != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            serverValue[");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"Sender, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsPropertyValue)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(_value5_.ParameterJoin);
            }
                }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"] = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsPropertyValue)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@";");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (_value3_.PropertyParameter == null)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                            serverValue.");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@";");
            }
            }
            }
            _code_.Add(@"
");
            _if_ = false;
                if (_value2_.MemberIndex == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"serverValue.");
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"Sender");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"value.Value.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.Parameter;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.ParameterJoin);
                    }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");");
            }
            _code_.Add(@"
");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            if (");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@") Sender.SetVerifyMethod();");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            value.Value.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = inputParameter");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@".");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            value.Value.");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            }
            _code_.Add(@"
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.Success;
                        }
                        catch (Exception error)
                        {
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                            Sender.Log(error);
                        }
                    }
                    public override void Call()
                    {
                        AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" value = new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@"();");
            _if_ = false;
                    if (_value2_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        if (Sender.IsSocket) get(ref value);");
            }
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        if (Sender.IsSocket)
                        {
                            get(ref value);
                            Sender.Push(CommandIndex");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(_value2_.MethodIdentityCommand);
            }
            _code_.Add(@", ref value);
                        }");
            }
            _code_.Add(@"
                        push(this);
                    }
                }");
            }
            }
            _code_.Add(@"
                private static readonly AutoCSer.Net.TcpServer.OutputInfo ");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@" = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = ");
            _code_.Add(_value2_.OutputParameterIndex.ToString());
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsKeepCallback = ");
            _code_.Add(_value2_.IsKeepCallback.ToString());
            }
            _if_ = false;
                    if (_value2_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsClientSendOnly = ");
            _code_.Add(_value2_.IsClientSendOnly.ToString());
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeOutputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeOutputParamter = true");
            }
            _code_.Add(@" };");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            }
            _code_.Add(@"
");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterTypes[] _value1_;
                    _value1_ = ParameterTypes;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterTypes _value2_ in _value1_)
                        {
            _code_.Add(@"
                [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false");
            _if_ = false;
                if (!(bool)_value2_.IsSerializeReferenceMember)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsReferenceMember = false");
            }
            _code_.Add(@")]");
            _if_ = false;
                    if (_value2_.IsSerializeBox)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                [AutoCSer.Metadata.BoxSerialize]");
            }
            _code_.Add(@"
                [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
                internal struct ");
            _code_.Add(_value2_.ParameterTypeName);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
                    if (_value3_.Type != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
#if NOJIT
                     : AutoCSer.Net.IReturnParameter
#else
                     : AutoCSer.Net.IReturnParameter<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">
#endif");
            }
            _code_.Add(@"
                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.Parameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(@"
                    public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.ParameterType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
                    if (_value3_.Type != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    [AutoCSer.Json.IgnoreMember]
                    public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" Ret;
                    [AutoCSer.IOS.Preserve(Conditional = true)]
                    public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" Return
                    {
                        get { return Ret; }
                        set { Ret = value; }
                    }
#if NOJIT
                    [AutoCSer.Metadata.Ignore]
                    public object ReturnObject
                    {
                        get { return Ret; }
                        set { Ret = (");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@")value; }
                    }
#endif");
            }
            _code_.Add(@"
                }");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
            }");
            _if_ = false;
                    if (IsClientCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            /// <summary>
            /// TCP客户端
            /// </summary>
            public class TcpInternalClient : AutoCSer.Net.TcpInternalServer.MethodClient<TcpInternalClient>
            {");
            _if_ = false;
                    if (IsTimeVerify)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                private bool _timerVerify_(TcpInternalClient client, AutoCSer.Net.TcpInternalServer.ClientSocketSender sender)
                {
                    return AutoCSer.Net.TcpInternalServer.TimeVerifyClient.Verify(verify, sender, _TcpClient_);
                }");
            }
            _code_.Add(@"
                /// <summary>
                /// TCP调用客户端
                /// </summary>
                /// <param name=""attribute"">TCP 调用服务器端配置信息</param>");
            _if_ = false;
                    if (IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""verifyMethod"">TCP 验证方法</param>");
            }
            _code_.Add(@"
                /// <param name=""onCustomData"">自定义数据包处理</param>
                /// <param name=""log"">日志接口</param>
                public TcpInternalClient(AutoCSer.Net.TcpInternalServer.ServerAttribute attribute = null");
            _if_ = false;
                    if (IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", Func<TcpInternalClient, AutoCSer.Net.TcpInternalServer.ClientSocketSender, bool> verifyMethod = null");
            }
            _code_.Add(@", Action<SubArray<byte>> onCustomData = null, AutoCSer.Log.ILog log = null)
                {
                    if (attribute == null)
                    {");
            _if_ = false;
                    if (IsServerCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        attribute = AutoCSer.Net.TcpInternalServer.ServerAttribute.GetConfig(""");
            _code_.Add(ServerRegisterName);
            _code_.Add(@""", typeof(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"));");
            }
            _if_ = false;
                if (!(bool)IsServerCode)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        attribute = AutoCSer.Config.Loader.Get<AutoCSer.Net.TcpInternalServer.ServerAttribute>(""");
            _code_.Add(ServerRegisterName);
            _code_.Add(@""") ?? AutoCSer.Json.Parser.Parse<AutoCSer.Net.TcpInternalServer.ServerAttribute>(@""");
            _code_.Add(AttributeJson);
            _code_.Add(@""");
                        if (attribute.Name == null) attribute.Name = """);
            _code_.Add(ServerRegisterName);
            _code_.Add(@""";");
            }
            _code_.Add(@"
                    }
                    _TcpClient_ = new AutoCSer.Net.TcpInternalServer.Client<TcpInternalClient>(this, attribute, onCustomData, log");
            _if_ = false;
                    if (IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", verifyMethod");
            _if_ = false;
                    if (IsTimeVerify)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" ?? (Func<TcpInternalClient, AutoCSer.Net.TcpInternalServer.ClientSocketSender, bool>)_timerVerify_");
            }
            }
            _code_.Add(@");
                    if (attribute.IsAuto) _TcpClient_.TryCreateSocket();
                }
");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsSynchronousMethodIdentityCommand)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                private static readonly AutoCSer.Net.TcpServer.CommandInfo ");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@" = new AutoCSer.Net.TcpServer.CommandInfo { Command = ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@" + ");
            _code_.Add(CommandStartIndex.ToString());
            _code_.Add(@", InputParameterIndex = ");
            _code_.Add(_value2_.InputParameterIndex.ToString());
            _if_ = false;
                    if (_value2_.IsJsonSerialize)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" , CommandFlags = AutoCSer.Net.TcpServer.CommandFlags.JsonSerialize");
            }
            _code_.Add(@", IsSendOnly = ");
            _code_.Add(_value2_.IsClientSendOnly.ToString());
            _code_.Add(@", TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous");
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsVerifyMethod = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeInputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeInputParamter = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeOutputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeOutputParamter = true");
            }
            _code_.Add(@" };");
            }
            _code_.Add(@"
");
            _if_ = false;
                if (_value2_.MemberIndex == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                public void ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@")
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                    {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                        ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    };");
            }
            _code_.Add(@"
                    _TcpClient_.Sender.CallOnly(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");");
            }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsClientSynchronous)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.ReturnXmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <returns>");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.ReturnXmlDocument);
                    }
                }
            _code_.Add(@"</returns>");
            }
            _code_.Add(@"
                public AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"AutoCSer.Net.TcpInternalServer.ClientSocketSender _sender_, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@")
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".Pop();
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = ");
            _if_ = false;
                if (!(bool)_value2_.IsVerifyMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_TcpClient_.Sender");
            }
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_sender_");
            }
            _code_.Add(@";
                        if (_socket_ != null)
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            };");
            }
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" _outputParameter_ = new TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRef)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value3_ = _value2_.ReturnInputParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                Ret = ");
            _code_.Add(_value3_.ParameterName);
            }
                }
            _code_.Add(@"
                            };
                            AutoCSer.Net.TcpServer.ReturnType _returnType_ = _socket_.WaitGet<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@", ref _outputParameter_);");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRefOrOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = _outputParameter_.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnType_");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", Value = _outputParameter_.Return");
            }
            _code_.Add(@" };");
            }
            _if_ = false;
                if (_value2_.OutputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _socket_.WaitCall(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@") };");
            }
            _code_.Add(@"
                        }
                    }
                    finally
                    {
                        if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".PushNotNull(_wait_);
                    }");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                }");
            _if_ = false;
                    if (_value2_.IsClientTaskAsync)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
#if DOTNET2
#else
#if DOTNET4
#else");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.ReturnXmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <returns>");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.ReturnXmlDocument);
                    }
                }
            _code_.Add(@"</returns>");
            }
            _code_.Add(@"
                public async System.Threading.Tasks.Task<AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@"> ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.TaskAsyncMethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"AutoCSer.Net.TcpInternalServer.ClientSocketSender _sender_, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@")
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = ");
            _if_ = false;
                if (!(bool)_value2_.IsVerifyMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_TcpClient_.Sender");
            }
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_sender_");
            }
            _code_.Add(@";
                    if (_socket_ != null)
                    {
                        AutoCSer.Net.TcpServer.TaskAsyncReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = new AutoCSer.Net.TcpServer.TaskAsyncReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@"();");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                        };");
            }
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.ReturnType _returnType_;");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" _outputParameter_ = new TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRef)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value3_ = _value2_.ReturnInputParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            Ret = ");
            _code_.Add(_value3_.ParameterName);
            }
                }
            _code_.Add(@"
                        };
                        if ((_returnType_ = _socket_.GetAsync<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@", ref _outputParameter_)) == AutoCSer.Net.TcpServer.ReturnType.Success)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _returnOutputParameter_ = await _wait_;");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRefOrOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = _returnOutputParameter_.Value.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnOutputParameter_.Type");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", Value = _returnOutputParameter_.Value.Return");
            }
            _code_.Add(@" };
                        }
                        return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnType_ };");
            }
            _if_ = false;
                if (_value2_.OutputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        _returnType_ = _socket_.CallAsync(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                        return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnType_ == AutoCSer.Net.TcpServer.ReturnType.Success ? await _wait_ : _returnType_ };");
            }
            _code_.Add(@"
                    }");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                }
#endif
#endif");
            }
            }
            _if_ = false;
                    if (_value2_.IsClientAsynchronous)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                private static readonly AutoCSer.Net.TcpServer.CommandInfo ");
            _code_.Add(_value2_.MethodAsynchronousIdentityCommand);
            _code_.Add(@" = new AutoCSer.Net.TcpServer.CommandInfo { Command = ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@" + ");
            _code_.Add(CommandStartIndex.ToString());
            _code_.Add(@", InputParameterIndex = ");
            _code_.Add(_value2_.InputParameterIndex.ToString());
            _code_.Add(@", TaskType = ");
            _code_.Add(_value2_.ClientTask);
            _if_ = false;
                    if (_value2_.IsJsonSerialize)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" , CommandFlags = AutoCSer.Net.TcpServer.CommandFlags.JsonSerialize");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsKeepCallback = ");
            _code_.Add(_value2_.IsKeepCallback.ToString());
            }
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsVerifyMethod = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeInputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeInputParamter = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeOutputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeOutputParamter = true");
            }
            _code_.Add(@" };");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.ReturnXmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""_onReturn_"">");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.ReturnXmlDocument);
                    }
                }
            _code_.Add(@"</param>");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <returns>保持异步回调</returns>");
            }
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public ");
            _code_.Add(_value2_.KeepCallbackType);
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"Action<AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@"> _onReturn_)
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    if (_onReturn_ == null) throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());
                    _onReturn_(new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@"{ Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired });");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@"> _onOutput_ = _TcpClient_.GetCallback<");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(_onReturn_);
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            };");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            return _socket_.GetKeep<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodAsynchronousIdentityCommand);
            _code_.Add(@", ref _onOutput_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");");
            }
            _if_ = false;
                if (_value2_.IsKeepCallback == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            _socket_.Get<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodAsynchronousIdentityCommand);
            _code_.Add(@", ref _onOutput_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");");
            }
            _code_.Add(@"
                        }
                    }
                    finally
                    {
                        if (_onOutput_ != null)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }");
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    return null;");
            }
            }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                if (!(bool)_value2_.MethodIsReturn)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public ");
            _code_.Add(_value2_.KeepCallbackType);
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"Action<AutoCSer.Net.TcpServer.ReturnValue> _onReturn_)
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    if (_onReturn_ == null) throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());
                    _onReturn_(new AutoCSer.Net.TcpServer.ReturnValue { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired });");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            };");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            AutoCSer.Net.TcpServer.KeepCallback _keepCallback_ = _socket_.CallKeep(");
            _code_.Add(_value2_.MethodAsynchronousIdentityCommand);
            _code_.Add(@", _onReturn_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                            _onReturn_ = null;
                            return _keepCallback_;");
            }
            _if_ = false;
                if (_value2_.IsKeepCallback == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            _socket_.Call(");
            _code_.Add(_value2_.MethodAsynchronousIdentityCommand);
            _code_.Add(@", _onReturn_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                            _onReturn_ = null;");
            }
            _code_.Add(@"
                        }
                    }
                    finally
                    {
                        if (_onReturn_ != null) _onReturn_(new AutoCSer.Net.TcpServer.ReturnValue { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException });
                    }");
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    return null;");
            }
            }
            _code_.Add(@"
                }");
            }
            }
            }
            }
            _code_.Add(@"
");
            _if_ = false;
                    if (_value2_.MemberIndex != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> this[");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"]
                {
                    get
                    {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".Pop();
                        try
                        {
                            AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                            if (_socket_ != null)
                            {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                                };");
            }
            _code_.Add(@"
                                AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _outputParameter_ = _socket_.WaitGet<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                                return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = _outputParameter_.Type, Value = _outputParameter_.Value.Return };
                            }
                        }
                        finally
                        {
                            if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".PushNotNull(_wait_);
                        }
                        return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                    }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value3_ = default(AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod);
                    _value3_ = _value2_.SetMethod;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    set
                    {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value4_ = _value3_.Attribute;
                    if (_value4_ != null)
                    {
                    if (_value4_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value4_ = _value3_.Attribute;
                    if (_value4_ != null)
                    {
                if (!(bool)_value4_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value3_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        TcpInternalServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@" _sendOnlyInputParameter_ = new TcpInternalServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value3_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.Parameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"
                        };
                        _TcpClient_.Sender.CallOnly(");
            _code_.Add(_value3_.MethodIdentityCommand);
            _code_.Add(@", ref _sendOnlyInputParameter_);");
            }
            _if_ = false;
                if (_value3_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.AutoWaitReturnValue _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue.Pop();
                        try
                        {
                            AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                            if (_socket_ != null)
                            {
                                TcpInternalServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpInternalServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@"
                                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value3_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.Parameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"
                                };
                                AutoCSer.Net.TcpServer.ReturnType _returnType_ = _socket_.WaitCall(");
            _code_.Add(_value3_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_, ref _inputParameter_);
                                if (_returnType_ == AutoCSer.Net.TcpServer.ReturnType.Success) return;
                                throw new Exception(_returnType_.ToString());
                            }
                        }
                        finally
                        {
                            if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue.PushNotNull(_wait_);
                        }
                        throw new Exception(AutoCSer.Net.TcpServer.ReturnType.ClientException.ToString());");
            }
            }
            _code_.Add(@"
                    }");
            }
                }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                if (_value2_.InputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> ");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@"
                {
                    get
                    {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".Pop();
                        try
                        {
                            AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                            if (_socket_ != null)
                            {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                                };");
            }
            _code_.Add(@"
                                AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _outputParameter_ = _socket_.WaitGet<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                                return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = _outputParameter_.Type, Value = _outputParameter_.Value.Return };
                            }
                        }
                        finally
                        {
                            if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpInternalServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".PushNotNull(_wait_);
                        }
                        return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                    }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value3_ = default(AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpInternalServer.ServerAttribute,AutoCSer.Net.TcpServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod);
                    _value3_ = _value2_.SetMethod;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    set
                    {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value4_ = _value3_.Attribute;
                    if (_value4_ != null)
                    {
                    if (_value4_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpServer.MethodAttribute _value4_ = _value3_.Attribute;
                    if (_value4_ != null)
                    {
                if (!(bool)_value4_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value3_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        TcpInternalServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@" _sendOnlyInputParameter_ = new TcpInternalServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value3_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.Parameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"
                        };
                        _TcpClient_.Sender.CallOnly(");
            _code_.Add(_value3_.MethodIdentityCommand);
            _code_.Add(@", ref _sendOnlyInputParameter_);");
            }
            _if_ = false;
                if (_value3_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.AutoWaitReturnValue _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue.Pop();
                        try
                        {
                            AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                            if (_socket_ != null)
                            {
                                TcpInternalServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpInternalServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@"
                                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value3_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.Parameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"
                                };
                                AutoCSer.Net.TcpServer.ReturnType _returnType_ = _socket_.WaitCall(");
            _code_.Add(_value3_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_, ref _inputParameter_);
                                if (_returnType_ == AutoCSer.Net.TcpServer.ReturnType.Success) return;
                                throw new Exception(_returnType_.ToString());
                            }
                        }
                        finally
                        {
                            if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue.PushNotNull(_wait_);
                        }
                        throw new Exception(AutoCSer.Net.TcpServer.ReturnType.ClientException.ToString());");
            }
            }
            _code_.Add(@"
                    }");
            }
                }
            _code_.Add(@"
                }");
            }
            }
            }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
            }");
            }
            _code_.Add(@"
        }");
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal partial class TcpOpenServer
    {
    internal partial class Generator
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.CSharp, _isOut_))
            {
                
            _code_.Add(@"
        ");
            _code_.Add(TypeNameDefinition);
            _if_ = false;
                    if (IsSetTcpServer)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (IsServerCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
#if NOJIT
#else
              : AutoCSer.Net.TcpServer.ISetTcpServer<AutoCSer.Net.TcpOpenServer.Server, AutoCSer.Net.TcpOpenServer.ServerAttribute>
#endif");
            }
            }
            _code_.Add(@"
        {");
            _if_ = false;
                    if (IsServerCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            /// <summary>
            /// 命令序号记忆数据
            /// </summary>
            private static KeyValue<string, int>[] ");
            _code_.Add(RememberIdentityCommeandName);
            _code_.Add(@"()
            {
                KeyValue<string, int>[] names = new KeyValue<string, int>[");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod[] _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.Length.ToString());
                    }
                }
            _code_.Add(@"];");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                names[");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@"].Set(@""");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.MethodKeyName);
                    }
                }
            _code_.Add(@""", ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@");");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                return names;
            }");
            }
            _code_.Add(@"
            /// <summary>
            /// ");
            _code_.Add(ServerRegisterName);
            _code_.Add(@" TCP服务");
            _if_ = false;
                if (!(bool)IsServerCode)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"参数");
            }
            _code_.Add(@"
            /// </summary>
            public sealed class TcpOpenServer");
            _if_ = false;
                    if (IsServerCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" : AutoCSer.Net.TcpOpenServer.Server");
            }
            _code_.Add(@"
            {");
            _if_ = false;
                    if (IsServerCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public readonly ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@" Value;
                /// <summary>
                /// ");
            _code_.Add(ServerRegisterName);
            _code_.Add(@" TCP调用服务端
                /// </summary>
                /// <param name=""attribute"">TCP调用服务器端配置信息</param>");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                {
                    System.Type _value2_ = _value1_.Type;
                    if (_value2_ != null)
                    {
                    if (_value2_.IsPublic)
                    {
                        _if_ = true;
                    }
                }
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""value"">TCP服务目标对象</param>");
            }
            _code_.Add(@"
                /// <param name=""log"">日志接口</param>
                /// <param name=""onCustomData"">自定义数据包处理</param>
                public TcpOpenServer(AutoCSer.Net.TcpOpenServer.ServerAttribute attribute = null, Func<System.Net.Sockets.Socket, bool> verify = null");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                {
                    System.Type _value2_ = _value1_.Type;
                    if (_value2_ != null)
                    {
                    if (_value2_.IsPublic)
                    {
                        _if_ = true;
                    }
                }
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@" value = null");
            }
            _code_.Add(@", Action<SubArray<byte>> onCustomData = null, AutoCSer.Log.ILog log = null)
                    : base(attribute ?? (attribute = AutoCSer.Net.TcpOpenServer.ServerAttribute.GetConfig(""");
            _code_.Add(ServerRegisterName);
            _code_.Add(@""", typeof(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"))), verify, onCustomData, log, ");
            _code_.Add(IsCallQueue ? "true" : "false");
            _code_.Add(@")
                {
                    Value =");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                {
                    System.Type _value2_ = _value1_.Type;
                    if (_value2_ != null)
                    {
                    if (_value2_.IsPublic)
                    {
                        _if_ = true;
                    }
                }
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@" value ?? ");
            }
            _code_.Add(@"new ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"();
                    setCommandData(");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod[] _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.Length.ToString());
                    }
                }
            _code_.Add(@");");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    setVerifyCommand(");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@");");
            }
            _if_ = false;
                if (!(bool)_value2_.IsVerifyMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    setCommand(");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@");");
            }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _if_ = false;
                    if (IsSetTcpServer)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    Value.SetTcpServer(this);");
            }
            _code_.Add(@"
                    if (attribute.IsAutoServer) Start();
                }
                /// <summary>
                /// 命令处理
                /// </summary>
                /// <param name=""index"">命令序号</param>
                /// <param name=""sender"">TCP 内部服务套接字数据发送</param>
                /// <param name=""data"">命令数据</param>
                public override void DoCommand(int index, AutoCSer.Net.TcpOpenServer.ServerSocketSender sender, ref SubArray<byte> data)
                {
                    AutoCSer.Net.TcpServer.ReturnType returnType;
                    switch (index - ");
            _code_.Add(CommandStartIndex.ToString());
            _code_.Add(@")
                    {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        case ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@":");
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            sender.Push(AutoCSer.Net.TcpServer.ReturnType.VersionExpired);");
            }
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;");
            }
            _code_.Add(@"
                            try
                            {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" inputParameter = new ");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"();
                                if (sender.DeSerialize(ref data, ref inputParameter");
            _if_ = false;
                    if (_value2_.IsSimpleSerializeInputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", true");
            }
            _code_.Add(@"))");
            }
            _code_.Add(@"
                                {");
            _if_ = false;
                    if (_value2_.IsAsynchronousCallback)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" outputParameter = new ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"();
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    Value.");
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@" sender.GetCallback<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@", ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref outputParameter));");
            }
            _if_ = false;
                if (!(bool)_value2_.MethodIsReturn)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    Value.");
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"sender.GetCallback(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@"));");
            }
            }
            _if_ = false;
                if (!(bool)_value2_.IsAsynchronousCallback)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsMethodServerCall)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    (");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@"/**/.Pop() ?? new ");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@"()).Set(sender, Value, ");
            _code_.Add(_value2_.ServerTask);
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref inputParameter");
            }
            _code_.Add(@");");
            }
            _if_ = false;
                if (!(bool)_value2_.IsMethodServerCall)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" _outputParameter_ = new ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"();");
            }
            }
            _code_.Add(@"
                                    ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            _if_ = false;
                    if (_value2_.MemberIndex != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsGetMember)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.PropertyParameter != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = Value[");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(_value5_.ParameterJoin);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"];");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (_value3_.PropertyParameter == null)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = Value.");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@";");
            }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsGetMember)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.PropertyParameter != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    Value[");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsPropertyValue)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(_value5_.ParameterJoin);
            }
                }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"] = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsPropertyValue)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@";");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (_value3_.PropertyParameter == null)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    Value.");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@";");
            }
            }
            }
            _if_ = false;
                if (_value2_.MemberIndex == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"Value.");
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_outputParameter_.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterJoin);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");");
            }
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    if (");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@") sender.SetVerifyMethod();");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    _outputParameter_.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    _outputParameter_.");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            _code_.Add(@"
                                    sender.Push(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref _outputParameter_);");
            }
            _if_ = false;
                if (_value2_.OutputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    sender.Push();");
            }
            }
            }
            }
            _code_.Add(@"
                                    return;
                                }");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerDeSerializeError;");
            }
            }
            _code_.Add(@"
                            }
                            catch (Exception error)
                            {");
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;");
            }
            _code_.Add(@"
                                sender.Log(error);
                            }");
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            sender.Push(returnType);");
            }
            }
            _code_.Add(@"
                            return;");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                        default: return;
                    }
                }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (!(bool)_value2_.IsAsynchronousCallback)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsMethodServerCall)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                sealed class ");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@" : AutoCSer.Net.TcpOpenServer.ServerCall<");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@", ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = Type;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(_value2_.InputParameterTypeName);
            }
            _code_.Add(@">
                {
                    private void get(ref AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" value)
                    {
                        try
                        {
                            ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            _if_ = false;
                    if (_value2_.MemberIndex != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsGetMember)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.PropertyParameter != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = serverValue[");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"Sender");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(_value5_.ParameterJoin);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"];");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (_value3_.PropertyParameter == null)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = serverValue.");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@";");
            }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsGetMember)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.PropertyParameter != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            serverValue[");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"Sender, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsPropertyValue)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(_value5_.ParameterJoin);
            }
                }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"] = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsPropertyValue)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@";");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (_value3_.PropertyParameter == null)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                            serverValue.");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@";");
            }
            }
            }
            _code_.Add(@"
");
            _if_ = false;
                if (_value2_.MemberIndex == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"serverValue.");
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"Sender");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"value.Value.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.Parameter;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.ParameterJoin);
                    }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");");
            }
            _code_.Add(@"
");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            if (");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@") Sender.SetVerifyMethod();");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            value.Value.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            value.Value.");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            }
            _code_.Add(@"
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.Success;
                        }
                        catch (Exception error)
                        {
                            value.Type = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                            Sender.Log(error);
                        }
                    }
                    public override void Call()
                    {
                        AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" value = new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@"();");
            _if_ = false;
                    if (_value2_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        if (Sender.IsSocket) get(ref value);");
            }
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        if (Sender.IsSocket)
                        {
                            get(ref value);
                            Sender.Push(CommandIndex");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(_value2_.MethodIdentityCommand);
            }
            _code_.Add(@", ref value);
                        }");
            }
            _code_.Add(@"
                        push(this);
                    }
                }");
            }
            }
            _code_.Add(@"
                private static readonly AutoCSer.Net.TcpServer.OutputInfo ");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@" = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = ");
            _code_.Add(_value2_.OutputParameterIndex.ToString());
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsKeepCallback = ");
            _code_.Add(_value2_.IsKeepCallback.ToString());
            }
            _if_ = false;
                    if (_value2_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsClientSendOnly = ");
            _code_.Add(_value2_.IsClientSendOnly.ToString());
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeOutputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeOutputParamter = true");
            }
            _code_.Add(@" };");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            }
            _code_.Add(@"
");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterTypes[] _value1_;
                    _value1_ = ParameterTypes;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterTypes _value2_ in _value1_)
                        {
            _code_.Add(@"
                [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false");
            _if_ = false;
                if (!(bool)_value2_.IsSerializeReferenceMember)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsReferenceMember = false");
            }
            _code_.Add(@")]");
            _if_ = false;
                    if (_value2_.IsSerializeBox)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                [AutoCSer.Metadata.BoxSerialize]");
            }
            _code_.Add(@"
                [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
                internal struct ");
            _code_.Add(_value2_.ParameterTypeName);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
                    if (_value3_.Type != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
#if NOJIT
                     : AutoCSer.Net.IReturnParameter
#else
                     : AutoCSer.Net.IReturnParameter<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">
#endif");
            }
            _code_.Add(@"
                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.Parameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(@"
                    public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.ParameterType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
                    if (_value3_.Type != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    [AutoCSer.Json.IgnoreMember]
                    public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" Ret;
                    [AutoCSer.IOS.Preserve(Conditional = true)]
                    public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" Return
                    {
                        get { return Ret; }
                        set { Ret = value; }
                    }
#if NOJIT
                    [AutoCSer.Metadata.Ignore]
                    public object ReturnObject
                    {
                        get { return Ret; }
                        set { Ret = (");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@")value; }
                    }
#endif");
            }
            _code_.Add(@"
                }");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
            }");
            _if_ = false;
                    if (IsClientCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            /// <summary>
            /// TCP客户端
            /// </summary>
            public class TcpOpenClient : AutoCSer.Net.TcpOpenServer.MethodClient<TcpOpenClient>
            {");
            _if_ = false;
                    if (IsTimeVerify)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                private bool _timerVerify_(TcpOpenClient client, AutoCSer.Net.TcpOpenServer.ClientSocketSender sender)
                {
                    return AutoCSer.Net.TcpOpenServer.TimeVerifyClient.Verify(verify, sender, _TcpClient_);
                }");
            }
            _code_.Add(@"
                /// <summary>
                /// TCP调用客户端
                /// </summary>
                /// <param name=""attribute"">TCP调用服务器端配置信息</param>");
            _if_ = false;
                    if (IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""verifyMethod"">TCP验证方法</param>");
            }
            _code_.Add(@"
                /// <param name=""onCustomData"">自定义数据包处理</param>
                /// <param name=""log"">日志接口</param>
                public TcpOpenClient(AutoCSer.Net.TcpOpenServer.ServerAttribute attribute = null");
            _if_ = false;
                    if (IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", Func<TcpOpenClient, AutoCSer.Net.TcpOpenServer.ClientSocketSender, bool> verifyMethod = null");
            }
            _code_.Add(@", Action<SubArray<byte>> onCustomData = null, AutoCSer.Log.ILog log = null)
                {
                    if (attribute == null)
                    {");
            _if_ = false;
                    if (IsServerCode)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        attribute = AutoCSer.Net.TcpOpenServer.ServerAttribute.GetConfig(""");
            _code_.Add(ServerRegisterName);
            _code_.Add(@""", typeof(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@"));");
            }
            _if_ = false;
                if (!(bool)IsServerCode)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        attribute = AutoCSer.Config.Loader.Get<AutoCSer.Net.TcpOpenServer.ServerAttribute>(""");
            _code_.Add(ServerRegisterName);
            _code_.Add(@""") ?? AutoCSer.Json.Parser.Parse<AutoCSer.Net.TcpOpenServer.ServerAttribute>(@""");
            _code_.Add(AttributeJson);
            _code_.Add(@""");
                        if (attribute.Name == null) attribute.Name = """);
            _code_.Add(ServerRegisterName);
            _code_.Add(@""";");
            }
            _code_.Add(@"
                    }
                    _TcpClient_ = new AutoCSer.Net.TcpOpenServer.Client<TcpOpenClient>(this, attribute, onCustomData, log");
            _if_ = false;
                    if (IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", verifyMethod");
            _if_ = false;
                    if (IsTimeVerify)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" ?? (Func<TcpOpenClient, AutoCSer.Net.TcpOpenServer.ClientSocketSender, bool>)_timerVerify_");
            }
            }
            _code_.Add(@");
                    if (attribute.IsAutoClient) _TcpClient_.TryCreateSocket();
                }
");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsSynchronousMethodIdentityCommand)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                private static readonly AutoCSer.Net.TcpServer.CommandInfo ");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@" = new AutoCSer.Net.TcpServer.CommandInfo { Command = ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@" + ");
            _code_.Add(CommandStartIndex.ToString());
            _code_.Add(@", InputParameterIndex = ");
            _code_.Add(_value2_.InputParameterIndex.ToString());
            _if_ = false;
                    if (_value2_.IsJsonSerialize)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" , CommandFlags = AutoCSer.Net.TcpServer.CommandFlags.JsonSerialize");
            }
            _code_.Add(@", IsSendOnly = ");
            _code_.Add(_value2_.IsClientSendOnly.ToString());
            _code_.Add(@", TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous");
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsVerifyMethod = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeInputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeInputParamter = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeOutputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeOutputParamter = true");
            }
            _code_.Add(@" };");
            }
            _code_.Add(@"
");
            _if_ = false;
                if (_value2_.MemberIndex == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                public void ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@")
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                    {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                        ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    };");
            }
            _code_.Add(@"
                    _TcpClient_.Sender.CallOnly(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");");
            }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsClientSynchronous)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.ReturnXmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <returns>");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.ReturnXmlDocument);
                    }
                }
            _code_.Add(@"</returns>");
            }
            _code_.Add(@"
                public AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"AutoCSer.Net.TcpOpenServer.ClientSocketSender _sender_, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@")
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".Pop();
                    try
                    {
                        AutoCSer.Net.TcpOpenServer.ClientSocketSender _socket_ = ");
            _if_ = false;
                if (!(bool)_value2_.IsVerifyMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_TcpClient_.Sender");
            }
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_sender_");
            }
            _code_.Add(@";
                        if (_socket_ != null)
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            };");
            }
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" _outputParameter_ = new TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRef)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value3_ = _value2_.ReturnInputParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                Ret = ");
            _code_.Add(_value3_.ParameterName);
            }
                }
            _code_.Add(@"
                            };
                            AutoCSer.Net.TcpServer.ReturnType _returnType_ = _socket_.WaitGet<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@", ref _outputParameter_);");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRefOrOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = _outputParameter_.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnType_");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", Value = _outputParameter_.Return");
            }
            _code_.Add(@" };");
            }
            _if_ = false;
                if (_value2_.OutputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _socket_.WaitCall(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@") };");
            }
            _code_.Add(@"
                        }
                    }
                    finally
                    {
                        if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".PushNotNull(_wait_);
                    }");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                }");
            _if_ = false;
                    if (_value2_.IsClientTaskAsync)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
#if DOTNET2
#else
#if DOTNET4
#else");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.ReturnXmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <returns>");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.ReturnXmlDocument);
                    }
                }
            _code_.Add(@"</returns>");
            }
            _code_.Add(@"
                public async System.Threading.Tasks.Task<AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@"> ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.TaskAsyncMethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"AutoCSer.Net.TcpOpenServer.ClientSocketSender _sender_, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@")
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    AutoCSer.Net.TcpOpenServer.ClientSocketSender _socket_ = ");
            _if_ = false;
                if (!(bool)_value2_.IsVerifyMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_TcpClient_.Sender");
            }
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_sender_");
            }
            _code_.Add(@";
                    if (_socket_ != null)
                    {
                        AutoCSer.Net.TcpServer.TaskAsyncReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = new AutoCSer.Net.TcpServer.TaskAsyncReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@"();");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                        };");
            }
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.ReturnType _returnType_;");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" _outputParameter_ = new TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRef)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value3_ = _value2_.ReturnInputParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            Ret = ");
            _code_.Add(_value3_.ParameterName);
            }
                }
            _code_.Add(@"
                        };
                        if ((_returnType_ = _socket_.GetAsync<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@", ref _outputParameter_)) == AutoCSer.Net.TcpServer.ReturnType.Success)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _returnOutputParameter_ = await _wait_;");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRefOrOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = _returnOutputParameter_.Value.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnOutputParameter_.Type");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", Value = _returnOutputParameter_.Value.Return");
            }
            _code_.Add(@" };
                        }
                        return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnType_ };");
            }
            _if_ = false;
                if (_value2_.OutputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        _returnType_ = _socket_.CallAsync(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                        return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnType_ == AutoCSer.Net.TcpServer.ReturnType.Success ? await _wait_ : _returnType_ };");
            }
            _code_.Add(@"
                    }");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                }
#endif
#endif");
            }
            }
            _if_ = false;
                    if (_value2_.IsClientAsynchronous)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                private static readonly AutoCSer.Net.TcpServer.CommandInfo ");
            _code_.Add(_value2_.MethodAsynchronousIdentityCommand);
            _code_.Add(@" = new AutoCSer.Net.TcpServer.CommandInfo { Command = ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@" + ");
            _code_.Add(CommandStartIndex.ToString());
            _code_.Add(@", InputParameterIndex = ");
            _code_.Add(_value2_.InputParameterIndex.ToString());
            _code_.Add(@", TaskType = ");
            _code_.Add(_value2_.ClientTask);
            _if_ = false;
                    if (_value2_.IsJsonSerialize)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" , CommandFlags = AutoCSer.Net.TcpServer.CommandFlags.JsonSerialize");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsKeepCallback = ");
            _code_.Add(_value2_.IsKeepCallback.ToString());
            }
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsVerifyMethod = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeInputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeInputParamter = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeOutputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeOutputParamter = true");
            }
            _code_.Add(@" };");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.ReturnXmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""_onReturn_"">");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.ReturnXmlDocument);
                    }
                }
            _code_.Add(@"</param>");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <returns>保持异步回调</returns>");
            }
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public ");
            _code_.Add(_value2_.KeepCallbackType);
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"Action<AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@"> _onReturn_)
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    if (_onReturn_ == null) throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());
                    _onReturn_(new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@"{ Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired });");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@"> _onOutput_ = _TcpClient_.GetCallback<");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(_onReturn_);
                    try
                    {
                        AutoCSer.Net.TcpOpenServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            };");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            return _socket_.GetKeep<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodAsynchronousIdentityCommand);
            _code_.Add(@", ref _onOutput_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");");
            }
            _if_ = false;
                if (_value2_.IsKeepCallback == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            _socket_.Get<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodAsynchronousIdentityCommand);
            _code_.Add(@", ref _onOutput_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");");
            }
            _code_.Add(@"
                        }
                    }
                    finally
                    {
                        if (_onOutput_ != null)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }");
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    return null;");
            }
            }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                if (!(bool)_value2_.MethodIsReturn)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public ");
            _code_.Add(_value2_.KeepCallbackType);
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"Action<AutoCSer.Net.TcpServer.ReturnValue> _onReturn_)
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    if (_onReturn_ == null) throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());
                    _onReturn_(new AutoCSer.Net.TcpServer.ReturnValue { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired });");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    try
                    {
                        AutoCSer.Net.TcpOpenServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                        if (_socket_ != null)
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            };");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            AutoCSer.Net.TcpServer.KeepCallback _keepCallback_ = _socket_.CallKeep(");
            _code_.Add(_value2_.MethodAsynchronousIdentityCommand);
            _code_.Add(@", _onReturn_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                            _onReturn_ = null;
                            return _keepCallback_;");
            }
            _if_ = false;
                if (_value2_.IsKeepCallback == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            _socket_.Call(");
            _code_.Add(_value2_.MethodAsynchronousIdentityCommand);
            _code_.Add(@", _onReturn_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                            _onReturn_ = null;");
            }
            _code_.Add(@"
                        }
                    }
                    finally
                    {
                        if (_onReturn_ != null) _onReturn_(new AutoCSer.Net.TcpServer.ReturnValue { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException });
                    }");
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    return null;");
            }
            }
            _code_.Add(@"
                }");
            }
            }
            }
            }
            _code_.Add(@"
");
            _if_ = false;
                    if (_value2_.MemberIndex != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> this[");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"]
                {
                    get
                    {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".Pop();
                        try
                        {
                            AutoCSer.Net.TcpOpenServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                            if (_socket_ != null)
                            {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                                };");
            }
            _code_.Add(@"
                                AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _outputParameter_ = _socket_.WaitGet<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                                return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = _outputParameter_.Type, Value = _outputParameter_.Value.Return };
                            }
                        }
                        finally
                        {
                            if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".PushNotNull(_wait_);
                        }
                        return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                    }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod _value3_ = default(AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod);
                    _value3_ = _value2_.SetMethod;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    set
                    {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value4_ = _value3_.Attribute;
                    if (_value4_ != null)
                    {
                    if (_value4_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value4_ = _value3_.Attribute;
                    if (_value4_ != null)
                    {
                if (!(bool)_value4_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value3_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        TcpOpenServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@" _sendOnlyInputParameter_ = new TcpOpenServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value3_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.Parameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"
                        };
                        _TcpClient_.Sender.CallOnly(");
            _code_.Add(_value3_.MethodIdentityCommand);
            _code_.Add(@", ref _sendOnlyInputParameter_);");
            }
            _if_ = false;
                if (_value3_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.AutoWaitReturnValue _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue.Pop();
                        try
                        {
                            AutoCSer.Net.TcpOpenServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                            if (_socket_ != null)
                            {
                                TcpOpenServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpOpenServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@"
                                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value3_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.Parameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"
                                };
                                AutoCSer.Net.TcpServer.ReturnType _returnType_ = _socket_.WaitCall(");
            _code_.Add(_value3_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_, ref _inputParameter_);
                                if (_returnType_ == AutoCSer.Net.TcpServer.ReturnType.Success) return;
                                throw new Exception(_returnType_.ToString());
                            }
                        }
                        finally
                        {
                            if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue.PushNotNull(_wait_);
                        }
                        throw new Exception(AutoCSer.Net.TcpServer.ReturnType.ClientException.ToString());");
            }
            }
            _code_.Add(@"
                    }");
            }
                }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                if (_value2_.InputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> ");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@"
                {
                    get
                    {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".Pop();
                        try
                        {
                            AutoCSer.Net.TcpOpenServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                            if (_socket_ != null)
                            {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                                };");
            }
            _code_.Add(@"
                                AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _outputParameter_ = _socket_.WaitGet<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
            _code_.Add(@"TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                                return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = _outputParameter_.Type, Value = _outputParameter_.Value.Return };
                            }
                        }
                        finally
                        {
                            if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<TcpOpenServer.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".PushNotNull(_wait_);
                        }
                        return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                    }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod _value3_ = default(AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpOpenServer.ServerAttribute,AutoCSer.Net.TcpOpenServer.MethodAttribute,AutoCSer.Net.TcpOpenServer.ServerSocketSender>.TcpMethod);
                    _value3_ = _value2_.SetMethod;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    set
                    {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value4_ = _value3_.Attribute;
                    if (_value4_ != null)
                    {
                    if (_value4_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpOpenServer.MethodAttribute _value4_ = _value3_.Attribute;
                    if (_value4_ != null)
                    {
                if (!(bool)_value4_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value3_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        TcpOpenServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@" _sendOnlyInputParameter_ = new TcpOpenServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value3_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.Parameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"
                        };
                        _TcpClient_.Sender.CallOnly(");
            _code_.Add(_value3_.MethodIdentityCommand);
            _code_.Add(@", ref _sendOnlyInputParameter_);");
            }
            _if_ = false;
                if (_value3_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.AutoWaitReturnValue _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue.Pop();
                        try
                        {
                            AutoCSer.Net.TcpOpenServer.ClientSocketSender _socket_ = _TcpClient_.Sender;
                            if (_socket_ != null)
                            {
                                TcpOpenServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new TcpOpenServer.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@"
                                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value3_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.Parameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"
                                };
                                AutoCSer.Net.TcpServer.ReturnType _returnType_ = _socket_.WaitCall(");
            _code_.Add(_value3_.MethodIdentityCommand);
            _code_.Add(@", ref _wait_, ref _inputParameter_);
                                if (_returnType_ == AutoCSer.Net.TcpServer.ReturnType.Success) return;
                                throw new Exception(_returnType_.ToString());
                            }
                        }
                        finally
                        {
                            if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue.PushNotNull(_wait_);
                        }
                        throw new Exception(AutoCSer.Net.TcpServer.ReturnType.ClientException.ToString());");
            }
            }
            _code_.Add(@"
                    }");
            }
                }
            _code_.Add(@"
                }");
            }
            }
            }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
            }");
            }
            _code_.Add(@"
        }");
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal partial class TcpStaticServer
    {
    internal partial class Generator
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.CSharp, _isOut_))
            {
                
            _if_ = false;
                if (!(bool)IsAllType)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            StringArray _PART_SERVERCALL_ = _code_;
            _code_ = new StringArray();
            _code_.Add(@"
        ");
            _code_.Add(TypeNameDefinition);
            _code_.Add(@"
        {
            internal static partial class TcpStaticServer
            {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]");
            _if_ = false;
                    if (_value2_.IsAsynchronousCallback)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public static void ");
            _code_.Add(_value2_.StaticMethodIndexName);
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"AutoCSer.Net.TcpInternalServer.ServerSocketSender _sender_, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"Func<AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = _value2_.MethodReturnType;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.FullName);
                    }
                }
            }
                }
            _code_.Add(@">, bool> _onReturn_)
                {
                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = Type;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@".");
            _code_.Add(_value3_.StaticMethodName);
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_sender_, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value2_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterRefName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"_onReturn_);");
            }
                }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                if (!(bool)_value2_.IsAsynchronousCallback)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public static ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = _value2_.MethodReturnType;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.FullName);
                    }
                }
            }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.StaticMethodIndexName);
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"AutoCSer.Net.TcpInternalServer.ServerSocketSender _sender_");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@")
                {");
            _if_ = false;
                    if (_value2_.MemberIndex != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsGetMember)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = Type;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.StaticPropertyName);
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter[]);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value4_ = _value2_.Method;
                    if (_value4_ != null)
                    {
                    _value3_ = _value4_.Parameters;
                    }
                }
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterName);
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@";");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsGetMember)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    return ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = Type;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.StaticPropertyName);
            _code_.Add(@";");
            }
            }
            _code_.Add(@"
");
            _if_ = false;
                if (_value2_.MemberIndex == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    return ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = Type;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@".");
            _code_.Add(_value3_.StaticMethodName);
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_sender_");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_ = _value2_.InputParameters;
                    if (_value4_ != null)
                    {
                    if (_value4_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value2_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterJoinRefName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@");");
            }
                }
            }
            _code_.Add(@"
                }");
            }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
            }
        }");
            _partCodes_["SERVERCALL"] = _code_.ToString();
            _code_ = _PART_SERVERCALL_;
            _code_.Add(_partCodes_["SERVERCALL"]);
            StringArray _PART_CLIENTCALL_ = _code_;
            _code_ = new StringArray();
            _code_.Add(@"
        /// <summary>
        /// TCP调用客户端
        /// </summary>
        public static partial class TcpCall
        {");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                    if (_value1_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
            /// <summary>
            /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.XmlDocument);
                    }
                }
            _code_.Add(@"
            /// </summary>");
            }
            _code_.Add(@"
            public ");
            _code_.Add(NoAccessTypeNameDefinition);
            _code_.Add(@"
            {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsSynchronousMethodIdentityCommand)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                private static readonly AutoCSer.Net.TcpServer.CommandInfo ");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _code_.Add(@" = new AutoCSer.Net.TcpServer.CommandInfo { Command = ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@" + ");
            _code_.Add(CommandStartIndex.ToString());
            _code_.Add(@", InputParameterIndex = ");
            _code_.Add(_value2_.InputParameterIndex.ToString());
            _if_ = false;
                    if (_value2_.IsJsonSerialize)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" , CommandFlags = AutoCSer.Net.TcpServer.CommandFlags.JsonSerialize");
            }
            _code_.Add(@", IsSendOnly = ");
            _code_.Add(_value2_.IsClientSendOnly.ToString());
            _code_.Add(@", TaskType = AutoCSer.Net.TcpServer.ClientTaskType.Synchronous");
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsVerifyMethod = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeInputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeInputParamter = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeOutputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeOutputParamter = true");
            }
            _code_.Add(@" };");
            }
            _code_.Add(@"
");
            _if_ = false;
                if (_value2_.MemberIndex == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                [System.Runtime.CompilerServices.MethodImpl(AutoCSer.MethodImpl.AggressiveInlining)]
                public static void ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@")
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                    {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                        ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    };");
            }
            _code_.Add(@"
                    ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ClientPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.TcpClient.Sender.CallOnly(");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");");
            }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsClientSynchronous)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.ReturnXmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <returns>");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.ReturnXmlDocument);
                    }
                }
            _code_.Add(@"</returns>");
            }
            _code_.Add(@"
                public static AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"AutoCSer.Net.TcpInternalServer.ClientSocketSender _sender_, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@")
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".Pop();
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = ");
            _if_ = false;
                if (!(bool)_value2_.IsVerifyMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ClientPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.TcpClient.Sender");
            }
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_sender_");
            }
            _code_.Add(@";
                        if (_socket_ != null)
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            };");
            }
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" _outputParameter_ = new ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRef)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value3_ = _value2_.ReturnInputParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                Ret = ");
            _code_.Add(_value3_.ParameterName);
            }
                }
            _code_.Add(@"
                            };
                            AutoCSer.Net.TcpServer.ReturnType _returnType_ = _socket_.WaitGet<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _code_.Add(@", ref _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@", ref _outputParameter_);");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRefOrOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = _outputParameter_.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnType_");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", Value = _outputParameter_.Return");
            }
            _code_.Add(@" };");
            }
            _if_ = false;
                if (_value2_.OutputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _socket_.WaitCall(");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _code_.Add(@", ref _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@") };");
            }
            _code_.Add(@"
                        }
                    }
                    finally
                    {
                        if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".PushNotNull(_wait_);
                    }");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                }");
            _if_ = false;
                    if (_value2_.IsClientTaskAsync)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
#if DOTNET2
#else
#if DOTNET4
#else");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.ReturnXmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <returns>");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.ReturnXmlDocument);
                    }
                }
            _code_.Add(@"</returns>");
            }
            _code_.Add(@"
                public static async System.Threading.Tasks.Task<AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@"> ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.TaskAsyncMethodName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"AutoCSer.Net.TcpInternalServer.ClientSocketSender _sender_, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterJoinName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@")
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = ");
            _if_ = false;
                if (!(bool)_value2_.IsVerifyMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ClientPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.TcpClient.Sender");
            }
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_sender_");
            }
            _code_.Add(@";
                    if (_socket_ != null)
                    {
                        AutoCSer.Net.TcpServer.TaskAsyncReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = new AutoCSer.Net.TcpServer.TaskAsyncReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@"();");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                        };");
            }
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.ReturnType _returnType_;");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" _outputParameter_ = new ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRef)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value3_ = _value2_.ReturnInputParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            Ret = ");
            _code_.Add(_value3_.ParameterName);
            }
                }
            _code_.Add(@"
                        };
                        if ((_returnType_ = _socket_.GetAsync<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _code_.Add(@", _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@", ref _outputParameter_)) == Net.TcpServer.ReturnType.Success)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _returnOutputParameter_ = await _wait_;");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsRefOrOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = _returnOutputParameter_.Value.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnOutputParameter_.Type");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", Value = _returnOutputParameter_.Value.Return");
            }
            _code_.Add(@" };
                        }
                        return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnType_ };");
            }
            _if_ = false;
                if (_value2_.OutputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        _returnType_ = _socket_.CallAsync(");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _code_.Add(@", _wait_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                        return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = _returnType_ == AutoCSer.Net.TcpServer.ReturnType.Success ? await _wait_ : _returnType_ };");
            }
            _code_.Add(@"
                    }");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@" = default(");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value6_ = _value5_.ParameterType;
                    if (_value6_ != null)
                    {
            _code_.Add(_value6_.FullName);
                    }
                }
            _code_.Add(@");");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                    return new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                }
#endif
#endif");
            }
            }
            _if_ = false;
                    if (_value2_.IsClientAsynchronous)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                private static readonly AutoCSer.Net.TcpServer.CommandInfo ");
            _code_.Add(_value2_.AsynchronousStaticMethodIdentityCommand);
            _code_.Add(@" = new AutoCSer.Net.TcpServer.CommandInfo { Command = ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@" + ");
            _code_.Add(CommandStartIndex.ToString());
            _code_.Add(@", InputParameterIndex = ");
            _code_.Add(_value2_.InputParameterIndex.ToString());
            _code_.Add(@", TaskType = ");
            _code_.Add(_value2_.ClientTask);
            _if_ = false;
                    if (_value2_.IsJsonSerialize)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" , CommandFlags = AutoCSer.Net.TcpServer.CommandFlags.JsonSerialize");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsKeepCallback = ");
            _code_.Add(_value2_.IsKeepCallback.ToString());
            }
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsVerifyMethod = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeInputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeInputParamter = true");
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeOutputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeOutputParamter = true");
            }
            _code_.Add(@" };");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value5_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@""">");
            _code_.Add(_value5_.XmlDocument);
            _code_.Add(@"</param>");
            }
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.ReturnXmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <param name=""_onReturn_"">");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.ReturnXmlDocument);
                    }
                }
            _code_.Add(@"</param>");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <returns>保持异步回调</returns>");
            }
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public static ");
            _code_.Add(_value2_.KeepCallbackType);
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"Action<AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@"> _onReturn_)
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    if (_onReturn_ == null) throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());
                    _onReturn_(new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">");
            }
            _code_.Add(@"{ Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired });");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    AutoCSer.Net.Callback<AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@"> _onOutput_ = ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ClientPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.TcpClient.GetCallback<");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@", ");
            }
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(_onReturn_);
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ClientPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.TcpClient.Sender;
                        if (_socket_ != null)
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            };");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            return _socket_.GetKeep<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.AsynchronousStaticMethodIdentityCommand);
            _code_.Add(@", ref _onOutput_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");");
            }
            _if_ = false;
                if (_value2_.IsKeepCallback == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            _socket_.Get<");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@", ");
            }
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">(");
            _code_.Add(_value2_.AsynchronousStaticMethodIdentityCommand);
            _code_.Add(@", ref _onOutput_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");");
            }
            _code_.Add(@"
                        }
                    }
                    finally
                    {
                        if (_onOutput_ != null)
                        {
                            AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _outputParameter_ = new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };
                            _onOutput_.Call(ref _outputParameter_);
                        }
                    }");
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    return null;");
            }
            }
            _code_.Add(@"
                }");
            }
            _if_ = false;
                if (!(bool)_value2_.MethodIsReturn)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                public static ");
            _code_.Add(_value2_.KeepCallbackType);
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterTypeRefName);
            _code_.Add(@" ");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"Action<AutoCSer.Net.TcpServer.ReturnValue> _onReturn_)
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    if (_onReturn_ == null) throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());
                    _onReturn_(new AutoCSer.Net.TcpServer.ReturnValue { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired });");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    try
                    {
                        AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ClientPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.TcpClient.Sender;
                        if (_socket_ != null)
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"
                            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.MethodParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
                            };");
            }
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            AutoCSer.Net.TcpServer.KeepCallback _keepCallback_ = _socket_.CallKeep(");
            _code_.Add(_value2_.AsynchronousStaticMethodIdentityCommand);
            _code_.Add(@", _onReturn_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                            _onReturn_ = null;
                            return _keepCallback_;");
            }
            _if_ = false;
                if (_value2_.IsKeepCallback == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            _socket_.Call(");
            _code_.Add(_value2_.AsynchronousStaticMethodIdentityCommand);
            _code_.Add(@", _onReturn_");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref _inputParameter_");
            }
            _code_.Add(@");
                            _onReturn_ = null;");
            }
            _code_.Add(@"
                        }
                    }
                    finally
                    {
                        if (_onReturn_ != null) _onReturn_(new AutoCSer.Net.TcpServer.ReturnValue { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException });
                    }");
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    return null;");
            }
            }
            _code_.Add(@"
                }");
            }
            }
            }
            }
            _code_.Add(@"
");
            _if_ = false;
                    if (_value2_.MemberIndex != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.XmlDocument != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.XmlDocument);
                    }
                }
            _code_.Add(@"
                /// </summary>");
            }
            _code_.Add(@"
                public static AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> ");
            _code_.Add(_value2_.PropertyName);
            _code_.Add(@"
                {
                    get
                    {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = AutoCSer.Net.TcpServer.ReturnType.VersionExpired };");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".Pop();
                        try
                        {
                            AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ClientPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.TcpClient.Sender;
                            if (_socket_ != null)
                            {
                                AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" _outputParameter_ = _socket_.WaitGet(");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _code_.Add(@", ref _wait_);
                                return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = _outputParameter_.Type, Value = _outputParameter_.Value.Return };
                            }
                        }
                        finally
                        {
                            if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value3_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value3_ = AutoParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@".PushNotNull(_wait_);
                        }
                        return new AutoCSer.Net.TcpServer.ReturnValue<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"> { Type = AutoCSer.Net.TcpServer.ReturnType.ClientException };");
            }
            _code_.Add(@"
                    }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value3_ = default(AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod);
                    _value3_ = _value2_.SetMethod;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    set
                    {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value4_ = _value3_.Attribute;
                    if (_value4_ != null)
                    {
                    if (_value4_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        throw new Exception(AutoCSer.Net.TcpServer.ReturnType.VersionExpired.ToString());");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value4_ = _value3_.Attribute;
                    if (_value4_ != null)
                    {
                if (!(bool)_value4_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value3_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value4_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value4_ = AutoParameter;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value4_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@" _sendOnlyInputParameter_ = new ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value4_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value4_ = AutoParameter;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value4_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@"
                        {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value3_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
            _code_.Add(@"
                            ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.Parameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"
                        };
                        ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value4_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value4_ = AutoParameter;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value4_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ClientPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.TcpClient.Sender.CallOnly(");
            _code_.Add(_value3_.StaticMethodIdentityCommand);
            _code_.Add(@", ref _sendOnlyInputParameter_);");
            }
            _if_ = false;
                if (_value3_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        AutoCSer.Net.TcpServer.AutoWaitReturnValue _wait_ = AutoCSer.Net.TcpServer.AutoWaitReturnValue.Pop();
                        try
                        {
                            AutoCSer.Net.TcpInternalServer.ClientSocketSender _socket_ = ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value4_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value4_ = AutoParameter;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value4_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ClientPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.TcpClient.Sender;
                            if (_socket_ != null)
                            {
                                ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value4_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value4_ = AutoParameter;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value4_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@" _inputParameter_ = new ");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value4_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value4_ = AutoParameter;
            _if_ = false;
                    if (_value4_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value4_.DefaultNamespace);
            }
                }
            _code_.Add(@".");
            _code_.Add(ParameterPart);
            _code_.Add(@"/**/.");
            _code_.Add(ServerName);
            _code_.Add(@"/**/.");
            _code_.Add(_value3_.InputParameterTypeName);
            _code_.Add(@"
                                {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value4_;
                    _value4_ = _value3_.InputParameters;
                    if (_value4_ != null)
                    {
                        int _loopIndex4_ = _loopIndex_, _loopCount4_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value4_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value5_ in _value4_)
                        {
            _code_.Add(@"
                                    ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.Parameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                    ");
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value6_ = _value5_.MethodParameter;
            _if_ = false;
                    if (_value6_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value6_.ParameterName);
            }
                }
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex4_;
                        _loopCount_ = _loopCount4_;
                    }
                }
            _code_.Add(@"
                                };
                                AutoCSer.Net.TcpServer.ReturnType _returnType_ = _socket_.WaitCall(");
            _code_.Add(_value3_.StaticMethodIdentityCommand);
            _code_.Add(@", ref _wait_, ref _inputParameter_);
                                if (_returnType_ == AutoCSer.Net.TcpServer.ReturnType.Success) return;
                                throw new Exception(_returnType_.ToString());
                            }
                        }
                        finally
                        {
                            if (_wait_ != null) AutoCSer.Net.TcpServer.AutoWaitReturnValue.PushNotNull(_wait_);
                        }
                        throw new Exception(AutoCSer.Net.TcpServer.ReturnType.ClientException.ToString());");
            }
            }
            _code_.Add(@"
                    }");
            }
                }
            _code_.Add(@"
                }");
            }
            }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
            }
        }");
            _partCodes_["CLIENTCALL"] = _code_.ToString();
            _code_ = _PART_CLIENTCALL_;
            _code_.Add(_partCodes_["CLIENTCALL"]);
            }
            _code_.Add(@"
");
            _if_ = false;
                    if (IsAllType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            StringArray _PART_SERVER_ = _code_;
            _code_ = new StringArray();
            _code_.Add(@"
        /// <summary>
        /// TCP调用服务端
        /// </summary>
        public partial class ");
            _code_.Add(ServerName);
            _code_.Add(@" : AutoCSer.Net.TcpInternalServer.Server
        {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.ServerAttribute _value1_ = ServiceAttribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsRememberCommand)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
            /// <summary>
            /// 命令序号记忆数据
            /// </summary>
            private static KeyValue<string, int>[] ");
            _code_.Add(RememberIdentityCommeandName);
            _code_.Add(@"()
            {
                KeyValue<string, int>[] names = new KeyValue<string, int>[");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.Length.ToString());
                    }
                }
            _code_.Add(@"];");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                names[");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@"].Set(@""");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.MethodKeyFullName);
                    }
                }
            _code_.Add(@""", ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@");");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                return names;
            }");
            }
            _code_.Add(@"
            /// <summary>
            /// TCP调用服务端
            /// </summary>
            /// <param name=""attribute"">TCP调用服务器端配置信息</param>
            /// <param name=""verify"">TCP验证实例</param>
            /// <param name=""log"">日志接口</param>
            /// <param name=""onCustomData"">自定义数据包处理</param>
            public ");
            _code_.Add(ServerName);
            _code_.Add(@"(AutoCSer.Net.TcpInternalServer.ServerAttribute attribute = null, Func<System.Net.Sockets.Socket, bool> verify = null, Action<SubArray<byte>> onCustomData = null, AutoCSer.Log.ILog log = null)
                : base(attribute ?? (attribute = AutoCSer.Net.TcpStaticServer.ServerAttribute.GetConfig(""");
            _code_.Add(ServerRegisterName);
            _code_.Add(@"""");
            _if_ = false;
                    if (TcpServerAttributeType != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", typeof(");
            _code_.Add(TcpServerAttributeType);
            _code_.Add(@")");
            }
            _code_.Add(@", true)), verify, onCustomData, log, ");
            _code_.Add(IsCallQueue ? "true" : "false");
            _code_.Add(@")
            {
                setCommandData(");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.Length.ToString());
                    }
                }
            _code_.Add(@");");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                setVerifyCommand(");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@");");
            }
            _if_ = false;
                if (!(bool)_value2_.IsVerifyMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                setCommand(");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@");");
            }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                if (attribute.IsAutoServer) Start();
            }
            /// <summary>
            /// 命令处理
            /// </summary>
            /// <param name=""index"">命令序号</param>
            /// <param name=""sender"">TCP 内部服务套接字数据发送</param>
            /// <param name=""data"">命令数据</param>
            public override void DoCommand(int index, AutoCSer.Net.TcpInternalServer.ServerSocketSender sender, ref SubArray<byte> data)
            {
                AutoCSer.Net.TcpServer.ReturnType returnType;
                switch (index - ");
            _code_.Add(CommandStartIndex.ToString());
            _code_.Add(@")
                {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    case ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@":");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsExpired)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        sender.Push(AutoCSer.Net.TcpServer.ReturnType.VersionExpired);");
            }
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.MethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsExpired)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        returnType = AutoCSer.Net.TcpServer.ReturnType.Unknown;");
            }
            _code_.Add(@"
                        try
                        {");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@" inputParameter = new ");
            _code_.Add(_value2_.InputParameterTypeName);
            _code_.Add(@"();
                            if (sender.DeSerialize(ref data, ref inputParameter");
            _if_ = false;
                    if (_value2_.IsSimpleSerializeInputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", true");
            }
            _code_.Add(@"))");
            }
            _code_.Add(@"
                            {");
            _if_ = false;
                    if (_value2_.IsAsynchronousCallback)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" outputParameter = new ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"();
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.TcpStaticServer.");
            _code_.Add(_value2_.StaticMethodIndexName);
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"sender.GetCallback<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@", ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">(");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _code_.Add(@", ref outputParameter));");
            }
            _if_ = false;
                if (!(bool)_value2_.MethodIsReturn)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.TcpStaticServer.");
            _code_.Add(_value2_.StaticMethodIndexName);
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender, ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            _code_.Add(@", ");
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"sender.GetCallback(");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _code_.Add(@"));");
            }
            }
            _if_ = false;
                if (!(bool)_value2_.IsAsynchronousCallback)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsMethodServerCall)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                (");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@"/**/.Pop() ?? new ");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@"()).Set(sender, ");
            _code_.Add(_value2_.ServerTask);
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ref inputParameter");
            }
            _code_.Add(@");");
            }
            _if_ = false;
                if (!(bool)_value2_.IsMethodServerCall)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@" _outputParameter_ = new ");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@"();");
            }
            }
            _code_.Add(@"
                                ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            _if_ = false;
                    if (_value2_.MemberIndex != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsGetMember)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.TcpStaticServer.");
            _code_.Add(_value2_.StaticMethodIndexName);
            _code_.Add(@"();");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsGetMember)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.TcpStaticServer.");
            _code_.Add(_value2_.StaticMethodIndexName);
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");");
            }
            }
            _if_ = false;
                if (_value2_.MemberIndex == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = _value2_.MethodType;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.FullName);
                    }
                }
            _code_.Add(@"/**/.TcpStaticServer.");
            _code_.Add(_value2_.StaticMethodIndexName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"sender");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"_outputParameter_.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterJoin);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");");
            }
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                if (");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@") sender.SetVerifyMethod();");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                _outputParameter_.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                _outputParameter_.");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            _code_.Add(@"
                                sender.Push(");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _code_.Add(@", ref _outputParameter_);");
            }
            _if_ = false;
                if (_value2_.OutputParameterIndex == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                sender.Push();");
            }
            }
            }
            }
            _code_.Add(@"
                                return;
                            }");
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            returnType = AutoCSer.Net.TcpServer.ReturnType.ServerDeSerializeError;");
            }
            }
            _code_.Add(@"
                        }
                        catch (Exception error)
                        {");
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            returnType = AutoCSer.Net.TcpServer.ReturnType.ServerException;");
            }
            _code_.Add(@"
                            sender.Log(error);
                        }");
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        sender.Push(returnType);");
            }
            }
            _code_.Add(@"
                        return;");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    default: return;
                }
            }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (!(bool)_value2_.IsAsynchronousCallback)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsMethodServerCall)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            sealed class ");
            _code_.Add(_value2_.MethodStreamName);
            _code_.Add(@" : AutoCSer.Net.TcpStaticServer.ServerCall<");
            _code_.Add(_value2_.MethodStreamName);
            _if_ = false;
                    if (_value2_.InputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(_value2_.InputParameterTypeName);
            }
            _code_.Add(@">
            {
                private void get(ref AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" value)
                {
                    try
                    {
                        ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            _if_ = false;
                    if (_value2_.MemberIndex != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsGetMember)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.TcpStaticServer.");
            _code_.Add(_value2_.StaticMethodIndexName);
            _code_.Add(@"();");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = _value2_.Method;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsGetMember)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.TcpStaticServer.");
            _code_.Add(_value2_.StaticMethodIndexName);
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(@"inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");");
            }
            }
            _code_.Add(@"
");
            _if_ = false;
                if (_value2_.MemberIndex == null)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value4_ = _value2_.MethodType;
                    if (_value4_ != null)
                    {
            _code_.Add(_value4_.FullName);
                    }
                }
            _code_.Add(@"/**/.TcpStaticServer.");
            _code_.Add(_value2_.StaticMethodIndexName);
            }
                }
            _code_.Add(@"(");
            _if_ = false;
                    if (_value2_.ClientParameterName != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"Sender");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@", ");
            }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.InputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                    if (_value5_.IsOut)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"value.Value.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.MethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"inputParameter.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.Parameter;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.ParameterJoin);
                    }
                }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");");
            }
            _code_.Add(@"
");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsVerifyMethod)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        if (");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@") Sender.SetVerifyMethod();");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterPair[] _value3_;
                    _value3_ = _value2_.OutputParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterPair _value4_ in _value3_)
                        {
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = _value4_.InputMethodParameter;
                    if (_value5_ != null)
                    {
                if (!(bool)_value5_.IsOut)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.Parameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        value.Value.");
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@" = inputParameter.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value5_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value5_ = _value4_.InputParameter;
            _if_ = false;
                    if (_value5_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value5_.ParameterName);
            }
                }
            _code_.Add(@";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                    if (_value2_.MethodIsReturn)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        value.Value.");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@" = ");
            _code_.Add(_value2_.ReturnName);
            _code_.Add(@";");
            }
            }
            _code_.Add(@"
                        value.Type = AutoCSer.Net.TcpServer.ReturnType.Success;
                    }
                    catch (Exception error)
                    {
                        value.Type = AutoCSer.Net.TcpServer.ReturnType.ServerException;
                        Sender.Log(error);
                    }
                }
                public override void Call()
                {
                    AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@" value = new AutoCSer.Net.TcpServer.ReturnValue");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"<");
            _code_.Add(_value2_.OutputParameterTypeName);
            _code_.Add(@">");
            }
            _code_.Add(@"();");
            _if_ = false;
                    if (_value2_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    if (Sender.IsSocket) get(ref value);");
            }
            _if_ = false;
                if (_value2_.IsClientSendOnly == 0)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    if (Sender.IsSocket)
                    {
                        get(ref value);
                        Sender.Push(CommandIndex");
            _if_ = false;
                    if (_value2_.OutputParameterIndex != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            }
            _code_.Add(@", ref value);
                    }");
            }
            _code_.Add(@"
                    push(this);
                }
            }");
            }
            }
            _code_.Add(@"
            private static readonly AutoCSer.Net.TcpServer.OutputInfo ");
            _code_.Add(_value2_.StaticMethodIdentityCommand);
            _code_.Add(@" = new AutoCSer.Net.TcpServer.OutputInfo { OutputParameterIndex = ");
            _code_.Add(_value2_.OutputParameterIndex.ToString());
            _if_ = false;
                    if (_value2_.IsKeepCallback != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsKeepCallback = ");
            _code_.Add(_value2_.IsKeepCallback.ToString());
            }
            _if_ = false;
                    if (_value2_.IsClientSendOnly != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsClientSendOnly = ");
            _code_.Add(_value2_.IsClientSendOnly.ToString());
            }
            _if_ = false;
                    if (_value2_.IsSimpleSerializeOutputParamter)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsSimpleSerializeOutputParamter = true");
            }
            _code_.Add(@" };");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterTypes[] _value1_;
                    _value1_ = ParameterTypes;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterTypes _value2_ in _value1_)
                        {
            _code_.Add(@"
            [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false");
            _if_ = false;
                if (!(bool)_value2_.IsSerializeReferenceMember)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsReferenceMember = false");
            }
            _code_.Add(@")]");
            _if_ = false;
                    if (_value2_.IsSerializeBox)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            [AutoCSer.Metadata.BoxSerialize]");
            }
            _code_.Add(@"
            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
            internal struct ");
            _code_.Add(_value2_.ParameterTypeName);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
                    if (_value3_.Type != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
#if NOJIT
                     : AutoCSer.Net.IReturnParameter
#else
                     : AutoCSer.Net.IReturnParameter<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@">
#endif");
            }
            _code_.Add(@"
            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.Parameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(@"
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.ParameterType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
                    if (_value3_.Type != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                [AutoCSer.Json.IgnoreMember]
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" Ret;
                [AutoCSer.IOS.Preserve(Conditional = true)]
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" Return
                {
                    get { return Ret; }
                    set { Ret = value; }
                }
#if NOJIT
                [AutoCSer.Metadata.Ignore]
                public object ReturnObject
                {
                    get { return Ret; }
                    set { Ret = (");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MethodReturnType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@")value; }
                }
#endif");
            }
            _code_.Add(@"
            }");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
        }");
            _partCodes_["SERVER"] = _code_.ToString();
            _code_ = _PART_SERVER_;
            _code_.Add(_partCodes_["SERVER"]);
            StringArray _PART_CLIENT_ = _code_;
            _code_ = new StringArray();
            _code_.Add(@"
        /// <summary>
        /// TCP调用客户端
        /// </summary>
        public class ");
            _code_.Add(ServerName);
            _code_.Add(@"
        {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.ServerAttribute _value1_ = ServiceAttribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsSegmentation)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod[] _value1_;
                    _value1_ = MethodIndexs;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsNullMethod)
                {
                    _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterTypes[] _value3_;
                    _value3_ = ParameterTypes;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterTypes _value4_ in _value3_)
                        {
            _code_.Add(@"
            [AutoCSer.BinarySerialize.Serialize(IsMemberMap = false");
            _if_ = false;
                if (!(bool)_value4_.IsSerializeReferenceMember)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", IsReferenceMember = false");
            }
            _code_.Add(@")]");
            _if_ = false;
                    if (_value4_.IsSerializeBox)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            [AutoCSer.Metadata.BoxSerialize]");
            }
            _code_.Add(@"
            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
            internal struct ");
            _code_.Add(_value4_.ParameterTypeName);
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.MethodReturnType;
                    if (_value5_ != null)
                    {
                    if (_value5_.Type != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
#if NOJIT
                     : AutoCSer.Net.IReturnParameter
#else
                     : AutoCSer.Net.IReturnParameter<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.MethodReturnType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@">
#endif");
            }
            _code_.Add(@"
            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value5_;
                    _value5_ = _value4_.Parameters;
                    if (_value5_ != null)
                    {
                        int _loopIndex5_ = _loopIndex_, _loopCount5_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value5_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value6_ in _value5_)
                        {
            _code_.Add(@"
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value7_ = _value6_.ParameterType;
                    if (_value7_ != null)
                    {
            _code_.Add(_value7_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value6_.ParameterName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex5_;
                        _loopCount_ = _loopCount5_;
                    }
                }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.MethodReturnType;
                    if (_value5_ != null)
                    {
                    if (_value5_.Type != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                [AutoCSer.Json.IgnoreMember]
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.MethodReturnType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@" Ret;
                [AutoCSer.IOS.Preserve(Conditional = true)]
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.MethodReturnType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@" Return
                {
                    get { return Ret; }
                    set { Ret = value; }
                }
#if NOJIT
                [AutoCSer.Metadata.Ignore]
                public object ReturnObject
                {
                    get { return Ret; }
                    set { Ret = (");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.MethodReturnType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@")value; }
                }
#endif");
            }
            _code_.Add(@"
            }");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            }
            _code_.Add(@"
            /// <summary>
            /// TCP 静态调用客户端参数
            /// </summary>
            public sealed class ClientConfig
            {
                /// <summary>
                /// TCP 内部服务配置
                /// </summary>
                public AutoCSer.Net.TcpInternalServer.ServerAttribute ServerAttribute;
                /// <summary>
                /// 自定义数据包处理
                /// </summary>
                public Action<AutoCSer.SubArray<byte>> OnCustomData;
                /// <summary>
                /// 日志接口
                /// </summary>
                public AutoCSer.Log.ILog Log;
                /// <summary>
                /// 验证委托
                /// </summary>
                public Func<AutoCSer.Net.TcpInternalServer.ClientSocketSender, bool> VerifyMethod");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value1_ = default(AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod);
                    _value1_ = TimeVerifyMethod;
            _if_ = false;
                    if (_value1_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" = verify");
            }
                }
            _code_.Add(@";
            }
            /// <summary>
            /// 默认客户端TCP调用
            /// </summary>
            public static readonly AutoCSer.Net.TcpStaticServer.Client TcpClient;");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod _value1_ = default(AutoCSer.CodeGenerator.TemplateGenerator.TcpServer.Generator<AutoCSer.Net.TcpStaticServer.ServerAttribute,AutoCSer.Net.TcpStaticServer.MethodAttribute,AutoCSer.Net.TcpInternalServer.ServerSocketSender>.TcpMethod);
                    _value1_ = TimeVerifyMethod;
            _if_ = false;
                    if (_value1_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            private static bool verify(AutoCSer.Net.TcpInternalServer.ClientSocketSender sender)
            {
                return AutoCSer.Net.TcpInternalServer.TimeVerifyClient.Verify(");
            _code_.Add(TimeVerifyClientType);
            _code_.Add(@"/**/.verify, sender, TcpClient);
            }");
            }
                }
            _code_.Add(@"
            static ");
            _code_.Add(ServerName);
            _code_.Add(@"()
            {
                ClientConfig config = (ClientConfig)AutoCSer.Config.Loader.GetObject(typeof(ClientConfig)) ?? new ClientConfig();
                if (config.ServerAttribute == null)
                {");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.ServerAttribute _value1_ = ServiceAttribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsSegmentation)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    config.ServerAttribute = AutoCSer.Net.TcpStaticServer.ServerAttribute.GetConfig(""");
            _code_.Add(ServerName);
            _code_.Add(@"""");
            _if_ = false;
                    if (TcpServerAttributeType != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", typeof(");
            _code_.Add(TcpServerAttributeType);
            _code_.Add(@")");
            }
            _code_.Add(@", false);");
            }
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.ServerAttribute _value1_ = ServiceAttribute;
                    if (_value1_ != null)
                    {
                if (!(bool)_value1_.IsSegmentation)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    config.ServerAttribute = AutoCSer.Net.TcpStaticServer.ServerAttribute.GetConfig(""");
            _code_.Add(ServerName);
            _code_.Add(@"""");
            _if_ = false;
                    if (TcpServerAttributeType != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", typeof(");
            _code_.Add(TcpServerAttributeType);
            _code_.Add(@")");
            }
            _code_.Add(@");");
            }
            _code_.Add(@"
                }");
            _if_ = false;
                {
                    AutoCSer.Net.TcpStaticServer.ServerAttribute _value1_ = ServiceAttribute;
                    if (_value1_ != null)
                    {
                if (!(bool)_value1_.IsSegmentation)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                if (config.ServerAttribute.IsServer) AutoCSer.Log.Pub.Log.Add(AutoCSer.Log.LogType.Warn | AutoCSer.Log.LogType.Debug, null, ""请确认 ");
            _code_.Add(ServerName);
            _code_.Add(@" 服务器端是否本地调用"", AutoCSer.Log.CacheType.None);");
            }
            _code_.Add(@"
                TcpClient = new AutoCSer.Net.TcpStaticServer.Client(config.ServerAttribute, config.OnCustomData, config.Log, config.VerifyMethod);
            }
        }");
            _partCodes_["CLIENT"] = _code_.ToString();
            _code_ = _PART_CLIENT_;
            _code_.Add(_partCodes_["CLIENT"]);
            }
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal partial class WebCall
    {
    internal partial class Generator
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.CSharp, _isOut_))
            {
                
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod[] _value1_ = Methods;
                    if (_value1_ != null)
                    {
                    if (_value1_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
        /// <summary>
        /// WEB服务器
        /// </summary>
        public partial class WebServer : AutoCSer.Net.HttpDomainServer.ViewServer<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = SessionType;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">
        {
            protected override string[] calls
            {
                get
                {
                    string[] names = new string[");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod[] _value1_ = Methods;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.Length.ToString());
                    }
                }
            _code_.Add(@"];");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod[] _value1_;
                    _value1_ = Methods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod _value2_ in _value1_)
                        {
            _code_.Add(@"
                    names[");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@"] = """);
            _code_.Add(_value2_.CallName);
            _code_.Add(@""";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    return names;
                }
            }");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod[] _value1_;
                    _value1_ = Methods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsAjaxLoad)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            private static readonly AutoCSer.WebView.CallMethodInfo ");
            _code_.Add(_value2_.CallMethodInfo);
            _code_.Add(@" = new AutoCSer.WebView.CallMethodInfo { MethodIndex = ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@", MaxMemoryStreamSize = (AutoCSer.SubBuffer.Size)");
            _code_.Add(_value2_.MaxMemoryStreamSize.ToString());
                {
                    AutoCSer.WebView.CallMethodAttribute _value3_ = default(AutoCSer.WebView.CallMethodAttribute);
                    _value3_ = _value2_.Attribute;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", MaxPostDataSize = ");
            _code_.Add(_value3_.MaxPostDataSize.ToString());
            _code_.Add(@", IsOnlyPost = ");
            _code_.Add(_value3_.IsOnlyPost ? "true" : "false");
            }
                }
            _code_.Add(@" };");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
            protected override void call(int callIndex, AutoCSer.Net.Http.SocketBase socket)
            {
                switch (callIndex)
                {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod[] _value1_;
                    _value1_ = Methods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod _value2_ in _value1_)
                        {
            _code_.Add(@"
                    case ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@":");
            _if_ = false;
                    if (_value2_.IsAjaxLoad)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebCallAsynchronousMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" loader = ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebCallAsynchronousMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.Pop() ?? new ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebCallAsynchronousMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"();
                        ajaxLoader(loader, socket);
                        loader.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"();");
            }
            _if_ = false;
                if (!(bool)_value2_.IsAjaxLoad)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsAsynchronous)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        loadAsynchronous(socket,");
            _if_ = false;
                    if (_value2_.IsPoolType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebCallAsynchronousMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.Pop() ??");
            }
            _code_.Add(@" new ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebCallAsynchronousMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"(), ");
            _code_.Add(_value2_.CallMethodInfo);
            _code_.Add(@");");
            }
            _if_ = false;
                if (!(bool)_value2_.IsAsynchronous)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                        load(socket,");
            _if_ = false;
                    if (_value2_.IsPoolType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebCallMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.Pop() ??");
            }
            _code_.Add(@" new ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebCallMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"(), ");
            _code_.Add(_value2_.CallMethodInfo);
            _code_.Add(@");");
            }
            }
            _code_.Add(@"
                        return;");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                }
            }
            protected override bool call(AutoCSer.WebView.CallBase call, ref AutoCSer.UnmanagedStream responseStream)
            {
                switch (call.CallMethodIndex)
                {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod[] _value1_;
                    _value1_ = Methods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsAjaxLoad)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                if (!(bool)_value2_.IsAsynchronous)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    case ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@":
                        {");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.ParameterTypeName);
            _code_.Add(@" parameter = new ");
            _code_.Add(_value2_.ParameterTypeName);
            _code_.Add(@"();");
            _if_ = false;
                {
                    AutoCSer.WebView.CallMethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsFirstParameter)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsFristParameterValueType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            if (call.ParseParameter(ref parameter");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value3_ = _value2_.FristParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@".");
            _code_.Add(_value3_.ValueTypeParameterName);
            }
                }
            _code_.Add(@"))");
            }
            _if_ = false;
                if (!(bool)_value2_.IsFristParameterValueType)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                if (call.ParseParameterAny(ref parameter");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value3_ = _value2_.FristParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@".");
            _code_.Add(_value3_.ParameterName);
            }
                }
            _code_.Add(@"))");
            }
            }
            _if_ = false;
                {
                    AutoCSer.WebView.CallMethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsFirstParameter)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    if (call.ParseParameter(ref parameter))");
            }
            }
            _code_.Add(@"
                                    {
                                        ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebCallMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" value = (");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebCallMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@")call;
                                        value.");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _code_.Add(@"parameter.");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(_value4_.ParameterJoin);
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");
                                        repsonseCall(value, ref responseStream);
                                        return true;
                                    }
                        }");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        return false;");
            }
            }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    default: return false;
                }
            }
            protected override bool call(AutoCSer.WebView.CallBase call)
            {
                switch (call.CallMethodIndex)
                {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod[] _value1_;
                    _value1_ = Methods;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebCall.Generator.CallMethod _value2_ in _value1_)
                        {
            _if_ = false;
                if (!(bool)_value2_.IsAjaxLoad)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsAsynchronous)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    case ");
            _code_.Add(_value2_.MethodIndex.ToString());
            _code_.Add(@":
                        {");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                            ");
            _code_.Add(_value2_.ParameterTypeName);
            _code_.Add(@" parameter = new ");
            _code_.Add(_value2_.ParameterTypeName);
            _code_.Add(@"();");
            _if_ = false;
                {
                    AutoCSer.WebView.CallMethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsFirstParameter)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsFristParameterValueType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                            if (call.ParseParameter(ref parameter");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value3_ = _value2_.FristParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@".");
            _code_.Add(_value3_.ValueTypeParameterName);
            }
                }
            _code_.Add(@"))");
            }
            _if_ = false;
                if (!(bool)_value2_.IsFristParameterValueType)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                                if (call.ParseParameterAny(ref parameter");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter);
                    _value3_ = _value2_.FristParameter;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@".");
            _code_.Add(_value3_.ParameterName);
            }
                }
            _code_.Add(@"))");
            }
            }
            _if_ = false;
                {
                    AutoCSer.WebView.CallMethodAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                if (!(bool)_value3_.IsFirstParameter)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                                    if (call.ParseParameter(ref parameter))");
            }
            }
            _code_.Add(@"
                                    {
                                        ((");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebCallMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@")call).");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value3_ = default(AutoCSer.CodeGenerator.Metadata.MethodIndex);
                    _value3_ = _value2_.Method;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.MethodName);
            }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(_value4_.ParameterRef);
            _code_.Add(@"parameter.");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(_value4_.ParameterJoin);
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@");
                                        return true;
                                    }
                        }");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_ = _value2_.MethodParameters;
                    if (_value3_ != null)
                    {
                    if (_value3_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                        return false;");
            }
            }
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    default: return false;
                }
            }");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameterTypeNames[] _value1_;
                    _value1_ = ParameterTypes;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameterTypeNames _value2_ in _value1_)
                        {
            _if_ = false;
                    if (_value2_.IsSerializeBox)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            [AutoCSer.Metadata.BoxSerialize]");
            }
            _code_.Add(@"
            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
            struct ");
            _code_.Add(_value2_.ParameterTypeName);
            _code_.Add(@"
            {");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value3_;
                    _value3_ = _value2_.Parameters;
                    if (_value3_ != null)
                    {
                        int _loopIndex3_ = _loopIndex_, _loopCount3_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value3_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value4_ in _value3_)
                        {
            _code_.Add(@"
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value5_ = _value4_.ParameterType;
                    if (_value5_ != null)
                    {
            _code_.Add(_value5_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value4_.ParameterName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex3_;
                        _loopCount_ = _loopCount3_;
                    }
                }
            _code_.Add(@"
            }");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
        }");
            }
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal abstract partial class WebPath
    {
    internal partial class JavaScript
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.JavaScript, _isOut_))
            {
                
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                {
                    System.Type _value2_ = _value1_.Type;
                    if (_value2_ != null)
                    {
            _code_.Add(_value2_.Name);
                    }
                }
                    }
                }
            _code_.Add(@":function(Id)
	{");
                {
                    AutoCSer.LeftArray<AutoCSer.CodeGenerator.TemplateGenerator.WebPath.Generator<AutoCSer.CodeGenerator.TemplateGenerator.WebPath.JavaScript>.PathMember> _value1_;
                    _value1_ = PathMembers;
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _getCount_(_value1_);
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebPath.Generator<AutoCSer.CodeGenerator.TemplateGenerator.WebPath.JavaScript>.PathMember _value2_ in _value1_)
                        {
            _code_.Add(@"
	this.");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value3_ = _value2_.Member;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.MemberName);
                    }
                }
            _code_.Add(@"='");
            _code_.Add(_value2_.Path);
            _if_ = false;
                    if (_value2_.IsIdentity)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsHash)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"#!");
            }
            _code_.Add(_value2_.OtherQuery);
            _code_.Add(_value2_.QueryName);
            _code_.Add(@"=");
            }
            _code_.Add(@"'");
            _if_ = false;
                    if (_value2_.IsIdentity)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"+Id");
            }
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
	},
");
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal abstract partial class WebPath
    {
    internal partial class TypeScript
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.TypeScript, _isOut_))
            {
                
            _code_.Add(@"    export class ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                {
                    System.Type _value2_ = _value1_.Type;
                    if (_value2_ != null)
                    {
            _code_.Add(_value2_.Name);
                    }
                }
                    }
                }
            _code_.Add(@" {");
                {
                    AutoCSer.LeftArray<AutoCSer.CodeGenerator.TemplateGenerator.WebPath.Generator<AutoCSer.CodeGenerator.TemplateGenerator.WebPath.TypeScript>.PathMember> _value1_;
                    _value1_ = PathMembers;
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _getCount_(_value1_);
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebPath.Generator<AutoCSer.CodeGenerator.TemplateGenerator.WebPath.TypeScript>.PathMember _value2_ in _value1_)
                        {
            _code_.Add(@"
        ");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value3_ = _value2_.Member;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.MemberName);
                    }
                }
            _code_.Add(@": string;");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
        constructor(Id: number) {");
                {
                    AutoCSer.LeftArray<AutoCSer.CodeGenerator.TemplateGenerator.WebPath.Generator<AutoCSer.CodeGenerator.TemplateGenerator.WebPath.TypeScript>.PathMember> _value1_;
                    _value1_ = PathMembers;
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _getCount_(_value1_);
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebPath.Generator<AutoCSer.CodeGenerator.TemplateGenerator.WebPath.TypeScript>.PathMember _value2_ in _value1_)
                        {
            _code_.Add(@"
            this.");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex _value3_ = _value2_.Member;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.MemberName);
                    }
                }
            _code_.Add(@" = '");
            _code_.Add(_value2_.Path);
            _if_ = false;
                    if (_value2_.IsIdentity)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _if_ = false;
                    if (_value2_.IsHash)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"#!");
            }
            _code_.Add(_value2_.OtherQuery);
            _code_.Add(_value2_.QueryName);
            _code_.Add(@"=");
            }
            _code_.Add(@"'");
            _if_ = false;
                    if (_value2_.IsIdentity)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@" + Id");
            }
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
        }
    }
");
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal partial class WebView
    {
    internal partial class Generator
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.CSharp, _isOut_))
            {
                
            _if_ = false;
                if (!(bool)IsServer)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
        ");
            _code_.Add(TypeNameDefinition);
            _code_.Add(@"
        {");
            _if_ = false;
                {
                    AutoCSer.WebView.ViewAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsPage)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _if_ = false;
                if (!(bool)IsPoolType)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            private static byte[][] ");
            _code_.Add(Htmls);
            _code_.Add(@";
            private static readonly object ");
            _code_.Add(HtmlLock);
            _code_.Add(@" = new object();");
            }
            _code_.Add(@"
            protected override bool page(ref AutoCSer.WebView.Response _html_)
            {
                byte[][] htmls;");
            _if_ = false;
                if (!(bool)IsPoolType)
                {
                    _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                htmls = loadHtml(@""");
            _code_.Add(HtmlFile);
            _code_.Add(@""", ");
            _code_.Add(HtmlCount.ToString());
            _code_.Add(@", ");
            _code_.Add(HtmlLock);
            _code_.Add(@", ref ");
            _code_.Add(Htmls);
            _code_.Add(@");");
            }
            _if_ = false;
                    if (IsPoolType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                htmls = loadHtml(@""");
            _code_.Add(HtmlFile);
            _code_.Add(@""", ");
            _code_.Add(HtmlCount.ToString());
            _code_.Add(@");");
            }
            _code_.Add(@"
                if (htmls != null)
                {
                    ");
            _code_.Add(PageCode);
            _code_.Add(@"
                    return true;
                }
                return false;
            }");
            }
            _code_.Add(@"
");
            _if_ = false;
                {
                    AutoCSer.WebView.ViewAttribute _value1_ = Attribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.IsAjax)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
            protected unsafe override void ajax(CharStream _js_)
            {
                ");
            _code_.Add(AjaxCode);
            _code_.Add(@"
            }");
            }
            _code_.Add(@"
");
            _if_ = false;
                    if (LoadMethod != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto)]
            private struct WebViewQuery
            {");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value1_ = LoadMethod;
                    if (_value1_ != null)
                    {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value2_ = _value1_.Parameters;
                    if (_value2_ != null)
                    {
                    if (_value2_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                [AutoCSer.Json.ParseMember(IsDefault = true)]");
            }
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value1_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter[]);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value2_ = LoadMethod;
                    if (_value2_ != null)
                    {
                    _value1_ = _value2_.Parameters;
                    }
                }
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value2_ in _value1_)
                        {
            _if_ = false;
                    if (_value2_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
            _code_.Add(_value2_.XmlDocument);
            _code_.Add(@"
                /// </summary>");
            }
            _code_.Add(@"
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.ParameterType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.ParameterName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = QueryMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _if_ = false;
                    if (_value2_.XmlDocument != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                /// <summary>
                /// ");
            _code_.Add(_value2_.XmlDocument);
            _code_.Add(@"
                /// </summary>");
            }
            _code_.Add(@"
                public ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.MemberType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@" ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
            }");
            _if_ = false;
                {
                    AutoCSer.WebView.ViewAttribute _value1_ = LoadAttribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.QueryName != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
            /// <summary>
            /// 查询参数
            /// </summary>
            private WebViewQuery ");
                {
                    AutoCSer.WebView.ViewAttribute _value1_ = default(AutoCSer.WebView.ViewAttribute);
                    _value1_ = LoadAttribute;
            _if_ = false;
                    if (_value1_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value1_.QueryName);
            }
                }
            _code_.Add(@";");
            }
            _code_.Add(@"
            /// <summary>
            /// WEB视图加载
            /// </summary>
            /// <returns>是否成功</returns>
            protected override bool loadView()
            {
                if (base.loadView())
                {");
            _if_ = false;
                {
                    AutoCSer.WebView.ViewAttribute _value1_ = LoadAttribute;
                    if (_value1_ != null)
                    {
                    if (_value1_.QueryName != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
                {
                    AutoCSer.WebView.ViewAttribute _value1_ = default(AutoCSer.WebView.ViewAttribute);
                    _value1_ = LoadAttribute;
            _if_ = false;
                    if (_value1_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
                    ");
            _code_.Add(_value1_.QueryName);
            }
                }
            _code_.Add(@"= default(WebViewQuery);
                    if (ParseParameter(ref ");
                {
                    AutoCSer.WebView.ViewAttribute _value1_ = default(AutoCSer.WebView.ViewAttribute);
                    _value1_ = LoadAttribute;
            _if_ = false;
                    if (_value1_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value1_.QueryName);
            }
                }
            _code_.Add(@"))
                    {");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = QueryMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _code_.Add(@"
                        ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@" = ");
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = default(AutoCSer.WebView.ViewAttribute);
                    _value3_ = LoadAttribute;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.QueryName);
            }
                }
            _code_.Add(@".");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                        return loadView(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value1_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter[]);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value2_ = LoadMethod;
                    if (_value2_ != null)
                    {
                    _value1_ = _value2_.Parameters;
                    }
                }
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value2_ in _value1_)
                        {
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = default(AutoCSer.WebView.ViewAttribute);
                    _value3_ = LoadAttribute;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(_value3_.QueryName);
            }
                }
            _code_.Add(@".");
            _code_.Add(_value2_.ParameterJoinName);
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@");
                    }");
            }
            _if_ = false;
                {
                    AutoCSer.WebView.ViewAttribute _value1_ = LoadAttribute;
                    if (_value1_ != null)
                    {
                if (_value1_.QueryName == null)
                {
                    _if_ = true;
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"
                    WebViewQuery query = new WebViewQuery();
                    if (ParseParameter(ref query))
                    {");
                {
                    AutoCSer.CodeGenerator.Metadata.MemberIndex[] _value1_;
                    _value1_ = QueryMembers;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MemberIndex _value2_ in _value1_)
                        {
            _code_.Add(@"
                        ");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@" = query.");
            _code_.Add(_value2_.MemberName);
            _code_.Add(@";");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                        return loadView(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value1_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter[]);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value2_ = LoadMethod;
                    if (_value2_ != null)
                    {
                    _value1_ = _value2_.Parameters;
                    }
                }
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value2_ in _value1_)
                        {
            _code_.Add(@"query.");
            _code_.Add(_value2_.ParameterJoinName);
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@");
                    }");
            }
            _code_.Add(@"
                }
                return false;
            }");
            }
            _code_.Add(@"
        }");
            }
            _code_.Add(@"
");
            _if_ = false;
                    if (IsServer)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
        /// <summary>
        /// WEB服务器
        /// </summary>
        public partial class WebServer : AutoCSer.Net.HttpDomainServer.ViewServer<");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = SessionType;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.FullName);
                    }
                }
            _code_.Add(@">
        {

            protected override KeyValue<string[], string[]> rewrites
            {
                get
                {
                    int count = ");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebView.Generator.ViewType[] _value1_ = Views;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.Length.ToString());
                    }
                }
            _code_.Add(@" + ");
            _code_.Add(RewriteViewCount.ToString());
            _code_.Add(@" * 2;
                    string[] names = new string[count];
                    string[] views = new string[count];");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebView.Generator.ViewType[] _value1_;
                    _value1_ = Views;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebView.Generator.ViewType _value2_ in _value1_)
                        {
            _code_.Add(@"
                    names[--count] = """);
            _code_.Add(_value2_.RewritePath);
            _code_.Add(@""";
                    views[count] = """);
            _code_.Add(_value2_.CallName);
            _code_.Add(@""";");
            _if_ = false;
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.RewritePath != null)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    names[--count] = @""");
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.RewritePath);
                    }
                }
            _if_ = false;
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsRewriteHtml)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@".html");
            }
            _code_.Add(@""";
                    views[count] = """);
            _code_.Add(_value2_.CallName);
            _code_.Add(@""";
                    names[--count] = @""");
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.RewritePath);
                    }
                }
            _code_.Add(@".js"";
                    views[count] = """);
            _code_.Add(_value2_.RewriteJs);
            _code_.Add(@""";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    return new KeyValue<string[], string[]>(names, views);
                }
            }");
            _if_ = false;
                    if (ViewPageCount != 0)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            protected override string[] viewRewrites
            {
                get
                {
                    string[] names = new string[");
            _code_.Add(ViewPageCount.ToString());
            _code_.Add(@"];");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebView.Generator.ViewType[] _value1_;
                    _value1_ = Views;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebView.Generator.ViewType _value2_ in _value1_)
                        {
            _if_ = false;
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsPage)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    names[");
            _code_.Add(_value2_.PageIndex.ToString());
            _code_.Add(@"] = """);
            _code_.Add(_value2_.RewritePath);
            _code_.Add(@""";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    return names;
                }
            }
            protected override string[] views
            {
                get
                {
                    string[] names = new string[");
            _code_.Add(ViewPageCount.ToString());
            _code_.Add(@"];");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebView.Generator.ViewType[] _value1_;
                    _value1_ = Views;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebView.Generator.ViewType _value2_ in _value1_)
                        {
            _if_ = false;
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsPage)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    names[");
            _code_.Add(_value2_.PageIndex.ToString());
            _code_.Add(@"] = """);
            _code_.Add(_value2_.CallName);
            _code_.Add(@""";");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                    return names;
                }
            }
            protected override void request(int viewIndex, AutoCSer.Net.Http.SocketBase socket)
            {
                switch (viewIndex)
                {");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebView.Generator.ViewType[] _value1_;
                    _value1_ = Views;
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.TemplateGenerator.WebView.Generator.ViewType _value2_ in _value1_)
                        {
            _if_ = false;
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = _value2_.Attribute;
                    if (_value3_ != null)
                    {
                    if (_value3_.IsPage)
                    {
                        _if_ = true;
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"
                    case ");
            _code_.Add(_value2_.PageIndex.ToString());
            _code_.Add(@": loadPage(socket, ");
            _if_ = false;
                    if (IsPoolType)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebViewMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"/**/.Pop() ?? ");
            }
            _code_.Add(@"new ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value3_ = _value2_.WebViewMethodType;
                    if (_value3_ != null)
                    {
            _code_.Add(_value3_.FullName);
                    }
                }
            _code_.Add(@"()");
                {
                    AutoCSer.WebView.ViewAttribute _value3_ = default(AutoCSer.WebView.ViewAttribute);
                    _value3_ = _value2_.Attribute;
            _if_ = false;
                    if (_value3_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@", ");
            _code_.Add(_value3_.IsAsynchronous ? "true" : "false");
            }
                }
            _code_.Add(@"); return;");
            }
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"
                }
            }");
            }
            _code_.Add(@"
            /// <summary>
            /// 网站生成配置
            /// </summary>");
                {
                    AutoCSer.CodeGenerator.ProjectParameter _value1_ = default(AutoCSer.CodeGenerator.ProjectParameter);
                    _value1_ = AutoParameter;
            _if_ = false;
                    if (_value1_ != null)
                    {
                        _if_ = true;
                }
            if (_if_)
            {
            _code_.Add(@"
            internal new static readonly ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value2_ = _value1_.WebConfigType;
                    if (_value2_ != null)
                    {
            _code_.Add(_value2_.FullName);
                    }
                }
            _code_.Add(@" WebConfig = new ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value2_ = _value1_.WebConfigType;
                    if (_value2_ != null)
                    {
            _code_.Add(_value2_.FullName);
                    }
                }
            _code_.Add(@"();");
            }
                }
            _code_.Add(@"
            /// <summary>
            /// 网站生成配置
            /// </summary>
            /// <returns>网站生成配置</returns>
            protected override AutoCSer.WebView.Config getWebConfig() { return WebConfig; }
        }");
            }
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
namespace AutoCSer.CodeGenerator.TemplateGenerator
{
    internal partial class WebView
    {
    internal partial class TypeScript
    {
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="isOut">是否输出代码</param>
        protected override void create(bool _isOut_)
        {
            if (outStart(AutoCSer.CodeGenerator.CodeLanguage.TypeScript, _isOut_))
            {
                
            _code_.Add(@"		static ");
                {
                    AutoCSer.CodeGenerator.Metadata.ExtensionType _value1_ = Type;
                    if (_value1_ != null)
                    {
                {
                    System.Type _value2_ = _value1_.Type;
                    if (_value2_ != null)
                    {
            _code_.Add(_value2_.Name);
                    }
                }
                    }
                }
            _code_.Add(@"(");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value1_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter[]);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value2_ = LoadMethod;
                    if (_value2_ != null)
                    {
                    _value1_ = _value2_.Parameters;
                    }
                }
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value2_ in _value1_)
                        {
            _code_.Add(_value2_.ParameterName);
            _code_.Add(@",");
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@"Callback = null) {
			AutoCSer.Pub.GetAjaxGet()('");
                {
                    AutoCSer.CodeGenerator.TemplateGenerator.WebView.Generator.ViewType _value1_ = View;
                    if (_value1_ != null)
                    {
            _code_.Add(_value1_.CallName);
                    }
                }
            _code_.Add(@"',");
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value1_ = LoadMethod;
                    if (_value1_ != null)
                    {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value2_ = _value1_.Parameters;
                    if (_value2_ != null)
                    {
                    if (_value2_.Length != 0)
                    {
                        _if_ = true;
                    }
                }
                    }
                }
                }
            if (_if_)
            {
            _code_.Add(@"{");
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value1_ = default(AutoCSer.CodeGenerator.Metadata.MethodParameter[]);
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value2_ = LoadMethod;
                    if (_value2_ != null)
                    {
                    _value1_ = _value2_.Parameters;
                    }
                }
                    if (_value1_ != null)
                    {
                        int _loopIndex1_ = _loopIndex_, _loopCount1_ = _loopCount_;
                        _loopIndex_ = 0;
                        _loopCount_ = _value1_.Length;
                        foreach (AutoCSer.CodeGenerator.Metadata.MethodParameter _value2_ in _value1_)
                        {
            _code_.Add(_value2_.ParameterName);
            _code_.Add(@": ");
            _code_.Add(_value2_.ParameterJoinName);
                            ++_loopIndex_;
                        }
                        _loopIndex_ = _loopIndex1_;
                        _loopCount_ = _loopCount1_;
                    }
                }
            _code_.Add(@" }");
            }
            _if_ = false;
                {
                    AutoCSer.CodeGenerator.Metadata.MethodIndex _value1_ = LoadMethod;
                    if (_value1_ != null)
                    {
                {
                    AutoCSer.CodeGenerator.Metadata.MethodParameter[] _value2_ = _value1_.Parameters;
                    if (_value2_ != null)
                    {
                if (_value2_.Length == 0)
                {
                    _if_ = true;
                }
                    }
                }
                    }
                }
            if (_if_)
            {
            _code_.Add(@"null");
            }
            _code_.Add(@", Callback);	
		}");
                if (_isOut_) outEnd();
            }
        }
    }
    }
}
#endif