﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

namespace Lib;

/// <summary>
/// 读取分析配置文件
/// </summary>
public static class CfgHelp
{
    private static string GetPath(string file)
    {
        return File.ReadAllText(Path.Combine(AppContext.BaseDirectory, file));
    }

    /// <summary>
    /// 读取json配置文件,转化为dynamic 动态类型对象.
    /// </summary>
    /// <param name="json">json文件路径.相对于AppContext.BaseDirectory.</param>
    public static dynamic ReadJson(string json)
    {
        string txt = GetPath(json);
        return SerializeHelp.JSONToDynamic(txt);
    }

    /// <summary>
    /// 读取ini文件,返回字典对象
    /// ini文件格式:#开头视为注释忽略. key=value,等号分开的键值对,前后的空格去除,每行只能有一个设置
    /// </summary>
    /// <param name="ini"></param>
    /// <returns></returns>
    public static Dictionary<string, object> Readini(string ini)
    {
        string txt = GetPath(ini);
        Dictionary<string, object> obj = new();
        string[] kvarr = txt.Split(Environment.NewLine);
        foreach (var item in kvarr)
        {
            if (item.StartsWith('#')) continue;
            string[] kv = item.Split('=');
            if (kv.Length != 2) continue;
            obj.Add(kv[0], kv[1]);
        }
        return obj;
    }
}
