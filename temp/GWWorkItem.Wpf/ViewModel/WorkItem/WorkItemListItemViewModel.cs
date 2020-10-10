using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GWWorkItem.Wpf
{
    /// <summary>
    /// 工单
    /// </summary>
    public class WorkItemListItemViewModel : BaseViewModel
    {
        #region 公共属性

        /// <summary>
        /// 设备名
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// 告警类型
        /// </summary>
        public string AlarmType { get; set; }

        /// <summary>
        /// 工单类型
        /// </summary>
        public WorkItemType Type { get; set; } 

        /// <summary>
        /// 是否折叠
        /// </summary>
        public bool Collapsed { get; set; } = true;

        /// <summary>
        /// 工单名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        public WorkItemPriority Priority { get; set; }

        /// <summary>
        /// 工单生成时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 处理人
        /// </summary>
        public List<string> Handlers { get; set; }

        #endregion

        #region 等待标识

        /// <summary>
        /// 分配中
        /// </summary>
        public bool Distributing { get; set; }

        /// <summary>
        /// 误报中
        /// </summary>
        public bool Misinfoing { get; set; }

        /// <summary>
        /// 重新分配中
        /// </summary>
        public bool Redistributing { get; set; }

        /// <summary>
        /// 审批通过中
        /// </summary>
        public bool ExamPassing { get; set; }

        /// <summary>
        /// 重启工单中
        /// </summary>
        public bool Restarting { get; set; }

        #endregion

        #region 公共命令

        /// <summary>
        /// 展开命令
        /// </summary>
        public ICommand ExpandCommand { get; set; }

        /// <summary>
        /// 分配命令
        /// </summary>
        public ICommand DistributeCommand { get; set; }

        /// <summary>
        /// 误报命令
        /// </summary>
        public ICommand MisinfoCommand { get; set; }

        /// <summary>
        /// 重新分配命令
        /// </summary>
        public ICommand RedistributeCommand { get; set; }

        /// <summary>
        /// 审批通过命令
        /// </summary>
        public ICommand ExamPassCommand { get; set; }

        /// <summary>
        /// 重启工单命令
        /// </summary>
        public ICommand RestartCommand { get; set; }

        /// <summary>
        /// 查看图片命令
        /// </summary>
        public ICommand CheckPictureCommand { get; set; }

        #endregion

        #region 构造函数

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public WorkItemListItemViewModel()
        {
            ExpandCommand = new RelayCommand(() => Collapsed ^= true);
            DistributeCommand = new RelayCommand(async () => await DistributeAsync());
            MisinfoCommand = new RelayCommand(async () => await MisinfoAsync());
            RedistributeCommand = new RelayCommand(async () => await RedistributeAsync());
            ExamPassCommand = new RelayCommand(async () => await ExamPassAsync());
            RestartCommand = new RelayCommand(async () => await RestartAsync());
            CheckPictureCommand = new RelayCommand(async () => await CheckPictureAsync());
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 分配工单
        /// </summary>
        /// <returns></returns>
        private async Task DistributeAsync()
        {
            await RunCommandAsync(() => Distributing, async () =>
            {
                await Task.Delay(500);
                await UIManager.ShowDistributeDialogAsync(this);
            });
        }

        /// <summary>
        /// 误报
        /// </summary>
        /// <returns></returns>
        private async Task MisinfoAsync()
        {
            await RunCommandAsync(() => Misinfoing, async () =>
            {
                await Task.Delay(500);
                await UIManager.ShowMessageAsync("误报完成");
            });
        }

        /// <summary>
        /// 重新分配
        /// </summary>
        /// <returns></returns>
        private async Task RedistributeAsync()
        {
            await RunCommandAsync(() => Redistributing, async () =>
            {
                await Task.Delay(500);
                await UIManager.ShowDistributeDialogAsync(this);
            });
        }

        /// <summary>
        /// 审核通过
        /// </summary>
        /// <returns></returns>
        private async Task ExamPassAsync()
        {
            await RunCommandAsync(() => ExamPassing, async () =>
            {
                await Task.Delay(500);
                await UIManager.ShowMessageAsync("审核通过完成");
            });
        }

        /// <summary>
        /// 重启工单
        /// </summary>
        /// <returns></returns>
        private async Task RestartAsync()
        {
            await RunCommandAsync(() => Restarting, async () =>
            {
                await Task.Delay(500);
                await UIManager.ShowMessageAsync("重启工单完成");
            });
        }

        /// <summary>
        /// 查看图片
        /// </summary>
        /// <returns></returns>
        private async Task CheckPictureAsync()
        {
            UIManager.ShowMessageAsync("请查看图片");

            await Task.CompletedTask;
        }

        #endregion
    }
}
