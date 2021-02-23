using System;
using System.IO;
using System.Windows;
using System.Windows.Data;
using Vlc.DotNet.Wpf;

namespace VlcPlayer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string Url =
            //"http://14.116.252.58:8090/hls/b6dcad87611ee3cc1867051ead6968f7.flv?token=9d14281f63d35140c953ecdf2954cf50";
            //@"C:\Users\Ganwei_RD-09\Desktop\test\8f0795240ecd31274c064ab6c22b2054.mp4";
            "rtsp://10.144.21.70:554/hls/b6dcad87611ee3cc1867051ead6968f7?token=630bdee14bb4b8e6b584dc9784f7163e";

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var appPath = AppDomain.CurrentDomain.BaseDirectory;
            VlcContext.LibVlcDllsPath = appPath + @"VLC\";
            //Set the vlc plugins directory path
            VlcContext.LibVlcPluginsPath = appPath + @"plugins\";

            //Set the startup options
            VlcContext.StartupOptions.IgnoreConfig = true;
            VlcContext.StartupOptions.LogOptions.LogInFile = false;
            VlcContext.StartupOptions.LogOptions.ShowLoggerConsole = false;
            VlcContext.StartupOptions.LogOptions.Verbosity = VlcLogVerbosities.None;

            //Initialize the VlcContext
            VlcContext.Initialize();

            VlcControl myVlcControl = new VlcControl();
            // 创建绑定，绑定Image
            Binding bing = new Binding();
            bing.Source = myVlcControl;
            bing.Path = new PropertyPath("VideoSource");
            img.SetBinding(Image.SourceProperty, bing);

            //流媒体播放

            var media = new LocationMedia("udp://@:ip:port");

            myVlcControl.Play(media);

            //本地播放

            myVlcControl.Play(new PathMedia(添加本地视频路径));

            //VlcContext.CloseAll();


            //try
            //{
            //    var vlcLibDirectory = new DirectoryInfo(System.IO.Path.Combine(Environment.CurrentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));

            //    var options = new string[] 
            //    {
            //        // VLC options can be given here. Please refer to the VLC command line documentation.
            //        "--file-logging", "-vvv", "--logfile=Logs.log",
            //    };

            //    this.VlcPlayer.SourceProvider.CreatePlayer(vlcLibDirectory, options);

            //    // Load libvlc libraries and initializes stuff. It is important that the options (if you want to pass any) and lib directory are given before calling this method.
            //    this.VlcPlayer.SourceProvider.MediaPlayer.Play(new Uri(Url));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
