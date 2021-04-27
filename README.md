MyWebViewDemo
-----
This is a C# Sample to use Microsoft Edge Webview2<br>

```

using Microsoft.Web.WebView2.Core;
public Form1()
{
    InitializeComponent();
    this.Resize += new System.EventHandler(this.Form_Resize);
    webView.NavigationStarting += EnsureHttps;
    InitializeAsync();
}

async void InitializeAsync()
{
    await webView.EnsureCoreWebView2Async(null);
}

```
Reference:
https://developer.microsoft.com/zh-tw/microsoft-edge/webview2/

Installation
------------
```
git clone MyWebViewDemo https://github.com/michaelfangtw/MyWebViewDemo.git
```

Git Notes
------------
```
d:
cd D:\git\MyRabbitMQ
git init
git add .
git status
git commit -m "first commit"
rem MyCodeFirstLab
git remote add origin https://github.com/michaelfangtw/MyWebViewDemo..git
rem origin =remote repos
rem master =local repos
git push -u origin master
```

Usage
------------
Open /src/MyWebViewDemo..sln via Visual Studio 2019

Issues
-------
Found a bug? Create an issue on GitHub.


For transparency and insight into the release cycle, releases will be numbered with the follow format:

`<major>.<minor>.<patch>`

And constructed with the following guidelines:

* Breaking backwards compatibility bumps the major (無法向前相容)
* New additions without breaking backwards compatibility bumps the minor (可向前相容的功能新增)
* Bug fixes and misc changes bump the patch (修正Bug)

For more information on semantic versioning, please visit http://semver.org/.

License
-------

Copyright (c) 2018 [Michael Fang](http://funtech.tw)  
Licensed under the MIT License.










