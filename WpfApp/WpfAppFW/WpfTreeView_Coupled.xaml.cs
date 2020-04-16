using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace WpfAppFW
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class WpfTreeView_Coupled : Window
    {
        #region Constructor
        public WpfTreeView_Coupled()
        {
            InitializeComponent();
        }
        #endregion

        #region On Loaded
        /// <summary>
        /// When the Application first opens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var drive in Directory.GetLogicalDrives())
            {
                //Create new TreeViewItem
                var item = new TreeViewItem()
                {
                    //Set the header
                    Header = drive,
                    //And the full path
                    Tag = drive,
                };

                //Add a dummy item
                item.Items.Add(null);

                //Listen out for item being expanded
                item.Expanded += Folder_Expanded;

                //Add it to the main tree-view
                FolderView.Items.Add(item);
            }

        }
        #endregion

        #region Folder Expand

        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            #region Initial Checks
            var item = (TreeViewItem)sender;

            // If the item only contains the dummy data
            if (item.Items.Count != 1 || item.Items[0] != null)
                return;
            // Clear dummy item
            item.Items.Clear();

            // Get full path
            var fullPath = (string)item.Tag;
            #endregion

            #region Get folders
            // Create a blank list for directories
            var directories = new List<string>();

            // Try and get directories from the folder
            // Ignoring any issues doing so
            try
            {
                var dirs = Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                    directories.AddRange(dirs);
            }
            catch { }

            // For each directory...
            directories.ForEach(directoryPath =>
            {
                // Create directory item
                var subItem = new TreeViewItem()
                {
                    // Set the header as the folder name
                    Header = DirectoryStructure.GetFileFolderName(directoryPath),
                    // And tag as full path
                    Tag = directoryPath,
                };

                // Add dummy item so we can expand folder
                subItem.Items.Add(null);

                // Handle expanding
                subItem.Expanded += Folder_Expanded;

                // Add this item to the parent
                item.Items.Add(subItem);
            });
            #endregion

            #region Get files
            // Create a blank list for files
            var files = new List<string>();

            // Try and get files from the folder
            // Ignoring any issues doing so
            try
            {
                var fs = Directory.GetFiles(fullPath);
                if (fs.Length > 0)
                    files.AddRange(fs);
            }
            catch { }

            // For each files...
            files.ForEach(filePath =>
            {
                // Create file item
                var subItem = new TreeViewItem()
                {
                    // Set the header as the file name
                    Header = DirectoryStructure.GetFileFolderName(filePath),
                    // And tag as full path
                    Tag = filePath,
                };

                // Add this item to the parent
                item.Items.Add(subItem);
            });
            #endregion
        }

        #endregion
    }
}
