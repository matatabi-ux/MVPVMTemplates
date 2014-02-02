namespace $safeprojectname$.Views
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices.WindowsRuntime;
    using $safeprojectname$.Common;
    using $safeprojectname$.Presenters;
    using Windows.Foundation;
    using Windows.Foundation.Collections;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Controls.Primitives;
    using Windows.UI.Xaml.Data;
    using Windows.UI.Xaml.Input;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Navigation;

    /// <summary>
    /// $fileinputname$ 画面
    /// </summary>
    public sealed partial class $fileinputname$ : PageBase, IView<$fileinputname$Presenter>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public $fileinputname$()
            : base()
        {
            this.InitializeComponent();
        }

        #region IView<TPresenter>

        /// <summary>
        /// この画面の Presenter
        /// </summary>
        public $fileinputname$Presenter Presenter
        {
            get { return this.PagePresenter as $fileinputname$Presenter; }
        }

        #endregion //IView<TPresenter>
    }
}
