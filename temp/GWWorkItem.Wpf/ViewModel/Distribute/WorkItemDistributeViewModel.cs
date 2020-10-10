using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWWorkItem.Wpf
{
    public class WorkItemDistributeViewModel : BaseDialogViewModel
    {
        #region 私有字段

        /// <summary>
        /// 第一项（选中全部）
        /// </summary>
        private readonly WorkItemDistributePerson _firstItem;

        #endregion

        #region 公共属性

        /// <summary>
        /// 分配人员名单
        /// </summary>
        public ObservableCollection<WorkItemDistributePerson> Items { get; set; } = new ObservableCollection<WorkItemDistributePerson>();

        #endregion

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public WorkItemDistributeViewModel()
        {
            _firstItem = new WorkItemDistributePerson { IsCheck = null, Content = "全部", CheckCommand = new RelayCommand(CheckAll) };
            Items.Add(_firstItem);
        }

        #endregion

        #region 公共方法

        /// <summary>
        /// 添加项
        /// </summary>
        /// <param name="content">内容</param>
        public void AddItem(string content)
        {
            Items.Add(new WorkItemDistributePerson { IsCheck = false, Content = content, CheckCommand = new RelayCommand(CheckItem), Id = 10 });
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 选择全部
        /// </summary>
        private void CheckAll()
        {
            var checkState = _firstItem.IsCheck.HasValue && _firstItem.IsCheck.Value;

            foreach (var item in Items)
            {
                item.IsCheck = checkState;
            }
        }

        /// <summary>
        /// 选择项
        /// </summary>
        private void CheckItem()
        {
            var checkAll = true;
            foreach (var item in Items)
            {
                if (item.IsCheck.Value)
                {
                    checkAll = true;
                    break;
                }
            }

            if (checkAll)
            {
                _firstItem.IsCheck = true;
            }
        }

        #endregion

    }
}
