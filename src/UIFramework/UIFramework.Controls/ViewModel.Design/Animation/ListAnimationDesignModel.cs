using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFramework.Controls
{
    public class ListAnimationDesignModel : ListAnimationViewModel
    {
        public static ListAnimationDesignModel Instance = new ListAnimationDesignModel();

        public ListAnimationDesignModel()
        {
            Items = new System.Collections.ObjectModel.ObservableCollection<ListAnimationItemViewModel>
            {
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
                new ListAnimationItemViewModel(),
            };
        }
    }
}
