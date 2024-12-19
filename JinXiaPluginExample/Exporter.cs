
using Plugger;
using System.Composition;
using System.Reflection;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;

namespace JinXiaPluginExample
{
    [Export(typeof(IPlugger))]
    public class Exporter : IPlugger
    {
        public string Id { get; set; } = "示例插件";
        public string Name { get; set; } = "示例插件";
        public string Author { get; set; } = "官方_纵码过河山";
        public string Description { get; set; } = "仅用于提供示例";
        public PlugInType PlugInType { get; set; } = PlugInType.Other;
        public string IconPath { get; set; } = "/JinXiaPluginExample;component/示例.png";
        public Version Version { get; set; } = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        /// 窗口
        /// </summary>
        private Window1 window { get; set; }

        /// <summary>
        /// 打开
        /// </summary>
        public void Open()
        {
            if (window == null)
            {
                window = new Window1();
                window.Closed += Window_Closed;
            }
            window.Show();
            window.Activate();
        }
        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closed(object sender, EventArgs e)
        {
            window = null;
        }

        /// <summary>
        /// 关闭
        /// </summary>
        public void Close()
        {
            if (window != null)
                window.Close();
        }

        ///// <summary>
        ///// 插件是否有设置
        ///// </summary>
        //public bool HasSetting { get; set; } = true;

        ///// <summary>
        ///// 显示插件内设置
        ///// </summary>
        //public void ShowSetting()
        //{
        //    if (window == null)
        //    {
        //        window = new Window1();
        //        window.Closed += Window_Closed;
        //    }
        //    window.ShowSetting();
        //}


        ///// <summary>
        ///// 更新插件时保留文件列表（相对路径）
        ///// </summary>
        //List<string> KeepFiles => new List<string>(){ "appsettings.json" };
    }

}
