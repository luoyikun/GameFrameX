//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;
using Server.Config.Core;


namespace cfg.test
{
public sealed partial class SepBean1 :  BeanBase 
{
    public SepBean1(JsonElement _json) 
    {
        A = _json.GetProperty("a").GetInt32();
        B = _json.GetProperty("b").GetInt32();
        C = _json.GetProperty("c").GetString();
        PostInit();
    }

    public SepBean1(int a, int b, string c ) 
    {
        this.A = a;
        this.B = b;
        this.C = c;
        PostInit();
    }

    public static SepBean1 DeserializeSepBean1(JsonElement _json)
    {
        return new test.SepBean1(_json);
    }

    public int A { get; private set; }
    public int B { get; private set; }
    public string C { get; private set; }

    public const int __ID__ = -1534339393;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "A:" + A + ","
        + "B:" + B + ","
        + "C:" + C + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
