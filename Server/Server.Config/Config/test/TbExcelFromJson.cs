//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{


public sealed partial class TbExcelFromJson
{
    private readonly Dictionary<int, test.ExcelFromJson> _dataMap;
    private readonly List<test.ExcelFromJson> _dataList;
    
    public TbExcelFromJson(JsonElement _json)
    {
        _dataMap = new Dictionary<int, test.ExcelFromJson>();
        _dataList = new List<test.ExcelFromJson>();
        
        foreach(JsonElement _row in _json.EnumerateArray())
        {
            var _v = test.ExcelFromJson.DeserializeExcelFromJson(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.X4, _v);
        }
        PostInit();
    }

    public Dictionary<int, test.ExcelFromJson> DataMap => _dataMap;
    public List<test.ExcelFromJson> DataList => _dataList;

    public test.ExcelFromJson GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.ExcelFromJson Get(int key) => _dataMap[key];
    public test.ExcelFromJson this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    

    partial void PostInit();
    partial void PostResolve();
}

}