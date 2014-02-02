﻿//<auto-generated>
namespace $safeprojectname$.Framework
{
    using $safeprojectname$.ViewModels;

    /// <summary>
    /// PageViewModel 管理クラス
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// 指定した Viewmodel を取得する
        /// </summary>
        /// <typeparam name="TViewModel">取得する PageViewModel の型</typeparam>
        /// <param name="key">キー</param>
        /// <returns>PageViewModel</returns>
        public static TViewModel Get<TViewModel>(string key = null) where TViewModel : ViewModelBase
        {
            if (string.IsNullOrEmpty(key) && !ModuleContainer.Instance.IsRegistered<TViewModel>())
            {
                ModuleContainer.Instance.Register<TViewModel>();
            }
            else if (!string.IsNullOrEmpty(key) && !ModuleContainer.Instance.IsRegistered<TViewModel>(key))
            {
                ModuleContainer.Instance.Register<TViewModel>(key);
            }
            return ModuleContainer.Instance.GetInstance<TViewModel>();
        }

        /// <summary>
        /// 指定した Viewmodel を破棄する
        /// </summary>
        /// <typeparam name="TViewModel">破棄する PageViewModel の型</typeparam>
        /// <param name="key">キー</param>
        public static void Discard<TViewModel>(string key = null) where TViewModel : ViewModelBase
        {
            if (string.IsNullOrEmpty(key) && ModuleContainer.Instance.IsRegistered<TViewModel>())
            {
                ModuleContainer.Instance.Discard<TViewModel>();
            }
            else if (!string.IsNullOrEmpty(key) && !ModuleContainer.Instance.IsRegistered<TViewModel>(key))
            {
                ModuleContainer.Instance.Discard<TViewModel>(key);
            }
        }
    }
}