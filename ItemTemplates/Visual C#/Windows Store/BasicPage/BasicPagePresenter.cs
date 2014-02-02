namespace $safeprojectname$.Presenters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using $safeprojectname$.ViewModels;
    using $safeprojectname$.Views;

    /// <summary>
    /// $fileinputname$ 画面の Presenter
    /// </summary>
    public class $safeitemname$ : PagePresenterBase<$fileinputname$, $fileinputname$ViewModel>, IPresenter<$fileinputname$, $fileinputname$ViewModel>
    {
        #region IPresenter<TView, TViewModel>

        /// <summary>
        /// View
        /// </summary>
        public $fileinputname$ View
        {
            get
            {
                return this.Page as $fileinputname$;
            }

            set
            {
                this.Page = value;
            }
        }

        /// <summary>
        /// ViewModel
        /// </summary>
        public $fileinputname$ViewModel ViewModel
        {
            get
            {
                return this.PageViewModel as $fileinputname$ViewModel;
            }

            set
            {
                this.PageViewModel = value;
            }
        }

        #endregion //IPresenter<TView, TViewModel>

        #region NavigationHelper

        /// <summary>
        /// 状態読み込み処理
        /// </summary>
        /// <param name="sender">イベント発行者</param>
        /// <param name="e">イベント引数</param>
        protected override void OnLoadState(object sender, Common.LoadStateEventArgs e)
        {
            base.OnLoadState(sender, e);

            if (e.PageState != null && e.PageState.ContainsKey(this.ViewModel.GetType().Name))
            {
                this.ViewModel = e.PageState[this.ViewModel.GetType().Name] as $fileinputname$ViewModel;
            }

            this.View.DataContext = this.ViewModel;
        }

        /// <summary>
        /// 状態保存処理
        /// </summary>
        /// <param name="sender">イベント発行者</param>
        /// <param name="e">イベント引数</param>
        protected override void OnSaveState(object sender, Common.SaveStateEventArgs e)
        {
            e.PageState[this.ViewModel.GetType().Name] = this.ViewModel;

            base.OnSaveState(sender, e);
        }

        #endregion //NavigationHelper
    }
}
