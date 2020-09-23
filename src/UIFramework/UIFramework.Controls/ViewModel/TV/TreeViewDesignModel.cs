using System.Collections.ObjectModel;
using UIFramework.Controls.ViewModel.TV;
using UIFramework.Core;

namespace UIFramework.Controls
{
    public class TreeViewDesignModel : BaseViewModel
    {
        public static TreeViewDesignModel Instance = new TreeViewDesignModel();

        public ObservableCollection<TreeViewItemModel> Items { get; set; }

        public TreeViewDesignModel()
        {
            var item = new TreeViewItemModel
            {
                Items = new ObservableCollection<TreeViewItemModel>
                {
                    new TreeViewItemModel
                    {
                        Items = new ObservableCollection<TreeViewItemModel>
                        {
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                        },

                        Name = "福州公交公司",
                    },
                    new TreeViewItemModel
                    {
                        Items = new ObservableCollection<TreeViewItemModel>
                        {
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                        },

                        Name = "厦门公交公司",
                    },
                    new TreeViewItemModel
                    {
                        Items = new ObservableCollection<TreeViewItemModel>
                        {
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                            new TreeViewItemModel { Name = "闽A12345"},
                        },

                        Name = "泉州公交公司",
                    },

                },

                Name = "交通运输中心",
            };

            Items = new ObservableCollection<TreeViewItemModel>();
            Items.Add(item);
        }
    }
}
