﻿using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
using System.Windows.Shapes;

namespace Fasetto.Word
{
    /// <summary>
    /// LoginPage.xaml 的交互逻辑
    /// </summary>
    public partial class RegisterPage : BasePage<RegisterViewModel>, IHasPassword
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public RegisterPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        public RegisterPage(RegisterViewModel viewModel) : base(viewModel)
        {
            InitializeComponent();
        }

        #endregion

        /// <summary>
        /// Secure password for the login page
        /// </summary>
        public SecureString SecurePassword => PasswordText.SecurePassword;
    }
}
