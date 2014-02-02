namespace $safeprojectname$.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// トップ画面の ViewModel
    /// </summary>
    public partial class TopPageViewModel : ViewModelBase, ITopPageViewModel
    {
    }
    
    /// <summary>
    /// トップ画面の ViewModel のインタフェース
    /// </summary>
    public partial interface ITopPageViewModel
    {
    }

}
