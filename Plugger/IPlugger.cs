using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Plugger
{
    /// <summary>
    /// 插件接口
    /// </summary>
    public interface IPlugger
    {
        /// <summary>
        /// 插件唯一Id
        /// </summary>
        string Id { get; set; }
        /// <summary>
        /// 插件名
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// 作者名
        /// </summary>
        string Author { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        Version Version { get; set; }
        /// <summary>
        /// 介绍
        /// </summary>
        string Description => string.Empty;
        /// <summary>
        /// 相关链接
        /// </summary>
        string Link => string.Empty;
        /// <summary>
        /// 图标路径（相对路径）
        /// </summary>
        string IconPath => string.Empty;
        /// <summary>
        /// 分类
        /// </summary>
        PlugInType PlugInType => PlugInType.Other;
        /// <summary>
        /// 打开方法
        /// </summary>
        /// <returns></returns>
        void Open();
        /// <summary>
        /// 关闭方法
        /// </summary>
        void Close();

        /// <summary>
        /// 是否有设置页面
        /// </summary>
        bool HasSetting => false;

        /// <summary>
        /// 显示设置方法
        /// </summary>
        void ShowSetting() { }

        /// <summary>
        /// 更新插件时保留文件列表（相对路径）
        /// </summary>
        List<string> KeepFiles => new List<string>();

        /// <summary>
        /// 更新插件时保留文件夹列表（相对路径）
        /// </summary>
        List<string> KeepFolders => new List<string>();
    }

    /// <summary>
    /// 插件类型
    /// </summary>
    public enum PlugInType
    {
        /// <summary>
        /// 未设置
        /// </summary>
        [Description("未设置")]
        None,
        /// <summary>
        /// 系统
        /// </summary>
        [Description("系统")]
        System,
        /// <summary>
        /// 媒体
        /// </summary>
        [Description("媒体")]
        Media,
        /// <summary>
        /// 网络
        /// </summary>
        [Description("网络")]
        Network,
        /// <summary>
        /// 生活
        /// </summary>
        [Description("生活")]
        Life,
        /// <summary>
        /// 自动化
        /// </summary>
        [Description("自动")]
        Automation,
        /// <summary>
        /// 教育
        /// </summary>
        [Description("教育")]
        Education,
        /// <summary>
        /// 商业
        /// </summary>
        [Description("商业")]
        Business,
        /// <summary>
        /// 开发
        /// </summary>
        [Description("开发")]
        Development,
        /// <summary>
        /// 安全
        /// </summary>
        [Description("安全")]
        Security,
        /// <summary>
        /// 游戏
        /// </summary>
        [Description("游戏")]
        Gaming,
        /// <summary>
        /// 数据
        /// </summary>
        [Description("数据")]
        Database,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other,
    }
}
