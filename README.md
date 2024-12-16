# 锦匣插件示例

[锦匣工具箱](https://github.com/tp1415926535/JinXiaToolBox) 插件开发示例规范

发布到文件夹或debug后，压缩文件夹成`zip`或`rar`，拖入锦匣程序主窗口即可自动安装


为了方便开发调试，可以先将输出类型改为`Windows应用程序`，并添加`app.xaml`
```xml
<Application x:Class="JinXiaPluginExample.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             StartupUri="MainWindow.xaml">
    <Application.Resources>

    </Application.Resources>
</Application>
```
以及对应的的`app.xaml.cs`
```csharp
using System.Windows;

namespace JinXiaPluginExample
{
    public partial class App : Application
    {
        public App()
        {
            Exporter exporter = new Exporter();
        }
    }
}
```
