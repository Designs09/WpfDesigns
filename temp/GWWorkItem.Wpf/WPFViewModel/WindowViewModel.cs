using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GWWorkItem.Wpf
{
    public class WindowViewModel : BaseViewModel
    {
        public static WindowViewModel Instance = new WindowViewModel();

        #region 公共属性

        /// <summary>
        /// 当前页面
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.TodoItem;

        /// <summary>
        /// 可见
        /// </summary>
        public bool IsVisible { get; set; } = true;

        #endregion

        #region 命令

        /// <summary>
        /// 切换页面命令
        /// </summary>
        public ICommand SwitchPageCommand { get; set; }

        /// <summary>
        /// 搜索命令
        /// </summary>
        public ICommand SearchCommand { get; set; }

        #endregion

        #region 构造函数
        
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public WindowViewModel()
        {
            SearchCommand = new RelayCommand(Search);
            SwitchPageCommand = new RelayParameterizedCommand(SwitchPage);
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 切换页面
        /// </summary>
        /// <param name="parameter"></param>
        private void SwitchPage(object parameter)
            => CurrentPage = (ApplicationPage)parameter;

        /// <summary>
        /// 搜索
        /// </summary>
        private void Search()
        {
            UIManager.ShowMessage($"搜索中...");
        }

        #endregion
    }
}
