﻿//<auto-generated>
namespace $safeprojectname$.Views
{
    using System.Reflection;
    using $safeprojectname$.Common;
    using $safeprojectname$.Framework;
    using $safeprojectname$.Presenters;
    using $safeprojectname$.ViewModels;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Navigation;

    /// <summary>
    /// 画面の基底クラス
    /// </summary>
    public class PageBase : Page
    {
        #region Privates

        /// <summary>
        /// Presenter
        /// </summary>
        private IPresenter presenter;

        /// <summary>
        /// NavigationHelper
        /// </summary>
        private NavigationHelper navigationHelper;

        #endregion //Privates

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PageBase()
        {
            this.navigationHelper = new NavigationHelper(this);
        }

        /// <summary>
        /// この画面の Presenter
        /// </summary>
        public virtual IPresenter PagePresenter
        {
            get { return this.presenter; }
        }

        /// <summary>
        /// NavigationHelper は、ナビゲーションおよびプロセス継続時間管理を
        /// 支援するために、各ページで使用します。
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        #region NavigationHelper の登録

        /// <summary>
        /// この画面への遷移時の処理
        /// </summary>
        /// <param name="e">イベント引数</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            // MainViewModel が空の場合はデータを読み込みます
            if (!ViewModelLocator.Get<MainViewModel>().IsLoaded)
            {
                await MainPresenter.Instance.LoadAsync();
            }

            this.presenter = PresenterLocator.Get(this.GetType());
            this.presenter.GetType().GetRuntimeProperty("Page").SetValue(this.presenter, this);
            this.presenter.Initialize();

            navigationHelper.OnNavigatedTo(e);
        }

        /// <summary>
        /// この画面から離れる時の処理
        /// </summary>
        /// <param name="e">イベント引数</param>
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);

            if (e.SourcePageType == this.GetType())
            {
                // 中断時の処理
                return;
            }

            this.presenter.Discard();
        }

        #endregion
    }
}
