## 介绍
+ 有赞开放平台C#版本SDK，v1.0.0

## 环境

```
.NET 4.0+
依赖System.Net.Http异步网络API
```

## 引用包
```
引用：System.Net.Http.dll
引用：open_sdk_csharp.dll

using YZOpenSDK;
```

## 如何使用？（参考README.md）
### 调用kdt.item.add接口

```
Auth auth = new Sign("${app_id}", "${app_secret}");
YZClient yzClient = new DefaultYZClient(auth);
Dictionary<string, object> dict = new System.Collections.Generic.Dictionary<string, object>();
dict.Add("title", "aaaaa");
dict.Add("price", 1.0);
dict.Add("post_fee", 1.0);

List<KeyValuePair<string, string>> files = new List<KeyValuePair<string, string>>();
files.Add(new KeyValuePair<string, string>("images[]", "/xx/xx/1.jpg"));

var result = yzClient.Invoke("kdt.item.add", "1.0.0", "post", dict, files);
Console.WriteLine(result);
```

### 调用kdt.items.onsale.get接口

```
Auth auth = new Token("xxx");
var result = yzClient.Invoke("kdt.items.onsale.get", "1.0.0", "get", dict, null);
Console.WriteLine(result);
```
