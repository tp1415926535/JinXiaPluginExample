
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
        public string Id { get; set; } = "ʾ�����";
        public string Name { get; set; } = "ʾ�����";
        public string Author { get; set; } = "�ٷ�_�������ɽ";
        public string Description { get; set; } = "�������ṩʾ��";
        public PlugInType PlugInType { get; set; } = PlugInType.Other;
        public string IconPath { get; set; } = "/JinXiaPluginExample;component/ʾ��.png";
        public Version Version { get; set; } = Assembly.GetExecutingAssembly().GetName().Version;

        /// <summary>
        /// ����
        /// </summary>
        private Window1 window { get; set; }

        /// <summary>
        /// ��
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
        /// ����ر��¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closed(object sender, EventArgs e)
        {
            window = null;
        }

        /// <summary>
        /// �ر�
        /// </summary>
        public void Close()
        {
            if (window != null)
                window.Close();
        }

        ///// <summary>
        ///// ����Ƿ�������
        ///// </summary>
        //public bool HasSetting { get; set; } = true;

        ///// <summary>
        ///// ��ʾ���������
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
        ///// ���²��ʱ�����ļ��б����·����
        ///// </summary>
        //List<string> KeepFiles => new List<string>(){ "appsettings.json" };
    }

}
