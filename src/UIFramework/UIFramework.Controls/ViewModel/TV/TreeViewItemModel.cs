﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFramework.Controls.ViewModel.TV
{
    public class TreeViewItemModel
    {
        public ObservableCollection<TreeViewItemModel> Items { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
